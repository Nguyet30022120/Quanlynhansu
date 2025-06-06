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
	public partial class fTaolichphongvan : Form
	{
		private List<string> staffNames;

		void LoadSchedule()
		{
			scheduleList.DataSource = LichphongvanDAO.Instance.GetSchedule();
		}

		BindingSource scheduleList = new BindingSource();

		public fTaolichphongvan(string tenuv, string mahs)
		{
			InitializeComponent();
			txb_tenuv.Text = tenuv;
			txb_mahs.Text = mahs;
			LoadCbDiaDiem();
			LoadStaffNames(); 
			SetupAutoCompleteForNguoiPV(); 
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

		private void btn_close_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btn_addlichpv_Click(object sender, EventArgs e)
		{
			try
			{
				string tenuv = txb_tenuv.Text;
				string mahs = txb_mahs.Text;
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

	}
}
