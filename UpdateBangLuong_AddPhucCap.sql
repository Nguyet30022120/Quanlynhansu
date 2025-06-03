-- =============================================
-- Script: Cập nhật và tạo dữ liệu test cho hệ thống tính lương
-- Ngày tạo: 2025-01-11 (Cập nhật theo DB thực tế)
-- Mô tả: Tạo dữ liệu test cho các bảng trong database thực tế
-- =============================================

USE [QuanLyNhanSu]
GO

-- 1. Tạo dữ liệu test cho bảng [Luong co ban]
IF NOT EXISTS (SELECT * FROM [Luong co ban] WHERE Ma_Luong = 'L001')
BEGIN
    INSERT INTO [Luong co ban] (Ma_Luong, LuongCoSo) VALUES
    ('L001', 5000000),
    ('L002', 7000000), 
    ('L003', 8000000),
    ('L004', 10000000),
    ('L005', 15000000)
    PRINT 'Đã thêm dữ liệu bảng [Luong co ban]'
END

-- 2. Tạo dữ liệu test cho bảng HeSoNgay
DELETE FROM HeSoNgay WHERE NgayLam >= '2025-01-01'
INSERT INTO HeSoNgay (NgayLam, HeSo, MoTa) VALUES
('2025-01-01', 1.0, N'Hệ số thường ngày'),
('2025-02-01', 1.1, N'Hệ số tháng 2 (tết)'),
('2025-03-01', 1.0, N'Hệ số thường ngày'),
('2025-04-01', 1.0, N'Hệ số thường ngày'),
('2025-05-01', 1.2, N'Hệ số tháng 5 (lễ lao động)')
PRINT 'Đã thêm dữ liệu bảng HeSoNgay'

-- 3. Tạo dữ liệu test CheckIn/CheckOut cho tháng 5/2025 với giờ làm việc thực tế
DELETE FROM CheckIn WHERE MONTH(NgayCheckIn) = 5 AND YEAR(NgayCheckIn) = 2025
DELETE FROM CheckOut WHERE MONTH(NgayCheckOut) = 5 AND YEAR(NgayCheckOut) = 2025

-- NV001 - Làm việc đầy đủ 8.5 giờ/ngày, 22 ngày (187 giờ)
DECLARE @date DATE = '2025-05-01'
DECLARE @i INT = 1
WHILE @i <= 22
BEGIN
    IF DATEPART(weekday, @date) NOT IN (1, 7) -- Không phải chủ nhật hoặc thứ 7
    BEGIN
        INSERT INTO CheckIn (Ma_NV, ThoiGianCheckIn, NgayCheckIn) 
        VALUES ('NV001', DATEADD(HOUR, 8, @date), @date)
        
        INSERT INTO CheckOut (Ma_NV, ThoiGianCheckOut, NgayCheckOut)
        VALUES ('NV001', DATEADD(HOUR, 16, DATEADD(MINUTE, 30, @date)), @date) -- 8:00-16:30 = 8.5 giờ
    END
    SET @date = DATEADD(DAY, 1, @date)
    SET @i = @i + 1
END

-- NV002 - Làm việc bình thường 8 giờ/ngày, 20 ngày (160 giờ)
SET @date = '2025-05-01'
SET @i = 1
WHILE @i <= 20
BEGIN
    IF DATEPART(weekday, @date) NOT IN (1, 7)
    BEGIN
        INSERT INTO CheckIn (Ma_NV, ThoiGianCheckIn, NgayCheckIn) 
        VALUES ('NV002', DATEADD(HOUR, 8, @date), @date)
        
        INSERT INTO CheckOut (Ma_NV, ThoiGianCheckOut, NgayCheckOut)
        VALUES ('NV002', DATEADD(HOUR, 16, @date), @date) -- 8:00-16:00 = 8 giờ
    END
    SET @date = DATEADD(DAY, 1, @date)
    SET @i = @i + 1
END

-- NV003 - Làm việc ít hơn 7.5 giờ/ngày, 18 ngày (135 giờ)
SET @date = '2025-05-01'
SET @i = 1
WHILE @i <= 18
BEGIN
    IF DATEPART(weekday, @date) NOT IN (1, 7)
    BEGIN
        INSERT INTO CheckIn (Ma_NV, ThoiGianCheckIn, NgayCheckIn) 
        VALUES ('NV003', DATEADD(HOUR, 8, DATEADD(MINUTE, 15, @date)), @date) -- Đi muộn 15 phút
        
        INSERT INTO CheckOut (Ma_NV, ThoiGianCheckOut, NgayCheckOut)
        VALUES ('NV003', DATEADD(HOUR, 16, @date), @date) -- 8:15-16:00 = 7.75 giờ
    END
    SET @date = DATEADD(DAY, 1, @date)
    SET @i = @i + 1
