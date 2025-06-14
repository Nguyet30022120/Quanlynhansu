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
			this.MaNV = row["Ma_NV"]?.ToString() ?? "";
			this.TenNV = row["HoTen"]?.ToString() ?? "";
			
			if (row["Ngay"] != DBNull.Value && row["Ngay"] != null)
				this.Ngay = (DateTime)row["Ngay"];
			else
				this.Ngay = DateTime.Now.Date; // Mặc định là ngày hiện tại
			
			if (row["GioCheckIn"] != DBNull.Value && row["GioCheckIn"] != null)
			{
				var checkInValue = row["GioCheckIn"].ToString().Trim();
				if (TimeSpan.TryParse(checkInValue, out TimeSpan checkInTime))
					this.GioCheckIn = checkInTime;
				else
					this.GioCheckIn = null;
			}
			else
				this.GioCheckIn = null;

		
			if (row["GioCheckOut"] != DBNull.Value && row["GioCheckOut"] != null)
			{
				var checkOutValue = row["GioCheckOut"].ToString().Trim();
				if (TimeSpan.TryParse(checkOutValue, out TimeSpan checkOutTime))
					this.GioCheckOut = checkOutTime;
				else
					this.GioCheckOut = null;
			}
			else
				this.GioCheckOut = null;


			if (row["SoGioLam"] != DBNull.Value && row["SoGioLam"] != null)
			{
				if (double.TryParse(row["SoGioLam"].ToString(), out double gioLam))
					this.SoGioLam = Math.Max(0, gioLam); // Đảm bảo không âm
				else
					this.SoGioLam = 0;
			}
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

		public string NgayDisplay => Ngay.ToString("dd/MM/yyyy");
		public string GioCheckInDisplay => GioCheckIn?.ToString(@"hh\:mm") ?? "--:--";
		public string GioCheckOutDisplay => GioCheckOut?.ToString(@"hh\:mm") ?? "--:--";
		public string SoGioLamDisplay => SoGioLam.ToString("0.0") + " giờ";

	
	}
} 