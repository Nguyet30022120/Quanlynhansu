using QuanLyNhanSu.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Sockets;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu.DAO
{
	public class LichsudangnhapDAO
	{
		private static LichsudangnhapDAO instance;
		public static LichsudangnhapDAO Instance
		{
			get
			{
				if (instance == null) instance = new LichsudangnhapDAO();
				return instance;
			}
		}

		public List<LichsudangnhapDTO> GetAll()
		{
			List<LichsudangnhapDTO> list = new List<LichsudangnhapDTO>();
			string query = "SELECT * FROM LichSuDangNhap ORDER BY ThoiGianDangNhap DESC";
			DataTable data = DataProvider.Instance.ExecuteQuery(query);
			foreach (DataRow row in data.Rows)
			{
				list.Add(new LichsudangnhapDTO
				{
					Id = (int)row["Id"],
					UserName = row["UserName"].ToString(),
					ThoiGianDangNhap = (DateTime)row["ThoiGianDangNhap"],
					DiaChiIP = row["DiaChiIP"].ToString()
				});
			}
			return list;
		}

		public void Insert(string userName, DateTime thoiGian, string diaChiIP)
		{
			string query = $"EXEC USP_ThemLichSuDangNhap @UserName = '{userName}', @ThoiGianDangNhap = '{thoiGian}', @DiaChiIP = '{diaChiIP}';\r\n";
			DataProvider.Instance.ExcuteNonQuery(query, new object[] { userName, thoiGian, diaChiIP });

		}
		public string GetLocalIPAddress()
		{
			var host = Dns.GetHostEntry(Dns.GetHostName());
			foreach (var ip in host.AddressList)
			{
				if (ip.AddressFamily == AddressFamily.InterNetwork)
				{
					return ip.ToString();
				}
			}
			return "Unknown";
		}
	}
}
