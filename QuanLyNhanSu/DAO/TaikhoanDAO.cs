using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Security.Cryptography;
using QuanLyNhanSu.DTO;
using QuanLyNhanSu.DAO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace QuanLyNhanSu.DAO
{
	public class TaikhoanDAO
	{
		private static TaikhoanDAO instance;

		public static TaikhoanDAO Instance { get => instance==null ? instance = new TaikhoanDAO() : instance; private set => instance=value; }

		private TaikhoanDAO() { }

		public bool Login(string userName, string passWord)
		{
			byte[] temp = ASCIIEncoding.ASCII.GetBytes(passWord);
			byte[] hasData = new MD5CryptoServiceProvider().ComputeHash(temp);

			string hasPass = "";
			foreach (byte item in hasData)
			{
				hasPass += item;
			}



			string query = "USP_Login @userName ,@passWord";

			DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { userName, hasPass });

			return result.Rows.Count > 0;
		}

		public TaikhoanDTO GetAccountByUserName(string userName)
		{
			DataTable data = DataProvider.Instance.ExecuteQuery("Select * from [Tai Khoan] where TaiKhoan = '" + userName + "'");

			foreach (DataRow item in data.Rows)
			{
				return new TaikhoanDTO(item);
			}
			return null;
		}

		public string GetAccountRole(string userName)
		{
			
				return DataProvider.Instance.ExcuteScalar("Select VaiTro from [Tai Khoan] where TaiKhoan = @userName", new object[] { userName }).ToString();
			
		}
		public string GetNameNvByUsername(string userName)
		{
			string name = DataProvider.Instance.ExcuteScalar("SELECT nv.HoTen FROM [dbo].[Nhan vien] nv INNER JOIN [dbo].[Tai khoan] tk ON nv.Ma_TK = tk.Ma_TK WHERE tk.TaiKhoan = @username ;", new object[] { userName }).ToString();
			return name;
		
		}

		public bool DoiMatKhau(string username, string matKhauCu, string matKhauMoi)
		{
			// Hash old password
			byte[] temp1 = ASCIIEncoding.ASCII.GetBytes(matKhauCu);
			byte[] hasData1 = new MD5CryptoServiceProvider().ComputeHash(temp1);
			string hasPass1 = "";
			foreach (byte item in hasData1)
			{
				hasPass1 += item;
			}

			// Hash new password
			byte[] temp2 = ASCIIEncoding.ASCII.GetBytes(matKhauMoi);
			byte[] hasData2 = new MD5CryptoServiceProvider().ComputeHash(temp2);
			string hasPass2 = "";
			foreach (byte item in hasData2)
			{
				hasPass2 += item;
			}

			string query = $"EXEC USP_UpdateMatKhau @TaiKhoan = '{username}', @MatKhauCu = '{hasPass1}', @MatKhauMoi = '{hasPass2}';";

			int re = Convert.ToInt32(DataProvider.Instance.ExcuteScalar(query));

			return re == 0;
		}
		public bool DoiMatKhauKhiQuen(string username, string email, string matKhauMoi)
		{


			// Hash new password
			byte[] temp2 = ASCIIEncoding.ASCII.GetBytes(matKhauMoi);
			byte[] hasData2 = new MD5CryptoServiceProvider().ComputeHash(temp2);
			string hasPass2 = "";
			foreach (byte item in hasData2)
			{
				hasPass2 += item;
			}

			string query = $"EXEC USP_ResetMatKhau @TaiKhoan = '{username}',   @Email = '{email}',@MatKhauMoi = '{hasPass2}';";

			int re = Convert.ToInt32(DataProvider.Instance.ExcuteScalar(query));

			return re == 0;
		}
		public bool IsEmailExists(string email)
		{
			string query = "SELECT COUNT(*) FROM [Nhan vien] WHERE Email = @Email";
			int count = Convert.ToInt32(DataProvider.Instance.ExcuteScalar(query, new object[] { email }));
			return count > 0;
		}
	}
}
