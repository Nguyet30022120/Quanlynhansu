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
			this.btn_themhoso = new System.Windows.Forms.Button();
			this.btn_suahoso = new System.Windows.Forms.Button();
			this.btn_xoahoso = new System.Windows.Forms.Button();
			this.btn_donghoso = new System.Windows.Forms.Button();
			this.btn_tiepnhan = new System.Windows.Forms.Button();
			this.btn_timhoso = new System.Windows.Forms.Button();
			this.lb_chucvu = new System.Windows.Forms.Label();
			this.txb_hoten = new System.Windows.Forms.TextBox();
			this.txb_dienthoai = new System.Windows.Forms.TextBox();
			this.txb_chitietcv = new System.Windows.Forms.TextBox();
			this.cb_nguonungvien = new System.Windows.Forms.ComboBox();
			this.cb_chucvu = new System.Windows.Forms.ComboBox();
			this.txb_findhs = new System.Windows.Forms.TextBox();
			this.dtp_ngaysinh = new System.Windows.Forms.DateTimePicker();
			this.lb_email = new System.Windows.Forms.Label();
			this.txb_email = new System.Windows.Forms.TextBox();
			this.cb_gioitinh = new System.Windows.Forms.ComboBox();
			this.panel1 = new System.Windows.Forms.Panel();
			this.lb_goiy = new System.Windows.Forms.Label();
			this.Ma_HS = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NgaySinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DienThoai = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ChiTietCV = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NguonUV = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ChucVu = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Email = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.GioiTinh = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dgv_hoso)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// lb_hoten
			// 
			this.lb_hoten.AutoSize = true;
			this.lb_hoten.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_hoten.Location = new System.Drawing.Point(30, 15);
			this.lb_hoten.Name = "lb_hoten";
			this.lb_hoten.Size = new System.Drawing.Size(58, 20);
			this.lb_hoten.TabIndex = 0;
			this.lb_hoten.Text = "Họ Tên";
			// 
			// lb_ngaysinh
			// 
			this.lb_ngaysinh.AutoSize = true;
			this.lb_ngaysinh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_ngaysinh.Location = new System.Drawing.Point(30, 95);
			this.lb_ngaysinh.Name = "lb_ngaysinh";
			this.lb_ngaysinh.Size = new System.Drawing.Size(80, 20);
			this.lb_ngaysinh.TabIndex = 1;
			this.lb_ngaysinh.Text = "Ngày Sinh";
			// 
			// lb_gioitinh
			// 
			this.lb_gioitinh.AutoSize = true;
			this.lb_gioitinh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_gioitinh.Location = new System.Drawing.Point(30, 55);
			this.lb_gioitinh.Name = "lb_gioitinh";
			this.lb_gioitinh.Size = new System.Drawing.Size(72, 20);
			this.lb_gioitinh.TabIndex = 2;
			this.lb_gioitinh.Text = "Giới Tính";
			// 
			// lb_dienthoai
			// 
			this.lb_dienthoai.AutoSize = true;
			this.lb_dienthoai.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_dienthoai.Location = new System.Drawing.Point(30, 135);
			this.lb_dienthoai.Name = "lb_dienthoai";
			this.lb_dienthoai.Size = new System.Drawing.Size(84, 20);
			this.lb_dienthoai.TabIndex = 3;
			this.lb_dienthoai.Text = "Điện Thoại";
			// 
			// lb_chitietcv
			// 
			this.lb_chitietcv.AutoSize = true;
			this.lb_chitietcv.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_chitietcv.Location = new System.Drawing.Point(487, 135);
			this.lb_chitietcv.Name = "lb_chitietcv";
			this.lb_chitietcv.Size = new System.Drawing.Size(82, 20);
			this.lb_chitietcv.TabIndex = 6;
			this.lb_chitietcv.Text = "Chi tiết CV";
			// 
			// lb_nguonungvien
			// 
			this.lb_nguonungvien.AutoSize = true;
			this.lb_nguonungvien.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_nguonungvien.Location = new System.Drawing.Point(487, 55);
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
            this.NgaySinh,
            this.DienThoai,
            this.ChiTietCV,
            this.NguonUV,
            this.ChucVu,
            this.Email,
            this.GioiTinh});
			this.dgv_hoso.Location = new System.Drawing.Point(3, 240);
			this.dgv_hoso.Name = "dgv_hoso";
			this.dgv_hoso.RowHeadersWidth = 51;
			this.dgv_hoso.RowTemplate.Height = 24;
			this.dgv_hoso.Size = new System.Drawing.Size(1475, 534);
			this.dgv_hoso.TabIndex = 8;
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
			// 
			// btn_tiepnhan
			// 
			this.btn_tiepnhan.BackColor = System.Drawing.Color.DarkOrange;
			this.btn_tiepnhan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_tiepnhan.Location = new System.Drawing.Point(1035, 125);
			this.btn_tiepnhan.Name = "btn_tiepnhan";
			this.btn_tiepnhan.Size = new System.Drawing.Size(115, 40);
			this.btn_tiepnhan.TabIndex = 14;
			this.btn_tiepnhan.Text = "Tiếp nhận";
			this.btn_tiepnhan.UseVisualStyleBackColor = false;
			this.btn_tiepnhan.Click += new System.EventHandler(this.btn_tiepnhan_Click);
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
			// 
			// lb_chucvu
			// 
			this.lb_chucvu.AutoSize = true;
			this.lb_chucvu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_chucvu.Location = new System.Drawing.Point(487, 95);
			this.lb_chucvu.Name = "lb_chucvu";
			this.lb_chucvu.Size = new System.Drawing.Size(141, 20);
			this.lb_chucvu.TabIndex = 16;
			this.lb_chucvu.Text = "Chức vụ ứng tuyển";
			// 
			// txb_hoten
			// 
			this.txb_hoten.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txb_hoten.Location = new System.Drawing.Point(140, 15);
			this.txb_hoten.Name = "txb_hoten";
			this.txb_hoten.ReadOnly = true;
			this.txb_hoten.Size = new System.Drawing.Size(252, 27);
			this.txb_hoten.TabIndex = 17;
			this.txb_hoten.TextChanged += new System.EventHandler(this.btn_findhs_Click);
			// 
			// txb_dienthoai
			// 
			this.txb_dienthoai.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txb_dienthoai.Location = new System.Drawing.Point(140, 135);
			this.txb_dienthoai.Name = "txb_dienthoai";
			this.txb_dienthoai.Size = new System.Drawing.Size(252, 27);
			this.txb_dienthoai.TabIndex = 18;
			// 
			// txb_chitietcv
			// 
			this.txb_chitietcv.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txb_chitietcv.Location = new System.Drawing.Point(670, 132);
			this.txb_chitietcv.Name = "txb_chitietcv";
			this.txb_chitietcv.Size = new System.Drawing.Size(252, 27);
			this.txb_chitietcv.TabIndex = 21;
			// 
			// cb_nguonungvien
			// 
			this.cb_nguonungvien.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cb_nguonungvien.FormattingEnabled = true;
			this.cb_nguonungvien.Location = new System.Drawing.Point(670, 55);
			this.cb_nguonungvien.Name = "cb_nguonungvien";
			this.cb_nguonungvien.Size = new System.Drawing.Size(252, 28);
			this.cb_nguonungvien.TabIndex = 22;
			// 
			// cb_chucvu
			// 
			this.cb_chucvu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cb_chucvu.FormattingEnabled = true;
			this.cb_chucvu.Location = new System.Drawing.Point(670, 95);
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
			this.dtp_ngaysinh.Location = new System.Drawing.Point(140, 95);
			this.dtp_ngaysinh.Name = "dtp_ngaysinh";
			this.dtp_ngaysinh.Size = new System.Drawing.Size(252, 27);
			this.dtp_ngaysinh.TabIndex = 25;
			// 
			// lb_email
			// 
			this.lb_email.AutoSize = true;
			this.lb_email.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_email.Location = new System.Drawing.Point(487, 15);
			this.lb_email.Name = "lb_email";
			this.lb_email.Size = new System.Drawing.Size(47, 20);
			this.lb_email.TabIndex = 26;
			this.lb_email.Text = "Email";
			// 
			// txb_email
			// 
			this.txb_email.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txb_email.Location = new System.Drawing.Point(670, 15);
			this.txb_email.Name = "txb_email";
			this.txb_email.Size = new System.Drawing.Size(252, 27);
			this.txb_email.TabIndex = 27;
			// 
			// cb_gioitinh
			// 
			this.cb_gioitinh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cb_gioitinh.FormattingEnabled = true;
			this.cb_gioitinh.Location = new System.Drawing.Point(140, 55);
			this.cb_gioitinh.Name = "cb_gioitinh";
			this.cb_gioitinh.Size = new System.Drawing.Size(252, 28);
			this.cb_gioitinh.TabIndex = 28;
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.lb_goiy);
			this.panel1.Controls.Add(this.btn_tiepnhan);
			this.panel1.Controls.Add(this.txb_email);
			this.panel1.Controls.Add(this.cb_gioitinh);
			this.panel1.Controls.Add(this.btn_themhoso);
			this.panel1.Controls.Add(this.btn_suahoso);
			this.panel1.Controls.Add(this.btn_xoahoso);
			this.panel1.Controls.Add(this.lb_ngaysinh);
			this.panel1.Controls.Add(this.btn_donghoso);
			this.panel1.Controls.Add(this.lb_gioitinh);
			this.panel1.Controls.Add(this.txb_chitietcv);
			this.panel1.Controls.Add(this.cb_nguonungvien);
			this.panel1.Controls.Add(this.cb_chucvu);
			this.panel1.Controls.Add(this.txb_findhs);
			this.panel1.Controls.Add(this.lb_email);
			this.panel1.Controls.Add(this.txb_hoten);
			this.panel1.Controls.Add(this.dtp_ngaysinh);
			this.panel1.Controls.Add(this.lb_chucvu);
			this.panel1.Controls.Add(this.lb_hoten);
			this.panel1.Controls.Add(this.btn_timhoso);
			this.panel1.Controls.Add(this.txb_dienthoai);
			this.panel1.Controls.Add(this.lb_dienthoai);
			this.panel1.Controls.Add(this.lb_nguonungvien);
			this.panel1.Controls.Add(this.lb_chitietcv);
			this.panel1.Location = new System.Drawing.Point(3, 3);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1475, 231);
			this.panel1.TabIndex = 29;
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
			// Ma_HS
			// 
			this.Ma_HS.DataPropertyName = "MaHS";
			this.Ma_HS.FillWeight = 125F;
			this.Ma_HS.HeaderText = "Mã hồ sơ";
			this.Ma_HS.MinimumWidth = 6;
			this.Ma_HS.Name = "Ma_HS";
			this.Ma_HS.Width = 125;
			// 
			// HoTen
			// 
			this.HoTen.DataPropertyName = "HoTen";
			this.HoTen.HeaderText = "Tên ứng viên";
			this.HoTen.MinimumWidth = 6;
			this.HoTen.Name = "HoTen";
			this.HoTen.Width = 200;
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
			this.NguonUV.Width = 150;
			// 
			// ChucVu
			// 
			this.ChucVu.DataPropertyName = "ChucVu";
			this.ChucVu.FillWeight = 150F;
			this.ChucVu.HeaderText = "Chức vụ ứng tuyển";
			this.ChucVu.MinimumWidth = 6;
			this.ChucVu.Name = "ChucVu";
			this.ChucVu.Width = 200;
			// 
			// Email
			// 
			this.Email.DataPropertyName = "Email";
			this.Email.HeaderText = "Email";
			this.Email.MinimumWidth = 6;
			this.Email.Name = "Email";
			this.Email.Width = 200;
			// 
			// GioiTinh
			// 
			this.GioiTinh.DataPropertyName = "GioiTinh";
			this.GioiTinh.FillWeight = 125F;
			this.GioiTinh.HeaderText = "Giới tính";
			this.GioiTinh.MinimumWidth = 6;
			this.GioiTinh.Name = "GioiTinh";
			this.GioiTinh.Width = 6;
			// 
			// fQuanlyhosoungvien
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.BlanchedAlmond;
			this.ClientSize = new System.Drawing.Size(1482, 778);
			this.Controls.Add(this.dgv_hoso);
			this.Controls.Add(this.panel1);
			this.Name = "fQuanlyhosoungvien";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
			this.Text = "Quản lý hồ sơ ứng viên";
			((System.ComponentModel.ISupportInitialize)(this.dgv_hoso)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
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
		private System.Windows.Forms.TextBox txb_hoten;
		private System.Windows.Forms.TextBox txb_dienthoai;
		private System.Windows.Forms.TextBox txb_chitietcv;
		private System.Windows.Forms.ComboBox cb_nguonungvien;
		private System.Windows.Forms.ComboBox cb_chucvu;
		private System.Windows.Forms.TextBox txb_findhs;
		private System.Windows.Forms.DateTimePicker dtp_ngaysinh;
		private System.Windows.Forms.Label lb_email;
		private System.Windows.Forms.TextBox txb_email;
		private System.Windows.Forms.ComboBox cb_gioitinh;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label lb_goiy;
		private System.Windows.Forms.DataGridViewTextBoxColumn Ma_HS;
		private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
		private System.Windows.Forms.DataGridViewTextBoxColumn NgaySinh;
		private System.Windows.Forms.DataGridViewTextBoxColumn DienThoai;
		private System.Windows.Forms.DataGridViewTextBoxColumn ChiTietCV;
		private System.Windows.Forms.DataGridViewTextBoxColumn NguonUV;
		private System.Windows.Forms.DataGridViewTextBoxColumn ChucVu;
		private System.Windows.Forms.DataGridViewTextBoxColumn Email;
		private System.Windows.Forms.DataGridViewTextBoxColumn GioiTinh;
	}
}