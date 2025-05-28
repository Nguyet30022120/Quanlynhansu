using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu.DTO
{
	public class ThongkenhansunamnuDTO
	{
		private string gioiTinh;

		private int soLuong;

		private decimal tyLe;

		public ThongkenhansunamnuDTO(string gioiTinh, int soLuong)
		{
			this.GioiTinh = gioiTinh;
			this.SoLuong = soLuong;
		}

		public ThongkenhansunamnuDTO(DataRow row)
		{
			this.GioiTinh = row["GioiTinh"].ToString();
			this.SoLuong = (int)row["SoLuong"];
		}

		public string GioiTinh { get => gioiTinh; set => gioiTinh=value; }
		public int SoLuong { get => soLuong; set => soLuong=value; }
	}
}
