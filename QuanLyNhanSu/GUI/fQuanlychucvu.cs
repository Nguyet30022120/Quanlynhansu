using QuanLyNhanSu.DAO;
using QuanLyNhanSu.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanSu
{
	public partial class fQuanlychucvu : Form
	{
		private Color originalAddButtonColor;
		private Color originalEditButtonColor;
		private Color originalDeleteButtonColor;
		private Color originalCloseButtonColor;
		private Color originalSearchButtonColor;

		BindingSource positionList = new BindingSource();
		public fQuanlychucvu()
		{
			InitializeComponent();
			dgv_chucvu.DataSource = positionList;
			LoadPosition();
			BindingPositionData();
			originalAddButtonColor = btn_themchucvu.BackColor;
			originalEditButtonColor = btn_suachucvu.BackColor;
			originalDeleteButtonColor = btn_xoachucvu.BackColor;
			originalCloseButtonColor = btn_dongchucvu.BackColor;
			originalSearchButtonColor = btn_timchucvu.BackColor;

		}
		void BindingPositionData()
		{
			txb_tenchucvu.DataBindings.Add(new Binding("Text", dgv_chucvu.DataSource, "TenChucVu", true, DataSourceUpdateMode.Never));
			txb_motachucvu.DataBindings.Add(new Binding("Text", dgv_chucvu.DataSource, "MoTaChucVu", true, DataSourceUpdateMode.Never));
		}
		void LoadPosition()
		{
			positionList.DataSource = ChucvuDAO.Instance.GetListChucVu();
		}
		#region Events
		private void btn_addcv_Click(object sender, EventArgs e)
		{
			try
			{
				string tencv = txb_tenchucvu.Text;
				string motachuvu = txb_motachucvu.Text;
				if (ChucvuDAO.Instance.InsertPosition(tencv, motachuvu))
				{
					MessageBox.Show("Thêm chức vụ thành công","Thông báo");
					LoadPosition();
				}
				else
				{
					MessageBox.Show("Thêm chức vụ thất bại", "Thông báo");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error: " + ex.Message, "ThongBao", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				LoadPosition();
			}
		}

		private void btn_editcv_Click(object sender, EventArgs e)
		{
			{
				try
				{
					int macv = Convert.ToInt32(dgv_chucvu.CurrentRow.Cells["MaCV"].Value);
					string tencv = txb_tenchucvu.Text;
					string motachucvu = txb_motachucvu.Text;

					if (ChucvuDAO.Instance.UpdatePosition(macv, tencv, motachucvu))
					{
						MessageBox.Show("Sửa chức vụ thành công.", "Thông báo");
					}
					else
					{
						MessageBox.Show("Sửa chức vụ thất bại.", "Thông báo");
					}

				}
				catch (Exception ex)
				{
					MessageBox.Show("Error: " + ex.Message, "ThongBao", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				finally
				{
					LoadPosition();
				}
			}
		}

		private void btn_deletecv_Click(object sender, EventArgs e)
		{
			{

				try
				{
					int macv = Convert.ToInt32(dgv_chucvu.CurrentRow.Cells["MaCV"].Value);

					if (ChucvuDAO.Instance.DeletePosition(macv))
					{
						MessageBox.Show("Xóa chức vụ thành công.", "Thông báo");
					}
					else
					{
						MessageBox.Show("Xóa chức vụ thất bại.", "Thông báo");
					}

				}
				catch (Exception ex)
				{
					MessageBox.Show("Error: " + ex.Message, "ThongBao", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				finally
				{
					LoadPosition();
				}
			}
		}

		private void btn_closecv_Click(object sender, EventArgs e)
		{
			this.Close();
		}
		private void btn_findcv_Click(object sender, EventArgs e)
		{
			positionList.DataSource = ChucvuDAO.Instance.SearchPosition(txb_timchucvu.Text);
		}
		#endregion

		#region Hover
		private void btn_timchucvu_MouseEnter(object sender, EventArgs e)
		{
			btn_timchucvu.BackColor = Color.LightBlue;
		}
		private void btn_timchucvu_MouseLeave(object sender, EventArgs e)
		{
			btn_timchucvu.BackColor = originalSearchButtonColor;
		}
		private void btn_themchucvu_MouseEnter(object sender, EventArgs e)
		{
			btn_themchucvu.BackColor = Color.LightBlue;
		}
		private void btn_themchucvu_MouseLeave(object sender, EventArgs e)
		{
			btn_themchucvu.BackColor = originalAddButtonColor;
		}
		private void btn_suachucvu_MouseEnter(object sender, EventArgs e)
		{
			btn_suachucvu.BackColor = Color.LightBlue;
		}
		private void btn_suachucvu_MouseLeave(object sender, EventArgs e)
		{
			btn_suachucvu.BackColor = originalEditButtonColor;
		}
		private void btn_xoachucvu_MouseEnter(object sender, EventArgs e)
		{
			btn_xoachucvu.BackColor = Color.LightBlue;
		}
		private void btn_xoachucvu_MouseLeave(object sender, EventArgs e)
		{
			btn_xoachucvu.BackColor = originalDeleteButtonColor;
		}
		private void btn_dongchucvu_MouseEnter(object sender, EventArgs e)
		{
			btn_dongchucvu.BackColor = Color.LightBlue;
		}
		private void btn_dongchucvu_MouseLeave(object sender, EventArgs e)
		{
			btn_dongchucvu.BackColor = originalCloseButtonColor;
		}
		#endregion
	}
}
