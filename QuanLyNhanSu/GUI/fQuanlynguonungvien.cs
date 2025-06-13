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
		private Color originalAddButtonColor;
		private Color originalDeleteButtonColor;
		private Color originalFindButtonColor;
		private Color originalCloseButtonColor;
		private Color originalLoadButtonColor;


		BindingSource sourceList = new BindingSource();
		public fQuanlynguonungvien()
		{
			InitializeComponent();
			dgv_nguonungvien.DataSource = sourceList;
			BindingsourceData();
			LoadCandidatePool();
			originalAddButtonColor = btn_themnguonungvien.BackColor;
			originalDeleteButtonColor = btn_xoanguonungvien.BackColor;
			originalFindButtonColor = btn_timnguonungvien.BackColor;
			originalCloseButtonColor = btn_dongnguonungvien.BackColor;
			originalLoadButtonColor = btn_load.BackColor;
		}
		void LoadCandidatePool()
		{
			sourceList.DataSource = NguonungvienDAO.Instance.GetListSource();
		}

		void BindingsourceData()
		{
			txb_nguonungvien.DataBindings.Add(new Binding("Text", dgv_nguonungvien.DataSource, "TenNguon", true, DataSourceUpdateMode.Never));
			txb_soluonghs.DataBindings.Add(new Binding("Text", dgv_nguonungvien.DataSource, "SoLuongHoSo", true, DataSourceUpdateMode.Never));
		}
		#region Events

		private void btn_addnguonuv_Click(object sender, EventArgs e)
		{
			try
			{
				string tennguonuv = txb_nguonungvien.Text;
				if (NguonungvienDAO.Instance.InsertSource(tennguonuv))
				{
					MessageBox.Show("Thêm nguồn ứng viên thành công","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
					LoadCandidatePool();
				}
				else
				{
					MessageBox.Show("Thêm nguồn ứng viên thất bại", "Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
					string nguonuv = txb_nguonungvien.Text;

					if (NguonungvienDAO.Instance.DeleteSource(nguonuv))
					{
						MessageBox.Show("Xóa nguồn ứng viên thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
					else
					{
						MessageBox.Show("Xóa nguồn ứng viên thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}

				}
				catch (Exception ex)
				{
					MessageBox.Show("Error: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

				foreach (DataGridViewRow row in dgv_nguonungvien.Rows)
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

				pn_chart.Controls.Clear();
				pn_chart.Controls.Add(host);
			}
			catch (Exception ex)
			{
				MessageBox.Show("Lỗi hiển thị biểu đồ: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		#endregion

		#region Hover
		private void btn_addnguonuv_MouseEnter(object sender, EventArgs e)
		{
			btn_themnguonungvien.BackColor = System.Drawing.Color.LightBlue;
		}
		private void btn_addnguonuv_MouseLeave(object sender, EventArgs e)
		{
			btn_themnguonungvien.BackColor = originalAddButtonColor;
		}
		private void btn_deletenguonuv_MouseEnter(object sender, EventArgs e)
		{
			btn_xoanguonungvien.BackColor = System.Drawing.Color.LightBlue;
		}
		private void btn_deletenguonuv_MouseLeave(object sender, EventArgs e)
		{
			btn_xoanguonungvien.BackColor = originalDeleteButtonColor;
		}
		private void btn_findnguonuv_MouseEnter(object sender, EventArgs e)
		{
			btn_timnguonungvien.BackColor = System.Drawing.Color.LightBlue;
		}
		private void btn_findnguonuv_MouseLeave(object sender, EventArgs e)
		{
			btn_timnguonungvien.BackColor = originalFindButtonColor;
		}
		private void btn_closenguonuv_MouseEnter(object sender, EventArgs e)
		{
			btn_dongnguonungvien.BackColor = System.Drawing.Color.LightBlue;
		}
		private void btn_closenguonuv_MouseLeave(object sender, EventArgs e)
		{
			btn_dongnguonungvien.BackColor = originalCloseButtonColor;
		}
		private void btn_load_MouseEnter(object sender, EventArgs e)
		{
			btn_load.BackColor = System.Drawing.Color.LightBlue;
		}
		private void btn_load_MouseLeave(object sender, EventArgs e)
		{
			btn_load.BackColor = originalLoadButtonColor;
		}
		#endregion

	}
}
