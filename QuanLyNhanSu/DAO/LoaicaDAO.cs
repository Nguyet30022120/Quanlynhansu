using QuanLyNhanSu.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu.DAO
{
	public class LoaicaDAO
	{
		public static LoaicaDAO instance;
		public static LoaicaDAO Instance
		{
			get { if (instance == null) instance = new LoaicaDAO(); return instance; }
			private set { instance = value; }
		}
		private LoaicaDAO() { }
		public List<LoaicaDTO> GetListLoaiCa()
		{
			List<LoaicaDTO> list = new List<LoaicaDTO>();

			string query = "SELECT * FROM LoaiCa";
			DataTable data = DataProvider.Instance.ExecuteQuery(query);

			foreach (DataRow item in data.Rows)
			{
				LoaicaDTO ca = new LoaicaDTO(item);

				list.Add(ca);
			}

			return list;
		}
		public bool InsertLoaiCa(string loaica, decimal heso)
		{
			string query = $"EXEC [dbo].[USP_InsertLoaiCa] @TenLoaiCa = N'{loaica}', @Heso = {heso};";
			int re = DataProvider.Instance.ExcuteNonQuery(query);
			return re != 0;
		}
		public bool UpdateLoaiCa(int maloaica, string loaica, decimal heso)
		{
			string query = $"EXEC [dbo].[USP_UpdateLoaiCa] @MaLoaiCa = {maloaica}, @TenLoaiCa = N'{loaica}', @Heso = {heso};";
			int re = DataProvider.Instance.ExcuteNonQuery(query);
			return re != 0;
		}
		public bool DeleteLoaiCa(int maloaica)
		{
			string query = $"EXEC [dbo].[USP_DeleteLoaiCa] @MaLoaiCa = '{maloaica}';";
			int re = DataProvider.Instance.ExcuteNonQuery(query);
			return re != 0;
		}
	}
}
