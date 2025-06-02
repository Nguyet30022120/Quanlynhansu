# HỆ THỐNG BẢNG LƯƠNG - QUẢN LÝ NHÂN SỰ

## 📋 TỔNG QUAN

Hệ thống bảng lương được thiết kế để tính toán và quản lý lương nhân viên dựa trên dữ liệu chấm công, với công thức tính lương linh hoạt và khả năng xuất báo cáo chi tiết.

## 🚀 TÍNH NĂNG CHÍNH

### 1. Tính Lương Tự Động
- Tính lương theo tháng/năm cho tất cả nhân viên
- Tính lương cho nhân viên cụ thể
- Áp dụng công thức: `Lương thực lĩnh = (Giờ làm × Lương cơ bản ÷ 160 × Hệ số) - Khấu trừ + Thưởng`

### 2. Quản Lý Dữ Liệu
- Hiển thị bảng lương với các cột chi tiết
- Lọc theo tháng/năm/nhân viên
- Thống kê tổng hợp (tổng lương, trung bình, cao nhất, thấp nhất)

### 3. Xuất Báo Cáo
- Xuất file CSV với đầy đủ thông tin
- Bao gồm dữ liệu và thống kê
- Tên file tự động theo format: `BangLuong_Thang_Nam_NgayGio.csv`

### 4. Lưu Trữ Database
- Lưu bảng lương vào bảng `Thanh toan luong`
- Theo dõi lịch sử tính lương
- Kiểm soát chất lượng dữ liệu

## 🏗️ KIẾN TRÚC HỆ THỐNG

### 1. Lớp DTO (Data Transfer Object)
```csharp
BangluongDTO.cs
├── Thuộc tính cơ bản: MaNV, TenNV, Thang, Nam
├── Dữ liệu tính lương: SoGioLam, LuongCoBan, HeSoNgay
├── Khấu trừ: BaoHiem, Thue, Phat
├── Thưởng: Thuong
└── Thuộc tính tính toán: LuongTheoGio, TongKhauTru, LuongThucLinh
```

### 2. Lớp DAO (Data Access Object)
```csharp
BangluongDAO.cs
├── TinhLuongTheoThang(): Tính lương tất cả NV trong tháng
├── TinhLuongNhanVien(): Tính lương NV cụ thể
├── LuuBangLuong(): Lưu vào database
├── GetThongKeLuongThang(): Thống kê tổng hợp
└── TaoDuLieuLuongTest(): Tạo dữ liệu demo
```

### 3. Lớp GUI (Giao Diện)
```csharp
fBangluong.cs + fBangluong.Designer.cs
├── Panel điều khiển: ComboBox tháng/năm/nhân viên, buttons
├── DataGridView: Hiển thị dữ liệu lương chi tiết
├── Panel thống kê: Hiển thị số liệu tổng hợp
└── Panel công thức: Hướng dẫn cách tính lương
```

## 📊 CÔNG THỨC TÍNH LƯƠNG

### Công Thức Chính
```
Lương thực lĩnh = Lương theo giờ - Tổng khấu trừ + Thưởng
```

### Chi Tiết Các Thành Phần
1. **Lương theo giờ** = `Số giờ làm × (Lương cơ bản ÷ 160) × Hệ số ngày`
2. **Tổng khấu trừ** = `Bảo hiểm + Thuế + Phạt`
3. **Lương thực lĩnh** = `Lương theo giờ - Tổng khấu trừ + Thưởng`

### Ví Dụ Tính Toán
```
Nhân viên làm 176 giờ, lương cơ bản 8.000.000 VNĐ, hệ số 1.2:
• Lương theo giờ = 176 × (8.000.000 ÷ 160) × 1.2 = 10.560.000 VNĐ
• Khấu trừ 1.200.000 VNĐ, thưởng 500.000 VNĐ
• Lương thực lĩnh = 10.560.000 - 1.200.000 + 500.000 = 9.860.000 VNĐ
```

## 🗃️ BẢNG DATABASE LIÊN QUAN

### 1. Bảng CheckIn (Dữ liệu đầu vào)
```sql
- Ma_NV: Mã nhân viên
- NgayCheckIn: Ngày giờ check-in
- TrangThai: Trạng thái check-in
```

### 2. Bảng [Nhan vien] (Thông tin nhân viên)
```sql
- Ma_NV: Mã nhân viên
- HoTen: Họ tên
- LuongCoBan: Lương cơ bản
- BaoHiem, Thue, Phat, Thuong: Các khoản liên quan
```

### 3. Bảng HeSoNgay (Hệ số tính lương)
```sql
- Thang: Tháng áp dụng
- HeSo: Hệ số nhân lương
```

