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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;
using System.Drawing;
using QuanLyNhanSu.GUI;

namespace QuanLyNhanSu
{
	public partial class fDangnhap : Form
	{
		private Color originalLoginButtonColor; 
		private Color originalExitButtonColor; 
		public fDangnhap()
		{
			InitializeComponent();
			originalLoginButtonColor = btn_login.BackColor;
			originalExitButtonColor = btn_exit.BackColor; 
		}

		#region Events
		private void btn_login_Click(object sender, EventArgs e)
		{
			string userName = txb_username.Text;
			string passWord = txb_password.Text;

			if (Login(txb_username.Text, txb_password.Text))
			{
				// Lưu lịch sử đăng nhập
				string diaChiIP = LichsudangnhapDAO.Instance.GetLocalIPAddress();
				DateTime thoiGian = DateTime.Now;
				LichsudangnhapDAO.Instance.Insert(userName, thoiGian, diaChiIP);

				TaikhoanDTO loginAccount = TaikhoanDAO.Instance.GetAccountByUserName(userName);
				string role = TaikhoanDAO.Instance.GetAccountRole(userName);

				if (role == "Admin")
				{
					AdminDashboard f = new AdminDashboard(userName);
					this.Hide();
					f.ShowDialog();
					this.Show();
				}
				if (role == "User")
				{
					fUserDashboard f = new fUserDashboard(userName);
					this.Hide();
					f.ShowDialog();
					this.Show();
				}
			}
			else
			{
				MessageBox.Show("Sai tên tài khoản hoặc mật khẩu!", "Thông báo" ,MessageBoxButtons.OK, MessageBoxIcon.Error);
			}

			bool Login(string userName1, string passWord1)
			{
				return TaikhoanDAO.Instance.Login(userName, passWord);
			}
		}
		private void lb_quenmk_Click(object sender, EventArgs e)
		{
			fQuenmatkhau quenmatkhauForm = new fQuenmatkhau();
			this.Hide();
			quenmatkhauForm.ShowDialog();
			this.Show();
		}

		private void btn_exit_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}
		#endregion

		#region Hovers
		private void btn_login_MouseEnter(object sender, EventArgs e)
		{
			btn_login.BackColor = System.Drawing.Color.LightBlue; 
		}
		private void btn_login_MouseLeave(object sender, EventArgs e)
		{
			btn_login.BackColor = originalLoginButtonColor;
		}
		private void btn_exit_MouseEnter(object sender, EventArgs e)
		{
			btn_exit.BackColor = System.Drawing.Color.LightBlue;
		}
		private void btn_exit_MouseLeave(object sender, EventArgs e)
		{
			btn_exit.BackColor = originalExitButtonColor;
		}

		private void chb_hienmk_CheckedChanged(object sender, EventArgs e)
		{
			txb_password.UseSystemPasswordChar = !chb_hienmk.Checked;
		}
		#endregion




	}
}
