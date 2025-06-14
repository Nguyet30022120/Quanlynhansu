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
using LiveCharts;
using LiveCharts.Wpf;
using System.Windows.Forms.Integration; // ElementHost
using LiveCharts.Defaults;
using System.IO;



namespace QuanLyNhanSu
{
	public partial class fThongkekhenthuongkyluat : Form
	{
		BindingSource commendationList = new BindingSource();
		private Color originalExportButtonColor;
		private Color originalCloseButtonColor;
		private Color originalStatisticButtonColor;
		public fThongkekhenthuongkyluat()
		{
			InitializeComponent();
			dgv_ktkltk.DataSource = commendationList;
			LoadCommendationBC();
			LoadInitialData();
			LoadChartAll();
			originalCloseButtonColor = btn_dong.BackColor;
			originalExportButtonColor = btn_xuatbaocao.BackColor;
			originalStatisticButtonColor = btn_thongke.BackColor;
		}
		void LoadInitialData()
		{
			int currentYear = DateTime.Now.Year;
			for (int i = 2020; i <= currentYear + 2; i++)
			{
				cb_nam.Items.Add(i);
			}
			cb_nam.SelectedItem = currentYear;

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

		void BindingCommendationData()
		{
			txb_manhanvien.DataBindings.Clear();
			txb_tennhanvien.DataBindings.Clear();
			cb_nam.DataBindings.Clear();
			txb_manhanvien.DataBindings.Clear();
			txb_tennhanvien.Text = "";
		}

		private void LoadCommendationBC()
		{
			commendationList.DataSource = KhenthuongkyluatDAO.Instance.GetCommendationsStatistic();
		}

		private void LoadCommendationStatisticByNam(string manv, int nam)
		{
			commendationList.DataSource = KhenthuongkyluatDAO.Instance.GetCommendationByNam(manv, nam);
			BindingCommendationData();
		}
		private void LoadChartAll()
		{
			try
			{
				var (tongKhenThuong, tongKyLuat) = KhenthuongkyluatDAO.Instance.GetTongKhenThuongVaKyLuat();

				Func<ChartPoint, string> labelPoint = chartPoint =>
					string.Format("{0} ({1:P})", chartPoint.Y, chartPoint.Participation);

				SeriesCollection series = new SeriesCollection
		{
			new PieSeries
			{
				Title = "Khen thưởng",
				Values = new ChartValues<int> { tongKhenThuong },
				DataLabels = true,
				LabelPoint = labelPoint,
                Fill = new System.Windows.Media.SolidColorBrush(
                	System.Windows.Media.Color.FromArgb(255, 66, 165, 245)
                )           },
			new PieSeries
			{
				Title = "Kỷ luật",
				Values = new ChartValues<int> { tongKyLuat },
				DataLabels = true,
				LabelPoint = labelPoint,
				Fill = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Colors.OrangeRed)
			}
		};

				var pieChart = new PieChart
				{
					Series = series,
					LegendLocation = LegendLocation.Right
				};

				ElementHost host = new ElementHost
				{
					Dock = DockStyle.Fill,
					Child = pieChart
				};

				pn_chart.Controls.Clear();
				pn_chart.Controls.Add(host);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Lỗi hiển thị biểu đồ: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		private void LoadChartTongTheoNam(int nam)
		{
			try
			{
				var (tongKhenThuong, tongKyLuat) = KhenthuongkyluatDAO.Instance.GetTongKhenThuongVaKyLuatTheoNam(nam);

				Func<ChartPoint, string> labelPoint = chartPoint =>
					string.Format("{0} ({1:P})", chartPoint.Y, chartPoint.Participation);

				SeriesCollection series = new SeriesCollection
		{
			new PieSeries
			{
				Title = "Khen thưởng",
				Values = new ChartValues<int> { tongKhenThuong },
				DataLabels = true,
				LabelPoint = labelPoint,
                Fill = new System.Windows.Media.SolidColorBrush(
                	System.Windows.Media.Color.FromArgb(255, 66, 165, 245)
                )           },
			new PieSeries
			{
				Title = "Kỷ luật",
				Values = new ChartValues<int> { tongKyLuat },
				DataLabels = true,
				LabelPoint = labelPoint,
				Fill = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Colors.OrangeRed)
			}
		};

				var pieChart = new PieChart
				{
					Series = series,
					LegendLocation = LegendLocation.Right
				};

				ElementHost host = new ElementHost
				{
					Dock = DockStyle.Fill,
					Child = pieChart
				};

				pn_chart.Controls.Clear();
				pn_chart.Controls.Add(host);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Lỗi hiển thị biểu đồ: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void LoadChart()
		{
			try
			{
				int tongKhenThuong = 0;
				int tongKyLuat = 0;

				foreach (DataGridViewRow row in dgv_ktkltk.Rows)
				{
					if (row.Cells["KhenThuong"].Value != null && row.Cells["KyLuat"].Value != null)
					{
						tongKhenThuong += Convert.ToInt32(row.Cells["KhenThuong"].Value);
						tongKyLuat += Convert.ToInt32(row.Cells["KyLuat"].Value);
					}
				}

				Func<ChartPoint, string> labelPoint = chartPoint =>
					string.Format("{0} ({1:P})", chartPoint.Y, chartPoint.Participation);

				SeriesCollection series = new SeriesCollection
		{
			new PieSeries
			{
				Title = "Khen thưởng",
				Values = new ChartValues<int> { tongKhenThuong },
				DataLabels = true,
				LabelPoint = labelPoint
			},
			new PieSeries
			{
				Title = "Kỷ luật",
				Values = new ChartValues<int> { tongKyLuat },
				DataLabels = true,
				LabelPoint = labelPoint
			}
		};

				var pieChart = new PieChart
				{
					Series = series,
					LegendLocation = LegendLocation.Right
				};

				ElementHost host = new ElementHost
				{
					Dock = DockStyle.Fill,
					Child = pieChart
				};

				pn_chart.Controls.Clear(); 
				pn_chart.Controls.Add(host);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Lỗi hiển thị biểu đồ: " + ex.Message, "ThongBao", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		private void ExportChartReport(string filePath, int tongKhenThuong, int tongKyLuat, string title = "")
		{
			try
			{
				int tong = tongKhenThuong + tongKyLuat;
				double tyLeKT = tong > 0 ? (double)tongKhenThuong / tong : 0;
				double tyLeKL = tong > 0 ? (double)tongKyLuat / tong : 0;

				StringBuilder csv = new StringBuilder();
				csv.AppendLine("\uFEFF"); // UTF-8 BOM
				csv.AppendLine("BÁO CÁO THỐNG KÊ KHEN THƯỞNG - KỶ LUẬT");
				if (!string.IsNullOrEmpty(title)) csv.AppendLine(title);
				csv.AppendLine();

				csv.AppendLine("Loại, Số lượng, Tỷ lệ");
				csv.AppendLine($"Khen thưởng, {tongKhenThuong}, {tyLeKT:P}");
				csv.AppendLine($"Kỷ luật, {tongKyLuat}, {tyLeKL:P}");
				csv.AppendLine($"Tổng, {tong}, 100%");

				File.WriteAllText(filePath, csv.ToString(), Encoding.UTF8);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Lỗi xuất báo cáo: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		#region Events
		private void btn_thongkenv_Click(object sender, EventArgs e)
		{
			string manv = txb_manhanvien.Text.Trim();
			if (!string.IsNullOrEmpty(manv))
			{
				LoadTenNV(manv);
			}

			if (cb_nam.SelectedItem == null)
			{
				MessageBox.Show("Vui lòng chọn năm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}

			int nam = Convert.ToInt32(cb_nam.SelectedItem.ToString());

			if (string.IsNullOrEmpty(manv))
			{
				int namtk = Convert.ToInt32(cb_nam.SelectedItem.ToString());
				LoadChartTongTheoNam(namtk); // hiển thị biểu đồ tròn theo năm tổng hợp
				commendationList.DataSource = KhenthuongkyluatDAO.Instance.GetCommendationNam(namtk);
				txb_tennhanvien.Text = "";
				return;
			}

			// Nếu có mã nhân viên → hiển thị thống kê riêng
			LoadCommendationStatisticByNam(manv, nam);

			if (dgv_ktkltk.Rows.Count > 0 && dgv_ktkltk.Rows[0].Cells["TenNV"].Value != null)
			{
				txb_tennhanvien.Text = dgv_ktkltk.Rows[0].Cells["TenNV"].Value.ToString();
			}
			else
			{
				txb_tennhanvien.Text = "";
			}
			LoadChart(); 
		}
		private void btn_dong_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btn_xuatbaocao_Click(object sender, EventArgs e)
		{
			try
			{
				SaveFileDialog saveDialog = new SaveFileDialog();
				saveDialog.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
				saveDialog.FileName = $"BangKhenThuongKyLuat_{cb_nam.SelectedItem}_{txb_tennhanvien.Text}.csv";

				if (saveDialog.ShowDialog() == DialogResult.OK)
				{
					int tongKhenThuong = 0;
					int tongKyLuat = 0;

					foreach (DataGridViewRow row in dgv_ktkltk.Rows)
					{
						if (row.Cells["KhenThuong"].Value != null && row.Cells["KyLuat"].Value != null)
						{
							tongKhenThuong += Convert.ToInt32(row.Cells["KhenThuong"].Value);
							tongKyLuat += Convert.ToInt32(row.Cells["KyLuat"].Value);
						}
					}

					// Gọi hàm xuất thống kê từ biểu đồ
					ExportChartReport(saveDialog.FileName, tongKhenThuong, tongKyLuat, "Tổng kết biểu đồ");

					MessageBox.Show("✅ Xuất báo cáo thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Lỗi khi xuất báo cáo: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		#endregion

		#region Hovers
		private void btn_xuatbaocao_MouseEnter(object sender, EventArgs e)
		{
			btn_xuatbaocao.BackColor = Color.LightBlue;
		}
		private void btn_xuatbaocao_MouseLeave(object sender, EventArgs e)
		{
			btn_xuatbaocao.BackColor = originalExportButtonColor;
		}
		private void btn_dong_MouseEnter(object sender, EventArgs e)
		{
			btn_dong.BackColor = Color.LightBlue;
		}
		private void btn_dong_MouseLeave(object sender, EventArgs e)
		{
			btn_dong.BackColor = originalCloseButtonColor;
		}
		private void btn_thongke_MouseEnter(object sender, EventArgs e)
		{
			btn_thongke.BackColor = Color.LightBlue;
		}
		private void btn_thongke_MouseLeave(object sender, EventArgs e)
		{
			btn_thongke.BackColor = originalStatisticButtonColor;
		}

		#endregion

	}
}