### 4. Bảng [Thanh toan luong] (Kết quả)
```sql
- Ma_NV, Thang, Nam: Khóa chính
- SoGioLam, LuongCoBan, HeSoNgay: Dữ liệu tính toán
- BaoHiem, Thue, Phat, Thuong: Các khoản điều chỉnh
- LuongThucLinh: Kết quả cuối cùng
- NgayTao: Thời gian tính lương
```

## 🔧 HƯỚNG DẪN SỬ DỤNG

### 1. Mở Form Bảng Lương
```csharp
// Từ AdminDashboard
fBangluong formBangLuong = new fBangluong();
formBangLuong.ShowDialog();
```

### 2. Các Chức Năng Chính

#### Tính Lương
1. Chọn tháng và năm
2. Chọn nhân viên (hoặc "Tất cả nhân viên")
3. Click nút "Tính lương"
4. Xem kết quả trong bảng và thống kê

#### Xuất Báo Cáo
1. Sau khi có dữ liệu lương
2. Click nút "Xuất báo cáo"
3. Chọn vị trí lưu file CSV
4. File được tạo với đầy đủ dữ liệu và thống kê

#### Lưu Bảng Lương
1. Sau khi tính lương
2. Click nút "Lưu bảng lương"
3. Xác nhận lưu vào database
4. Dữ liệu được lưu vào bảng `Thanh toan luong`

### 3. Giao Diện Chính

#### Panel Điều Khiển (Trên)
- ComboBox chọn tháng (1-12)
- ComboBox chọn năm (2020 - hiện tại + 2)
- ComboBox chọn nhân viên
- Buttons: Tính lương, Xuất báo cáo, Lưu bảng lương, Đóng

#### DataGridView (Giữa bên trái)
- Hiển thị chi tiết lương từng nhân viên
- Các cột: Mã NV, Tên, Giờ làm, Lương cơ bản, Hệ số, Bảo hiểm, Thuế, Phạt, Thưởng, Lương thực lĩnh
- Hỗ trợ sắp xếp và chọn hàng

#### Panel Công Thức (Giữa bên phải)
- Hiển thị công thức tính lương chi tiết
- Ví dụ tính toán cụ thể
- Giải thích các thành phần

#### Panel Thống Kê (Dưới)
- Tổng nhân viên
- Tổng lương
- Lương trung bình
- Lương cao nhất
- Lương thấp nhất

## 🔌 TÍCH HỢP VÀO HỆ THỐNG

### 1. Thêm Button vào Dashboard
```csharp
// Trong AdminDashboard.cs đã có sẵn event handler:
private void btn_quanlybangluong_Click(object sender, EventArgs e)
{
    fBangluong bangluong = new fBangluong();
    bangluong.ShowDialog();
}
```

### 2. Dependencies Cần Thiết
- `NhanvienDAO`: Để load danh sách nhân viên
- `BangcongDAO`: Để lấy dữ liệu chấm công (nếu có)
- `DataProvider`: Để kết nối database

### 3. Xử Lý Lỗi
- Try-catch trong tất cả operations
- Fallback với dữ liệu test khi DB không khả dụng
- Thông báo lỗi user-friendly

## 📈 DEMO DATA

Hệ thống bao gồm 5 nhân viên demo:
1. **NV001** - Nguyễn Văn A: Làm đủ giờ, có thưởng
2. **NV002** - Trần Thị B: Làm ít giờ hơn
3. **NV003** - Lê Văn C: Có phạt
4. **NV004** - Phạm Thị D: Nhân viên mới
5. **NV005** - Hoàng Văn E: Nhân viên cao cấp

## 🛠️ BẢO TRÌ VÀ MỞ RỘNG

### Customization Points
1. **Công thức tính lương**: Chỉnh sửa trong `BangluongDTO` properties
2. **Nguồn dữ liệu**: Thay đổi SQL queries trong `BangluongDAO`
3. **Giao diện**: Chỉnh sửa layout trong `fBangluong.Designer.cs`
4. **Validation**: Thêm rules trong `fBangluong.cs` methods

### Performance Optimization
- Index database tables appropriately
- Cache employee data for ComboBox
- Implement pagination for large datasets
- Optimize SQL queries

## 📞 HỖ TRỢ

Nếu có vấn đề với hệ thống bảng lương:
1. Kiểm tra kết nối database
2. Verify bảng `CheckIn` có dữ liệu
3. Confirm structure của bảng database
4. Test với dữ liệu demo trước

---
**Phiên bản**: 1.0  
**Ngày tạo**: 2024  
**Tác giả**: QuanLyNhanSu Development Team 