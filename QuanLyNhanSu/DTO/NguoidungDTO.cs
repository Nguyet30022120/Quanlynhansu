using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu.DTO
{
	public class NguoidungDTO
	{
		public NguoidungDTO(string tenNV, string maNV, string chucVu, string cuaHang, string maTK, string taiKhoan, string vaiTro, string moTaQUyenHan)
		{
			this.TenNV = tenNV;
			this.MaNV = maNV;
			this.ChucVu = chucVu;
			this.CuaHang = cuaHang;
			this.MaTK = maTK;
			this.TaiKhoan = taiKhoan;
			this.VaiTro = vaiTro;
			this.MoTaQuyenHan = moTaQUyenHan;
		}

		public NguoidungDTO(DataRow row)
		{
			this.TenNV = row["HoTen"].ToString();
			this.MaNV = row["Ma_NV"].ToString();
			this.ChucVu = row["TenChucVu"].ToString();
			this.CuaHang = row["TenCuaHang"].ToString();
			this.MaTK = row["Ma_TK"].ToString();
			this.TaiKhoan = row["TaiKhoan"].ToString();
			this.VaiTro = row["VaiTro"].ToString();
			this.MoTaQuyenHan = row["MoTaQuyenHan"].ToString();
		}

		private string tenNV;

		private string maNV;

		private string chucVu;

		private string cuaHang;

		private string maTK;

		private string taiKhoan;

		private string vaiTro;

		private string moTaQuyenHan;

		public string TenNV { get => tenNV; set => tenNV=value; }
		public string MaNV { get => maNV; set => maNV=value; }
		public string ChucVu { get => chucVu; set => chucVu=value; }
		public string CuaHang { get => cuaHang; set => cuaHang=value; }
		public string MaTK { get => maTK; set => maTK=value; }
		public string TaiKhoan { get => taiKhoan; set => taiKhoan=value; }
		public string VaiTro { get => vaiTro; set => vaiTro=value; }
		public string MoTaQuyenHan { get => moTaQuyenHan; set => moTaQuyenHan=value; }
	}
}
