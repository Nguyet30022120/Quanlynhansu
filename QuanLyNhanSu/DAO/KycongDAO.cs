using QuanLyNhanSu.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu.DAO
{
	public class KycongDAO
	{
		private static KycongDAO instance;
		public static KycongDAO Instance
		{
			get { if (instance == null) instance = new KycongDAO(); return instance; }
			private set { instance = value; }
		}
		private KycongDAO() { }
		public List<KycongDTO> GetListKyCong()
		{
			List<KycongDTO> list = new List<KycongDTO>();

			string query = "SELECT * FROM Kycong";
			DataTable data = DataProvider.Instance.ExecuteQuery(query);

			foreach (DataRow item in data.Rows)
			{
				KycongDTO ky = new KycongDTO(item);

				list.Add(ky);
			}

			return list;
		}
		public bool InsertKyCong(int nam, int thang, DateTime ngaytinhcong, int ngaycongtrongthang)
		{
			string query = $"EXEC USP_InsertKyCong @Thang = {thang}, @Nam = {nam}, @NgayTinhCong = '{ngaytinhcong}', @NgayCongTongThang = {ngaycongtrongthang};\r\n";
			int re = DataProvider.Instance.ExcuteNonQuery(query);
			return re != 0;
		}
		public bool UpdateKyCong(int maKyCong, DateTime ngaytinhcong, int ngaycongtrongthang)
		{
			string query = $"EXEC USP_UpdateKyCong @MaKyCong = {maKyCong}, @NgayTinhCong = '{ngaytinhcong}', @NgayCongTongThang = {ngaycongtrongthang};\r\n";
			int re = DataProvider.Instance.ExcuteNonQuery(query);
			return re != 0;
		}
		public bool DeleteKyCong(int maKyCong)
		{
			string query = $"EXEC USP_DeleteKyCong @MaKyCong = {maKyCong};\r\n";
			int re = DataProvider.Instance.ExcuteNonQuery(query);
			return re != 0;
		}

	}
}
