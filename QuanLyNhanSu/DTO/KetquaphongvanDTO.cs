using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu.DTO
{
	public class KetquaphongvanDTO
	{
		public KetquaphongvanDTO(string maHS, string maKQ, string tenUV, string danhGia, string ketLuan, DateTime ngayDanhGia)
		{
			this.MaKQ = maKQ;
			this.TenUV = tenUV;
			this.DanhGia = danhGia;
			this.KetLuan = ketLuan;
			this.NgayDanhGia = ngayDanhGia;
			this.MaHS = maHS;
		}

		public KetquaphongvanDTO(DataRow row)
		{
			this.MaKQ = row["Ma_KQ"].ToString();
			this.TenUV = row["TenUV"].ToString();
			this.DanhGia = row["DanhGia"].ToString();
			this.KetLuan = row["KetLuan"].ToString();
			this.NgayDanhGia = Convert.ToDateTime(row["NgayDanhGia"]);
			this.MaHS = row["Ma_HS"].ToString();
		}

		string maKQ;

		string tenUV;

		string danhGia;

		string ketLuan;

		DateTime ngayDanhGia;

		string maHS;

		public string MaKQ { get => maKQ; set => maKQ=value; }
		public string TenUV { get => tenUV; set => tenUV=value; }
		public string DanhGia { get => danhGia; set => danhGia=value; }
		public string KetLuan { get => ketLuan; set => ketLuan=value; }
		public DateTime NgayDanhGia { get => ngayDanhGia; set => ngayDanhGia=value; }
		public string MaHS { get => maHS; set => maHS=value; }
	}
}
