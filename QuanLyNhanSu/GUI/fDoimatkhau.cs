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

namespace QuanLyNhanSu
{
	public partial class fDoimatkhau : Form
	{
		public fDoimatkhau(string userName)
		{
			InitializeComponent();
			LoadDataUser(userName);
		}
		void LoadDataUser(string userName)
		{
			List<NguoidungDTO> data = NguoidungDAO.Instance.GetInforNVByUsername(userName);

			if (data.Count > 0)
			{
				NguoidungDTO user = data[0];
				txb_tendangnhap.Text = user.TaiKhoan;
			}
			else
			{
				MessageBox.Show("No data found for the given username.");
			}
		}
		private void btn_doimatkhau_Click(object sender, EventArgs e)
		{
			try
			{
				string currentPassword = txb_matkhaucu.Text;
				string newPassword = txb_matkhaumoi.Text;
				string confirmPassword = txb_nhaplaimatkhaumoi.Text;

				if (string.IsNullOrWhiteSpace(currentPassword) ||
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

				bool result = QuanLyNhanSu.DAO.TaikhoanDAO.Instance.DoiMatKhau(username, currentPassword, newPassword);

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

		private void btn_exit_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
