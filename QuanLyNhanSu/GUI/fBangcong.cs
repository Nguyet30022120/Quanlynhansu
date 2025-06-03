using QuanLyNhanSu.DAO;
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
			try
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
			catch (Exception ex)
			{
				// Fallback với dữ liệu test
				DataTable dtNhanVien = new DataTable();
				dtNhanVien.Columns.Add("Ma_NV");
				dtNhanVien.Columns.Add("HoTen");
				
				DataRow allRow = dtNhanVien.NewRow();
				allRow["Ma_NV"] = "";
				allRow["HoTen"] = "-- Tất cả nhân viên --";
				dtNhanVien.Rows.Add(allRow);

				// Thêm danh sách nhân viên test
				dtNhanVien.Rows.Add("NV001", "Nguyễn Văn A");
				dtNhanVien.Rows.Add("NV002", "Trần Thị B");
				dtNhanVien.Rows.Add("NV003", "Lê Văn C");
				dtNhanVien.Rows.Add("NV004", "Phạm Thị D");
				dtNhanVien.Rows.Add("NV005", "Hoàng Văn E");

				cb_nhanvien.DataSource = dtNhanVien;
				cb_nhanvien.DisplayMember = "HoTen";
				cb_nhanvien.ValueMember = "Ma_NV";
				cb_nhanvien.SelectedIndex = 0;
			}
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
			int buttonWidth = 180;  // Tăng kích thước từ ~150 lên 180
			int buttonHeight = 120; // Tăng kích thước từ ~80 lên 120
			int padding = 15;       // Tăng khoảng cách
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
				lblDay.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);
				lblDay.BackColor = Color.DarkBlue;
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
				btnDay.Font = new Font("Microsoft Sans Serif", 16, FontStyle.Bold);
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
						btn.BackColor = Color.LimeGreen;
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
						btn.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
						btn.TextAlign = ContentAlignment.TopLeft;
					}
					else
					{
						// Màu đỏ - không có chấm công
						btn.BackColor = Color.LightCoral;
						btn.ForeColor = Color.White;
						btn.Text = $"📅 {day}\n\n❌ Chưa\nchấm công";
						btn.Font = new Font("Microsoft Sans Serif", 12, FontStyle.Bold);
						btn.TextAlign = ContentAlignment.MiddleCenter;
					}
					
					// Thêm hiệu ứng hover
					btn.FlatAppearance.MouseOverBackColor = btn.BackColor == Color.LimeGreen ? 
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
			try
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
					var maxGio = bangCongData.Max(x => x.SoGioLam);
					var minGio = bangCongData.Where(x => x.SoGioLam > 0).Min(x => x.SoGioLam);
					thongBao += $"📊 THỐNG KÊ CHI TIẾT:\n";
					thongBao += $"   • Giờ làm cao nhất: {maxGio:F1} giờ\n";
					thongBao += $"   • Giờ làm thấp nhất: {minGio:F1} giờ\n";
					thongBao += $"   • Giờ làm trung bình: {(tongGioLam/Math.Max(tongNgayLam,1)):F1} giờ/ngày\n\n";
				}
				
				thongBao += $"💡 Mẹo: Click vào ngày trong lịch để xem chi tiết!";

				MessageBox.Show(thongBao, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			catch (Exception ex)
			{
				MessageBox.Show("⚠️ KHÔNG THỂ TẢI DỮ LIỆU THỰC\n\nChuyển sang chế độ DEMO với dữ liệu mẫu\n\nLý do: " + ex.Message, 
					"Cảnh báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				
				// Hiển thị dữ liệu test với nhiều ngày khác nhau
				var testData = new List<BangcongDTO>();
				
				int thang = (int)cb_thang.SelectedItem;
				int nam = (int)cb_nam.SelectedItem;
				string maNV = cb_nhanvien.SelectedValue?.ToString();

				// Tạo dữ liệu test với giờ làm việc thực tế khác nhau
				var nhanVienList = new List<(string ma, string ten, double gioTrungBinh, TimeSpan gioVao, TimeSpan gioRa)>
				{
					("NV001", "Nguyễn Văn A", 8.5, TimeSpan.Parse("08:00"), TimeSpan.Parse("16:30")),
					("NV002", "Trần Thị B", 8.0, TimeSpan.Parse("08:00"), TimeSpan.Parse("16:00")),
					("NV003", "Lê Văn C", 7.75, TimeSpan.Parse("08:15"), TimeSpan.Parse("16:00")),
					("NV004", "Phạm Thị D", 8.25, TimeSpan.Parse("07:45"), TimeSpan.Parse("16:00")),
					("NV005", "Hoàng Văn E", 9.5, TimeSpan.Parse("07:30"), TimeSpan.Parse("17:00"))
				};

				foreach (var nv in nhanVienList)
				{
					if (!string.IsNullOrEmpty(maNV) && nv.ma != maNV) continue;

					// Tạo ngẫu nhiên số ngày làm việc cho mỗi nhân viên
					Random rand = new Random(nv.ma.GetHashCode());
					int soNgayLam = rand.Next(18, 23); // 18-22 ngày làm việc

					for (int day = 1; day <= soNgayLam && day <= DateTime.DaysInMonth(nam, thang); day++)
					{
						DateTime ngay = new DateTime(nam, thang, day);
						if (ngay.DayOfWeek != DayOfWeek.Saturday && ngay.DayOfWeek != DayOfWeek.Sunday)
						{
							// Thêm biến đổi nhỏ vào giờ làm việc
							double gioLamThucTe = nv.gioTrungBinh + (rand.NextDouble() - 0.5) * 1.0; // ±0.5 giờ
							gioLamThucTe = Math.Max(6.0, Math.Min(12.0, gioLamThucTe)); // Giới hạn 6-12 giờ

							var gioVao = nv.gioVao.Add(TimeSpan.FromMinutes(rand.Next(-15, 30))); // ±15-30 phút
							var gioRa = gioVao.Add(TimeSpan.FromHours(gioLamThucTe));

							testData.Add(new BangcongDTO(nv.ma, nv.ten, ngay, gioVao, gioRa, gioLamThucTe));
						}
					}
				}

				currentBangCongData = testData;
				CalculateStatistics(testData, maNV);
				UpdateCalendarColors();
				
				var tongGioDemo = testData.Sum(x => x.SoGioLam);
				var tongNgayDemo = testData.Count(x => x.SoGioLam > 0);
				var nvCountDemo = testData.Select(x => x.MaNV).Distinct().Count();

				string demoInfo = $"🎭 CHÍNH THỨC SỬ DỤNG DỮ LIỆU DEMO\n\n";
				demoInfo += $"📅 Tháng {thang}/{nam}\n";
				demoInfo += $"👥 Số nhân viên: {nvCountDemo}\n";
				demoInfo += $"📝 Số bản ghi: {testData.Count}\n";
				demoInfo += $"🕐 Tổng giờ làm: {tongGioDemo:F1} giờ\n";
				demoInfo += $"📆 Tổng ngày làm: {tongNgayDemo} ngày\n\n";
				demoInfo += $"💡 Dữ liệu này được tạo tự động với:\n";
				demoInfo += $"   • Giờ làm việc thực tế từ 6-12 giờ/ngày\n";
				demoInfo += $"   • Thời gian CheckIn/CheckOut biến đổi\n";
				demoInfo += $"   • Số ngày làm việc ngẫu nhiên 18-22 ngày\n\n";
				demoInfo += $"🎯 Click vào ngày trong lịch để xem chi tiết!";
				
				MessageBox.Show(demoInfo, "Dữ liệu Demo", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
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
