-- SCRIPT DEBUG NHANH CHO BẢNG CHẤM CÔNG
-- Chạy từng đoạn để kiểm tra vấn đề

USE [QuanLyNhanSu]
GO

PRINT '========== 1. KIỂM TRA CẤU TRÚC BẢNG =========='

-- Kiểm tra cấu trúc bảng CheckIn
SELECT 'CheckIn Structure:' as Info
SELECT COLUMN_NAME, DATA_TYPE, IS_NULLABLE
FROM INFORMATION_SCHEMA.COLUMNS 
WHERE TABLE_NAME = 'CheckIn'
ORDER BY ORDINAL_POSITION

-- Kiểm tra cấu trúc bảng CheckOut
SELECT 'CheckOut Structure:' as Info
SELECT COLUMN_NAME, DATA_TYPE, IS_NULLABLE
FROM INFORMATION_SCHEMA.COLUMNS 
WHERE TABLE_NAME = 'CheckOut'
ORDER BY ORDINAL_POSITION

PRINT '========== 2. KIỂM TRA DỮ LIỆU THỰC TẾ =========='

-- Xem có bao nhiều dữ liệu CheckIn
SELECT 'Total CheckIn records:' as Info, COUNT(*) as Count FROM CheckIn
SELECT 'CheckIn records in May 2025:' as Info, COUNT(*) as Count 
FROM CheckIn WHERE MONTH(NgayCheckIn) = 5 AND YEAR(NgayCheckIn) = 2025

-- Xem có bao nhiều dữ liệu CheckOut
SELECT 'Total CheckOut records:' as Info, COUNT(*) as Count FROM CheckOut
SELECT 'CheckOut records in May 2025:' as Info, COUNT(*) as Count 
FROM CheckOut WHERE MONTH(NgayCheckOut) = 5 AND YEAR(NgayCheckOut) = 2025

PRINT '========== 3. XEM MẪU DỮ LIỆU =========='

-- Xem 5 bản ghi CheckIn gần nhất
SELECT 'Latest 5 CheckIn records:' as Info
SELECT TOP 5 * FROM CheckIn ORDER BY NgayCheckIn DESC

-- Xem 5 bản ghi CheckOut gần nhất  
SELECT 'Latest 5 CheckOut records:' as Info
SELECT TOP 5 * FROM CheckOut ORDER BY NgayCheckOut DESC

PRINT '========== 4. TEST QUERY CHÍNH =========='

-- Test query chính của ứng dụng
SELECT 'Main Query Test Result:' as Info
SELECT 
    nv.Ma_NV,
    nv.HoTen,
    CAST(ci.NgayCheckIn AS DATE) as Ngay,
    CASE 
        WHEN ci.ThoiGianCheckIn IS NOT NULL 
        THEN CAST(ci.ThoiGianCheckIn AS TIME)
        ELSE '08:00:00'
    END as GioCheckIn,
    CASE 
        WHEN co.ThoiGianCheckOut IS NOT NULL 
        THEN CAST(co.ThoiGianCheckOut AS TIME)
        ELSE CAST(ci.ThoiGianCheckIn AS TIME)
    END as GioCheckOut,
    CASE 
        WHEN co.ThoiGianCheckOut IS NOT NULL AND ci.ThoiGianCheckIn IS NOT NULL
        THEN DATEDIFF(MINUTE, ci.ThoiGianCheckIn, co.ThoiGianCheckOut) / 60.0
        ELSE 8.0
    END AS SoGioLam
FROM [Nhan vien] nv
INNER JOIN CheckIn ci ON nv.Ma_NV = ci.Ma_NV 
LEFT JOIN CheckOut co ON ci.Ma_NV = co.Ma_NV 
    AND CAST(ci.NgayCheckIn AS DATE) = CAST(co.NgayCheckOut AS DATE)
WHERE MONTH(ci.NgayCheckIn) = 5 AND YEAR(ci.NgayCheckIn) = 2025
ORDER BY nv.Ma_NV, ci.NgayCheckIn

PRINT '========== DONE ==========' 