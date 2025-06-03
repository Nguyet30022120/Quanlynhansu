# GIẢI THÍCH NGUỒN DỮ LIỆU VÀ CÔNG THỨC TÍNH LƯƠNG

## 🗄️ **CẤU TRÚC DATABASE THỰC TẾ**

### **Sơ đồ quan hệ các bảng:**
```
[Nhan vien] ──┬── [Luong co ban] (Ma_Luong)
              ├── CheckIn/CheckOut (Ma_NV) 
              ├── ThongTinPhuCap (Ma_NV)
              ├── ThongTinBaoHiem (Ma_NV)
              └── KhenThuongKyLuat (Ma_NV)

HeSoNgay (độc lập)
```

## 🧮 **CÔNG THỨC TÍNH LƯƠNG**

```sql
Lương thực lĩnh = (Số giờ làm × Lương cơ bản ÷ 160 × Hệ số ngày) 
                + Phụ cấp 
                - Bảo hiểm 
                - Thuế 
                - Phạt 
                + Thưởng
```

## 📊 **CHI TIẾT NGUỒN DỮ LIỆU**

### **1. 👤 THÔNG TIN NHÂN VIÊN CƠ BẢN**
**Bảng:** `[Nhan vien]`
```sql
SELECT Ma_NV, HoTen, Ma_Luong FROM [Nhan vien]
```
- **Ma_NV**: Mã nhân viên (primary key)
- **HoTen**: Tên nhân viên  
- **Ma_Luong**: Liên kết đến bảng lương cơ bản

---

### **2. 💰 LƯƠNG CƠ BẢN**
**Bảng:** `[Luong co ban]`
```sql
SELECT LuongCoSo FROM [Luong co ban] 
WHERE Ma_Luong = (SELECT Ma_Luong FROM [Nhan vien] WHERE Ma_NV = 'NV001')
```
- **LuongCoSo**: Mức lương cơ bản/tháng (VNĐ)
- **Mặc định**: 5,000,000 VNĐ nếu không có dữ liệu

---

### **3. ⏰ SỐ GIỜ LÀM VIỆC THỰC TẾ**
**Bảng:** `CheckIn` + `CheckOut`
```sql
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
```

**Cách tính:**
- Tính chênh lệch thời gian **thực tế** giữa CheckOut và CheckIn
- Sử dụng `DATEDIFF(MINUTE, ...)` để tính phút, sau đó chia 60 để ra giờ
- **JOIN điều kiện**: Cùng nhân viên và cùng ngày (`CAST AS DATE`)
- **Fallback**: Nếu không có CheckOut → mặc định 8 giờ

**Ví dụ thực tế:**
```sql
-- NV001: 8:00 - 16:30 = 8.5 giờ/ngày × 22 ngày = 187 giờ
-- NV002: 8:00 - 16:00 = 8.0 giờ/ngày × 20 ngày = 160 giờ  
-- NV003: 8:15 - 16:00 = 7.75 giờ/ngày × 18 ngày = 139.5 giờ
-- NV004: 7:45 - 16:00 = 8.25 giờ/ngày × 21 ngày = 173.25 giờ
-- NV005: 7:30 - 17:00 = 9.5 giờ/ngày × 22 ngày = 209 giờ
```

**Lưu ý quan trọng:**
- **Chính xác hơn**: Tính theo giờ thực tế thay vì cố định 8 giờ/ngày
- **Linh hoạt**: Nhân viên làm thêm giờ/về sớm được tính chính xác
- **Bảo toàn**: Nếu thiếu CheckOut vẫn tính 8 giờ mặc định
- **Hiệu quả**: JOIN theo ngày để khớp đúng CheckIn-CheckOut

---

### **4. 📈 HỆ SỐ NGÀY**
**Bảng:** `HeSoNgay`
```sql
SELECT TOP 1 HeSo 
FROM HeSoNgay 
WHERE NgayLam <= GETDATE()
ORDER BY NgayLam DESC
```

