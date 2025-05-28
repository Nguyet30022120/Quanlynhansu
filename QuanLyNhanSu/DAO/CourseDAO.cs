using QuanLyNhanSu.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu.DAO
{
	public class CourseDAO
	{
		private static CourseDAO instance;
		public static CourseDAO Instance
		{
			get { if (instance == null) instance = new CourseDAO(); return CourseDAO.instance; }
			private set { CourseDAO.instance = value; }
		}
		private CourseDAO() { }
		public List<CourseDTO> GetListCourse()
		{
			List<CourseDTO> list = new List<CourseDTO>();
			string query = "SELECT * FROM dbo.KhoaHoc";
			DataTable data = DataProvider.Instance.ExecuteQuery(query);
			foreach (DataRow item in data.Rows)
			{
				CourseDTO course = new CourseDTO(item);
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

		public List<CourseDTO> SearchCourse(string value)
		{
			List<CourseDTO> list = new List<CourseDTO>();

			string query = string.Format("SELECT * FROM [KhoaHoc] WHERE Ma_KhoaHoc LIKE N'%{0}%' OR TenKhoaHoc LIKE N'%{1}%'", value, value);

			Console.WriteLine(query);

			DataTable data = DataProvider.Instance.ExecuteQuery(query);

			foreach (DataRow item in data.Rows)
			{
				CourseDTO Course = new CourseDTO(item);

				list.Add(Course);
			}
			return list;
		}
	}
}
