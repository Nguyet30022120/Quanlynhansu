using LiveCharts.Wpf;
using LiveCharts;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.Integration;
using QuanLyNhanSu.DAO;

namespace QuanLyNhanSu.GUI
{
	public partial class fThongketuyendung : Form
	{
		BindingSource tuyendungList = new BindingSource();
		public fThongketuyendung()
		{
			InitializeComponent();
			LoadInitialData();
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

		}
		void LoadTyLeTuyenDung(int nam, int thang)
		{
			tuyendungList.DataSource = ThongketuyendungDAO.Instance.GetTyLeTuyenDung(nam, thang);
			dgv_tuyendungtk.DataSource = tuyendungList;
		}
		private void ExportToCSV(string filePath)
		{
			try
			{
				// Create a StringBuilder to store CSV content
				StringBuilder csvContent = new StringBuilder();

				// Add header row
				foreach (DataGridViewColumn column in dgv_tuyendungtk.Columns)
				{
					csvContent.Append(column.HeaderText + ",");
				}
				csvContent.AppendLine();

				// Add data rows
				foreach (DataGridViewRow row in dgv_tuyendungtk.Rows)
				{
					foreach (DataGridViewCell cell in row.Cells)
					{
						if (cell.Value != null)
						{
							csvContent.Append(cell.Value.ToString() + ",");
						}
						else
						{
							csvContent.Append(",");
						}
					}
					csvContent.AppendLine();
				}

				// Write to file
				System.IO.File.WriteAllText(filePath, csvContent.ToString());
			}
			catch (Exception ex)
			{
				MessageBox.Show("Lỗi khi xuất CSV: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		private void LoadChartTuyenDung(DataTable dt)
		{
			// Mảng lưu số lượng cho từng tháng (1-12)
			int[] duocTuyen = new int[12];
			int[] khongDuocTuyen = new int[12];

			// Duyệt dữ liệu và phân loại
			foreach (DataRow row in dt.Rows)
			{
				int thang = Convert.ToInt32(row["Thang"]);
				int soLuong = Convert.ToInt32(row["SoLuong"]);
				string ketLuan = row["KetLuan"].ToString();

				if (ketLuan == "Được tuyển")
					duocTuyen[thang - 1] = soLuong;
				else
					khongDuocTuyen[thang - 1] = soLuong;
			}

			// Tạo Series cho biểu đồ cột nhóm
			var series = new SeriesCollection
	{
		new ColumnSeries
		{
			Title = "Được tuyển",
			Values = new ChartValues<int>(duocTuyen)
		},
		new ColumnSeries
		{
			Title = "Không được tuyển",
			Values = new ChartValues<int>(khongDuocTuyen)
		}
	};

			// Nhãn trục X là các tháng
			string[] labels = Enumerable.Range(1, 12).Select(i => $"Tháng {i}").ToArray();

			var cartesianChart = new CartesianChart
			{
				Series = series,
				AxisX = { new Axis { Title = "Tháng", Labels = labels } },
				AxisY = { new Axis { Title = "Số lượng" } },
				LegendLocation = LegendLocation.Top
			};

			// Hiển thị lên panel_chart (panel_chart là Panel bạn đặt trên form)
			ElementHost host = new ElementHost
			{
				Dock = DockStyle.Fill,
				Child = cartesianChart
			};
			panel_chart.Controls.Clear();
			panel_chart.Controls.Add(host);
		}

		private void btn_thongkenhanvien_Click(object sender, EventArgs e)
		{

		}

		private void btn_xuatbaocao_Click(object sender, EventArgs e)
		{
			try
			{
				// Xuất báo cáo (có thể dùng Excel hoặc PDF)
				SaveFileDialog saveDialog = new SaveFileDialog();
				saveDialog.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
				saveDialog.FileName = $"BaoCaoNghiPhep_{cb_nam}_{cb_thang}.csv";

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

		private void btn_dong_Click(object sender, EventArgs e)
		{

		}
	}
}
