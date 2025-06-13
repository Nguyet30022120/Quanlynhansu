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
		private Color originalExportButtonColor;
		private Color originalCloseButtonColor;
		private Color originalStatisticButtonColor;
		BindingSource tuyendungList = new BindingSource();
		public fThongketuyendung()
		{
			InitializeComponent();
			LoadInitialData();
			originalCloseButtonColor = btn_dong.BackColor;
			originalExportButtonColor = btn_xuatbaocao.BackColor;
			originalStatisticButtonColor = btn_thongkenhanvien.BackColor;


			int nam = Convert.ToInt32(cb_nam.SelectedItem);
			int thang = 0; 
			List<ThongketuyendungDTO> dataList = ThongketuyendungDAO.Instance.GetTyLeTuyenDung(nam, thang);
			DataTable dataTable = ConvertListToDataTable(dataList);
			LoadChartTuyenDung(dataTable);
			tuyendungList.DataSource = dataList;
			dgv_tuyendungthongke.DataSource = tuyendungList;
		}
		void LoadInitialData()
		{
			cb_thang.Items.Clear();
			cb_thang.Items.Add("--Tất cả các tháng--");
			for (int i = 1; i <= 12; i++)
			{
				cb_thang.Items.Add(i);
			}
			cb_thang.SelectedIndex = 0; 

			int currentYear = DateTime.Now.Year;
			cb_nam.Items.Clear();
			for (int i = 2020; i <= currentYear + 2; i++)
			{
				cb_nam.Items.Add(i);
			}
			cb_nam.SelectedItem = currentYear;
		}

		private void ExportToCSV(string filePath)
		{
			try
			{
				StringBuilder csvContent = new StringBuilder();

				foreach (DataGridViewColumn column in dgv_tuyendungthongke.Columns)
				{
					csvContent.Append(column.HeaderText + ",");
				}
				csvContent.AppendLine();


				foreach (DataGridViewRow row in dgv_tuyendungthongke.Rows)
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
			LabelPoint = point => point.Y > 0 ? point.Y.ToString() : "", 
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
			pn_chart.Controls.Clear();
			pn_chart.Controls.Add(host);
		}
		private DataTable ConvertListToDataTable(List<ThongketuyendungDTO> list)
		{
			DataTable dataTable = new DataTable();

			dataTable.Columns.Add("Thang", typeof(int));
			dataTable.Columns.Add("SoLuong", typeof(int));
			dataTable.Columns.Add("KetLuan", typeof(string)); 

			foreach (var item in list)
			{
				DataRow row = dataTable.NewRow();
				row["Thang"] = item.Thang;
				row["SoLuong"] = item.SoLuong;
				row["KetLuan"] = item.KetQua; 
				dataTable.Rows.Add(row);
			}

			return dataTable;
		}
		#region Events
		private void btn_thongkenhanvien_Click(object sender, EventArgs e)
		{

			try
			{
				int nam = Convert.ToInt32(cb_nam.SelectedItem);
				int thang = 0;
				if (cb_thang.SelectedIndex > 0)
				{
					thang = Convert.ToInt32(cb_thang.SelectedItem);
				}

				List<ThongketuyendungDTO> dataList = ThongketuyendungDAO.Instance.GetTyLeTuyenDung(nam, thang);
				DataTable dataTable = ConvertListToDataTable(dataList);
				LoadChartTuyenDung(dataTable);
				tuyendungList.DataSource = dataList;
				dgv_tuyendungthongke.DataSource = tuyendungList;
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
				int nam = Convert.ToInt32(cb_nam.SelectedItem);
				SaveFileDialog saveDialog = new SaveFileDialog();


				saveDialog.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
				saveDialog.FileName = $"BaoCaoTuyenDung_{cb_nam.SelectedItem}_.csv";

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

		private void btn_dong_Click(object sender, EventArgs e)
		{
			this.Close();
		}
		#endregion

		#region Hover
		private void btn_thongkenhanvien_MouseEnter(object sender, EventArgs e)
		{
			btn_thongkenhanvien.BackColor = Color.LightBlue;
		}
		private void btn_thongkenhanvien_MouseLeave(object sender, EventArgs e)
		{
			btn_thongkenhanvien.BackColor = originalStatisticButtonColor;
		}
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
		#endregion
	}
}