END

-- NV004 - Làm việc 8.25 giờ/ngày, 21 ngày (173.25 giờ)
SET @date = '2025-05-01'
SET @i = 1
WHILE @i <= 21
BEGIN
    IF DATEPART(weekday, @date) NOT IN (1, 7)
    BEGIN
        INSERT INTO CheckIn (Ma_NV, ThoiGianCheckIn, NgayCheckIn) 
        VALUES ('NV004', DATEADD(HOUR, 7, DATEADD(MINUTE, 45, @date)), @date) -- 7:45
        
        INSERT INTO CheckOut (Ma_NV, ThoiGianCheckOut, NgayCheckOut)
        VALUES ('NV004', DATEADD(HOUR, 16, @date), @date) -- 7:45-16:00 = 8.25 giờ
    END
    SET @date = DATEADD(DAY, 1, @date)
    SET @i = @i + 1
END

-- NV005 - Làm việc nhiều giờ 9.5 giờ/ngày, 22 ngày (209 giờ)
SET @date = '2025-05-01'
SET @i = 1
WHILE @i <= 22
BEGIN
    IF DATEPART(weekday, @date) NOT IN (1, 7)
    BEGIN
        INSERT INTO CheckIn (Ma_NV, ThoiGianCheckIn, NgayCheckIn) 
        VALUES ('NV005', DATEADD(HOUR, 7, DATEADD(MINUTE, 30, @date)), @date) -- 7:30
        
        INSERT INTO CheckOut (Ma_NV, ThoiGianCheckOut, NgayCheckOut)
        VALUES ('NV005', DATEADD(HOUR, 17, @date), @date) -- 7:30-17:00 = 9.5 giờ
    END
    SET @date = DATEADD(DAY, 1, @date)
    SET @i = @i + 1
END

PRINT 'Đã thêm dữ liệu CheckIn/CheckOut với giờ làm việc thực tế tháng 5/2025'

-- 4. Cập nhật dữ liệu ThongTinPhuCap (nếu chưa có)
DELETE FROM ThongTinPhuCap WHERE Ma_PC LIKE 'PC%'
INSERT INTO ThongTinPhuCap (Ma_PC, Ma_NV, LoaiPhuCap, SoTienPhuCap) VALUES
-- NV001 - Nhân viên có nhiều phụ cấp
('PC001', 'NV001', N'Phụ cấp ăn trưa', 600000),
('PC002', 'NV001', N'Phụ cấp xăng xe', 400000),

-- NV002 - Nhân viên có phụ cấp trung bình
('PC003', 'NV002', N'Phụ cấp ăn trưa', 500000),
('PC004', 'NV002', N'Phụ cấp điện thoại', 300000),

-- NV003 - Nhân viên có ít phụ cấp
('PC005', 'NV003', N'Phụ cấp ăn trưa', 500000),

-- NV005 - Nhân viên quản lý có phụ cấp cao
('PC006', 'NV005', N'Phụ cấp ăn trưa', 800000),
('PC007', 'NV005', N'Phụ cấp xăng xe', 600000),
('PC008', 'NV005', N'Phụ cấp trách nhiệm', 600000)

PRINT 'Đã thêm dữ liệu ThongTinPhuCap'

-- 5. Tạo dữ liệu test cho ThongTinBaoHiem
DELETE FROM ThongTinBaoHiem WHERE Ma_BH LIKE 'BH%'
INSERT INTO ThongTinBaoHiem (Ma_BH, Ma_NV, LoaiBaoHiem, MoTa, NgayBatDau, NgayKetThuc, SoTienDong) VALUES
('BH001', 'NV001', N'BHXH', N'Bảo hiểm xã hội', '2025-01-01', '2025-12-31', 800000),
('BH002', 'NV002', N'BHXH', N'Bảo hiểm xã hội', '2025-01-01', '2025-12-31', 700000),
('BH003', 'NV003', N'BHXH', N'Bảo hiểm xã hội', '2025-01-01', '2025-12-31', 600000),
('BH004', 'NV004', N'BHXH', N'Bảo hiểm xã hội', '2025-01-01', '2025-12-31', 500000),
('BH005', 'NV005', N'BHXH', N'Bảo hiểm xã hội', '2025-01-01', '2025-12-31', 1200000)

PRINT 'Đã thêm dữ liệu ThongTinBaoHiem'

