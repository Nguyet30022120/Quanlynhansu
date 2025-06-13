namespace QuanLyNhanSu.GUI
{
	partial class fQuanlyhosoungvien
	{
		/// <summary>
		/// Required designer variable.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Clean up any resources being used.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Windows Form Designer generated code

		/// <summary>
		/// Required method for Designer support - do not modify
		/// the contents of this method with the code editor.
		/// </summary>
		private void InitializeComponent()
		{
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			this.lb_hoten = new System.Windows.Forms.Label();
			this.lb_ngaysinh = new System.Windows.Forms.Label();
			this.lb_gioitinh = new System.Windows.Forms.Label();
			this.lb_dienthoai = new System.Windows.Forms.Label();
			this.lb_chitietcv = new System.Windows.Forms.Label();
			this.lb_nguonungvien = new System.Windows.Forms.Label();
			this.dgv_hoso = new System.Windows.Forms.DataGridView();
			this.Ma_HS = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ChiTietCV = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NguonUV = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ChucVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btn_themhoso = new System.Windows.Forms.Button();
			this.btn_suahoso = new System.Windows.Forms.Button();
			this.btn_xoahoso = new System.Windows.Forms.Button();
			this.btn_donghoso = new System.Windows.Forms.Button();
			this.btn_tiepnhan = new System.Windows.Forms.Button();
			this.btn_timhoso = new System.Windows.Forms.Button();
			this.lb_chucvu = new System.Windows.Forms.Label();
			this.txb_dienthoai = new System.Windows.Forms.TextBox();
			this.txb_chitietcv = new System.Windows.Forms.TextBox();
			this.cb_nguonungvien = new System.Windows.Forms.ComboBox();
			this.cb_chucvu = new System.Windows.Forms.ComboBox();
			this.txb_findhs = new System.Windows.Forms.TextBox();
			this.dtp_ngaysinh = new System.Windows.Forms.DateTimePicker();
			this.lb_email = new System.Windows.Forms.Label();
			this.txb_email = new System.Windows.Forms.TextBox();
			this.cb_gioitinh = new System.Windows.Forms.ComboBox();
			this.pn_hosoungvien = new System.Windows.Forms.Panel();
			this.txb_hoten = new System.Windows.Forms.TextBox();
			this.lb_goiy = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dgv_hoso)).BeginInit();
			this.pn_hosoungvien.SuspendLayout();
			this.SuspendLayout();
			// 
			// lb_hoten
			// 
			this.lb_hoten.AutoSize = true;
			this.lb_hoten.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_hoten.Location = new System.Drawing.Point(30, 20);
			this.lb_hoten.Name = "lb_hoten";
			this.lb_hoten.Size = new System.Drawing.Size(58, 20);
			this.lb_hoten.TabIndex = 0;
			this.lb_hoten.Text = "Họ Tên";
			// 
			// lb_ngaysinh
			// 
			this.lb_ngaysinh.AutoSize = true;
			this.lb_ngaysinh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_ngaysinh.Location = new System.Drawing.Point(30, 100);
			this.lb_ngaysinh.Name = "lb_ngaysinh";
			this.lb_ngaysinh.Size = new System.Drawing.Size(80, 20);
			this.lb_ngaysinh.TabIndex = 1;
			this.lb_ngaysinh.Text = "Ngày Sinh";
			// 
			// lb_gioitinh
			// 
			this.lb_gioitinh.AutoSize = true;
			this.lb_gioitinh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_gioitinh.Location = new System.Drawing.Point(30, 60);
			this.lb_gioitinh.Name = "lb_gioitinh";
			this.lb_gioitinh.Size = new System.Drawing.Size(72, 20);
			this.lb_gioitinh.TabIndex = 2;
			this.lb_gioitinh.Text = "Giới Tính";
			// 
			// lb_dienthoai
			// 
			this.lb_dienthoai.AutoSize = true;
			this.lb_dienthoai.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_dienthoai.Location = new System.Drawing.Point(30, 140);
			this.lb_dienthoai.Name = "lb_dienthoai";
			this.lb_dienthoai.Size = new System.Drawing.Size(84, 20);
			this.lb_dienthoai.TabIndex = 3;
			this.lb_dienthoai.Text = "Điện Thoại";
			// 
			// lb_chitietcv
			// 
			this.lb_chitietcv.AutoSize = true;
			this.lb_chitietcv.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_chitietcv.Location = new System.Drawing.Point(575, 140);
			this.lb_chitietcv.Name = "lb_chitietcv";
			this.lb_chitietcv.Size = new System.Drawing.Size(82, 20);
			this.lb_chitietcv.TabIndex = 6;
			this.lb_chitietcv.Text = "Chi tiết CV";
			// 
			// lb_nguonungvien
			// 
			this.lb_nguonungvien.AutoSize = true;
			this.lb_nguonungvien.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_nguonungvien.Location = new System.Drawing.Point(575, 60);
			this.lb_nguonungvien.Name = "lb_nguonungvien";
			this.lb_nguonungvien.Size = new System.Drawing.Size(122, 20);
			this.lb_nguonungvien.TabIndex = 7;
			this.lb_nguonungvien.Text = "Nguồn ứng viên";
			// 
			// dgv_hoso
			// 
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.Tan;
			this.dgv_hoso.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dgv_hoso.BackgroundColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgv_hoso.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dgv_hoso.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv_hoso.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ma_HS,
            this.HoTen,
            this.TrangThai,
            this.GioiTinh,
            this.NgaySinh,
            this.DienThoai,
            this.ChiTietCV,
            this.NguonUV,
            this.ChucVu,
            this.Email});
			this.dgv_hoso.Location = new System.Drawing.Point(3, 240);
			this.dgv_hoso.Name = "dgv_hoso";
			this.dgv_hoso.RowHeadersWidth = 51;
			this.dgv_hoso.RowTemplate.Height = 24;
			this.dgv_hoso.Size = new System.Drawing.Size(1475, 534);
			this.dgv_hoso.TabIndex = 8;
			// 
			// Ma_HS
			// 
			this.Ma_HS.DataPropertyName = "MaHS";
			this.Ma_HS.FillWeight = 125F;
			this.Ma_HS.HeaderText = "Mã hồ sơ";
			this.Ma_HS.MinimumWidth = 6;
			this.Ma_HS.Name = "Ma_HS";
			this.Ma_HS.Width = 75;
			// 
			// HoTen
			// 
			this.HoTen.DataPropertyName = "HoTen";
			this.HoTen.HeaderText = "Tên ứng viên";
			this.HoTen.MinimumWidth = 6;
			this.HoTen.Name = "HoTen";
			this.HoTen.Width = 125;
			// 
			// TrangThai
			// 
			this.TrangThai.DataPropertyName = "TrangThai";
			this.TrangThai.HeaderText = "Trạng thái";
			this.TrangThai.MinimumWidth = 6;
			this.TrangThai.Name = "TrangThai";
			this.TrangThai.Width = 125;
			// 
			// GioiTinh
			// 
			this.GioiTinh.DataPropertyName = "GioiTinh";
			this.GioiTinh.FillWeight = 125F;
			this.GioiTinh.HeaderText = "Giới tính";
			this.GioiTinh.MinimumWidth = 6;
			this.GioiTinh.Name = "GioiTinh";
			this.GioiTinh.Width = 50;
			// 
			// NgaySinh
			// 
			this.NgaySinh.DataPropertyName = "NgaySinh";
			this.NgaySinh.HeaderText = "Ngày sinh";
			this.NgaySinh.MinimumWidth = 6;
			this.NgaySinh.Name = "NgaySinh";
			this.NgaySinh.Width = 125;
			// 
			// DienThoai
			// 
			this.DienThoai.DataPropertyName = "DienThoai";
			this.DienThoai.HeaderText = "Điện thoại";
			this.DienThoai.MinimumWidth = 6;
			this.DienThoai.Name = "DienThoai";
			this.DienThoai.Width = 125;
			// 
			// ChiTietCV
			// 
			this.ChiTietCV.DataPropertyName = "ChiTietCV";
			this.ChiTietCV.HeaderText = "Chi tiết CV";
			this.ChiTietCV.MinimumWidth = 6;
			this.ChiTietCV.Name = "ChiTietCV";
			this.ChiTietCV.Width = 200;
			// 
			// NguonUV
			// 
			this.NguonUV.DataPropertyName = "NguonUV";
			this.NguonUV.HeaderText = "Nguồn ứng viên";
			this.NguonUV.MinimumWidth = 6;
			this.NguonUV.Name = "NguonUV";
			this.NguonUV.Width = 125;
			// 
			// ChucVu
			// 
			this.ChucVu.DataPropertyName = "ChucVu";
			this.ChucVu.FillWeight = 150F;
			this.ChucVu.HeaderText = "Chức vụ ứng tuyển";
			this.ChucVu.MinimumWidth = 6;
			this.ChucVu.Name = "ChucVu";
			this.ChucVu.Width = 125;
			// 
			// Email
			// 
			this.Email.DataPropertyName = "Email";
			this.Email.HeaderText = "Email";
			this.Email.MinimumWidth = 6;
			this.Email.Name = "Email";
			this.Email.Width = 200;
			// 
			// btn_themhoso
			// 
			this.btn_themhoso.BackColor = System.Drawing.Color.DarkOrange;
			this.btn_themhoso.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_themhoso.Location = new System.Drawing.Point(1352, 9);
			this.btn_themhoso.Name = "btn_themhoso";
			this.btn_themhoso.Size = new System.Drawing.Size(115, 40);
			this.btn_themhoso.TabIndex = 10;
			this.btn_themhoso.Text = "Thêm";
			this.btn_themhoso.UseVisualStyleBackColor = false;
			this.btn_themhoso.Click += new System.EventHandler(this.btn_addhs_Click);
			this.btn_themhoso.MouseEnter += new System.EventHandler(this.btn_addhs_MouseEnter);
			this.btn_themhoso.MouseLeave += new System.EventHandler(this.btn_addhs_MouseLeave);
			// 
			// btn_suahoso
			// 
			this.btn_suahoso.BackColor = System.Drawing.Color.DarkOrange;
			this.btn_suahoso.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_suahoso.Location = new System.Drawing.Point(1352, 49);
			this.btn_suahoso.Name = "btn_suahoso";
			this.btn_suahoso.Size = new System.Drawing.Size(115, 40);
			this.btn_suahoso.TabIndex = 11;
			this.btn_suahoso.Text = "Sửa";
			this.btn_suahoso.UseVisualStyleBackColor = false;
			this.btn_suahoso.Click += new System.EventHandler(this.btn_ediths_Click);
			this.btn_suahoso.MouseEnter += new System.EventHandler(this.btn_ediths_MouseEnter);
			this.btn_suahoso.MouseLeave += new System.EventHandler(this.btn_ediths_MouseLeave);
			// 
			// btn_xoahoso
			// 
			this.btn_xoahoso.BackColor = System.Drawing.Color.DarkOrange;
			this.btn_xoahoso.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_xoahoso.Location = new System.Drawing.Point(1352, 89);
			this.btn_xoahoso.Name = "btn_xoahoso";
			this.btn_xoahoso.Size = new System.Drawing.Size(115, 40);
			this.btn_xoahoso.TabIndex = 12;
			this.btn_xoahoso.Text = "Xóa";
			this.btn_xoahoso.UseVisualStyleBackColor = false;
			this.btn_xoahoso.Click += new System.EventHandler(this.btn_deletehs_Click);
			this.btn_xoahoso.MouseEnter += new System.EventHandler(this.btn_deletehs_MouseEnter);
			this.btn_xoahoso.MouseLeave += new System.EventHandler(this.btn_deletehs_MouseLeave);
			// 
			// btn_donghoso
			// 
			this.btn_donghoso.BackColor = System.Drawing.Color.DarkOrange;
			this.btn_donghoso.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_donghoso.Location = new System.Drawing.Point(1352, 129);
			this.btn_donghoso.Name = "btn_donghoso";
			this.btn_donghoso.Size = new System.Drawing.Size(115, 40);
			this.btn_donghoso.TabIndex = 13;
			this.btn_donghoso.Text = "Đóng";
			this.btn_donghoso.UseVisualStyleBackColor = false;
			this.btn_donghoso.Click += new System.EventHandler(this.btn_closehs_Click);
			this.btn_donghoso.MouseEnter += new System.EventHandler(this.btn_closehs_MouseEnter);
			this.btn_donghoso.MouseLeave += new System.EventHandler(this.btn_closehs_MouseLeave);
			// 
			// btn_tiepnhan
			// 
			this.btn_tiepnhan.BackColor = System.Drawing.Color.DarkOrange;
			this.btn_tiepnhan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_tiepnhan.Location = new System.Drawing.Point(1205, 128);
			this.btn_tiepnhan.Name = "btn_tiepnhan";
			this.btn_tiepnhan.Size = new System.Drawing.Size(115, 40);
			this.btn_tiepnhan.TabIndex = 14;
			this.btn_tiepnhan.Text = "Tiếp nhận";
			this.btn_tiepnhan.UseVisualStyleBackColor = false;
			this.btn_tiepnhan.Click += new System.EventHandler(this.btn_tiepnhan_Click);
			this.btn_tiepnhan.MouseEnter += new System.EventHandler(this.btn_tiepnhan_MouseEnter);
			this.btn_tiepnhan.MouseLeave += new System.EventHandler(this.btn_tiepnhan_MouseLeave);
			// 
			// btn_timhoso
			// 
			this.btn_timhoso.BackColor = System.Drawing.Color.DarkOrange;
			this.btn_timhoso.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_timhoso.Location = new System.Drawing.Point(1352, 169);
			this.btn_timhoso.Name = "btn_timhoso";
			this.btn_timhoso.Size = new System.Drawing.Size(115, 40);
			this.btn_timhoso.TabIndex = 15;
			this.btn_timhoso.Text = "Tìm kiếm";
			this.btn_timhoso.UseVisualStyleBackColor = false;
			this.btn_timhoso.Click += new System.EventHandler(this.btn_findhs_Click);
			this.btn_timhoso.MouseEnter += new System.EventHandler(this.btn_findhs_MouseEnter);
			this.btn_timhoso.MouseLeave += new System.EventHandler(this.btn_findhs_MouseLeave);
			// 
			// lb_chucvu
			// 
			this.lb_chucvu.AutoSize = true;
			this.lb_chucvu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_chucvu.Location = new System.Drawing.Point(575, 100);
			this.lb_chucvu.Name = "lb_chucvu";
			this.lb_chucvu.Size = new System.Drawing.Size(141, 20);
			this.lb_chucvu.TabIndex = 16;
			this.lb_chucvu.Text = "Chức vụ ứng tuyển";
			// 
			// txb_dienthoai
			// 
			this.txb_dienthoai.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txb_dienthoai.Location = new System.Drawing.Point(141, 139);
			this.txb_dienthoai.Name = "txb_dienthoai";
			this.txb_dienthoai.Size = new System.Drawing.Size(252, 27);
			this.txb_dienthoai.TabIndex = 18;
			// 
			// txb_chitietcv
			// 
			this.txb_chitietcv.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txb_chitietcv.Location = new System.Drawing.Point(760, 140);
			this.txb_chitietcv.Name = "txb_chitietcv";
			this.txb_chitietcv.Size = new System.Drawing.Size(252, 27);
			this.txb_chitietcv.TabIndex = 21;
			// 
			// cb_nguonungvien
			// 
			this.cb_nguonungvien.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cb_nguonungvien.FormattingEnabled = true;
			this.cb_nguonungvien.Location = new System.Drawing.Point(760, 60);
			this.cb_nguonungvien.Name = "cb_nguonungvien";
			this.cb_nguonungvien.Size = new System.Drawing.Size(252, 28);
			this.cb_nguonungvien.TabIndex = 22;
			// 
			// cb_chucvu
			// 
			this.cb_chucvu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cb_chucvu.FormattingEnabled = true;
			this.cb_chucvu.Location = new System.Drawing.Point(760, 100);
			this.cb_chucvu.Name = "cb_chucvu";
			this.cb_chucvu.Size = new System.Drawing.Size(252, 28);
			this.cb_chucvu.TabIndex = 23;
			// 
			// txb_findhs
			// 
			this.txb_findhs.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txb_findhs.Location = new System.Drawing.Point(34, 177);
			this.txb_findhs.Name = "txb_findhs";
			this.txb_findhs.Size = new System.Drawing.Size(1303, 27);
			this.txb_findhs.TabIndex = 24;
			// 
			// dtp_ngaysinh
			// 
			this.dtp_ngaysinh.CalendarFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtp_ngaysinh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtp_ngaysinh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtp_ngaysinh.Location = new System.Drawing.Point(140, 100);
			this.dtp_ngaysinh.Name = "dtp_ngaysinh";
			this.dtp_ngaysinh.Size = new System.Drawing.Size(252, 27);
			this.dtp_ngaysinh.TabIndex = 25;
			// 
			// lb_email
			// 
			this.lb_email.AutoSize = true;
			this.lb_email.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_email.Location = new System.Drawing.Point(575, 20);
			this.lb_email.Name = "lb_email";
			this.lb_email.Size = new System.Drawing.Size(47, 20);
			this.lb_email.TabIndex = 26;
			this.lb_email.Text = "Email";
			// 
			// txb_email
			// 
			this.txb_email.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txb_email.Location = new System.Drawing.Point(760, 20);
			this.txb_email.Name = "txb_email";
			this.txb_email.Size = new System.Drawing.Size(252, 27);
			this.txb_email.TabIndex = 27;
			// 
			// cb_gioitinh
			// 
			this.cb_gioitinh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cb_gioitinh.FormattingEnabled = true;
			this.cb_gioitinh.Location = new System.Drawing.Point(140, 60);
			this.cb_gioitinh.Name = "cb_gioitinh";
			this.cb_gioitinh.Size = new System.Drawing.Size(252, 28);
			this.cb_gioitinh.TabIndex = 28;
			// 
			// pn_hosoungvien
			// 
			this.pn_hosoungvien.Controls.Add(this.txb_hoten);
			this.pn_hosoungvien.Controls.Add(this.lb_goiy);
			this.pn_hosoungvien.Controls.Add(this.btn_tiepnhan);
			this.pn_hosoungvien.Controls.Add(this.txb_email);
			this.pn_hosoungvien.Controls.Add(this.cb_gioitinh);
			this.pn_hosoungvien.Controls.Add(this.btn_themhoso);
			this.pn_hosoungvien.Controls.Add(this.btn_suahoso);
			this.pn_hosoungvien.Controls.Add(this.btn_xoahoso);
			this.pn_hosoungvien.Controls.Add(this.lb_ngaysinh);
			this.pn_hosoungvien.Controls.Add(this.btn_donghoso);
			this.pn_hosoungvien.Controls.Add(this.lb_gioitinh);
			this.pn_hosoungvien.Controls.Add(this.txb_chitietcv);
			this.pn_hosoungvien.Controls.Add(this.cb_nguonungvien);
			this.pn_hosoungvien.Controls.Add(this.cb_chucvu);
			this.pn_hosoungvien.Controls.Add(this.txb_findhs);
			this.pn_hosoungvien.Controls.Add(this.lb_email);
			this.pn_hosoungvien.Controls.Add(this.dtp_ngaysinh);
			this.pn_hosoungvien.Controls.Add(this.lb_chucvu);
			this.pn_hosoungvien.Controls.Add(this.lb_hoten);
			this.pn_hosoungvien.Controls.Add(this.btn_timhoso);
			this.pn_hosoungvien.Controls.Add(this.txb_dienthoai);
			this.pn_hosoungvien.Controls.Add(this.lb_dienthoai);
			this.pn_hosoungvien.Controls.Add(this.lb_nguonungvien);
			this.pn_hosoungvien.Controls.Add(this.lb_chitietcv);
			this.pn_hosoungvien.Location = new System.Drawing.Point(3, 3);
			this.pn_hosoungvien.Name = "pn_hosoungvien";
			this.pn_hosoungvien.Size = new System.Drawing.Size(1475, 231);
			this.pn_hosoungvien.TabIndex = 29;
			// 
			// txb_hoten
			// 
			this.txb_hoten.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txb_hoten.Location = new System.Drawing.Point(140, 20);
			this.txb_hoten.Name = "txb_hoten";
			this.txb_hoten.Size = new System.Drawing.Size(252, 27);
			this.txb_hoten.TabIndex = 46;
			// 
			// lb_goiy
			// 
			this.lb_goiy.AutoSize = true;
			this.lb_goiy.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_goiy.Location = new System.Drawing.Point(32, 207);
			this.lb_goiy.Name = "lb_goiy";
			this.lb_goiy.Size = new System.Drawing.Size(227, 17);
			this.lb_goiy.TabIndex = 45;
			this.lb_goiy.Text = "(Tìm kiếm theo mã hồ sơ, tên ứng viên)";
			// 
			// fQuanlyhosoungvien
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.BlanchedAlmond;
			this.ClientSize = new System.Drawing.Size(1482, 778);
			this.Controls.Add(this.dgv_hoso);
			this.Controls.Add(this.pn_hosoungvien);
			this.Name = "fQuanlyhosoungvien";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Hồ sơ ứng viên";
			((System.ComponentModel.ISupportInitialize)(this.dgv_hoso)).EndInit();
			this.pn_hosoungvien.ResumeLayout(false);
			this.pn_hosoungvien.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label lb_hoten;
		private System.Windows.Forms.Label lb_ngaysinh;
		private System.Windows.Forms.Label lb_gioitinh;
		private System.Windows.Forms.Label lb_dienthoai;
		private System.Windows.Forms.Label lb_chitietcv;
		private System.Windows.Forms.Label lb_nguonungvien;
		private System.Windows.Forms.DataGridView dgv_hoso;
		private System.Windows.Forms.Button btn_themhoso;
		private System.Windows.Forms.Button btn_suahoso;
		private System.Windows.Forms.Button btn_xoahoso;
		private System.Windows.Forms.Button btn_donghoso;
		private System.Windows.Forms.Button btn_tiepnhan;
		private System.Windows.Forms.Button btn_timhoso;
		private System.Windows.Forms.Label lb_chucvu;
		private System.Windows.Forms.TextBox txb_dienthoai;
		private System.Windows.Forms.TextBox txb_chitietcv;
		private System.Windows.Forms.ComboBox cb_nguonungvien;
		private System.Windows.Forms.ComboBox cb_chucvu;
		private System.Windows.Forms.TextBox txb_findhs;
		private System.Windows.Forms.DateTimePicker dtp_ngaysinh;
		private System.Windows.Forms.Label lb_email;
		private System.Windows.Forms.TextBox txb_email;
		private System.Windows.Forms.ComboBox cb_gioitinh;
		private System.Windows.Forms.Panel pn_hosoungvien;
		private System.Windows.Forms.Label lb_goiy;
		private System.Windows.Forms.TextBox txb_hoten;
		private System.Windows.Forms.DataGridViewTextBoxColumn Ma_HS;
		private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
		private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai;
		private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
		private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinh;
		private System.Windows.Forms.DataGridViewTextBoxColumn DienThoai;
		private System.Windows.Forms.DataGridViewTextBoxColumn ChiTietCV;
		private System.Windows.Forms.DataGridViewTextBoxColumn NguonUV;
		private System.Windows.Forms.DataGridViewTextBoxColumn ChucVu;
		private System.Windows.Forms.DataGridViewTextBoxColumn Email;
	}
}