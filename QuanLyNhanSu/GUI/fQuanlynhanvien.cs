using QuanLyNhanSu.DAO;
using QuanLyNhanSu.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanSu
{
	public partial class fQuanlynhanvien : Form
	{
		private Color originalAddButtonColor;
		private Color originalDeleteButtonColor;
		private Color originalFindButtonColor;
		private Color originalCloseButtonColor;
		private Color originalEditButtonColor;

		BindingSource staffList = new BindingSource();

		List<NhanvienDTO> SearchStaff(string value)
		{
			List<NhanvienDTO> listStaff = NhanvienDAO.Instance.SearchStaff(value);

			return listStaff;
		}

		public fQuanlynhanvien()
		{
			InitializeComponent();
			dgv_nhanvien.DataSource = staffList;
			LoadStaff();
			BindingStaffData();
			LoadCbGioiTinh();
			LoadCbPhongBan();
			LoadCbChucVu();
			originalAddButtonColor = btn_themnhanvien.BackColor;
			originalDeleteButtonColor = btn_xoanhanvien.BackColor;
			originalFindButtonColor = btn_timnhanvien.BackColor;
			originalCloseButtonColor = btn_dongnhanvien.BackColor;
			originalEditButtonColor = btn_suanhanvien.BackColor;

		}


		void LoadCbPhongBan()
		{
			cb_cuahang.DataSource = CuahangDAO.Instance.GetListCuaHang();
			cb_cuahang.DisplayMember = "TenCH";
			cb_cuahang.ValueMember = "MaCH";
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
			cb_chucvu.ValueMember = "MaChucVu";
		}
		void BindingStaffData()
		{
			txb_hoten.DataBindings.Add(new Binding("Text", dgv_nhanvien.DataSource, "HoTen", true, DataSourceUpdateMode.Never));
			cb_chucvu.DataBindings.Add(new Binding("Text", dgv_nhanvien.DataSource, "ChucVu", true, DataSourceUpdateMode.Never));
			cb_cuahang.DataBindings.Add(new Binding("Text", dgv_nhanvien.DataSource, "CuaHang", true, DataSourceUpdateMode.Never));
			txb_taikhoan.DataBindings.Add(new Binding("Text", dgv_nhanvien.DataSource, "TaiKhoan", true, DataSourceUpdateMode.Never));
			txb_CCCD.DataBindings.Add(new Binding("Text", dgv_nhanvien.DataSource, "CCCD", true, DataSourceUpdateMode.Never));
			txb_dienthoai.DataBindings.Add(new Binding("Text", dgv_nhanvien.DataSource, "DienThoai", true, DataSourceUpdateMode.Never));
			txb_diachi.DataBindings.Add(new Binding("Text", dgv_nhanvien.DataSource, "DiaChi", true, DataSourceUpdateMode.Never));
			cb_gioitinh.DataBindings.Add(new Binding("Text", dgv_nhanvien.DataSource, "GioiTinh", true, DataSourceUpdateMode.Never));
			dtp_ngaysinh.DataBindings.Add(new Binding("Value", dgv_nhanvien.DataSource, "NgaySinh", true, DataSourceUpdateMode.Never));
			txb_email.DataBindings.Add(new Binding("Text", dgv_nhanvien.DataSource, "Email", true, DataSourceUpdateMode.Never));
		}

		void LoadStaff()
		{
			staffList.DataSource = NhanvienDAO.Instance.GetInforNV();
		}
		#region Hover
		private void btn_themnhanvien_MouseEnter(object sender, EventArgs e)
		{
			btn_themnhanvien.BackColor = Color.LightBlue;
		}
		private void btn_themnhanvien_MouseLeave(object sender, EventArgs e)
		{
			btn_themnhanvien.BackColor = originalAddButtonColor;
		}
		private void btn_suanhanvien_MouseEnter(object sender, EventArgs e)
		{
			btn_suanhanvien.BackColor = Color.LightBlue;
		}

		private void btn_suanhanvien_MouseLeave(object sender, EventArgs e)
		{
			btn_suanhanvien.BackColor = originalEditButtonColor;
		}
		private void btn_xoanhanvien_MouseEnter(object sender, EventArgs e)
		{
			btn_xoanhanvien.BackColor = Color.LightBlue;
		}
		private void btn_xoanhanvien_MouseLeave(object sender, EventArgs e)
		{
			btn_xoanhanvien.BackColor = originalDeleteButtonColor;
		}
		private void btn_timnhanvien_MouseEnter(object sender, EventArgs e)
		{
			btn_timnhanvien.BackColor = Color.LightBlue;
		}
		private void btn_timnhanvien_MouseLeave(object sender, EventArgs e)
		{
			btn_timnhanvien.BackColor = originalFindButtonColor;
		}
		private void btn_dongnhanvien_MouseEnter(object sender, EventArgs e)
		{
			btn_dongnhanvien.BackColor = Color.LightBlue;
		}
		private void btn_dongnhanvien_MouseLeave(object sender, EventArgs e)
		{
			btn_dongnhanvien.BackColor = originalCloseButtonColor;
		}
		#endregion

		#region Events


		private void btn_addnv_Click(object sender, EventArgs e)
		{

			try
			{
				string hoten = txb_hoten.Text;
				int chucvu = Convert.ToInt32(cb_chucvu.SelectedValue);
				string phongban = cb_cuahang.SelectedValue.ToString();
				string taikhoan = txb_taikhoan.Text;
				string cccd = txb_CCCD.Text;
				string dienthoai = txb_dienthoai.Text;
				string diachi = txb_diachi.Text;
				int gioitinh = (int)cb_gioitinh.SelectedValue;
				DateTime ngaysinh = dtp_ngaysinh.Value;
				string email = txb_email.Text;

				if (NhanvienDAO.Instance.InsertStaff(chucvu, phongban, hoten, gioitinh, ngaysinh, cccd, dienthoai, diachi, email))
				{
					MessageBox.Show("Thêm nhân viên thành công.", "Thông báo");
				}
				else
				{
					MessageBox.Show("Thêm nhân viên thất bại.", "Thông báo");
				}

			}
			catch (Exception ex)
			{
				MessageBox.Show("Error: " + ex.Message, "ThongBao", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				LoadStaff();
			}
		}

		private void btn_editnv_Click(object sender, EventArgs e)
		{
			{

				try
				{
					string manv = dgv_nhanvien.CurrentRow.Cells["MaNV"].Value.ToString();
					string hoten = txb_hoten.Text;
					int chucvu = Convert.ToInt32(cb_chucvu.SelectedValue);
					string phongban = cb_cuahang.SelectedValue.ToString();
					string taikhoan = txb_taikhoan.Text;
					string cccd = txb_CCCD.Text;
					string dienthoai = txb_dienthoai.Text;
					string diachi = txb_diachi.Text;
					int gioitinh = (int)cb_gioitinh.SelectedValue;
					DateTime ngaysinh = dtp_ngaysinh.Value;
					string email = txb_email.Text;


					if (NhanvienDAO.Instance.UpdateStaff(manv, chucvu, phongban, hoten, gioitinh, ngaysinh, cccd, dienthoai, diachi, email))
					{
						MessageBox.Show("Sửa nhân viên thành công", "Thông báo");
					}
					else
					{
						MessageBox.Show("Sửa nhân viên thất bại", "Thông báo");
					}

				}
				catch (Exception ex)
				{
					MessageBox.Show("Error: " + ex.Message, "ThongBao", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				finally
				{
					LoadStaff();
				}
			}
		}

		private void btn_deletenv_Click(object sender, EventArgs e)
		{
			{

				try
				{
					string manv = dgv_nhanvien.CurrentRow.Cells["MaNV"].Value.ToString();


					if (NhanvienDAO.Instance.DeleteStaff(manv))
					{
						MessageBox.Show("Xóa nhân viên thành công","Thông báo");
					}
					else
					{
						MessageBox.Show("Xóa nhân viên thất bại", "Thông báo");
					}

				}
				catch (Exception ex)
				{
					MessageBox.Show("Error: " + ex.Message, "ThongBao", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				finally
				{
					LoadStaff();
				}
			}
		}

		private void btn_findnv_Click(object sender, EventArgs e)
		{
			staffList.DataSource = SearchStaff(txb_timnhanvien.Text);
		}

		private void btn_closenv_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		#endregion


	}
}
