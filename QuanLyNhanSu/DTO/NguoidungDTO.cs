using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu.DTO
{
	public class NguoidungDTO
	{
		public NguoidungDTO (string tenNV, string maNV, string chucVu, string cuaHang, string maTK, string taiKhoan, string vaiTro, string moTaQUyenHan, DateTime ngaySinh, int gioiTinh, string diaChi,
			string cCCD, string soDienThoai)
		{
			this.tenNV = tenNV;
			this.MaNV = maNV;
			this.ChucVu = chucVu;
			this.CuaHang = cuaHang;
			this.MaTK = maTK;
			this.TaiKhoan = taiKhoan;
			this.VaiTro = vaiTro;
			this.MoTaQuyenHan = moTaQUyenHan;
			this.NgaySinh = ngaySinh;
			this.DiaChi = diaChi;
			this.CCCD = cCCD;
			this.SoDienThoai = soDienThoai;
			this.GioiTinh = gioiTinh;
		}

		public NguoidungDTO (DataRow row)
		{
			this.TenNV = row["HoTen"].ToString();
			this.MaNV = row["Ma_NV"].ToString();
			this.ChucVu = row["TenChucVu"].ToString();
			this.CuaHang = row["TenCuaHang"].ToString();
			this.MaTK = row["Ma_TK"].ToString();
			this.TaiKhoan = row["TaiKhoan"].ToString();
			this.VaiTro = row["VaiTro"].ToString();
			this.MoTaQuyenHan = row["MoTaQuyenHan"].ToString();
			this.NgaySinh = row["NgaySinh"] != DBNull.Value ? (DateTime?)row["NgaySinh"] : null;
			this.DiaChi = row["DiaChi"].ToString();
			this.CCCD = row["CCCD"].ToString();
			this.SoDienThoai = row["DienThoai"].ToString();
			this.GioiTinh = Convert.ToInt32(row["GioiTinh"]);
		}

		private string tenNV;

		private string maNV;

		private string chucVu;

		private string cuaHang;

		private string maTK;

		private string taiKhoan;

		private string vaiTro;

		private string moTaQuyenHan;

		private DateTime? ngaySinh;

		private int gioiTinh;

		private string diaChi;

		private string cCCD;

		private string soDienThoai;

		public string TenNV { get => tenNV; set => tenNV=value; }
		public string MaNV { get => maNV; set => maNV=value; }
		public string ChucVu { get => chucVu; set => chucVu=value; }
		public string CuaHang { get => cuaHang; set => cuaHang=value; }
		public string MaTK { get => maTK; set => maTK=value; }
		public string TaiKhoan { get => taiKhoan; set => taiKhoan=value; }
		public string VaiTro { get => vaiTro; set => vaiTro=value; }
		public string MoTaQuyenHan { get => moTaQuyenHan; set => moTaQuyenHan=value; }
		public DateTime? NgaySinh { get => ngaySinh; set => ngaySinh=value; }
		public int GioiTinh { get => gioiTinh; set => gioiTinh=value; }
		public string DiaChi { get => diaChi; set => diaChi=value; }
		public string SoDienThoai { get => soDienThoai; set => soDienThoai=value; }
		public string CCCD { get => cCCD; set => cCCD=value; }
	}
}
