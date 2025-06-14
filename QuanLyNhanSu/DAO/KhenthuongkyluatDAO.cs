using QuanLyNhanSu.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu.DAO
{
	public class KhenthuongkyluatDAO
	{
		private static KhenthuongkyluatDAO instance;
		public static KhenthuongkyluatDAO Instance
		{
			get { if (instance == null) instance = new KhenthuongkyluatDAO(); return instance; }
			private set { instance = value; }
		}
		private KhenthuongkyluatDAO() { }
		#region ManagementV

		public List<KhenthuongkyluatDTO> GetCommendationsByMaNV(string maNV)
		{
			List<KhenthuongkyluatDTO> list = new List<KhenthuongkyluatDTO>();
			string query = $"SELECT ktkl.Ma_NV, ktkl.Ma_KTKL, nv.HoTen AS TenNhanVien, ktkl.ThoiGian, ktkl.NoiDung, CASE WHEN ktkl.HinhThuc = 1 THEN N'Khen thưởng' WHEN ktkl.HinhThuc = 0 THEN N'Kỷ luật' ELSE N'Không xác định' END AS HinhThuc FROM KhenThuongKyLuat ktkl JOIN [NhanVien] nv ON ktkl.Ma_NV = nv.Ma_NV WHERE NV.Ma_NV = '{maNV}'";
			DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { maNV });
			foreach (DataRow item in data.Rows)
			{
				KhenthuongkyluatDTO commendation = new KhenthuongkyluatDTO(item);
				list.Add(commendation);
			}
			return list;
		}
		public bool InsertCommendation(string maNV, string noiDung, int hinhThuc, DateTime thoiGian)
		{
			string query = $"EXEC USP_InsertKTKL @MaNV = '{maNV}', @ThoiGian = '{thoiGian}', @NoiDung = N'{noiDung}', @HinhThuc = {hinhThuc}\r\n";
			int result = DataProvider.Instance.ExcuteNonQuery(query, new object[] { maNV, noiDung, hinhThuc, thoiGian });
			return result != 0;
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

		#endregion

		#region statistic
		public List<ThongkekhenthuongkyluatDTO> GetCommendationsStatistic()
		{
			List<ThongkekhenthuongkyluatDTO> list = new List<ThongkekhenthuongkyluatDTO>();
			string query = "SELECT nv.HoTen, nv.Ma_NV, YEAR(ktkl.ThoiGian) AS Nam, SUM(CASE WHEN ktkl.HinhThuc = 1 THEN 1 ELSE 0 END) AS KhenThuong, SUM(CASE WHEN ktkl.HinhThuc = 0 THEN 1 ELSE 0 END) AS KyLuat FROM KhenThuongKyLuat ktkl JOIN NhanVien nv ON ktkl.Ma_NV = nv.Ma_NV GROUP BY nv.HoTen, nv.Ma_NV, YEAR(ktkl.ThoiGian) ORDER BY nv.HoTen, YEAR(ktkl.ThoiGian);";
			DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { });
			foreach (DataRow item in data.Rows)
			{
				ThongkekhenthuongkyluatDTO commendation = new ThongkekhenthuongkyluatDTO(item);
				list.Add(commendation);
			}
			return list;
		}
		public List<ThongkekhenthuongkyluatDTO> GetCommendationNam(int nam)
		{
			List<ThongkekhenthuongkyluatDTO> list = new List<ThongkekhenthuongkyluatDTO>();
			string query = $"SELECT nv.HoTen, nv.Ma_NV, YEAR(ktkl.ThoiGian) AS Nam, SUM(CASE WHEN ktkl.HinhThuc = 1 THEN 1 ELSE 0 END) AS KhenThuong, SUM(CASE WHEN ktkl.HinhThuc = 0 THEN 1 ELSE 0 END) AS KyLuat FROM KhenThuongKyLuat ktkl JOIN NhanVien nv ON ktkl.Ma_NV = nv.Ma_NV WHERE YEAR(ktkl.ThoiGian) = {nam} GROUP BY nv.HoTen, nv.Ma_NV, YEAR(ktkl.ThoiGian) ORDER BY nv.HoTen, Nam;";

			DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { });
			foreach (DataRow item in data.Rows)
			{
				ThongkekhenthuongkyluatDTO commendation = new ThongkekhenthuongkyluatDTO(item);
				list.Add(commendation);
			}
			return list;
		}
		public List<ThongkekhenthuongkyluatDTO> GetCommendationByNam(string manv, int nam)
		{
			List<ThongkekhenthuongkyluatDTO> list = new List<ThongkekhenthuongkyluatDTO>();
			string query = $"SELECT nv.HoTen, nv.Ma_NV, YEAR(ktkl.ThoiGian) AS Nam, SUM(CASE WHEN ktkl.HinhThuc = 1 THEN 1 ELSE 0 END) AS KhenThuong, SUM(CASE WHEN ktkl.HinhThuc = 0 THEN 1 ELSE 0 END) AS KyLuat FROM KhenThuongKyLuat ktkl JOIN [NhanVien] nv ON ktkl.Ma_NV = nv.Ma_NV WHERE nv.Ma_NV = '{manv}' AND YEAR(ktkl.ThoiGian) = {nam} GROUP BY nv.HoTen, nv.Ma_NV, YEAR(ktkl.ThoiGian) ORDER BY nv.HoTen, YEAR(ktkl.ThoiGian);\r\n;\r\n";
			DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { });
			foreach (DataRow item in data.Rows)
			{
				ThongkekhenthuongkyluatDTO commendation = new ThongkekhenthuongkyluatDTO(item);
				list.Add(commendation);
			}
			return list;
		}
		public (int tongKhenThuong, int tongKyLuat) GetTongKhenThuongVaKyLuat()
		{
			string query = @"
		      SELECT 
		      	SUM(CASE WHEN HinhThuc = 1 THEN 1 ELSE 0 END) AS TongKhenThuong,
		      	SUM(CASE WHEN HinhThuc = 0 THEN 1 ELSE 0 END) AS TongKyLuat
		      FROM KhenThuongKyLuat";

			DataTable result = DataProvider.Instance.ExecuteQuery(query);

			if (result.Rows.Count > 0)
			{
				int tongKhenThuong = Convert.ToInt32(result.Rows[0]["TongKhenThuong"]);
				int tongKyLuat = Convert.ToInt32(result.Rows[0]["TongKyLuat"]);
				return (tongKhenThuong, tongKyLuat);
			}

			return (0, 0);
		}

		public (int tongKhenThuong, int tongKyLuat) GetTongKhenThuongVaKyLuatTheoNam(int nam)
		{
			string query = @"
               SELECT 
                   SUM(CASE WHEN HinhThuc = 1 THEN 1 ELSE 0 END) AS TongKhenThuong,
                   SUM(CASE WHEN HinhThuc = 0 THEN 1 ELSE 0 END) AS TongKyLuat
               FROM Khenthuongkyluat
               WHERE YEAR(ThoiGian) = @nam";

			DataTable result = DataProvider.Instance.ExecuteQuery(query, new object[] { nam });

			int khenThuong = 0;
			int kyLuat = 0;

			if (result.Rows.Count > 0)
			{
				int.TryParse(result.Rows[0]["TongKhenThuong"].ToString(), out khenThuong);
				int.TryParse(result.Rows[0]["TongKyLuat"].ToString(), out kyLuat);
			}

			return (khenThuong, kyLuat);
		}
		#endregion
	}
}
