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
using QuanLyNhanSu.GUI;

namespace QuanLyNhanSu.GUI
{
	public partial class fCheckIn : Form
	{
		BindingSource checkinList = new BindingSource();
		public fCheckIn()
		{
			InitializeComponent();
			dgv_checkin.DataSource = checkinList;
			lb_giocheckin.Text = DateTime.Now.ToLongTimeString();
			//dgv_checkin.Columns["GioCheckIn"].DefaultCellStyle.Format = "HH:mm:ss";


			timer1.Start();
			//lb_tennhanvien.Text="Ten_nhan_vien";
			var col = dgv_checkin.Columns["GioCheckIn"];
			if (col != null)
				col.DefaultCellStyle.Format = "HH:mm:ss";
		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			lb_giocheckin.Text = DateTime.Now.ToLongTimeString();
		}
		void LoadTenNV()
		{
			

			txb_tennv.DataBindings.Clear();
			txb_tennv.DataBindings.Add(new Binding("Text", dgv_checkin.DataSource, "TenNV", true, DataSourceUpdateMode.Never));
		}
		void LoadCheckIn(string manv)
		{
			checkinList.DataSource = CheckinDAO.Instance.GetCheckInByMaNV(manv);
		}
		private void dgv_checkin_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			if (dgv_checkin.Columns[e.ColumnIndex].Name == "GioCheckIn")
			{
				if (e.Value is TimeSpan ts)
				{
					e.Value = ts.ToString(@"hh\:mm\:ss");
					e.FormattingApplied = true;
				}
			}
		}


		private void btn_findnv_Click(object sender, EventArgs e)
		{
			try
			{
				LoadCheckIn(txb_manhanvien.Text);
				LoadTenNV();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Lỗi tìm kiếm nhân viên: " + ex.Message, "ThongBao", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btn_checkin_Click(object sender, EventArgs e)
		{
			try
			{
				string manv = txb_manhanvien.Text;
				if (CheckinDAO.Instance.InsertCheckIn(manv))
				{
					MessageBox.Show("Thêm checkin thành công");
					LoadCheckIn(txb_manhanvien.Text);
				}
				else
				{
					MessageBox.Show("Thêm checkin thất bại");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error: " + ex.Message, "ThongBao", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				LoadCheckIn(txb_manhanvien.Text);
			}
		}

		private void btn_editcheckin_Click(object sender, EventArgs e)
		{
			DialogResult result = MessageBox.Show("Bạn có muốn sửa checkin cho nhân viên này?",
										"Xác nhận",
										MessageBoxButtons.YesNo,
										MessageBoxIcon.Question);

			if (result == DialogResult.Yes)
			{
				string manv = txb_manhanvien.Text;
				fSuaCheckin editCheckin = new fSuaCheckin(manv);
				editCheckin.ShowDialog();
			}
			else if (result == DialogResult.No)
			{
			}
		}

		private void btn_closecheckin_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btn_deletecheckin_Click(object sender, EventArgs e)
		{
			try
			{
				int macheckin = Convert.ToInt32(dgv_checkin.CurrentRow.Cells["MaCheckIn"].Value);
				if (CheckinDAO.Instance.DeleteCheckIn(macheckin))
				{
					MessageBox.Show("Xóa checkin thành công");
					LoadCheckIn(txb_manhanvien.Text);
				}
				else
				{
					MessageBox.Show("Xóa checkin thất bại");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error: " + ex.Message, "ThongBao", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				LoadCheckIn(txb_manhanvien.Text);
			}
		}

	}
}