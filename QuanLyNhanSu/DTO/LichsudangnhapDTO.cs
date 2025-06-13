using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu.DTO
{
	public class LichsudangnhapDTO
	{
		public LichsudangnhapDTO(int id, string userName, DateTime thoiGianDangNhap, string diaChiIP)
		{
			this.id = id;
			this.userName = userName;
			this.thoiGianDangNhap = thoiGianDangNhap;
			this.diaChiIP = diaChiIP;

		}
		public LichsudangnhapDTO()
		{
			this.id = 0;
			this.userName = string.Empty;
			this.thoiGianDangNhap = DateTime.Now;
			this.diaChiIP = string.Empty;
		}

		private int id;

		private string userName;

		private DateTime thoiGianDangNhap;

		private string diaChiIP;

		public int Id { get => id; set => id=value; }
		public string UserName { get => userName; set => userName=value; }
		public DateTime ThoiGianDangNhap { get => thoiGianDangNhap; set => thoiGianDangNhap=value; }
		public string DiaChiIP { get => diaChiIP; set => diaChiIP=value; }
	}
}
