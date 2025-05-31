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
using static System.Net.WebRequestMethods;
using QuanLyNhanSu.DAO;

namespace QuanLyNhanSu.GUI
{
	public partial class fQuenmatkhau : Form
	{
		Random random = new Random();
		int OTP;
		public fQuenmatkhau()
		{
			InitializeComponent();

		}

		private void btn_huy_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btn_laylaimatkhau_Click(object sender, EventArgs e)
		{
			try
			{
				string email = txb_email.Text.Trim();
				if (!TaikhoanDAO.Instance.IsEmailExists(email))
				{
					MessageBox.Show("Email không tồn tại trong hệ thống.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
					return;
				}

				OTP = random.Next(100000, 1000000);

				var fromAddress = new MailAddress("nguyenminhnguyet356@gmail.com"); // mail dùng để gửi mã otp
				var toAddress = new MailAddress(txb_email.Text.ToString()); // mail dùng để nhận mã otp
				const string frompass = "sivp tyyl aiup zxia"; // mã xác thực 2 lớp rồi nhận mã
				string subject = "OTP code";
				string body = OTP.ToString();

				var smtp = new SmtpClient
				{
					Host = "smtp.gmail.com",
					Port = 587,
					EnableSsl = true,
					DeliveryMethod = SmtpDeliveryMethod.Network,
					UseDefaultCredentials = false,
					Credentials = new NetworkCredential(fromAddress.Address, frompass),
					Timeout = 200000
				};

				using (var message = new MailMessage(fromAddress, toAddress)
				{
					Subject = subject,
					Body = body
				})
				{
					smtp.Send(message);
				}
				MessageBox.Show("Mã xác nhận đã được gửi đến email của bạn. Vui lòng kiểm tra hộp thư đến.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

			}
			catch (Exception ex)
			{
				MessageBox.Show("Đã xảy ra lỗi khi gửi mã xác nhận: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btn_xacnhan_Click(object sender, EventArgs e)
		{
			string email = txb_email.Text.Trim();
			if (OTP.ToString().Equals(txb_OTP.Text))
			{
				MessageBox.Show("Xác minh thành công");
				fDoimatkhaukhiquen f = new fDoimatkhaukhiquen(email);
				f.ShowDialog();
				this.Close(); // Đóng form hiện tại sau khi xác minh thành công
			}
			else
			{
				MessageBox.Show("OTP không chính xác");
			}
		}
	}
}

