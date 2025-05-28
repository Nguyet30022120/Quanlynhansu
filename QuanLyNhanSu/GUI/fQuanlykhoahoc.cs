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

namespace QuanLyNhanSu.GUI
{
	public partial class fQuanlykhoahoc : Form
	{
		BindingSource courseList = new BindingSource();

		public void fCourseManagement_Load(object sender, EventArgs e)
		{
			// Add logic to initialize the form when it loads  
			LoadCourse();
		}
		public fQuanlykhoahoc()
		{
			InitializeComponent();
			dgv_khoahoc.DataSource = courseList;
			LoadCourse();
			BindingCourseData();
		}
		void BindingCourseData()
		{
			//txb_makh.DataBindings.Add(new Binding("Text", dgv_khoahoc.DataSource, "MaKhoaHoc", true, DataSourceUpdateMode.Never));
			txb_tenkh.DataBindings.Add(new Binding("Text", dgv_khoahoc.DataSource, "TenKhoaHoc", true, DataSourceUpdateMode.Never));
			txb_motakh.DataBindings.Add(new Binding("Text", dgv_khoahoc.DataSource, "MoTaKhoaHoc", true, DataSourceUpdateMode.Never));
		}
		void LoadCourse()
		{
			courseList.DataSource = KhoahocDAO.Instance.GetListCourse();
		}

		private void btn_addkh_Click(object sender, EventArgs e)
		{
			try
			{
				string tenkh = txb_tenkh.Text;
				string mota = txb_motakh.Text;
				if (KhoahocDAO.Instance.InsertCourse(tenkh, mota))
				{
					MessageBox.Show("Thêm khóa học thành công");
					LoadCourse();
				}
				else
				{
					MessageBox.Show("Thêm khóa học thất bại");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error: " + ex.Message, "ThongBao", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				LoadCourse();
			}
		}

		private void btn_editkh_Click(object sender, EventArgs e)
		{
			{

				try
				{
					string makh = dgv_khoahoc.CurrentRow.Cells["MaKH"].Value.ToString();
					string tenkh = txb_tenkh.Text;
					string mota = txb_motakh.Text;

					if (KhoahocDAO.Instance.UpdateCourse(makh, tenkh,mota))
					{
						MessageBox.Show("Sửa khóa học thành công.");
					}
					else
					{
						MessageBox.Show("Sửa khóa học thất bại.");
					}

				}
				catch (Exception ex)
				{
					MessageBox.Show("Error: " + ex.Message, "ThongBao", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				finally
				{
					LoadCourse();
				}
			}
		}

		private void btn_deletekh_Click(object sender, EventArgs e)
		{
			{

				try
				{
					string makh = dgv_khoahoc.CurrentRow.Cells["MaKH"].Value.ToString();


					if (KhoahocDAO.Instance.DeleteCourse(makh))
					{
						MessageBox.Show("Xóa khóa học thành công.");
					}
					else
					{
						MessageBox.Show("Xóa khóa học thất bại.");
					}

				}
				catch (Exception ex)
				{
					MessageBox.Show("Error: " + ex.Message, "ThongBao", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				finally
				{
					LoadCourse();
				}
			}
		}

		private void btn_closekh_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btn_findkh_Click(object sender, EventArgs e)
		{
			courseList.DataSource = KhoahocDAO.Instance.SearchCourse(txb_findkh.Text);
		}
	}
}
