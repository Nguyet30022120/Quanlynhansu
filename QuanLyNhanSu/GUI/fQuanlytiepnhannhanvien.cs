﻿using QuanLyNhanSu.DAO;
using QuanLyNhanSu.DTO;
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
	public partial class fQuanlytiepnhannhanvien : Form
	{
		private List<string> staffNames;
		BindingSource candidateList = new BindingSource();
		BindingSource staffList = new BindingSource();

		public fQuanlytiepnhannhanvien(string candidateName)
		{
			InitializeComponent();
			profileList.DataSource = HosoungvienDAO.Instance.GetProfileByTenUV(candidateName);
			LoadCbChucVu();
			LoadCbGioiTinh();
			LoadCbPhongBan();
			LoadDataHS(candidateName);
		}
		void LoadDataHS(string candidatename)
		{
			List<HosoungvienDTO> data = HosoungvienDAO.Instance.GetProfileByTenUV(candidatename);

			if (data.Count > 0)
			{
				HosoungvienDTO profile = data[0];
				txb_hoten.Text = profile.HoTen;
				txb_dienthoai.Text = profile.DienThoai;
				txb_email.Text = profile.Email;
				cb_chucvu.Text = profile.ChucVu;
				cb_gioitinh.Text = profile.GioiTinh == 1 ? "Nam" : "Nữ";
				dtp_ngaysinh.Value = profile.NgaySinh;
			}
			else
			{
				MessageBox.Show("Không tìm thấy dữ liệu ứng viên.");
			}
		}
		void LoadStaff()
		{
			staffList.DataSource = NhanvienDAO.Instance.GetInforNV();
		}

		BindingSource scheduleList = new BindingSource();
		BindingSource profileList = new BindingSource();



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

		void LoadCbPhongBan()
		{
			cb_phongban.DataSource = PhongbanDAO.Instance.GetListPhongBan();
			cb_phongban.DisplayMember = "TenPB";
			cb_phongban.ValueMember = "MaPB";
		}
		private void btn_close_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btn_addnv_Click(object sender, EventArgs e)
		{
			try
			{
				string hoten = txb_hoten.Text;
				int chucvu = Convert.ToInt32(cb_chucvu.SelectedValue);
				string phongban = cb_phongban.SelectedValue.ToString();
				string cccd = txb_cccd.Text;
				string dienthoai = txb_dienthoai.Text;
				string diachi = txb_diachi.Text;
				int gioitinh = (int)cb_gioitinh.SelectedValue;
				DateTime ngaysinh = dtp_ngaysinh.Value;
				string email = txb_email.Text;

				if (NhanvienDAO.Instance.IsStaffExistsByEmail(email))
				{
					MessageBox.Show("Ứng viên này đã được tiếp nhận trước đó.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
					return;
				}

				if (NhanvienDAO.Instance.InsertStaff(chucvu, phongban, hoten, gioitinh, ngaysinh, cccd, dienthoai, diachi, email))
				{
					MessageBox.Show("Thêm nhân viên thành công.");
				}
				else
				{
					MessageBox.Show("Thêm nhân viên thất bại.");
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

		private void btn_closenv_Click(object sender, EventArgs e)
		{
			this.Close();
		}


	}
}
