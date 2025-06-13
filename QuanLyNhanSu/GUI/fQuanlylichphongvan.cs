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
	public partial class fQuanlylichphongvan : Form
	{
		private Color originalAddButtonColor;
		private Color originalEditButtonColor;
		private Color originalDeleteButtonColor;
		private Color originalFindButtonColor;
		private Color originalCloseButtonColor;


		BindingSource scheduleList = new BindingSource();

		private List<string> staffNames = new List<string>();
		public fQuanlylichphongvan()
		{
			InitializeComponent();
			dgv_lichphongvan.DataSource = scheduleList;
			BindingscheduleData();
			LoadSchedule();
			LoadCbTrangThai();
			LoadCbDiaDiem();
			LoadStaffNames();
			SetupAutoCompleteForNguoiPV();
			originalAddButtonColor = btn_themlichphongvan.BackColor;
			originalEditButtonColor = btn_sualichphongvan.BackColor;
			originalDeleteButtonColor = btn_xoalichphongvan.BackColor;
			originalFindButtonColor = btn_timlichphongvan.BackColor;
			originalCloseButtonColor = btn_donglichphongvan.BackColor;
		}
		void LoadSchedule()
		{
			scheduleList.DataSource = LichphongvanDAO.Instance.GetSchedule();
		}
		void BindingscheduleData()
		{
			txb_tenungvien.DataBindings.Add(new Binding("Text", dgv_lichphongvan.DataSource, "TenUV", true, DataSourceUpdateMode.Never));
			dtp_ngayphongvan.DataBindings.Add(new Binding("Value", dgv_lichphongvan.DataSource, "NgayPV", true, DataSourceUpdateMode.Never));
			dtp_giophongvan.DataBindings.Add(new Binding("Value", dgv_lichphongvan.DataSource, "ThoiGianPV", true, DataSourceUpdateMode.Never));
			cb_diadiem.DataBindings.Add(new Binding("Text", dgv_lichphongvan.DataSource, "DiaDiem", true, DataSourceUpdateMode.Never));
			cb_trangthai.DataBindings.Add(new Binding("Text", dgv_lichphongvan.DataSource, "TrangThai", true, DataSourceUpdateMode.Never));
			txb_nguoiphongvan.DataBindings.Add(new Binding("Text", dgv_lichphongvan.DataSource, "NguoiPV", true, DataSourceUpdateMode.Never));
			txb_mahoso.DataBindings.Add(new Binding("Text", dgv_lichphongvan.DataSource, "MaHS", true, DataSourceUpdateMode.Never));
		}
		private void dgv_lichphongvan_SelectionChanged(object sender, EventArgs e)
		{
			if (dgv_lichphongvan.CurrentRow != null)
			{
				var value = dgv_lichphongvan.CurrentRow.Cells["ThoiGianPV"].Value?.ToString();
				if (TimeSpan.TryParse(value, out TimeSpan time))
				{
					dtp_giophongvan.Value = DateTime.Today.Add(time);
				}
			}
		}
		private void LoadStaffNames()
		{
			staffNames = NhanvienDAO.Instance.GetStaffName();
		}
		void LoadCbDiaDiem()
		{
			List<string> diaDiem = new List<string>()
			{
				"Cửa hàng 1", "Cửa hàng 2", "Cửa hàng 3", "Cửa hàng 4", "Cửa hàng 5"
			};
			cb_diadiem.DataSource = diaDiem;
		}
		private void SetupAutoCompleteForNguoiPV()
		{
			var autoComplete = new AutoCompleteStringCollection();
			autoComplete.AddRange(staffNames.ToArray());

			txb_nguoiphongvan.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			txb_nguoiphongvan.AutoCompleteSource = AutoCompleteSource.CustomSource;
			txb_nguoiphongvan.AutoCompleteCustomSource = autoComplete;
		}
		void LoadCbTrangThai()
		{
			List<string> trangThai = new List<string>()
			{
				"Đã hẹn", "Chưa hẹn", "Đã hủy", "Đã phỏng vấn"
			};
			cb_trangthai.DataSource = trangThai;
		}
		#region Events
		private void btn_addlich_Click(object sender, EventArgs e)
		{
			try
			{
				string mahs = txb_mahoso.Text;
				string tenuv = txb_tenungvien.Text;
				string nguoipv = txb_nguoiphongvan.Text;
				DateTime ngaypv = dtp_ngayphongvan.Value;
				DateTime thoigianpv = dtp_giophongvan.Value;
				string diadiem = cb_diadiem.Text;

				if (LichphongvanDAO.Instance.InsertSchedule(mahs, nguoipv, ngaypv, thoigianpv, diadiem))
				{
					MessageBox.Show("Thêm lịch phỏng vấn thành công","Thông báo");
					LoadSchedule();
				}
				else
				{
					MessageBox.Show("Thêm lịch phỏng vấn thất bại", "Thông báo");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btn_editlichpv_Click(object sender, EventArgs e)
		{
			{

				try
				{
					string mapv = dgv_lichphongvan.CurrentRow.Cells["MaPV"].Value.ToString();
					string nguoipv = txb_nguoiphongvan.Text;
					DateTime ngaypv = dtp_ngayphongvan.Value;
					DateTime thoigianpv = dtp_giophongvan.Value;
					string diadiem = cb_diadiem.Text;
					string trangthai = cb_trangthai.Text;


					if (LichphongvanDAO.Instance.UpdateSchedule(mapv, nguoipv, ngaypv, thoigianpv, diadiem, trangthai))
					{
						MessageBox.Show("Sửa lịch phỏng vấn thành công.", "Thông báo");
					}
					else
					{
						MessageBox.Show("Sửa lịch phỏng vấn thất bại.", "Thông báo");
					}

				}
				catch (Exception ex)
				{
					MessageBox.Show("Error: " + ex.Message, "ThongBao", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				finally
				{
					LoadSchedule();
				}
			}
		}

		private void btn_deletelichpv_Click(object sender, EventArgs e)
		{
			{

				try
				{
					string mapv = dgv_lichphongvan.CurrentRow.Cells["MaPV"].Value.ToString();

					if (LichphongvanDAO.Instance.DeleteSchedule(mapv))
					{
						MessageBox.Show("Xóa lịch phỏng vấn thành công.", "Thông báo");
					}
					else
					{
						MessageBox.Show("Xóa lịch phỏng vấn thất bại.", "Thông báo");
					}

				}
				catch (Exception ex)
				{
					MessageBox.Show("Error: " + ex.Message, "ThongBao", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				finally
				{
					LoadSchedule();
				}
			}
		}

		private void btn_closelichpv_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		#endregion

		#region Hover
		private void btn_findlichpv_Click(object sender, EventArgs e)
		{
			scheduleList.DataSource = LichphongvanDAO.Instance.SearchSchedule(txb_findlichpv.Text);
		}
		private void btn_themlichphongvan_MouseEnter(object sender, EventArgs e)
		{
			btn_themlichphongvan.BackColor = System.Drawing.Color.LightBlue;
		}
		private void btn_themlichphongvan_MouseLeave(object sender, EventArgs e)
		{
			btn_themlichphongvan.BackColor = originalAddButtonColor;
		}
		private void btn_sualichphongvan_MouseEnter(object sender, EventArgs e)
		{
			btn_sualichphongvan.BackColor = System.Drawing.Color.LightBlue;
		}
		private void btn_sualichphongvan_MouseLeave(object sender, EventArgs e)
		{
			btn_sualichphongvan.BackColor = originalEditButtonColor;
		}
		private void btn_xoalichphongvan_MouseEnter(object sender, EventArgs e)
		{
			btn_xoalichphongvan.BackColor = System.Drawing.Color.LightBlue;
		}
		private void btn_xoalichphongvan_MouseLeave(object sender, EventArgs e)
		{
			btn_xoalichphongvan.BackColor = originalDeleteButtonColor;
		}
		private void btn_timlichphongvan_MouseEnter(object sender, EventArgs e)
		{
			btn_timlichphongvan.BackColor = System.Drawing.Color.LightBlue;
		}
		private void btn_timlichphongvan_MouseLeave(object sender, EventArgs e)
		{
			btn_timlichphongvan.BackColor = originalFindButtonColor;
		}
		private void btn_donglichphongvan_MouseEnter(object sender, EventArgs e)
		{
			btn_donglichphongvan.BackColor = System.Drawing.Color.LightBlue;
		}
		private void btn_donglichphongvan_MouseLeave(object sender, EventArgs e)
		{
			btn_donglichphongvan.BackColor = originalCloseButtonColor;
		}
		#endregion


	}
}

