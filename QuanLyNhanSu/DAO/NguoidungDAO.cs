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

		//public static UserDAO Instance { get => instance; set => instance=value; }

		public static NguoidungDAO Instance { get => instance==null ? instance = new NguoidungDAO() : instance; private set => instance=value; }

		private NguoidungDAO() { }


		public List<NguoidungDTO> GetInforNVByUsername(string username)
		{
			List<NguoidungDTO> list = new List<NguoidungDTO>();

			string query = $"SELECT nv.HoTen, nv.GioiTinh, nv.Ma_NV, nv.Ma_ChucVu, pb.TenPhong, tk.Ma_TK, tk.TaiKhoan, tk.VaiTro, tk.MoTaQuyenHan, nv.NgaySinh, nv.DiaChi, nv.CMND, nv.DienThoai\r\nFROM [dbo].[Nhan vien] AS nv INNER JOIN [dbo].[Tai khoan] AS tk ON nv.Ma_TK = tk.Ma_TK INNER JOIN [dbo].[Phong ban] AS pb ON nv.Ma_PB = pb.Ma_PB\r\nWHERE tk.TaiKhoan = 'admin'";
		
			DataTable data = DataProvider.Instance.ExecuteQuery(query);

			foreach (DataRow item in data.Rows)
			{
				NguoidungDTO category = new NguoidungDTO(item);

				list.Add(category);
			}

			return list;
		}

	}
}
