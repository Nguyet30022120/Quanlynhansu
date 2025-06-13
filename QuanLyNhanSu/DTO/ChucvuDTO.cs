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
		public ChucvuDTO(int maChucVu, string tenChucVu, string moTaChucVu)
		{
			this.MaChucVu = maChucVu;
			this.TenChucVu = tenChucVu;
			this.MoTaChucVu = moTaChucVu;
		}

		public ChucvuDTO(DataRow row)
		{
			this.MaChucVu = Convert.ToInt32(row["MaChucVu"]);
			this.TenChucVu = row["TenChucVu"].ToString();
			this.MoTaChucVu = row["MoTaChucVu"].ToString();
		}

		int maChucVu;

		private string tenChucVu;

		private string moTaChucVu;


		public string TenChucVu { get => tenChucVu; set => tenChucVu=value; }
		public string MoTaChucVu { get => moTaChucVu; set => moTaChucVu=value; }
		public int MaChucVu { get => maChucVu; set => maChucVu=value; }
	}
}
