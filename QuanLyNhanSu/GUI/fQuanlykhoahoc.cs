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
		private Color originalAddButtonColor;
		private Color originalEditButtonColor;
		private Color originalDeleteButtonColor;
		private Color originalFindButtonColor;
		private Color originalCloseButtonColor;

		BindingSource courseList = new BindingSource();

		public void fCourseManagement_Load(object sender, EventArgs e)
		{
			LoadCourse();
		}
		public fQuanlykhoahoc()
		{
			InitializeComponent();
			dgv_khoahoc.DataSource = courseList;
			LoadCourse();
			BindingCourseData();
			originalAddButtonColor = btn_themkhoahoc.BackColor;
			originalEditButtonColor = btn_suakhoahoc.BackColor;
			originalDeleteButtonColor = btn_xoakhoahoc.BackColor;
			originalFindButtonColor = btn_timkhoahoc.BackColor;
			originalCloseButtonColor = btn_dongkhoahoc.BackColor;

		}
		void BindingCourseData()
		{
			txb_tenkhoahoc.DataBindings.Add(new Binding("Text", dgv_khoahoc.DataSource, "TenKhoaHoc", true, DataSourceUpdateMode.Never));
			txb_mota.DataBindings.Add(new Binding("Text", dgv_khoahoc.DataSource, "MoTaKhoaHoc", true, DataSourceUpdateMode.Never));
		}
		void LoadCourse()
		{
			courseList.DataSource = KhoahocDAO.Instance.GetListCourse();
		}
		#region Events
		private void btn_addkh_Click(object sender, EventArgs e)
		{
			try
			{
				string tenkh = txb_tenkhoahoc.Text;
				string mota = txb_mota.Text;
				if (KhoahocDAO.Instance.InsertCourse(tenkh, mota))
				{
					MessageBox.Show("Thêm khóa học thành công", "Thông báo");
					LoadCourse();
				}
				else
				{
					MessageBox.Show("Thêm khóa học thất bại", "Thông báo");
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
					string tenkh = txb_tenkhoahoc.Text;
					string mota = txb_mota.Text;

					if (KhoahocDAO.Instance.UpdateCourse(makh, tenkh,mota))
					{
						MessageBox.Show("Sửa khóa học thành công.", "Thông báo");
					}
					else
					{
						MessageBox.Show("Sửa khóa học thất bại.", "Thông báo");
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
						MessageBox.Show("Xóa khóa học thành công.", "Thông báo");
					}
					else
					{
						MessageBox.Show("Xóa khóa học thất bại.", "Thông báo");
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
			courseList.DataSource = KhoahocDAO.Instance.SearchCourse(txb_timkhoahoc.Text);
		}
		#endregion

		#region Hover

		private void btn_themkhoahoc_MouseEnter(object sender, EventArgs e)
		{
			btn_themkhoahoc.BackColor = Color.LightBlue;
		}
		private void btn_themkhoahoc_MouseLeave(object sender, EventArgs e)
		{
			btn_themkhoahoc.BackColor = originalAddButtonColor;
		}
		private void btn_suakhoahoc_MouseEnter(object sender, EventArgs e)
		{
			btn_suakhoahoc.BackColor = Color.LightBlue;
		}
		private void btn_suakhoahoc_MouseLeave(object sender, EventArgs e)
		{
			btn_suakhoahoc.BackColor = originalEditButtonColor;
		}
		private void btn_xoakhoahoc_MouseEnter(object sender, EventArgs e)
		{
			btn_xoakhoahoc.BackColor = Color.LightBlue;
		}
		private void btn_xoakhoahoc_MouseLeave(object sender, EventArgs e)
		{
			btn_xoakhoahoc.BackColor = originalDeleteButtonColor;
		}
		private void btn_timkhoahoc_MouseEnter(object sender, EventArgs e)
		{
			btn_timkhoahoc.BackColor = Color.LightBlue;
		}
		private void btn_timkhoahoc_MouseLeave(object sender, EventArgs e)
		{
			btn_timkhoahoc.BackColor = originalFindButtonColor;
		}
		private void btn_dongkhoahoc_MouseEnter(object sender, EventArgs e)
		{
			btn_dongkhoahoc.BackColor = Color.LightBlue;
		}
		private void btn_dongkhoahoc_MouseLeave(object sender, EventArgs e)
		{
			btn_dongkhoahoc.BackColor = originalCloseButtonColor;
		}
		#endregion
	}
}
