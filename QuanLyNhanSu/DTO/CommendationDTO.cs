using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu.DTO
{
	public class CommendationDTO
	{
		private string maKTKL;

		private string maNV;

		private string noiDung;

		private string hinhThuc;

		private DateTime thoiGian;

		private string tenNV;

		public CommendationDTO(string maKTKL, string maNV, string noiDung, string hinhThuc, DateTime thoiGian, string tenNV)
		{
			this.maKTKL = maKTKL;
			//this.maNV = maNV;
			this.noiDung = noiDung;
			this.hinhThuc = hinhThuc;
			this.thoiGian = thoiGian;
			this.TenNV = tenNV;
		}
		public CommendationDTO(DataRow row)
		{
			this.maKTKL = row["MaKTKL"].ToString();
			//this.maNV = row["MaNV"].ToString();
			this.noiDung = row["NoiDung"].ToString();
			this.hinhThuc = row["HinhThuc"].ToString();
			this.thoiGian = (DateTime)row["ThoiGian"];
			this.TenNV = row["TenNhanVien"].ToString();
		}

		public string MaKTKL { get => maKTKL; set => maKTKL=value; }
		public string MaNV { get => maNV; set => maNV=value; }
		public string NoiDung { get => noiDung; set => noiDung=value; }
		public string HinhThuc { get => hinhThuc; set => hinhThuc=value; }
		public DateTime ThoiGian { get => thoiGian; set => thoiGian=value; }
		public string TenNV { get => tenNV; set => tenNV=value; }
	}
}
