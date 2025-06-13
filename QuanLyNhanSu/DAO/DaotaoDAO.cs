using QuanLyNhanSu.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace QuanLyNhanSu.DAO
{
	public class DaotaoDAO
	{
		private static DaotaoDAO instance;

		public static DaotaoDAO Instance { get => instance==null ? instance = new DaotaoDAO() : instance; private set => instance=value; }

		private DaotaoDAO() { }

		public List<DaotaoDTO> GetListDaoTaoAll()
		{
			List<DaotaoDTO> list = new List<DaotaoDTO>();

			string query = $"SELECT DT.Ma_NV, DT.Ma_DT, NV.HoTen, KH.TenKhoaHoc, DT.KetQua, DT.TrangThai FROM DaoTaoNhanVien DT INNER JOIN [NhanVien] NV ON DT.Ma_NV = NV.Ma_NV INNER JOIN KhoaHoc KH ON DT.Ma_KH = KH.Ma_KH;\r\n";
			DataTable data = DataProvider.Instance.ExecuteQuery(query);

			foreach (DataRow item in data.Rows)
			{
				DaotaoDTO training = new DaotaoDTO(item);

				list.Add(training);
			}

			return list;
		}
		public List<DaotaoDTO> GetListDaoTao(string manv)
		{
			List<DaotaoDTO> list = new List<DaotaoDTO>();

			string query = $"SELECT DT.Ma_NV, DT.Ma_DT, NV.HoTen, KH.TenKhoaHoc, DT.KetQua, DT.TrangThai FROM DaoTaoNhanVien DT INNER JOIN [NhanVien] NV ON DT.Ma_NV = NV.Ma_NV INNER JOIN KhoaHoc KH ON DT.Ma_KH = KH.Ma_KH WHERE NV.Ma_NV ='{manv}';\r\n";
			DataTable data = DataProvider.Instance.ExecuteQuery(query);

			foreach (DataRow item in data.Rows)
			{
				DaotaoDTO training = new DaotaoDTO(item);

				list.Add(training);
			}

			return list;
		}

		public bool InsertDaoTao(string manv, string tenkh)
		{
			string query = $"EXEC USP_InsertDaoTaoNhanVien @Ma_NV = '{manv}', @TenKhoaHoc = N'{tenkh}';";
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
	}
}
