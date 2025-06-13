using QuanLyNhanSu.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu.DAO
{
	public class KetquaphongvanDAO
	{
		private static KetquaphongvanDAO instance;
		public static KetquaphongvanDAO Instance
		{
			get { if (instance == null) instance = new KetquaphongvanDAO(); return instance; }
			private set { instance = value; }
		}
		public List<DTO.KetquaphongvanDTO> GetListResult()
		{
			List<DTO.KetquaphongvanDTO> listResult = new List<DTO.KetquaphongvanDTO>();
			string query = "SELECT HSV.Ma_HS, KQ.Ma_KQ, HSV.HoTen AS TenUV, KQ.DanhGia, KQ.KetLuan, KQ.NgayDanhGia, CASE WHEN EXISTS (SELECT 1 FROM [NhanVien] NV WHERE NV.Email = HSV.Email) THEN N'Đã tiếp nhận' ELSE N'Chưa tiếp nhận' END AS TrangThai FROM KetQuaPhongVan KQ JOIN LichPhongVan LPV ON KQ.Ma_PV = LPV.Ma_PV JOIN HoSoUngVien HSV ON LPV.Ma_HS = HSV.Ma_HS;\r\n";
			DataTable data = DataProvider.Instance.ExecuteQuery(query);
			foreach (DataRow item in data.Rows)
			{
				DTO.KetquaphongvanDTO result = new DTO.KetquaphongvanDTO(item);
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
		public List<KetquaphongvanDTO> SearchResult(string value)
		{
			List<KetquaphongvanDTO> list = new List<KetquaphongvanDTO>();

			string query = string.Format("SELECT HSV.Ma_HS, KQ.Ma_KQ, HSV.HoTen AS TenUV, KQ.DanhGia, KQ.KetLuan, KQ.NgayDanhGia, CASE WHEN EXISTS (SELECT 1 FROM [NhanVien] NV WHERE NV.Email = HSV.Email) THEN N'Đã tiếp nhận' ELSE N'Chưa tiếp nhận' END AS TrangThai FROM KetQuaPhongVan KQ JOIN LichPhongVan LPV ON KQ.Ma_PV = LPV.Ma_PV JOIN HoSoUngVien HSV ON LPV.Ma_HS = HSV.Ma_HS WHERE LPV.Ma_HS LIKE N'%{2}%' OR HSV.HoTen LIKE N'%{0}%' OR KQ.KetLuan LIKE N'%{1}%';\r\n", value, value, value);

			Console.WriteLine(query);

			DataTable data = DataProvider.Instance.ExecuteQuery(query);

			foreach (DataRow item in data.Rows)
			{
				KetquaphongvanDTO result = new KetquaphongvanDTO(item);

				list.Add(result);
			}
			return list;
		}

		
	}
}
