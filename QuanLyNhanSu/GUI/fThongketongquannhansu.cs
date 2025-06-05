using LiveCharts;
using LiveCharts.Wpf;
using QuanLyNhanSu.DAO;
using System;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.Integration;

namespace QuanLyNhanSu.GUI
{
	public partial class fThongketongquannhansu : Form
	{
		BindingSource namnuList = new BindingSource();

		BindingSource nvtheopbList = new BindingSource();

		BindingSource nvtheocvList = new BindingSource();
		public fThongketongquannhansu()
		{
			InitializeComponent();
			LoadNamNuStatisticByMaNV();
			LoadPBStatisticByMaNV();
			LoadCVStatisticByMaNV();
			LoadChartGioiTinh();
			LoadChartPhongBan();
			LoadChartChucVu();
			LoadLbTongNV();
			LoadLbTongPB();
			LoadLbTongCV();
		}
		void LoadNamNuStatisticByMaNV()
		{
			namnuList.DataSource = ThongkenhansuDAO.Instance.GetNamNuStatistics();
			dgv_namnu.DataSource = namnuList;
		}
		void LoadPBStatisticByMaNV()
		{
			nvtheopbList.DataSource = ThongkenhansuDAO.Instance.GetPhongBanStatistics();
			dgv_nvtheopb.DataSource = nvtheopbList;
		}
		void LoadCVStatisticByMaNV()
		{
			nvtheocvList.DataSource = ThongkenhansuDAO.Instance.GetChucVuStatistics();
			dgv_nvtheocv.DataSource = nvtheocvList;
		}
		void LoadLbTongNV()
		{
			int soLuong = 0;
			foreach (DataGridViewRow row in dgv_namnu.Rows)
			{
				if (row.Cells["SoLuong"].Value != null)
				{
					soLuong += Convert.ToInt32(row.Cells["SoLuong"].Value);
				}
			}
			lb_slnv2.Text = soLuong.ToString();
		}

		void LoadLbTongPB()
		{
			int soDong = 0;
			foreach (DataGridViewRow row in dgv_nvtheopb.Rows)
			{
				if (!row.IsNewRow) // loại bỏ dòng trống cuối cùng (nếu có)
				{
					soDong++;
				}
			}
			lb_slpb2.Text = soDong.ToString();
		}
		void LoadLbTongCV()
		{
			int soDong = 0;
			foreach (DataGridViewRow row in dgv_nvtheocv.Rows)
			{
				if (!row.IsNewRow) // loại bỏ dòng trống cuối cùng (nếu có)
				{
					soDong++;
				}
			}
			lb_slcv2.Text = soDong.ToString();
		}

