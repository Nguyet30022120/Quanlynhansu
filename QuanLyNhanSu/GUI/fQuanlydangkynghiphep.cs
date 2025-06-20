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
using QuanLyNhanSu.GUI;


namespace QuanLyNhanSu.GUI
{
	public partial class fQuanlydangkynghiphep : Form
	{
		private Color originalAddButtonColor;
		private Color originalDeleteButtonColor;
		private Color originalCloseButtonColor;
		private Color originalSearchButtonColor;
		private Color originalEditButtonColor;

		BindingSource donNghiPhepList = new BindingSource();

		private List<string> staffNames = new List<string>();
		public fQuanlydangkynghiphep()
		{
			InitializeComponent();
			dgv_donnghiphep.DataSource = donNghiPhepList;
			LoadDonNghiPhep(txb_manhanvien.Text);
			LoadStaffNames();
			LoadCbLoaiPhep();
			SetupAutoCompleteForNguoiDuyet();
			LoadCbTrangThai();
			originalAddButtonColor = btn_themdonnghiphep.BackColor;
			originalDeleteButtonColor = btn_xoadonnghiphep.BackColor;
			originalCloseButtonColor = btn_dongdonnghiphep.BackColor;
			originalSearchButtonColor = btn_timnhanvien.BackColor;
			originalEditButtonColor = btn_suadonnghiphep.BackColor;

		}
		void BindingDonNghiPhepData()
		{
			txb_tennhanvien.DataBindings.Clear();
			cb_loaiphep.DataBindings.Clear();
			txb_lydo.DataBindings.Clear();
			dtp_ngaybatdau.DataBindings.Clear();
			dtp_ngayketthuc.DataBindings.Clear();
			cb_trangthai.DataBindings.Clear();
			txb_nguoiduyet.DataBindings.Clear();

			txb_tennhanvien.DataBindings.Add(new Binding("Text", dgv_donnghiphep.DataSource, "TenNV", true, DataSourceUpdateMode.Never));
			cb_loaiphep.DataBindings.Add(new Binding("Text", dgv_donnghiphep.DataSource, "LoaiPhep", true, DataSourceUpdateMode.Never));
			txb_lydo.DataBindings.Add(new Binding("Text", dgv_donnghiphep.DataSource, "LyDo", true, DataSourceUpdateMode.Never));
			dtp_ngaybatdau.DataBindings.Add(new Binding("Value", dgv_donnghiphep.DataSource, "NgayBD", true, DataSourceUpdateMode.Never));
			dtp_ngayketthuc.DataBindings.Add(new Binding("Value", dgv_donnghiphep.DataSource, "NgayKT", true, DataSourceUpdateMode.Never));
			cb_trangthai.DataBindings.Add(new Binding("Text", dgv_donnghiphep.DataSource, "TrangThai", true, DataSourceUpdateMode.Never));
			txb_nguoiduyet.DataBindings.Add(new Binding("Text", dgv_donnghiphep.DataSource, "NguoiDuyet", true, DataSourceUpdateMode.Never));

		}

