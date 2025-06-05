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
		}
		void LoadSchedule()
		{
			scheduleList.DataSource = LichphongvanDAO.Instance.GetSchedule();
		}
		void BindingscheduleData()
		{
			//txb_mapv.DataBindings.Add(new Binding("Text", dgv_lichpv.DataSource, "MaPV", true, DataSourceUpdateMode.Never));
			txb_tenungvien.DataBindings.Add(new Binding("Text", dgv_lichphongvan.DataSource, "TenUV", true, DataSourceUpdateMode.Never));
			dtp_ngayphongvan.DataBindings.Add(new Binding("Value", dgv_lichphongvan.DataSource, "NgayPV", true, DataSourceUpdateMode.Never));
			dtp_giophongvan.DataBindings.Add(new Binding("Value", dgv_lichphongvan.DataSource, "ThoiGianPV", true, DataSourceUpdateMode.Never));
			cb_diadiem.DataBindings.Add(new Binding("Text", dgv_lichphongvan.DataSource, "DiaDiem", true, DataSourceUpdateMode.Never));
			cb_trangthai.DataBindings.Add(new Binding("Text", dgv_lichphongvan.DataSource, "TrangThai", true, DataSourceUpdateMode.Never));
			txb_nguoiphongvan.DataBindings.Add(new Binding("Text", dgv_lichphongvan.DataSource, "NguoiPV", true, DataSourceUpdateMode.Never));
			txb_mahoso.DataBindings.Add(new Binding("Text", dgv_lichphongvan.DataSource, "MaHS", true, DataSourceUpdateMode.Never));
		}
		private void LoadStaffNames()
		{
			staffNames = NhanvienDAO.Instance.GetStaffName();
		}
		void LoadCbDiaDiem()
		{
			List<string> diaDiem = new List<string>()
			{
				"Phòng 1", "Phòng 2", "Phòng 3", "Phòng 4", "Phòng 5"
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
					MessageBox.Show("Thêm lịch phỏng vấn thành công");
					LoadSchedule();
				}
				else
				{
					MessageBox.Show("Thêm lịch phỏng vấn thất bại");
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
						MessageBox.Show("Sửa lịch phỏng vấn thành công.");
					}
					else
					{
						MessageBox.Show("Sửa lịch phỏng vấn thất bại.");
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
						MessageBox.Show("Xóa lịch phỏng vấn thành công.");
					}
					else
					{
						MessageBox.Show("Xóa lịch phỏng vấn thất bại.");
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


		private void btn_findlichpv_Click(object sender, EventArgs e)
		{
			scheduleList.DataSource = LichphongvanDAO.Instance.SearchSchedule(txb_findlichpv.Text);
		}

	}
}

