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
		private Color originalExportButtonColor;
		private Color originalCloseButtonColor;
		private Color originalStatisticButtonColor;
		private int[] monthDataExport = new int[12];


		BindingSource onleavingList = new BindingSource();
		public fThongkenghiphep()
		{

			InitializeComponent();
			LoadAllLeaveData();
			DrawLeaveChartForAll();
			int currentYear = DateTime.Now.Year;
			cb_nam.Items.Clear();
			for (int i = 2020; i <= currentYear + 2; i++)
			{
				cb_nam.Items.Add(i);
			}
			cb_nam.SelectedItem = currentYear;

			originalCloseButtonColor = btn_dong.BackColor;
			originalExportButtonColor = btn_xuatbaocao.BackColor;
			originalStatisticButtonColor = btn_thongke.BackColor;

		}

		void LoadAllLeaveData()
		{
			var list = ThongkenghiphepDAO.Instance.GetOnLeaving();
			onleavingList.DataSource = list;
			dgv_nghiphepthongke.DataSource = onleavingList;

			txb_manhanvien.DataBindings.Clear();
			txb_tennhanvien.DataBindings.Clear();
			txb_manhanvien.Text = "";
			txb_tennhanvien.Text = "";

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


		void DrawLeaveChartForAll()
		{
			try
			{
				DataTable data = ThongkenghiphepDAO.Instance.GetNgayNghiNamAll();

				int[] monthData = new int[12];
				for (int i = 0; i < 12; i++) monthData[i] = 0;

				foreach (DataRow row in data.Rows)
				{
					int thang = Convert.ToInt32(row["Thang"]);
					int songay = Convert.ToInt32(row["SoNgayNghi"]);
					if (thang >= 1 && thang <= 12)
						monthData[thang - 1] = songay;
				}
				monthDataExport = monthData.ToArray(); // Gán mảng để xuất CSV


				var chartValues = new LiveCharts.ChartValues<int>(monthData);

				var columnSeries = new LiveCharts.Wpf.ColumnSeries
				{
					Title = "Tổng số ngày nghỉ (tất cả nhân viên)",
					Values = chartValues,
					DataLabels = true,
					LabelPoint = point => point.Y > 0 ? point.Y.ToString() : "",
					Fill = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Colors.OrangeRed),
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

				elh_thongkenghiphep.Child = cartesianChart;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Lỗi khi vẽ biểu đồ tổng: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		void BindingOnLeaveData()
		{

			txb_manhanvien.DataBindings.Clear();
			txb_tennhanvien.DataBindings.Clear();


			txb_tennhanvien.DataBindings.Add(new Binding("Text", dgv_nghiphepthongke.DataSource, "TenNV", true, DataSourceUpdateMode.Never));
			txb_manhanvien.DataBindings.Add(new Binding("Text", dgv_nghiphepthongke.DataSource, "MaNV", true, DataSourceUpdateMode.Never));
		}

		void LoadOnLeaveStatisticByMaNV(string manv)
		{
			onleavingList.DataSource = ThongkenghiphepDAO.Instance.GetOnLeavingByMaNV(manv);
			dgv_nghiphepthongke.DataSource = onleavingList;
			BindingOnLeaveData();
		}
		

		private void ExportToCSV(string filePath)
		{
			try
			{
				StringBuilder csvContent = new StringBuilder();

				// Ghi tiêu đề
				csvContent.AppendLine("Tháng,Số ngày nghỉ");

				// Ghi từng dòng cho từng tháng
				for (int i = 0; i < 12; i++)
				{
					string thang = $"Tháng {i + 1}";
					int soNgay = monthDataExport[i];
					csvContent.AppendLine($"{thang},{soNgay}");
				}

				// Ghi ra file với encoding UTF-8 có BOM để không lỗi font tiếng Việt
				System.IO.File.WriteAllText(filePath, csvContent.ToString(), new UTF8Encoding(true));

			}
			catch (Exception ex)
			{
				MessageBox.Show("Lỗi khi xuất CSV: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		#region Events
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
				saveDialog.FileName = $"BaoCaoNghiPhep_{txb_manhanvien.Text}_{txb_tennhanvien.Text}_{cb_nam.Text}.csv";

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
		private void btn_thongkenv_Click(object sender, EventArgs e)
		{
			try
			{
				LoadOnLeaveStatisticByMaNV(txb_manhanvien.Text);
				string maNV = txb_manhanvien.Text.Trim();
				LoadTenNV(maNV);

				if (cb_nam.SelectedItem == null)
				{
					MessageBox.Show("Vui lòng chọn năm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}

				int nam = Convert.ToInt32(cb_nam.SelectedItem.ToString());
				DataTable data = ThongkenghiphepDAO.Instance.GetOnLeavingNam(maNV, nam);

				if (data.Rows.Count == 0)
				{
					MessageBox.Show("Không có dữ liệu nghỉ phép cho nhân viên trong năm đã chọn.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
					return;
				}

				int[] monthData = new int[12];
				for (int i = 0; i < 12; i++)
					monthData[i] = 0;

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
					LabelPoint = point => point.Y > 0 ? point.Y.ToString() : "",
					Fill = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Colors.OrangeRed),
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

				elh_thongkenghiphep.Child = cartesianChart;
			}
			catch (Exception ex)
			{
				MessageBox.Show("Lỗi hiển thị biểu đồ: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
        #endregion

		#region Hover
		private void btn_dong_MouseEnter(object sender, EventArgs e)
		{
			btn_dong.BackColor = Color.LightBlue;
		}
		private void btn_dong_MouseLeave(object sender, EventArgs e)
		{
			btn_dong.BackColor = originalCloseButtonColor;
		}
		private void btn_xuatbaocao_MouseEnter(object sender, EventArgs e)
		{
			btn_xuatbaocao.BackColor = Color.LightBlue;
		}
		private void btn_xuatbaocao_MouseLeave(object sender, EventArgs e)
		{
			btn_xuatbaocao.BackColor = originalExportButtonColor;
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


