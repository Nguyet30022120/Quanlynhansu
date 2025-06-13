using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu.DTO
{
	public class DonnghiphepDTO
	{
		private string tenNV;

		private string maNV;

		private string loaiPhep;

		private string lyDo;

		private string trangThai;

		private string nguoiDuyet;

		private DateTime ngayBD;

		private DateTime ngayKT;

		private int soNgay;

		private DateTime ngayTao;

		private int maDonNghiPhep;

		public DonnghiphepDTO(int maDonNghiPhep, string tenNV, string maNV, string loaiPhep, string lyDo, string trangThai, string nguoiDuyet, DateTime ngayBD, DateTime ngayKT, int soNgay, DateTime ngayTao)
		{
			this.TenNV = tenNV;
			this.MaNV = maNV;
			this.LoaiPhep = loaiPhep;
			this.LyDo = lyDo;
			this.TrangThai = trangThai;
			this.NguoiDuyet = nguoiDuyet;
			this.NgayBD = ngayBD;
			this.NgayKT = ngayKT;
			this.soNgay=soNgay;
			this.ngayTao=ngayTao;
			this.MaDonNghiPhep = maDonNghiPhep;

		}
		public DonnghiphepDTO(DataRow row)
		{
			this.TenNV = row["TenNhanVien"].ToString();
			this.MaNV = row["MaNhanVien"].ToString();
			this.LoaiPhep = row["LoaiPhep"].ToString();
			this.LyDo = row["LyDo"].ToString();
			this.TrangThai = row["TrangThai"].ToString();
			this.NguoiDuyet = row["NguoiDuyet"].ToString();
			this.NgayBD = Convert.ToDateTime(row["TuNgay"]);
			this.NgayKT = Convert.ToDateTime(row["DenNgay"]);
			this.SoNgay = Convert.ToInt32(row["SoNgay"]);
			this.NgayTao = Convert.ToDateTime(row["NgayTao"]);
			this.MaDonNghiPhep = Convert.ToInt32(row["Ma_DNP"]);
		}

		public string TenNV { get => tenNV; set => tenNV=value; }
		public string MaNV { get => maNV; set => maNV=value; }
		public string LoaiPhep { get => loaiPhep; set => loaiPhep=value; }
		public string LyDo { get => lyDo; set => lyDo=value; }
		public string TrangThai { get => trangThai; set => trangThai=value; }
		public string NguoiDuyet { get => nguoiDuyet; set => nguoiDuyet=value; }

		public DateTime NgayBD { get => ngayBD; set => ngayBD=value; }
		public DateTime NgayKT { get => ngayKT; set => ngayKT=value; }
		public int SoNgay { get => soNgay; set => soNgay=value; }
		public DateTime NgayTao { get => ngayTao; set => ngayTao=value; }
		public int MaDonNghiPhep { get => maDonNghiPhep; set => maDonNghiPhep=value; }
	}
}
