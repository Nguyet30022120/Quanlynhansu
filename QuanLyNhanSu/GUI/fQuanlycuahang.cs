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
	public partial class fQuanlycuahang : Form
	{
		private Color originalAddButtonColor;
		private Color originalEditButtonColor;
		private Color originalDeleteButtonColor;
		private Color originalCloseButtonColor;
		private Color originalSearchButtonColor;

		BindingSource officeList = new BindingSource();

		public fQuanlycuahang()
		{
			InitializeComponent();
			dgv_cuahang.DataSource = officeList;
			LoadOffice();
			BindingOfficeData();
			originalAddButtonColor = btn_themcuahang.BackColor;
			originalEditButtonColor = btn_suacuahang.BackColor;
			originalDeleteButtonColor = btn_xoacuahang.BackColor;
			originalCloseButtonColor = btn_dongcuahang.BackColor;
			originalSearchButtonColor = btn_timcuahang.BackColor;
		}

		void BindingOfficeData()
		{
			txb_tencuahang.DataBindings.Add(new Binding("Text", dgv_cuahang.DataSource, "TenCH", true, DataSourceUpdateMode.Never));
			txb_diachi.DataBindings.Add(new Binding("Text", dgv_cuahang.DataSource, "DiaChi", true, DataSourceUpdateMode.Never));
		}
		void LoadOffice()
		{
			officeList.DataSource = CuahangDAO.Instance.GetListCuaHang();
		}

		#region Events
		private void btn_addpb_Click_1(object sender, EventArgs e)
		{
			try
			{
				string tench = txb_tencuahang.Text;
				string diachi = txb_diachi.Text;
				if (CuahangDAO.Instance.InsertCuaHang(tench, diachi))
				{
					MessageBox.Show("Thêm cửa hàng thành công", "Thông báo");
					LoadOffice();
				}
				else
				{
					MessageBox.Show("Thêm cửa hàng thất bại", "Thông báo");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error: " + ex.Message, "ThongBao", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				LoadOffice();
			}
		}

		private void btn_editpb_Click(object sender, EventArgs e)
		{
			{

				try
				{
					string mach = dgv_cuahang.CurrentRow.Cells["MaCH"].Value.ToString();
					string tench = txb_tencuahang.Text;
					string diachi = txb_diachi.Text;

					if (CuahangDAO.Instance.UpdateCuaHang(mach, tench, diachi))
					{
						MessageBox.Show("Sửa cửa hàng thành công.", "Thông báo");
					}
					else
					{
						MessageBox.Show("Sửa cửa hàng thất bại.", "Thông báo");
					}

				}
				catch (Exception ex)
				{
					MessageBox.Show("Error: " + ex.Message, "ThongBao", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				finally
				{
					LoadOffice();
				}
			}
		}

		private void btn_deletepb_Click(object sender, EventArgs e)
		{
			try
			{
				string mach = dgv_cuahang.CurrentRow.Cells["MaCH"].Value.ToString();

				if (CuahangDAO.Instance.DeleteCuaHang(mach))
				{
					MessageBox.Show("Xóa cửa hàng thành công.", "Thông báo");
				}
				else
				{
					MessageBox.Show("Xóa cửa hàng thất bại.", "Thông báo");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Cửa hàng này hiện vẫn còn nhân viên, hãy điều chuyển nhân viên sang cửa hàng khác rồi xóa!", "Thông báo");
			}
			finally
			{
				LoadOffice();
			}
		}

		private void btn_exitpb_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btn_findpb_Click(object sender, EventArgs e)
		{
			officeList.DataSource = CuahangDAO.Instance.SearchCuaHang(txb_timcuahang.Text);
		}
		#endregion

		#region Hover
		private void btn_themcuahang_MouseEnter(object sender, EventArgs e)
		{
			btn_themcuahang.BackColor = Color.LightBlue;
		}
		private void btn_themcuahang_MouseLeave(object sender, EventArgs e)
		{
			btn_themcuahang.BackColor = originalAddButtonColor;
		}
		private void btn_suacuahang_MouseEnter(object sender, EventArgs e)
		{
			btn_suacuahang.BackColor = Color.LightBlue;
		}
		private void btn_suacuahang_MouseLeave(object sender, EventArgs e)
		{
			btn_suacuahang.BackColor = originalEditButtonColor;
		}
		private void btn_xoacuahang_MouseEnter(object sender, EventArgs e)
		{
			btn_xoacuahang.BackColor = Color.LightBlue;
		}
		private void btn_xoacuahang_MouseLeave(object sender, EventArgs e)
		{
			btn_xoacuahang.BackColor = originalDeleteButtonColor;
		}

		private void btn_dongcuahang_MouseEnter(object sender, EventArgs e)
		{
			btn_dongcuahang.BackColor = Color.LightBlue;
		}
		private void btn_dongcuahang_MouseLeave(object sender, EventArgs e)
		{
			btn_dongcuahang.BackColor = originalCloseButtonColor;
		}
		private void btn_timcuahang_MouseEnter(object sender, EventArgs e)
		{
			btn_timcuahang.BackColor = Color.LightBlue;
		}
		private void btn_timcuahang_MouseLeave(object sender, EventArgs e)
		{
			btn_timcuahang.BackColor = originalSearchButtonColor;
		}
		#endregion

	}
}
