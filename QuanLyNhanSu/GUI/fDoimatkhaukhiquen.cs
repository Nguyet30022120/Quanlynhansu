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
		public fDoimatkhaukhiquen(string email)
		{
			InitializeComponent();
			LoadEmail(email);
		}

		void LoadEmail(string email)
		{
			txb_email.Text = email;
		}


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
					MessageBox.Show("Vui lòng nhập đầy đủ thông tin.");
					return;
				}

				if (newPassword != confirmPassword)
				{
					MessageBox.Show("Mật khẩu mới và xác nhận không khớp.");
					return;
				}


				string username = txb_tendangnhap.Text;
				string email = txb_email.Text;

				bool result = QuanLyNhanSu.DAO.TaikhoanDAO.Instance.DoiMatKhauKhiQuen(username, email, newPassword);

				if (result)
				{
					MessageBox.Show("Đổi mật khẩu thành công!");
					this.Close();
				}
				else
				{
					MessageBox.Show("Đổi mật khẩu thất bại! Vui lòng kiểm tra lại mật khẩu cũ.");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error: " + ex.Message, "ThongBao", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}


		}

		private void btn_dong_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
