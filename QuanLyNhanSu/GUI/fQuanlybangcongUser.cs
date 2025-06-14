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
	public partial class fQuanlybangcongUser : Form
	{
		Color originalStatisticButtonColor;
		Color originalExportButtonColor;
		Color originalCloseButtonColor;

		private List<Button> dayButtons = new List<Button>();
		private List<BangcongDTO> currentBangCongData = new List<BangcongDTO>();

		public fQuanlybangcongUser(string manv)
		{
			InitializeComponent();
			LoadInitialData(manv);
			CreateCalendarView();
			LoadBangCongTheoMaNV(manv);
			originalStatisticButtonColor = btn_xem.BackColor;
			originalExportButtonColor = btn_xuatbaocao.BackColor;
			originalCloseButtonColor = btn_close.BackColor;
			txb_manhanvien.Text = manv;
			LoadTenNV(manv);
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

		void LoadInitialData(string manv)
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
			txb_manhanvien.Text = manv; // Hiển thị mã nhân viên ngay khi vào form
		}

		void CreateCalendarView()
		{
			pn_days.Controls.Clear();
			dayButtons.Clear();

			if (cb_thang.SelectedItem == null || cb_nam.SelectedItem == null)
				return;

			int thang = (int)cb_thang.SelectedItem;
			int nam = (int)cb_nam.SelectedItem;

			// Tạo header cho thứ trong tuần
			string[] daysOfWeek = { "Chủ Nhật", "Thứ Hai", "Thứ Ba", "Thứ Tư", "Thứ Năm", "Thứ Sáu", "Thứ Bảy" };

			int buttonWidth = 200;  
			int buttonHeight = 100; 
			int padding = 10;       
			int startX = 20;
			int startY = 20;

			// Tạo header thứ trong tuần
			for (int i = 0; i < daysOfWeek.Length; i++)
			{
				Label lblDay = new Label();
				lblDay.Text = daysOfWeek[i];
				lblDay.Size = new Size(buttonWidth, 40);
				lblDay.Location = new Point(startX + i * (buttonWidth + padding), startY);
				lblDay.TextAlign = ContentAlignment.MiddleCenter;
				lblDay.Font = new Font("Segoe UI", 12, FontStyle.Bold);
				lblDay.BackColor = Color.DarkOrange;
				lblDay.ForeColor = Color.White;
				lblDay.BorderStyle = BorderStyle.FixedSingle;
				pn_days.Controls.Add(lblDay);
			}

			// Tính toán ngày đầu tháng là thứ mấy
			DateTime firstDay = new DateTime(nam, thang, 1);
			int dayOfWeek = (int)firstDay.DayOfWeek; // 0=CN, 1=T2, ..., 6=T7
			int daysInMonth = DateTime.DaysInMonth(nam, thang);

			// Tạo các button cho ngày trong tháng
			int currentRow = 1;
			int currentCol = dayOfWeek;

			// Tính toán tổng chiều cao cần thiết cho việc scroll
			int totalRows = (int)Math.Ceiling((double)(daysInMonth + dayOfWeek) / 7);
			int totalHeight = startY + 45 + (totalRows * (buttonHeight + padding)) + 50;
			pn_days.AutoScrollMinSize = new Size(7 * (buttonWidth + padding) + 40, totalHeight);

			for (int day = 1; day <= daysInMonth; day++)
			{
				Button btnDay = new Button();
				btnDay.Size = new Size(buttonWidth, buttonHeight);
				btnDay.Location = new Point(startX + currentCol * (buttonWidth + padding),
										   startY + 45 + (currentRow - 1) * (buttonHeight + padding));
				btnDay.Font = new Font("Segoe UI", 16, FontStyle.Bold);
				btnDay.FlatStyle = FlatStyle.Flat;
				btnDay.FlatAppearance.BorderSize = 3;
				btnDay.FlatAppearance.BorderColor = Color.DarkGray;
				btnDay.Tag = day; // Lưu ngày vào Tag
				btnDay.TextAlign = ContentAlignment.TopCenter;

				// Mặc định màu đỏ (chưa chấm công)
				btnDay.BackColor = Color.OrangeRed;
				btnDay.ForeColor = Color.White;
				btnDay.Text = day.ToString();

				// Event click để hiển thị chi tiết ngày
				btnDay.Click += BtnDay_Click;

				// Tooltip hiển thị thông tin nhanh
				ToolTip toolTip = new ToolTip();
				toolTip.SetToolTip(btnDay, $"Ngày {day}/{thang}/{nam}\nClick để xem chi tiết chấm công");

				pn_days.Controls.Add(btnDay);
				dayButtons.Add(btnDay);

				currentCol++;
				if (currentCol >= 7)
				{
					currentCol = 0;
					currentRow++;
				}
			}

			// Cập nhật màu sắc dựa trên dữ liệu chấm công
			UpdateCalendarColors();
		}

	

		void UpdateCalendarColors()
		{
			try
			{
				if (currentBangCongData == null || !currentBangCongData.Any())
					return;

				// Lấy dữ liệu chấm công nhóm theo ngày
				var attendanceByDay = currentBangCongData
				.Where(x => x.SoGioLam > 0)
				.GroupBy(x => new { x.MaNV, Ngay = x.Ngay.Date }) 
				.Select(g => g.First()) 
				.GroupBy(x => x.Ngay.Day) 
				.ToDictionary(g => g.Key, g => g.ToList());

				foreach (Button btn in dayButtons)
				{
					int day = (int)btn.Tag;

					if (attendanceByDay.ContainsKey(day))
					{
						var dayData = attendanceByDay[day];

						// Màu xanh lá cây - có chấm công
						btn.BackColor = Color.LightGreen;
						btn.ForeColor = Color.White;

						// Tạo text hiển thị thông tin chi tiết
						StringBuilder btnText = new StringBuilder();
						btnText.AppendLine($"📅 {day}");
						btnText.AppendLine($"👥 {dayData.Count} NV");

						if (dayData.Count == 1)
						{
							// Hiển thị thông tin chi tiết cho 1 nhân viên
							var nv = dayData.First();
							btnText.AppendLine($"⏰ {nv.GioCheckInDisplay}");
							btnText.AppendLine($"🏁 {nv.GioCheckOutDisplay}");
							btnText.AppendLine($"🕐 {nv.SoGioLamDisplay}h");
						}
						else if (dayData.Count <= 3)
						{
							// Hiển thị danh sách ngắn gọn cho <= 3 nhân viên
							foreach (var nv in dayData.Take(2))
							{
								btnText.AppendLine($"• {nv.MaNV}");
							}
							if (dayData.Count > 2)
							{
								btnText.AppendLine("• ...");
							}
						}
						else
						{
							// Hiển thị tóm tắt cho nhiều nhân viên
							btnText.AppendLine($"⏰ {dayData.First().GioCheckInDisplay}-{dayData.First().GioCheckOutDisplay}");
							btnText.AppendLine($"📊 Xem chi tiết");
						}

						btn.Text = btnText.ToString().Trim();
						btn.Font = new Font("Segoe UI", 10, FontStyle.Regular);
						btn.TextAlign = ContentAlignment.TopLeft;
					}
					else
					{
						// Màu đỏ - không có chấm công
						btn.BackColor = Color.OrangeRed;
						btn.ForeColor = Color.White;
						btn.Text = $"📅 {day}\n\n❌ Chưa\nchấm công";
						btn.Font = new Font("Segoe UI", 12, FontStyle.Bold);
						btn.TextAlign = ContentAlignment.MiddleCenter;
					}

					// Thêm hiệu ứng hover
					btn.FlatAppearance.MouseOverBackColor = btn.BackColor == Color.LightGreen ?
						Color.Green : Color.Crimson;
				}
			}
			catch (Exception ex)
			{
			}
		}
		void LoadBangCongTheoMaNV(string maNV)
		{
			if (cb_thang.SelectedItem == null ||
		cb_nam.SelectedItem == null)
			{
				MessageBox.Show("Vui lòng chọn đầy đủ tháng, năm để xem thống kê.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			int thang = (int)cb_thang.SelectedItem;
			int nam = (int)cb_nam.SelectedItem;

			// Hiển thị tên nhân viên nếu có
			string tenNV = "";
			if (!string.IsNullOrEmpty(maNV))
			{
				DataTable dtNhanVien = BangcongDAO.Instance.GetDanhSachNhanVienCoChamCong();
				var rows = dtNhanVien.Select($"Ma_NV = '{maNV}'");

				if (rows.Length > 0)
				{
					tenNV = rows[0]["HoTen"].ToString();
				}
			}
			txb_tennhanvien.Text = tenNV;

			// Tải dữ kiện chấm công
			List<BangcongDTO> bangCongData;
			if (string.IsNullOrEmpty(maNV))
				bangCongData = BangcongDAO.Instance.GetBangCongTheoThang(thang, nam);
			else
				bangCongData = BangcongDAO.Instance.GetBangCongNhanVienTheoThang(maNV, thang, nam);

			currentBangCongData = bangCongData;

			CalculateStatistics(bangCongData, maNV);
			UpdateCalendarColors();
			CreateCalendarView();
		}

		void CalculateStatistics(List<BangcongDTO> data, string maNV)
		{
			try
			{
				var filteredData = data
					.GroupBy(x => new { x.MaNV, Ngay = x.Ngay.Date })
					.Select(g => g.First()) 
					.ToList();

				if (string.IsNullOrEmpty(maNV))
				{
					// Thống kê tất cả nhân viên
					int tongNgayLam = filteredData.Count(x => x.SoGioLam > 0);
					double tongGioLam = filteredData.Sum(x => x.SoGioLam);
					int tongNgayVang = filteredData.Count(x => x.SoGioLam == 0);

					lb_tonggio.Text = tongGioLam.ToString("0.0") + " giờ";
		
				}
				else
				{
					// Chỉ lọc và thống kê cho 1 nhân viên
					var nvData = filteredData.Where(x => x.MaNV == maNV).ToList();

					int tongNgayLam = nvData.Count(x => x.SoGioLam > 0);
					double tongGioLam = nvData.Sum(x => x.SoGioLam);
					int tongNgayVang = nvData.Count(x => x.SoGioLam == 0);

					lb_tonggio.Text = tongGioLam.ToString("0.0") + " giờ";
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Lỗi khi tính thống kê: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		
		private void ExportToCSV(string filePath)
		{
			StringBuilder csv = new StringBuilder();

			// Header
			csv.AppendLine("Mã NV,Tên nhân viên,Ngày,Giờ vào,Giờ ra,Số giờ làm");

			// Data
			foreach (BangcongDTO item in currentBangCongData)
			{
				csv.AppendLine($"{item.MaNV},{item.TenNV},{item.NgayDisplay},{item.GioCheckInDisplay},{item.GioCheckOutDisplay},{item.SoGioLamDisplay}");
			}

			// Summary
			csv.AppendLine("");
			csv.AppendLine("THỐNG KÊ:");
			csv.AppendLine($"Tổng số giờ làm việc:,{lb_tonggio.Text}");

			System.IO.File.WriteAllText(filePath, csv.ToString(), Encoding.UTF8);
		}
		#region Events
		private void btn_close_Click(object sender, EventArgs e)
		{
			this.Close();
		}

	
		private void btn_xem_Click(object sender, EventArgs e)
		{
			string maNV = txb_manhanvien.Text.Trim();
			LoadBangCongTheoMaNV(maNV);

		}
		private void btn_xuatbaocao_Click(object sender, EventArgs e)
		{
			try
			{
				// Xuất báo cáo (có thể dùng Excel hoặc PDF)
				SaveFileDialog saveDialog = new SaveFileDialog();
				saveDialog.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
				saveDialog.FileName = $"BangCong_{txb_manhanvien.Text}_{txb_tennhanvien.Text}_{cb_thang.SelectedItem}_{cb_nam.SelectedItem}.csv";

				if (saveDialog.ShowDialog() == DialogResult.OK)
				{
					ExportToCSV(saveDialog.FileName);
					MessageBox.Show("Xuất báo cáo thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Lỗi khi xuất báo cáo: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		private void BtnDay_Click(object sender, EventArgs e)
		{
			Button btn = sender as Button;
			int day = (int)btn.Tag;
			int thang = (int)cb_thang.SelectedItem;
			int nam = (int)cb_nam.SelectedItem;

			DateTime selectedDate = new DateTime(nam, thang, day);

			// Lọc dữ liệu theo ngày được chọn
			var filteredData = currentBangCongData
				.Where(x => x.Ngay.Date == selectedDate.Date)
				.GroupBy(x => new { x.MaNV, x.GioCheckInDisplay, x.GioCheckOutDisplay })
				.Select(g => g.First())
				.ToList();


			if (filteredData.Any())
			{
				StringBuilder info = new StringBuilder();
				info.AppendLine($"📅 THÔNG TIN CHẤM CÔNG NGÀY {selectedDate:dd/MM/yyyy}");
				info.AppendLine(new string('=', 50));
				info.AppendLine();

				foreach (var item in filteredData)
				{
					info.AppendLine($"👤 {item.TenNV} ({item.MaNV})");
					info.AppendLine($"   ⏰ Giờ vào: {item.GioCheckInDisplay}");
					info.AppendLine($"   ⏰ Giờ ra: {item.GioCheckOutDisplay}");
					info.AppendLine($"   🕐 Số giờ làm: {item.SoGioLamDisplay}");
					info.AppendLine();
				}

				MessageBox.Show(info.ToString(), "Chi tiết chấm công", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			else
			{
				MessageBox.Show($"Không có dữ liệu chấm công cho ngày {selectedDate:dd/MM/yyyy}",
							   "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
		}
		#endregion
		#region Hovers
		private void btn_thongke_MouseEnter(object sender, EventArgs e)
		{
			btn_xem.BackColor = Color.LightBlue;
		}
		private void btn_thongke_MouseLeave(object sender, EventArgs e)
		{
			btn_xem.BackColor = originalStatisticButtonColor;
		}
		private void btn_xuatbaocao_MouseEnter(object sender, EventArgs e)
		{
			btn_xuatbaocao.BackColor = Color.LightBlue;
		}
		private void btn_xuatbaocao_MouseLeave(object sender, EventArgs e)
		{
			btn_xuatbaocao.BackColor = originalExportButtonColor;
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
	}

}
