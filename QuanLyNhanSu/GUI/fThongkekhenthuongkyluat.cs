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
			LoadInitialData();
		}
		void LoadInitialData()
		{
			// Load ComboBox tháng (1-12)
			//for (int i = 1; i <= 12; i++)
			//{
			//	cb_thang.Items.Add(i);
			//}
			//cb_thang.SelectedItem = DateTime.Now.Month;

			// Load ComboBox năm (từ 2020 đến năm hiện tại + 2)
			int currentYear = DateTime.Now.Year;
			for (int i = 2020; i <= currentYear + 2; i++)
			{
				cb_nam.Items.Add(i);
			}
			cb_nam.SelectedItem = currentYear;

			// Load ComboBox nhân viên

		}

		//void LoadNhanVien()
		//{
		//	try
		//	{
		//		// Lấy danh sách nhân viên từ DAO
		//		DataTable dtNhanVien = BangcongDAO.Instance.GetDanhSachNhanVienCoChamCong();

		//		// Thêm option "Tất cả nhân viên"
		//		DataRow allRow = dtNhanVien.NewRow();
		//		allRow["Ma_NV"] = "";
		//		allRow["HoTen"] = "-- Tất cả nhân viên --";
		//		dtNhanVien.Rows.InsertAt(allRow, 0);

		//		cb_nhanvien.DataSource = dtNhanVien;
		//		cb_nhanvien.DisplayMember = "HoTen";
		//		cb_nhanvien.ValueMember = "Ma_NV";
		//		cb_nhanvien.SelectedIndex = 0;
		//	}
		//	catch (Exception ex)
		//	{
		//		// Fallback với dữ liệu test
		//		DataTable dtNhanVien = new DataTable();
		//		dtNhanVien.Columns.Add("Ma_NV");
		//		dtNhanVien.Columns.Add("HoTen");

		//		DataRow allRow = dtNhanVien.NewRow();
		//		allRow["Ma_NV"] = "";
		//		allRow["HoTen"] = "-- Tất cả nhân viên --";
		//		dtNhanVien.Rows.Add(allRow);

		//		// Thêm danh sách nhân viên test
		//		dtNhanVien.Rows.Add("NV001", "Nguyễn Văn A");
		//		dtNhanVien.Rows.Add("NV002", "Trần Thị B");
		//		dtNhanVien.Rows.Add("NV003", "Lê Văn C");
		//		dtNhanVien.Rows.Add("NV004", "Phạm Thị D");
		//		dtNhanVien.Rows.Add("NV005", "Hoàng Văn E");

		//		cb_nhanvien.DataSource = dtNhanVien;
		//		cb_nhanvien.DisplayMember = "HoTen";
		//		cb_nhanvien.ValueMember = "Ma_NV";
		//		cb_nhanvien.SelectedIndex = 0;
		//	}
		//}
		void BindingCommendationData()
		{
			// Clear old bindings
			txb_manhanvien.DataBindings.Clear();
			txb_tennhanvien.DataBindings.Clear();
			cb_nam.DataBindings.Clear();
			txb_manhanvien.DataBindings.Clear();
			txb_tennhanvien.Text = "--Tất cả nhân viên--";



			//txb_manhanvien.DataBindings.Add(new Binding("Text", dgv_ktkltk.DataSource, "TenNV", true, DataSourceUpdateMode.Never));
			//txb_manhanvien.DataBindings.Add(new Binding("Text", dgv_ktkltk.DataSource, "MaNV", true, DataSourceUpdateMode.Never));
			//cb_nam.DataBindings.Add(new Binding("Text", dgv_ktkltk.DataSource, "Nam", true, DataSourceUpdateMode.Never))/*;*/
		}

		void LoadCommendationBC()
		{
			commendationList.DataSource = KhenthuongkyluatDAO.Instance.GetCommendationsStatistic();
		}

		//void LoadCommendationStatisticByMaNV(string manv)
		//{
		//		commendationList.DataSource = KhenthuongkyluatDAO.Instance.GetCommendationByMaNV(manv);
		//		BindingCommendationData();
			
			
		//}
		void LoadCommendationStatisticByNam(string manv, int nam)
		{
			commendationList.DataSource = KhenthuongkyluatDAO.Instance.GetCommendationByNam(manv, nam);
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
		private void ExportToCSV(string filePath)
		{
			try
			{
				// Create a StringBuilder to store CSV content
				StringBuilder csvContent = new StringBuilder();

				// Add header row
				foreach (DataGridViewColumn column in dgv_ktkltk.Columns)
				{
					csvContent.Append(column.HeaderText + ",");
				}
				csvContent.AppendLine();

				// Add data rows
				foreach (DataGridViewRow row in dgv_ktkltk.Rows)
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
		private void btn_thongkenv_Click(object sender, EventArgs e)
		{
			string manv = txb_manhanvien.Text.Trim();

			if (string.IsNullOrEmpty(manv))
			{
				MessageBox.Show("Vui lòng nhập mã nhân viên để thống kê.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			if (cb_nam.SelectedItem == null)
			{
				MessageBox.Show("Vui lòng chọn năm.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
				return;
			}
			int nam = Convert.ToInt32(cb_nam.SelectedItem.ToString());
			LoadCommendationStatisticByNam(manv, nam);
			LoadChart();

			// Hiển thị tên nhân viên từ dòng đầu tiên của dgv_ktkltk (nếu có)
			if (dgv_ktkltk.Rows.Count > 0 && dgv_ktkltk.Rows[0].Cells["TenNV"].Value != null)
			{
				txb_tennhanvien.Text = dgv_ktkltk.Rows[0].Cells["TenNV"].Value.ToString();
			}
			else
			{
				txb_tennhanvien.Text = "";
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
				saveDialog.FileName = $"BangKhenThuongKyLuat_{cb_nam.SelectedItem}_{txb_tennhanvien}.csv";

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
	}
}