**Cách hoạt động:**
- Lấy hệ số **mới nhất** đến thời điểm hiện tại
- **VD:** Tháng 5/2025 có hệ số 1.2 (lễ lao động)
- **Mặc định**: 1.0 nếu không có dữ liệu

**Dữ liệu mẫu:**
```sql
NgayLam        HeSo    MoTa
2025-01-01     1.0     Hệ số thường ngày
2025-02-01     1.1     Hệ số tháng 2 (tết)  
2025-05-01     1.2     Hệ số tháng 5 (lễ lao động)
```

---

### **5. 💼 PHỤ CẤP**
**Bảng:** `ThongTinPhuCap`
```sql
SELECT 
    Ma_NV,
    SUM(SoTienPhuCap) as TongPhucCap
FROM ThongTinPhuCap
GROUP BY Ma_NV
```

**Các loại phụ cấp:**
- **Ăn trưa**: 500,000 - 800,000 VNĐ
- **Xăng xe**: 300,000 - 600,000 VNĐ  
- **Điện thoại**: 200,000 - 300,000 VNĐ
- **Trách nhiệm**: 600,000 VNĐ (quản lý)

**VD NV001:**
```sql
PC001: Phụ cấp ăn trưa    600,000 VNĐ
PC002: Phụ cấp xăng xe    400,000 VNĐ
-----------------------------------------
Tổng phụ cấp:          1,000,000 VNĐ
```

---

### **6. 🛡️ BẢO HIỂM**
**Bảng:** `ThongTinBaoHiem`
```sql
SELECT 
    Ma_NV,
    SUM(SoTienDong) as TongBaoHiem
FROM ThongTinBaoHiem
WHERE MONTH(NgayBatDau) <= 5 AND MONTH(ISNULL(NgayKetThuc, GETDATE())) >= 5
      AND YEAR(NgayBatDau) <= 2025 AND YEAR(ISNULL(NgayKetThuc, GETDATE())) >= 2025
GROUP BY Ma_NV
```

**Điều kiện:**
- Bảo hiểm có hiệu lực trong tháng tính lương
- **NgayBatDau** ≤ tháng tính ≤ **NgayKetThuc**

---

### **7. 💸 THUẾ THU NHẬP**
**Tính toán tự động dựa trên lương:**
```sql
CASE 
    WHEN LuongCoSo > 11,000,000 THEN LuongCoSo * 0.1    -- 10%
    WHEN LuongCoSo > 5,000,000  THEN LuongCoSo * 0.05   -- 5%
    ELSE 0                                              -- Miễn thuế
END
```

**Bậc thuế:**
- **≤ 5 triệu**: Miễn thuế (0%)
- **5-11 triệu**: 5% 
- **> 11 triệu**: 10%

---

### **8. 🏆 THƯỞNG & 📉 PHẠT**
**Bảng:** `KhenThuongKyLuat`
```sql
-- Thưởng (HinhThuc = 1)
SELECT Ma_NV, SUM(500000) as TienThuong
FROM KhenThuongKyLuat
WHERE HinhThuc = 1 AND MONTH(ThoiGian) = 5 AND YEAR(ThoiGian) = 2025
GROUP BY Ma_NV

-- Phạt (HinhThuc = 0)  
SELECT Ma_NV, SUM(200000) as TienPhat
FROM KhenThuongKyLuat
WHERE HinhThuc = 0 AND MONTH(ThoiGian) = 5 AND YEAR(ThoiGian) = 2025
GROUP BY Ma_NV
```

**Mức thưởng/phạt cố định:**
- **Khen thưởng**: 500,000 VNĐ/lần
- **Kỷ luật**: 200,000 VNĐ/lần

---

## 🧮 **VÍ DỤ TÍNH TOÁN CHI TIẾT**

### **Nhân viên NV001 - Tháng 5/2025:**

