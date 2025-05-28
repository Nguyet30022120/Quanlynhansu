using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu.DTO
{
	public class InsuranceDTO
	{
		public InsuranceDTO(string maBH, string tenNV, string loaiBH, string moTa, DateTime ngayBD, DateTime ngayKT)
		{
			this.MaBH = maBH;
			this.TenNV = tenNV;
			this.LoaiBH = loaiBH;
			this.MoTa = moTa;
			this.NgayBD = ngayBD;
			this.NgayKT = ngayKT;
		}

		public InsuranceDTO(DataRow row)
		{
			this.MaBH = row["Ma_BH"].ToString();
			this.TenNV = row["HoTen"].ToString();
			this.LoaiBH = row["LoaiBaoHiem"].ToString();
			this.MoTa = row["MoTa"].ToString();
			this.NgayBD = Convert.ToDateTime(row["NgayBatDau"]);
			this.NgayKT = Convert.ToDateTime(row["NgayKetThuc"]);
		}

		string maBH;

		string tenNV;

		string loaiBH;

		string moTa;

		DateTime ngayBD;

		DateTime ngayKT;

		public string MaBH { get => maBH; set => maBH=value; }
		public string TenNV { get => tenNV; set => tenNV=value; }
		public string LoaiBH { get => loaiBH; set => loaiBH=value; }
		public string MoTa { get => moTa; set => moTa=value; }
		public DateTime NgayBD { get => ngayBD; set => ngayBD=value; }
		public DateTime NgayKT { get => ngayKT; set => ngayKT=value; }
	}
}
