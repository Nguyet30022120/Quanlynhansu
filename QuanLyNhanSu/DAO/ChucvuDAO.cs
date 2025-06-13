using QuanLyNhanSu.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu.DAO
{
	public class ChucvuDAO
	{
		private static ChucvuDAO instance;


		public static ChucvuDAO Instance { get => instance==null ? instance = new ChucvuDAO() : instance; private set => instance=value; }

		private ChucvuDAO() { }


		public List<ChucvuDTO> GetListChucVu()
		{
			List<ChucvuDTO> list = new List<ChucvuDTO>();

			string query = "SELECT Ma_CV as MaChucVu, TenChucVu, MoTaChucVu FROM [ChucVu]";
			DataTable data = DataProvider.Instance.ExecuteQuery(query);

			foreach (DataRow item in data.Rows)
			{
				ChucvuDTO chucvu = new ChucvuDTO(item);

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

		public List<ChucvuDTO> SearchPosition(string value)
		{
			List<ChucvuDTO> list = new List<ChucvuDTO>();

			string query = string.Format("SELECT Ma_CV as MaChucVu, TenChucVu, MoTaChucVu FROM [ChucVu] WHERE Ma_CV LIKE N'%{0}%' OR TenChucVu LIKE N'%{1}%' OR MoTaChucVu LIKE N'%{2}%'", value, value, value);

			Console.WriteLine(query);

			DataTable data = DataProvider.Instance.ExecuteQuery(query);

			foreach (DataRow item in data.Rows)
			{
				ChucvuDTO position = new ChucvuDTO(item);

				list.Add(position);
			}
			return list;
		}
	}
}
