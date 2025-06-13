using QuanLyNhanSu.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu.DAO
{
	public class LuongcobanDAO
	{
		private static LuongcobanDAO instance;
		public static LuongcobanDAO Instance
		{
			get { if (instance == null) instance = new LuongcobanDAO(); return instance; }
			private set { instance = value; }
		}
		public LuongcobanDAO() { }

		public List<LuongcobanDTO> GetLuongCoBan()
		{
			List<LuongcobanDTO> list = new List<LuongcobanDTO>();
			string query = "SELECT N.Ma_Luong, N.HoTen, N.Ma_NV, L.LuongCoSo FROM NhanVien N JOIN LuongCoBan L ON N.Ma_Luong = L.Ma_Luong;\r\n";
			DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { });
			foreach (DataRow item in data.Rows)
			{
				LuongcobanDTO luongcoban = new LuongcobanDTO(item);
				list.Add(luongcoban);
			}
			return list;
		}
		public bool UpdateLuongCoBan(string maLuong, decimal luongCoSo)
		{
			string query = $"EXEC USP_UpdateLuongCoSo @MaLuong = '{maLuong}', @LuongCoSo = {luongCoSo};";
			int result = DataProvider.Instance.ExcuteNonQuery(query, new object[] { luongCoSo, maLuong });
			return result > 0;
		}
		public List<LuongcobanDTO> SearchLuongCoBan(string value)
		{
			List<LuongcobanDTO> list = new List<LuongcobanDTO>();
			string query = $"SELECT N.Ma_Luong, N.HoTen, N.Ma_NV, L.LuongCoSo FROM NhanVien N JOIN LuongCoBan L ON N.Ma_Luong = L.Ma_Luong WHERE N.Ma_NV LIKE '{value}' OR N.HoTen LIKE N'%{value}%';\r\n";
			DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { value });
			foreach (DataRow item in data.Rows)
			{
				LuongcobanDTO luongcoban = new LuongcobanDTO(item);
				list.Add(luongcoban);
			}
			return list;
		}
	}
}


