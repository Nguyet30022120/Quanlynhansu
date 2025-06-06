﻿using QuanLyNhanSu.DAO;
using QuanLyNhanSu.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanSu.GUI
{
	public partial class fBangcong : Form
	{
		private List<Button> dayButtons = new List<Button>();
		private List<BangcongDTO> currentBangCongData = new List<BangcongDTO>();

		public fBangcong()
		{
			InitializeComponent();
			LoadInitialData();
			CreateCalendarView();
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

			// Load ComboBox nhân viên
			LoadNhanVien();
		}

		void LoadNhanVien()
		{
			// Lấy danh sách nhân viên từ DAO
			DataTable dtNhanVien = BangcongDAO.Instance.GetDanhSachNhanVienCoChamCong();
			
			// Thêm option "Tất cả nhân viên"
			DataRow allRow = dtNhanVien.NewRow();
			allRow["Ma_NV"] = "";
			allRow["HoTen"] = "-- Tất cả nhân viên --";
			dtNhanVien.Rows.InsertAt(allRow, 0);

			cb_nhanvien.DataSource = dtNhanVien;
			cb_nhanvien.DisplayMember = "HoTen";
			cb_nhanvien.ValueMember = "Ma_NV";
			cb_nhanvien.SelectedIndex = 0;
		}

		void CreateCalendarView()
		{
			panel_days.Controls.Clear();
			dayButtons.Clear();

			if (cb_thang.SelectedItem == null || cb_nam.SelectedItem == null)
				return;

			int thang = (int)cb_thang.SelectedItem;
			int nam = (int)cb_nam.SelectedItem;

			// Tạo header cho thứ trong tuần
			string[] daysOfWeek = { "Chủ Nhật", "Thứ Hai", "Thứ Ba", "Thứ Tư", "Thứ Năm", "Thứ Sáu", "Thứ Bảy" };
			
			// Kích thước cố định cho các ô to hơn
			int buttonWidth = 200;  // Tăng kích thước từ ~150 lên 180
			int buttonHeight = 100; // Tăng kích thước từ ~80 lên 120
			int padding = 10;       // Tăng khoảng cách
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
				panel_days.Controls.Add(lblDay);
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
			panel_days.AutoScrollMinSize = new Size(7 * (buttonWidth + padding) + 40, totalHeight);

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
				btnDay.BackColor = Color.LightCoral;
				btnDay.ForeColor = Color.White;
				btnDay.Text = day.ToString();

				// Event click để hiển thị chi tiết ngày
				btnDay.Click += BtnDay_Click;

				// Tooltip hiển thị thông tin nhanh
				ToolTip toolTip = new ToolTip();
				toolTip.SetToolTip(btnDay, $"Ngày {day}/{thang}/{nam}\nClick để xem chi tiết chấm công");

				panel_days.Controls.Add(btnDay);
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
				MessageBox.Show($"❌ Không có dữ liệu chấm công cho ngày {selectedDate:dd/MM/yyyy}", 
							   "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
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
					.GroupBy(x => x.Ngay.Day)
					.ToDictionary(g => g.Key, g => g.ToList());

				// Cập nhật màu và thông tin cho các button
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
				// Không hiển thị lỗi để tránh gián đoạn UI
			}
		}

		void LoadBangCong()
		{
			int thang = (int)cb_thang.SelectedItem;
			int nam = (int)cb_nam.SelectedItem;
			string maNV = cb_nhanvien.SelectedValue?.ToString();

			List<BangcongDTO> bangCongData = new List<BangcongDTO>();

			if (string.IsNullOrEmpty(maNV))
			{
				// Hiển thị tất cả nhân viên
				bangCongData = BangcongDAO.Instance.GetBangCongTheoThang(thang, nam);
			}
			else
			{
				// Hiển thị một nhân viên cụ thể
				bangCongData = BangcongDAO.Instance.GetBangCongNhanVienTheoThang(maNV, thang, nam);
			}

			currentBangCongData = bangCongData;
			CalculateStatistics(bangCongData, maNV);
			UpdateCalendarColors(); // Cập nhật màu calendar

			// Thống kê chi tiết
			var tongGioLam = bangCongData.Sum(x => x.SoGioLam);
			var tongNgayLam = bangCongData.Count(x => x.SoGioLam > 0);
			var nhanVienCount = bangCongData.Select(x => x.MaNV).Distinct().Count();

			string thongBao = $"✅ TẢI THÀNH CÔNG BẢNG CHẤM CÔNG!\n\n";
			thongBao += $"📅 Tháng {thang}/{nam}\n";
			thongBao += $"👥 Số nhân viên: {nhanVienCount}\n";
			thongBao += $"📝 Số bản ghi: {bangCongData.Count}\n";
			thongBao += $"🕐 Tổng giờ làm: {tongGioLam:F1} giờ\n";
			thongBao += $"📆 Tổng ngày làm: {tongNgayLam} ngày\n\n";
			
			if (bangCongData.Any())
			{
				// Kiểm tra xem có dữ liệu SoGioLam > 0 trước khi tính min/max
				var validWorkHours = bangCongData.Where(x => x.SoGioLam > 0).ToList();
				
				if (validWorkHours.Any())
				{
					var maxGio = validWorkHours.Max(x => x.SoGioLam);
					var minGio = validWorkHours.Min(x => x.SoGioLam);
					thongBao += $"📊 THỐNG KÊ CHI TIẾT:\n";
					thongBao += $"   • Giờ làm cao nhất: {maxGio:F1} giờ\n";
					thongBao += $"   • Giờ làm thấp nhất: {minGio:F1} giờ\n";
					thongBao += $"   • Giờ làm trung bình: {(tongGioLam/Math.Max(tongNgayLam,1)):F1} giờ/ngày\n\n";
				}
				else
				{
					thongBao += $"📊 THỐNG KÊ CHI TIẾT:\n";
					thongBao += $"   • Chưa có dữ liệu giờ làm việc hợp lệ\n";
					thongBao += $"   • Tất cả bản ghi có SoGioLam = 0\n\n";
				}
			}
			else
			{
				thongBao = $"❌ KHÔNG TÌM THẤY DỮ LIỆU CHẤM CÔNG!\n\n";
				thongBao += $"📅 Tháng {thang}/{nam}\n";
				thongBao += $"👤 Nhân viên: {(string.IsNullOrEmpty(maNV) ? "Tất cả" : maNV)}\n\n";
				thongBao += $"💡 Vui lòng kiểm tra:\n";
				thongBao += $"   • Dữ liệu CheckIn có tồn tại không\n";
				thongBao += $"   • Tháng/năm có đúng không\n";
				thongBao += $"   • Nhân viên có dữ liệu chấm công không\n\n";
				thongBao += $"🔍 Sử dụng nút 'Test DB' để kiểm tra kết nối!";
			}
			
			thongBao += $"\n💡 Mẹo: Click vào ngày trong lịch để xem chi tiết!";

			MessageBox.Show(thongBao, "Thông báo", MessageBoxButtons.OK, 
				(bangCongData.Any() ? MessageBoxIcon.Information : MessageBoxIcon.Warning));
		}

		void CalculateStatistics(List<BangcongDTO> data, string maNV)
		{
			try
			{
				if (string.IsNullOrEmpty(maNV))
				{
					// Thống kê tất cả nhân viên
					var groupedData = data.GroupBy(x => x.MaNV).ToList();
					int tongNgayLam = groupedData.Sum(g => g.Count(x => x.SoGioLam > 0));
					double tongGioLam = data.Sum(x => x.SoGioLam);
					int tongNgayVang = groupedData.Sum(g => g.Count(x => x.SoGioLam == 0));

					lbl_tonggio.Text = tongGioLam.ToString("0.0") + " giờ";
					lbl_tongngaylam.Text = tongNgayLam.ToString() + " ngày";
					lbl_tongngayvang.Text = tongNgayVang.ToString() + " ngày";
				}
				else
				{
					// Thống kê một nhân viên
					int tongNgayLam = data.Count(x => x.SoGioLam > 0);
					double tongGioLam = data.Sum(x => x.SoGioLam);
					int tongNgayVang = data.Count(x => x.SoGioLam == 0);

					lbl_tonggio.Text = tongGioLam.ToString("0.0") + " giờ";
					lbl_tongngaylam.Text = tongNgayLam.ToString() + " ngày";
					lbl_tongngayvang.Text = tongNgayVang.ToString() + " ngày";
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Lỗi khi tính thống kê: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btn_xem_Click(object sender, EventArgs e)
		{
			LoadBangCong();
		}

		// Thêm nút debug test
		private void btn_test_debug_Click(object sender, EventArgs e)
		{
			try
			{
				DataTable testData = BangcongDAO.Instance.TestConnection();
				
				if (testData.Rows.Count > 0)
				{
					StringBuilder sb = new StringBuilder();
					sb.AppendLine("🔍 TEST KẾT NỐI DATABASE");
					sb.AppendLine("✅ Kết nối thành công!");
					sb.AppendLine($"📊 Tìm thấy {testData.Rows.Count} bản ghi:");
					sb.AppendLine(new string('-', 50));
					
					foreach (DataRow row in testData.Rows)
					{
						if (testData.Columns.Contains("Error"))
						{
							sb.AppendLine($"❌ {row["Error"]}");
						}
						else
						{
							sb.AppendLine($"🆔 Mã NV: {row["Ma_NV"]}");
							sb.AppendLine($"👤 Tên: {row["HoTen"]}");
							sb.AppendLine($"📅 Ngày: {row["NgayCheckIn"]}");
							sb.AppendLine($"⏰ Giờ vào: {row["ThoiGianCheckIn"]}");
							sb.AppendLine($"⏰ Giờ ra: {(row.IsNull("ThoiGianCheckOut") ? "Chưa checkout" : row["ThoiGianCheckOut"].ToString())}");
							sb.AppendLine(new string('-', 30));
						}
					}
					
					MessageBox.Show(sb.ToString(), "🔍 Debug Test Results", 
						MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				else
				{
					MessageBox.Show("❌ Không tìm thấy dữ liệu CheckIn/CheckOut cho tháng 5/2025.\n\n" +
						"Vui lòng kiểm tra:\n" +
						"1. Kết nối database\n" +
						"2. Dữ liệu trong bảng CheckIn\n" +
						"3. Tên cột trong database", 
						"⚠️ Debug Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show($"💥 Lỗi khi test kết nối:\n{ex.Message}\n\nChi tiết: {ex.StackTrace}", 
					"❌ Debug Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btn_xuatbaocao_Click(object sender, EventArgs e)
		{
			try
			{
				// Xuất báo cáo (có thể dùng Excel hoặc PDF)
				SaveFileDialog saveDialog = new SaveFileDialog();
				saveDialog.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
				saveDialog.FileName = $"BangCong_{cb_thang.SelectedItem}_{cb_nam.SelectedItem}.csv";

				if (saveDialog.ShowDialog() == DialogResult.OK)
				{
					ExportToCSV(saveDialog.FileName);
					MessageBox.Show("✅ Xuất báo cáo thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Lỗi khi xuất báo cáo: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
			csv.AppendLine($"Tổng số giờ làm việc:,{lbl_tonggio.Text}");
			csv.AppendLine($"Tổng số ngày làm:,{lbl_tongngaylam.Text}");
			csv.AppendLine($"Tổng số ngày vắng:,{lbl_tongngayvang.Text}");

			System.IO.File.WriteAllText(filePath, csv.ToString(), Encoding.UTF8);
		}

		private void btn_close_Click(object sender, EventArgs e)
		{
			this.Close();
		}

        private void cb_nhanvien_SelectedIndexChanged(object sender, EventArgs e)
        {
			// Tự động tải lại dữ liệu khi thay đổi nhân viên
			if (cb_thang.SelectedItem != null && cb_nam.SelectedItem != null)
			{
				LoadBangCong();
			}
        }

		private void cb_thang_SelectedIndexChanged(object sender, EventArgs e)
		{
			// Tạo lại calendar khi thay đổi tháng
			CreateCalendarView();
			if (cb_nam.SelectedItem != null)
			{
				LoadBangCong();
			}
		}

		private void cb_nam_SelectedIndexChanged(object sender, EventArgs e)
		{
			// Tạo lại calendar khi thay đổi năm
			CreateCalendarView();
			if (cb_thang.SelectedItem != null)
			{
				LoadBangCong();
			}
		}

	}
}
