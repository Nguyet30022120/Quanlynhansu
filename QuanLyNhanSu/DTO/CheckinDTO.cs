using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu.DTO
{
	public class CheckinDTO
	{
		public CheckinDTO(string maCheckIn, string maNV, string tenNV, TimeSpan gioCheckIn, DateTime ngayCheckIn)
		{
			this.MaCheckIn = maCheckIn;
			this.MaNV = maNV;
			this.TenNV = tenNV;
			this.GioCheckIn = gioCheckIn;
			this.NgayCheckIn = ngayCheckIn;
		}
		public CheckinDTO(DataRow row)
		{
			this.MaCheckIn = row["MaCheckIn"].ToString();
			this.MaNV = row["Ma_NV"].ToString();
			this.TenNV = row["HoTen"].ToString();
			this.GioCheckIn = TimeSpan.Parse(row["GioCheckIn"].ToString());
			this.NgayCheckIn = (DateTime)row["NgayCheckIn"];
		}


		private string maCheckIn;

		private string maNV;

		private string tenNV;

		private TimeSpan gioCheckIn;

		private DateTime ngayCheckIn;

		public string MaCheckIn { get => maCheckIn; set => maCheckIn=value; }
		public string MaNV { get => maNV; set => maNV=value; }
		public string TenNV { get => tenNV; set => tenNV=value; }


		public DateTime NgayCheckIn { get => ngayCheckIn; set => ngayCheckIn=value; }
		public TimeSpan GioCheckIn { get => gioCheckIn; set => gioCheckIn=value; }
	}
}
