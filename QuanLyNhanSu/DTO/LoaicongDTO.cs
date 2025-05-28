using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu.DTO
{
	public class LoaicongDTO
	{
		public LoaicongDTO(string maLoaiCong, decimal heSo, string tenLoaiCong)
		{
			this.MaLoaiCong = maLoaiCong;
			this.HeSo = heSo;
			this.TenLoaiCong = tenLoaiCong;
		}
		public LoaicongDTO(DataRow row)
		{
			this.MaLoaiCong = row["MaLoaiCong"].ToString();
			this.TenLoaiCong = row["TenLoaiCong"].ToString();
			this.HeSo = Convert.ToDecimal(row["HeSo"]);
		}

		private string maLoaiCong;

		private decimal heSo;

		private string tenLoaiCong;


		public string TenLoaiCong { get => tenLoaiCong; set => tenLoaiCong=value; }
		public string MaLoaiCong { get => maLoaiCong; set => maLoaiCong=value; }
		public decimal HeSo { get => heSo; set => heSo=value; }
	}
}
