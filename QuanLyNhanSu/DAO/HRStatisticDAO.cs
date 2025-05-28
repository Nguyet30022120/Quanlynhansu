using QuanLyNhanSu.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu.DAO
{
	public class HRStatisticDAO
	{
		private static HRStatisticDAO instance;
		public static HRStatisticDAO Instance
		{
			get { if (instance == null) instance = new HRStatisticDAO(); return instance; }
			private set { instance = value; }
		}
		private HRStatisticDAO() { }
		public List<HRStatisticNamNuDTO> GetNamNuStatistics()
		{
			List<HRStatisticNamNuDTO> list = new List<HRStatisticNamNuDTO>();
			string query = "SELECT CASE GioiTinh WHEN 1 THEN N'Nam' WHEN 0 THEN N'Nữ' ELSE N'Khác' END AS GioiTinh, COUNT(*) AS SoLuong, CAST(COUNT(*) * 100.0 / (SELECT COUNT(*) FROM [Nhan vien]) AS DECIMAL(5,2)) AS TyLePhanTram FROM [Nhan vien] GROUP BY GioiTinh;\r\n";
			DataTable data = DataProvider.Instance.ExecuteQuery(query);
			foreach (DataRow item in data.Rows)
			{
				HRStatisticNamNuDTO hrStat = new HRStatisticNamNuDTO(item);
				list.Add(hrStat);
			}
			return list;
		}
		public List<HRStatisticPBDTO> GetPhongBanStatistics()
		{
			List<HRStatisticPBDTO> list = new List<HRStatisticPBDTO>();
			string query = "SELECT pb.TenPhong AS PhongBan, COUNT(nv.Ma_NV) AS SoLuong FROM [Nhan vien] nv JOIN [Phong Ban] pb ON nv.Ma_PB = pb.Ma_PB GROUP BY pb.TenPhong;\r\n";
			DataTable data = DataProvider.Instance.ExecuteQuery(query);
			foreach (DataRow item in data.Rows)
			{
				HRStatisticPBDTO hrStat = new HRStatisticPBDTO(item);
				list.Add(hrStat);
			}
			return list;
		}
		public List<HRStatisticCVDTO> GetChucVuStatistics()
		{
			List<HRStatisticCVDTO> list = new List<HRStatisticCVDTO>();
			string query = "SELECT cv.TenChucVu AS ChucVu, COUNT(nv.Ma_NV) AS SoLuong FROM [Nhan vien] nv JOIN [Chuc Vu] cv ON nv.Ma_ChucVu = cv.Ma_ChucVu GROUP BY cv.TenChucVu;";
			DataTable data = DataProvider.Instance.ExecuteQuery(query);
			foreach (DataRow item in data.Rows)
			{
				HRStatisticCVDTO hrStat = new HRStatisticCVDTO(item);
				list.Add(hrStat);
			}
			return list;
		}
	}
}
