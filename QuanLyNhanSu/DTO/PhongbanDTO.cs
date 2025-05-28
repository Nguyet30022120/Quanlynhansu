using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu.DTO
{
	public class PhongbanDTO
	{
		private string maPB;

		private string tenPB;

		private string diaChi;


		public PhongbanDTO(string maPB, string tenPB, string diaChi)
		{
			this.MaPB = maPB;
			this.TenPB = tenPB;
			this.DiaChi = diaChi;
		}

		public PhongbanDTO(DataRow row)
		{
			this.MaPB = row["Ma_PB"].ToString();
			this.TenPB = row["TenPhong"].ToString();
			this.DiaChi = row["DiaChi"].ToString();
		}

		public string MaPB { get => maPB; set => maPB=value; }
		public string TenPB { get => tenPB; set => tenPB=value; }
		public string DiaChi { get => diaChi; set => diaChi=value; }
	}
}
