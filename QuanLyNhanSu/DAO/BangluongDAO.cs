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
                        ISNULL(lcb.LuongCoSo, 50000) as LuongCoBan, -- Lương theo giờ
                        ISNULL(hsn.HeSo, 1.0) as HeSoNgay,
                        ISNULL(pc.TongPhucCap, 0) as PhucCap,
                        ISNULL(bh.TongBaoHiem, 0) as BaoHiem,
                        -- Tính tổng thu nhập trước thuế
                        (ISNULL(lcb.LuongCoSo, 50000) * ISNULL(bc.SoGioLam, 0) * ISNULL(hsn.HeSo, 1.0)) + 
                        ISNULL(pc.TongPhucCap, 0) + ISNULL(kt.TienThuong, 0) - ISNULL(kl.TienPhat, 0) as TongThuNhap,
                        -- Tính thuế dựa trên tổng thu nhập
                        CASE 
                            WHEN (ISNULL(lcb.LuongCoSo, 50000) * ISNULL(bc.SoGioLam, 0) * ISNULL(hsn.HeSo, 1.0)) + 
                                 ISNULL(pc.TongPhucCap, 0) + ISNULL(kt.TienThuong, 0) - ISNULL(kl.TienPhat, 0) > 11000000 
                            THEN ((ISNULL(lcb.LuongCoSo, 50000) * ISNULL(bc.SoGioLam, 0) * ISNULL(hsn.HeSo, 1.0)) + 
                                  ISNULL(pc.TongPhucCap, 0) + ISNULL(kt.TienThuong, 0) - ISNULL(kl.TienPhat, 0)) * 0.1
                            ELSE ((ISNULL(lcb.LuongCoSo, 50000) * ISNULL(bc.SoGioLam, 0) * ISNULL(hsn.HeSo, 1.0)) + 
                                  ISNULL(pc.TongPhucCap, 0) + ISNULL(kt.TienThuong, 0) - ISNULL(kl.TienPhat, 0)) * 0.05
                        END as Thue,
                        ISNULL(kl.TienPhat, 0) as Phat,
                        ISNULL(kt.TienThuong, 0) as Thuong,
                        -- Tính lương thực nhận theo công thức mới: (Lương mỗi giờ × Số giờ làm × Hệ số) + Thưởng + Phụ cấp - Phạt - Bảo hiểm - Thuế
                        (ISNULL(lcb.LuongCoSo, 50000) * ISNULL(bc.SoGioLam, 0) * ISNULL(hsn.HeSo, 1.0)) + 
                        ISNULL(kt.TienThuong, 0) + ISNULL(pc.TongPhucCap, 0) - ISNULL(kl.TienPhat, 0) - ISNULL(bh.TongBaoHiem, 0) -
                        CASE 
                            WHEN (ISNULL(lcb.LuongCoSo, 50000) * ISNULL(bc.SoGioLam, 0) * ISNULL(hsn.HeSo, 1.0)) + 
                                 ISNULL(pc.TongPhucCap, 0) + ISNULL(kt.TienThuong, 0) - ISNULL(kl.TienPhat, 0) > 11000000 
                            THEN ((ISNULL(lcb.LuongCoSo, 50000) * ISNULL(bc.SoGioLam, 0) * ISNULL(hsn.HeSo, 1.0)) + 
                                  ISNULL(pc.TongPhucCap, 0) + ISNULL(kt.TienThuong, 0) - ISNULL(kl.TienPhat, 0)) * 0.1
                            ELSE ((ISNULL(lcb.LuongCoSo, 50000) * ISNULL(bc.SoGioLam, 0) * ISNULL(hsn.HeSo, 1.0)) + 
                                  ISNULL(pc.TongPhucCap, 0) + ISNULL(kt.TienThuong, 0) - ISNULL(kl.TienPhat, 0)) * 0.05
                        END as LuongThucNhan
                    FROM [Nhan vien] nv
                    LEFT JOIN [Luong co ban] lcb ON nv.Ma_Luong = lcb.Ma_Luong
                    LEFT JOIN (
                        SELECT 
                            ci.Ma_NV,
                            SUM(
                                CASE 
                                    WHEN co.ThoiGianCheckOut IS NOT NULL 
                                    THEN DATEDIFF(MINUTE, ci.ThoiGianCheckIn, co.ThoiGianCheckOut) / 60.0
                                    ELSE 8.0  -- Mặc định 8 giờ nếu không có checkout
                                END
                            ) as SoGioLam
                        FROM CheckIn ci
                        LEFT JOIN CheckOut co ON ci.Ma_NV = co.Ma_NV 
                                                AND CAST(ci.NgayCheckIn AS DATE) = CAST(co.NgayCheckOut AS DATE)
                        WHERE MONTH(ci.NgayCheckIn) = {0} AND YEAR(ci.NgayCheckIn) = {1}
                        GROUP BY ci.Ma_NV
                    ) bc ON nv.Ma_NV = bc.Ma_NV
                    LEFT JOIN (
                        SELECT TOP 1 HeSo
                        FROM HeSoNgay 
                        WHERE NgayLam <= GETDATE()
                        ORDER BY NgayLam DESC
                    ) hsn ON 1=1
                    LEFT JOIN (
                        SELECT 
                            Ma_NV,
                            SUM(SoTienPhuCap) as TongPhucCap
                        FROM ThongTinPhuCap
                        GROUP BY Ma_NV
                    ) pc ON nv.Ma_NV = pc.Ma_NV
                    LEFT JOIN (
                        SELECT 
                            Ma_NV,
                            SUM(SoTienDong) as TongBaoHiem
                        FROM ThongTinBaoHiem
                        WHERE MONTH(NgayBatDau) <= {0} AND MONTH(ISNULL(NgayKetThuc, GETDATE())) >= {0}
                              AND YEAR(NgayBatDau) <= {1} AND YEAR(ISNULL(NgayKetThuc, GETDATE())) >= {1}
                        GROUP BY Ma_NV
                    ) bh ON nv.Ma_NV = bh.Ma_NV
                    LEFT JOIN (
                        SELECT 
                            Ma_NV,
                            SUM(CASE WHEN HinhThuc = 1 THEN 500000 ELSE 0 END) as TienThuong
                        FROM KhenThuongKyLuat
                        WHERE MONTH(ThoiGian) = {0} AND YEAR(ThoiGian) = {1}
                        GROUP BY Ma_NV
                    ) kt ON nv.Ma_NV = kt.Ma_NV
                    LEFT JOIN (
                        SELECT 
                            Ma_NV,
                            SUM(CASE WHEN HinhThuc = 0 THEN 200000 ELSE 0 END) as TienPhat
                        FROM KhenThuongKyLuat
                        WHERE MONTH(ThoiGian) = {0} AND YEAR(ThoiGian) = {1}
                        GROUP BY Ma_NV
                    ) kl ON nv.Ma_NV = kl.Ma_NV
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
                // Log error và trả về danh sách rỗng thay vì dữ liệu test
                System.Diagnostics.Debug.WriteLine($"Lỗi khi tính lương theo tháng: {ex.Message}");
                return new List<BangluongDTO>();
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
                        ISNULL(lcb.LuongCoSo, 50000) as LuongCoBan, -- Lương theo giờ
                        ISNULL(hsn.HeSo, 1.0) as HeSoNgay,
                        ISNULL(pc.TongPhucCap, 0) as PhucCap,
                        ISNULL(bh.TongBaoHiem, 0) as BaoHiem,
                        -- Tính tổng thu nhập trước thuế
                        (ISNULL(lcb.LuongCoSo, 50000) * ISNULL(bc.SoGioLam, 0) * ISNULL(hsn.HeSo, 1.0)) + 
                        ISNULL(pc.TongPhucCap, 0) + ISNULL(kt.TienThuong, 0) - ISNULL(kl.TienPhat, 0) as TongThuNhap,
                        -- Tính thuế dựa trên tổng thu nhập
                        CASE 
                            WHEN (ISNULL(lcb.LuongCoSo, 50000) * ISNULL(bc.SoGioLam, 0) * ISNULL(hsn.HeSo, 1.0)) + 
                                 ISNULL(pc.TongPhucCap, 0) + ISNULL(kt.TienThuong, 0) - ISNULL(kl.TienPhat, 0) > 11000000 
                            THEN ((ISNULL(lcb.LuongCoSo, 50000) * ISNULL(bc.SoGioLam, 0) * ISNULL(hsn.HeSo, 1.0)) + 
                                  ISNULL(pc.TongPhucCap, 0) + ISNULL(kt.TienThuong, 0) - ISNULL(kl.TienPhat, 0)) * 0.1
                            ELSE ((ISNULL(lcb.LuongCoSo, 50000) * ISNULL(bc.SoGioLam, 0) * ISNULL(hsn.HeSo, 1.0)) + 
                                  ISNULL(pc.TongPhucCap, 0) + ISNULL(kt.TienThuong, 0) - ISNULL(kl.TienPhat, 0)) * 0.05
                        END as Thue,
                        ISNULL(kl.TienPhat, 0) as Phat,
                        ISNULL(kt.TienThuong, 0) as Thuong,
                        -- Tính lương thực nhận theo công thức mới: (Lương mỗi giờ × Số giờ làm × Hệ số) + Thưởng + Phụ cấp - Phạt - Bảo hiểm - Thuế
                        (ISNULL(lcb.LuongCoSo, 50000) * ISNULL(bc.SoGioLam, 0) * ISNULL(hsn.HeSo, 1.0)) + 
                        ISNULL(kt.TienThuong, 0) + ISNULL(pc.TongPhucCap, 0) - ISNULL(kl.TienPhat, 0) - ISNULL(bh.TongBaoHiem, 0) -
                        CASE 
                            WHEN (ISNULL(lcb.LuongCoSo, 50000) * ISNULL(bc.SoGioLam, 0) * ISNULL(hsn.HeSo, 1.0)) + 
                                 ISNULL(pc.TongPhucCap, 0) + ISNULL(kt.TienThuong, 0) - ISNULL(kl.TienPhat, 0) > 11000000 
                            THEN ((ISNULL(lcb.LuongCoSo, 50000) * ISNULL(bc.SoGioLam, 0) * ISNULL(hsn.HeSo, 1.0)) + 
                                  ISNULL(pc.TongPhucCap, 0) + ISNULL(kt.TienThuong, 0) - ISNULL(kl.TienPhat, 0)) * 0.1
                            ELSE ((ISNULL(lcb.LuongCoSo, 50000) * ISNULL(bc.SoGioLam, 0) * ISNULL(hsn.HeSo, 1.0)) + 
                                  ISNULL(pc.TongPhucCap, 0) + ISNULL(kt.TienThuong, 0) - ISNULL(kl.TienPhat, 0)) * 0.05
                        END as LuongThucNhan
                    FROM [Nhan vien] nv
                    LEFT JOIN [Luong co ban] lcb ON nv.Ma_Luong = lcb.Ma_Luong
                    LEFT JOIN (
                        SELECT 
                            ci.Ma_NV,
                            SUM(
                                CASE 
                                    WHEN co.ThoiGianCheckOut IS NOT NULL 
                                    THEN DATEDIFF(MINUTE, ci.ThoiGianCheckIn, co.ThoiGianCheckOut) / 60.0
                                    ELSE 8.0  -- Mặc định 8 giờ nếu không có checkout
                                END
                            ) as SoGioLam
                        FROM CheckIn ci
                        LEFT JOIN CheckOut co ON ci.Ma_NV = co.Ma_NV 
                                                AND CAST(ci.NgayCheckIn AS DATE) = CAST(co.NgayCheckOut AS DATE)
                        WHERE ci.Ma_NV = '{0}' AND MONTH(ci.NgayCheckIn) = {1} AND YEAR(ci.NgayCheckIn) = {2}
                        GROUP BY ci.Ma_NV
                    ) bc ON nv.Ma_NV = bc.Ma_NV
                    LEFT JOIN (
                        SELECT TOP 1 HeSo
                        FROM HeSoNgay 
                        WHERE NgayLam <= GETDATE()
                        ORDER BY NgayLam DESC
                    ) hsn ON 1=1
                    LEFT JOIN (
                        SELECT 
                            Ma_NV,
                            SUM(SoTienPhuCap) as TongPhucCap
                        FROM ThongTinPhuCap
                        WHERE Ma_NV = '{0}'
                        GROUP BY Ma_NV
                    ) pc ON nv.Ma_NV = pc.Ma_NV
                    LEFT JOIN (
                        SELECT 
                            Ma_NV,
                            SUM(SoTienDong) as TongBaoHiem
                        FROM ThongTinBaoHiem
                        WHERE Ma_NV = '{0}' AND MONTH(NgayBatDau) <= {1} AND MONTH(ISNULL(NgayKetThuc, GETDATE())) >= {1}
                              AND YEAR(NgayBatDau) <= {2} AND YEAR(ISNULL(NgayKetThuc, GETDATE())) >= {2}
                        GROUP BY Ma_NV
                    ) bh ON nv.Ma_NV = bh.Ma_NV
                    LEFT JOIN (
                        SELECT 
                            Ma_NV,
                            SUM(CASE WHEN HinhThuc = 1 THEN 500000 ELSE 0 END) as TienThuong
                        FROM KhenThuongKyLuat
                        WHERE Ma_NV = '{0}' AND MONTH(ThoiGian) = {1} AND YEAR(ThoiGian) = {2}
                        GROUP BY Ma_NV
                    ) kt ON nv.Ma_NV = kt.Ma_NV
                    LEFT JOIN (
                        SELECT 
                            Ma_NV,
                            SUM(CASE WHEN HinhThuc = 0 THEN 200000 ELSE 0 END) as TienPhat
                        FROM KhenThuongKyLuat
                        WHERE Ma_NV = '{0}' AND MONTH(ThoiGian) = {1} AND YEAR(ThoiGian) = {2}
                        GROUP BY Ma_NV
                    ) kl ON nv.Ma_NV = kl.Ma_NV
                    WHERE nv.Ma_NV = '{0}'", maNV, thang, nam);

                DataTable data = DataProvider.Instance.ExecuteQuery(query);
                if (data.Rows.Count > 0)
                {
                    return new BangluongDTO(data.Rows[0]);
                }
            }
            catch (Exception ex)
            {
                // Log error và trả về null thay vì dữ liệu test
                System.Diagnostics.Debug.WriteLine($"Lỗi khi tính lương nhân viên {maNV}: {ex.Message}");
                return null;
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
                    // Tạo mã thanh toán lương tự động
                    string maTTTL = "TTTL" + DateTime.Now.ToString("yyyyMMdd") + "_" + luong.MaNV;
                    
                    // Lấy Ma_Luong từ nhân viên
                    string queryMaLuong = $"SELECT Ma_Luong FROM [Nhan vien] WHERE Ma_NV = '{luong.MaNV}'";
                    DataTable dtMaLuong = DataProvider.Instance.ExecuteQuery(queryMaLuong);
                    string maLuong = dtMaLuong.Rows.Count > 0 ? dtMaLuong.Rows[0]["Ma_Luong"].ToString() : "L001";

                    string query = @"
                        INSERT INTO [Thanh toan luong] 
                        ([Ma_TTTL], [Ma_Luong], [Ma_NV], [Ngay_nhan], [Thuong], [Phat], 
                         [KhauTruThue], [KhauTruBaoHiem], [LuongThucNhan], [ThoiGianBatDau], 
                         [ThoiGianKetThuc], [TongGioLam])
                        VALUES 
                        ('{0}', '{1}', '{2}', GETDATE(), {3}, {4}, {5}, {6}, {7}, 
                         DATEFROMPARTS({8}, {9}, 1), 
                         EOMONTH(DATEFROMPARTS({8}, {9}, 1)), 
                         {10})";

                    string formattedQuery = string.Format(query,
                        maTTTL, maLuong, luong.MaNV, luong.Thuong, luong.Phat,
                        luong.Thue, luong.BaoHiem, luong.LuongThucLinh,
                        luong.Nam, luong.Thang, luong.SoGioLam);

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
                        SUM(TongGioLam) as TongGioLam,
                        SUM(Thuong) as TongThuong,
                        SUM(Phat) as TongPhat,
                        SUM(KhauTruThue) as TongThue,
                        SUM(KhauTruBaoHiem) as TongBaoHiem,
                        SUM(LuongThucNhan) as TongLuongThucLinh,
                        AVG(LuongThucNhan) as LuongTrungBinh,
                        MAX(LuongThucNhan) as LuongCaoNhat,
                        MIN(LuongThucNhan) as LuongThapNhat
                    FROM [Thanh toan luong]
                    WHERE MONTH(ThoiGianBatDau) = {0} AND YEAR(ThoiGianBatDau) = {1}", thang, nam);

                return DataProvider.Instance.ExecuteQuery(query);
            }
            catch
            {
                // Return empty table
                DataTable dt = new DataTable();
                dt.Columns.Add("TongNhanVien", typeof(int));
                dt.Columns.Add("TongGioLam", typeof(double));
                dt.Columns.Add("TongThuong", typeof(decimal));
                dt.Columns.Add("TongPhat", typeof(decimal));
                dt.Columns.Add("TongThue", typeof(decimal));
                dt.Columns.Add("TongBaoHiem", typeof(decimal));
                dt.Columns.Add("TongLuongThucLinh", typeof(decimal));
                dt.Columns.Add("LuongTrungBinh", typeof(decimal));
                dt.Columns.Add("LuongCaoNhat", typeof(decimal));
                dt.Columns.Add("LuongThapNhat", typeof(decimal));
                return dt;
            }
        }
    }
} 