using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu.DTO
{

	public class NhanvienDTO
	{
		public NhanvienDTO(string maNV,string maChucVu, string maPB, string hoTen, string chucVu, string phongBan, string taiKhoan, string cCCD, string dienThoai, string tDHV, string diaChi, int gioiTinh, DateTime? ngaySinh, string trinhDo, string maTrinhDo, string email)
		{
			this.MaNV = maNV;
			this.HoTen = hoTen;
			this.ChucVu = chucVu;
			this.PhongBan = phongBan;
			this.TaiKhoan = taiKhoan;
			this.CCCD = cCCD;
			this.DienThoai = dienThoai;
			this.DiaChi = diaChi;
			this.GioiTinh = gioiTinh;
			this.NgaySinh = ngaySinh;
			this.MaPB = maPB;
			this.MaChucVu = maChucVu;
			//this.TrinhDo = trinhDo;
			//this.MaTrinhDo = maTrinhDo;
			this.Email = email;
		}

		public NhanvienDTO(DataRow row)
		{
			this.MaNV = row["Ma_NV"].ToString();
			this.HoTen = row["HoTen"].ToString();
			this.ChucVu = row["ChucVu"].ToString();
			this.PhongBan = row["PhongBan"].ToString();
			this.TaiKhoan = row["TaiKhoan"].ToString();
			this.CCCD = row["CCCD"].ToString();
			this.DienThoai = row["DienThoai"].ToString();
			this.DiaChi = row["DiaChi"].ToString();
			this.GioiTinh = Convert.ToInt32(row["GioiTinh"]);
			this.NgaySinh = row["NgaySinh"] != DBNull.Value ? (DateTime?)row["NgaySinh"] : null;
			this.MaPB = row["MaPB"].ToString();
			this.MaChucVu = row["MaChucVu"].ToString();
			//this.TrinhDo = row["TrinhDo"].ToString();
			//this.MaTrinhDo = row["MaTrinhDo"].ToString();
			this.Email = row["Email"].ToString();
		}
		private string maChucVu;

		private string maNV;

		private string hoTen;

		private string chucVu;

		private string phongBan;

		private string taiKhoan;

		private string cCCD;

		private string dienThoai;

		private string maPB;

		private string diaChi;

		private int gioiTinh;

		private DateTime? ngaySinh;

		//private string trinhDo;

		//private string maTrinhDo;

		private string email;

		public string MaNV { get => maNV; set => maNV=value; }
		public string HoTen { get => hoTen; set => hoTen=value; }
		public string ChucVu { get => chucVu; set => chucVu=value; }
		public string PhongBan { get => phongBan; set => phongBan=value; }
		public string TaiKhoan { get => taiKhoan; set => taiKhoan=value; }
		public string CCCD { get => cCCD; set => cCCD=value; }
		public string DienThoai { get => dienThoai; set => dienThoai=value; }
		public string DiaChi { get => diaChi; set => diaChi=value; }
		public int GioiTinh { get => gioiTinh; set => gioiTinh=value; }
		public DateTime? NgaySinh { get => ngaySinh; set => ngaySinh=value; }
		public string MaPB { get => maPB; set => maPB=value; }
		public string MaChucVu { get => maChucVu; set => maChucVu=value; }
		//public string TrinhDo { get => trinhDo; set => trinhDo=value; }
		//public string MaTrinhDo { get => maTrinhDo; set => maTrinhDo=value; }
		public string Email { get => email; set => email=value; }
	}
}