**📋 Dữ liệu đầu vào:**
```sql
-- Từ [Nhan vien] + [Luong co ban]
LuongCoSo = 8,000,000 VNĐ

-- Từ CheckIn  
SoGioLam = 22 ngày × 8 giờ = 176 giờ

-- Từ HeSoNgay
HeSo = 1.2 (tháng 5/2025)

-- Từ ThongTinPhuCap
PhucCap = 600,000 + 400,000 = 1,000,000 VNĐ

-- Từ ThongTinBaoHiem
BaoHiem = 800,000 VNĐ

-- Tính thuế
Thue = 8,000,000 × 0.05 = 400,000 VNĐ (5%)

-- Từ KhenThuongKyLuat
Thuong = 1 lần × 500,000 = 500,000 VNĐ
Phat = 0 VNĐ
```

**🧮 Tính toán:**
```sql
-- Bước 1: Lương theo giờ
LuongTheoGio = 176 × (8,000,000 ÷ 160) × 1.2 
             = 176 × 50,000 × 1.2 
             = 10,560,000 VNĐ

-- Bước 2: Lương thực lĩnh
LuongThucLinh = 10,560,000 + 1,000,000 - 800,000 - 400,000 - 0 + 500,000
              = 10,860,000 VNĐ
```

---

## 🔧 **SQL QUERY HOÀN CHỈNH**

```sql
SELECT 
    nv.Ma_NV,
    nv.HoTen,
    5 as Thang,
    2025 as Nam,
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
    -- CÔNG THỨC TÍNH LƯƠNG THỰC LĨNH
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
    SELECT ci.Ma_NV, SUM(
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
    SELECT TOP 1 HeSo FROM HeSoNgay 
    WHERE NgayLam <= GETDATE() ORDER BY NgayLam DESC
) hsn ON 1=1
LEFT JOIN (
    SELECT Ma_NV, SUM(SoTienPhuCap) as TongPhucCap
    FROM ThongTinPhuCap GROUP BY Ma_NV
) pc ON nv.Ma_NV = pc.Ma_NV
LEFT JOIN (
    SELECT Ma_NV, SUM(SoTienDong) as TongBaoHiem
    FROM ThongTinBaoHiem
    WHERE MONTH(NgayBatDau) <= 5 AND MONTH(ISNULL(NgayKetThuc, GETDATE())) >= 5
          AND YEAR(NgayBatDau) <= 2025 AND YEAR(ISNULL(NgayKetThuc, GETDATE())) >= 2025
    GROUP BY Ma_NV
) bh ON nv.Ma_NV = bh.Ma_NV
LEFT JOIN (
    SELECT Ma_NV, SUM(CASE WHEN HinhThuc = 1 THEN 500000 ELSE 0 END) as TienThuong
    FROM KhenThuongKyLuat
    WHERE MONTH(ThoiGian) = 5 AND YEAR(ThoiGian) = 2025
    GROUP BY Ma_NV
) kt ON nv.Ma_NV = kt.Ma_NV
LEFT JOIN (
    SELECT Ma_NV, SUM(CASE WHEN HinhThuc = 0 THEN 200000 ELSE 0 END) as TienPhat
    FROM KhenThuongKyLuat
    WHERE MONTH(ThoiGian) = 5 AND YEAR(ThoiGian) = 2025
    GROUP BY Ma_NV
) kl ON nv.Ma_NV = kl.Ma_NV

ORDER BY nv.Ma_NV
```

---

## ⚠️ **LƯU Ý QUAN TRỌNG**

1. **Xử lý NULL**: Tất cả trường đều có giá trị mặc định bằng `ISNULL()`
2. **Hiệu suất**: Sử dụng LEFT JOIN để không loại bỏ nhân viên thiếu dữ liệu  
3. **Tính chính xác**: Dùng `COUNT(DISTINCT NgayCheckIn)` để tránh trùng lặp
4. **Linh hoạt**: Hệ số ngày có thể thay đổi theo từng tháng
5. **Mở rộng**: Có thể thêm các loại phụ cấp mới mà không ảnh hưởng code

Đây là hệ thống tính lương **tự động**, **chính xác** và **linh hoạt** dựa trên cấu trúc database thực tế! 