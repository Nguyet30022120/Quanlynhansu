using Microsoft.Identity.Client;
using QuanLyNhanSu.DAO;
using QuanLyNhanSu.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu
{
	public class CuahangDAO
	{
		private static CuahangDAO instance;

		public static CuahangDAO Instance { get => instance==null ? instance = new CuahangDAO() : instance; private set => instance=value; }

		private CuahangDAO() { }


		public List<CuahangDTO> GetListCuaHang()
		{
			List<CuahangDTO> list = new List<CuahangDTO>();

			string query = "SELECT * FROM [CuaHang]";
			DataTable data = DataProvider.Instance.ExecuteQuery(query);

			foreach (DataRow item in data.Rows)
			{
				CuahangDTO office = new CuahangDTO(item);

				list.Add(office);
			}

			return list;
		}

		public bool InsertCuaHang(string tench, string diachi)
		{
			string query = $"EXEC [dbo].[USP_InsertNewDepartment] @TenCuaHang = N'{tench}', @DiaChi = N'{diachi}';";
			int re = DataProvider.Instance.ExcuteNonQuery(query);
			return re != 0;
		}

		public bool UpdateCuaHang(string mach,string tench, string diachi)
		{
			string query = $"EXEC [dbo].[USP_UpdateDepartmentByID] @Ma_CH = '{mach}',@TenCuaHang = N'{tench}',@DiaChi = N'{diachi}'" ;

			int re = Convert.ToInt32(DataProvider.Instance.ExcuteScalar(query));

			return re == 0;
		}

		public bool DeleteCuaHang(string mach)
		{
			string query = $"EXEC [dbo].[USP_DeleteDepartmentByID] @Ma_CH = '{mach}'";
			int re = Convert.ToInt32(DataProvider.Instance.ExcuteScalar(query));
			return re == 0;
		}

		public List<CuahangDTO> SearchCuaHang(string value)
		{
			List<CuahangDTO> list = new List<CuahangDTO>();

			string query = string.Format("SELECT * FROM [CuaHang] WHERE Ma_CH LIKE N'%{0}%' OR TenCuaHang LIKE N'%{1}%'", value, value);

			Console.WriteLine(query);

			DataTable data = DataProvider.Instance.ExecuteQuery(query);

			foreach (DataRow item in data.Rows)
			{
				CuahangDTO office = new CuahangDTO(item);

				list.Add(office);
			}
			return list;
		}

	}
}
