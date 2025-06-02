-- Dữ liệu test cho bảng chấm công
-- Chạy script này để tạo dữ liệu mẫu

-- Thêm dữ liệu CheckIn (giả sử có vài nhân viên)
INSERT INTO CheckIn (Ma_NV, NgayCheckIn, GioCheckIn) VALUES
('NV001', '2024-01-15', '08:00:00'),
('NV001', '2024-01-16', '08:15:00'),
('NV001', '2024-01-17', '07:45:00'),
('NV002', '2024-01-15', '08:30:00'),
('NV002', '2024-01-16', '08:00:00'),
('NV002', '2024-01-17', '08:10:00');

-- Thêm dữ liệu CheckOut
INSERT INTO CheckOut (Ma_NV, NgayCheckOut, GioCheckOut) VALUES
('NV001', '2024-01-15', '17:30:00'),
('NV001', '2024-01-16', '17:00:00'),
('NV001', '2024-01-17', '17:15:00'),
('NV002', '2024-01-15', '17:45:00'),
('NV002', '2024-01-16', '17:30:00'),
('NV002', '2024-01-17', '17:20:00');

-- Kiểm tra dữ liệu
SELECT 'CheckIn Data' as TableName;
SELECT * FROM CheckIn;

SELECT 'CheckOut Data' as TableName;
SELECT * FROM CheckOut;

SELECT 'Employee Data' as TableName;
SELECT Ma_NV, HoTen FROM [Nhan vien] WHERE Ma_NV IN ('NV001', 'NV002'); 