using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu.DTO
{
	public class ThongkenhansuchucvuDTO
	{
		private string chucVu;
		private int soLuong;
		public ThongkenhansuchucvuDTO(string chucVu, int soLuong)
		{
			this.ChucVu = chucVu;
			this.SoLuong = soLuong;
		}
		public ThongkenhansuchucvuDTO(DataRow row)
		{
			this.ChucVu = row["ChucVu"].ToString();
			this.SoLuong = (int)row["SoLuong"];
		}
		public string ChucVu { get => chucVu; set => chucVu=value; }
		public int SoLuong
		{
			get => soLuong; set => soLuong=value;
		}
	}
}
