using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu.DAO
{
	public class LoaicaDTO
	{
		public LoaicaDTO(string maLoaiCa, decimal heSo, string tenLoaiCa)
		{
			this.MaLoaiCa = maLoaiCa;
			this.HeSo = heSo;
			this.TenLoaiCa = tenLoaiCa;
		}
		public LoaicaDTO(DataRow row)
		{
			this.MaLoaiCa = row["MaLoaiCa"].ToString();
			this.TenLoaiCa = row["TenLoaiCa"].ToString();
			this.HeSo = Convert.ToDecimal(row["HeSo"]);
		}

		private string maLoaiCa;

		private decimal heSo;

		private string tenLoaiCa;


		public string TenLoaiCa { get => tenLoaiCa; set => tenLoaiCa=value; }
		public string MaLoaiCa { get => maLoaiCa; set => maLoaiCa=value; }
		public decimal HeSo { get => heSo; set => heSo=value; }
	}
}
