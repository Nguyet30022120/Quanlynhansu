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
	public class OfficeDAO
	{
		private static OfficeDAO instance;

		//public static UserDAO Instance { get => instance; set => instance=value; }

		public static OfficeDAO Instance { get => instance==null ? instance = new OfficeDAO() : instance; private set => instance=value; }

		private OfficeDAO() { }


		public List<OfficeDTO> GetListPhongBan()
		{
			List<OfficeDTO> list = new List<OfficeDTO>();

			string query = "SELECT * FROM [Phong Ban]";
			DataTable data = DataProvider.Instance.ExecuteQuery(query);

			foreach (DataRow item in data.Rows)
			{
				OfficeDTO office = new OfficeDTO(item);

				list.Add(office);
			}

			return list;
		}

		public bool InsertPhongBan(string tenpb, string diachi)
		{
			string query = $"EXEC [dbo].[USP_InsertNewDepartment] @TenPhong = N'{tenpb}', @DiaChi = N'{diachi}';";
			int re = DataProvider.Instance.ExcuteNonQuery(query);
			return re != 0;
		}

		public bool UpdateOffice(string mapb,string tenpb, string diachi)
		{
			string query = $"EXEC [dbo].[USP_UpdateDepartmentByID] @Ma_PB = '{mapb}',@TenPhong = N'{tenpb}',@DiaChi = N'{diachi}'" ;

			int re = Convert.ToInt32(DataProvider.Instance.ExcuteScalar(query));

			return re == 0;
		}

		public bool DeleteOffice(string mapb)
		{
			string query = $"EXEC [dbo].[USP_DeleteDepartmentByID] @Ma_PB = '{mapb}'";
			int re = Convert.ToInt32(DataProvider.Instance.ExcuteScalar(query));
			return re == 0;
		}

		public List<OfficeDTO> SearchOffice(string value)
		{
			List<OfficeDTO> list = new List<OfficeDTO>();

			string query = string.Format("SELECT * FROM [Phong Ban] WHERE Ma_PB LIKE N'%{0}%' OR TenPhong LIKE N'%{1}%'", value, value);

			Console.WriteLine(query);

			DataTable data = DataProvider.Instance.ExecuteQuery(query);

			foreach (DataRow item in data.Rows)
			{
				OfficeDTO office = new OfficeDTO(item);

				list.Add(office);
			}
			return list;
		}

	}
}
