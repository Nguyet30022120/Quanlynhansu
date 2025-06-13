using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu.DTO
{
	public class LuongcobanDTO
	{
		public LuongcobanDTO(string maLuong, decimal luongCoSo, string maNV, string tenNV)
		{
			this.MaLuong = maLuong;
			this.LuongCoSo = luongCoSo;
			this.TenNV = tenNV;
			this.MaNV = maNV;
		}

		public LuongcobanDTO(DataRow row)
		{
			this.LuongCoSo = Convert.ToDecimal(row["LuongCoSo"]);
			this.MaLuong = row["Ma_Luong"].ToString();
			this.TenNV = row["HoTen"].ToString();
			this.MaNV = row["Ma_NV"].ToString();
		}
		private string maLuong;

		private decimal luongCoSo;

		private string tenNV;

		private string maNV;

		public string MaLuong { get => maLuong; set => maLuong=value; }
		public decimal LuongCoSo { get => luongCoSo; set => luongCoSo=value; }
		public string TenNV { get => tenNV; set => tenNV=value; }
		public string MaNV { get => maNV; set => maNV=value; }
	}
}
