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
		private Color originalGuiMaButtonColor;
		private Color originalXacNhanButtonColor;
		private Color originalHuyButtonColor;
		Random random = new Random();
		int OTP;
		public fQuenmatkhau()
		{
			InitializeComponent();
			originalGuiMaButtonColor = btn_guiyeucau.BackColor;
			originalXacNhanButtonColor = btn_xacnhan.BackColor;
			originalHuyButtonColor = btn_huy.BackColor;

		}
		#region Events
		private void btn_laylaimatkhau_Click(object sender, EventArgs e)
		{
			try
			{
				string email = txb_email.Text.Trim();
				if (!TaikhoanDAO.Instance.IsEmailExists(email))
				{
					MessageBox.Show("Email không tồn tại trong hệ thống.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}

				OTP = random.Next(100000, 1000000);

				var fromAddress = new MailAddress("nguyenminhnguyet356@gmail.com"); // mail dùng để gửi mã otp
				var toAddress = new MailAddress(txb_email.Text.ToString()); 
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
				MessageBox.Show("Xác minh thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				fDoimatkhaukhiquen f = new fDoimatkhaukhiquen(email);
				f.ShowDialog();
				this.Close();
			}
			else
			{
				MessageBox.Show("OTP không chính xác", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btn_huy_Click(object sender, EventArgs e)
		{
			this.Close();
		}
		#endregion

		#region Hovers
		private void btn_guiyeucau_MouseEnter(object sender, EventArgs e)
		{
			btn_guiyeucau.BackColor = Color.LightBlue;
		}
		private void btn_guiyeucau_MouseLeave(object sender, EventArgs e)
		{
			btn_guiyeucau.BackColor = originalGuiMaButtonColor;
		}
		private void btn_xacnhan_MouseEnter(object sender, EventArgs e)
		{
			btn_xacnhan.BackColor = Color.LightBlue;
		}
		private void btn_xacnhan_MouseLeave(object sender, EventArgs e)
		{
			btn_xacnhan.BackColor = originalXacNhanButtonColor;
		}
		private void btn_huy_MouseEnter(object sender, EventArgs e)
		{
			btn_huy.BackColor = Color.LightBlue;
		}
		private void btn_huy_MouseLeave(object sender, EventArgs e)
		{
			btn_huy.BackColor = originalHuyButtonColor;
		}
		#endregion



	}
}

