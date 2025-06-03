using QuanLyNhanSu.DAO;
using QuanLyNhanSu.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace QuanLyNhanSu.GUI
{
    public partial class fBangluong : Form
    {
        private List<BangluongDTO> danhSachLuong;

        public fBangluong()
        {
            InitializeComponent();
            InitializeForm();
        }

        private void InitializeForm()
        {
            LoadComboBoxes();
            ConfigureDataGridView();
            LoadData();
        }

        private void LoadComboBoxes()
        {
            // Load tháng (1-12)
            cb_thang.Items.Clear();
            for (int i = 1; i <= 12; i++)
            {
                string thang = i < 10 ? "0" + i : i.ToString();
                cb_thang.Items.Add(new { Text = "Tháng " + thang, Value = i });
            }
            cb_thang.DisplayMember = "Text";
            cb_thang.ValueMember = "Value";
            cb_thang.SelectedIndex = DateTime.Now.Month - 1;

            // Load năm (2020 - hiện tại + 2)
            cb_nam.Items.Clear();
            int currentYear = DateTime.Now.Year;
            for (int i = 2020; i <= currentYear + 2; i++)
            {
                cb_nam.Items.Add(new { Text = "Năm " + i, Value = i });
            }
            cb_nam.DisplayMember = "Text";
            cb_nam.ValueMember = "Value";
            cb_nam.SelectedIndex = cb_nam.Items.Count - 3; // Chọn năm hiện tại

            // Load nhân viên
            LoadNhanVienComboBox();
        }

        private void LoadNhanVienComboBox()
        {
            try
            {
                cb_nhanvien.Items.Clear();
                cb_nhanvien.Items.Add(new { Text = "-- Tất cả nhân viên --", Value = "" });

                var listNhanVien = NhanvienDAO.Instance.GetInforNV();
                foreach (var nv in listNhanVien)
                {
                    string maNV = nv.MaNV;
                    string tenNV = nv.HoTen;
                    cb_nhanvien.Items.Add(new { Text = maNV + " - " + tenNV, Value = maNV });
                }

                cb_nhanvien.DisplayMember = "Text";
                cb_nhanvien.ValueMember = "Value";
                cb_nhanvien.SelectedIndex = 0;
            }
            catch (Exception ex)
            {
                // Nếu không load được từ DB, tạo dữ liệu test
                cb_nhanvien.Items.Clear();
                cb_nhanvien.Items.Add(new { Text = "-- Tất cả nhân viên --", Value = "" });
                cb_nhanvien.Items.Add(new { Text = "NV001 - Nguyễn Văn A", Value = "NV001" });
                cb_nhanvien.Items.Add(new { Text = "NV002 - Trần Thị B", Value = "NV002" });
                cb_nhanvien.Items.Add(new { Text = "NV003 - Lê Văn C", Value = "NV003" });
                cb_nhanvien.Items.Add(new { Text = "NV004 - Phạm Thị D", Value = "NV004" });
                cb_nhanvien.Items.Add(new { Text = "NV005 - Hoàng Văn E", Value = "NV005" });
                cb_nhanvien.DisplayMember = "Text";
                cb_nhanvien.ValueMember = "Value";
                cb_nhanvien.SelectedIndex = 0;
            }
        }

        private void ConfigureDataGridView()
        {
            dgv_bangluong.AutoGenerateColumns = false;
            dgv_bangluong.Columns.Clear();

            // Cấu hình các cột
            DataGridViewTextBoxColumn colMaNV = new DataGridViewTextBoxColumn();
            colMaNV.Name = "MaNV";
            colMaNV.HeaderText = "Mã NV";
            colMaNV.DataPropertyName = "MaNV";
            colMaNV.Width = 80;
            dgv_bangluong.Columns.Add(colMaNV);

            DataGridViewTextBoxColumn colTenNV = new DataGridViewTextBoxColumn();
            colTenNV.Name = "TenNV";
            colTenNV.HeaderText = "Tên nhân viên";
            colTenNV.DataPropertyName = "TenNV";
            colTenNV.Width = 150;
            dgv_bangluong.Columns.Add(colTenNV);

            DataGridViewTextBoxColumn colSoGio = new DataGridViewTextBoxColumn();
            colSoGio.Name = "SoGioLam";
            colSoGio.HeaderText = "Giờ làm";
            colSoGio.DataPropertyName = "SoGioLamDisplay";
            colSoGio.Width = 80;
            dgv_bangluong.Columns.Add(colSoGio);

            DataGridViewTextBoxColumn colLuongCB = new DataGridViewTextBoxColumn();
            colLuongCB.Name = "LuongCoBan";
            colLuongCB.HeaderText = "Lương cơ bản";
            colLuongCB.DataPropertyName = "LuongCoBanDisplay";
            colLuongCB.Width = 120;
            dgv_bangluong.Columns.Add(colLuongCB);

            DataGridViewTextBoxColumn colHeSo = new DataGridViewTextBoxColumn();
            colHeSo.Name = "HeSoNgay";
            colHeSo.HeaderText = "Hệ số";
            colHeSo.DataPropertyName = "HeSoNgayDisplay";
            colHeSo.Width = 70;
            dgv_bangluong.Columns.Add(colHeSo);

            // Thêm cột phụ cấp
            DataGridViewTextBoxColumn colPhucCap = new DataGridViewTextBoxColumn();
            colPhucCap.Name = "PhucCap";
            colPhucCap.HeaderText = "Phụ cấp";
            colPhucCap.DataPropertyName = "PhucCapDisplay";
            colPhucCap.Width = 100;
            colPhucCap.DefaultCellStyle.ForeColor = Color.Green;
            dgv_bangluong.Columns.Add(colPhucCap);

            DataGridViewTextBoxColumn colBaoHiem = new DataGridViewTextBoxColumn();
            colBaoHiem.Name = "BaoHiem";
            colBaoHiem.HeaderText = "Bảo hiểm";
            colBaoHiem.DataPropertyName = "BaoHiemDisplay";
            colBaoHiem.Width = 100;
            dgv_bangluong.Columns.Add(colBaoHiem);

            DataGridViewTextBoxColumn colThue = new DataGridViewTextBoxColumn();
            colThue.Name = "Thue";
            colThue.HeaderText = "Thuế";
            colThue.DataPropertyName = "ThueDisplay";
            colThue.Width = 100;
            dgv_bangluong.Columns.Add(colThue);

            DataGridViewTextBoxColumn colPhat = new DataGridViewTextBoxColumn();
            colPhat.Name = "Phat";
            colPhat.HeaderText = "Phạt";
            colPhat.DataPropertyName = "PhatDisplay";
            colPhat.Width = 100;
            dgv_bangluong.Columns.Add(colPhat);

            DataGridViewTextBoxColumn colThuong = new DataGridViewTextBoxColumn();
            colThuong.Name = "Thuong";
            colThuong.HeaderText = "Thưởng";
            colThuong.DataPropertyName = "ThuongDisplay";
            colThuong.Width = 100;
            dgv_bangluong.Columns.Add(colThuong);

            DataGridViewTextBoxColumn colLuongThucLinh = new DataGridViewTextBoxColumn();
            colLuongThucLinh.Name = "LuongThucLinh";
            colLuongThucLinh.HeaderText = "Lương thực lĩnh";
            colLuongThucLinh.DataPropertyName = "LuongThucLinhDisplay";
            colLuongThucLinh.Width = 130;
            colLuongThucLinh.DefaultCellStyle.ForeColor = Color.Blue;
            colLuongThucLinh.DefaultCellStyle.Font = new Font(dgv_bangluong.Font, FontStyle.Bold);
            dgv_bangluong.Columns.Add(colLuongThucLinh);

            // Cấu hình giao diện
            dgv_bangluong.AlternatingRowsDefaultCellStyle.BackColor = Color.LightBlue;
            dgv_bangluong.ColumnHeadersDefaultCellStyle.BackColor = Color.Navy;
            dgv_bangluong.ColumnHeadersDefaultCellStyle.ForeColor = Color.White;
            dgv_bangluong.ColumnHeadersDefaultCellStyle.Font = new Font(dgv_bangluong.Font, FontStyle.Bold);
        }

        private void LoadData()
        {
            if (cb_thang.SelectedItem == null || cb_nam.SelectedItem == null) return;

            int thang = (int)((dynamic)cb_thang.SelectedItem).Value;
            int nam = (int)((dynamic)cb_nam.SelectedItem).Value;
            string maNV = cb_nhanvien.SelectedItem != null ? ((dynamic)cb_nhanvien.SelectedItem).Value.ToString() : "";

            try
            {
                if (string.IsNullOrEmpty(maNV))
                {
                    // Load tất cả nhân viên
                    danhSachLuong = BangluongDAO.Instance.TinhLuongTheoThang(thang, nam);
                }
                else
                {
                    // Load một nhân viên cụ thể
                    var luongNV = BangluongDAO.Instance.TinhLuongNhanVien(maNV, thang, nam);
                    danhSachLuong = luongNV != null ? new List<BangluongDTO> { luongNV } : new List<BangluongDTO>();
                }

                dgv_bangluong.DataSource = danhSachLuong;
                UpdateStatistics();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi tải dữ liệu: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateStatistics()
        {
            if (danhSachLuong == null || danhSachLuong.Count == 0)
            {
                lbl_tongnhanvien.Text = "0";
                lbl_tongluong.Text = "0 VNĐ";
                lbl_luongtrungbinh.Text = "0 VNĐ";
                lbl_luongcaonhat.Text = "0 VNĐ";
                lbl_luongthapnhat.Text = "0 VNĐ";
                return;
            }

            int tongNV = danhSachLuong.Count;
            decimal tongLuong = danhSachLuong.Sum(x => x.LuongThucLinh);
            decimal luongTB = tongLuong / tongNV;
            decimal luongMax = danhSachLuong.Max(x => x.LuongThucLinh);
            decimal luongMin = danhSachLuong.Min(x => x.LuongThucLinh);

            lbl_tongnhanvien.Text = tongNV.ToString();
            lbl_tongluong.Text = tongLuong.ToString("N0") + " VNĐ";
            lbl_luongtrungbinh.Text = luongTB.ToString("N0") + " VNĐ";
            lbl_luongcaonhat.Text = luongMax.ToString("N0") + " VNĐ";
            lbl_luongthapnhat.Text = luongMin.ToString("N0") + " VNĐ";
        }

        private void btn_tinhluong_Click(object sender, EventArgs e)
        {
            LoadData();
            MessageBox.Show("Đã tính lương thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btn_xuatbaocao_Click(object sender, EventArgs e)
        {
            if (danhSachLuong == null || danhSachLuong.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để xuất báo cáo!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            SaveFileDialog saveDialog = new SaveFileDialog();
            saveDialog.Filter = "CSV files (*.csv)|*.csv|All files (*.*)|*.*";
            saveDialog.FileName = $"BangLuong_{cb_thang.Text}_{cb_nam.Text}_{DateTime.Now:yyyyMMdd_HHmmss}.csv";
            
            if (saveDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    ExportToCSV(saveDialog.FileName);
                    MessageBox.Show("Xuất báo cáo thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi xuất báo cáo: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void ExportToCSV(string filePath)
        {
            StringBuilder csv = new StringBuilder();
            
            // Header thông tin
            csv.AppendLine($"BẢNG LƯƠNG {cb_thang.Text.ToUpper()} {cb_nam.Text}");
            csv.AppendLine($"Ngày xuất: {DateTime.Now:dd/MM/yyyy HH:mm:ss}");
            csv.AppendLine("");

            // Header columns
            csv.AppendLine("Mã NV,Tên nhân viên,Giờ làm,Lương cơ bản,Hệ số,Phụ cấp,Bảo hiểm,Thuế,Phạt,Thưởng,Lương thực lĩnh");

            // Data rows
            foreach (var luong in danhSachLuong)
            {
                csv.AppendLine($"{luong.MaNV},{luong.TenNV},{luong.SoGioLam},{luong.LuongCoBan},{luong.HeSoNgay},{luong.PhucCap},{luong.BaoHiem},{luong.Thue},{luong.Phat},{luong.Thuong},{luong.LuongThucLinh}");
            }

            // Statistics
            csv.AppendLine("");
            csv.AppendLine("THỐNG KÊ");
            csv.AppendLine($"Tổng nhân viên,{lbl_tongnhanvien.Text}");
            csv.AppendLine($"Tổng lương,{lbl_tongluong.Text}");
            csv.AppendLine($"Lương trung bình,{lbl_luongtrungbinh.Text}");
            csv.AppendLine($"Lương cao nhất,{lbl_luongcaonhat.Text}");
            csv.AppendLine($"Lương thấp nhất,{lbl_luongthapnhat.Text}");

            File.WriteAllText(filePath, csv.ToString(), Encoding.UTF8);
        }

        private void btn_luubangluong_Click(object sender, EventArgs e)
        {
            if (danhSachLuong == null || danhSachLuong.Count == 0)
            {
                MessageBox.Show("Không có dữ liệu để lưu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult result = MessageBox.Show("Bạn có chắc chắn muốn lưu bảng lương này vào hệ thống?", 
                                                "Xác nhận", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            
            if (result == DialogResult.Yes)
            {
                try
                {
                    bool success = BangluongDAO.Instance.LuuBangLuong(danhSachLuong);
                    if (success)
                    {
                        MessageBox.Show("Lưu bảng lương thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Lưu bảng lương thất bại!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi khi lưu bảng lương: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cb_thang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_thang.SelectedItem != null && cb_nam.SelectedItem != null)
            {
                LoadData();
            }
        }

        private void cb_nam_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_thang.SelectedItem != null && cb_nam.SelectedItem != null)
            {
                LoadData();
            }
        }

        private void cb_nhanvien_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cb_thang.SelectedItem != null && cb_nam.SelectedItem != null)
            {
                LoadData();
            }
        }
    }
} 