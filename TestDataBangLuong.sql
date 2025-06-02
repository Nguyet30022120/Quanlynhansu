-- ================================================
-- SCRIPT TẠO DỮ LIỆU DEMO CHO HỆ THỐNG BẢNG LƯƠNG
-- ================================================

-- 1. Tạo bảng HeSoNgay nếu chưa có
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[HeSoNgay]') AND type in (N'U'))
BEGIN
    CREATE TABLE [dbo].[HeSoNgay] (
        [Thang] INT PRIMARY KEY,
        [HeSo] FLOAT NOT NULL,
        [MoTa] NVARCHAR(200),
        [NgayTao] DATETIME DEFAULT GETDATE()
    );
END

-- 2. Tạo bảng Thanh toan luong nếu chưa có
IF NOT EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Thanh toan luong]') AND type in (N'U'))
BEGIN
    CREATE TABLE [dbo].[Thanh toan luong] (
        [Ma_NV] NVARCHAR(50) NOT NULL,
        [Thang] INT NOT NULL,
        [Nam] INT NOT NULL,
        [SoGioLam] FLOAT NOT NULL,
        [LuongCoBan] DECIMAL(18,2) NOT NULL,
        [HeSoNgay] FLOAT NOT NULL,
        [BaoHiem] DECIMAL(18,2) DEFAULT 0,
        [Thue] DECIMAL(18,2) DEFAULT 0,
        [Phat] DECIMAL(18,2) DEFAULT 0,
        [Thuong] DECIMAL(18,2) DEFAULT 0,
        [LuongThucLinh] DECIMAL(18,2) NOT NULL,
        [NgayTao] DATETIME DEFAULT GETDATE(),
        PRIMARY KEY ([Ma_NV], [Thang], [Nam])
    );
END

-- 3. Thêm dữ liệu hệ số ngày cho 12 tháng
DELETE FROM [HeSoNgay];
INSERT INTO [HeSoNgay] ([Thang], [HeSo], [MoTa]) VALUES
(1, 1.0, N'Tháng 1 - Hệ số bình thường'),
(2, 1.1, N'Tháng 2 - Tăng 10% do Tết'),
(3, 1.0, N'Tháng 3 - Hệ số bình thường'),
(4, 1.05, N'Tháng 4 - Tăng 5% do lễ'),
(5, 1.2, N'Tháng 5 - Tăng 20% do cao điểm'),
(6, 1.0, N'Tháng 6 - Hệ số bình thường'),
(7, 1.0, N'Tháng 7 - Hệ số bình thường'),
(8, 1.0, N'Tháng 8 - Hệ số bình thường'),
(9, 1.05, N'Tháng 9 - Tăng 5% do lễ'),
(10, 1.0, N'Tháng 10 - Hệ số bình thường'),
(11, 1.0, N'Tháng 11 - Hệ số bình thường'),
(12, 1.15, N'Tháng 12 - Tăng 15% do cuối năm');

-- 4. Cập nhật thông tin lương cho nhân viên (nếu có bảng Nhan vien)
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[Nhan vien]') AND type in (N'U'))
BEGIN
    -- Cập nhật lương cơ bản và các khoản khấu trừ/thưởng cho nhân viên demo
    UPDATE [Nhan vien] SET 
        LuongCoBan = 8000000,
        BaoHiem = 800000,
        Thue = 400000,
        Phat = 0,
        Thuong = 500000
    WHERE Ma_NV = 'NV001';

    UPDATE [Nhan vien] SET 
        LuongCoBan = 7000000,
        BaoHiem = 700000,
        Thue = 350000,
        Phat = 0,
        Thuong = 300000
    WHERE Ma_NV = 'NV002';

    UPDATE [Nhan vien] SET 
        LuongCoBan = 6000000,
        BaoHiem = 600000,
        Thue = 300000,
        Phat = 100000,
        Thuong = 0
    WHERE Ma_NV = 'NV003';

    UPDATE [Nhan vien] SET 
        LuongCoBan = 5000000,
        BaoHiem = 500000,
        Thue = 250000,
        Phat = 0,
        Thuong = 200000
    WHERE Ma_NV = 'NV004';

    UPDATE [Nhan vien] SET 
        LuongCoBan = 12000000,
        BaoHiem = 1200000,
        Thue = 600000,
        Phat = 0,
        Thuong = 1000000
    WHERE Ma_NV = 'NV005';
