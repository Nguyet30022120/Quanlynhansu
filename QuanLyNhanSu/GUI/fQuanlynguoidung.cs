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

namespace QuanLyNhanSu
{
	public partial class fQuanlynguoidung : Form
	{
		private Color originalEditButtonColor;
		private Color originalDeleteButtonColor;
		private Color originalCloseButtonColor;
		BindingSource userList = new BindingSource();

		public fQuanlynguoidung()
		{
			InitializeComponent();
			dgv_nguoidung.DataSource = userList;
			LoadUser();
			BindingUserData();
			originalEditButtonColor = btn_suanguoidung.BackColor;
			originalDeleteButtonColor = btn_xoanguoidung.BackColor;
			originalCloseButtonColor = btn_dongnguoidung.BackColor;
		}
		void LoadUser()
		{
			userList.DataSource = NguoidungDAO.Instance.GetInfoUser();
		}
		void BindingUserData()
		{
			txb_hoten.DataBindings.Add(new Binding("Text", dgv_nguoidung.DataSource, "TenNV", true, DataSourceUpdateMode.Never));
			txb_chucvu.DataBindings.Add(new Binding("Text", dgv_nguoidung.DataSource, "ChucVu", true, DataSourceUpdateMode.Never));
			txb_phongban.DataBindings.Add(new Binding("Text", dgv_nguoidung.DataSource, "CuaHang", true, DataSourceUpdateMode.Never));
			txb_motaquyenhan.DataBindings.Add(new Binding("Text", dgv_nguoidung.DataSource, "MoTaQuyenHan", true, DataSourceUpdateMode.Never));
			cb_vaitro.DataBindings.Add(new Binding("Text", dgv_nguoidung.DataSource, "VaiTro", true, DataSourceUpdateMode.Never));
		}
		#region Hovers
		private void btn_suanguoidung_MouseEnter(object sender, EventArgs e)
		{
			btn_suanguoidung.BackColor = Color.LightBlue;
		}
		private void btn_suanguoidung_MouseLeave(object sender, EventArgs e)
		{
			btn_suanguoidung.BackColor = originalEditButtonColor;
		}
		private void btn_xoanguoidung_MouseEnter(object sender, EventArgs e)
		{
			btn_xoanguoidung.BackColor = Color.LightBlue;
		}
		private void btn_xoanguoidung_MouseLeave(object sender, EventArgs e)
		{
			btn_xoanguoidung.BackColor = originalDeleteButtonColor;
		}
		private void btn_dongnguoidung_MouseEnter(object sender, EventArgs e)
		{
			btn_dongnguoidung.BackColor = Color.LightBlue;
		}
		private void btn_dongnguoidung_MouseLeave(object sender, EventArgs e)
		{
			btn_dongnguoidung.BackColor = originalCloseButtonColor;
		}
		#endregion

		#region Events


		private void btn_dongnguoidung_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btn_suanguoidung_Click(object sender, EventArgs e)
		{
			{

				try
				{

					string matk = dgv_nguoidung.CurrentRow.Cells["MaTK"].Value.ToString();
					string vaiTro = cb_vaitro.Text;
					string moTaQuyenHan = txb_motaquyenhan.Text;

					if (NguoidungDAO.Instance.UpdateUser(matk, vaiTro, moTaQuyenHan))
					{
						MessageBox.Show("Chỉnh sửa người dùng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
					else
					{
						MessageBox.Show("Chỉnh sửa người dùng thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}

				}
				catch (Exception ex)
				{
					MessageBox.Show("Error: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				finally
				{
					LoadUser();
				}
			}
		}

		private void btn_xoanguoidung_Click(object sender, EventArgs e)
		{
			{

				try
				{

					string matk = dgv_nguoidung.CurrentRow.Cells["MaTK"].Value.ToString();

					if (NguoidungDAO.Instance.DeleteUser(matk))
					{
						MessageBox.Show("Xóa người dùng thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
					else
					{
						MessageBox.Show("Xóa người dùng thất bại","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}

				}
				catch (Exception ex)
				{
					MessageBox.Show("Error: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				finally
				{
					LoadUser();
				}
			}
		}
		#endregion

	}
}
