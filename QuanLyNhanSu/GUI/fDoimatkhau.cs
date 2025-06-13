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
		private Color originalEditButtonColor;
		private Color originalCloseButtonColor;
		public fDoimatkhau(string userName)
		{
			InitializeComponent();
			LoadDataUser(userName);
			originalEditButtonColor = btn_doimatkhau.BackColor;
			originalCloseButtonColor = btn_dong.BackColor;
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
				MessageBox.Show("Không tìm thấy dữ liệu cho nhân viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		#region Hovers
		private void btn_doimatkhau_MouseEnter(object sender, EventArgs e)
		{
			btn_doimatkhau.BackColor = Color.LightBlue;
		}
		private void btn_doimatkhau_MouseLeave(object sender, EventArgs e)
		{
			btn_doimatkhau.BackColor = originalEditButtonColor;
		}
		private void btn_exit_MouseEnter(object sender, EventArgs e)
		{
			btn_dong.BackColor = Color.LightBlue;
		}
		private void btn_exit_MouseLeave(object sender, EventArgs e)
		{
			btn_dong.BackColor = originalCloseButtonColor;
		}
		#endregion

		#region Events

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
					MessageBox.Show("Vui lòng nhập đầy đủ thông tin.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
					return;
				}

				if (newPassword != confirmPassword)
				{
					MessageBox.Show("Mật khẩu mới và xác nhận không khớp.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}

		
				string username = txb_tendangnhap.Text; 

				bool result = QuanLyNhanSu.DAO.TaikhoanDAO.Instance.DoiMatKhau(username, currentPassword, newPassword);

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

		private void btn_exit_Click(object sender, EventArgs e)
		{
			this.Close();
		}
		#endregion
	}
}
