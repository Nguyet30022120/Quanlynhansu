using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu.DTO
{
	public class HopdongDTO
	{
		public HopdongDTO(string maHD, string maNV, DateTime? ngayDK, DateTime? ngayHH, string trangThai, string tenNV)
		{
			this.MaHD = maHD;
			this.MaNV = maNV;
			this.TenNV = tenNV;
			this.NgayDK = ngayDK;
			this.NgayHH = ngayHH;
			this.TrangThai = trangThai;
		}

		public HopdongDTO(DataRow row)
		{
			this.MaHD = row["Ma_HD"].ToString();
			this.MaNV = row["Ma_NV"].ToString();
			this.TenNV = row["TenNhanVien"].ToString();
			this.NgayDK = row["NgayDangKy"] != DBNull.Value ? (DateTime?)row["NgayDangKy"] : null;
			this.NgayHH = row["NgayHetHan"] != DBNull.Value ? (DateTime?)row["NgayHetHan"] : null;
			this.TrangThai = row["TrangThai"].ToString();
		}


		private string maHD;

		private string maNV;

		private string tenNV;

		private DateTime? ngayDK;

		private DateTime? ngayHH;

		private string trangThai;

		public string MaHD { get => maHD; set => maHD=value; }
		public string MaNV { get => maNV; set => maNV=value; }
		public DateTime? NgayDK { get => ngayDK; set => ngayDK=value; }
		public DateTime? NgayHH { get => ngayHH; set => ngayHH=value; }
		public string TrangThai { get => trangThai; set => trangThai=value; }
		public string TenNV { get => tenNV; set => tenNV=value; }
	}
}
