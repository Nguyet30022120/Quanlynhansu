using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu.DTO
{
	public class DaotaoDTO
	{

		public DaotaoDTO(string maDT, string tenNV, string tenKH, string trangThai, string ketQua)
		{
			this.MaDT = maDT;
			this.TenNV = tenNV;
			this.TenKH = tenKH;
			this.TrangThai = trangThai;
			this.KetQua = ketQua;
		}

		public DaotaoDTO(DataRow row)
		{
			this.MaDT = row["Ma_DaoTao"].ToString();
			this.TenNV = row["HoTen"].ToString();
			this.TenKH = row["TenKhoaHoc"].ToString();
			this.TrangThai = row["TrangThai"].ToString();
			this.KetQua = row["KetQua"].ToString();
		}

		private string maDT;

		private string tenNV;

		private string tenKH;

		private string trangThai;

		private string ketQua;

		public string MaDT { get => maDT; set => maDT=value; }
		public string TenNV { get => tenNV; set => tenNV=value; }
		public string TenKH { get => tenKH; set => tenKH=value; }
		public string TrangThai { get => trangThai; set => trangThai=value; }
		public string KetQua { get => ketQua; set => ketQua=value; }
	}
}
