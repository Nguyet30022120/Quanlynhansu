using QuanLyNhanSu.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu.DAO
{
	public class ResultDAO
	{
		private static ResultDAO instance;
		public static ResultDAO Instance
		{
			get { if (instance == null) instance = new ResultDAO(); return instance; }
			private set { instance = value; }
		}
		public List<DTO.ResultDTO> GetListResult()
		{
			List<DTO.ResultDTO> listResult = new List<DTO.ResultDTO>();
			string query = "SELECT HSV.Ma_HS, KQ.Ma_KQ, HSV.HoTen AS TenUV, KQ.DanhGia, KQ.KetLuan, KQ.NgayDanhGia FROM KetQuaPhongVan KQ JOIN LichPhongVan LPV ON KQ.Ma_PV = LPV.Ma_PV JOIN HoSoUngVien HSV ON LPV.Ma_HS = HSV.Ma_HS;\r\n";
			DataTable data = DataProvider.Instance.ExecuteQuery(query);
			foreach (DataRow item in data.Rows)
			{
				DTO.ResultDTO result = new DTO.ResultDTO(item);
				listResult.Add(result);
			}
			return listResult;
		}
		public bool InsertResult(string mahs, string danhgia, string ketluan, DateTime ngaydanhgia)
		{
			string query = $"EXEC USP_InsertKetQuaPV @Ma_HS = N'{mahs}', @DanhGia = N'{danhgia}', @KetLuan = N'{ketluan}', @NgayDanhGia = '{ngaydanhgia}';";
			int re = DataProvider.Instance.ExcuteNonQuery(query);
			return re > 0;
		}
		public bool UpdateResult(string makq, string tenuv, string danhgia, string ketluan, DateTime ngaydanhgia)
		{
			string query = $"EXEC USP_UpdateKetQuaPV @Ma_KQ = '{makq}', @DanhGia = N'{danhgia}', @KetLuan = N'{ketluan}', @NgayDanhGia = '{ngaydanhgia}';\r\n";
			int re = DataProvider.Instance.ExcuteNonQuery(query);
			return re > 0;
		}
		public bool DeleteResult(string makq)
		{
			string query = $"EXEC USP_DeleteKetQuaPV @Ma_KQ = '{makq}';";
			int re = DataProvider.Instance.ExcuteNonQuery(query);
			return re > 0;
		}
		public List<ResultDTO> SearchResult(string value)
		{
			List<ResultDTO> list = new List<ResultDTO>();

			string query = string.Format("SELECT KQ.Ma_KQ, HSV.HoTen AS TenUV, KQ.DanhGia, KQ.KetLuan, KQ.NgayDanhGia FROM KetQuaPhongVan KQ JOIN LichPhongVan LPV ON KQ.Ma_PV = LPV.Ma_PV JOIN HoSoUngVien HSV ON LPV.Ma_HS = HSV.Ma_HS WHERE HSV.HoTen LIKE N'%{0}%' OR KQ.KetLuan LIKE N'%{1}%'", value, value);

			Console.WriteLine(query);

			DataTable data = DataProvider.Instance.ExecuteQuery(query);

			foreach (DataRow item in data.Rows)
			{
				ResultDTO result = new ResultDTO(item);

				list.Add(result);
			}
			return list;
		}

		
	}
}
