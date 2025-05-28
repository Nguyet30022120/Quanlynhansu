using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu.DTO
{
	public class ThongkenghiphepDTO
	{
		public ThongkenghiphepDTO(string maNV, string tenNV, DateTime ngayBD, DateTime ngayKT, string lyDo, string trangThai)
		{
			this.maNV = maNV;
			this.tenNV = tenNV;
			this.ngayBD = ngayBD;
			this.ngayKT = ngayKT;
			this.lyDo = lyDo;
			this.trangThai = trangThai;
		}
		public ThongkenghiphepDTO(DataRow row)
		{
			this.maNV = row["Ma_NV"].ToString();
			this.tenNV = row["HoTen"].ToString();
			this.ngayBD = (DateTime)row["NgayBatDau"];
			this.ngayKT = (DateTime)row["NgayKetThuc"];
			this.lyDo = row["LyDo"].ToString();
			this.trangThai = row["TrangThai"].ToString();
		}

		private string maNV;

		private string tenNV;

		private DateTime ngayBD;

		private DateTime ngayKT;

		private string lyDo;

		private string trangThai;

		public string MaNV { get => maNV; set => maNV=value; }
		public string TenNV { get => tenNV; set => tenNV=value; }
		public DateTime NgayBD { get => ngayBD; set => ngayBD=value; }
		public DateTime NgayKT { get => ngayKT; set => ngayKT=value; }
		public string LyDo { get => lyDo; set => lyDo=value; }
		public string TrangThai { get => trangThai; set => trangThai=value; }
	}
}
