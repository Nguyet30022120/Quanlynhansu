using QuanLyNhanSu.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu.DAO
{
	public class PositionDAO
	{
		private static PositionDAO instance;

		//public static UserDAO Instance { get => instance; set => instance=value; }

		public static PositionDAO Instance { get => instance==null ? instance = new PositionDAO() : instance; private set => instance=value; }

		private PositionDAO() { }


		public List<PositionDTO> GetListChucVu()
		{
			List<PositionDTO> list = new List<PositionDTO>();

			string query = "SELECT Ma_ChucVu as MaChucVu, TenChucVu, MoTaChucVu FROM [Chuc Vu]";
			DataTable data = DataProvider.Instance.ExecuteQuery(query);

			foreach (DataRow item in data.Rows)
			{
				PositionDTO chucvu = new PositionDTO(item);

				list.Add(chucvu);
			}

			return list;
		}

		public bool InsertPosition(string tencv, string motachucvu)
		{
			string query = $"EXEC [dbo].[USP_InsertNewPosition] @TenChucVu = N'{tencv}', @MoTaChucVu = N'{motachucvu}';";
			int re = DataProvider.Instance.ExcuteNonQuery(query);
			return re != 0;
		}

		public bool UpdatePosition(int macv, string tencv, string motachucvu)
		{
			string query = $"EXEC [dbo].[USP_UpdatePositionByID] @Ma_ChucVu = '{macv}',@TenChucVu = N'{tencv}',@MoTaChucVu = N'{motachucvu}'";

			int re = Convert.ToInt32(DataProvider.Instance.ExcuteScalar(query));

			return re == 0;
		}
		public bool DeletePosition(int macv)
		{
			string query = $"EXEC [dbo].[USP_DeletePositionByID] @Ma_ChucVu = '{macv}'";
			int re = Convert.ToInt32(DataProvider.Instance.ExcuteScalar(query));
			return re == 0;
		}

		public List<PositionDTO> SearchPosition(string value)
		{
			List<PositionDTO> list = new List<PositionDTO>();

			string query = string.Format("SELECT Ma_ChucVu as MaChucVu, TenChucVu, MoTaChucVu FROM [Chuc Vu] WHERE Ma_ChucVu LIKE N'%{0}%' OR TenChucVu LIKE N'%{1}%' OR MoTaChucVu LIKE N'%{2}%'", value, value, value);

			Console.WriteLine(query);

			DataTable data = DataProvider.Instance.ExecuteQuery(query);

			foreach (DataRow item in data.Rows)
			{
				PositionDTO position = new PositionDTO(item);

				list.Add(position);
			}
			return list;
		}
	}
}
