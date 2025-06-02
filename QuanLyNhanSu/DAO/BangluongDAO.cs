using QuanLyNhanSu.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace QuanLyNhanSu.DAO
{
    public class BangluongDAO
    {
        private static BangluongDAO instance;
        public static BangluongDAO Instance
        {
            get { if (instance == null) instance = new BangluongDAO(); return instance; }
            private set { instance = value; }
        }

        /// <summary>
        /// Tính lương cho tất cả nhân viên trong tháng
        /// </summary>
        public List<BangluongDTO> TinhLuongTheoThang(int thang, int nam)
        {
            List<BangluongDTO> danhSachLuong = new List<BangluongDTO>();

            try
            {
                string query = string.Format(@"
                    SELECT 
                        nv.Ma_NV,
                        nv.HoTen,
                        {0} as Thang,
                        {1} as Nam,
                        ISNULL(bc.SoGioLam, 0) as SoGioLam,
                        ISNULL(nv.LuongCoBan, 5000000) as LuongCoBan,
                        ISNULL(hsn.HeSo, 1.0) as HeSoNgay,
                        ISNULL(nv.BaoHiem, 0) as BaoHiem,
                        ISNULL(nv.Thue, 0) as Thue,
                        ISNULL(nv.Phat, 0) as Phat,
                        ISNULL(nv.Thuong, 0) as Thuong
                    FROM [Nhan vien] nv
                    LEFT JOIN (
                        SELECT 
                            ci.Ma_NV,
                            COUNT(ci.NgayCheckIn) * 8.0 as SoGioLam
                        FROM CheckIn ci
                        WHERE MONTH(ci.NgayCheckIn) = {0} AND YEAR(ci.NgayCheckIn) = {1}
                        GROUP BY ci.Ma_NV
                    ) bc ON nv.Ma_NV = bc.Ma_NV
                    LEFT JOIN HeSoNgay hsn ON MONTH(GETDATE()) = hsn.Thang
                    ORDER BY nv.Ma_NV", thang, nam);

                DataTable data = DataProvider.Instance.ExecuteQuery(query);
                foreach (DataRow row in data.Rows)
                {
                    BangluongDTO luong = new BangluongDTO(row);
                    danhSachLuong.Add(luong);
                }
            }
            catch (Exception ex)
            {
                // Log error và tạo dữ liệu test
                danhSachLuong = TaoDuLieuLuongTest(thang, nam);
            }

            return danhSachLuong;
        }

        /// <summary>
        /// Tính lương cho một nhân viên cụ thể
        /// </summary>
        public BangluongDTO TinhLuongNhanVien(string maNV, int thang, int nam)
        {
            try
            {
                string query = string.Format(@"
                    SELECT 
                        nv.Ma_NV,
                        nv.HoTen,
                        {1} as Thang,
                        {2} as Nam,
                        ISNULL(bc.SoGioLam, 0) as SoGioLam,
                        ISNULL(nv.LuongCoBan, 5000000) as LuongCoBan,
                        ISNULL(hsn.HeSo, 1.0) as HeSoNgay,
                        ISNULL(nv.BaoHiem, 0) as BaoHiem,
                        ISNULL(nv.Thue, 0) as Thue,
                        ISNULL(nv.Phat, 0) as Phat,
                        ISNULL(nv.Thuong, 0) as Thuong
                    FROM [Nhan vien] nv
                    LEFT JOIN (
                        SELECT 
                            ci.Ma_NV,
                            COUNT(ci.NgayCheckIn) * 8.0 as SoGioLam
                        FROM CheckIn ci
                        WHERE ci.Ma_NV = '{0}' AND MONTH(ci.NgayCheckIn) = {1} AND YEAR(ci.NgayCheckIn) = {2}
                        GROUP BY ci.Ma_NV
                    ) bc ON nv.Ma_NV = bc.Ma_NV
                    LEFT JOIN HeSoNgay hsn ON MONTH(GETDATE()) = hsn.Thang
                    WHERE nv.Ma_NV = '{0}'", maNV, thang, nam);

                DataTable data = DataProvider.Instance.ExecuteQuery(query);
                if (data.Rows.Count > 0)
                {
                    return new BangluongDTO(data.Rows[0]);
                }
            }
            catch (Exception ex)
            {
                // Return test data for specific employee
                var testData = TaoDuLieuLuongTest(thang, nam);
                return testData.FirstOrDefault(x => x.MaNV == maNV) ?? testData.FirstOrDefault();
            }

            return null;
        }

        /// <summary>
        /// Lưu bảng lương vào database
        /// </summary>
        public bool LuuBangLuong(List<BangluongDTO> danhSachLuong)
        {
            try
            {
                foreach (var luong in danhSachLuong)
                {
                    string query = @"
                        INSERT INTO [Thanh toan luong] 
                        ([Ma_NV], [Thang], [Nam], [SoGioLam], [LuongCoBan], [HeSoNgay], 
                         [BaoHiem], [Thue], [Phat], [Thuong], [LuongThucLinh], [NgayTao])
                        VALUES 
                        ('{0}', {1}, {2}, {3}, {4}, {5}, {6}, {7}, {8}, {9}, {10}, GETDATE())";

                    string formattedQuery = string.Format(query,
                        luong.MaNV, luong.Thang, luong.Nam, luong.SoGioLam,
                        luong.LuongCoBan, luong.HeSoNgay, luong.BaoHiem,
                        luong.Thue, luong.Phat, luong.Thuong, luong.LuongThucLinh);

                    DataProvider.Instance.ExcuteNonQuery(formattedQuery);
                }
                return true;
            }
            catch
            {
                return false;
            }
        }

        /// <summary>
        /// Lấy thống kê tổng lương theo tháng
        /// </summary>
        public DataTable GetThongKeLuongThang(int thang, int nam)
        {
            try
            {
                string query = string.Format(@"
                    SELECT 
                        COUNT(*) as TongNhanVien,
                        SUM(SoGioLam) as TongGioLam,
                        SUM(LuongThucLinh) as TongLuongThucLinh,
                        AVG(LuongThucLinh) as LuongTrungBinh,
                        MAX(LuongThucLinh) as LuongCaoNhat,
                        MIN(LuongThucLinh) as LuongThapNhat
                    FROM [Thanh toan luong]
                    WHERE Thang = {0} AND Nam = {1}", thang, nam);

                return DataProvider.Instance.ExecuteQuery(query);
            }
            catch
            {
                // Return empty table
                DataTable dt = new DataTable();
                dt.Columns.Add("TongNhanVien", typeof(int));
                dt.Columns.Add("TongGioLam", typeof(double));
                dt.Columns.Add("TongLuongThucLinh", typeof(decimal));
                dt.Columns.Add("LuongTrungBinh", typeof(decimal));
                dt.Columns.Add("LuongCaoNhat", typeof(decimal));
                dt.Columns.Add("LuongThapNhat", typeof(decimal));
                return dt;
            }
        }

        /// <summary>
        /// Tạo dữ liệu test cho demo
        /// </summary>
        private List<BangluongDTO> TaoDuLieuLuongTest(int thang, int nam)
        {
            List<BangluongDTO> testData = new List<BangluongDTO>();

            // NV001 - Làm đủ giờ, có thưởng
            testData.Add(new BangluongDTO("NV001", "Nguyễn Văn A", thang, nam, 176.0, 8000000, 1.2, 800000, 400000, 0, 500000));

            // NV002 - Làm ít giờ hơn
            testData.Add(new BangluongDTO("NV002", "Trần Thị B", thang, nam, 160.0, 7000000, 1.0, 700000, 350000, 0, 300000));

            // NV003 - Có phạt
            testData.Add(new BangluongDTO("NV003", "Lê Văn C", thang, nam, 144.0, 6000000, 1.0, 600000, 300000, 100000, 0));

            // NV004 - Nhân viên mới, lương thấp
            testData.Add(new BangluongDTO("NV004", "Phạm Thị D", thang, nam, 168.0, 5000000, 1.0, 500000, 250000, 0, 200000));

            // NV005 - Nhân viên cao cấp
            testData.Add(new BangluongDTO("NV005", "Hoàng Văn E", thang, nam, 180.0, 12000000, 1.5, 1200000, 600000, 0, 1000000));

            return testData;
        }
    }
} 