using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu.DTO
{
	public class BangcongDTO
	{
		public BangcongDTO(string maNV, string tenNV, DateTime ngay, TimeSpan? gioCheckIn, TimeSpan? gioCheckOut, double soGioLam)
		{
			this.MaNV = maNV;
			this.TenNV = tenNV;
			this.Ngay = ngay;
			this.GioCheckIn = gioCheckIn;
			this.GioCheckOut = gioCheckOut;
			this.SoGioLam = soGioLam;
		}

		public BangcongDTO(DataRow row)
		{
			this.MaNV = row["Ma_NV"].ToString();
			this.TenNV = row["HoTen"].ToString();
			this.Ngay = (DateTime)row["Ngay"];
			
			// Handle nullable TimeSpan for CheckIn
			if (row["GioCheckIn"] != DBNull.Value && row["GioCheckIn"] != null)
				this.GioCheckIn = TimeSpan.Parse(row["GioCheckIn"].ToString());
			else
				this.GioCheckIn = null;

			// Handle nullable TimeSpan for CheckOut
			if (row["GioCheckOut"] != DBNull.Value && row["GioCheckOut"] != null)
				this.GioCheckOut = TimeSpan.Parse(row["GioCheckOut"].ToString());
			else
				this.GioCheckOut = null;

			// Calculate working hours
			if (row["SoGioLam"] != DBNull.Value && row["SoGioLam"] != null)
				this.SoGioLam = Convert.ToDouble(row["SoGioLam"]);
			else
				this.SoGioLam = 0;
		}

		private string maNV;
		private string tenNV;
		private DateTime ngay;
		private TimeSpan? gioCheckIn;
		private TimeSpan? gioCheckOut;
		private double soGioLam;

		public string MaNV { get => maNV; set => maNV = value; }
		public string TenNV { get => tenNV; set => tenNV = value; }
		public DateTime Ngay { get => ngay; set => ngay = value; }
		public TimeSpan? GioCheckIn { get => gioCheckIn; set => gioCheckIn = value; }
		public TimeSpan? GioCheckOut { get => gioCheckOut; set => gioCheckOut = value; }
		public double SoGioLam { get => soGioLam; set => soGioLam = value; }

		// Properties for display in DataGridView
		public string NgayDisplay => Ngay.ToString("dd/MM/yyyy");
		public string GioCheckInDisplay => GioCheckIn?.ToString(@"hh\:mm") ?? "--:--";
		public string GioCheckOutDisplay => GioCheckOut?.ToString(@"hh\:mm") ?? "--:--";
		public string SoGioLamDisplay => SoGioLam.ToString("0.0") + " giờ";
	}
} 