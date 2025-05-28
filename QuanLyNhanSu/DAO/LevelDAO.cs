using QuanLyNhanSu.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu.DAO
{
	public class LevelDAO
	{
		private static LevelDAO instance;

		//public static UserDAO Instance { get => instance; set => instance=value; }

		public static LevelDAO Instance { get => instance==null ? instance = new LevelDAO() : instance; private set => instance=value; }

		private LevelDAO() { }


		public List<LevelDTO> GetListTrinhDo(string manv)
		{
			List<LevelDTO> list = new List<LevelDTO>();

			string query = $"SELECT TDCM.Ma_TD, NV.HoTen AS TenNhanVien, TDCM.LoaiBangCap, TDCM.ChuyenNganh, TDCM.TruongHoc FROM TrinhDoChuyenMon TDCM JOIN [Nhan vien] NV ON TDCM.Ma_NV = NV.Ma_NV WHERE NV.Ma_NV ='{manv}';\r\n";
			DataTable data = DataProvider.Instance.ExecuteQuery(query);

			foreach (DataRow item in data.Rows)
			{
				LevelDTO Level = new LevelDTO(item);

				list.Add(Level);
			}

			return list;
		}
		public bool InsertTrinhDo(string manv, string loaibc, string chuyennganh, string truonghoc)
		{
			string query = $"EXEC USP_InsertTrinhDo @Ma_NV = '{manv}', @LoaiBangCap = N'{loaibc}', @ChuyenNganh = N'{chuyennganh}', @TruongHoc = N'{truonghoc}';";
			int re = DataProvider.Instance.ExcuteNonQuery(query);
			return re != 0;
		}

		public bool UpdateTrinhDo(string matd, string loaibc, string chuyennganh, string truonghoc)
		{
			string query = $"EXEC USP_UpdateTrinhDoChuyenMon @Ma_TD = '{matd}',@LoaiBangCap = N'{loaibc}',@ChuyenNganh = N'{chuyennganh}',@TruongHoc = N'{truonghoc}';";

			int re = Convert.ToInt32(DataProvider.Instance.ExcuteScalar(query));

			return re == 0;
		}

		public bool DeleteTrinhDo(string matd)
		{
			string query = $"EXEC [dbo].[USP_DeleteTrinhDoChuyenMon] @Ma_TD = '{matd}'";
			int re = Convert.ToInt32(DataProvider.Instance.ExcuteScalar(query));
			return re == 0;
		}




	}
}
