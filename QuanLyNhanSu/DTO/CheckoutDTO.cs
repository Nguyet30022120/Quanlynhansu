using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu.DTO
{
	public class CheckoutDTO
	{
		public CheckoutDTO(string maCheckOut, string maNV, string tenNV, TimeSpan gioCheckOut, DateTime ngayCheckOut)
		{
			this.MaCheckOut = maCheckOut;
			this.MaNV = maNV;
			this.TenNV = tenNV;
			this.GioCheckOut = gioCheckOut;
			this.NgayCheckOut = ngayCheckOut;
		}
		public CheckoutDTO(DataRow row)
		{
			this.MaCheckOut = row["Ma_CheckOut"].ToString();
			this.MaNV = row["Ma_NV"].ToString();
			this.TenNV = row["HoTen"].ToString();
			this.GioCheckOut = TimeSpan.Parse(row["GioCheckOut"].ToString());
			this.NgayCheckOut = row["NgayCheckOut"] != DBNull.Value ? (DateTime)row["NgayCheckOut"] : DateTime.MinValue; 
		}


		private string maCheckOut;

		private string maNV;

		private string tenNV;

		private TimeSpan gioCheckOut;

		private DateTime ngayCheckOut;

		public string MaCheckOut { get => maCheckOut; set => maCheckOut=value; }
		public string MaNV { get => maNV; set => maNV=value; }
		public string TenNV { get => tenNV; set => tenNV=value; }
		

		public DateTime NgayCheckOut { get => ngayCheckOut; set => ngayCheckOut=value; }
		public TimeSpan GioCheckOut { get => gioCheckOut; set => gioCheckOut=value; }
	}
}

