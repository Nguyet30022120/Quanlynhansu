using LiveCharts.Wpf;
using LiveCharts;
using QuanLyNhanSu.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Windows.Markup;
using System.Windows.Forms.Integration;

namespace QuanLyNhanSu.GUI
{
	public partial class fQuanlynguonungvien : Form
	{
		BindingSource sourceList = new BindingSource();
		public fQuanlynguonungvien()
		{
			InitializeComponent();
			dgv_nguonuv.DataSource = sourceList;
			BindingsourceData();
			LoadCbNguonUV();
			LoadCandidatePool();
		}
		void LoadCandidatePool()
		{
			sourceList.DataSource = NguonungvienDAO.Instance.GetListSource();
		}
		void LoadCbNguonUV()
		{
			cb_nguonungvien.DataSource = NguonungvienDAO.Instance.GetListSource();
			cb_nguonungvien.DisplayMember = "TenNguon";
		}
		void BindingsourceData()
		{
			cb_nguonungvien.DataBindings.Add(new Binding("Text", dgv_nguonuv.DataSource, "TenNguon", true, DataSourceUpdateMode.Never));
			txb_soluonghs.DataBindings.Add(new Binding("Text", dgv_nguonuv.DataSource, "SoLuongHoSo", true, DataSourceUpdateMode.Never));
		}

		private void btn_addnguonuv_Click(object sender, EventArgs e)
		{
			try
			{
				string tennguonuv = cb_nguonungvien.Text;
				if (NguonungvienDAO.Instance.InsertSource(tennguonuv))
				{
					MessageBox.Show("Thêm nguồn ứng viên thành công");
					LoadCandidatePool();
				}
				else
				{
					MessageBox.Show("Thêm nguồn ứng viên thất bại");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error: " + ex.Message, "ThongBao", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				LoadCandidatePool();
			}
		}

		private void btn_deletenguonuv_Click(object sender, EventArgs e)
		{
			{

				try
				{
					string nguonuv = cb_nguonungvien.Text;

					if (NguonungvienDAO.Instance.DeleteSource(nguonuv))
					{
						MessageBox.Show("Xóa nguồn ứng viên thành công.");
					}
					else
					{
						MessageBox.Show("Xóa nguồn ứng viên thất bại.");
					}

				}
				catch (Exception ex)
				{
					MessageBox.Show("Error: " + ex.Message, "ThongBao", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				finally
				{
					LoadCandidatePool();
				}
			}
		}

		private void btn_findnguonuv_Click(object sender, EventArgs e)
		{
			sourceList.DataSource = NguonungvienDAO.Instance.SearchSource(txb_timnguonungvien.Text);
		}

		private void btn_closenguonuv_Click(object sender, EventArgs e)
		{
			this.Close();
		}


		Func<ChartPoint, string> labelPoint = chartpoint => string.Format("{0} ({1:P})", chartpoint.Y, chartpoint.Participation);
		private void btn_load_Click(object sender, EventArgs e)
		{
			try
			{
				LiveCharts.SeriesCollection series = new LiveCharts.SeriesCollection();

				foreach (DataGridViewRow row in dgv_nguonuv.Rows)
				{
					if (row.Cells["TenNguon"].Value != null && row.Cells["SoLuongHoSo"].Value != null)
					{
						series.Add(new LiveCharts.Wpf.PieSeries
						{
							Title = row.Cells["TenNguon"].Value.ToString(),
							Values = new LiveCharts.ChartValues<int>
					{
						Convert.ToInt32(row.Cells["SoLuongHoSo"].Value)
					},
							DataLabels = true,
							LabelPoint = labelPoint
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

				// Gắn biểu đồ vào panel đã thiết kế
				panel_chart.Controls.Clear();
				panel_chart.Controls.Add(host);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Lỗi hiển thị biểu đồ: " + ex.Message, "ThongBao", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}



	}
}
