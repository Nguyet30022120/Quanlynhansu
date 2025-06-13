using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu.DTO
{
	public class NguonungvienDTO
	{
		public NguonungvienDTO(string tenNguon, string soLuongHoSo)
		{
			this.TenNguon = tenNguon;
			this.soLuongHoSo=soLuongHoSo;
		}

		public NguonungvienDTO(DataRow row)
		{
			this.TenNguon = row["TenNguon"].ToString();
			this.SoLuongHoSo = row["SoLuongHoSo"].ToString();
		}


		private string tenNguon;

		private string soLuongHoSo;
		public string TenNguon { get => tenNguon; set => tenNguon=value; }
		public string SoLuongHoSo { get => soLuongHoSo; set => soLuongHoSo=value; }
	}
}
