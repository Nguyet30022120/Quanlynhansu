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
			string query = "SELECT CASE GioiTinh WHEN 1 THEN N'Nam' WHEN 0 THEN N'Nữ' ELSE N'Khác' END AS GioiTinh, COUNT(*) AS SoLuong, CAST(COUNT(*) * 100.0 / (SELECT COUNT(*) FROM [NhanVien]) AS DECIMAL(5,2)) AS TyLePhanTram FROM [NhanVien] GROUP BY GioiTinh;\r\n";
			DataTable data = DataProvider.Instance.ExecuteQuery(query);
			foreach (DataRow item in data.Rows)
			{
				ThongkenhansunamnuDTO hrStat = new ThongkenhansunamnuDTO(item);
				list.Add(hrStat);
			}
			return list;
		}
		public List<ThongkenhansucuahangDTO> GetPhongBanStatistics()
		{
			List<ThongkenhansucuahangDTO> list = new List<ThongkenhansucuahangDTO>();
			string query = "SELECT ch.TenCuaHang AS CuaHang, COUNT(nv.Ma_NV) AS SoLuong FROM [NhanVien] nv JOIN [CuaHang] ch ON nv.Ma_CH = ch.Ma_CH GROUP BY ch.TenCuaHang;\r\n";
			DataTable data = DataProvider.Instance.ExecuteQuery(query);
			foreach (DataRow item in data.Rows)
			{
				ThongkenhansucuahangDTO hrStat = new ThongkenhansucuahangDTO(item);
				list.Add(hrStat);
			}
			return list;
		}
		public List<ThongkenhansuchucvuDTO> GetChucVuStatistics()
		{
			List<ThongkenhansuchucvuDTO> list = new List<ThongkenhansuchucvuDTO>();
			string query = "SELECT cv.TenChucVu AS ChucVu, COUNT(nv.Ma_NV) AS SoLuong FROM [NhanVien] nv JOIN [ChucVu] cv ON nv.Ma_CV = cv.Ma_CV GROUP BY cv.TenChucVu;";
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
