using QuanLyNhanSu.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu.DAO
{
	public class ProfileDAO
	{
		private static ProfileDAO instance;


		public static ProfileDAO Instance { get => instance==null ? instance = new ProfileDAO() : instance; private set => instance=value; }

		private ProfileDAO() { }

		public List<ProfileDTO> GetProfile()
		{
			List<ProfileDTO> list = new List<ProfileDTO>();

			string query = "SELECT HS.Ma_HS, HS.HoTen, HS.NgaySinh, HS.GioiTinh, HS.SoDienThoai, HS.ChiTietCV, HS.Email, NU.TenNguon AS NguonUngVien, CV.TenChucVu AS ChucVu FROM HoSoUngVien AS HS LEFT JOIN [Chuc vu] AS CV ON HS.Ma_ChucVu = CV.Ma_ChucVu LEFT JOIN NguonUngVien AS NU ON HS.Ma_Nguon = NU.Ma_Nguon;\r\n";
			DataTable data = DataProvider.Instance.ExecuteQuery(query);

			foreach (DataRow item in data.Rows)
			{
				ProfileDTO profile = new ProfileDTO(item);

				list.Add(profile);
			}

			return list;
		}

		public bool InsertProfile(string hoten, string tenchucvu, int gioitinh, DateTime ngaysinh, string tennguon, string dienthoai, string chitietcv, string email)
		{
			string query = $"EXEC USP_InsertNewHoSoUngVien_ByName @HoTen = N'{hoten}', @NgaySinh = '{ngaysinh}', @GioiTinh = {gioitinh}, @SoDienThoai = '{dienthoai}', @ChiTietCV = '{chitietcv}', @TenNguon = N'{tennguon}', @TenChucVu = N'{tenchucvu}', @Email = '{email}';\r\n";

			int re = DataProvider.Instance.ExcuteNonQuery(query);

			return re > 0;
		}

		public bool UpdateProfile(string mahs, string hoten, string tenchucvu, int gioitinh, DateTime ngaysinh, string tennguon, string dienthoai, string chitietcv, string email)
		{
			string query = $"EXEC USP_UpdateHoSoUngVien_ByName @Ma_HS = '{mahs}', @HoTen = N'{hoten}', @NgaySinh = '{ngaysinh}', @GioiTinh = {gioitinh}, @SoDienThoai = '{dienthoai}', @ChiTietCV = '{chitietcv}', @Email = '{email}', @TenNguon = N'{tennguon}', @TenChucVu = N'{tenchucvu}';";
			int re = DataProvider.Instance.ExcuteNonQuery(query);
			return re > 0;
		}

		public bool DeleteProfile(string mahs)
		{
			string query = $"EXEC USP_DeleteHoSoUngVien @Ma_HS = '{mahs}';";
			int re = DataProvider.Instance.ExcuteNonQuery(query);
			return re > 0;
		}

		public List<ProfileDTO> SearchProfile(string value)
		{
			List<ProfileDTO> list = new List<ProfileDTO>();

			string query = string.Format("SELECT HS.Ma_HS, HS.HoTen, HS.NgaySinh, HS.GioiTinh, HS.SoDienThoai, HS.ChiTietCV, HS.Email, NU.TenNguon AS NguonUngVien, CV.TenChucVu AS ChucVu FROM HoSoUngVien AS HS LEFT JOIN [Chuc vu] AS CV ON HS.Ma_ChucVu = CV.Ma_ChucVu LEFT JOIN NguonUngVien AS NU ON HS.Ma_Nguon = NU.Ma_Nguon WHERE HS.Ma_HS LIKE N'%{0}%' OR HS.HoTen LIKE N'%{1}%'", value, value);

			Console.WriteLine(query);

			DataTable data = DataProvider.Instance.ExecuteQuery(query);

			foreach (DataRow item in data.Rows)
			{
				ProfileDTO profile = new ProfileDTO(item);

				list.Add(profile);
			}
			return list;
		}
		public List<ProfileDTO> GetProfileByTenUV(string mahs)
		{
			List<ProfileDTO> list = new List<ProfileDTO>();

			string query = $"SELECT HS.Ma_HS, HS.HoTen, HS.NgaySinh, HS.GioiTinh, HS.SoDienThoai, HS.ChiTietCV, HS.Email, NU.TenNguon AS NguonUngVien, CV.TenChucVu AS ChucVu FROM HoSoUngVien AS HS LEFT JOIN [Chuc vu] AS CV ON HS.Ma_ChucVu = CV.Ma_ChucVu LEFT JOIN NguonUngVien AS NU ON HS.Ma_Nguon = NU.Ma_Nguon WHERE HS.MA_HS LIKE N'%{mahs}%';";

			DataTable data = DataProvider.Instance.ExecuteQuery(query);

			foreach (DataRow item in data.Rows)
			{
				ProfileDTO profile = new ProfileDTO(item);

				list.Add(profile);
			}

			return list;
		}
	}
	}
