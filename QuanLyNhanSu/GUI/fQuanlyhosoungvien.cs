using QuanLyNhanSu.DAO;
using QuanLyNhanSu.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanSu.GUI
{
	public partial class fQuanlyhosoungvien : Form
	{
		private Color originalAddButtonColor;
		private Color originalEditButtonColor;
		private Color originalDeleteButtonColor;
		private Color originalFindButtonColor;
		private Color originalCloseButtonColor;
		private Color originalAcceptButtonColor;

		BindingSource profileList = new BindingSource();

		public fQuanlyhosoungvien()
		{
			InitializeComponent();
			dgv_hoso.DataSource = profileList;
			LoadProfile();
			BindingStaffData();
			LoadCbGioiTinh();
			LoadCbChucVu();
			LoadCbNguonUV();
			originalAddButtonColor = btn_themhoso.BackColor;
			originalDeleteButtonColor = btn_xoahoso.BackColor;
			originalEditButtonColor = btn_suahoso.BackColor;
			originalFindButtonColor = btn_timhoso.BackColor;
			originalCloseButtonColor = btn_donghoso.BackColor;
			originalAcceptButtonColor = btn_tiepnhan.BackColor;
		}

		void LoadCbGioiTinh()
		{
			List<KeyValuePair<int, string>> gioitinh = new List<KeyValuePair<int, string>>()
			{
				new KeyValuePair<int, string>(1, "Nam"),
				new KeyValuePair<int, string>(0, "Nữ")
			};
			cb_gioitinh.DataSource = gioitinh;
			cb_gioitinh.DisplayMember = "Value";
			cb_gioitinh.ValueMember = "Key";
		}
		void LoadCbChucVu()
		{
			cb_chucvu.DataSource = ChucvuDAO.Instance.GetListChucVu();
			cb_chucvu.DisplayMember = "TenChucVu";
		}

		void LoadCbNguonUV()
		{
			cb_nguonungvien.DataSource = NguonungvienDAO.Instance.GetListSource();
			cb_nguonungvien.DisplayMember = "TenNguon";
		}

		void BindingStaffData()
		{
			txb_hoten.DataBindings.Add(new Binding("Text", dgv_hoso.DataSource, "HoTen", true, DataSourceUpdateMode.Never));
			cb_chucvu.DataBindings.Add(new Binding("Text", dgv_hoso.DataSource, "ChucVu", true, DataSourceUpdateMode.Never));
			txb_dienthoai.DataBindings.Add(new Binding("Text", dgv_hoso.DataSource, "DienThoai", true, DataSourceUpdateMode.Never));
			cb_gioitinh.DataBindings.Add(new Binding("Text", dgv_hoso.DataSource, "GioiTinh", true, DataSourceUpdateMode.Never));
			dtp_ngaysinh.DataBindings.Add(new Binding("Value", dgv_hoso.DataSource, "NgaySinh", true, DataSourceUpdateMode.Never));
			txb_email.DataBindings.Add(new Binding("Text", dgv_hoso.DataSource, "Email", true, DataSourceUpdateMode.Never));
			txb_chitietcv.DataBindings.Add(new Binding("Text", dgv_hoso.DataSource, "ChiTietCV", true, DataSourceUpdateMode.Never));
			cb_nguonungvien.DataBindings.Add(new Binding("Text", dgv_hoso.DataSource, "NguonUV", true, DataSourceUpdateMode.Never));
		}

		void LoadProfile()
		{
			profileList.DataSource = HosoungvienDAO.Instance.GetProfile();
		}
		#region Events
		private void btn_addhs_Click(object sender, EventArgs e)
		{
			try
			{
				string hoten = txb_hoten.Text;
				string tenchucvu = cb_chucvu.Text;
				string tennguon = cb_nguonungvien.Text;
				int gioitinh = (int)cb_gioitinh.SelectedValue;
				DateTime ngaysinh = dtp_ngaysinh.Value;
				string dienthoai = txb_dienthoai.Text;
				string chitietcv = txb_chitietcv.Text;
				string email = txb_email.Text;

				if (HosoungvienDAO.Instance.InsertProfile(hoten, tenchucvu, gioitinh, ngaysinh, tennguon, dienthoai, chitietcv, email))
				{
					MessageBox.Show("Thêm hồ sơ ứng viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
					LoadProfile();
				}
				else
				{
					MessageBox.Show("Thêm hồ sơ ứng viên thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				LoadProfile();
			}
		}

		private void btn_ediths_Click(object sender, EventArgs e)
		{
			{

				try
				{
					string mahs = dgv_hoso.CurrentRow.Cells["Ma_HS"].Value.ToString();
					string hoten = txb_hoten.Text;
					string tenchucvu = cb_chucvu.Text;
					int gioitinh = (int)cb_gioitinh.SelectedValue;
					DateTime ngaysinh = dtp_ngaysinh.Value;
					string tennguon = cb_nguonungvien.Text;
					string dienthoai = txb_dienthoai.Text;
					string chitietcv = txb_chitietcv.Text;
					string email = txb_email.Text;

					if (HosoungvienDAO.Instance.UpdateProfile(mahs, hoten, tenchucvu, gioitinh, ngaysinh, tennguon, dienthoai, chitietcv, email))
					{
						MessageBox.Show("Sửa hồ sơ ứng viên thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
					else
					{
						MessageBox.Show("Sửa hồ sơ ứng viên thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}

				}
				catch (Exception ex)
				{
					MessageBox.Show("Error: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				finally
				{
					LoadProfile();
				}
			}
		}

		private void btn_deletehs_Click(object sender, EventArgs e)
		{
			{

				try
				{
					string mahs = dgv_hoso.CurrentRow.Cells["Ma_HS"].Value.ToString();


					if (HosoungvienDAO.Instance.DeleteProfile(mahs))
					{
						MessageBox.Show("Xóa hồ sơ thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
					else
					{
						MessageBox.Show("Xóa hồ sơ thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}

				}
				catch (Exception ex)
				{
					MessageBox.Show("Ứng viên này đã được tiếp nhận! Hãy lưu trữ hồ sơ của ứng viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				finally
				{
					LoadProfile();
				}
			}
		}

		private void btn_closehs_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btn_findhs_Click(object sender, EventArgs e)
		{
			profileList.DataSource = HosoungvienDAO.Instance.SearchProfile(txb_findhs.Text);
		}

		private void btn_tiepnhan_Click(object sender, EventArgs e)
		{
			string mahs = dgv_hoso.CurrentRow.Cells["Ma_HS"].Value.ToString();

			// Kiểm tra nếu ứng viên đã được tiếp nhận (đã có lịch phỏng vấn)
			if (LichphongvanDAO.Instance.IsProfileAccepted(mahs))
			{
				MessageBox.Show("Ứng viên này đã được tiếp nhận trước đó!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}

			DialogResult result = MessageBox.Show("Bạn có muốn tạo lịch phỏng vấn cho ứng viên này luôn không?",
										"Xác nhận",
										MessageBoxButtons.YesNoCancel,
										MessageBoxIcon.Question);

			if (result == DialogResult.Yes)
			{
				string tenuv = txb_hoten.Text;
				fTaolichphongvan schedule = new fTaolichphongvan(tenuv, mahs);
				schedule.ShowDialog();

				LoadProfile();
			}
		}
		#endregion

		#region Hover
		private void btn_addhs_MouseEnter(object sender, EventArgs e)
		{
			btn_themhoso.BackColor = System.Drawing.Color.LightBlue;
		}
		private void btn_addhs_MouseLeave(object sender, EventArgs e)
		{
			btn_themhoso.BackColor = originalAddButtonColor;
		}
		private void btn_ediths_MouseEnter(object sender, EventArgs e)
		{
			btn_suahoso.BackColor = System.Drawing.Color.LightBlue;
		}
		private void btn_ediths_MouseLeave(object sender, EventArgs e)
		{
			btn_suahoso.BackColor = originalEditButtonColor;
		}
		private void btn_deletehs_MouseEnter(object sender, EventArgs e)
		{
			btn_xoahoso.BackColor = System.Drawing.Color.LightBlue;
		}
		private void btn_deletehs_MouseLeave(object sender, EventArgs e)
		{
			btn_xoahoso.BackColor = originalDeleteButtonColor;
		}
		private void btn_findhs_MouseEnter(object sender, EventArgs e)
		{
			btn_timhoso.BackColor = System.Drawing.Color.LightBlue;
		}
		private void btn_findhs_MouseLeave(object sender, EventArgs e)
		{
			btn_timhoso.BackColor = originalFindButtonColor;
		}
		private void btn_closehs_MouseEnter(object sender, EventArgs e)
		{
			btn_donghoso.BackColor = System.Drawing.Color.LightBlue;
		}
		private void btn_closehs_MouseLeave(object sender, EventArgs e)
		{
			btn_donghoso.BackColor = originalCloseButtonColor;
		}
		private void btn_tiepnhan_MouseEnter(object sender, EventArgs e)
		{
			btn_tiepnhan.BackColor = System.Drawing.Color.LightBlue;
		}
		private void btn_tiepnhan_MouseLeave(object sender, EventArgs e)
		{
			btn_tiepnhan.BackColor = originalAcceptButtonColor;

		}
		#endregion

	}
}

