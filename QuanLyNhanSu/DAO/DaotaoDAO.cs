using QuanLyNhanSu.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu.DAO
{
	public class DaotaoDAO
	{
		private static DaotaoDAO instance;

		//public static TrainingDAO Instance { get => instance; set => instance=value; }

		public static DaotaoDAO Instance { get => instance==null ? instance = new DaotaoDAO() : instance; private set => instance=value; }

		private DaotaoDAO() { }


		public List<DaotaoDTO> GetListDaoTao()
		{
			List<DaotaoDTO> list = new List<DaotaoDTO>();

			string query = "SELECT DT.Ma_DaoTao, NV.HoTen, KH.TenKhoaHoc, DT.KetQua, DT.TrangThai FROM DaoTaoNhanVien DT INNER JOIN [Nhan vien] NV ON DT.Ma_NV = NV.Ma_NV INNER JOIN KhoaHoc KH ON DT.Ma_KhoaHoc = KH.Ma_KhoaHoc;";
			DataTable data = DataProvider.Instance.ExecuteQuery(query);

			foreach (DataRow item in data.Rows)
			{
				DaotaoDTO training = new DaotaoDTO(item);


				list.Add(training);
			}

			return list;
		}

		public bool InsertDaoTao(string tennv, string tenkh)
		{
			string query = $"EXEC [USP_InsertDaoTaoNhanVien_ByName] @TenNhanVien = N'{tennv}',  @TenKhoaHoc = N'{tenkh}';";
			int re = DataProvider.Instance.ExcuteNonQuery(query);
			return re != 0;
		}

		public bool UpdateDaoTao(string madt, string tennv, string tenkh, string trangthai, string ketqua)
		{
			string query = $"EXEC USP_UpdateDaoTao @Ma_DaoTao = '{madt}', @TenNhanVien = N'{tennv}', @TenKhoaHoc = N'{tenkh}', @KetQua = N'{ketqua}', @TrangThai = N'{trangthai}';\r\n";
			int re = Convert.ToInt32(DataProvider.Instance.ExcuteScalar(query));
			return re == 0;
		}
		public bool DeleteDaoTao(string madt)
		{
			string query = $"EXEC USP_DeleteDaoTaoByID @Ma_DaoTao = '{madt}';";
			int re = Convert.ToInt32(DataProvider.Instance.ExcuteScalar(query));
			return re == 0;
		}
		public List<DaotaoDTO> SearchTraining(string value)
		{
			List<DaotaoDTO> list = new List<DaotaoDTO>();

			string query = string.Format("SELECT DT.Ma_DaoTao, NV.HoTen, KH.TenKhoaHoc, DT.KetQua, DT.TrangThai FROM DaoTaoNhanVien DT INNER JOIN [Nhan vien] NV ON DT.Ma_NV = NV.Ma_NV INNER JOIN KhoaHoc KH ON DT.Ma_KhoaHoc = KH.Ma_KhoaHoc WHERE DT.Ma_DaoTao LIKE N'%{0}%' OR NV.HoTen LIKE N'%{1}%' OR KH.TenKhoaHoc LIKE N'%{2}%'", value, value, value);

			Console.WriteLine(query);

			DataTable data = DataProvider.Instance.ExecuteQuery(query);

			foreach (DataRow item in data.Rows)
			{
				DaotaoDTO Training = new DaotaoDTO(item);

				list.Add(Training);
			}
			return list;
		}
	}
}
