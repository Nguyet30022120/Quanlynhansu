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
			lb_name.Text="Ten_nhan_vien";


		}
		void BindingOnLeaveData()
		{
			// Clear old bindings
			//txb_tennv.DataBindings.Clear();
			txb_manv.DataBindings.Clear();
			dtp_ngaybd.DataBindings.Clear();
			dtp_ngaykt.DataBindings.Clear();
			lb_name.DataBindings.Clear();

			lb_name.DataBindings.Add(new Binding("Text", dgv_nghipheptk.DataSource, "TenNV", true, DataSourceUpdateMode.Never));
			//txb_tennv.DataBindings.Add(new Binding("Text", dgv_nghipheptk.DataSource, "TenNV", true, DataSourceUpdateMode.Never));
			txb_manv.DataBindings.Add(new Binding("Text", dgv_nghipheptk.DataSource, "MaNV", true, DataSourceUpdateMode.Never));
			dtp_ngaybd.DataBindings.Add(new Binding("Value", dgv_nghipheptk.DataSource, "NgayBD", true, DataSourceUpdateMode.Never));
			dtp_ngaykt.DataBindings.Add(new Binding("Value", dgv_nghipheptk.DataSource, "NgayKT", true, DataSourceUpdateMode.Never));
		}

		void LoadOnLeaveStatisticByMaNV(string manv)
		{
			onleavingList.DataSource = ThongkenghiphepDAO.Instance.GetOnLeavingByMaNV(manv);
			dgv_nghipheptk.DataSource = onleavingList;
			BindingOnLeaveData();
		}
		void LoadOnLeaveStatisticByNgay(string manv,DateTime ngaybd, DateTime ngaykt)
		{
			onleavingList.DataSource = ThongkenghiphepDAO.Instance.GetOnLeavingByNgay(manv, ngaybd, ngaykt);
			dgv_nghipheptk.DataSource = onleavingList;
			BindingOnLeaveData();
		}

		private void btn_thongkenv_Click(object sender, EventArgs e)
		{
			try
			{
				LoadOnLeaveStatisticByMaNV(txb_manv.Text);

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
				LoadOnLeaveStatisticByNgay(txb_manv.Text, dtp_ngaybd.Value, dtp_ngaykt.Value);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Lỗi hiển thị biểu đồ: " + ex.Message, "ThongBao", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void fOnLeavingStatistics_Load(object sender, EventArgs e)
		{

		}

		private void fOnLeavingStatistics_Load_1(object sender, EventArgs e)
		{

		}
		private void btn_load_Click(object sender, EventArgs e)
		{
			
		}

		private void btn_load_Click_1(object sender, EventArgs e)
		{
			try
			{
				string maNV = txb_manv.Text;
				DataTable data = ThongkenghiphepDAO.Instance.GetNgayNghiTheoThang(maNV);

				Dictionary<int, double> monthData = new Dictionary<int, double>();
				for (int i = 1; i <= 12; i++)
				{
					monthData[i] = 0;
				}

				foreach (DataRow row in data.Rows)
				{
					int thang = Convert.ToInt32(row["Thang"]);
					double songay = Convert.ToDouble(row["SoNgayNghi"]);
					monthData[thang] = songay;
				}

				var chartValues = new LiveCharts.ChartValues<double>(monthData.Values);

				var columnSeries = new LiveCharts.Wpf.ColumnSeries
				{
					Title = "Số ngày nghỉ",
					Values = chartValues,
					DataLabels = true
				};

				var cartesianChart = new LiveCharts.Wpf.CartesianChart
				{
					Series = new LiveCharts.SeriesCollection { columnSeries },
					AxisX = new LiveCharts.Wpf.AxesCollection
			{
				new LiveCharts.Wpf.Axis
				{
					Title = "Tháng",
					Labels = monthData.Keys.Select(k => k.ToString()).ToArray()
				}
			},
					AxisY = new LiveCharts.Wpf.AxesCollection
			{
				new LiveCharts.Wpf.Axis
				{
					Title = "Số ngày nghỉ"
				}
			}
				};

				elementHost1.Child = cartesianChart; // Gắn biểu đồ vào ElementHost
			}
			catch (Exception ex)
			{
				MessageBox.Show("Lỗi hiển thị biểu đồ: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
	}
	}

