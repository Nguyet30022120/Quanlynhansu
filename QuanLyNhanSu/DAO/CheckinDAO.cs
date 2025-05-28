using QuanLyNhanSu.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu.DAO
{
	public class CheckinDAO
	{
		private static CheckinDAO instance;
		public static CheckinDAO Instance
		{
			get { if (instance == null) instance = new CheckinDAO(); return instance; }
			private set { instance = value; }
		}

		public List<CheckinDTO> GetCheckInByMaNV(string manv)
		{
			List<CheckinDTO> list = new List<CheckinDTO>();
			string query = $"SELECT c.MaCheckIn, c.Ma_NV, c.GioCheckIn, c.NgayCheckIn, n.HoTen FROM CheckIn c JOIN [Nhan Vien] n ON c.Ma_NV = n.Ma_NV WHERE n.Ma_NV ='{manv}';\r\n";
			DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { });
			foreach (DataRow item in data.Rows)
			{
				CheckinDTO checkin = new CheckinDTO(item);
				list.Add(checkin);
			}
			return list;
		}
		public bool InsertCheckIn(string manv)
		{
			string query = $"EXEC USP_InsertCheckIn @MaNV = '{manv}';";
			int re = DataProvider.Instance.ExcuteNonQuery(query);
			return re != 0;
		}

		public bool UpdateCheckIn(string manv, DateTime thoigiancheckin, DateTime ngaycheckin)
		{
			string query = $"EXEC USP_UpdateCheckIn @Ma_NV = '{manv}',@NgayCheckIn = '{ngaycheckin}',@GioMoi = '{thoigiancheckin}';";
			int re = DataProvider.Instance.ExcuteNonQuery(query);
			return re != 0;
		}
		public bool DeleteCheckIn(int maCheckIn)
		{
			string query = $"EXEC USP_DeleteCheckIn @MaCheckIn = '{maCheckIn}';";
			int re = DataProvider.Instance.ExcuteNonQuery(query);
			return re != 0;
		}
	}
}
