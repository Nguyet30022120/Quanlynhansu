using QuanLyNhanSu.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Windows.Forms; // Thêm để hiển thị debug message

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
		public DataTable GetNhanVienTheoMa()
		{
			string query = $"SELECT Ma_NV, HoTen FROM NhanVien";

			return DataProvider.Instance.ExecuteQuery(query);
		}
		/// <summary>
		/// Tính lương cho tất cả nhân viên trong tháng - VERSION DEBUG
		/// </summary>
		public List<BangluongDTO> TinhLuongTheoThang(int thang, int nam)
		{
			List<BangluongDTO> danhSachLuong = new List<BangluongDTO>();

			try
			{

				// Query chính: Tính tổng (Giờ từng ngày × Hệ số từng ngày)
				string query = string.Format(@"
                    WITH ChiTietChamCongTheoNgay AS (
                        SELECT 
                            ci.Ma_NV,
                            CAST(ci.NgayCheckIn AS DATE) as NgayLam,
                            -- Số giờ làm trong ngày
                            CASE 
                                WHEN co.ThoiGianCheckOut IS NOT NULL 
                                THEN DATEDIFF(MINUTE, ci.ThoiGianCheckIn, co.ThoiGianCheckOut) / 60.0
                                ELSE 8.0
                            END as GioLamTrongNgay,
                            -- SỬA: Hệ số chỉ áp dụng cho chính xác ngày đó (EQUALS, không phải <=)
                            ISNULL((
                                SELECT HeSo 
                                FROM HeSoNgay 
                                WHERE NgayLam = CAST(ci.NgayCheckIn AS DATE)
                            ), 1.0) as HeSoCuaNgay
                        FROM CheckIn ci
                        LEFT JOIN CheckOut co ON ci.Ma_NV = co.Ma_NV 
                                                AND CAST(ci.NgayCheckIn AS DATE) = CAST(co.NgayCheckOut AS DATE)
                        WHERE MONTH(ci.NgayCheckIn) = {0} AND YEAR(ci.NgayCheckIn) = {1}
                    ),
                    TongKetChamCong AS (
                        SELECT 
                            Ma_NV,
                            -- Tổng số giờ (không có hệ số)
                            SUM(GioLamTrongNgay) as TongGioLam,
                            -- Tổng số giờ có hệ số = Σ(Giờ ngày i × Hệ số ngày i)
                            SUM(GioLamTrongNgay * HeSoCuaNgay) as TongGioCoHeSo,
                            -- Hệ số trung bình (để hiển thị)
                            AVG(HeSoCuaNgay) as HeSoTrungBinh,
                            -- Số ngày làm việc
                            COUNT(*) as SoNgayLam
                        FROM ChiTietChamCongTheoNgay
                        GROUP BY Ma_NV
                    )
                    SELECT 
                        nv.Ma_NV,
                        nv.HoTen,
                        {0} as Thang,
                        {1} as Nam,
                        ISNULL(cc.TongGioLam, 0) as SoGioLam,
                        ISNULL(lcb.LuongCoSo, 50000) as LuongCoBan,
                        ISNULL(pc.TongPhucCap, 0) as PhucCap,
                        ISNULL(bh.TongBaoHiem, 0) as BaoHiem,
                        ISNULL(kl.TienPhat, 0) as Phat,
                        ISNULL(kt.TienThuong, 0) as Thuong,
                        -- Hệ số trung bình (chỉ để hiển thị)
                        ISNULL(cc.HeSoTrungBinh, 1.0) as HeSoNgay,
                        -- Lương cơ bản = LuongCoSo × TongGioCoHeSo (đã tính hệ số từng ngày)
                        ISNULL(lcb.LuongCoSo, 50000) * ISNULL(cc.TongGioCoHeSo, 0) as LuongCoBanDaTinhHeSo,
                        -- Tổng thu nhập trước thuế
                        (ISNULL(lcb.LuongCoSo, 50000) * ISNULL(cc.TongGioCoHeSo, 0)) + 
                        ISNULL(pc.TongPhucCap, 0) + ISNULL(kt.TienThuong, 0) - ISNULL(kl.TienPhat, 0) as TongThuNhap,
                        -- Thuế thu nhập
                        CASE 
                            WHEN (ISNULL(lcb.LuongCoSo, 50000) * ISNULL(cc.TongGioCoHeSo, 0)) + 
                                 ISNULL(pc.TongPhucCap, 0) + ISNULL(kt.TienThuong, 0) - ISNULL(kl.TienPhat, 0) > 11000000 
                            THEN ((ISNULL(lcb.LuongCoSo, 50000) * ISNULL(cc.TongGioCoHeSo, 0)) + 
                                  ISNULL(pc.TongPhucCap, 0) + ISNULL(kt.TienThuong, 0) - ISNULL(kl.TienPhat, 0)) * 0.1
                            ELSE ((ISNULL(lcb.LuongCoSo, 50000) * ISNULL(cc.TongGioCoHeSo, 0)) + 
                                  ISNULL(pc.TongPhucCap, 0) + ISNULL(kt.TienThuong, 0) - ISNULL(kl.TienPhat, 0)) * 0.05
                        END as Thue,
                        -- LƯƠNG THỰC NHẬN = Lương cơ bản (đã có hệ số) + Thưởng + Phụ cấp - Phạt - Bảo hiểm - Thuế
                        (ISNULL(lcb.LuongCoSo, 50000) * ISNULL(cc.TongGioCoHeSo, 0)) + 
                        ISNULL(kt.TienThuong, 0) + ISNULL(pc.TongPhucCap, 0) - ISNULL(kl.TienPhat, 0) - ISNULL(bh.TongBaoHiem, 0) -
                        CASE 
                            WHEN (ISNULL(lcb.LuongCoSo, 50000) * ISNULL(cc.TongGioCoHeSo, 0)) + 
                                 ISNULL(pc.TongPhucCap, 0) + ISNULL(kt.TienThuong, 0) - ISNULL(kl.TienPhat, 0) > 11000000 
                            THEN ((ISNULL(lcb.LuongCoSo, 50000) * ISNULL(cc.TongGioCoHeSo, 0)) + 
                                  ISNULL(pc.TongPhucCap, 0) + ISNULL(kt.TienThuong, 0) - ISNULL(kl.TienPhat, 0)) * 0.1
                            ELSE ((ISNULL(lcb.LuongCoSo, 50000) * ISNULL(cc.TongGioCoHeSo, 0)) + 
                                  ISNULL(pc.TongPhucCap, 0) + ISNULL(kt.TienThuong, 0) - ISNULL(kl.TienPhat, 0)) * 0.05
                        END as LuongThucNhan
                    FROM [NhanVien] nv
                    LEFT JOIN [LuongCoBan] lcb ON nv.Ma_Luong = lcb.Ma_Luong
                    LEFT JOIN TongKetChamCong cc ON nv.Ma_NV = cc.Ma_NV
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

				// DEBUG: Hiển thị số dòng kết quả
				//MessageBox.Show($"Query trả về {data.Rows.Count} dòng dữ liệu", "Debug Info", MessageBoxButtons.OK, MessageBoxIcon.Information);

				foreach (DataRow row in data.Rows)
				{
					BangluongDTO luong = new BangluongDTO(row);
					danhSachLuong.Add(luong);
				}
			}
			catch (Exception ex)
			{
				// Hiển thị lỗi chi tiết
				MessageBox.Show($"Lỗi chi tiết khi tính lương theo tháng:\n{ex.Message}\n\nStack Trace:\n{ex.StackTrace}",
							   "Lỗi Debug", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                       DECLARE @MaNV VARCHAR(50) = '{2}';  -- Thay bằng mã nhân viên cần tính

                WITH ChiTietChamCongTheoNgay AS (
                    SELECT 
                        ci.Ma_NV,
                        CAST(ci.NgayCheckIn AS DATE) as NgayLam,
                        CASE 
                            WHEN co.ThoiGianCheckOut IS NOT NULL 
                            THEN DATEDIFF(MINUTE, ci.ThoiGianCheckIn, co.ThoiGianCheckOut) / 60.0
                            ELSE 8.0
                        END as GioLamTrongNgay,
                        ISNULL((
                            SELECT HeSo 
                            FROM HeSoNgay 
                            WHERE NgayLam = CAST(ci.NgayCheckIn AS DATE)
                        ), 1.0) as HeSoCuaNgay
                    FROM CheckIn ci
                    LEFT JOIN CheckOut co ON ci.Ma_NV = co.Ma_NV 
                                             AND CAST(ci.NgayCheckIn AS DATE) = CAST(co.NgayCheckOut AS DATE)
                    WHERE MONTH(ci.NgayCheckIn) = {0} AND YEAR(ci.NgayCheckIn) = {1}
                          AND ci.Ma_NV = @MaNV
                ),
                TongKetChamCong AS (
                    SELECT 
                        Ma_NV,
                        SUM(GioLamTrongNgay) as TongGioLam,
                        SUM(GioLamTrongNgay * HeSoCuaNgay) as TongGioCoHeSo,
                        AVG(HeSoCuaNgay) as HeSoTrungBinh,
                        COUNT(*) as SoNgayLam
                    FROM ChiTietChamCongTheoNgay
                    GROUP BY Ma_NV
                )
                SELECT 
                    nv.Ma_NV,
                    nv.HoTen,
                    {0} as Thang,
                    {1} as Nam,
                    ISNULL(cc.TongGioLam, 0) as SoGioLam,
                    ISNULL(lcb.LuongCoSo, 50000) as LuongCoBan,
                    ISNULL(pc.TongPhucCap, 0) as PhucCap,
                    ISNULL(bh.TongBaoHiem, 0) as BaoHiem,
                    ISNULL(kl.TienPhat, 0) as Phat,
                    ISNULL(kt.TienThuong, 0) as Thuong,
                    ISNULL(cc.HeSoTrungBinh, 1.0) as HeSoNgay,
                    ISNULL(lcb.LuongCoSo, 50000) * ISNULL(cc.TongGioCoHeSo, 0) as LuongCoBanDaTinhHeSo,
                    (ISNULL(lcb.LuongCoSo, 50000) * ISNULL(cc.TongGioCoHeSo, 0)) + 
                    ISNULL(pc.TongPhucCap, 0) + ISNULL(kt.TienThuong, 0) - ISNULL(kl.TienPhat, 0) as TongThuNhap,
                    CASE 
                        WHEN (ISNULL(lcb.LuongCoSo, 50000) * ISNULL(cc.TongGioCoHeSo, 0)) + 
                             ISNULL(pc.TongPhucCap, 0) + ISNULL(kt.TienThuong, 0) - ISNULL(kl.TienPhat, 0) > 11000000 
                        THEN ((ISNULL(lcb.LuongCoSo, 50000) * ISNULL(cc.TongGioCoHeSo, 0)) + 
                              ISNULL(pc.TongPhucCap, 0) + ISNULL(kt.TienThuong, 0) - ISNULL(kl.TienPhat, 0)) * 0.1
                        ELSE ((ISNULL(lcb.LuongCoSo, 50000) * ISNULL(cc.TongGioCoHeSo, 0)) + 
                              ISNULL(pc.TongPhucCap, 0) + ISNULL(kt.TienThuong, 0) - ISNULL(kl.TienPhat, 0)) * 0.05
                    END as Thue,
                    (ISNULL(lcb.LuongCoSo, 50000) * ISNULL(cc.TongGioCoHeSo, 0)) + 
                    ISNULL(kt.TienThuong, 0) + ISNULL(pc.TongPhucCap, 0) - ISNULL(kl.TienPhat, 0) - ISNULL(bh.TongBaoHiem, 0) -
                    CASE 
                        WHEN (ISNULL(lcb.LuongCoSo, 50000) * ISNULL(cc.TongGioCoHeSo, 0)) + 
                             ISNULL(pc.TongPhucCap, 0) + ISNULL(kt.TienThuong, 0) - ISNULL(kl.TienPhat, 0) > 11000000 
                        THEN ((ISNULL(lcb.LuongCoSo, 50000) * ISNULL(cc.TongGioCoHeSo, 0)) + 
                              ISNULL(pc.TongPhucCap, 0) + ISNULL(kt.TienThuong, 0) - ISNULL(kl.TienPhat, 0)) * 0.1
                        ELSE ((ISNULL(lcb.LuongCoSo, 50000) * ISNULL(cc.TongGioCoHeSo, 0)) + 
                              ISNULL(pc.TongPhucCap, 0) + ISNULL(kt.TienThuong, 0) - ISNULL(kl.TienPhat, 0)) * 0.05
                    END as LuongThucNhan
                FROM [NhanVien] nv
                LEFT JOIN [LuongCoBan] lcb ON nv.Ma_Luong = lcb.Ma_Luong
                LEFT JOIN TongKetChamCong cc ON nv.Ma_NV = cc.Ma_NV
                LEFT JOIN (
                    SELECT 
                        Ma_NV,
                        SUM(SoTienPhuCap) as TongPhucCap
                    FROM ThongTinPhuCap
                    WHERE Ma_NV = @MaNV
                    GROUP BY Ma_NV
                ) pc ON nv.Ma_NV = pc.Ma_NV
                LEFT JOIN (
                    SELECT 
                        Ma_NV,
                        SUM(SoTienDong) as TongBaoHiem
                    FROM ThongTinBaoHiem
                    WHERE MONTH(NgayBatDau) <= {0} AND MONTH(ISNULL(NgayKetThuc, GETDATE())) >= {0}
                          AND YEAR(NgayBatDau) <= {1} AND YEAR(ISNULL(NgayKetThuc, GETDATE())) >= {1}
                          AND Ma_NV = @MaNV
                    GROUP BY Ma_NV
                ) bh ON nv.Ma_NV = bh.Ma_NV
                LEFT JOIN (
                    SELECT 
                        Ma_NV,
                        SUM(CASE WHEN HinhThuc = 1 THEN 500000 ELSE 0 END) as TienThuong
                    FROM KhenThuongKyLuat
                    WHERE MONTH(ThoiGian) = {0} AND YEAR(ThoiGian) = {1} AND Ma_NV = @MaNV
                    GROUP BY Ma_NV
                ) kt ON nv.Ma_NV = kt.Ma_NV
                LEFT JOIN (
                    SELECT 
                        Ma_NV,
                        SUM(CASE WHEN HinhThuc = 0 THEN 200000 ELSE 0 END) as TienPhat
                    FROM KhenThuongKyLuat
                    WHERE MONTH(ThoiGian) = {0} AND YEAR(ThoiGian) = {1} AND Ma_NV = @MaNV
                    GROUP BY Ma_NV
                ) kl ON nv.Ma_NV = kl.Ma_NV
                WHERE nv.Ma_NV = @MaNV", thang, nam, maNV);

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
		public List<BangluongDTO> BangLuongNhanVien(string maNV)
		{
			List<BangluongDTO> list = new List<BangluongDTO>();

			try
			{
				string query = @"
                 WITH ChiTietChamCongTheoNgay AS (
                     SELECT 
                         ci.Ma_NV,
                         CAST(ci.NgayCheckIn AS DATE) AS NgayLam,
                         MONTH(ci.NgayCheckIn) AS Thang,
                         YEAR(ci.NgayCheckIn) AS Nam,
                         CASE 
                             WHEN co.ThoiGianCheckOut IS NOT NULL THEN DATEDIFF(minute, ci.ThoiGianCheckIn, co.ThoiGianCheckOut) / 60.0
                             ELSE 8.0
                         END AS GioLamTrongNgay,
                         ISNULL((SELECT HeSo FROM HeSoNgay WHERE NgayLam = CAST(ci.NgayCheckIn AS DATE)), 1.0) AS HeSoCuaNgay
                     FROM CheckIn ci
                     LEFT JOIN CheckOut co ON ci.Ma_NV = co.Ma_NV 
                                              AND CAST(ci.NgayCheckIn AS DATE) = CAST(co.NgayCheckOut AS DATE)
                     WHERE ci.Ma_NV = @MaNV
                 ),
                 TongKetChamCong AS (
                     SELECT 
                         Ma_NV,
                         Thang,
                         Nam,
                         SUM(GioLamTrongNgay) AS TongGioLam,
                         SUM(GioLamTrongNgay * HeSoCuaNgay) AS TongGioCoHeSo,
                         AVG(HeSoCuaNgay) AS HeSoTrungBinh,
                         COUNT(*) AS SoNgayLam
                     FROM ChiTietChamCongTheoNgay
                     GROUP BY Ma_NV, Thang, Nam
                 ),
                 ThuongPhat AS (
                     SELECT 
                         Ma_NV,
                         MONTH(ThoiGian) AS Thang,
                         YEAR(ThoiGian) AS Nam,
                         SUM(CASE WHEN HinhThuc = 1 THEN 500000 ELSE 0 END) AS TienThuong,
                         SUM(CASE WHEN HinhThuc = 0 THEN 200000 ELSE 0 END) AS TienPhat
                     FROM KhenThuongKyLuat
                     WHERE Ma_NV = @MaNV
                     GROUP BY Ma_NV, MONTH(ThoiGian), YEAR(ThoiGian)
                 ),
                 BaoHiem AS (
                     SELECT 
                         Ma_NV,
                         MONTH(NgayBatDau) AS Thang,
                         YEAR(NgayBatDau) AS Nam,
                         SUM(SoTienDong) AS TongBaoHiem
                     FROM ThongTinBaoHiem
                     WHERE Ma_NV = @MaNV
                     GROUP BY Ma_NV, MONTH(NgayBatDau), YEAR(NgayBatDau)
                 ),
                 PhuCap AS (
                     SELECT 
                         Ma_NV,
                         SUM(SoTienPhuCap) AS TongPhucCap
                     FROM ThongTinPhuCap
                     WHERE Ma_NV = @MaNV
                     GROUP BY Ma_NV
                 )
                 SELECT 
                     nv.Ma_NV,
                     nv.HoTen,
                     cc.Thang,
                     cc.Nam,
                     ISNULL(cc.TongGioLam, 0) AS SoGioLam,
                     ISNULL(lcb.LuongCoSo, 50000) AS LuongCoBan,
                     ISNULL(pc.TongPhucCap, 0) AS PhucCap,
                     ISNULL(bh.TongBaoHiem, 0) AS BaoHiem,
                     ISNULL(tp.TienPhat, 0) AS Phat,
                     ISNULL(tp.TienThuong, 0) AS Thuong,
                     ISNULL(cc.HeSoTrungBinh, 1.0) AS HeSoNgay,
                     ISNULL(lcb.LuongCoSo, 50000) * ISNULL(cc.TongGioCoHeSo, 0) AS LuongCoBanDaTinhHeSo,
                     (ISNULL(lcb.LuongCoSo, 50000) * ISNULL(cc.TongGioCoHeSo, 0)) + 
                     ISNULL(pc.TongPhucCap, 0) + ISNULL(tp.TienThuong, 0) - ISNULL(tp.TienPhat, 0) AS TongThuNhap,
                     CASE 
                         WHEN (ISNULL(lcb.LuongCoSo, 50000) * ISNULL(cc.TongGioCoHeSo, 0)) + 
                              ISNULL(pc.TongPhucCap, 0) + ISNULL(tp.TienThuong, 0) - ISNULL(tp.TienPhat, 0) > 11000000 
                         THEN((ISNULL(lcb.LuongCoSo, 50000) * ISNULL(cc.TongGioCoHeSo, 0)) + ISNULL(pc.TongPhucCap, 0) + ISNULL(tp.TienThuong, 0) - ISNULL(tp.TienPhat, 0)) * 0.1
                         ELSE((ISNULL(lcb.LuongCoSo, 50000) * ISNULL(cc.TongGioCoHeSo, 0)) + ISNULL(pc.TongPhucCap, 0) + ISNULL(tp.TienThuong, 0) - ISNULL(tp.TienPhat, 0)) * 0.05
                     END AS Thue,
                     (ISNULL(lcb.LuongCoSo, 50000) * ISNULL(cc.TongGioCoHeSo, 0)) + ISNULL(tp.TienThuong, 0) + ISNULL(pc.TongPhucCap, 0) - ISNULL(tp.TienPhat, 0) - ISNULL(bh.TongBaoHiem, 0) - 
                     CASE 
                         WHEN (ISNULL(lcb.LuongCoSo, 50000) * ISNULL(cc.TongGioCoHeSo, 0)) + ISNULL(pc.TongPhucCap, 0) + ISNULL(tp.TienThuong, 0) - ISNULL(tp.TienPhat, 0) > 11000000 
                         THEN((ISNULL(lcb.LuongCoSo, 50000) * ISNULL(cc.TongGioCoHeSo, 0)) + ISNULL(pc.TongPhucCap, 0) + ISNULL(tp.TienThuong, 0) - ISNULL(tp.TienPhat, 0)) * 0.1
                         ELSE((ISNULL(lcb.LuongCoSo, 50000) * ISNULL(cc.TongGioCoHeSo, 0)) + ISNULL(pc.TongPhucCap, 0) + ISNULL(tp.TienThuong, 0) - ISNULL(tp.TienPhat, 0)) * 0.05
                     END AS LuongThucNhan
                 FROM NhanVien nv
                 LEFT JOIN LuongCoBan lcb ON nv.Ma_Luong = lcb.Ma_Luong
                 LEFT JOIN TongKetChamCong cc ON nv.Ma_NV = cc.Ma_NV
                 LEFT JOIN PhuCap pc ON nv.Ma_NV = pc.Ma_NV
                 LEFT JOIN BaoHiem bh ON nv.Ma_NV = bh.Ma_NV AND bh.Thang = cc.Thang AND bh.Nam = cc.Nam
                 LEFT JOIN ThuongPhat tp ON nv.Ma_NV = tp.Ma_NV AND tp.Thang = cc.Thang AND tp.Nam = cc.Nam
                 WHERE nv.Ma_NV = @MaNV
                 ORDER BY cc.Nam, cc.Thang;
                 ";

				SqlParameter[] parameters = new SqlParameter[]
				{
			         new SqlParameter("@MaNV", maNV)
				};

				DataTable data = DataProvider.Instance.ExecuteQuery(query, parameters);

				foreach (DataRow row in data.Rows)
				{
					list.Add(new BangluongDTO(row)); // bạn cần hàm khởi tạo từ dòng dữ kiện
				}
			}
			catch (Exception ex)
			{
				System.Diagnostics.Debug.WriteLine($"Lỗi khi thống kê bảng lương nhân viên {maNV}: {ex.Message}");

				// bạn cũng có thể ném Exception nếu bạn muốn xử lý phía UI
				// throw;
			}

			return list;
		}



		//public List<BangluongDTO> BangLuongNhanVien(string maNV)
		//{
		//	List<BangluongDTO> danhSachLuong = new List<BangluongDTO>();

		//	try
		//	{
		//		string query = string.Format(@"
		//            WITH ChiTietChamCongTheoNgay AS (
		//                SELECT 
		//                    ci.Ma_NV,
		//                    CAST(ci.NgayCheckIn AS DATE) as NgayLam,
		//                    MONTH(ci.NgayCheckIn) AS Thang,
		//                    YEAR(ci.NgayCheckIn) AS Nam,
		//                    CASE 
		//                        WHEN co.ThoiGianCheckOut IS NOT NULL 
		//                        THEN DATEDIFF(MINUTE, ci.ThoiGianCheckIn, co.ThoiGianCheckOut) / 60.0
		//                        ELSE 8.0
		//                    END as GioLamTrongNgay,
		//                    ISNULL((
		//                        SELECT HeSo 
		//                        FROM HeSoNgay 
		//                        WHERE NgayLam = CAST(ci.NgayCheckIn AS DATE)
		//                    ), 1.0) as HeSoCuaNgay
		//                FROM CheckIn ci
		//                LEFT JOIN CheckOut co ON ci.Ma_NV = co.Ma_NV 
		//                                     AND CAST(ci.NgayCheckIn AS DATE) = CAST(co.NgayCheckOut AS DATE)
		//                WHERE ci.Ma_NV = '{0}'
		//            ),
		//            TongKetChamCong AS (
		//                SELECT 
		//                    Ma_NV,
		//                    Thang,
		//                    Nam,
		//                    SUM(GioLamTrongNgay) as TongGioLam,
		//                    SUM(GioLamTrongNgay * HeSoCuaNgay) as TongGioCoHeSo,
		//                    AVG(HeSoCuaNgay) as HeSoTrungBinh,
		//                    COUNT(*) as SoNgayLam
		//                FROM ChiTietChamCongTheoNgay
		//                GROUP BY Ma_NV, Thang, Nam
		//            ),
		//            ThuongPhat AS (
		//                SELECT 
		//                    Ma_NV,
		//                    MONTH(ThoiGian) AS Thang,
		//                    YEAR(ThoiGian) AS Nam,
		//                    SUM(CASE WHEN HinhThuc = 1 THEN 500000 ELSE 0 END) as TienThuong,
		//                    SUM(CASE WHEN HinhThuc = 0 THEN 200000 ELSE 0 END) as TienPhat
		//                FROM KhenThuongKyLuat
		//                WHERE Ma_NV = '{0}'
		//                GROUP BY Ma_NV, MONTH(ThoiGian), YEAR(ThoiGian)
		//            ),
		//            BaoHiem AS (
		//                SELECT 
		//                    Ma_NV,
		//                    MONTH(NgayBatDau) AS Thang,
		//                    YEAR(NgayBatDau) AS Nam,
		//                    SUM(SoTienDong) as TongBaoHiem
		//                FROM ThongTinBaoHiem
		//                WHERE Ma_NV = '{0}'
		//                GROUP BY Ma_NV, MONTH(NgayBatDau), YEAR(NgayBatDau)
		//            ),
		//            PhuCap AS (
		//                SELECT 
		//                    Ma_NV,
		//                    SUM(SoTienPhuCap) AS TongPhucCap
		//                FROM ThongTinPhuCap
		//                WHERE Ma_NV = '{0}'
		//                GROUP BY Ma_NV
		//            )
		//            SELECT 
		//                nv.Ma_NV,
		//                nv.HoTen,
		//                cc.Thang,
		//                cc.Nam,
		//                ISNULL(cc.TongGioLam, 0) as SoGioLam,
		//                ISNULL(lcb.LuongCoSo, 50000) as LuongCoBan,
		//                ISNULL(pc.TongPhucCap, 0) as PhucCap,
		//                ISNULL(bh.TongBaoHiem, 0) as BaoHiem,
		//                ISNULL(tp.TienPhat, 0) as Phat,
		//                ISNULL(tp.TienThuong, 0) as Thuong,
		//                ISNULL(cc.HeSoTrungBinh, 1.0) as HeSoNgay,
		//                ISNULL(lcb.LuongCoSo, 50000) * ISNULL(cc.TongGioCoHeSo, 0) as LuongCoBanDaTinhHeSo,
		//                (ISNULL(lcb.LuongCoSo, 50000) * ISNULL(cc.TongGioCoHeSo, 0)) + 
		//                ISNULL(pc.TongPhucCap, 0) + ISNULL(tp.TienThuong, 0) - ISNULL(tp.TienPhat, 0) as TongThuNhap,
		//                CASE 
		//                    WHEN (ISNULL(lcb.LuongCoSo, 50000) * ISNULL(cc.TongGioCoHeSo, 0)) + 
		//                         ISNULL(pc.TongPhucCap, 0) + ISNULL(tp.TienThuong, 0) - ISNULL(tp.TienPhat, 0) > 11000000 
		//                    THEN ((ISNULL(lcb.LuongCoSo, 50000) * ISNULL(cc.TongGioCoHeSo, 0)) + 
		//                          ISNULL(pc.TongPhucCap, 0) + ISNULL(tp.TienThuong, 0) - ISNULL(tp.TienPhat, 0)) * 0.1
		//                    ELSE ((ISNULL(lcb.LuongCoSo, 50000) * ISNULL(cc.TongGioCoHeSo, 0)) + 
		//                          ISNULL(pc.TongPhucCap, 0) + ISNULL(tp.TienThuong, 0) - ISNULL(tp.TienPhat, 0)) * 0.05
		//                END as Thue,
		//                (ISNULL(lcb.LuongCoSo, 50000) * ISNULL(cc.TongGioCoHeSo, 0)) + 
		//                ISNULL(tp.TienThuong, 0) + ISNULL(pc.TongPhucCap, 0) - ISNULL(tp.TienPhat, 0) - ISNULL(bh.TongBaoHiem, 0) - 
		//                CASE 
		//                    WHEN (ISNULL(lcb.LuongCoSo, 50000) * ISNULL(cc.TongGioCoHeSo, 0)) + 
		//                         ISNULL(pc.TongPhucCap, 0) + ISNULL(tp.TienThuong, 0) - ISNULL(tp.TienPhat, 0) > 11000000 
		//                    THEN ((ISNULL(lcb.LuongCoSo, 50000) * ISNULL(cc.TongGioCoHeSo, 0)) + 
		//                          ISNULL(pc.TongPhucCap, 0) + ISNULL(tp.TienThuong, 0) - ISNULL(tp.TienPhat, 0)) * 0.1
		//                    ELSE ((ISNULL(lcb.LuongCoSo, 50000) * ISNULL(cc.TongGioCoHeSo, 0)) + 
		//                          ISNULL(pc.TongPhucCap, 0) + ISNULL(tp.TienThuong, 0) - ISNULL(tp.TienPhat, 0)) * 0.05
		//                END as LuongThucNhan
		//            FROM NhanVien nv
		//            LEFT JOIN LuongCoBan lcb ON nv.Ma_Luong = lcb.Ma_Luong
		//            LEFT JOIN TongKetChamCong cc ON nv.Ma_NV = cc.Ma_NV
		//            LEFT JOIN PhuCap pc ON nv.Ma_NV = pc.Ma_NV
		//            LEFT JOIN BaoHiem bh ON nv.Ma_NV = bh.Ma_NV AND bh.Thang = cc.Thang AND bh.Nam = cc.Nam
		//            LEFT JOIN ThuongPhat tp ON nv.Ma_NV = tp.Ma_NV AND tp.Thang = cc.Thang AND tp.Nam = cc.Nam
		//            WHERE nv.Ma_NV = '{0}'
		//            ORDER BY cc.Nam, cc.Thang;", maNV);

		//		DataTable data = DataProvider.Instance.ExecuteQuery(query);

		//		foreach (DataRow row in data.Rows)
		//		{
		//			danhSachLuong.Add(new BangluongDTO(row));
		//		}
		//	}
		//	catch (Exception ex)
		//	{
		//		System.Diagnostics.Debug.WriteLine($"Lỗi khi thống kê bảng lương nhân viên {maNV}: {ex.Message}");
		//	}

		//	return danhSachLuong;
		//}


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
					string queryMaLuong = $"SELECT Ma_Luong FROM [NhanVien] WHERE Ma_NV = '{luong.MaNV}'";
					DataTable dtMaLuong = DataProvider.Instance.ExecuteQuery(queryMaLuong);
					string maLuong = dtMaLuong.Rows.Count > 0 ? dtMaLuong.Rows[0]["Ma_Luong"].ToString() : "L001";

					string query = @"
                        INSERT INTO [ThanhToanLuong] 
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
	}
}