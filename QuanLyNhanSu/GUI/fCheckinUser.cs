﻿using QuanLyNhanSu.DAO;
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
	public partial class fCheckinUser : Form
	{
		private Color originalAddButtonColor;
		private Color originalDeleteButtonColor;
		private Color originalCloseButtonColor;

		BindingSource checkinList = new BindingSource();
		public fCheckinUser(string manv)
		{
			InitializeComponent();
			dgv_checkin.DataSource = checkinList;
			txb_manhanvien.Text = manv;
			lb_giocheckin.Text = DateTime.Now.ToLongTimeString();
			timer_giocheckin.Start();
			var col = dgv_checkin.Columns["GioCheckIn"];
			if (col != null)
				col.DefaultCellStyle.Format = "HH:mm:ss";
			LoadCheckIn(manv);
			originalAddButtonColor = btn_checkin.BackColor;
			originalDeleteButtonColor = btn_xoacheckin.BackColor;
			originalCloseButtonColor = btn_dongcheckin.BackColor;
			LoadTenNV(manv);

		}

		private void timer1_Tick(object sender, EventArgs e)
		{
			lb_giocheckin.Text = DateTime.Now.ToLongTimeString();
		}
		void LoadTenNV(string manv)
		{
			string tenNV = NhanvienDAO.Instance.GetStaffTen(manv);

			if (string.IsNullOrEmpty(tenNV))
			{
				MessageBox.Show("Không có mã nhân viên trong hệ thống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
				txb_tennhanvien.Text = "";
			}
			else
			{
				txb_tennhanvien.Text = tenNV;
			}
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

		#region Events

		private void btn_checkin_Click(object sender, EventArgs e)
		{
			try
			{
				string manv = txb_manhanvien.Text;
				// Kiểm tra nhân viên đã check-in hôm nay chưa
				var list = CheckinDAO.Instance.GetCheckInByMaNV(manv);
				bool daCheckIn = list.Any(c => c.NgayCheckIn.Date == DateTime.Now.Date);

				if (daCheckIn)
				{
					MessageBox.Show("Nhân viên đã check-in hôm nay!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}

				if (CheckinDAO.Instance.InsertCheckIn(manv))
				{
					MessageBox.Show("Thêm checkin thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
					LoadCheckIn(txb_manhanvien.Text);
				}
				else
				{
					MessageBox.Show("Thêm checkin thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Hãy nhập mã nhân viên", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				LoadCheckIn(txb_manhanvien.Text);
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
					MessageBox.Show("Xóa checkin thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
					LoadCheckIn(txb_manhanvien.Text);
				}
				else
				{
					MessageBox.Show("Xóa checkin thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				LoadCheckIn(txb_manhanvien.Text);
			}
		}
		#endregion

		#region Hover

		private void btn_checkin_MouseEnter(object sender, EventArgs e)
		{
			btn_checkin.BackColor = Color.LightBlue;
		}
		private void btn_checkin_MouseLeave(object sender, EventArgs e)
		{
			btn_checkin.BackColor = originalAddButtonColor;
		}
		private void btn_xoacheckin_MouseEnter(object sender, EventArgs e)
		{
			btn_xoacheckin.BackColor = Color.LightBlue;
		}
		private void btn_xoacheckin_MouseLeave(object sender, EventArgs e)
		{
			btn_xoacheckin.BackColor = originalDeleteButtonColor;
		}
		private void btn_dongcheckin_MouseEnter(object sender, EventArgs e)
		{
			btn_dongcheckin.BackColor = Color.LightBlue;
		}
		private void btn_dongcheckin_MouseLeave(object sender, EventArgs e)
		{
			btn_dongcheckin.BackColor = originalCloseButtonColor;
		}
		#endregion
	}
}

