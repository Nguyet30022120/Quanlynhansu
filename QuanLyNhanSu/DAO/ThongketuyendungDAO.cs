using QuanLyNhanSu.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu.DAO
{
	public class ThongketuyendungDAO
	{
		private static ThongketuyendungDAO instance;
		public static ThongketuyendungDAO Instance
		{
			get { if (instance == null) instance = new ThongketuyendungDAO(); return instance; }
			private set { instance = value; }
		}
		private ThongketuyendungDAO() { }
		public List<ThongketuyendungDTO> GetTyLeTuyenDung(int nam, int thang)
		{
			List<ThongketuyendungDTO> list = new List<ThongketuyendungDTO>();
			string query;
			if (thang > 0)
			{
				// Lấy theo tháng cụ thể
				query = $"SELECT KetLuan, COUNT(*) AS SoLuong, YEAR(NgayDanhGia) AS Nam, MONTH(NgayDanhGia) AS Thang FROM KetQuaPhongVan WHERE YEAR(NgayDanhGia) = '{nam}' AND MONTH(NgayDanhGia) = '{thang}' GROUP BY KetLuan, YEAR(NgayDanhGia), MONTH(NgayDanhGia) ORDER BY KetLuan;";
			}
			else
			{
				// Lấy tất cả các tháng trong năm
				query = $"SELECT KetLuan, COUNT(*) AS SoLuong, YEAR(NgayDanhGia) AS Nam, MONTH(NgayDanhGia) AS Thang FROM KetQuaPhongVan WHERE YEAR(NgayDanhGia) = '{nam}' GROUP BY KetLuan, YEAR(NgayDanhGia), MONTH(NgayDanhGia) ORDER BY Thang, KetLuan;";
			}
			DataTable data = DataProvider.Instance.ExecuteQuery(query);
			foreach (DataRow item in data.Rows)
			{
				ThongketuyendungDTO td = new ThongketuyendungDTO(item);
				list.Add(td);
			}
			return list;
		}
	}
}
