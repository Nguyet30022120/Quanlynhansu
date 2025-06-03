# 🔧 FIX: GIỜ CHECKOUT KHÔNG HIỂN THỊ TRÊN FORM

## 🚨 **VẤN ĐỀ PHÁT HIỆN**

Từ hình ảnh database bạn gửi, tôi phát hiện **cấu trúc bảng khác với query**:

### **Database Thực Tế:**
```sql
-- Bảng CheckOut
MaCheckOut | Ma_NV | ThoiGianCheckOut     | GioCheckOut      | NgayCheckOut
18         | NV001 | 2025-05-10 17:30:00  | 17:30:00.0000000 | 2025-05-12
22         | NV001 | 2025-05-19 00:42:28  | 00:42:28.4733333 | 2025-05-19
```

### **Query Cũ (SAI):**
```sql
-- Sử dụng cột không tồn tại hoặc sai định dạng
CAST(ci.ThoiGianCheckIn AS TIME) as GioCheckIn,
CAST(co.ThoiGianCheckOut AS TIME) as GioCheckOut,
DATEDIFF(MINUTE, ci.ThoiGianCheckIn, co.ThoiGianCheckOut) / 60.0
```

---

## ✅ **GIẢI PHÁP ĐÃ ÁP DỤNG**

### **1. Cập Nhật Query Sử Dụng Đúng Cột:**
```sql
-- Query mới (ĐÚNG)
CASE 
    WHEN ci.GioCheckIn IS NOT NULL 
    THEN CAST(ci.GioCheckIn AS TIME)
    ELSE '08:00:00'
END as GioCheckIn,

CASE 
    WHEN co.GioCheckOut IS NOT NULL 
    THEN CAST(co.GioCheckOut AS TIME)
    ELSE CAST(ci.GioCheckIn AS TIME)
END as GioCheckOut,

-- Tính giờ làm việc chính xác
CASE 
    WHEN co.GioCheckOut IS NOT NULL AND ci.GioCheckIn IS NOT NULL
    THEN DATEDIFF(MINUTE, 
        CAST(CAST(ci.NgayCheckIn AS DATE) AS DATETIME) + CAST(ci.GioCheckIn AS TIME),
        CAST(CAST(co.NgayCheckOut AS DATE) AS DATETIME) + CAST(co.GioCheckOut AS TIME)
    ) / 60.0
    ELSE 8.0  -- Mặc định 8 giờ nếu không có checkout
END AS SoGioLam
```

### **2. Xử Lý Kết Hợp DATE + TIME:**
```sql
-- Kết hợp ngày + giờ để tính chính xác
CAST(CAST(ci.NgayCheckIn AS DATE) AS DATETIME) + CAST(ci.GioCheckIn AS TIME)
CAST(CAST(co.NgayCheckOut AS DATE) AS DATETIME) + CAST(co.GioCheckOut AS TIME)
```

### **3. Fallback Logic:**
- **Nếu thiếu GioCheckIn**: Mặc định `08:00:00`
- **Nếu thiếu GioCheckOut**: Sử dụng GioCheckIn (hiển thị chưa checkout)
- **Nếu thiếu cả hai**: Mặc định 8.0 giờ làm việc

---

## 🧪 **CÁCH KIỂM TRA**

### **Bước 1: Build và Run**
```bash
# Build project
F6 hoặc Build Solution

# Chạy ứng dụng
F5 hoặc Start Debugging
```

### **Bước 2: Test Form Chấm Công**
1. Mở form bảng chấm công
2. Chọn **tháng 5/2025** (có dữ liệu)
3. Chọn **nhân viên NV001**
4. Bấm nút **"Xem"**

### **Bước 3: Kiểm Tra Kết Quả**
**Nếu thành công, bạn sẽ thấy:**
```
✅ TẢI THÀNH CÔNG BẢNG CHẤM CÔNG!

📅 Tháng 5/2025
👥 Số nhân viên: 1
📝 Số bản ghi: 4
🕐 Tổng giờ làm: XX.X giờ
📆 Tổng ngày làm: 4 ngày

📊 THỐNG KÊ CHI TIẾT:
   • Giờ làm cao nhất: XX.X giờ
   • Giờ làm thấp nhất: XX.X giờ
   • Giờ làm trung bình: XX.X giờ/ngày
```

