using QuanLyNhanSu.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu.DAO
{
	public class CommendationDAO
	{
		private static CommendationDAO instance;
		public static CommendationDAO Instance
		{
			get { if (instance == null) instance = new CommendationDAO(); return instance; }
			private set { instance = value; }
		}
		private CommendationDAO() { }
		public List<CommendationDTO> GetCommendationsByMaNV(string maNV)
		{
			List<CommendationDTO> list = new List<CommendationDTO>();
			string query = $"SELECT ktkl.MaKTKL, nv.HoTen AS TenNhanVien, ktkl.ThoiGian, ktkl.NoiDung, CASE WHEN ktkl.HinhThuc = 1 THEN N'Khen thưởng' WHEN ktkl.HinhThuc = 0 THEN N'Kỷ luật' ELSE N'Không xác định' END AS HinhThuc FROM KhenThuongKyLuat ktkl JOIN [Nhan vien] nv ON ktkl.Ma_NV = nv.Ma_NV WHERE NV.Ma_NV = '{maNV}'";
			DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { maNV });
			foreach (DataRow item in data.Rows)
			{
				CommendationDTO commendation = new CommendationDTO(item);
				list.Add(commendation);
			}
			return list;
		}
		public bool InsertCommendation(string maNV, string noiDung, int hinhThuc, DateTime thoiGian)
		{
			string query = $"EXEC USP_InsertKTKL @MaNV = '{maNV}', @ThoiGian = '{thoiGian}', @NoiDung = N'{noiDung}', @HinhThuc = {hinhThuc}\r\n";
			int result = DataProvider.Instance.ExcuteNonQuery(query, new object[] { maNV, noiDung, hinhThuc, thoiGian });
			return result > 0;
		}
		public bool UpdateCommendation(string maktkl, string noidung, int hinhthuc, DateTime thoigian)
		{
			string query = $"EXEC USP_UpdateKTKL @MaKTKL = '{maktkl}', @ThoiGian = '{thoigian}', @NoiDung = N'{noidung}', @HinhThuc = {hinhthuc}\r\n";

			int re = Convert.ToInt32(DataProvider.Instance.ExcuteScalar(query));

			return re != 0;
		}
		public bool DeleteCommendation(string maktkl)
		{
			string query = $"EXEC USP_DeleteKTKL @MaKTKL = '{maktkl}'";
			int re = Convert.ToInt32(DataProvider.Instance.ExcuteScalar(query));
			return re != 0;
		}
		#region statistic
		public List<CommendationStatisticDTO> GetCommendationsStatistic()
		{
			List<CommendationStatisticDTO> list = new List<CommendationStatisticDTO>();
			string query = $"SELECT nv.HoTen, nv.Ma_NV, YEAR(ktkl.ThoiGian) as Nam, SUM(CASE WHEN ktkl.HinhThuc = 1 THEN 1 ELSE 0 END) as KhenThuong, SUM(CASE WHEN ktkl.HinhThuc = 0 THEN 1 ELSE 0 END) as KyLuat FROM KhenThuongKyLuat ktkl JOIN [Nhan vien] nv ON ktkl.Ma_NV = nv.Ma_NV GROUP BY nv.HoTen, nv.Ma_NV, YEAR(ktkl.ThoiGian) ORDER BY nv.HoTen, YEAR(ktkl.ThoiGian);\r\n";
			DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { });
			foreach (DataRow item in data.Rows)
			{
				CommendationStatisticDTO commendation = new CommendationStatisticDTO(item);
				list.Add(commendation);
			}
			return list;
		}

		public List<CommendationStatisticDTO> GetCommendationByMaNV(string manv)
		{
			List<CommendationStatisticDTO> list = new List<CommendationStatisticDTO>();
			string query = $"SELECT nv.HoTen, nv.Ma_NV, YEAR(ktkl.ThoiGian) as Nam, SUM(CASE WHEN ktkl.HinhThuc = 1 THEN 1 ELSE 0 END) as KhenThuong, SUM(CASE WHEN ktkl.HinhThuc = 0 THEN 1 ELSE 0 END) as KyLuat FROM KhenThuongKyLuat ktkl JOIN [Nhan vien] nv ON ktkl.Ma_NV = nv.Ma_NV WHERE nv.Ma_NV = '{manv}' GROUP BY nv.HoTen, nv.Ma_NV, YEAR(ktkl.ThoiGian) ORDER BY nv.HoTen, YEAR(ktkl.ThoiGian);\r\n";
			DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { });
			foreach (DataRow item in data.Rows)
			{
				CommendationStatisticDTO commendation = new CommendationStatisticDTO(item);
				list.Add(commendation);
			}
			return list;
		}
		public List<CommendationStatisticDTO> GetCommendationByNam(int nam)
		{
			List<CommendationStatisticDTO> list = new List<CommendationStatisticDTO>();
			string query = $"SELECT nv.HoTen, nv.Ma_NV, YEAR(ktkl.ThoiGian) as Nam, SUM(CASE WHEN ktkl.HinhThuc = 1 THEN 1 ELSE 0 END) as KhenThuong, SUM(CASE WHEN ktkl.HinhThuc = 0 THEN 1 ELSE 0 END) as KyLuat FROM KhenThuongKyLuat ktkl JOIN [Nhan vien] nv ON ktkl.Ma_NV = nv.Ma_NV WHERE YEAR(ktkl.ThoiGian) = {nam} GROUP BY nv.HoTen, nv.Ma_NV, YEAR(ktkl.ThoiGian) ORDER BY nv.HoTen, YEAR(ktkl.ThoiGian);\r\n";
			DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { });
			foreach (DataRow item in data.Rows)
			{
				CommendationStatisticDTO commendation = new CommendationStatisticDTO(item);
				list.Add(commendation);
			}
			return list;
		}
		#endregion
	}
}
