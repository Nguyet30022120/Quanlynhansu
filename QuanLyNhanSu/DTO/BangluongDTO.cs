using System;
using System.Data;

namespace QuanLyNhanSu.DTO
{
	public class BangluongDTO
	{
		public string MaNV { get; set; }
		public string TenNV { get; set; }
		public int Thang { get; set; }
		public int Nam { get; set; }
		public double SoGioLam { get; set; }
		public decimal LuongCoBan { get; set; }
		public double HeSoNgay { get; set; }
		public decimal PhucCap { get; set; }
		public decimal BaoHiem { get; set; }
		public decimal Thue { get; set; }
		public decimal Phat { get; set; }
		public decimal Thuong { get; set; }

		private decimal? _luongThucLinhFromDB;

		// Tính toán
		public decimal LuongCoBanTheoGio => LuongCoBan;
		public decimal LuongTheoGio => (decimal)SoGioLam * LuongCoBanTheoGio * (decimal)HeSoNgay;
		public decimal TongKhauTru => BaoHiem + Thue + Phat;
		// Công thức CHÍNH XÁC: Lương thực nhận = Σ(Lương mỗi giờ × Số giờ làm × Hệ số theo ngày) + Thưởng + Phụ cấp - Phạt - Bảo hiểm - Thuế
		// Hệ số được tính riêng cho từng ngày làm việc, nếu không có hệ số thì mặc định 1.0
		// Ưu tiên sử dụng giá trị từ database, nếu không có thì tính toán
		public decimal LuongThucLinh => _luongThucLinhFromDB ??
			((LuongCoBan * (decimal)SoGioLam * (decimal)HeSoNgay) + Thuong + PhucCap - Phat - BaoHiem - Thue);
		public string SoGioLamDisplay => SoGioLam.ToString("0.0");
		public string LuongCoBanDisplay => LuongCoBan.ToString("N0");
		public string HeSoNgayDisplay => HeSoNgay.ToString("0.00");
		public string PhucCapDisplay => PhucCap.ToString("N0");
		public string BaoHiemDisplay => BaoHiem.ToString("N0");
		public string ThueDisplay => Thue.ToString("N0");
		public string PhatDisplay => Phat.ToString("N0");
		public string ThuongDisplay => Thuong.ToString("N0");
		public string LuongTheoGioDisplay => LuongTheoGio.ToString("N0");
		public string TongKhauTruDisplay => TongKhauTru.ToString("N0");
		public string LuongThucLinhDisplay => LuongThucLinh.ToString("N0");

		public BangluongDTO()
		{
		}

		public BangluongDTO(string maNV, string tenNV, int thang, int nam, double soGioLam,
						   decimal luongCoBan, double heSoNgay, decimal phucCap, decimal baoHiem, decimal thue,
						   decimal phat, decimal thuong)
		{
			MaNV = maNV;
			TenNV = tenNV;
			Thang = thang;
			Nam = nam;
			SoGioLam = soGioLam;
			LuongCoBan = luongCoBan;
			HeSoNgay = heSoNgay;
			PhucCap = phucCap;
			BaoHiem = baoHiem;
			Thue = thue;
			Phat = phat;
			Thuong = thuong;
		}

		public BangluongDTO(DataRow row)
		{
			MaNV = row["Ma_NV"]?.ToString();
			TenNV = row["HoTen"]?.ToString();
			Thang = row["Thang"] != DBNull.Value ? Convert.ToInt32(row["Thang"]) : 0;
			Nam = row["Nam"] != DBNull.Value ? Convert.ToInt32(row["Nam"]) : 0;
			SoGioLam = row["SoGioLam"] != DBNull.Value ? Convert.ToDouble(row["SoGioLam"]) : 0.0;
			LuongCoBan = row["LuongCoBan"] != DBNull.Value ? Convert.ToDecimal(row["LuongCoBan"]) : 0;
			HeSoNgay = row["HeSoNgay"] != DBNull.Value ? Convert.ToDouble(row["HeSoNgay"]) : 1.0;
			PhucCap = row["PhucCap"] != DBNull.Value ? Convert.ToDecimal(row["PhucCap"]) : 0;
			BaoHiem = row["BaoHiem"] != DBNull.Value ? Convert.ToDecimal(row["BaoHiem"]) : 0;
			Thue = row["Thue"] != DBNull.Value ? Convert.ToDecimal(row["Thue"]) : 0;
			Phat = row["Phat"] != DBNull.Value ? Convert.ToDecimal(row["Phat"]) : 0;
			Thuong = row["Thuong"] != DBNull.Value ? Convert.ToDecimal(row["Thuong"]) : 0;

			if (row.Table.Columns.Contains("LuongThucNhan") && row["LuongThucNhan"] != DBNull.Value)
			{
				_luongThucLinhFromDB = Convert.ToDecimal(row["LuongThucNhan"]);
			}
		}
	}
}