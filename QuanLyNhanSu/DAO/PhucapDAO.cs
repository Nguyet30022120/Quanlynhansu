using QuanLyNhanSu.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu.DAO
{
	public class PhucapDAO
	{
		private static PhucapDAO instance;
		public static PhucapDAO Instance
		{
			get { if (instance == null) instance = new PhucapDAO(); return instance; }
			private set { instance = value; }
		}
		private PhucapDAO() { }
		public List<PhucapDTO> GetListPhuCap(string manv)
		{
			List<PhucapDTO> list = new List<PhucapDTO>();
			string query = $"SELECT nv.HoTen, pc.LoaiPhuCap, pc.SoTienPhuCap, pc.Ma_PC FROM ThongTinPhuCap pc JOIN [Nhan vien] nv ON pc.Ma_NV = nv.Ma_NV WHERE pc.Ma_NV = '{manv}';\r\n;";
			DataTable data = DataProvider.Instance.ExecuteQuery(query);
			foreach (DataRow item in data.Rows)
			{
				PhucapDTO phucap = new PhucapDTO(item);
				list.Add(phucap);
			}
			return list;
		}
		public bool InsertPhuCap(string maNV, string loaiPC,  decimal tienPC)
		{
			string query = $"EXEC USP_InsertPhuCap @Ma_NV = '{maNV}', @LoaiPhuCap = N'{loaiPC}', @SoTienPhuCap = '{tienPC}';\r\n";
			int re = DataProvider.Instance.ExcuteNonQuery(query);
			return re != 0;
		}
		public bool UpdatePhuCap(string maPC, string loaiPC, string maNV, decimal tienPC)
		{
			string query = $"EXEC USP_UpdatePhuCap @Ma_PC = '{maPC}', @Ma_NV = '{maNV}', @LoaiPhuCap = N'{loaiPC}', @SoTienPhuCap = '{tienPC}';\r\n";
			int re = DataProvider.Instance.ExcuteNonQuery(query);
			return re != 0;
		}
		public bool DeletePhuCap(string maPC)
		{
			string query = $"EXEC USP_DeletePhuCap @Ma_PC = '{maPC}';\r\n";
			int re = DataProvider.Instance.ExcuteNonQuery(query);
			return re != 0;
		}
	}
}
