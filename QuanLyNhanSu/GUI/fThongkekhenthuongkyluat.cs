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


namespace QuanLyNhanSu
{
	public partial class fThongkekhenthuongkyluat : Form
	{
		BindingSource commendationList = new BindingSource();
		public fThongkekhenthuongkyluat()
		{
			InitializeComponent();
			dgv_ktkltk.DataSource = commendationList;
			LoadCommendationBC();
		}
		void BindingCommendationData()
		{
			// Clear old bindings
			txb_tennhanvien.DataBindings.Clear();
			cb_nam.DataBindings.Clear();
			txb_manv.DataBindings.Clear();

			txb_tennhanvien.DataBindings.Add(new Binding("Text", dgv_ktkltk.DataSource, "TenNV", true, DataSourceUpdateMode.Never));
			txb_manv.DataBindings.Add(new Binding("Text", dgv_ktkltk.DataSource, "MaNV", true, DataSourceUpdateMode.Never));
			cb_nam.DataBindings.Add(new Binding("Text", dgv_ktkltk.DataSource, "Nam", true, DataSourceUpdateMode.Never));
		}

		void LoadCommendationBC()
		{
			commendationList.DataSource = KhenthuongkyluatDAO.Instance.GetCommendationsStatistic();
		}

		void LoadCommendationStatisticByMaNV(string manv)
		{
				commendationList.DataSource = KhenthuongkyluatDAO.Instance.GetCommendationByMaNV(manv);
				BindingCommendationData();
			
			
		}
		void LoadCommendationStatisticByNam(int nam)
		{
			commendationList.DataSource = KhenthuongkyluatDAO.Instance.GetCommendationByNam(nam);
			BindingCommendationData();
		}
		void LoadChart()
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

				panel_chart.Controls.Clear(); // panel_chart phải tồn tại trong form Designer
				panel_chart.Controls.Add(host);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Lỗi hiển thị biểu đồ: " + ex.Message, "ThongBao", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btn_thongkenv_Click(object sender, EventArgs e)
		{
			LoadCommendationStatisticByMaNV(txb_manv.Text);
			LoadChart();
		}

		private void btn_thongkenam_Click(object sender, EventArgs e)
		{
			LoadCommendationStatisticByNam(Convert.ToInt32(cb_nam.Text));
			LoadChart();
		}


	}
}
