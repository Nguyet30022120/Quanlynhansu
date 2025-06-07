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
using QuanLyNhanSu.DTO;

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
			// Load ComboBox tháng (Tất cả các tháng + 1-12)
			cb_thang.Items.Add("--Tất cả các tháng--"); // Giá trị đầu tiên, tương ứng với 0
			for (int i = 1; i <= 12; i++)
			{
				cb_thang.Items.Add(i);
			}
			// Nếu muốn mặc định là tháng hiện tại, cần +1 vì "Tất cả các tháng" ở vị trí 0
			cb_thang.SelectedIndex = DateTime.Now.Month;

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

			int[] duocTuyen = new int[12];
			int[] khongDuocTuyen = new int[12];

			for (int i = 1; i <= 12; i++)
			{
				var rowsDuocTuyen = dt.Select($"Thang = {i} AND KetLuan = 'Được tuyển'");
				var rowsKhongDuocTuyen = dt.Select($"Thang = {i} AND KetLuan = 'Không được tuyển'");

				duocTuyen[i - 1] = rowsDuocTuyen.Length > 0 ? Convert.ToInt32(rowsDuocTuyen[0]["SoLuong"]) : 0;
				khongDuocTuyen[i - 1] = rowsKhongDuocTuyen.Length > 0 ? Convert.ToInt32(rowsKhongDuocTuyen[0]["SoLuong"]) : 0;
			}

			var series = new SeriesCollection
	{
		new ColumnSeries
		{
			Title = "Được tuyển",
			Values = new ChartValues<int>(duocTuyen),
			DataLabels = true,
			LabelPoint = point => point.Y > 0 ? point.Y.ToString() : "", // ẩn số 0
            Foreground = System.Windows.Media.Brushes.Black,
			FontWeight = System.Windows.FontWeights.Bold
		},
		new ColumnSeries
		{
			Title = "Không được tuyển",
			Values = new ChartValues<int>(khongDuocTuyen),
			DataLabels = true,
			LabelPoint = point => point.Y > 0 ? point.Y.ToString() : "",
			Foreground = System.Windows.Media.Brushes.Black,
			FontWeight = System.Windows.FontWeights.Bold
		}
	};

			// Hiển thị nhãn "Tháng 1", "Tháng 2", ...
			string[] labels = Enumerable.Range(1, 12).Select(j => $"Tháng {j}").ToArray();

			var cartesianChart = new CartesianChart
			{
				Series = series,
				AxisX = { new Axis { Labels = labels, Title = "" } },
				AxisY = { new Axis { Title = "Số lượng" } },
				LegendLocation = LegendLocation.Top
			};

			ElementHost host = new ElementHost
			{
				Dock = DockStyle.Fill,
				Child = cartesianChart
			};
			panel_chart.Controls.Clear();
			panel_chart.Controls.Add(host);
		}
		private DataTable ConvertListToDataTable(List<ThongketuyendungDTO> list)
		{
			DataTable dataTable = new DataTable();

			// Define columns based on ThongketuyendungDTO properties
			dataTable.Columns.Add("Thang", typeof(int));
			dataTable.Columns.Add("SoLuong", typeof(int));
			dataTable.Columns.Add("KetLuan", typeof(string)); // Đúng tên cột dùng cho DataTable

			// Populate rows
			foreach (var item in list)
			{
				DataRow row = dataTable.NewRow();
				row["Thang"] = item.Thang;
				row["SoLuong"] = item.SoLuong;
				row["KetLuan"] = item.KetQua; // Gán vào cột "KetLuan"
				dataTable.Rows.Add(row);
			}

			return dataTable;
		}
		private void btn_thongkenhanvien_Click(object sender, EventArgs e)
		{

			try
			{
				int nam = Convert.ToInt32(cb_nam.SelectedItem);
				int thang = 0;
				// Nếu chọn "--Tất cả các tháng--" thì thang = 0, còn lại lấy giá trị số tháng
				if (cb_thang.SelectedIndex > 0)
				{
					thang = Convert.ToInt32(cb_thang.SelectedItem);
				}

				List<ThongketuyendungDTO> dataList = ThongketuyendungDAO.Instance.GetTyLeTuyenDung(nam, thang);
				DataTable dataTable = ConvertListToDataTable(dataList);
				LoadChartTuyenDung(dataTable);
				// Hiển thị lên DataGridView
				tuyendungList.DataSource = dataList;
				dgv_tuyendungtk.DataSource = tuyendungList;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Lỗi hiển thị biểu đồ: " + ex.Message, "ThongBao", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

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
			this.Close();
		}
	}
}
