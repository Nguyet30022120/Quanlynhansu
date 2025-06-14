using QuanLyNhanSu.DAO;
using QuanLyNhanSu.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLyNhanSu.GUI
{
	public partial class fQuanlybangluongUser : Form
	{
		Color originalCloseButtonColor;
		Color originalTinhLuongButtonColor;
		Color originalXuatBaoCaoButtonColor;

		private List<BangluongDTO> danhSachLuong;

		public fQuanlybangluongUser(string manv)
		{
			InitializeComponent();
			InitializeForm(manv);
			originalCloseButtonColor = btn_close.BackColor;
			originalTinhLuongButtonColor = btn_tinhluong.BackColor;
			originalXuatBaoCaoButtonColor = btn_xuatbaocao.BackColor;
			txb_manhanvien.Text = manv;
			LoadTenNV(manv);
			LoadData(manv);
		}

		private void InitializeForm(string manv)
		{
			LoadInitialData();
			ConfigureDataGridView();
			
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
		private void ConfigureDataGridView()
		{
			dgv_bangluong.AutoGenerateColumns = false;
			dgv_bangluong.Columns.Clear();

			// Cấu hình các cột
			DataGridViewTextBoxColumn colMaNV = new DataGridViewTextBoxColumn();
			colMaNV.Name = "MaNV";
			colMaNV.HeaderText = "Mã nhân viên";
			colMaNV.DataPropertyName = "MaNV";
			colMaNV.Width = 80;
			dgv_bangluong.Columns.Add(colMaNV);

			DataGridViewTextBoxColumn colTenNV = new DataGridViewTextBoxColumn();
			colTenNV.Name = "TenNV";
			colTenNV.HeaderText = "Tên nhân viên";
			colTenNV.DataPropertyName = "TenNV";
			colTenNV.Width = 180;
			dgv_bangluong.Columns.Add(colTenNV);

			DataGridViewTextBoxColumn colThang = new DataGridViewTextBoxColumn();
			colThang.Name = "Thang";
			colThang.HeaderText = "Tháng";
			colThang.DataPropertyName = "Thang";
			colThang.Width = 150;
			dgv_bangluong.Columns.Add(colThang);

			DataGridViewTextBoxColumn colNam = new DataGridViewTextBoxColumn();
			colNam.Name = "Nam";
			colNam.HeaderText = "Năm";
			colNam.DataPropertyName = "Nam";
			colNam.Width = 150;
			dgv_bangluong.Columns.Add(colNam);

			DataGridViewTextBoxColumn colSoGio = new DataGridViewTextBoxColumn();
			colSoGio.Name = "SoGioLam";
			colSoGio.HeaderText = "Giờ làm";
			colSoGio.DataPropertyName = "SoGioLamDisplay";
			colSoGio.Width = 50;
			dgv_bangluong.Columns.Add(colSoGio);

			DataGridViewTextBoxColumn colLuongCB = new DataGridViewTextBoxColumn();
			colLuongCB.Name = "LuongCoBan";
			colLuongCB.HeaderText = "Lương cơ bản";
			colLuongCB.DataPropertyName = "LuongCoBanDisplay";
			colLuongCB.Width = 120;
			dgv_bangluong.Columns.Add(colLuongCB);

			DataGridViewTextBoxColumn colPhucCap = new DataGridViewTextBoxColumn();
			colPhucCap.Name = "PhucCap";
			colPhucCap.HeaderText = "Phụ cấp";
			colPhucCap.DataPropertyName = "PhucCapDisplay";
			colPhucCap.Width = 100;
			colPhucCap.DefaultCellStyle.ForeColor = Color.Black;
			dgv_bangluong.Columns.Add(colPhucCap);

			DataGridViewTextBoxColumn colBaoHiem = new DataGridViewTextBoxColumn();
			colBaoHiem.Name = "BaoHiem";
			colBaoHiem.HeaderText = "Bảo hiểm";
			colBaoHiem.DataPropertyName = "BaoHiemDisplay";
			colBaoHiem.Width = 100;
			dgv_bangluong.Columns.Add(colBaoHiem);

			DataGridViewTextBoxColumn colThue = new DataGridViewTextBoxColumn();
			colThue.Name = "Thue";
			colThue.HeaderText = "Thuế";
			colThue.DataPropertyName = "ThueDisplay";
			colThue.Width = 100;
			dgv_bangluong.Columns.Add(colThue);

			DataGridViewTextBoxColumn colPhat = new DataGridViewTextBoxColumn();
			colPhat.Name = "Phat";
			colPhat.HeaderText = "Phạt";
			colPhat.DataPropertyName = "PhatDisplay";
			colPhat.Width = 100;
			dgv_bangluong.Columns.Add(colPhat);

			DataGridViewTextBoxColumn colThuong = new DataGridViewTextBoxColumn();
			colThuong.Name = "Thuong";
			colThuong.HeaderText = "Thưởng";
			colThuong.DataPropertyName = "ThuongDisplay";
			colThuong.Width = 100;
			dgv_bangluong.Columns.Add(colThuong);

			DataGridViewTextBoxColumn colLuongThucLinh = new DataGridViewTextBoxColumn();
			colLuongThucLinh.Name = "LuongThucLinh";
			colLuongThucLinh.HeaderText = "Lương thực lĩnh";
			colLuongThucLinh.DataPropertyName = "LuongThucLinhDisplay";
			colLuongThucLinh.Width = 130;
			colLuongThucLinh.DefaultCellStyle.ForeColor = Color.Black;
			colLuongThucLinh.DefaultCellStyle.Font = new Font(dgv_bangluong.Font, FontStyle.Bold);
			dgv_bangluong.Columns.Add(colLuongThucLinh);

			

			// Cấu hình giao diện
			dgv_bangluong.AlternatingRowsDefaultCellStyle.BackColor = Color.Tan;
			dgv_bangluong.ColumnHeadersDefaultCellStyle.BackColor = Color.Tan;
			dgv_bangluong.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
			dgv_bangluong.ColumnHeadersDefaultCellStyle.Font = new Font(dgv_bangluong.Font, FontStyle.Bold);
		}

		private void LoadData(string manv)
		{
			string tenNV;
			try
			{

				DataTable dtNhanVien = BangluongDAO.Instance.GetNhanVienTheoMa();
				var rows = dtNhanVien.Select($"Ma_NV = '{manv}'");
				if (rows.Length > 0)
				{
					tenNV = rows[0]["HoTen"].ToString();
				}
				else
				{
					MessageBox.Show("Không tìm thấy nhân viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}

				danhSachLuong = BangluongDAO.Instance.BangLuongNV(manv);
				txb_tennhanvien.Text = tenNV;
				dgv_bangluong.DataSource = danhSachLuong;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Lỗi khi tính lương: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	
		


		void LoadInitialData()
		{
			// Load ComboBox tháng (1-12)
			for (int i = 1; i <= 12; i++)
			{
				cb_thang.Items.Add(i);
			}
			cb_thang.SelectedItem = DateTime.Now.Month;

			// Load ComboBox năm (từ 2020 đến năm hiện tại + 2)
			int currentYear = DateTime.Now.Year;
			for (int i = 2020; i <= currentYear + 2; i++)
			{
				cb_nam.Items.Add(i);
			}

			cb_nam.SelectedItem = currentYear;
			txb_manhanvien.Text = ""; 
			txb_tennhanvien.Text = "";

		}
		private void ExportToCSV(string filePath)
		{
			StringBuilder csv = new StringBuilder();

			// Header thông tin
			csv.AppendLine($"BẢNG LƯƠNG {cb_thang.Text.ToUpper()} {cb_nam.Text}");
			csv.AppendLine($"Ngày xuất: {DateTime.Now:dd/MM/yyyy HH:mm:ss}");
			csv.AppendLine("");

			// Header columns
			csv.AppendLine("Mã NV,Tên nhân viên,Giờ làm,Lương cơ bản,Phụ cấp,Bảo hiểm,Thuế,Phạt,Thưởng,Lương thực lĩnh");

			// Data rows
			foreach (var luong in danhSachLuong)
			{
				csv.AppendLine($"{luong.MaNV},{luong.TenNV},{luong.SoGioLam},{luong.LuongCoBan},{luong.PhucCap},{luong.BaoHiem},{luong.Thue},{luong.Phat},{luong.Thuong},{luong.LuongThucLinh}");
			}

			File.WriteAllText(filePath, csv.ToString(), Encoding.UTF8);
		}
		#region Hover
		private void btn_tinhluong_MouseEnter(object sender, EventArgs e)
		{
			btn_tinhluong.BackColor = Color.LightBlue;
		}
		private void btn_tinhluong_MouseLeave(object sender, EventArgs e)
		{
			btn_tinhluong.BackColor = originalTinhLuongButtonColor;
		}
		private void btn_xuatbaocao_MouseEnter(object sender, EventArgs e)
		{
			btn_xuatbaocao.BackColor = Color.LightBlue;
		}
		private void btn_xuatbaocao_MouseLeave(object sender, EventArgs e)
		{
			btn_xuatbaocao.BackColor = originalXuatBaoCaoButtonColor;
		}
		private void btn_close_MouseEnter(object sender, EventArgs e)
		{
			btn_close.BackColor = Color.LightBlue;
		}
		private void btn_close_MouseLeave(object sender, EventArgs e)
		{
			btn_close.BackColor = originalCloseButtonColor;
		}
		#endregion

		


		#region Events

		private void btn_tinhluong_Click(object sender, EventArgs e)
		{
			if (cb_thang.SelectedItem == null || cb_nam.SelectedItem == null)
			{
				MessageBox.Show("Vui lòng chọn tháng và năm!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			int thang = (int)cb_thang.SelectedItem;
			int nam = (int)cb_nam.SelectedItem;
			string maNV = txb_manhanvien.Text.Trim();
			string tenNV;

			try
			{

					DataTable dtNhanVien = BangluongDAO.Instance.GetNhanVienTheoMa();
					var rows = dtNhanVien.Select($"Ma_NV = '{maNV}'");
					if (rows.Length > 0)
					{
						tenNV = rows[0]["HoTen"].ToString();
					}
					else
					{
						MessageBox.Show("Không tìm thấy nhân viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
						return;
					}

					// Chỉ tính lương cho nhân viên đó
					var luongNV = BangluongDAO.Instance.TinhLuongNhanVien(maNV, thang, nam);
					danhSachLuong = luongNV != null ? new List<BangluongDTO> { luongNV } : new List<BangluongDTO>();
					txb_tennhanvien.Text = tenNV;
					dgv_bangluong.DataSource = danhSachLuong;
		

				MessageBox.Show("Đã tính lương thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Lỗi khi tính lương: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btn_xuatbaocao_Click(object sender, EventArgs e)
		{
			if (danhSachLuong == null || danhSachLuong.Count == 0)
			{
				MessageBox.Show("Không có dữ liệu để xuất báo cáo!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			SaveFileDialog saveDialog = new SaveFileDialog();
			saveDialog.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
			saveDialog.FileName = $"BangLuong_{txb_manhanvien.Text}_{txb_tennhanvien.Text}_{cb_thang.Text}_{cb_nam.Text}_{DateTime.Now:yyyyMMdd_HHmmss}.csv";

			if (saveDialog.ShowDialog() == DialogResult.OK)
			{
				try
				{
					ExportToCSV(saveDialog.FileName);
					MessageBox.Show("Xuất báo cáo thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				catch (Exception ex)
				{
					MessageBox.Show("Lỗi khi xuất báo cáo: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
		}

		private void btn_close_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		#endregion

	}
}
