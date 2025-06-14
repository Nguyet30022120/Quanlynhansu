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

		/// Lấy bảng công của tất cả nhân viên theo tháng/năm với tính toán giờ làm thực tế
		public List<BangcongDTO> GetBangCongTheoThang(int thang, int nam)
		{
			List<BangcongDTO> list = new List<BangcongDTO>();
			string query = string.Format(@"
				SELECT 
					nv.Ma_NV,
					nv.HoTen,
					CAST(ci.NgayCheckIn AS DATE) as Ngay,
					CASE 
						WHEN ci.ThoiGianCheckIn IS NOT NULL 
						THEN CAST(ci.ThoiGianCheckIn AS TIME)
						ELSE '08:00:00'
					END as GioCheckIn,
					CASE 
						WHEN co.ThoiGianCheckOut IS NOT NULL 
						THEN CAST(co.ThoiGianCheckOut AS TIME)
						ELSE NULL  -- Không đặt giờ mặc định nếu chưa checkout
					END as GioCheckOut,
					CASE 
						WHEN co.ThoiGianCheckOut IS NOT NULL AND ci.ThoiGianCheckIn IS NOT NULL
						THEN DATEDIFF(MINUTE, ci.ThoiGianCheckIn, co.ThoiGianCheckOut) / 60.0
						ELSE 0.0  -- Không tính giờ nếu chưa checkout hoàn chỉnh
					END AS SoGioLam
				FROM [NhanVien] nv
				INNER JOIN CheckIn ci ON nv.Ma_NV = ci.Ma_NV 
				LEFT JOIN CheckOut co ON ci.Ma_NV = co.Ma_NV 
					AND CAST(ci.NgayCheckIn AS DATE) = CAST(co.NgayCheckOut AS DATE)
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

		/// Lấy bảng công của một nhân viên theo tháng/năm với tính toán giờ làm thực tế
		public List<BangcongDTO> GetBangCongNhanVienTheoThang(string maNV, int thang, int nam)
		{
			List<BangcongDTO> list = new List<BangcongDTO>();
			string query = string.Format(@"
				SELECT 
					nv.Ma_NV,
					nv.HoTen,
					CAST(ci.NgayCheckIn AS DATE) as Ngay,
					CASE 
						WHEN ci.ThoiGianCheckIn IS NOT NULL 
						THEN CAST(ci.ThoiGianCheckIn AS TIME)
						ELSE '08:00:00'
					END as GioCheckIn,
					CASE 
						WHEN co.ThoiGianCheckOut IS NOT NULL 
						THEN CAST(co.ThoiGianCheckOut AS TIME)
						ELSE NULL  -- Không đặt giờ mặc định nếu chưa checkout
					END as GioCheckOut,
					CASE 
						WHEN co.ThoiGianCheckOut IS NOT NULL AND ci.ThoiGianCheckIn IS NOT NULL
						THEN DATEDIFF(MINUTE, ci.ThoiGianCheckIn, co.ThoiGianCheckOut) / 60.0
						ELSE 0.0  -- Không tính giờ nếu chưa checkout hoàn chỉnh
					END AS SoGioLam
				FROM [NhanVien] nv
				INNER JOIN CheckIn ci ON nv.Ma_NV = ci.Ma_NV 
				LEFT JOIN CheckOut co ON ci.Ma_NV = co.Ma_NV 
					AND CAST(ci.NgayCheckIn AS DATE) = CAST(co.NgayCheckOut AS DATE)
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


		/// Lấy danh sách nhân viên có dữ liệu chấm công
		public DataTable GetDanhSachNhanVienCoChamCong()
		{
			string query = @"
				SELECT DISTINCT nv.Ma_NV, nv.HoTen
				FROM [NhanVien] nv
				INNER JOIN CheckIn ci ON nv.Ma_NV = ci.Ma_NV
				ORDER BY nv.Ma_NV";

			return DataProvider.Instance.ExecuteQuery(query);
		}

	}
} 