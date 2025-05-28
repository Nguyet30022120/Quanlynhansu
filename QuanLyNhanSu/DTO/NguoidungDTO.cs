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
		public NguoidungDTO (string nameNV, string maNV, string chucVu, string phongBan, string maTK, string taiKhoan, string vaiTro, string moTaQUyenHan, DateTime ngaySinh, int gioiTinh, string diaChi, 
			string cCCD, string soDienThoai)
		{
			this.NameNV = nameNV;
			this.MaNV = maNV;
			this.ChucVu = chucVu;
			this.PhongBan = phongBan;
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
			this.NameNV = row["HoTen"].ToString();
			this.MaNV = row["Ma_NV"].ToString();
			this.ChucVu = row["Ma_ChucVu"].ToString();
			this.PhongBan = row["TenPhong"].ToString();
			this.MaTK = row["Ma_TK"].ToString();
			this.TaiKhoan = row["TaiKhoan"].ToString();
			this.VaiTro = row["VaiTro"].ToString();
			this.MoTaQuyenHan = row["MoTaQuyenHan"].ToString();
			this.NgaySinh = row["NgaySinh"] != DBNull.Value ? (DateTime?)row["NgaySinh"] : null;
			this.DiaChi = row["DiaChi"].ToString();
			this.CCCD = row["CMND"].ToString();
			this.SoDienThoai = row["DienThoai"].ToString();
			this.GioiTinh = Convert.ToInt32(row["GioiTinh"]);
		}

		private string nameNV;

		private string maNV;

		private string chucVu;

		private string phongBan;

		private string maTK;

		private string taiKhoan;

		private string vaiTro;

		private string moTaQuyenHan;

		private DateTime? ngaySinh;

		private int gioiTinh;

		private string diaChi;

		private string cCCD;

		private string soDienThoai;

		public string NameNV { get => nameNV; set => nameNV=value; }
		public string MaNV { get => maNV; set => maNV=value; }
		public string ChucVu { get => chucVu; set => chucVu=value; }
		public string PhongBan { get => phongBan; set => phongBan=value; }
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
