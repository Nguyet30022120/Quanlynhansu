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
	public class ScheduleDAO
	{
		private static ScheduleDAO instance;


		public static ScheduleDAO Instance { get => instance==null ? instance = new ScheduleDAO() : instance; private set => instance=value; }

		private ScheduleDAO() { }

		public List<ScheduleDTO> GetSchedule()
		{
			List<ScheduleDTO> list = new List<ScheduleDTO>();

			string query = "SELECT LPV.Ma_PV, HSV.HoTen, LPV.NgayPV, LPV.ThoiGianPV, LPV.DiaDiem, NV.HoTen + '-' + NV.Ma_NV AS [NguoiPV], LPV.TrangThai FROM LichPhongVan LPV JOIN HoSoUngVien HSV ON LPV.Ma_HS = HSV.Ma_HS JOIN [Nhan vien] NV ON LPV.Ma_NV_PV = NV.Ma_NV;\r\n";
			DataTable data = DataProvider.Instance.ExecuteQuery(query);

			foreach (DataRow item in data.Rows)
			{
				ScheduleDTO Schedule = new ScheduleDTO(item);

				list.Add(Schedule);
			}

			return list;
		}
		public bool InsertSchedule(string tenuv, string nguoipv, DateTime ngaypv, DateTime thoigianpv, string diadiem)
		{
			string query = $"EXEC USP_InsertLichPhongVann @TenUV = N'{tenuv}', @TenNguoiPV = N'{nguoipv}', @NgayPV = '{ngaypv}', @ThoiGianPV = '{thoigianpv}', @DiaDiem = N'{diadiem}'";

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

		public List<ScheduleDTO> GetScheduleArrange()
		{
			List<ScheduleDTO> list = new List<ScheduleDTO>();

			string query = "SELECT LPV.Ma_PV, HSV.HoTen, LPV.NgayPV, LPV.ThoiGianPV, LPV.DiaDiem, NV.HoTen + '-' + NV.Ma_NV AS [NguoiPV], LPV.TrangThai FROM LichPhongVan LPV JOIN HoSoUngVien HSV ON LPV.Ma_HS = HSV.Ma_HS JOIN [Nhan vien] NV ON LPV.Ma_NV_PV = NV.Ma_NV ORDER BY NgayPV ASC, ThoiGianPV ASC;;\r\n";
			DataTable data = DataProvider.Instance.ExecuteQuery(query);

			foreach (DataRow item in data.Rows)
			{
				ScheduleDTO Schedule = new ScheduleDTO(item);

				list.Add(Schedule);
			}

			return list;
		}

		public List<ScheduleDTO> SearchSchedule(string value)
		{
			List<ScheduleDTO> list = new List<ScheduleDTO>();

			string query = string.Format("SELECT LPV.Ma_PV, HSV.HoTen, LPV.NgayPV, LPV.ThoiGianPV, LPV.DiaDiem, NV.HoTen + '-' + NV.Ma_NV AS [NguoiPV], LPV.TrangThai FROM LichPhongVan LPV JOIN HoSoUngVien HSV ON LPV.Ma_HS = HSV.Ma_HS JOIN [Nhan vien] NV ON LPV.Ma_NV_PV = NV.Ma_NV WHERE LPV.Ma_PV LIKE N'%{0}%' OR HSV.HoTen LIKE N'%{1}%' OR LPV.NgayPV LIKE '%{2}%' OR LPV.DiaDiem LIKE N'%{3}%' OR LPV.TrangThai LIKE N'%{4}%'", value, value, value, value, value);

			Console.WriteLine(query);

			DataTable data = DataProvider.Instance.ExecuteQuery(query);

			foreach (DataRow item in data.Rows)
			{
				ScheduleDTO Schedule = new ScheduleDTO(item);

				list.Add(Schedule);
			}
			return list;
		}
	}
}

