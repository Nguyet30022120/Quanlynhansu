using QuanLyNhanSu.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu.DAO
{
	public class SourceDAO
	{
		private static SourceDAO instance;
		public static SourceDAO Instance { get => instance == null ? instance = new SourceDAO() : instance; private set => instance = value; }
		private SourceDAO() { }
		public List<SourceDTO> GetListSource()
		{
			List<SourceDTO> list = new List<SourceDTO>();
			string query = "SELECT NU.TenNguon, COUNT(HUV.Ma_HS) AS SoLuongHoSo FROM NguonUngVien NU LEFT JOIN HoSoUngVien HUV ON NU.Ma_Nguon = HUV.Ma_Nguon GROUP BY NU.TenNguon;\r\n";
			DataTable data = DataProvider.Instance.ExecuteQuery(query);
			foreach (DataRow item in data.Rows)
			{
				SourceDTO source = new SourceDTO(item);
				list.Add(source);
			}
			return list;
		}

		public bool InsertSource(string tenNguon)
		{
			string query = $"EXEC [dbo].[USP_InsertNguonUngVien] @TenNguon = N'{tenNguon}'";
			int re = DataProvider.Instance.ExcuteNonQuery(query);
			return re != 0;
		}

		public bool DeleteSource(string nguonuv)
		{
			string query = $"EXEC USP_DeleteNguonUngVienByTen @TenNguon = N'{nguonuv}';";
			int re = Convert.ToInt32(DataProvider.Instance.ExcuteScalar(query));
			return re == 0;
		}

		public List<SourceDTO> SearchSource(string value)
		{
			List<SourceDTO> list = new List<SourceDTO>();

			string query = string.Format("SELECT NU.TenNguon, COUNT(HUV.Ma_HS) AS SoLuongHoSo FROM NguonUngVien NU LEFT JOIN HoSoUngVien HUV ON NU.Ma_Nguon = HUV.Ma_Nguon WHERE NU.TenNguon LIKE N'{0}%' GROUP BY NU.TenNguon;\r\n", value);

			Console.WriteLine(query);

			DataTable data = DataProvider.Instance.ExecuteQuery(query);

			foreach (DataRow item in data.Rows)
			{
				SourceDTO source = new SourceDTO(item);

				list.Add(source);
			}
			return list;
		}

	}
}
