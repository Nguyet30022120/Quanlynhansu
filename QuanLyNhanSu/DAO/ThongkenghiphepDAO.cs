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
	public class ThongkenghiphepDAO
	{
		private static ThongkenghiphepDAO instance;
		public static ThongkenghiphepDAO Instance
		{
			get { if (instance == null) instance = new ThongkenghiphepDAO(); return instance; }
			private set { instance = value; }
		}
		private ThongkenghiphepDAO() { }
		public List<ThongkenghiphepDTO> GetOnLeavingByMaNV(string manv)
		{
			List<ThongkenghiphepDTO> list = new List<ThongkenghiphepDTO>();
			string query = $"SELECT nv.Ma_NV, nv.HoTen,  np.NgayBatDau, np.NgayKetThuc, np.LyDo, np.TrangThai FROM LichNghiPhep AS np JOIN [Nhan vien] AS nv ON np.Ma_NV = nv.Ma_NV WHere nv.Ma_NV ='{manv}'";
			DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { });
			foreach (DataRow item in data.Rows)
			{
				ThongkenghiphepDTO onLeave = new ThongkenghiphepDTO(item);
				list.Add(onLeave);
			}
			return list;
		}
		public List<ThongkenghiphepDTO> GetOnLeavingByNgay(string manv, DateTime ngaybd, DateTime ngaykt)
		{
			List<ThongkenghiphepDTO> list = new List<ThongkenghiphepDTO>();
			string query = $"SELECT nv.Ma_NV, nv.HoTen, np.MaNghiPhep, np.NgayBatDau, np.NgayKetThuc, np.LyDo, np.TrangThai FROM LichNghiPhep AS np JOIN [Nhan vien] AS nv ON np.Ma_NV = nv.Ma_NV WHERE np.NgayBatDau >= '{ngaybd}' AND np.NgayKetThuc <= '{ngaykt}';";
			DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { });
			foreach (DataRow item in data.Rows)
			{
				ThongkenghiphepDTO onLeave = new ThongkenghiphepDTO(item);
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
