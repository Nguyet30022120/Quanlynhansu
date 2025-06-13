using QuanLyNhanSu.DTO;
using System;
using System.Collections.Generic;
using System.Data;

namespace QuanLyNhanSu.DAO
{
	public class NhanvienDAO
	{
		private static NhanvienDAO instance;

		public static NhanvienDAO Instance { get => instance==null ? instance = new NhanvienDAO() : instance; private set => instance=value; }

		private NhanvienDAO() { }


		public List<NhanvienDTO> GetInforNV()
		{
			List<NhanvienDTO> list = new List<NhanvienDTO>();

			string query = string.Format("SELECT NV.Ma_NV, NV.HoTen, CV.Ma_CV AS MaChucVu, CV.TenChucVu AS ChucVu, CH.Ma_CH AS MaCH, CH.TenCuaHang AS CuaHang, TK.TaiKhoan, NV.CCCD AS CCCD, NV.DienThoai, NV.DiaChi, CASE WHEN NV.GioiTinh = 1 THEN N'Nam' WHEN NV.GioiTinh = 0 THEN N'Nữ' ELSE N'Khác' END AS GioiTinh, NV.NgaySinh, NV.Email FROM [NhanVien] AS NV INNER JOIN [ChucVu] AS CV ON NV.Ma_CV = CV.Ma_CV INNER JOIN [CuaHang] AS CH ON NV.Ma_CH = CH.Ma_CH INNER JOIN [TaiKhoan] AS TK ON NV.Ma_TK = TK.Ma_TK\r\n");
			DataTable data = DataProvider.Instance.ExecuteQuery(query);

			foreach (DataRow item in data.Rows)
			{
				NhanvienDTO staff = new NhanvienDTO(item);

				list.Add(staff);
			}

			return list;
		}
		public List<string> GetStaffName()
		{
			List<string> list = new List<string>();

			string query = "SELECT HoTen + '-' + Ma_NV AS NhanVien_Ma FROM [NhanVien]";
			DataTable data = DataProvider.Instance.ExecuteQuery(query);

			foreach (DataRow item in data.Rows)
			{
				list.Add(item["NhanVien_Ma"].ToString());
			}

			return list;
		}
		public bool IsStaffExistsByEmail(string email)
		{
			string query = $"SELECT COUNT(*) FROM [NhanVien] WHERE Email = '{email}'";
			object result = DataProvider.Instance.ExcuteScalar(query);
			return Convert.ToInt32(result) > 0;
		}

		public bool InsertStaff(int machucvu, string mach, string hoten, int gioitinh, DateTime ngaysinh, string cccd, string dienthoai, string diachi, string email)
		{
			string query = $"EXEC [dbo].[USP_InsertNewEmployeeByID] @Ma_ChucVu = '{machucvu}', @Ma_PB = '{mach}', @HoTen = N'{hoten}', @GioiTinh = {gioitinh}, @NgaySinh = '{ngaysinh}',@Email = '{email}', @CMND = '{cccd}', @DienThoai = '{dienthoai}', @DiaChi = N'{diachi}'";

			int re = DataProvider.Instance.ExcuteNonQuery(query);

			return re > 0;
		}

		public bool UpdateStaff(string manv, int machucvu, string mapb, string hoten, int gioitinh, DateTime ngaysinh, string cccd, string dienthoai, string diachi, string email)
		{
			string query = $"EXEC [dbo].[USP_UpdateEmployeeByID] @Ma_NV = '{manv}', @Ma_ChucVu = '{machucvu}', @Ma_PB = '{mapb}', @HoTen = N'{hoten}', @GioiTinh = {gioitinh}, @NgaySinh = '{ngaysinh}',@Email = '{email}', @CMND = '{cccd}', @DienThoai = '{dienthoai}', @DiaChi = N'{diachi}';";

			int re = Convert.ToInt32(DataProvider.Instance.ExcuteScalar(query));

			return re == 0;
		}

		public bool DeleteStaff(string manv)
		{
			string query = $"EXEC [dbo].[USP_DeleteEmployeeByID] @Ma_NV = '{manv}'";

			int result = DataProvider.Instance.ExcuteNonQuery(query);

			return true;
		}

		public List<NhanvienDTO> SearchStaff(string value, DateTime? date = null)
		{
			List<NhanvienDTO> list = new List<NhanvienDTO>();

			string query = string.Format("SELECT NV.Ma_NV, NV.HoTen, CV.Ma_CV AS MaChucVu, CV.TenChucVu AS ChucVu, CH.Ma_CH AS MaCH, CH.TenCuaHang AS CuaHang, TK.TaiKhoan, NV.CCCD AS CCCD, NV.DienThoai, NV.DiaChi, CASE WHEN NV.GioiTinh = 1 THEN N'Nam' ELSE N'Nữ' END AS GioiTinh, NV.NgaySinh, NV.Email FROM [NhanVien] AS NV INNER JOIN [ChucVu] AS CV ON NV.Ma_CV = CV.Ma_CV INNER JOIN [CuaHang] AS CH ON NV.Ma_CH = CH.Ma_CH INNER JOIN [TaiKhoan] AS TK ON NV.Ma_TK = TK.Ma_TK WHERE NV.Ma_NV LIKE N'%{0}%' OR NV.HoTen LIKE N'%{1}%'\r\n", value, value);

			Console.WriteLine(query);

			if (date.HasValue)
			{
				query += " AND CONVERT(DATE, LPV.NgayPV) = CONVERT(DATE, '" + date.Value.ToString("yyyy-MM-dd") + "')";
			}

			DataTable data = DataProvider.Instance.ExecuteQuery(query);

			foreach (DataRow item in data.Rows)
			{
				NhanvienDTO staff = new NhanvienDTO(item);

				list.Add(staff);
			}
			return list;
		}




	}
}
