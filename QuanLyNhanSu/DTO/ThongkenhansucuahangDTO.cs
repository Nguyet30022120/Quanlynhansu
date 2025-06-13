using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu.DTO
{
	public class ThongkenhansucuahangDTO
	{
		public ThongkenhansucuahangDTO(string cuaHang, int soLuong)
		{
			this.CuaHang = cuaHang;
			this.SoLuong = soLuong;
		}

		public ThongkenhansucuahangDTO(DataRow row)
		{
			this.CuaHang = row["CuaHang"].ToString();
			this.SoLuong = (int)row["SoLuong"];
		}

		private string cuaHang;

		private int soLuong;

		public string CuaHang { get => cuaHang; set => cuaHang=value; }
		public int SoLuong { get => soLuong; set => soLuong=value; }
	}
}