		void LoadDonNghiPhep(string manv)
		{
			donNghiPhepList.DataSource = DonnghiphepDAO.Instance.GetDonNghiPhep(manv);
			BindingDonNghiPhepData();
		}
		private void LoadStaffNames()
		{
			staffNames = NhanvienDAO.Instance.GetStaffName();
		}
		void LoadCbLoaiPhep()
		{
			List<string> loaiPhep = new List<string>()
			{
				"Nghỉ không lương", "Nghỉ ốm", "Nghỉ phép năm", "Nghỉ thai sản", "Nghỉ việc riêng", "Nghỉ việc khác"
			};
			cb_loaiphep.DataSource = loaiPhep;
		}
		private void SetupAutoCompleteForNguoiDuyet()
		{
			var autoComplete = new AutoCompleteStringCollection();
			autoComplete.AddRange(staffNames.ToArray());

			txb_nguoiduyet.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			txb_nguoiduyet.AutoCompleteSource = AutoCompleteSource.CustomSource;
			txb_nguoiduyet.AutoCompleteCustomSource = autoComplete;
		}
		void LoadCbTrangThai()
		{
			List<string> trangThai = new List<string>()
			{
				"Chờ duyệt", "Đã duyệt", "Từ chối"
			};
			cb_trangthai.DataSource = trangThai;
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

		#region Events
		private void btn_findnv_Click(object sender, System.EventArgs e)
		{
			string manv = txb_manhanvien.Text;
			LoadDonNghiPhep(manv);
			if (!string.IsNullOrEmpty(manv))
			{
				LoadTenNV(manv);
			}
		}

		private void btn_adddonnghiphep_Click(object sender, System.EventArgs e)
		{
			string manv = txb_manhanvien.Text;
			try
			{
				string tennv = txb_tennhanvien.Text;
				string loaiphep = cb_loaiphep.Text;
				string trangthai = cb_trangthai.Text;
				string lydo = txb_lydo.Text;
				DateTime ngaybd = dtp_ngaybatdau.Value;
				DateTime ngaykt = dtp_ngayketthuc.Value;
				string nguoiduyet = txb_nguoiduyet.Text;

				if (DonnghiphepDAO.Instance.InsertDonNghiPhep(manv,loaiphep,trangthai,lydo,ngaybd,ngaykt,nguoiduyet))
				{
					MessageBox.Show("Thêm đơn nghỉ phép thành công", "Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
					LoadDonNghiPhep(manv);
				}
				else
				{
					MessageBox.Show("Thêm đơn nghỉ phép thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				LoadDonNghiPhep(manv);
			}
		}

		private void btn_editdonnghiphep_Click(object sender, EventArgs e)
		{
			string manv = txb_manhanvien.Text;
			try
			{
				int madonnghiphep = Convert.ToInt32(dgv_donnghiphep.CurrentRow.Cells["MaDonNghiPhep"].Value);
				string tennv = txb_tennhanvien.Text;
				string loaiphep = cb_loaiphep.Text;
				string trangthai = cb_trangthai.Text;
				string lydo = txb_lydo.Text;
				DateTime ngaybd = dtp_ngaybatdau.Value;
				DateTime ngaykt = dtp_ngayketthuc.Value;
				string nguoiduyet = txb_nguoiduyet.Text;

				if (DonnghiphepDAO.Instance.UpdateDonNghiPhep(madonnghiphep, tennv, loaiphep, trangthai, lydo, ngaybd, ngaykt, nguoiduyet))
				{
					MessageBox.Show("Sửa đơn nghỉ phép thành công", "Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
					LoadDonNghiPhep(manv);
				}
				else
				{
					MessageBox.Show("Sửa đơn nghỉ phép thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				LoadDonNghiPhep(manv);
			}
		}

		private void btn_deletedonnghiphep_Click(object sender, EventArgs e)
		{
			string manv = txb_manhanvien.Text;
			try
			{
				int madonnghiphep = Convert.ToInt32(dgv_donnghiphep.CurrentRow.Cells["MaDonNghiPhep"].Value);

				if (DonnghiphepDAO.Instance.DeleteDonNghiPhep(madonnghiphep))
				{
					MessageBox.Show("Xóa đơn nghỉ phép thành công", "Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
					LoadDonNghiPhep(manv);
				}
				else
				{
					MessageBox.Show("Xóa đơn nghỉ phép thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error: " + ex.Message, "ThongBao", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				LoadDonNghiPhep(manv);
			}
		}

		private void btn_closedonnghiphep_Click(object sender, EventArgs e)
		{
			this.Close();
		}
		#endregion

		#region Hover
		private void btn_themdonnghiphep_MouseEnter(object sender, EventArgs e)
		{
			btn_themdonnghiphep.BackColor = Color.LightBlue;
		}
		private void btn_themdonnghiphep_MouseLeave(object sender, EventArgs e)
		{
			btn_themdonnghiphep.BackColor = originalAddButtonColor;
		}
		private void btn_xoadonnghiphep_MouseEnter(object sender, EventArgs e)
		{
			btn_xoadonnghiphep.BackColor = Color.LightBlue;
		}
		private void btn_xoadonnghiphep_MouseLeave(object sender, EventArgs e)
		{
			btn_xoadonnghiphep.BackColor = originalDeleteButtonColor;
		}
		private void btn_dongdonnghiphep_MouseEnter(object sender, EventArgs e)
		{
			btn_dongdonnghiphep.BackColor = Color.LightBlue;
		}
		private void btn_dongdonnghiphep_MouseLeave(object sender, EventArgs e)
		{
			btn_dongdonnghiphep.BackColor = originalCloseButtonColor;
		}
		private void btn_timnhanvien_MouseEnter(object sender, EventArgs e)
		{
			btn_timnhanvien.BackColor = Color.LightBlue;
		}
		private void btn_timnhanvien_MouseLeave(object sender, EventArgs e)
		{
			btn_timnhanvien.BackColor = originalSearchButtonColor;
		}
		private void btn_suadonnghiphep_MouseEnter(object sender, EventArgs e)
		{
			btn_suadonnghiphep.BackColor = Color.LightBlue;
		}
		private void btn_suadonnghiphep_MouseLeave(object sender, EventArgs e)
		{
			btn_suadonnghiphep.BackColor = originalEditButtonColor;
		}
		#endregion
	}
}
