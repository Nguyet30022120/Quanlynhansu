using QuanLyNhanSu.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu.DAO
{
	public class UserDAO
	{
		private static UserDAO instance;

		//public static UserDAO Instance { get => instance; set => instance=value; }

		public static UserDAO Instance { get => instance==null ? instance = new UserDAO() : instance; private set => instance=value; }

		private UserDAO() { }


		public List<UserDTO> GetInforNVByUsername(string username)
		{
			List<UserDTO> list = new List<UserDTO>();

			string query = $"SELECT nv.HoTen, nv.GioiTinh, nv.Ma_NV, nv.Ma_ChucVu, pb.TenPhong, tk.Ma_TK, tk.TaiKhoan, tk.VaiTro, tk.MoTaQuyenHan, nv.NgaySinh, nv.DiaChi, nv.CMND, nv.DienThoai\r\nFROM [dbo].[Nhan vien] AS nv INNER JOIN [dbo].[Tai khoan] AS tk ON nv.Ma_TK = tk.Ma_TK INNER JOIN [dbo].[Phong ban] AS pb ON nv.Ma_PB = pb.Ma_PB\r\nWHERE tk.TaiKhoan = 'admin'";
		
			DataTable data = DataProvider.Instance.ExecuteQuery(query);

			foreach (DataRow item in data.Rows)
			{
				UserDTO category = new UserDTO(item);

				list.Add(category);
			}

			return list;
		}

	}
}
