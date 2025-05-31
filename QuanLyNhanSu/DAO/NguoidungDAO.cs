using QuanLyNhanSu.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu.DAO
{
	public class NguoidungDAO
	{
		private static NguoidungDAO instance;

		public static NguoidungDAO Instance { get => instance==null ? instance = new NguoidungDAO() : instance; private set => instance=value; }

		private NguoidungDAO() { }


		public List<NguoidungDTO> GetInforNVByUsername(string username)
		{
			List<NguoidungDTO> list = new List<NguoidungDTO>();

			string query = $"SELECT nv.HoTen, nv.GioiTinh, nv.Ma_NV, cv.TenChucVu, pb.TenPhong, tk.Ma_TK, tk.TaiKhoan, tk.VaiTro, tk.MoTaQuyenHan, nv.NgaySinh, nv.DiaChi, nv.CMND, nv.DienThoai\r\nFROM [dbo].[Nhan vien] AS nv INNER JOIN [dbo].[Tai khoan] AS tk ON nv.Ma_TK = tk.Ma_TK INNER JOIN [dbo].[Phong ban] AS pb ON nv.Ma_PB = pb.Ma_PB INNER JOIN [dbo].[Chuc vu] AS cv ON nv.Ma_ChucVu = cv.Ma_ChucVu WHERE tk.TaiKhoan = '{username}'";

			DataTable data = DataProvider.Instance.ExecuteQuery(query);

			foreach (DataRow item in data.Rows)
			{
				NguoidungDTO category = new NguoidungDTO(item);

				list.Add(category);
			}

			return list;
		}
		public List<NguoidungDTO1> GetInfoUser()
		{
			List<NguoidungDTO1> list = new List<NguoidungDTO1>();

			string query = $"SELECT nv.HoTen, nv.Ma_NV, cv.TenChucVu, pb.TenPhong, tk.Ma_TK, tk.TaiKhoan, tk.VaiTro, tk.MoTaQuyenHan FROM [dbo].[Nhan vien] AS nv INNER JOIN [dbo].[Tai khoan] AS tk ON nv.Ma_TK = tk.Ma_TK INNER JOIN [dbo].[Phong ban] AS pb ON nv.Ma_PB = pb.Ma_PB INNER JOIN [dbo].[Chuc vu] AS cv ON nv.Ma_ChucVu = cv.Ma_ChucVu";

			DataTable data = DataProvider.Instance.ExecuteQuery(query);

			foreach (DataRow item in data.Rows)
			{
				NguoidungDTO1 user = new NguoidungDTO1(item);

				list.Add(user);
			}

			return list;
		}

		//public bool InsertUser(string nameNV, string maNV, string chucVu, string phongBan, string maTK, string taiKhoan, string vaiTro, string moTaQuyenHan, DateTime? ngaySinh, int gioiTinh, string diaChi, string cCCD, string soDienThoai)
		//{
		//	string query = $"EXEC [dbo].[USP_InsertNewUser] @HoTen = N'{nameNV}', @Ma_NV = '{maNV}', @TenChucVu = N'{chucVu}', @TenPhong = N'{phongBan}', @Ma_TK = '{maTK}', @TaiKhoan = N'{taiKhoan}', @VaiTro = N'{vaiTro}', @MoTaQuyenHan = N'{moTaQuyenHan}', @NgaySinh = '{ngaySinh}', @GioiTinh = {gioiTinh}, @DiaChi = N'{diaChi}', @CMND = '{cCCD}', @DienThoai = '{soDienThoai}'";
		//	int re = DataProvider.Instance.ExcuteNonQuery(query);
		//	return re != 0;
		//}
		public bool UpdateUser(string maTK, string vaiTro, string moTaQuyenHan)
		{
			string query = $"EXEC USP_UpdateTaiKhoan @Ma_TK = '{maTK}',@VaiTro = '{vaiTro}', @MoTaQuyenHan = N'{moTaQuyenHan}';\r\n";
			int re = DataProvider.Instance.ExcuteNonQuery(query);
			return re != 0;
		}
		public bool DeleteUser(string matk)
		{
			string query = $"EXEC USP_DeleteTaiKhoan @Ma_TK = '{matk}'";
			int re = Convert.ToInt32(DataProvider.Instance.ExcuteScalar(query));
			return re == 0;
		}
	}
}
