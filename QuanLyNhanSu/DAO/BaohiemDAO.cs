using QuanLyNhanSu.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Sources;

namespace QuanLyNhanSu.DAO
{
	public class BaohiemDAO
	{
		private static BaohiemDAO instance;
		public static BaohiemDAO Instance
		{
			get { if (instance == null) instance = new BaohiemDAO(); return instance; }
			private set { instance = value; }
		}
		private BaohiemDAO() { }
		public List<BaohiemDTO> GetListInsurance(string manv)
		{
			List<BaohiemDTO> list = new List<BaohiemDTO>();
			string query = $"SELECT nv.HoTen, bh.NgayBatDau, bh.NgayKetThuc, bh.Ma_BH, bh.LoaiBaoHiem, bh.MoTa, bh.SoTienDong FROM ThongTinBaoHiem bh JOIN [Nhan vien] nv ON bh.Ma_NV = nv.Ma_NV WHERE bh.Ma_NV = '{manv}';\r\n;";
			DataTable data = DataProvider.Instance.ExecuteQuery(query);
			foreach (DataRow item in data.Rows)
			{
				BaohiemDTO insurance = new BaohiemDTO(item);
				list.Add(insurance);
			}
			return list;
		}
		public bool InsertInsurance(string maNV, string loaiBH, string moTa, DateTime ngayBD, DateTime ngayKT, decimal tienBH)
		{
			string query = $"EXEC USP_InsertThongTinBaoHiem @Ma_NV = '{maNV}',@LoaiBaoHiem = N'{loaiBH}',@MoTa = N'{moTa}',@NgayBatDau = '{ngayBD}',@NgayKetThuc = '{ngayKT}', @SoTienDong = '{tienBH}';\r\n";
			int re = DataProvider.Instance.ExcuteNonQuery(query);
			return re != 0;
		}
		public bool UpdateInsurance(string maBH, string loaiBH, string moTa, DateTime ngayBD, DateTime ngayKT, string maNV, decimal tienBH)
		{
			string query = $"EXEC USP_UpdateThongTinBaoHiem @Ma_BH = '{maBH}', @Ma_NV = '{maNV}',@LoaiBaoHiem = N'{loaiBH}',@MoTa = N'{moTa}',@NgayBatDau = '{ngayBD}',@NgayKetThuc = '{ngayKT}',@SoTienDong = '{tienBH}';\r\n";
			int re = DataProvider.Instance.ExcuteNonQuery(query);
			return re != 0;
		}
		public bool DeleteInsurance(string maBH)
		{
			string query = $"EXEC USP_DeleteThongTinBaoHiem @Ma_BH = '{maBH}';\r\n";
			int re = DataProvider.Instance.ExcuteNonQuery(query);
			return re != 0;
		}
	}
}