		void LoadChartGioiTinh()
		{
			try
			{
				LiveCharts.SeriesCollection series = new LiveCharts.SeriesCollection();

				foreach (DataGridViewRow row in dgv_namnu.Rows)
				{
					if (row.Cells["GioiTinh"].Value != null && row.Cells["SoLuong"].Value != null)
					{
						string gioiTinhRaw = row.Cells["GioiTinh"].Value.ToString().Trim();
						string gioiTinhStr = gioiTinhRaw == "Nam" ? "Nam" : "Nữ"; // 1 là Nam, còn lại là Nữ

						int soLuong = Convert.ToInt32(row.Cells["SoLuong"].Value);

						series.Add(new PieSeries
						{
							Title = gioiTinhStr,
							Values = new ChartValues<int> { soLuong },
							DataLabels = true,
							LabelPoint = chartPoint => string.Format("{0} ({1:P})", chartPoint.Y, chartPoint.Participation)
						});
					}
				}


				var pieChart = new LiveCharts.Wpf.PieChart
				{
					Series = series,
					LegendLocation = LiveCharts.LegendLocation.Right
				};

				ElementHost host = new ElementHost
				{
					Dock = DockStyle.Fill,
					Child = pieChart
				};

				panel_namnu.Controls.Clear();
				panel_namnu.Controls.Add(host);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Lỗi hiển thị biểu đồ giới tính: " + ex.Message, "ThongBao", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		private void LoadChartPhongBan()
		{
			try
			{
				LiveCharts.SeriesCollection series = new LiveCharts.SeriesCollection();

				foreach (DataGridViewRow row in dgv_nvtheopb.Rows)
				{
					if (row.Cells["PhongBan"].Value != null && row.Cells["SoLuong2"].Value != null)
					{
						string tenPB = row.Cells["PhongBan"].Value.ToString();
						int soLuong = Convert.ToInt32(row.Cells["SoLuong2"].Value);

						series.Add(new PieSeries
						{
							Title = tenPB,
							Values = new ChartValues<int> { soLuong },
							DataLabels = true,
							LabelPoint = chartPoint => string.Format("{0} ({1:P})", chartPoint.Y, chartPoint.Participation)
						});
					}
				}

				var pieChart = new LiveCharts.Wpf.PieChart
				{
					Series = series,
					LegendLocation = LiveCharts.LegendLocation.Right
				};

				ElementHost host = new ElementHost
				{
					Dock = DockStyle.Fill,
					Child = pieChart
				};

				panel_nvtheopb.Controls.Clear();
				panel_nvtheopb.Controls.Add(host);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Lỗi hiển thị biểu đồ phòng ban: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		private void LoadChartChucVu()
		{
			try
			{
				LiveCharts.SeriesCollection series = new LiveCharts.SeriesCollection();

				foreach (DataGridViewRow row in dgv_nvtheocv.Rows)
				{
					if (row.Cells["ChucVu"].Value != null && row.Cells["SoLuong3"].Value != null)
					{
						string tenCV = row.Cells["ChucVu"].Value.ToString();
						int soLuong = Convert.ToInt32(row.Cells["SoLuong3"].Value);

						series.Add(new PieSeries
						{
							Title = tenCV,
							Values = new ChartValues<int> { soLuong },
							DataLabels = true,
							LabelPoint = chartPoint => string.Format("{0} ({1:P})", chartPoint.Y, chartPoint.Participation)
						});
					}
				}

				var pieChart = new LiveCharts.Wpf.PieChart
				{
					Series = series,
					LegendLocation = LiveCharts.LegendLocation.Right
				};

				ElementHost host = new ElementHost
				{
					Dock = DockStyle.Fill,
					Child = pieChart
				};

				panel_nvtheocv.Controls.Clear();
				panel_nvtheocv.Controls.Add(host);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Lỗi hiển thị biểu đồ phòng ban: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		private void ExportToCSV(string filePath)
		{
			try
			{
				StringBuilder csvContent = new StringBuilder();

				// Export dgv_namnu
				csvContent.AppendLine("=== Thống kê Nam/Nữ ===");
				foreach (DataGridViewColumn column in dgv_namnu.Columns)
				{
					csvContent.Append(column.HeaderText + ",");
				}
				csvContent.AppendLine();
				foreach (DataGridViewRow row in dgv_namnu.Rows)
				{
					if (!row.IsNewRow)
					{
						foreach (DataGridViewCell cell in row.Cells)
						{
							csvContent.Append((cell.Value ?? "").ToString() + ",");
						}
						csvContent.AppendLine();
					}
				}
				csvContent.AppendLine();

				// Export dgv_nvtheopb
				csvContent.AppendLine("=== Thống kê theo Cửa hàng ===");
				foreach (DataGridViewColumn column in dgv_nvtheopb.Columns)
				{
					csvContent.Append(column.HeaderText + ",");
				}
				csvContent.AppendLine();
				foreach (DataGridViewRow row in dgv_nvtheopb.Rows)
				{
					if (!row.IsNewRow)
					{
						foreach (DataGridViewCell cell in row.Cells)
						{
							csvContent.Append((cell.Value ?? "").ToString() + ",");
						}
						csvContent.AppendLine();
					}
				}
				csvContent.AppendLine();

				// Export dgv_nvtheocv
				csvContent.AppendLine("=== Thống kê theo Chức Vụ ===");
				foreach (DataGridViewColumn column in dgv_nvtheocv.Columns)
				{
					csvContent.Append(column.HeaderText + ",");
				}
				csvContent.AppendLine();
				foreach (DataGridViewRow row in dgv_nvtheocv.Rows)
				{
					if (!row.IsNewRow)
					{
						foreach (DataGridViewCell cell in row.Cells)
						{
							csvContent.Append((cell.Value ?? "").ToString() + ",");
						}
						csvContent.AppendLine();
					}
				}

				System.IO.File.WriteAllText(filePath, csvContent.ToString());
			}
			catch (Exception ex)
			{
				MessageBox.Show("Lỗi khi xuất CSV: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		private void btn_close_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btn_xuatbaocao_Click(object sender, EventArgs e)
		{
			try
			{
				// Xuất báo cáo (có thể dùng Excel hoặc PDF)
				SaveFileDialog saveDialog = new SaveFileDialog();
				saveDialog.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
				saveDialog.FileName = $"BaoCaoTongQuanNhanSu.csv";

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
	}
}