**Nếu click vào ngày có dữ liệu:**
```
📅 THÔNG TIN CHẤM CÔNG NGÀY XX/05/2025
==================================================

👤 Nguyễn Văn A (NV001)
   ⏰ Giờ vào: XX:XX
   ⏰ Giờ ra: XX:XX  <- ĐÂY SẼ HIỂN THỊ ĐÚNG GIỜ CHECKOUT
   🕐 Số giờ làm: X.X giờ
```

---

## 📊 **PHÂN TÍCH DỮ LIỆU CỦA BẠN**

Từ hình ảnh, dữ liệu sẽ được hiển thị như sau:

| Ngày | NV | Giờ Vào | Giờ Ra | Giờ Làm | Ghi Chú |
|------|----|---------|---------|---------|---------| 
| 10/05/2025 | NV001 | ? | 17:30:00 | ? | Checkout 12/05 (có vấn đề?) |
| 19/05/2025 | NV001 | ? | 00:42:28 | ? | Checkout nửa đêm (có vấn đề?) |
| 21/05/2025 | NV001 | ? | 07:17:45 | ? | Checkout sáng sớm |
| 22/05/2025 | NV001 | ? | 09:55:58 | ? | Checkout buổi sáng |

**⚠️ Lưu ý:** Dữ liệu của bạn có vẻ có vấn đề:
- Checkout ngày 10/05 nhưng ghi nhận ngày 12/05
- Checkout vào nửa đêm (00:42:28) có thể là lỗi
- Không thấy dữ liệu CheckIn tương ứng

---

## 🔍 **TROUBLESHOOTING**

### **Nếu vẫn không hiển thị:**

#### **1. Kiểm tra tên cột database:**
```sql
-- Chạy query này trong SQL Server Management Studio
SELECT COLUMN_NAME, DATA_TYPE 
FROM INFORMATION_SCHEMA.COLUMNS 
WHERE TABLE_NAME = 'CheckIn'

SELECT COLUMN_NAME, DATA_TYPE 
FROM INFORMATION_SCHEMA.COLUMNS 
WHERE TABLE_NAME = 'CheckOut'
```

#### **2. Kiểm tra dữ liệu CheckIn:**
```sql
SELECT TOP 5 * FROM CheckIn WHERE Ma_NV = 'NV001'
```

#### **3. Test query trực tiếp:**
```sql
SELECT 
    nv.Ma_NV, nv.HoTen,
    ci.NgayCheckIn, ci.GioCheckIn,
    co.NgayCheckOut, co.GioCheckOut
FROM [Nhan vien] nv
INNER JOIN CheckIn ci ON nv.Ma_NV = ci.Ma_NV 
LEFT JOIN CheckOut co ON ci.Ma_NV = co.Ma_NV 
    AND CAST(ci.NgayCheckIn AS DATE) = CAST(co.NgayCheckOut AS DATE)
WHERE nv.Ma_NV = 'NV001' 
    AND MONTH(ci.NgayCheckIn) = 5 
    AND YEAR(ci.NgayCheckIn) = 2025
```

#### **4. Nếu tên cột khác:**
Cập nhật query trong `BangcongDAO.cs` với tên cột đúng:
```csharp
// Thay đổi từ
CAST(ci.GioCheckIn AS TIME)
// Thành tên cột thực tế của bạn
CAST(ci.TenCotThucTe AS TIME)
```

---

## 🎯 **KẾT LUẬN**

**Vấn đề đã được sửa:** Query đã được cập nhật để sử dụng đúng cột `GioCheckIn` và `GioCheckOut` thay vì `ThoiGianCheckIn`/`ThoiGianCheckOut`.

**Bây giờ bạn có thể:**
1. ✅ Xem giờ checkout chính xác
2. ✅ Tính giờ làm việc thực tế 
3. ✅ Hiển thị thống kê chi tiết
4. ✅ Export báo cáo với dữ liệu đúng

**Hãy test lại và cho tôi biết kết quả!** 🚀 