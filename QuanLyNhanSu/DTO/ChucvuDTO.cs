using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu.DTO
{
	public class ChucvuDTO
	{
		public ChucvuDTO(string maChucVu, string tenChucVu, string moTaChucVu)
		{
			this.MaChucVu = maChucVu;
			this.TenChucVu = tenChucVu;
			this.MoTaChucVu = moTaChucVu;
		}

		public ChucvuDTO(DataRow row)
		{
			this.maChucVu = row["MaChucVu"].ToString();
			this.TenChucVu = row["TenChucVu"].ToString();
			this.MoTaChucVu = row["MoTaChucVu"].ToString();
		}

		private string maChucVu;


		private string tenChucVu;

		private string moTaChucVu;


		public string TenChucVu { get => tenChucVu; set => tenChucVu=value; }
		public string MoTaChucVu { get => moTaChucVu; set => moTaChucVu=value; }
		public string MaChucVu { get => maChucVu; set => maChucVu=value; }
	}
}
