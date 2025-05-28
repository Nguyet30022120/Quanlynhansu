using QuanLyNhanSu.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Sources;
using System.Windows.Forms;

namespace QuanLyNhanSu.DAO
{
	public class NhanvienDAO
	{
		private static NhanvienDAO instance;

		//public static UserDAO Instance { get => instance; set => instance=value; }

		public static NhanvienDAO Instance { get => instance==null ? instance = new NhanvienDAO() : instance; private set => instance=value; }

		private NhanvienDAO() { }


		public List<NhanvienDTO> GetInforNV()
		{
			List<NhanvienDTO> list = new List<NhanvienDTO>();

			string query = "SELECT NV.Ma_NV, NV.HoTen,CV.Ma_ChucVu AS MaChucVu, CV.TenChucVu AS ChucVu, PB.Ma_PB AS MaPB, PB.TenPhong AS PhongBan, TK.TaiKhoan, NV.CMND AS CCCD, NV.DienThoai, NV.DiaChi, NV.GioiTinh, NV.NgaySinh, NV.Email FROM [Nhan vien] AS NV INNER JOIN [Chuc vu] AS CV ON NV.Ma_ChucVu = CV.Ma_ChucVu INNER JOIN [Phong ban] AS PB ON NV.Ma_PB = PB.Ma_PB INNER JOIN [Tai khoan] AS TK ON NV.Ma_TK = TK.Ma_TK;";
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

			string query = "SELECT HoTen + '-' + Ma_NV AS NhanVien_Ma FROM [Nhan Vien]";
			DataTable data = DataProvider.Instance.ExecuteQuery(query);

			foreach (DataRow item in data.Rows)
			{
				list.Add(item["NhanVien_Ma"].ToString());
			}

			return list;
		}
		public bool IsStaffExistsByEmail(string email)
		{
			string query = $"SELECT COUNT(*) FROM [Nhan Vien] WHERE Email = '{email}'";
			object result = DataProvider.Instance.ExcuteScalar(query);
			return Convert.ToInt32(result) > 0;
		}

		public bool InsertStaff(int machucvu, string mapb, string hoten, int gioitinh, DateTime ngaysinh, string cccd, string dienthoai, string diachi, string email)
		{
			string query = $"EXEC [dbo].[USP_InsertNewEmployeeByID] @Ma_ChucVu = '{machucvu}', @Ma_PB = '{mapb}', @HoTen = N'{hoten}', @GioiTinh = {gioitinh}, @NgaySinh = '{ngaysinh}',@Email = '{email}', @CMND = '{cccd}', @DienThoai = '{dienthoai}', @DiaChi = N'{diachi}'";

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

			string query = string.Format("SELECT NV.Ma_NV, NV.HoTen,CV.Ma_ChucVu AS MaChucVu, CV.TenChucVu AS ChucVu, PB.Ma_PB AS MaPB, PB.TenPhong AS PhongBan, TK.TaiKhoan, NV.CMND AS CCCD, NV.DienThoai, NV.DiaChi, NV.GioiTinh, NV.NgaySinh, NV.Email FROM [Nhan vien] AS NV INNER JOIN [Chuc vu] AS CV ON NV.Ma_ChucVu = CV.Ma_ChucVu INNER JOIN [Phong ban] AS PB ON NV.Ma_PB = PB.Ma_PB INNER JOIN [Tai khoan] AS TK ON NV.Ma_TK = TK.Ma_TK WHERE NV.Ma_NV LIKE N'%{0}%' OR NV.HoTen LIKE N'%{1}%'", value, value);

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