-- 6. Tạo dữ liệu test cho KhenThuongKyLuat (tháng 5/2025)
DELETE FROM KhenThuongKyLuat WHERE MONTH(ThoiGian) = 5 AND YEAR(ThoiGian) = 2025
INSERT INTO KhenThuongKyLuat (MaKTKL, Ma_NV, ThoiGian, NoiDung, HinhThuc) VALUES
('KT001', 'NV001', '2025-05-15', N'Hoàn thành xuất sắc công việc', 1), -- Khen thưởng
('KT002', 'NV002', '2025-05-20', N'Nhân viên tiêu biểu tháng', 1),     -- Khen thưởng
('KL001', 'NV003', '2025-05-10', N'Đi muộn 3 lần trong tháng', 0),     -- Kỷ luật
('KT003', 'NV005', '2025-05-25', N'Quản lý hiệu quả nhóm', 1)          -- Khen thưởng

PRINT 'Đã thêm dữ liệu KhenThuongKyLuat tháng 5/2025'

-- 7. Hiển thị kết quả tính lương mẫu
PRINT ''
PRINT '========== KẾT QUẢ TÍNH LƯƠNG THÁNG 5/2025 =========='

SELECT 
    nv.Ma_NV,
    nv.HoTen,
    ISNULL(bc.SoGioLam, 0) as SoGioLam,
    ISNULL(lcb.LuongCoSo, 5000000) as LuongCoBan,
    ISNULL(hsn.HeSo, 1.0) as HeSoNgay,
    ISNULL(pc.TongPhucCap, 0) as PhucCap,
    ISNULL(bh.TongBaoHiem, 0) as BaoHiem,
    CASE 
        WHEN ISNULL(lcb.LuongCoSo, 5000000) > 11000000 THEN ISNULL(lcb.LuongCoSo, 5000000) * 0.1
        WHEN ISNULL(lcb.LuongCoSo, 5000000) > 5000000 THEN ISNULL(lcb.LuongCoSo, 5000000) * 0.05
        ELSE 0
    END as Thue,
    ISNULL(kl.TienPhat, 0) as Phat,
    ISNULL(kt.TienThuong, 0) as Thuong,
    -- Tính lương thực lĩnh với giờ làm việc thực tế
    (ISNULL(bc.SoGioLam, 0) * ISNULL(lcb.LuongCoSo, 5000000) / 160.0 * ISNULL(hsn.HeSo, 1.0)) +
    ISNULL(pc.TongPhucCap, 0) - ISNULL(bh.TongBaoHiem, 0) - 
    CASE 
        WHEN ISNULL(lcb.LuongCoSo, 5000000) > 11000000 THEN ISNULL(lcb.LuongCoSo, 5000000) * 0.1
        WHEN ISNULL(lcb.LuongCoSo, 5000000) > 5000000 THEN ISNULL(lcb.LuongCoSo, 5000000) * 0.05
        ELSE 0
    END - ISNULL(kl.TienPhat, 0) + ISNULL(kt.TienThuong, 0) as LuongThucLinh
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
    WHERE MONTH(ci.NgayCheckIn) = 5 AND YEAR(ci.NgayCheckIn) = 2025
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
    WHERE MONTH(NgayBatDau) <= 5 AND MONTH(ISNULL(NgayKetThuc, GETDATE())) >= 5
          AND YEAR(NgayBatDau) <= 2025 AND YEAR(ISNULL(NgayKetThuc, GETDATE())) >= 2025
    GROUP BY Ma_NV
) bh ON nv.Ma_NV = bh.Ma_NV
LEFT JOIN (
    SELECT 
        Ma_NV,
        SUM(CASE WHEN HinhThuc = 1 THEN 500000 ELSE 0 END) as TienThuong
    FROM KhenThuongKyLuat
    WHERE MONTH(ThoiGian) = 5 AND YEAR(ThoiGian) = 2025
    GROUP BY Ma_NV
) kt ON nv.Ma_NV = kt.Ma_NV
LEFT JOIN (
    SELECT 
        Ma_NV,
        SUM(CASE WHEN HinhThuc = 0 THEN 200000 ELSE 0 END) as TienPhat
    FROM KhenThuongKyLuat
    WHERE MONTH(ThoiGian) = 5 AND YEAR(ThoiGian) = 2025
    GROUP BY Ma_NV
) kl ON nv.Ma_NV = kl.Ma_NV
WHERE nv.Ma_NV IN ('NV001', 'NV002', 'NV003', 'NV004', 'NV005')
ORDER BY nv.Ma_NV

PRINT 'Hoàn thành tạo dữ liệu test và hiển thị kết quả tính lương!'
PRINT ''
PRINT 'CÔNG THỨC TÍNH LƯƠNG MỚI:'
PRINT 'Lương thực lĩnh = (Giờ làm × Lương cơ bản ÷ 160 × Hệ số) + Phụ cấp - Bảo hiểm - Thuế - Phạt + Thưởng' 