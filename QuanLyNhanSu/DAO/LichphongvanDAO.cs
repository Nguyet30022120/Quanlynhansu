using QuanLyNhanSu.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanSu.DAO
{
	public class LichphongvanDAO
	{
		private static LichphongvanDAO instance;


		public static LichphongvanDAO Instance { get => instance==null ? instance = new LichphongvanDAO() : instance; private set => instance=value; }

		private LichphongvanDAO() { }

		public List<LichphongvanDTO> GetSchedule()
		{
			List<LichphongvanDTO> list = new List<LichphongvanDTO>();

			string query = "SELECT LPV.Ma_HS, LPV.Ma_PV, HSV.HoTen, LPV.NgayPV, LPV.ThoiGianPV, LPV.DiaDiem, NV.HoTen + '-' + NV.Ma_NV AS [NguoiPV], LPV.TrangThai FROM LichPhongVan LPV JOIN HoSoUngVien HSV ON LPV.Ma_HS = HSV.Ma_HS JOIN [NhanVien] NV ON LPV.Ma_NV_PV = NV.Ma_NV ORDER BY NgayPV ASC, ThoiGianPV ASC;;\r\n";
			DataTable data = DataProvider.Instance.ExecuteQuery(query);

			foreach (DataRow item in data.Rows)
			{
				LichphongvanDTO Schedule = new LichphongvanDTO(item);

				list.Add(Schedule);
			}

			return list;
		}
		public bool InsertSchedule(string mahs, string nguoipv, DateTime ngaypv, DateTime thoigianpv, string diadiem)
		{
			string query = $"EXEC [dbo].[USP_InsertLichPhongVann] @Ma_HS = '{mahs}', @TenNguoiPV = N'{nguoipv}', @NgayPV = '{ngaypv}', @ThoiGianPV = '{thoigianpv}', @DiaDiem = N'{diadiem}';\r\n";

			int re = DataProvider.Instance.ExcuteNonQuery(query);

			return re > 0;
		}

		public bool UpdateSchedule(string mapv, string nguoipv, DateTime ngaypv, DateTime thoigianpv, string diadiem, string trangthai)
		{
			string query = $"EXEC USP_UpdateLichPhongVan @Ma_PV = '{mapv}',@TenNguoiPV = N'{nguoipv}', @NgayPV = '{ngaypv}', @ThoiGianPV = '{thoigianpv}', @DiaDiem = N'{diadiem}',@TrangThai = N'{trangthai}';\r\n";
			int re = DataProvider.Instance.ExcuteNonQuery(query);
			return re > 0;
		}
		public bool DeleteSchedule(string mapv)
		{
			string query = $"EXEC USP_DeleteLichPhongVan @Ma_PV = '{mapv}';";
			int re = DataProvider.Instance.ExcuteNonQuery(query);
			return re > 0;
		}


		public List<LichphongvanDTO> SearchSchedule(string value)
		{
			List<LichphongvanDTO> list = new List<LichphongvanDTO>();

			string query = string.Format("SELECT LPV.Ma_HS, LPV.Ma_PV, HSV.HoTen, LPV.NgayPV, LPV.ThoiGianPV, LPV.DiaDiem, NV.HoTen + '-' + NV.Ma_NV AS [NguoiPV], LPV.TrangThai FROM LichPhongVan LPV JOIN HoSoUngVien HSV ON LPV.Ma_HS = HSV.Ma_HS JOIN [Nhanvien] NV ON LPV.Ma_NV_PV = NV.Ma_NV WHERE LPV.Ma_HS LIKE '%{5}%' OR LPV.Ma_PV LIKE N'%{0}%' OR HSV.HoTen LIKE N'%{1}%' OR LPV.NgayPV LIKE '%{2}%' OR LPV.DiaDiem LIKE N'%{3}%' OR LPV.TrangThai LIKE N'%{4}%'", value, value, value, value, value, value);

			Console.WriteLine(query);

			DataTable data = DataProvider.Instance.ExecuteQuery(query);

			foreach (DataRow item in data.Rows)
			{
				LichphongvanDTO Schedule = new LichphongvanDTO(item);

				list.Add(Schedule);
			}
			return list;
		}
		public bool IsProfileAccepted(string mahs)
		{
			string query = "SELECT COUNT(*) FROM LichPhongVan WHERE Ma_HS = @mahs";
			object result = DataProvider.Instance.ExcuteScalar(query, new object[] { mahs });
			int count = 0;
			if (result != null && int.TryParse(result.ToString(), out int temp))
			{
				count = temp;
			}
			return count > 0;
		}
	}
}

