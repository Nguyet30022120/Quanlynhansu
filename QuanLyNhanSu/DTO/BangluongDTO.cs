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
        
        // Tính toán
        public decimal LuongCoBanTheoGio => LuongCoBan ; 
        public decimal LuongTheoGio => (decimal)SoGioLam * LuongCoBanTheoGio * (decimal)HeSoNgay;
        public decimal TongKhauTru => BaoHiem + Thue + Phat;
		public decimal LuongThucLinh => (LuongCoBan * (decimal)HeSoNgay) + PhucCap + Thuong - (BaoHiem + Thue + Phat);
		// Display properties
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
            MaNV = row["Ma_NV"].ToString();
            TenNV = row["HoTen"].ToString();
            Thang = Convert.ToInt32(row["Thang"]);
            Nam = Convert.ToInt32(row["Nam"]);
            SoGioLam = Convert.ToDouble(row["SoGioLam"]);
            LuongCoBan = Convert.ToDecimal(row["LuongCoBan"]);
            HeSoNgay = Convert.ToDouble(row["HeSoNgay"]);
            PhucCap = row["PhucCap"] != DBNull.Value ? Convert.ToDecimal(row["PhucCap"]) : 0;
            BaoHiem = Convert.ToDecimal(row["BaoHiem"]);
            Thue = Convert.ToDecimal(row["Thue"]);
            Phat = Convert.ToDecimal(row["Phat"]);
            Thuong = Convert.ToDecimal(row["Thuong"]);
        }
    }
} 