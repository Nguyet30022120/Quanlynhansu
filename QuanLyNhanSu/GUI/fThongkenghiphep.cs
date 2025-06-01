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
					Fill = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Colors.BlanchedAlmond),
					Foreground = new System.Windows.Media.SolidColorBrush(System.Windows.Media.Colors.Black)
				};

				var cartesianChart = new LiveCharts.Wpf.CartesianChart
				{
					Series = new LiveCharts.SeriesCollection { columnSeries },
					AxisX = new LiveCharts.Wpf.AxesCollection
			{
				new LiveCharts.Wpf.Axis
				{
					Title = "Tháng",
					Labels = Enumerable.Range(1, 12).Select(i => i.ToString()).ToArray(),
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
	}
}


