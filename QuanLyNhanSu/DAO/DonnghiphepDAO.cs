using QuanLyNhanSu.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu.DAO
{
	public class DonnghiphepDAO
	{
		private static DonnghiphepDAO instance;
		public static DonnghiphepDAO Instance { get => instance == null ? instance = new DonnghiphepDAO() : instance; private set => instance = value; }
		private DonnghiphepDAO() { }
		public List<DonnghiphepDTO> GetDonNghiPhep(string manv)
		{
			List<DonnghiphepDTO> list = new List<DonnghiphepDTO>();
			string query = $"SELECT dp.MaDonNghiPhep, dp.Ma_NV AS MaNhanVien, nv1.HoTen AS TenNhanVien, dp.LoaiPhep, dp.TuNgay, dp.DenNgay, dp.LyDo, dp.TrangThai, nv2.HoTen + '-' + dp.MaNguoiDuyet AS NguoiDuyet, dp.SoNgay, dp.NgayTao FROM DonNghiPhep dp JOIN [Nhan vien] nv1 ON dp.Ma_NV = nv1.Ma_NV LEFT JOIN [Nhan vien] nv2 ON dp.MaNguoiDuyet = nv2.Ma_NV WHERE dp.Ma_NV = '{manv}'";
			DataTable data = DataProvider.Instance.ExecuteQuery(query);
			foreach (DataRow item in data.Rows)
			{
				DonnghiphepDTO donnghiphep = new DonnghiphepDTO(item);
				list.Add(donnghiphep);
			}
			return list;
		}
		public bool InsertDonNghiPhep(string tennv, string loaiphep, string trangthai, string lydo, DateTime ngaybd, DateTime ngaykt, string nguoiduyet)
		{
			string query = $"EXEC USP_InsertDonNghiPhep @TenNhanVien = N'{tennv}', @LoaiPhep = N'{loaiphep}', @TuNgay = '{ngaybd}', @DenNgay = '{ngaykt}', @LyDo = N'{lydo}', @TrangThai = N'{trangthai}', @NguoiDuyet = N'{nguoiduyet}';";
			int result = DataProvider.Instance.ExcuteNonQuery(query, new object[] { tennv, loaiphep, ngaybd, ngaykt, lydo, trangthai, nguoiduyet });
			return result != 0;
		}
		public bool UpdateDonNghiPhep(int madonnghiphep, string tennv, string loaiphep, string trangthai, string lydo, DateTime ngaybd, DateTime ngaykt, string nguoiduyet)
		{
			string query = $"EXEC USP_UpdateDonNghiPhep @MaDon = {madonnghiphep}, @TenNhanVien = N'{tennv}', @LoaiPhep = N'{loaiphep}', @TuNgay = '{ngaybd}', @DenNgay = '{ngaykt}', @LyDo = N'{lydo}', @TrangThai = N'{trangthai}', @NguoiDuyet = N'{nguoiduyet}';";
			int result = DataProvider.Instance.ExcuteNonQuery(query, new object[] { madonnghiphep, tennv, loaiphep, ngaybd, ngaykt, lydo, trangthai, nguoiduyet });
			return result != 0;
		}
		public bool DeleteDonNghiPhep(int madonnghiphep)
		{
			string query = $"EXEC USP_DeleteDonNghiPhep @MaDon = {madonnghiphep};";
			int result = DataProvider.Instance.ExcuteNonQuery(query, new object[] { madonnghiphep });
			return result != 0;
		}
		public List<DonnghiphepDTO> GetDonNghiPhepCanDuyet()
		{
			List<DonnghiphepDTO> list = new List<DonnghiphepDTO>();
			string query = $"SELECT dp.MaDonNghiPhep, dp.Ma_NV AS MaNhanVien, nv1.HoTen AS TenNhanVien, dp.LoaiPhep, dp.TuNgay, dp.DenNgay, dp.LyDo, dp.TrangThai, nv2.HoTen + '-' + dp.MaNguoiDuyet AS NguoiDuyet, dp.SoNgay, dp.NgayTao FROM DonNghiPhep dp JOIN [Nhan vien] nv1 ON dp.Ma_NV = nv1.Ma_NV LEFT JOIN [Nhan vien] nv2 ON dp.MaNguoiDuyet = nv2.Ma_NV WHERE dp.TrangThai = N'Chờ duyệt'";
			DataTable data = DataProvider.Instance.ExecuteQuery(query);
			foreach (DataRow item in data.Rows)
			{
				DonnghiphepDTO donnghiphep = new DonnghiphepDTO(item);
				list.Add(donnghiphep);
			}
			return list;
		}
		public List<DonnghiphepDTO> SearchDonnghiphep(string value)
		{
			List<DonnghiphepDTO> list = new List<DonnghiphepDTO>();
			string query = $"SELECT dp.MaDonNghiPhep, dp.Ma_NV AS MaNhanVien, nv1.HoTen AS TenNhanVien, dp.LoaiPhep, dp.TuNgay, dp.DenNgay, dp.LyDo, dp.TrangThai, nv2.HoTen + '-' + dp.MaNguoiDuyet AS NguoiDuyet, dp.SoNgay, dp.NgayTao FROM DonNghiPhep dp JOIN [Nhan vien] nv1 ON dp.Ma_NV = nv1.Ma_NV LEFT JOIN [Nhan vien] nv2 ON dp.MaNguoiDuyet = nv2.Ma_NV WHERE dp.TrangThai = N'Chờ duyệt' and dp.Ma_NV LIKE '{value}' or nv1.HoTen LIKE N'{value}' or dp.MaDonNghiPhep LIKE '{value}'";
			DataTable data = DataProvider.Instance.ExecuteQuery(query);
			foreach (DataRow item in data.Rows)
			{
				DonnghiphepDTO donnghiphep = new DonnghiphepDTO(item);
				list.Add(donnghiphep);
			}
			return list;
		}

		public bool DuyetDonNghiPhep(int madonnghiphep)
		{
			string query = $"EXEC USP_DuyetDonNghiPhep @MaDonNghiPhep = {madonnghiphep}";
			int result = DataProvider.Instance.ExcuteNonQuery(query, new object[] { madonnghiphep});
			return result != 0;
		}
		public bool TuChoiDonNghiPhep(int madonnghiphep)
		{
			string query = $"EXEC USP_TuChoiDonNghiPhep @MaDonNghiPhep = {madonnghiphep}";
			int result = DataProvider.Instance.ExcuteNonQuery(query, new object[] { madonnghiphep });
			return result != 0;
		}

	}
}
