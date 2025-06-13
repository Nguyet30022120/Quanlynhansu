using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu.DTO
{
	public class CuahangDTO
	{
		private string maCH;

		private string tenCH;

		private string diaChi;


		public CuahangDTO(string maCH, string tenCH, string diaChi)
		{
			this.MaCH = maCH;
			this.TenCH = tenCH;
			this.DiaChi = diaChi;
		}

		public CuahangDTO(DataRow row)
		{
			this.MaCH = row["Ma_CH"].ToString();
			this.TenCH = row["TenCuaHang"].ToString();
			this.DiaChi = row["DiaChi"].ToString();
		}

		public string MaCH { get => maCH; set => maCH=value; }
		public string TenCH { get => tenCH; set => tenCH=value; }
		public string DiaChi { get => diaChi; set => diaChi=value; }
	}
}
