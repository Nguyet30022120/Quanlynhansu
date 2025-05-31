using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu.DTO
{
	public class BaohiemDTO
	{
		public BaohiemDTO(string maBH, string tenNV, string loaiBH, string moTa, DateTime ngayBD, DateTime ngayKT, decimal tienBH)
		{
			this.MaBH = maBH;
			this.TenNV = tenNV;
			this.LoaiBH = loaiBH;
			this.MoTa = moTa;
			this.NgayBD = ngayBD;
			this.NgayKT = ngayKT;
			this.tienBH=tienBH;

		}

		public BaohiemDTO(DataRow row)
		{
			this.MaBH = row["Ma_BH"].ToString();
			this.TenNV = row["HoTen"].ToString();
			this.LoaiBH = row["LoaiBaoHiem"].ToString();
			this.MoTa = row["MoTa"].ToString();
			this.NgayBD = Convert.ToDateTime(row["NgayBatDau"]);
			this.NgayKT = Convert.ToDateTime(row["NgayKetThuc"]);
			this.tienBH = Convert.ToDecimal(row["SoTienDong"]);
		}

		string maBH;

		string tenNV;

		string loaiBH;

		string moTa;

		DateTime ngayBD;

		DateTime ngayKT;

		decimal tienBH;

		public string MaBH { get => maBH; set => maBH=value; }
		public string TenNV { get => tenNV; set => tenNV=value; }
		public string LoaiBH { get => loaiBH; set => loaiBH=value; }
		public string MoTa { get => moTa; set => moTa=value; }
		public DateTime NgayBD { get => ngayBD; set => ngayBD=value; }
		public DateTime NgayKT { get => ngayKT; set => ngayKT=value; }
		public decimal TienBH { get => tienBH; set => tienBH=value; }
	}
}
