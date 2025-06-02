using QuanLyNhanSu.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu.DAO
{
	public class BangcongDAO
	{
		private static BangcongDAO instance;
		public static BangcongDAO Instance
		{
			get { if (instance == null) instance = new BangcongDAO(); return instance; }
			private set { instance = value; }
		}

		/// <summary>
		/// Lấy bảng công của tất cả nhân viên theo tháng/năm
		/// </summary>
		public List<BangcongDTO> GetBangCongTheoThang(int thang, int nam)
		{
			List<BangcongDTO> list = new List<BangcongDTO>();
			string query = string.Format(@"
				SELECT 
					nv.Ma_NV,
					nv.HoTen,
					ci.NgayCheckIn as Ngay,
					ci.GioCheckIn,
					ISNULL(co.GioCheckOut, ci.GioCheckIn) as GioCheckOut,
					CASE 
						WHEN ci.GioCheckIn IS NOT NULL AND co.GioCheckOut IS NOT NULL 
						THEN 8.0
						ELSE 0
					END AS SoGioLam
				FROM [Nhan vien] nv
				INNER JOIN CheckIn ci ON nv.Ma_NV = ci.Ma_NV 
				LEFT JOIN CheckOut co ON nv.Ma_NV = co.Ma_NV AND ci.NgayCheckIn = co.NgayCheckOut
				WHERE MONTH(ci.NgayCheckIn) = {0} AND YEAR(ci.NgayCheckIn) = {1}
				ORDER BY nv.Ma_NV, ci.NgayCheckIn", thang, nam);

			DataTable data = DataProvider.Instance.ExecuteQuery(query);
			foreach (DataRow item in data.Rows)
			{
				BangcongDTO bangcong = new BangcongDTO(item);
				list.Add(bangcong);
			}
			return list;
		}

		/// <summary>
		/// Lấy bảng công của một nhân viên theo tháng/năm
		/// </summary>
		public List<BangcongDTO> GetBangCongNhanVienTheoThang(string maNV, int thang, int nam)
		{
			List<BangcongDTO> list = new List<BangcongDTO>();
			string query = string.Format(@"
				SELECT 
					nv.Ma_NV,
					nv.HoTen,
					ci.NgayCheckIn as Ngay,
					ci.GioCheckIn,
					ISNULL(co.GioCheckOut, ci.GioCheckIn) as GioCheckOut,
					CASE 
						WHEN ci.GioCheckIn IS NOT NULL AND co.GioCheckOut IS NOT NULL 
						THEN 8.0
						ELSE 0
					END AS SoGioLam
				FROM [Nhan vien] nv
				INNER JOIN CheckIn ci ON nv.Ma_NV = ci.Ma_NV 
				LEFT JOIN CheckOut co ON nv.Ma_NV = co.Ma_NV AND ci.NgayCheckIn = co.NgayCheckOut
				WHERE nv.Ma_NV = '{0}' AND MONTH(ci.NgayCheckIn) = {1} AND YEAR(ci.NgayCheckIn) = {2}
				ORDER BY ci.NgayCheckIn", maNV, thang, nam);

			DataTable data = DataProvider.Instance.ExecuteQuery(query);
			foreach (DataRow item in data.Rows)
			{
				BangcongDTO bangcong = new BangcongDTO(item);
				list.Add(bangcong);
			}
			return list;
		}

		/// <summary>
		/// Tính tổng số giờ làm việc của nhân viên trong tháng
		/// </summary>
		public double GetTongGioLamTheoThang(string maNV, int thang, int nam)
		{
			string query = string.Format(@"
				SELECT COUNT(*) * 8.0 as TongGioLam
				FROM CheckIn ci
				WHERE ci.Ma_NV = '{0}' 
					AND MONTH(ci.NgayCheckIn) = {1} 
					AND YEAR(ci.NgayCheckIn) = {2}", maNV, thang, nam);

			object result = DataProvider.Instance.ExcuteScalar(query);
			return result != null ? Convert.ToDouble(result) : 0;
		}

		/// <summary>
		/// Lấy danh sách nhân viên có dữ liệu chấm công
		/// </summary>
		public DataTable GetDanhSachNhanVienCoChamCong()
		{
			string query = @"
				SELECT DISTINCT nv.Ma_NV, nv.HoTen
				FROM [Nhan vien] nv
				INNER JOIN CheckIn ci ON nv.Ma_NV = ci.Ma_NV
				ORDER BY nv.Ma_NV";

			return DataProvider.Instance.ExecuteQuery(query);
		}

		/// <summary>
		/// Thống kê tổng quan chấm công trong tháng
		/// </summary>
		public DataTable GetThongKeChamCongThang(int thang, int nam)
		{
			string query = string.Format(@"
				SELECT 
					nv.Ma_NV,
					nv.HoTen,
					COUNT(ci.NgayCheckIn) AS SoNgayLam,
					COUNT(ci.NgayCheckIn) * 8.0 AS TongGioLam
				FROM [Nhan vien] nv
				LEFT JOIN CheckIn ci ON nv.Ma_NV = ci.Ma_NV 
					AND MONTH(ci.NgayCheckIn) = {0} 
					AND YEAR(ci.NgayCheckIn) = {1}
				GROUP BY nv.Ma_NV, nv.HoTen
				ORDER BY nv.Ma_NV", thang, nam);

			return DataProvider.Instance.ExecuteQuery(query);
		}
	}
} 