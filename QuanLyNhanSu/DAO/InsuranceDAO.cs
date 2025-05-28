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
	public class InsuranceDAO
	{
		private static InsuranceDAO instance;
		public static InsuranceDAO Instance
		{
			get { if (instance == null) instance = new InsuranceDAO(); return instance; }
			private set { instance = value; }
		}
		private InsuranceDAO() { }
		public List<InsuranceDTO> GetListInsurance(string manv)
		{
			List<InsuranceDTO> list = new List<InsuranceDTO>();
			string query = $"SELECT nv.HoTen, bh.NgayBatDau, bh.NgayKetThuc, bh.Ma_BH, bh.LoaiBaoHiem, bh.MoTa FROM ThongTinBaoHiem bh JOIN [Nhan vien] nv ON bh.Ma_NV = nv.Ma_NV WHERE bh.Ma_NV = '{manv}';\r\n;";
			DataTable data = DataProvider.Instance.ExecuteQuery(query);
			foreach (DataRow item in data.Rows)
			{
				InsuranceDTO insurance = new InsuranceDTO(item);
				list.Add(insurance);
			}
			return list;
		}
		public bool InsertInsurance(string maNV, string loaiBH, string moTa, DateTime ngayBD, DateTime ngayKT)
		{
			string query = $"EXEC USP_InsertThongTinBaoHiem @Ma_NV = '{maNV}',@LoaiBaoHiem = N'{loaiBH}',@MoTa = N'{moTa}',@NgayBatDau = '{ngayBD}',@NgayKetThuc = '{ngayKT}';\r\n";
			int re = DataProvider.Instance.ExcuteNonQuery(query);
			return re != 0;
		}
		public bool UpdateInsurance(string maBH, string loaiBH, string moTa, DateTime ngayBD, DateTime ngayKT, string maNV)
		{
			string query = $"EXEC USP_UpdateThongTinBaoHiem @Ma_BH = '{maBH}', @Ma_NV = '{maNV}',@LoaiBaoHiem = N'{loaiBH}',@MoTa = N'{moTa}',@NgayBatDau = '{ngayBD}',@NgayKetThuc = '{ngayKT}';\r\n";
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
