# CẬP NHẬT CÔNG THỨC TÍNH BẢNG LƯƠNG

## Tổng quan
Hệ thống tính bảng lương đã được cập nhật để bao gồm **phụ cấp** vào công thức tính lương thực lĩnh.

## Công thức tính lương mới

### Công thức cũ:
```
Lương thực lĩnh = (Số giờ làm × Lương cơ bản × Hệ số ngày) - Bảo hiểm - Thuế - Phạt + Thưởng
```

### Công thức mới:
```
Lương thực lĩnh = (Số giờ làm × Lương cơ bản × Hệ số ngày) + Phụ cấp - Bảo hiểm - Thuế - Phạt + Thưởng
```

## Thay đổi chi tiết

### 1. BangluongDTO.cs
- **Thêm trường**: `PhucCap` (decimal)
- **Thêm display**: `PhucCapDisplay` (string với định dạng VNĐ)
- **Cập nhật constructor**: Thêm tham số `phucCap`
- **Cập nhật công thức**: `LuongThucLinh` bao gồm phụ cấp

### 2. BangluongDAO.cs
- **Cập nhật query**: Thêm LEFT JOIN với bảng `ThongTinPhuCap`
- **Tính tổng phụ cấp**: `SUM(SoTienPhuCap) as TongPhucCap`
- **Cập nhật method `LuuBangLuong`**: Lưu trường PhucCap vào database
- **Cập nhật dữ liệu test**: Thêm phụ cấp cho các nhân viên mẫu

### 3. fBangluong.cs
- **Thêm cột mới**: Cột "Phụ cấp" trong DataGridView với màu xanh lá
- **Cập nhật export CSV**: Bao gồm cột phụ cấp khi xuất báo cáo

## Cấu trúc dữ liệu

### Bảng ThongTinPhuCap
```sql
- Ma_PC (Primary Key)
- Ma_NV (Foreign Key đến bảng Nhan vien)
- LoaiPhuCap (varchar) - Loại phụ cấp (ăn trưa, xăng xe, điện thoại, etc.)
- SoTienPhuCap (decimal) - Số tiền phụ cấp
```

### Bảng Thanh toan luong (cập nhật)
```sql
- Thêm cột: PhucCap (decimal)
```

## Các loại phụ cấp thường gặp
1. **Phụ cấp ăn trưa**: 500,000 - 1,000,000 VNĐ/tháng
2. **Phụ cấp xăng xe**: 300,000 - 800,000 VNĐ/tháng  
3. **Phụ cấp điện thoại**: 200,000 - 500,000 VNĐ/tháng
4. **Phụ cấp làm ca đêm**: 10-20% lương cơ bản
5. **Phụ cấp độc hại**: 15-25% lương cơ bản
6. **Phụ cấp trách nhiệm**: Tùy theo vị trí quản lý

## Ví dụ tính toán

### Nhân viên NV001:
- Số giờ làm: 176 giờ
- Lương cơ bản: 8,000,000 VNĐ
- Hệ số ngày: 1.2
- **Phụ cấp: 1,000,000 VNĐ** (Mới)
- Bảo hiểm: 800,000 VNĐ
- Thuế: 400,000 VNĐ
- Phạt: 0 VNĐ
- Thưởng: 500,000 VNĐ

**Tính toán:**
```
Lương theo giờ = 176 × (8,000,000 ÷ 160) × 1.2 = 10,560,000 VNĐ
Lương thực lĩnh = 10,560,000 + 1,000,000 - 800,000 - 400,000 - 0 + 500,000 
                = 10,860,000 VNĐ
```

## Giao diện cập nhật

### DataGridView
- Thêm cột "Phụ cấp" với màu xanh lá
- Định dạng hiển thị: "X,XXX,XXX VNĐ"
- Vị trí: Sau cột "Hệ số", trước cột "Bảo hiểm"

### Báo cáo CSV
- Header: "Mã NV,Tên nhân viên,Giờ làm,Lương cơ bản,Hệ số,**Phụ cấp**,Bảo hiểm,Thuế,Phạt,Thưởng,Lương thực lĩnh"
- Dữ liệu bao gồm giá trị phụ cấp cho mỗi nhân viên

## Lưu ý kỹ thuật

1. **Xử lý NULL**: Sử dụng `ISNULL(pc.TongPhucCap, 0)` để xử lý nhân viên không có phụ cấp
2. **Tổng phụ cấp**: Một nhân viên có thể có nhiều loại phụ cấp, hệ thống tự động tính tổng
3. **Hiệu suất**: Sử dụng LEFT JOIN để không ảnh hưởng đến nhân viên không có phụ cấp
4. **Backward compatibility**: Dữ liệu cũ vẫn hoạt động, phụ cấp = 0 nếu không có

## Test Cases

### Dữ liệu test đã cập nhật:
- **NV001**: Phụ cấp 1,000,000 VNĐ (cao)
- **NV002**: Phụ cấp 800,000 VNĐ (trung bình)
- **NV003**: Phụ cấp 500,000 VNĐ (thấp)
- **NV004**: Phụ cấp 0 VNĐ (không có)
- **NV005**: Phụ cấp 2,000,000 VNĐ (rất cao - quản lý)

## Cách sử dụng

1. **Quản lý phụ cấp**: Sử dụng form `fQuanlyphucap` để thêm/sửa/xóa phụ cấp cho nhân viên
2. **Tính lương**: Phụ cấp tự động được tính vào khi bấm "Tính lương"
3. **Xem báo cáo**: Cột phụ cấp hiển thị trong bảng lương và file CSV xuất ra
4. **Lưu dữ liệu**: Phụ cấp được lưu vào bảng `Thanh toan luong` khi bấm "Lưu bảng lương" 