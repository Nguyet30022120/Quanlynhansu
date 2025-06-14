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


		public List<UserDTO> GetInforNVByUsername(string username)
		{
			List<UserDTO> list = new List<UserDTO>();

			string query = $"SELECT nv.HoTen, nv.GioiTinh, nv.Ma_NV, cv.TenChucVu, ch.TenCuaHang, tk.Ma_TK, tk.TaiKhoan, tk.VaiTro, tk.MoTaQuyenHan, nv.NgaySinh, nv.DiaChi, nv.CCCD, nv.DienThoai\r\nFROM [dbo].[NhanVien] AS nv INNER JOIN [dbo].[TaiKhoan] AS tk ON nv.Ma_TK = tk.Ma_TK INNER JOIN [dbo].[CuaHang] AS ch ON nv.Ma_CH = ch.Ma_CH INNER JOIN [dbo].[ChucVu] AS cv ON nv.Ma_CV = cv.Ma_CV WHERE tk.TaiKhoan = '{username}'";

			DataTable data = DataProvider.Instance.ExecuteQuery(query);

			foreach (DataRow item in data.Rows)
			{
				UserDTO category = new UserDTO(item);

				list.Add(category);
			}

			return list;
		}
		public List<NguoidungDTO> GetInfoUser()
		{
			List<NguoidungDTO> list = new List<NguoidungDTO>();

			string query = $"SELECT nv.HoTen, nv.Ma_NV, cv.TenChucVu, ch.TenCuaHang, tk.Ma_TK, tk.TaiKhoan, tk.VaiTro, tk.MoTaQuyenHan FROM [dbo].[NhanVien] AS nv INNER JOIN [dbo].[TaiKhoan] AS tk ON nv.Ma_TK = tk.Ma_TK INNER JOIN [dbo].[CuaHang] AS ch ON nv.Ma_CH = ch.Ma_CH INNER JOIN [dbo].[ChucVu] AS cv ON nv.Ma_CV = cv.Ma_CV";

			DataTable data = DataProvider.Instance.ExecuteQuery(query);

			foreach (DataRow item in data.Rows)
			{
				NguoidungDTO user = new NguoidungDTO(item);

				list.Add(user);
			}

			return list;
		}

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
