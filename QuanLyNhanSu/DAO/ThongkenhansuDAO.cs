using QuanLyNhanSu.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu.DAO
{
	public class ThongkenhansuDAO
	{
		private static ThongkenhansuDAO instance;
		public static ThongkenhansuDAO Instance
		{
			get { if (instance == null) instance = new ThongkenhansuDAO(); return instance; }
			private set { instance = value; }
		}
		private ThongkenhansuDAO() { }
		public List<ThongkenhansunamnuDTO> GetNamNuStatistics()
		{
			List<ThongkenhansunamnuDTO> list = new List<ThongkenhansunamnuDTO>();
			string query = "SELECT CASE GioiTinh WHEN 1 THEN N'Nam' WHEN 0 THEN N'Nữ' ELSE N'Khác' END AS GioiTinh, COUNT(*) AS SoLuong, CAST(COUNT(*) * 100.0 / (SELECT COUNT(*) FROM [Nhan vien]) AS DECIMAL(5,2)) AS TyLePhanTram FROM [Nhan vien] GROUP BY GioiTinh;\r\n";
			DataTable data = DataProvider.Instance.ExecuteQuery(query);
			foreach (DataRow item in data.Rows)
			{
				ThongkenhansunamnuDTO hrStat = new ThongkenhansunamnuDTO(item);
				list.Add(hrStat);
			}
			return list;
		}
		public List<ThongkenhansuphongbanDTO> GetPhongBanStatistics()
		{
			List<ThongkenhansuphongbanDTO> list = new List<ThongkenhansuphongbanDTO>();
			string query = "SELECT pb.TenPhong AS PhongBan, COUNT(nv.Ma_NV) AS SoLuong FROM [Nhan vien] nv JOIN [Phong Ban] pb ON nv.Ma_PB = pb.Ma_PB GROUP BY pb.TenPhong;\r\n";
			DataTable data = DataProvider.Instance.ExecuteQuery(query);
			foreach (DataRow item in data.Rows)
			{
				ThongkenhansuphongbanDTO hrStat = new ThongkenhansuphongbanDTO(item);
				list.Add(hrStat);
			}
			return list;
		}
		public List<ThongkenhansuchucvuDTO> GetChucVuStatistics()
		{
			List<ThongkenhansuchucvuDTO> list = new List<ThongkenhansuchucvuDTO>();
			string query = "SELECT cv.TenChucVu AS ChucVu, COUNT(nv.Ma_NV) AS SoLuong FROM [Nhan vien] nv JOIN [Chuc Vu] cv ON nv.Ma_ChucVu = cv.Ma_ChucVu GROUP BY cv.TenChucVu;";
			DataTable data = DataProvider.Instance.ExecuteQuery(query);
			foreach (DataRow item in data.Rows)
			{
				ThongkenhansuchucvuDTO hrStat = new ThongkenhansuchucvuDTO(item);
				list.Add(hrStat);
			}
			return list;
		}
	}
}
