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
			string query = $"SELECT nv.Ma_NV, nv.HoTen,  np.TuNgay as NgayBatDau, np.DenNgay as NgayKetThuc, np.LyDo, np.TrangThai FROM DonNghiPhep AS np JOIN [NhanVien] AS nv ON np.Ma_NV = nv.Ma_NV WHere nv.Ma_NV ='{manv}'\r\n\r\n";
			DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { });
			foreach (DataRow item in data.Rows)
			{
				ThongkenghiphepDTO onLeave = new ThongkenghiphepDTO(item);
				list.Add(onLeave);
			}
			return list;
		}
		public List<ThongkenghiphepDTO> GetOnLeaving()
		{
			List<ThongkenghiphepDTO> list = new List<ThongkenghiphepDTO>();
			string query = $"SELECT nv.Ma_NV, nv.HoTen,  np.TuNgay as NgayBatDau, np.DenNgay as NgayKetThuc, np.LyDo, np.TrangThai FROM DonNghiPhep AS np JOIN [NhanVien] AS nv ON np.Ma_NV = nv.Ma_NV\r\n\r\n";
			DataTable data = DataProvider.Instance.ExecuteQuery(query, new object[] { });
			foreach (DataRow item in data.Rows)
			{
				ThongkenghiphepDTO onLeave = new ThongkenghiphepDTO(item);
				list.Add(onLeave);
			}
			return list;
		}

		public DataTable GetOnLeavingNam(string maNV, int nam)
		{
			{
				string query = $"SELECT MONTH(TuNgay) AS Thang, SUM(DATEDIFF(DAY, TuNgay, DenNgay) + 1) AS SoNgayNghi FROM DonNghiPhep WHERE Ma_NV = '{maNV}' AND YEAR(TuNgay) = '{nam}' AND TrangThai = N'Đã duyệt' GROUP BY MONTH(TuNgay) ORDER BY Thang";
				return DataProvider.Instance.ExecuteQuery(query);
			}
		}
		public DataTable GetNgayNghiNamAll()
		{
			string query = $"SELECT MONTH(TuNgay) AS Thang, SUM(DATEDIFF(DAY, TuNgay, DenNgay) + 1) AS SoNgayNghi FROM DonNghiPhep WHERE YEAR(TuNgay) = 2025 AND TrangThai = N'Đã duyệt' GROUP BY MONTH(TuNgay) ORDER BY Thang;\r\n";
			return DataProvider.Instance.ExecuteQuery(query);

		}

	}
}
