using QuanLyNhanSu.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Management.Instrumentation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanSu.DAO
{
	public class HosoungvienDAO
	{
		private static HosoungvienDAO instance;


		public static HosoungvienDAO Instance { get => instance==null ? instance = new HosoungvienDAO() : instance; private set => instance=value; }

		private HosoungvienDAO() { }

		public List<HosoungvienDTO> GetProfile()
		{
			List<HosoungvienDTO> list = new List<HosoungvienDTO>();

			string query = string.Format("SELECT HS.Ma_HS, HS.HoTen, HS.NgaySinh, HS.GioiTinh, HS.SoDienThoai, HS.ChiTietCV, HS.Email, NU.TenNguon AS NguonUngVien, CV.TenChucVu AS ChucVu, CASE WHEN EXISTS (SELECT 1 FROM [Nhan vien] NV WHERE NV.Email = HS.Email) THEN N'Đã tiếp nhận' WHEN EXISTS (SELECT 1 FROM KetQuaPhongVan KQ JOIN LichPhongVan LPV ON KQ.Ma_PV = LPV.Ma_PV WHERE LPV.Ma_HS = HS.Ma_HS) THEN N'Đã có kết quả' WHEN EXISTS (SELECT 1 FROM LichPhongVan LPV WHERE LPV.Ma_HS = HS.Ma_HS) THEN N'Đã có lịch phỏng vấn' ELSE N'Chưa tiếp nhận' END AS TrangThai FROM HoSoUngVien AS HS LEFT JOIN [Chuc vu] AS CV ON HS.Ma_ChucVu = CV.Ma_ChucVu LEFT JOIN NguonUngVien AS NU ON HS.Ma_Nguon = NU.Ma_Nguon;\r\n");

			DataTable data = DataProvider.Instance.ExecuteQuery(query);

			foreach (DataRow item in data.Rows)
			{
				HosoungvienDTO profile = new HosoungvienDTO(item);

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

		public List<HosoungvienDTO> SearchProfile(string value)
		{
			List<HosoungvienDTO> list = new List<HosoungvienDTO>();

			string query = string.Format("SELECT HS.Ma_HS, HS.HoTen, HS.NgaySinh, HS.GioiTinh, HS.SoDienThoai, HS.ChiTietCV, HS.Email, NU.TenNguon AS NguonUngVien, CV.TenChucVu AS ChucVu, CASE WHEN EXISTS (SELECT 1 FROM [Nhan vien] NV WHERE NV.Email = HS.Email) THEN N'Đã tiếp nhận' WHEN EXISTS (SELECT 1 FROM KetQuaPhongVan KQ JOIN LichPhongVan LPV ON KQ.Ma_PV = LPV.Ma_PV WHERE LPV.Ma_HS = HS.Ma_HS) THEN N'Đã có kết quả' WHEN EXISTS (SELECT 1 FROM LichPhongVan LPV WHERE LPV.Ma_HS = HS.Ma_HS) THEN N'Đã có lịch phỏng vấn' ELSE N'Chưa tiếp nhận' END AS TrangThai FROM HoSoUngVien AS HS LEFT JOIN [Chuc vu] AS CV ON HS.Ma_ChucVu = CV.Ma_ChucVu LEFT JOIN NguonUngVien AS NU ON HS.Ma_Nguon = NU.Ma_Nguon WHERE HS.Ma_HS LIKE N'%{0}%' OR HS.HoTen LIKE N'%{1}%'", value, value);

			Console.WriteLine(query);

			DataTable data = DataProvider.Instance.ExecuteQuery(query);

			foreach (DataRow item in data.Rows)
			{
				HosoungvienDTO profile = new HosoungvienDTO(item);

				list.Add(profile);
			}
			return list;
		}
		public List<HosoungvienDTO> GetProfileByTenUV(string mahs)
		{
			List<HosoungvienDTO> list = new List<HosoungvienDTO>();

			string query = $"SELECT HS.Ma_HS, HS.HoTen, HS.NgaySinh, HS.GioiTinh, HS.SoDienThoai, HS.ChiTietCV, HS.Email, NU.TenNguon AS NguonUngVien, CV.TenChucVu AS ChucVu FROM HoSoUngVien AS HS LEFT JOIN [Chuc vu] AS CV ON HS.Ma_ChucVu = CV.Ma_ChucVu LEFT JOIN NguonUngVien AS NU ON HS.Ma_Nguon = NU.Ma_Nguon WHERE HS.MA_HS LIKE N'%{mahs}%';";

			DataTable data = DataProvider.Instance.ExecuteQuery(query);

			foreach (DataRow item in data.Rows)
			{
				HosoungvienDTO profile = new HosoungvienDTO(item);

				list.Add(profile);
			}

			return list;
		}


	}
}