END

-- 5. Thêm dữ liệu bảng lương demo cho tháng 5/2025
DELETE FROM [Thanh toan luong] WHERE Thang = 5 AND Nam = 2025;
INSERT INTO [Thanh toan luong] 
([Ma_NV], [Thang], [Nam], [SoGioLam], [LuongCoBan], [HeSoNgay], [BaoHiem], [Thue], [Phat], [Thuong], [LuongThucLinh]) 
VALUES
('NV001', 5, 2025, 176.0, 8000000, 1.2, 800000, 400000, 0, 500000, 10560000 - 1200000 + 500000),
('NV002', 5, 2025, 160.0, 7000000, 1.2, 700000, 350000, 0, 300000, 8400000 - 1050000 + 300000),
('NV003', 5, 2025, 144.0, 6000000, 1.2, 600000, 300000, 100000, 0, 6480000 - 1000000),
('NV004', 5, 2025, 168.0, 5000000, 1.2, 500000, 250000, 0, 200000, 6300000 - 750000 + 200000),
('NV005', 5, 2025, 180.0, 12000000, 1.2, 1200000, 600000, 0, 1000000, 16200000 - 1800000 + 1000000);

-- 6. Thêm dữ liệu cho tháng 4/2025 (hệ số 1.05)
DELETE FROM [Thanh toan luong] WHERE Thang = 4 AND Nam = 2025;
INSERT INTO [Thanh toan luong] 
([Ma_NV], [Thang], [Nam], [SoGioLam], [LuongCoBan], [HeSoNgay], [BaoHiem], [Thue], [Phat], [Thuong], [LuongThucLinh]) 
VALUES
('NV001', 4, 2025, 172.0, 8000000, 1.05, 800000, 400000, 0, 500000, 9030000 - 1200000 + 500000),
('NV002', 4, 2025, 168.0, 7000000, 1.05, 700000, 350000, 0, 300000, 7717500 - 1050000 + 300000),
('NV003', 4, 2025, 152.0, 6000000, 1.05, 600000, 300000, 50000, 0, 5985000 - 950000),
('NV004', 4, 2025, 160.0, 5000000, 1.05, 500000, 250000, 0, 150000, 5250000 - 750000 + 150000),
('NV005', 4, 2025, 176.0, 12000000, 1.05, 1200000, 600000, 0, 800000, 13860000 - 1800000 + 800000);

-- 7. Thêm dữ liệu CheckIn demo cho tháng 5/2025 nếu bảng tồn tại
IF EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CheckIn]') AND type in (N'U'))
BEGIN
    -- Xóa dữ liệu cũ
    DELETE FROM CheckIn WHERE MONTH(NgayCheckIn) = 5 AND YEAR(NgayCheckIn) = 2025;
    
    -- Thêm dữ liệu check-in cho 22 ngày làm việc trong tháng 5/2025
    DECLARE @NgayBatDau DATE = '2025-05-01';
    DECLARE @NgayKetThuc DATE = '2025-05-31';
    DECLARE @NgayHienTai DATE = @NgayBatDau;
    
    WHILE @NgayHienTai <= @NgayKetThuc
    BEGIN
        -- Chỉ thêm cho ngày làm việc (thứ 2-6)
        IF DATEPART(WEEKDAY, @NgayHienTai) BETWEEN 2 AND 6
        BEGIN
            -- NV001 - Đi làm đầy đủ (22 ngày * 8 giờ = 176 giờ)
            INSERT INTO CheckIn (Ma_NV, NgayCheckIn, TrangThai) 
            VALUES ('NV001', CAST(@NgayHienTai AS DATETIME) + CAST('08:00:00' AS TIME), 1);
            
            -- NV002 - Đi làm 20 ngày (160 giờ)
            IF DATEPART(DAY, @NgayHienTai) % 11 != 0  -- Nghỉ 2 ngày
            INSERT INTO CheckIn (Ma_NV, NgayCheckIn, TrangThai) 
            VALUES ('NV002', CAST(@NgayHienTai AS DATETIME) + CAST('08:15:00' AS TIME), 1);
            
            -- NV003 - Đi làm 18 ngày (144 giờ)
            IF DATEPART(DAY, @NgayHienTai) % 6 != 0  -- Nghỉ 4 ngày
            INSERT INTO CheckIn (Ma_NV, NgayCheckIn, TrangThai) 
            VALUES ('NV003', CAST(@NgayHienTai AS DATETIME) + CAST('08:30:00' AS TIME), 1);
            
            -- NV004 - Đi làm 21 ngày (168 giờ)
            IF DATEPART(DAY, @NgayHienTai) % 22 != 0  -- Nghỉ 1 ngày
            INSERT INTO CheckIn (Ma_NV, NgayCheckIn, TrangThai) 
            VALUES ('NV004', CAST(@NgayHienTai AS DATETIME) + CAST('08:00:00' AS TIME), 1);
            
            -- NV005 - Làm thêm giờ, 22 ngày + overtime (180 giờ)
            INSERT INTO CheckIn (Ma_NV, NgayCheckIn, TrangThai) 
            VALUES ('NV005', CAST(@NgayHienTai AS DATETIME) + CAST('07:45:00' AS TIME), 1);
        END
        
        SET @NgayHienTai = DATEADD(DAY, 1, @NgayHienTai);
    END
