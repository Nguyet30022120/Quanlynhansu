# Chức năng Chấm Công - Hệ thống Quản lý Nhân sự

## Mô tả
Chức năng chấm công cho phép xem và thống kê thời gian làm việc của nhân viên theo từng ngày, tháng, năm.

## Các tính năng chính

### 1. Hiển thị bảng công
- Xem bảng công theo tháng/năm
- Lọc theo nhân viên cụ thể hoặc xem tất cả
- Hiển thị: Mã NV, Tên NV, Ngày, Giờ vào, Giờ ra, Số giờ làm

### 2. Thống kê tổng hợp
- Tổng số giờ làm việc trong tháng
- Tổng số ngày làm việc
- Tổng số ngày vắng mặt

### 3. Xuất báo cáo
- Xuất dữ liệu ra file CSV
- Bao gồm cả chi tiết và thống kê tổng hợp

## Cách sử dụng

### 1. Mở form bảng công
```csharp
fBangcong formBangCong = new fBangcong();
formBangCong.ShowDialog();
```

### 2. Cách xem bảng công
1. Chọn **Tháng** từ ComboBox (1-12)
2. Chọn **Năm** từ ComboBox 
3. Chọn **Nhân viên** (hoặc "Tất cả nhân viên")
4. Nhấn nút **"Xem"** để hiển thị dữ liệu

### 3. Xuất báo cáo
1. Sau khi xem dữ liệu, nhấn nút **"Xuất báo cáo"**
2. Chọn vị trí lưu file CSV
3. File sẽ chứa đầy đủ dữ liệu và thống kê

## Cấu trúc Code

### 1. DTO (Data Transfer Object)
**BangcongDTO.cs**: Chứa thông tin một bản ghi chấm công
- `MaNV`: Mã nhân viên
- `TenNV`: Tên nhân viên  
- `Ngay`: Ngày làm việc
- `GioCheckIn`: Giờ vào (nullable)
- `GioCheckOut`: Giờ ra (nullable)
- `SoGioLam`: Số giờ làm việc trong ngày

### 2. DAO (Data Access Object)
**BangcongDAO.cs**: Chứa các phương thức truy cập dữ liệu
- `GetBangCongTheoThang()`: Lấy bảng công tất cả NV theo tháng
- `GetBangCongNhanVienTheoThang()`: Lấy bảng công 1 NV theo tháng
- `GetTongGioLamTheoThang()`: Tính tổng giờ làm của NV trong tháng
- `GetDanhSachNhanVienCoChamCong()`: Lấy danh sách NV có dữ liệu chấm công

### 3. GUI (Giao diện người dùng)
**fBangcong.cs & fBangcong.Designer.cs**: Form hiển thị bảng công
- ComboBox chọn tháng/năm/nhân viên
- DataGridView hiển thị dữ liệu
- Labels hiển thị thống kê
- Buttons thực hiện chức năng

## Cơ sở dữ liệu

### Bảng liên quan:
1. **CheckIn**: Lưu thời gian vào làm
2. **CheckOut**: Lưu thời gian ra về  
3. **Nhan vien**: Thông tin nhân viên
4. **HeSoNgay**: Hệ số ngày (thường/lễ) - sẽ dùng cho tính lương

### Công thức tính giờ làm:
```sql
CASE 
    WHEN GioCheckIn IS NOT NULL AND GioCheckOut IS NOT NULL 
    THEN DATEDIFF(MINUTE, 
        CAST(NgayCheckIn AS DATETIME) + CAST(GioCheckIn AS DATETIME), 
        CAST(NgayCheckOut AS DATETIME) + CAST(GioCheckOut AS DATETIME)) / 60.0
    ELSE 0
END AS SoGioLam
```

## Dữ liệu test
Chạy file `TestDataChamCong.sql` để tạo dữ liệu mẫu cho việc test chức năng.

## Tích hợp với dashboard
Để tích hợp vào dashboard chính, thêm button/menu item:
```csharp
private void btn_bangcong_Click(object sender, EventArgs e)
{
    fBangcong f = new fBangcong();
    f.ShowDialog();
}
```

## Ghi chú
- Form hiển thị tối đa dữ liệu trong 1 tháng
- Chỉ hiển thị những ngày có dữ liệu checkin/checkout
- Hỗ trợ xuất báo cáo định dạng CSV
- Tự động tính toán thống kê theo lựa chọn

## Phát triển tiếp theo
1. **Tích hợp với tính lương**: Sử dụng số giờ làm để tính lương
2. **Thêm chức năng báo cáo**: Báo cáo theo quý, năm
3. **Cảnh báo**: Cảnh báo nhân viên đi muộn, về sớm
4. **Export Excel**: Xuất báo cáo định dạng Excel với format đẹp 