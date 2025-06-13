using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu.DTO
{
	public class HosoungvienDTO
	{
		public HosoungvienDTO(string maHS, string hoTen, DateTime ngaySinh, string gioiTinh, string dienThoai, string chiTietCV, string nguonUV, string chucVu, string email, string trangThai)
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
			this.TrangThai = trangThai;
		}

		public HosoungvienDTO(DataRow row)
		{
			this.MaHS = row["Ma_HS"].ToString();
			this.HoTen = row["HoTen"].ToString();
			this.NgaySinh = Convert.ToDateTime(row["NgaySinh"]);
			this.GioiTinh = row["GioiTinh"] != DBNull.Value ? row["GioiTinh"].ToString() : "Không xác định";
			this.DienThoai = row["SoDienThoai"].ToString();
			this.ChiTietCV = row["ChiTietCV"].ToString();
			this.NguonUV = row["NguonUngVien"].ToString();
			this.ChucVu = row["ChucVu"].ToString();
			this.Email = row["Email"].ToString();
			this.TrangThai = row.Table.Columns.Contains("TrangThai") ? row["TrangThai"].ToString() : string.Empty;
		}


		private string maHS;

		private string hoTen;

		private DateTime ngaySinh;

		private string gioiTinh;

		private string dienThoai;

		private string chiTietCV;

		private string nguonUV;

		private string chucVu;

		private string email;

		private string trangThai;

		public string MaHS { get => maHS; set => maHS=value; }
		public string HoTen { get => hoTen; set => hoTen=value; }
		public DateTime NgaySinh { get => ngaySinh; set => ngaySinh=value; }
		public string DienThoai { get => dienThoai; set => dienThoai=value; }
		public string ChiTietCV { get => chiTietCV; set => chiTietCV=value; }
		public string NguonUV { get => nguonUV; set => nguonUV=value; }
		public string ChucVu { get => chucVu; set => chucVu=value; }
		public string Email { get => email; set => email=value; }

		public string TrangThai { get => trangThai; set => trangThai=value; }
		public string GioiTinh { get => gioiTinh; set => gioiTinh=value; }
	}
}
