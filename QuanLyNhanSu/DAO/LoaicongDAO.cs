using QuanLyNhanSu.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu.DAO
{
	public class LoaicongDAO
	{
		public static LoaicongDAO instance;
		public static LoaicongDAO Instance
		{
			get { if (instance == null) instance = new LoaicongDAO(); return instance; }
			private set { instance = value; }
		}
		private LoaicongDAO() { }
		public List<LoaicongDTO> GetListLoaiCong()
		{
			List<LoaicongDTO> list = new List<LoaicongDTO>();
			string query = "SELECT * FROM LoaiCong";
			DataTable data = DataProvider.Instance.ExecuteQuery(query);
			foreach (DataRow item in data.Rows)
			{
				LoaicongDTO cong = new LoaicongDTO(item);
				list.Add(cong);
			}
			return list;
		}
		public bool InsertLoaiCong(string loaicong, decimal heso)
		{
			string query = $"EXEC [dbo].[USP_InsertLoaiCong] @TenLoaiCong = N'{loaicong}', @HeSo = {heso};";
			int re = DataProvider.Instance.ExcuteNonQuery(query);
			return re != 0;
		}
		public bool UpdateLoaiCong(int maloaicong, string loaicong, decimal heso)
		{
			string query = $"EXEC [dbo].[USP_UpdateLoaiCong] @MaLoaiCong = {maloaicong}, @TenLoaiCa = N'{loaicong}', @Heso = {heso};";
			int re = DataProvider.Instance.ExcuteNonQuery(query);
			return re != 0;
		}
		public bool DeleteLoaiCong(int maloaicong)
		{
			string query = $"EXEC [dbo].[USP_DeleteLoaiCong] @MaLoaiCong = '{maloaicong}';";
			int re = DataProvider.Instance.ExcuteNonQuery(query);
			return re != 0;
		}
	}
}
