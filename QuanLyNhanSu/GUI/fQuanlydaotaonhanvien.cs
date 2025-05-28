using QuanLyNhanSu.DAO;
using QuanLyNhanSu.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Sources;
using System.Windows.Forms;

namespace QuanLyNhanSu
{
	public partial class fQuanlydaotaonhanvien : Form
	{
		BindingSource trainingList = new BindingSource();
		public fQuanlydaotaonhanvien()
		{
			InitializeComponent();
			dgv_daotao.DataSource = trainingList;
			LoadTraining();
			BindingtrainingData();
			LoadCbTrangThai();
			LoadCbKetQua();
			LoadCbKhoaHoc();
		}

		void BindingtrainingData()
		{
			//txb_madt.DataBindings.Add(new Binding("Text", dgv_daotao.DataSource, "MaDT", true, DataSourceUpdateMode.Never));
			txb_tennhanvien.DataBindings.Add(new Binding("Text", dgv_daotao.DataSource, "TenNV", true, DataSourceUpdateMode.Never));
			cb_khoahoc.DataBindings.Add(new Binding("Text", dgv_daotao.DataSource, "TenKH", true, DataSourceUpdateMode.Never));
			cb_ketqua.DataBindings.Add(new Binding("Text", dgv_daotao.DataSource, "KetQua", true, DataSourceUpdateMode.Never));
			cb_trangthai.DataBindings.Add(new Binding("Text", dgv_daotao.DataSource, "TrangThai", true, DataSourceUpdateMode.Never));
		}
		void LoadTraining()
		{
			trainingList.DataSource = DaotaoDAO.Instance.GetListDaoTao();
		}

		void LoadCbTrangThai()
		{
			List<string> trangThai = new List<string>()
			{"Đang học","Hoàn thành"};
			cb_trangthai.DataSource = trangThai;
		}
		void LoadCbKetQua()
		{
			List<string> ketQua = new List<string>()
			{"Đạt","Không Đạt"};
			cb_ketqua.DataSource = ketQua;
		}
		void LoadCbKhoaHoc()
		{
			cb_khoahoc.DataSource = KhoahocDAO.Instance.GetListCourse();
			cb_khoahoc.DisplayMember = "TenKhoaHoc";
			cb_khoahoc.ValueMember = "MaKhoaHoc";
		}

		private void btn_adddt_Click(object sender, EventArgs e)
		{
			try
			{
				string tennv = txb_tennhanvien.Text;
				string tenkh = cb_khoahoc.Text;
				if (DaotaoDAO.Instance.InsertDaoTao(tennv, tenkh))
				{
					MessageBox.Show("Thêm đào tạo thành công");
					LoadTraining();
				}
				else
				{
					MessageBox.Show("Thêm đào tạo thất bại");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error: " + ex.Message, "ThongBao", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				LoadTraining();
			}
		}

		private void editdt_Click(object sender, EventArgs e)
		{
			{

				try
				{
					string madt = dgv_daotao.CurrentRow.Cells["MaDT"].Value.ToString();
					string tennv = txb_tennhanvien.Text;
					string tenkh = cb_khoahoc.Text;
					string trangthai = cb_trangthai.Text;
					string ketqua = cb_ketqua.Text;

					if (DaotaoDAO.Instance.UpdateDaoTao(madt, tennv,tenkh,trangthai,ketqua))
					{
						MessageBox.Show("Sửa đào tạo thành công.");
					}
					else
					{
						MessageBox.Show("Sửa đào tạo thất bại.");
					}

				}
				catch (Exception ex)
				{
					MessageBox.Show("Error: " + ex.Message, "ThongBao", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				finally
				{
					LoadTraining();
				}
			}
		}

		private void btn_deletedt_Click(object sender, EventArgs e)
		{
			{

				try
				{
					string madt = dgv_daotao.CurrentRow.Cells["MaDT"].Value.ToString();

					if (DaotaoDAO.Instance.DeleteDaoTao(madt))
					{
						MessageBox.Show("Xóa đào tạo thành công.");
					}
					else
					{
						MessageBox.Show("Xóa đào tạo thất bại.");
					}

				}
				catch (Exception ex)
				{
					MessageBox.Show("Error: " + ex.Message, "ThongBao", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				finally
				{
					LoadTraining();
				}
			}
		}

		private void btn_closedt_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btn_finddt_Click(object sender, EventArgs e)
		{
			trainingList.DataSource = DaotaoDAO.Instance.SearchTraining(txb_finddt.Text);
		}

		private void btn_viewkh_Click(object sender, EventArgs e)
		{
			fQuanlykhoahoc f = new fQuanlykhoahoc();
			this.Hide();
			f.ShowDialog();
			this.Show();
		}
	}
}
