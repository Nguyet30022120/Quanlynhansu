using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using System.Net.Mail;
using System.Windows.Forms;

namespace QuanLyNhanSu.GUI
{
	public partial class fQuenmatkhau : Form
	{
		public fQuenmatkhau()
		{
			InitializeComponent();
			//lblMessage = new Label
			//{
			//	AutoSize = true,
			//	Location = new Point(10, 100), // Adjust location as needed
			//	ForeColor = Color.Red // Optional styling
			//};
			//this.Controls.Add(lblMessage);
		}

		private void btn_huy_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btn_laylaimatkhau_Click(object sender, EventArgs e)
		{
			string email = txb_email.Text.Trim();

			//if (IsValidEmail(email))
			//{
			//	// Gửi mã xác nhận qua email (giả sử bạn có hàm gửi email ở đây)
			SendPasswordResetEmail(email);
			//	lblMessage.Text = "Mã xác nhận đã được gửi tới email của bạn!";
			//}
			//else
			//{
			//	lblMessage.Text = "Vui lòng nhập email hợp lệ!";
			//}
		}
		private bool IsValidEmail(string email)
		{
			try
			{
				var addr = new System.Net.Mail.MailAddress(email);
				return addr.Address == email;
			}
			catch
			{
				return false;
			}
		}

		// Hàm giả lập gửi mã xác nhận qua email
		private void SendPasswordResetEmail(string email)
		{
			var fromAddress = new MailAddress("nguyenminhnguyet356@gmail.com", "Your Name");
			var toAddress = new MailAddress(email);
			const string fromPassword = "Nguyenminhnguyet30022120*";
			const string subject = "Mã xác nhận quên mật khẩu";
			const string body = "Đây là mã xác nhận của bạn: 123456";

			var smtp = new SmtpClient
			{
				Host = "smtp.gmail.com",
				Port = 587,
				EnableSsl = true,
				DeliveryMethod = SmtpDeliveryMethod.Network,
				UseDefaultCredentials = false,
				Credentials = new NetworkCredential(fromAddress.Address, fromPassword)
			};

			using (var message = new MailMessage(fromAddress, toAddress)
			{
				Subject = subject,
				Body = body
			})
			{
				smtp.Send(message);
			}
		}
	}
}

