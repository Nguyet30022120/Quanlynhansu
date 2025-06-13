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

namespace QuanLyNhanSu.GUI
{
	public partial class fDoimatkhaukhiquen : Form
	{
		private Color originalCloseButtonColor;
		private Color originalChangeButtonColor;
		public fDoimatkhaukhiquen(string email)
		{
			InitializeComponent();
			LoadEmail(email);
			originalCloseButtonColor = btn_dong.BackColor;
			originalChangeButtonColor = btn_doimatkhau.BackColor;
		}

		void LoadEmail(string email)
		{
			txb_email.Text = email;
		}
		#region Hovers
		private void btn_doimatkhau_MouseEnter(object sender, EventArgs e)
		{
			btn_doimatkhau.BackColor = Color.LightBlue;
		}
		private void btn_doimatkhau_MouseLeave(object sender, EventArgs e)
		{
			btn_doimatkhau.BackColor = originalChangeButtonColor;
		}
		private void btn_dong_MouseEnter(object sender, EventArgs e)
		{
			btn_dong.BackColor = Color.LightBlue;
		}
		private void btn_dong_MouseLeave(object sender, EventArgs e)
		{
			btn_dong.BackColor = originalCloseButtonColor;
		}
		#endregion

		#region Events
		private void btn_doimatkhau_Click_1(object sender, EventArgs e)
		{
			try
			{
				string newPassword = txb_matkhaumoi.Text;
				string confirmPassword = txb_nhaplaimatkhaumoi.Text;

				if
				(
					string.IsNullOrWhiteSpace(newPassword) ||
					string.IsNullOrWhiteSpace(confirmPassword))
				{
					MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
					return;
				}

				if (newPassword != confirmPassword)
				{
					MessageBox.Show("Mật khẩu mới và xác nhận không khớp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}

				string username = txb_tendangnhap.Text;
				string email = txb_email.Text;

				bool result = QuanLyNhanSu.DAO.TaikhoanDAO.Instance.DoiMatKhauKhiQuen(username, email, newPassword);

				if (result)
				{
					MessageBox.Show("Đổi mật khẩu thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
					this.Close();
				}
				else
				{
					MessageBox.Show("Đổi mật khẩu thất bại! Vui lòng kiểm tra lại mật khẩu cũ.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}


		}

		private void btn_dong_Click(object sender, EventArgs e)
		{
			this.Close();
		}
		#endregion
	}
}
