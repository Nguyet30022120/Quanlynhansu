using QuanLyNhanSu.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu.DAO
{
	public class CheckoutDAO
	{
		private static CheckoutDAO instance;
		public static CheckoutDAO Instance
		{
			get { if (instance == null) instance = new CheckoutDAO(); return instance; }
			private set { instance = value; }
		}

		public List<CheckoutDTO> GetCheckOutByMaNV(string manv)
		{
			List<CheckoutDTO> list = new List<CheckoutDTO>();
			string query = $"SELECT c.MaCheckOut, c.Ma_NV, c.GioCheckOut, c.NgayCheckOut, n.HoTen FROM CheckOut c JOIN [Nhan Vien] n ON c.Ma_NV = n.Ma_NV WHERE n.Ma_NV ='{manv}';\r\n";
			DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { });
			foreach (DataRow item in data.Rows)
			{
				CheckoutDTO checkout = new CheckoutDTO(item);
				list.Add(checkout);
			}
			return list;
		}
		public bool InsertCheckOut(string manv)
		{
			string query = $"EXEC USP_InsertCheckOut @MaNV = '{manv}';";
			int re = DataProvider.Instance.ExcuteNonQuery(query);
			return re != 0;
		}

		public bool UpdateCheckOut(string manv, DateTime thoigiancheckout, DateTime ngaycheckout)
		{
			string query = $"EXEC USP_UpdateCheckOut @Ma_NV = '{manv}',@NgayCheckIn = '{ngaycheckout}',@GioMoi = '{thoigiancheckout}';";
			int re = DataProvider.Instance.ExcuteNonQuery(query);
			return re != 0;
		}
		public bool DeleteCheckOut(int maCheckOut)
		{
			string query = $"EXEC USP_DeleteCheckOut @MaCheckOut = '{maCheckOut}';";
			int re = DataProvider.Instance.ExcuteNonQuery(query);
			return re != 0;
		}
	}
}