END

-- 8. Tạo view báo cáo tổng hợp (tùy chọn)
IF EXISTS (SELECT * FROM sys.views WHERE object_id = OBJECT_ID(N'[dbo].[vw_BaoCaoLuong]'))
    DROP VIEW [dbo].[vw_BaoCaoLuong];
GO

CREATE VIEW [dbo].[vw_BaoCaoLuong] AS
SELECT 
    tl.Ma_NV,
    nv.HoTen,
    tl.Thang,
    tl.Nam,
    tl.SoGioLam,
    tl.LuongCoBan,
    tl.HeSoNgay,
    hsn.MoTa as MoTaHeSo,
    tl.BaoHiem,
    tl.Thue,
    tl.Phat,
    tl.Thuong,
    tl.LuongThucLinh,
    (tl.LuongCoBan / 160.0 * tl.SoGioLam * tl.HeSoNgay) as LuongTheoGio,
    (tl.BaoHiem + tl.Thue + tl.Phat) as TongKhauTru,
    tl.NgayTao
FROM [Thanh toan luong] tl
LEFT JOIN [Nhan vien] nv ON tl.Ma_NV = nv.Ma_NV
LEFT JOIN [HeSoNgay] hsn ON tl.Thang = hsn.Thang;
GO

-- 9. Thống kê sau khi chạy script
SELECT 'Tổng số hệ số ngày đã tạo' as Muc, COUNT(*) as SoLuong FROM [HeSoNgay]
UNION ALL
SELECT 'Tổng số bảng lương đã tạo' as Muc, COUNT(*) as SoLuong FROM [Thanh toan luong]
UNION ALL
SELECT 'Tổng số check-in tháng 5/2025' as Muc, 
       CASE WHEN EXISTS (SELECT * FROM sys.objects WHERE object_id = OBJECT_ID(N'[dbo].[CheckIn]') AND type in (N'U'))
            THEN (SELECT COUNT(*) FROM CheckIn WHERE MONTH(NgayCheckIn) = 5 AND YEAR(NgayCheckIn) = 2025)
            ELSE 0 
       END as SoLuong;

PRINT '================================================';
PRINT 'HOÀN THÀNH TẠO DỮ LIỆU DEMO BẢNG LƯƠNG';
PRINT '================================================';
PRINT 'Dữ liệu đã tạo:';
PRINT '- 12 hệ số ngày cho các tháng trong năm';
PRINT '- Bảng lương demo cho tháng 4 và 5 năm 2025';
PRINT '- Dữ liệu check-in cho tháng 5/2025 (nếu bảng tồn tại)';
PRINT '- View báo cáo tổng hợp vw_BaoCaoLuong';
PRINT '';
PRINT 'Có thể test hệ thống bằng cách:';
PRINT '1. Mở form fBangluong';
PRINT '2. Chọn tháng 5, năm 2025';
PRINT '3. Click "Tính lương" để xem kết quả';
PRINT '================================================'; 