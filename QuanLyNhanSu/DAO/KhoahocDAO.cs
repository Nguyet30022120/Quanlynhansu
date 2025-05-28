using QuanLyNhanSu.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu.DAO
{
	public class KhoahocDAO
	{
		private static KhoahocDAO instance;
		public static KhoahocDAO Instance
		{
			get { if (instance == null) instance = new KhoahocDAO(); return KhoahocDAO.instance; }
			private set { KhoahocDAO.instance = value; }
		}
		private KhoahocDAO() { }
		public List<KhoahocDTO> GetListCourse()
		{
			List<KhoahocDTO> list = new List<KhoahocDTO>();
			string query = "SELECT * FROM dbo.KhoaHoc";
			DataTable data = DataProvider.Instance.ExecuteQuery(query);
			foreach (DataRow item in data.Rows)
			{
				KhoahocDTO course = new KhoahocDTO(item);
				list.Add(course);
			}
			return list;
		}

		public bool InsertCourse(string tenkhoahoc, string mota)
		{
			string query = $"EXEC [dbo].[USP_InsertNewKhoaHoc] @TenKhoaHoc = N'{tenkhoahoc}', @MoTa = N'{mota}';";
			int re = DataProvider.Instance.ExcuteNonQuery(query);
			return re != 0;
		}

		public bool UpdateCourse(string makhoahoc, string tenkhoahoc, string mota)
		{
			string query = $"EXEC [dbo].[USP_UpdateKhoaHoc] @Ma_KhoaHoc = N'{makhoahoc}', @TenKhoaHoc = N'{tenkhoahoc}', @MoTa = N'{mota}';";
			int re = Convert.ToInt32(DataProvider.Instance.ExcuteScalar(query));
			return re == 0;
		}
		public bool DeleteCourse(string makhoahoc)
		{
			string query = $"EXEC [dbo].[USP_DeleteKhoaHoc] @Ma_KhoaHoc = '{makhoahoc}'";
			int re = Convert.ToInt32(DataProvider.Instance.ExcuteScalar(query));
			return re == 0;
		}

		public List<KhoahocDTO> SearchCourse(string value)
		{
			List<KhoahocDTO> list = new List<KhoahocDTO>();

			string query = string.Format("SELECT * FROM [KhoaHoc] WHERE Ma_KhoaHoc LIKE N'%{0}%' OR TenKhoaHoc LIKE N'%{1}%'", value, value);

			Console.WriteLine(query);

			DataTable data = DataProvider.Instance.ExecuteQuery(query);

			foreach (DataRow item in data.Rows)
			{
				KhoahocDTO Course = new KhoahocDTO(item);

				list.Add(Course);
			}
			return list;
		}
	}
}
