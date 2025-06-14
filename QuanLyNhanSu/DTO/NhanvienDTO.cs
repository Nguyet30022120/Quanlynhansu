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
		public NhanvienDTO(string maNV,/*string maChucVu, string maPB*/string hoTen, string chucVu, string cuaHang, string taiKhoan, string cCCD, string dienThoai, string tDHV, string diaChi, string gioiTinh, DateTime? ngaySinh, string trinhDo, string maTrinhDo, string email)
		{
			this.MaNV = maNV;
			this.HoTen = hoTen;
			this.ChucVu = chucVu;
			this.CuaHang = cuaHang;
			this.TaiKhoan = taiKhoan;
			this.CCCD = cCCD;
			this.DienThoai = dienThoai;
			this.DiaChi = diaChi;
			this.GioiTinh = gioiTinh;
			this.NgaySinh = ngaySinh;
			this.Email = email;
		}

		public NhanvienDTO(DataRow row)
		{
			this.MaNV = row["Ma_NV"].ToString();
			this.HoTen = row["HoTen"].ToString();
			this.ChucVu = row["ChucVu"].ToString();
			this.CuaHang = row["CuaHang"].ToString();
			this.TaiKhoan = row["TaiKhoan"].ToString();
			this.CCCD = row["CCCD"].ToString();
			this.DienThoai = row["DienThoai"].ToString();
			this.DiaChi = row["DiaChi"].ToString();
			this.GioiTinh = row["GioiTinh"] != DBNull.Value ? row["GioiTinh"].ToString() : "Không xác định"; 
			this.NgaySinh = row["NgaySinh"] != DBNull.Value ? (DateTime?)row["NgaySinh"] : null;
			this.Email = row["Email"].ToString();
		}


		private string maNV;

		private string hoTen;

		private string chucVu;

		private string cuaHang;

		private string taiKhoan;

		private string cCCD;

		private string dienThoai;

		private string diaChi;

		private string gioiTinh;

		private DateTime? ngaySinh;

		private string email;

		public string MaNV { get => maNV; set => maNV=value; }
		public string HoTen { get => hoTen; set => hoTen=value; }
		public string ChucVu { get => chucVu; set => chucVu=value; }
		public string CuaHang { get => cuaHang; set => cuaHang=value; }
		public string TaiKhoan { get => taiKhoan; set => taiKhoan=value; }
		public string CCCD { get => cCCD; set => cCCD=value; }
		public string DienThoai { get => dienThoai; set => dienThoai=value; }
		public string DiaChi { get => diaChi; set => diaChi=value; }
		public DateTime? NgaySinh { get => ngaySinh; set => ngaySinh=value; }
		public string Email { get => email; set => email=value; }
		public string GioiTinh { get => gioiTinh; set => gioiTinh=value; }
	}
}
