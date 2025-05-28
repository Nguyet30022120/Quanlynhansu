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
			//this.MaNguon = maNguon;
			this.TenNguon = tenNguon;
			this.soLuongHoSo=soLuongHoSo;
		}

		public NguonungvienDTO(DataRow row)
		{
			//this.MaNguon = row["Ma_Nguon"].ToString();
			this.TenNguon = row["TenNguon"].ToString();
			this.SoLuongHoSo = row["SoLuongHoSo"].ToString();
		}

		//private string maNguon;

		private string tenNguon;

		private string soLuongHoSo;
		//public string MaNguon { get => maNguon; set => maNguon=value; }
		public string TenNguon { get => tenNguon; set => tenNguon=value; }
		public string SoLuongHoSo { get => soLuongHoSo; set => soLuongHoSo=value; }
	}
}
