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
using System.Windows.Forms.Integration;

namespace QuanLyNhanSu
{
	public partial class fThongkenghiphep : Form
	{
		BindingSource onleavingList = new BindingSource();
		public fThongkenghiphep()
		{

			InitializeComponent();
			//BindingOnLeaveData();

		}
		void BindingOnLeaveData()
		{
			// Clear old bindings
			//txb_tennv.DataBindings.Clear();
			txb_manhanvien.DataBindings.Clear();
			dtp_ngaybatdau.DataBindings.Clear();
			dtp_ngaykt.DataBindings.Clear();
			txb_tennhanvien.DataBindings.Clear();


			txb_tennhanvien.DataBindings.Add(new Binding("Text", dgv_nghipheptk.DataSource, "TenNV", true, DataSourceUpdateMode.Never));
			txb_manhanvien.DataBindings.Add(new Binding("Text", dgv_nghipheptk.DataSource, "MaNV", true, DataSourceUpdateMode.Never));
			dtp_ngaybatdau.DataBindings.Add(new Binding("Value", dgv_nghipheptk.DataSource, "NgayBD", true, DataSourceUpdateMode.Never));
			dtp_ngaykt.DataBindings.Add(new Binding("Value", dgv_nghipheptk.DataSource, "NgayKT", true, DataSourceUpdateMode.Never));
		}

		void LoadOnLeaveStatisticByMaNV(string manv)
		{
			onleavingList.DataSource = ThongkenghiphepDAO.Instance.GetOnLeavingByMaNV(manv);
			dgv_nghipheptk.DataSource = onleavingList;
			BindingOnLeaveData();
		}
		void LoadOnLeaveStatisticByNgay(string manv, DateTime ngaybd, DateTime ngaykt)
		{
			onleavingList.DataSource = ThongkenghiphepDAO.Instance.GetOnLeavingByNgay(manv, ngaybd, ngaykt);
			dgv_nghipheptk.DataSource = onleavingList;
			BindingOnLeaveData();
		}

		private void btn_thongkenv_Click(object sender, EventArgs e)
		{
			try
			{
				LoadOnLeaveStatisticByMaNV(txb_manhanvien.Text);
				string maNV = txb_manhanvien.Text.Trim();
				DataTable data = ThongkenghiphepDAO.Instance.GetNgayNghiTheoThang(maNV);

				// Khởi tạo dữ liệu cho 12 tháng, mặc định là 0
				int[] monthData = new int[12];
				for (int i = 0; i < 12; i++)
					monthData[i] = 0;

				// Gán số ngày nghỉ cho từng tháng nếu có dữ liệu
				foreach (DataRow row in data.Rows)
				{
					int thang = Convert.ToInt32(row["Thang"]);
					int songay = Math.Max(0, Convert.ToInt32(row["SoNgayNghi"]));
					if (thang >= 1 && thang <= 12)
						monthData[thang - 1] = songay;
				}

				var chartValues = new LiveCharts.ChartValues<int>(monthData);

				var columnSeries = new LiveCharts.Wpf.ColumnSeries
				{
					Title = "Số ngày nghỉ",
					Values = chartValues,
					DataLabels = true,
					LabelPoint = point => point.Y > 0 ? point.Y.ToString() : "", // Chỉ hiển thị số > 0
					Fill = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Colors.Red),
					Foreground = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Colors.Black),
					FontWeight = System.Windows.FontWeights.Bold
				};

				var cartesianChart = new LiveCharts.Wpf.CartesianChart
				{
					Series = new LiveCharts.SeriesCollection { columnSeries },
					AxisX = new LiveCharts.Wpf.AxesCollection
			{
				new LiveCharts.Wpf.Axis
				{
					Title = "Tháng",
					Labels = Enumerable.Range(1, 12).Select(i => $"Tháng {i}").ToArray(),
					Foreground = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Colors.Black)
				}
			},
					AxisY = new LiveCharts.Wpf.AxesCollection
			{
				new LiveCharts.Wpf.Axis
				{
					Title = "Số ngày nghỉ",
					MinValue = 0
				}
			}
				};

				elementHost1.Child = cartesianChart;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Lỗi hiển thị biểu đồ: " + ex.Message, "ThongBao", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		private void ExportToCSV(string filePath)
		{
			try
			{
				// Create a StringBuilder to store CSV content
				StringBuilder csvContent = new StringBuilder();

				// Add header row
				foreach (DataGridViewColumn column in dgv_nghipheptk.Columns)
				{
					csvContent.Append(column.HeaderText + ",");
				}
				csvContent.AppendLine();

				// Add data rows
				foreach (DataGridViewRow row in dgv_nghipheptk.Rows)
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

		private void btn_thongketheongay_Click(object sender, EventArgs e)
		{
			try
			{
				LoadOnLeaveStatisticByNgay(txb_manhanvien.Text, dtp_ngaybatdau.Value, dtp_ngaykt.Value);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Lỗi hiển thị biểu đồ: " + ex.Message, "ThongBao", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btn_dong_Click(object sender, EventArgs e)
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
				saveDialog.FileName = $"BaoCaoNghiPhep_{txb_tennhanvien.Text}.csv";

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

		private void fThongkenghiphep_Load(object sender, EventArgs e)
		{

		}
	}
}


