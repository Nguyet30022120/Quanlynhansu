using QuanLyNhanSu.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanSu.GUI
{
	public partial class fQuanlyketquaphongvan : Form
	{
		private Color originalAddButtonColor;
		private Color originalEditButtonColor;
		private Color originalDeleteButtonColor;
		private Color originalFindButtonColor;
		private Color originalCloseButtonColor;
		private Color originalAcceptButtonColor;

		BindingSource resultList = new BindingSource();
		public fQuanlyketquaphongvan()
		{
			InitializeComponent();
			LoadResult();
			dgv_ketqua.DataSource = resultList;
			BindingResultData();
			LoadCbKetLuan();
			originalAddButtonColor = btn_themketqua.BackColor;
			originalEditButtonColor = btn_suaketqua.BackColor;
			originalDeleteButtonColor = btn_xoaketqua.BackColor;
			originalFindButtonColor = btn_timketqua.BackColor;
			originalCloseButtonColor = btn_dongketqua.BackColor;
			originalAcceptButtonColor = btn_tiepnhan.BackColor;

		}
		void LoadResult()
		{
			resultList.DataSource = KetquaphongvanDAO.Instance.GetListResult();
		}

		void LoadCbKetLuan()
		{
			List<string> diaDiem = new List<string>()
			{
				"Được tuyển", "Không được tuyển"
			};
			cb_ketluan.DataSource = diaDiem;
		}
		void BindingResultData()
		{
			txb_mahoso.DataBindings.Add(new Binding("Text", dgv_ketqua.DataSource, "MaHS", true, DataSourceUpdateMode.Never));
			txb_tenungvien.DataBindings.Add(new Binding("Text", dgv_ketqua.DataSource, "TenUV", true, DataSourceUpdateMode.Never));
			txb_danhgia.DataBindings.Add(new Binding("Text", dgv_ketqua.DataSource, "DanhGia", true, DataSourceUpdateMode.Never));
			dtp_ngaydanhgia.DataBindings.Add(new Binding("Value", dgv_ketqua.DataSource, "NgayDanhGia", true, DataSourceUpdateMode.Never));
			cb_ketluan.DataBindings.Add(new Binding("Text", dgv_ketqua.DataSource, "KetLuan", true, DataSourceUpdateMode.Never));
		}
		#region Events
		private void btn_addkq_Click(object sender, EventArgs e)
		{
			try
			{
				string mahs = txb_mahoso.Text;
				string tenuv = txb_tenungvien.Text;
				string danhgia = txb_danhgia.Text;
				string ketluan = cb_ketluan.Text;
				DateTime ngaydanhgia = dtp_ngaydanhgia.Value;

				if (KetquaphongvanDAO.Instance.InsertResult(mahs, danhgia, ketluan, ngaydanhgia))
				{
					MessageBox.Show("Thêm kết quả phỏng vấn thành công", "Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
					LoadResult();
				}
				else
				{
					MessageBox.Show("Thêm kết quả phỏng vấn thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btn_editkq_Click(object sender, EventArgs e)
		{
			{

				try
				{
					string makq = dgv_ketqua.CurrentRow.Cells["MaKQ"].Value.ToString();
					string tenuv = txb_tenungvien.Text;
					string danhgia = txb_danhgia.Text;
					string ketluan = cb_ketluan.Text;
					DateTime ngaydanhgia = dtp_ngaydanhgia.Value;


					if (KetquaphongvanDAO.Instance.UpdateResult(makq, tenuv, danhgia, ketluan, ngaydanhgia))
					{
						MessageBox.Show("Sửa kết quả phỏng vấn thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
					else
					{
						MessageBox.Show("Sửa kết quả phỏng vấn thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}

				}
				catch (Exception ex)
				{
					MessageBox.Show("Error: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				finally
				{
					LoadResult();
				}
			}
		}

		private void btn_deletekq_Click(object sender, EventArgs e)
		{
			{

				try
				{
					string makq = dgv_ketqua.CurrentRow.Cells["MaKQ"].Value.ToString();


					if (KetquaphongvanDAO.Instance.DeleteResult(makq))
					{
						MessageBox.Show("Xóa kết quả phỏng vấn thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
					else
					{
						MessageBox.Show("Xóa kết quả phỏng vấn thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}

				}
				catch (Exception ex)
				{
					MessageBox.Show("Error: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				finally
				{
					LoadResult();
				}
			}
		}

		private void btn_closekq_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btn_findkq_Click(object sender, EventArgs e)
		{
			resultList.DataSource = KetquaphongvanDAO.Instance.SearchResult(txb_timketqua.Text);
		}

		private void btn_tiepnhan_Click(object sender, EventArgs e)
		{
			string maHoSo = txb_mahoso.Text;
			string email = HosoungvienDAO.Instance.GetEmailByMaHS(maHoSo);


			if (NhanvienDAO.Instance.IsStaffExistsByEmail(email))
			{
				MessageBox.Show("Ứng viên này đã được tiếp nhận trước đó.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				return;
			}

			DialogResult result = MessageBox.Show(
				"Bạn có muốn tạo tài khoản cho ứng viên này luôn không?",
				"Xác nhận",
				MessageBoxButtons.YesNo,
				MessageBoxIcon.Question);

			if (result == DialogResult.Yes)
			{
				using (fQuanlytiepnhannhanvien schedule = new fQuanlytiepnhannhanvien(maHoSo))
				{
					schedule.ShowDialog();
				}
			}
		}

		#endregion

		#region Hover
		private void btn_themketqua_MouseEnter(object sender, EventArgs e)
		{
			btn_themketqua.BackColor = System.Drawing.Color.LightBlue;
		}
		private void btn_themketqua_MouseLeave(object sender, EventArgs e)
		{
			btn_themketqua.BackColor = originalAddButtonColor;
		}
		private void btn_suaketqua_MouseEnter(object sender, EventArgs e)
		{
			btn_suaketqua.BackColor = System.Drawing.Color.LightBlue;
		}
		private void btn_suaketqua_MouseLeave(object sender, EventArgs e)
		{
			btn_suaketqua.BackColor = originalEditButtonColor;
		}
		private void btn_xoaketqua_MouseEnter(object sender, EventArgs e)
		{
			btn_xoaketqua.BackColor = System.Drawing.Color.LightBlue;
		}
		private void btn_xoaketqua_MouseLeave(object sender, EventArgs e)
		{
			btn_xoaketqua.BackColor = originalDeleteButtonColor;
		}
		private void btn_timketqua_MouseEnter(object sender, EventArgs e)
		{
			btn_timketqua.BackColor = System.Drawing.Color.LightBlue;
		}
		private void btn_timketqua_MouseLeave(object sender, EventArgs e)
		{
			btn_timketqua.BackColor = originalFindButtonColor;
		}
		private void btn_dongketqua_MouseEnter(object sender, EventArgs e)
		{
			btn_dongketqua.BackColor = System.Drawing.Color.LightBlue;
		}
		private void btn_dongketqua_MouseLeave(object sender, EventArgs e)
		{
			btn_dongketqua.BackColor = originalCloseButtonColor;
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
