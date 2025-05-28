using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu.DTO
{
	public class ProfileDTO
	{
		public ProfileDTO(string maHS, string hoTen, DateTime ngaySinh, int gioiTinh, string dienThoai, string chiTietCV, string nguonUV, string chucVu, string email)
		{
			this.MaHS = maHS;
			this.HoTen = hoTen;
			this.NgaySinh = ngaySinh;
			this.GioiTinh = gioiTinh;
			this.DienThoai = dienThoai;
			this.ChiTietCV = chiTietCV;
			this.NguonUV = nguonUV;
			this.ChucVu = chucVu;
			this.Email = email;
		}

		public ProfileDTO(DataRow row)
		{
			this.MaHS = row["Ma_HS"].ToString();
			this.HoTen = row["HoTen"].ToString();
			this.NgaySinh = Convert.ToDateTime(row["NgaySinh"]);
			this.GioiTinh = Convert.ToInt32(row["GioiTinh"]);
			this.DienThoai = row["SoDienThoai"].ToString();
			this.ChiTietCV = row["ChiTietCV"].ToString();
			this.NguonUV = row["NguonUngVien"].ToString();
			this.ChucVu = row["ChucVu"].ToString();
			this.Email = row["Email"].ToString();
		}


		private string maHS;

		private string hoTen;

		private DateTime ngaySinh;

		private int gioiTinh;

		private string dienThoai;

		private string chiTietCV;

		private string nguonUV;

		private string chucVu;

		private string email;

		public string MaHS { get => maHS; set => maHS=value; }
		public string HoTen { get => hoTen; set => hoTen=value; }
		public DateTime NgaySinh { get => ngaySinh; set => ngaySinh=value; }
		public string DienThoai { get => dienThoai; set => dienThoai=value; }
		public string ChiTietCV { get => chiTietCV; set => chiTietCV=value; }
		public string NguonUV { get => nguonUV; set => nguonUV=value; }
		public string ChucVu { get => chucVu; set => chucVu=value; }
		public string Email { get => email; set => email=value; }
		public int GioiTinh { get => gioiTinh; set => gioiTinh=value; }
	}
}
