using QuanLyNhanSu.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu.DAO
{
	public class ContractDAO
	{
		private static ContractDAO instance;

		//public static ContractDAO Instance { get => instance; set => instance=value; }

		public static ContractDAO Instance { get => instance==null ? instance = new ContractDAO() : instance; private set => instance=value; }

		private ContractDAO() { }


		public List<ContractDTO> GetListHopDong()
		{
			List<ContractDTO> list = new List<ContractDTO>();

			string query = "SELECT HD.Ma_HD, HD.Ma_NV, NV.HoTen AS TenNhanVien, HD.NgayDangKy, HD.Han_HD AS NgayHetHan, HD.TrangThai FROM [Hop dong] AS HD INNER JOIN [Nhan vien] AS NV ON HD.Ma_NV = NV.Ma_NV;\r\n";
			DataTable data = DataProvider.Instance.ExecuteQuery(query);

			foreach (DataRow item in data.Rows)
			{
				ContractDTO contract = new ContractDTO(item);


				list.Add(contract);
			}

			return list;
		}

		public bool InsertHopDong(string manv, DateTime ngaydk, DateTime ngayhh)
		{
			string query = $"EXEC [dbo].[USP_InsertNewContract] @Ma_NV = N'{manv}', @NgayDangKy = N'{ngaydk}', @Han_HD = N'{ngayhh}';";
			int re = DataProvider.Instance.ExcuteNonQuery(query);
			return re != 0;
		}

		public bool UpdateHopDong(string mahd, DateTime ngaydk, DateTime ngayhh)
		{
			string query = $"EXEC [dbo].[USP_UpdateContractDates] @Ma_HD = N'{mahd}', @NgayDangKy = N'{ngaydk}', @Han_HD = N'{ngayhh}';";
			int re = Convert.ToInt32(DataProvider.Instance.ExcuteScalar(query));
			return re == 0;
		}

		public bool DeleteContract(string mahd)
		{
			string query = $"EXEC [dbo].[USP_DeleteContractByID] @Ma_HD = '{mahd}'";
			int re = Convert.ToInt32(DataProvider.Instance.ExcuteScalar(query));
			return re == 0;
		}

		public bool UpdateTrangThai()
		{
			string query = $"EXEC USP_UpdateContractStatusIfExpired;";
			int re = Convert.ToInt32(DataProvider.Instance.ExcuteScalar(query));
			return re == 0;
		}
		public List<ContractDTO> SearchContract(string value)
		{
			List<ContractDTO> list = new List<ContractDTO>();

			string query = string.Format("SELECT HD.Ma_HD, HD.Ma_NV, NV.HoTen AS TenNhanVien, HD.NgayDangKy, HD.Han_HD AS NgayHetHan, HD.TrangThai FROM [Hop dong] AS HD INNER JOIN [Nhan vien] AS NV ON HD.Ma_NV = NV.Ma_NV WHERE HD.Ma_HD LIKE N'{0}' OR NV.HoTen LIKE N'{1}';", value, value);

			Console.WriteLine(query);

			DataTable data = DataProvider.Instance.ExecuteQuery(query);

			foreach (DataRow item in data.Rows)
			{
				ContractDTO Contract = new ContractDTO(item);

				list.Add(Contract);
			}
			return list;
		}
	}
}
