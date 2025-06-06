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
		/// Lấy bảng công của tất cả nhân viên theo tháng/năm với tính toán giờ làm thực tế
		/// </summary>
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
				FROM [Nhan vien] nv
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

		/// <summary>
		/// Lấy bảng công của một nhân viên theo tháng/năm với tính toán giờ làm thực tế
		/// </summary>
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
				FROM [Nhan vien] nv
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

		/// <summary>
		/// Tính tổng số giờ làm việc thực tế của nhân viên trong tháng
		/// </summary>
		public double GetTongGioLamTheoThang(string maNV, int thang, int nam)
		{
			string query = string.Format(@"
				SELECT 
					SUM(
						CASE 
							WHEN co.ThoiGianCheckOut IS NOT NULL AND ci.ThoiGianCheckIn IS NOT NULL
							THEN DATEDIFF(MINUTE, ci.ThoiGianCheckIn, co.ThoiGianCheckOut) / 60.0
							ELSE 0.0  -- Không tính giờ nếu chưa checkout hoàn chỉnh
						END
					) as TongGioLam
				FROM CheckIn ci
				LEFT JOIN CheckOut co ON ci.Ma_NV = co.Ma_NV 
					AND CAST(ci.NgayCheckIn AS DATE) = CAST(co.NgayCheckOut AS DATE)
				WHERE ci.Ma_NV = '{0}' 
					AND MONTH(ci.NgayCheckIn) = {1} 
					AND YEAR(ci.NgayCheckIn) = {2}", maNV, thang, nam);

			object result = DataProvider.Instance.ExcuteScalar(query);
			return result != null && result != DBNull.Value ? Convert.ToDouble(result) : 0;
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
		/// Thống kê tổng quan chấm công trong tháng với tính toán giờ làm thực tế
		/// </summary>
		public DataTable GetThongKeChamCongThang(int thang, int nam)
		{
			string query = string.Format(@"
				SELECT 
					nv.Ma_NV,
					nv.HoTen,
					COUNT(ci.NgayCheckIn) AS SoNgayLam,
					SUM(
						CASE 
							WHEN co.ThoiGianCheckOut IS NOT NULL AND ci.ThoiGianCheckIn IS NOT NULL
							THEN DATEDIFF(MINUTE, ci.ThoiGianCheckIn, co.ThoiGianCheckOut) / 60.0
							ELSE 8.0  -- Mặc định 8 giờ nếu không có checkout
						END
					) AS TongGioLam
				FROM [Nhan vien] nv
				LEFT JOIN CheckIn ci ON nv.Ma_NV = ci.Ma_NV 
					AND MONTH(ci.NgayCheckIn) = {0} 
					AND YEAR(ci.NgayCheckIn) = {1}
				LEFT JOIN CheckOut co ON ci.Ma_NV = co.Ma_NV 
					AND CAST(ci.NgayCheckIn AS DATE) = CAST(co.NgayCheckOut AS DATE)
				GROUP BY nv.Ma_NV, nv.HoTen
				ORDER BY nv.Ma_NV", thang, nam);

			return DataProvider.Instance.ExecuteQuery(query);
		}

		/// <summary>
		/// Test kết nối và lấy dữ liệu thô từ database
		/// </summary>
		public DataTable TestConnection()
		{
			try
			{
				// Sử dụng tháng/năm hiện tại thay vì hardcode
				int currentMonth = DateTime.Now.Month;
				int currentYear = DateTime.Now.Year;
				
				string query = string.Format(@"
					SELECT TOP 10
						ci.MaCheckIn, ci.Ma_NV, ci.NgayCheckIn, ci.ThoiGianCheckIn, ci.GioCheckIn,
						co.MaCheckOut, co.ThoiGianCheckOut, co.GioCheckOut,
						nv.HoTen,
						CASE 
							WHEN co.ThoiGianCheckOut IS NOT NULL AND ci.ThoiGianCheckIn IS NOT NULL
							THEN DATEDIFF(MINUTE, ci.ThoiGianCheckIn, co.ThoiGianCheckOut) / 60.0
							ELSE 0.0  -- Không tính giờ nếu chưa checkout
						END AS SoGioLamTinhToan
					FROM CheckIn ci
					LEFT JOIN CheckOut co ON ci.Ma_NV = co.Ma_NV 
						AND CAST(ci.NgayCheckIn AS DATE) = CAST(co.NgayCheckOut AS DATE)
					LEFT JOIN [Nhan vien] nv ON ci.Ma_NV = nv.Ma_NV
					WHERE MONTH(ci.NgayCheckIn) = {0} AND YEAR(ci.NgayCheckIn) = {1}
					ORDER BY ci.NgayCheckIn DESC", currentMonth, currentYear);

				return DataProvider.Instance.ExecuteQuery(query);
			}
			catch (Exception ex)
			{
				// Tạo bảng lỗi với thông tin debug chi tiết hơn
				DataTable dt = new DataTable();
				dt.Columns.Add("Error", typeof(string));
				dt.Columns.Add("Details", typeof(string));
				dt.Rows.Add("Connection Error: " + ex.Message, ex.StackTrace);
				return dt;
			}
		}

		/// <summary>
		/// Lấy thống kê tổng quan về nhân viên và dữ liệu chấm công
		/// </summary>
		public DataTable GetThongKeNhanh()
		{
			try
			{
				string query = @"
					SELECT 
						'Tổng nhân viên' as ThongKe,
						COUNT(DISTINCT nv.Ma_NV) as GiaTri
					FROM [Nhan vien] nv
					UNION ALL
					SELECT 
						'Nhân viên có chấm công hôm nay' as ThongKe,
						COUNT(DISTINCT ci.Ma_NV) as GiaTri
					FROM CheckIn ci
					WHERE CAST(ci.NgayCheckIn AS DATE) = CAST(GETDATE() AS DATE)
					UNION ALL
					SELECT 
						'Tổng bản ghi CheckIn tháng này' as ThongKe,
						COUNT(*) as GiaTri
					FROM CheckIn ci
					WHERE MONTH(ci.NgayCheckIn) = MONTH(GETDATE()) 
						AND YEAR(ci.NgayCheckIn) = YEAR(GETDATE())";

				return DataProvider.Instance.ExecuteQuery(query);
			}
			catch
			{
				// Trả về bảng rỗng nếu có lỗi
				DataTable dt = new DataTable();
				dt.Columns.Add("ThongKe", typeof(string));
				dt.Columns.Add("GiaTri", typeof(int));
				return dt;
			}
		}
	}
} 