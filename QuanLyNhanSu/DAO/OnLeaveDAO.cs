using QuanLyNhanSu.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms.Integration;
using System.Windows.Forms;

namespace QuanLyNhanSu.DAO
{
	public class OnLeaveDAO
	{
		private static OnLeaveDAO instance;
		public static OnLeaveDAO Instance
		{
			get { if (instance == null) instance = new OnLeaveDAO(); return instance; }
			private set { instance = value; }
		}
		private OnLeaveDAO() { }
		public List<OnLeaveStatisticDTO> GetOnLeavingByMaNV(string manv)
		{
			List<OnLeaveStatisticDTO> list = new List<OnLeaveStatisticDTO>();
			string query = $"SELECT nv.Ma_NV, nv.HoTen,  np.NgayBatDau, np.NgayKetThuc, np.LyDo, np.TrangThai FROM LichNghiPhep AS np JOIN [Nhan vien] AS nv ON np.Ma_NV = nv.Ma_NV WHere nv.Ma_NV ='{manv}'";
			DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { });
			foreach (DataRow item in data.Rows)
			{
				OnLeaveStatisticDTO onLeave = new OnLeaveStatisticDTO(item);
				list.Add(onLeave);
			}
			return list;
		}
		public List<OnLeaveStatisticDTO> GetOnLeavingByNgay(string manv, DateTime ngaybd, DateTime ngaykt)
		{
			List<OnLeaveStatisticDTO> list = new List<OnLeaveStatisticDTO>();
			string query = $"SELECT nv.Ma_NV, nv.HoTen, np.MaNghiPhep, np.NgayBatDau, np.NgayKetThuc, np.LyDo, np.TrangThai FROM LichNghiPhep AS np JOIN [Nhan vien] AS nv ON np.Ma_NV = nv.Ma_NV WHERE np.NgayBatDau >= '{ngaybd}' AND np.NgayKetThuc <= '{ngaykt}';";
			DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { });
			foreach (DataRow item in data.Rows)
			{
				OnLeaveStatisticDTO onLeave = new OnLeaveStatisticDTO(item);
				list.Add(onLeave);
			}
			return list;
		}
		public DataTable GetNgayNghiTheoThang(string maNV)
		{
			string query = $"SELECT MONTH(NgayBatDau) AS Thang, SUM(DATEDIFF(DAY, NgayBatDau, NgayKetThuc) + 1) AS SoNgayNghi FROM LichNghiPhep WHERE Ma_NV = '{maNV}' AND TrangThai = N'Đã duyệt' GROUP BY MONTH(NgayBatDau) ORDER BY Thang";

			DataTable result = new DataTable();

			//using (SqlConnection conn = new SqlConnection(DataProvider.Instance.ConnectionString))
			//{
			//	using (SqlCommand cmd = new SqlCommand(query, conn))
			//	{
			//		cmd.Parameters.AddWithValue("@MaNV", maNV);

			//		SqlDataAdapter adapter = new SqlDataAdapter(cmd);
			//		adapter.Fill(result);
			//	}
			//}

			return result;

		}
	}
}
