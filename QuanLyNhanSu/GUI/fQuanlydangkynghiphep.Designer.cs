namespace QuanLyNhanSu.GUI
{
	partial class fQuanlydangkynghiphep
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
			this.lb_loaiphep = new System.Windows.Forms.Label();
			this.lb_ngaybatdau = new System.Windows.Forms.Label();
			this.lb_ngayketthuc = new System.Windows.Forms.Label();
			this.lb_lydo = new System.Windows.Forms.Label();
			this.lb_trangthai = new System.Windows.Forms.Label();
			this.lb_tennhanvien = new System.Windows.Forms.Label();
			this.lb_nguoiduyet = new System.Windows.Forms.Label();
			this.txb_tennhanvien = new System.Windows.Forms.TextBox();
			this.cb_loaiphep = new System.Windows.Forms.ComboBox();
			this.cb_trangthai = new System.Windows.Forms.ComboBox();
			this.txb_nguoiduyet = new System.Windows.Forms.TextBox();
			this.txb_lydo = new System.Windows.Forms.TextBox();
			this.dtp_ngaybatdau = new System.Windows.Forms.DateTimePicker();
			this.dtp_ngayketthuc = new System.Windows.Forms.DateTimePicker();
			this.dgv_donnghiphep = new System.Windows.Forms.DataGridView();
			this.btn_themdonnghiphep = new System.Windows.Forms.Button();
			this.btn_suadonnghiphep = new System.Windows.Forms.Button();
			this.btn_xoadonnghiphep = new System.Windows.Forms.Button();
			this.btn_dongdonnghiphep = new System.Windows.Forms.Button();
			this.txb_manhanvien = new System.Windows.Forms.TextBox();
			this.lb_manhanvien = new System.Windows.Forms.Label();
			this.btn_timnhanvien = new System.Windows.Forms.Button();
			this.MaDonNghiPhep = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.LoaiPhep = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.LyDo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NguoiDuyet = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NgayBD = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NgayKT = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SoNgay = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NgayTao = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dgv_donnghiphep)).BeginInit();
			this.SuspendLayout();
			// 
			// lb_loaiphep
			// 
			this.lb_loaiphep.AutoSize = true;
			this.lb_loaiphep.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_loaiphep.Location = new System.Drawing.Point(20, 100);
			this.lb_loaiphep.Name = "lb_loaiphep";
			this.lb_loaiphep.Size = new System.Drawing.Size(77, 20);
			this.lb_loaiphep.TabIndex = 1;
			this.lb_loaiphep.Text = "Loại phép";
			// 
			// lb_ngaybatdau
			// 
			this.lb_ngaybatdau.AutoSize = true;
			this.lb_ngaybatdau.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_ngaybatdau.Location = new System.Drawing.Point(20, 140);
			this.lb_ngaybatdau.Name = "lb_ngaybatdau";
			this.lb_ngaybatdau.Size = new System.Drawing.Size(66, 20);
			this.lb_ngaybatdau.TabIndex = 2;
			this.lb_ngaybatdau.Text = "Từ ngày";
			// 
			// lb_ngayketthuc
			// 
			this.lb_ngayketthuc.AutoSize = true;
			this.lb_ngayketthuc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_ngayketthuc.Location = new System.Drawing.Point(20, 180);
			this.lb_ngayketthuc.Name = "lb_ngayketthuc";
			this.lb_ngayketthuc.Size = new System.Drawing.Size(75, 20);
			this.lb_ngayketthuc.TabIndex = 3;
			this.lb_ngayketthuc.Text = "Đến ngày";
			// 
			// lb_lydo
			// 
			this.lb_lydo.AutoSize = true;
			this.lb_lydo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_lydo.Location = new System.Drawing.Point(425, 100);
			this.lb_lydo.Name = "lb_lydo";
			this.lb_lydo.Size = new System.Drawing.Size(47, 20);
			this.lb_lydo.TabIndex = 4;
			this.lb_lydo.Text = "Lý do";
			// 
			// lb_trangthai
			// 
			this.lb_trangthai.AutoSize = true;
			this.lb_trangthai.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_trangthai.Location = new System.Drawing.Point(425, 140);
			this.lb_trangthai.Name = "lb_trangthai";
			this.lb_trangthai.Size = new System.Drawing.Size(80, 20);
			this.lb_trangthai.TabIndex = 5;
			this.lb_trangthai.Text = "Trạng thái";
			// 
			// lb_tennhanvien
			// 
			this.lb_tennhanvien.AutoSize = true;
			this.lb_tennhanvien.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_tennhanvien.Location = new System.Drawing.Point(20, 60);
			this.lb_tennhanvien.Name = "lb_tennhanvien";
			this.lb_tennhanvien.Size = new System.Drawing.Size(106, 20);
			this.lb_tennhanvien.TabIndex = 0;
			this.lb_tennhanvien.Text = "Tên nhân viên";
			// 
			// lb_nguoiduyet
			// 
			this.lb_nguoiduyet.AutoSize = true;
			this.lb_nguoiduyet.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_nguoiduyet.Location = new System.Drawing.Point(425, 180);
			this.lb_nguoiduyet.Name = "lb_nguoiduyet";
			this.lb_nguoiduyet.Size = new System.Drawing.Size(97, 20);
			this.lb_nguoiduyet.TabIndex = 6;
			this.lb_nguoiduyet.Text = "Người duyệt";
			// 
			// txb_tennhanvien
			// 
			this.txb_tennhanvien.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txb_tennhanvien.Location = new System.Drawing.Point(140, 60);
			this.txb_tennhanvien.Name = "txb_tennhanvien";
			this.txb_tennhanvien.Size = new System.Drawing.Size(252, 27);
			this.txb_tennhanvien.TabIndex = 7;
			// 
			// cb_loaiphep
			// 
			this.cb_loaiphep.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cb_loaiphep.FormattingEnabled = true;
			this.cb_loaiphep.Location = new System.Drawing.Point(140, 100);
			this.cb_loaiphep.Name = "cb_loaiphep";
			this.cb_loaiphep.Size = new System.Drawing.Size(252, 28);
			this.cb_loaiphep.TabIndex = 8;
			// 
			// cb_trangthai
			// 
			this.cb_trangthai.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cb_trangthai.FormattingEnabled = true;
			this.cb_trangthai.Location = new System.Drawing.Point(539, 136);
			this.cb_trangthai.Name = "cb_trangthai";
			this.cb_trangthai.Size = new System.Drawing.Size(252, 28);
			this.cb_trangthai.TabIndex = 9;
			// 
			// txb_nguoiduyet
			// 
			this.txb_nguoiduyet.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txb_nguoiduyet.Location = new System.Drawing.Point(539, 180);
			this.txb_nguoiduyet.Name = "txb_nguoiduyet";
			this.txb_nguoiduyet.Size = new System.Drawing.Size(252, 27);
			this.txb_nguoiduyet.TabIndex = 10;
			// 
			// txb_lydo
			// 
			this.txb_lydo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txb_lydo.Location = new System.Drawing.Point(539, 98);
			this.txb_lydo.Name = "txb_lydo";
			this.txb_lydo.Size = new System.Drawing.Size(252, 27);
			this.txb_lydo.TabIndex = 11;
			// 
			// dtp_ngaybatdau
			// 
			this.dtp_ngaybatdau.CalendarFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtp_ngaybatdau.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtp_ngaybatdau.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtp_ngaybatdau.Location = new System.Drawing.Point(140, 142);
			this.dtp_ngaybatdau.Name = "dtp_ngaybatdau";
			this.dtp_ngaybatdau.Size = new System.Drawing.Size(252, 27);
			this.dtp_ngaybatdau.TabIndex = 12;
			// 
			// dtp_ngayketthuc
			// 
			this.dtp_ngayketthuc.CalendarFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtp_ngayketthuc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtp_ngayketthuc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtp_ngayketthuc.Location = new System.Drawing.Point(140, 180);
			this.dtp_ngayketthuc.Name = "dtp_ngayketthuc";
			this.dtp_ngayketthuc.Size = new System.Drawing.Size(252, 27);
			this.dtp_ngayketthuc.TabIndex = 13;
			// 
			// dgv_donnghiphep
			// 
			this.dgv_donnghiphep.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv_donnghiphep.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaDonNghiPhep,
            this.TenNV,
            this.MaNV,
            this.LoaiPhep,
            this.LyDo,
            this.TrangThai,
            this.NguoiDuyet,
            this.NgayBD,
            this.NgayKT,
            this.SoNgay,
            this.NgayTao});
			this.dgv_donnghiphep.Location = new System.Drawing.Point(12, 226);
			this.dgv_donnghiphep.Name = "dgv_donnghiphep";
			this.dgv_donnghiphep.RowHeadersWidth = 51;
			this.dgv_donnghiphep.RowTemplate.Height = 24;
			this.dgv_donnghiphep.Size = new System.Drawing.Size(958, 265);
			this.dgv_donnghiphep.TabIndex = 14;
			// 
			// btn_themdonnghiphep
			// 
			this.btn_themdonnghiphep.BackColor = System.Drawing.Color.DarkOrange;
			this.btn_themdonnghiphep.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_themdonnghiphep.Location = new System.Drawing.Point(827, 10);
			this.btn_themdonnghiphep.Name = "btn_themdonnghiphep";
			this.btn_themdonnghiphep.Size = new System.Drawing.Size(115, 40);
			this.btn_themdonnghiphep.TabIndex = 15;
			this.btn_themdonnghiphep.Text = "Thêm";
			this.btn_themdonnghiphep.UseVisualStyleBackColor = false;
			this.btn_themdonnghiphep.Click += new System.EventHandler(this.btn_adddonnghiphep_Click);
			// 
			// btn_suadonnghiphep
			// 
			this.btn_suadonnghiphep.BackColor = System.Drawing.Color.DarkOrange;
			this.btn_suadonnghiphep.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_suadonnghiphep.Location = new System.Drawing.Point(827, 50);
			this.btn_suadonnghiphep.Name = "btn_suadonnghiphep";
			this.btn_suadonnghiphep.Size = new System.Drawing.Size(115, 40);
			this.btn_suadonnghiphep.TabIndex = 16;
			this.btn_suadonnghiphep.Text = "Sửa";
			this.btn_suadonnghiphep.UseVisualStyleBackColor = false;
			this.btn_suadonnghiphep.Click += new System.EventHandler(this.btn_editdonnghiphep_Click);
			// 
			// btn_xoadonnghiphep
			// 
			this.btn_xoadonnghiphep.BackColor = System.Drawing.Color.DarkOrange;
			this.btn_xoadonnghiphep.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_xoadonnghiphep.Location = new System.Drawing.Point(827, 90);
			this.btn_xoadonnghiphep.Name = "btn_xoadonnghiphep";
			this.btn_xoadonnghiphep.Size = new System.Drawing.Size(115, 40);
			this.btn_xoadonnghiphep.TabIndex = 17;
			this.btn_xoadonnghiphep.Text = "Xóa";
			this.btn_xoadonnghiphep.UseVisualStyleBackColor = false;
			this.btn_xoadonnghiphep.Click += new System.EventHandler(this.btn_deletedonnghiphep_Click);
			// 
			// btn_dongdonnghiphep
			// 
			this.btn_dongdonnghiphep.BackColor = System.Drawing.Color.DarkOrange;
			this.btn_dongdonnghiphep.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_dongdonnghiphep.Location = new System.Drawing.Point(827, 130);
			this.btn_dongdonnghiphep.Name = "btn_dongdonnghiphep";
			this.btn_dongdonnghiphep.Size = new System.Drawing.Size(115, 40);
			this.btn_dongdonnghiphep.TabIndex = 18;
			this.btn_dongdonnghiphep.Text = "Đóng";
			this.btn_dongdonnghiphep.UseVisualStyleBackColor = false;
			this.btn_dongdonnghiphep.Click += new System.EventHandler(this.btn_closedonnghiphep_Click);
			// 
			// txb_manhanvien
			// 
			this.txb_manhanvien.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txb_manhanvien.Location = new System.Drawing.Point(140, 20);
			this.txb_manhanvien.Name = "txb_manhanvien";
			this.txb_manhanvien.Size = new System.Drawing.Size(252, 27);
			this.txb_manhanvien.TabIndex = 19;
			// 
			// lb_manhanvien
			// 
			this.lb_manhanvien.AutoSize = true;
			this.lb_manhanvien.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_manhanvien.Location = new System.Drawing.Point(20, 20);
			this.lb_manhanvien.Name = "lb_manhanvien";
			this.lb_manhanvien.Size = new System.Drawing.Size(103, 20);
			this.lb_manhanvien.TabIndex = 20;
			this.lb_manhanvien.Text = "Mã nhân viên";
			// 
			// btn_timnhanvien
			// 
			this.btn_timnhanvien.BackColor = System.Drawing.Color.DarkOrange;
			this.btn_timnhanvien.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_timnhanvien.Location = new System.Drawing.Point(425, 15);
			this.btn_timnhanvien.Name = "btn_timnhanvien";
			this.btn_timnhanvien.Size = new System.Drawing.Size(115, 40);
			this.btn_timnhanvien.TabIndex = 21;
			this.btn_timnhanvien.Text = "Tìm kiếm";
			this.btn_timnhanvien.UseVisualStyleBackColor = false;
			this.btn_timnhanvien.Click += new System.EventHandler(this.btn_findnv_Click);
			// 
			// MaDonNghiPhep
			// 
			this.MaDonNghiPhep.DataPropertyName = "MaDonNghiPhep";
			this.MaDonNghiPhep.HeaderText = "Mã đơn";
			this.MaDonNghiPhep.MinimumWidth = 6;
			this.MaDonNghiPhep.Name = "MaDonNghiPhep";
			this.MaDonNghiPhep.Width = 50;
			// 
			// TenNV
			// 
			this.TenNV.DataPropertyName = "TenNV";
			this.TenNV.HeaderText = "Tên nhân viên";
			this.TenNV.MinimumWidth = 6;
			this.TenNV.Name = "TenNV";
			this.TenNV.Width = 125;
			// 
			// MaNV
			// 
			this.MaNV.DataPropertyName = "MaNV";
			this.MaNV.HeaderText = "Mã nhân viên";
			this.MaNV.MinimumWidth = 6;
			this.MaNV.Name = "MaNV";
			this.MaNV.Width = 50;
			// 
			// LoaiPhep
			// 
			this.LoaiPhep.DataPropertyName = "LoaiPhep";
			this.LoaiPhep.HeaderText = "Loại phép";
			this.LoaiPhep.MinimumWidth = 6;
			this.LoaiPhep.Name = "LoaiPhep";
			this.LoaiPhep.Width = 125;
			// 
			// LyDo
			// 
			this.LyDo.DataPropertyName = "LyDo";
			this.LyDo.HeaderText = "Lý do";
			this.LyDo.MinimumWidth = 6;
			this.LyDo.Name = "LyDo";
			this.LyDo.Width = 125;
			// 
			// TrangThai
			// 
			this.TrangThai.DataPropertyName = "TrangThai";
			this.TrangThai.HeaderText = "Trạng thái";
			this.TrangThai.MinimumWidth = 6;
			this.TrangThai.Name = "TrangThai";
			this.TrangThai.Width = 125;
			// 
			// NguoiDuyet
			// 
			this.NguoiDuyet.DataPropertyName = "NguoiDuyet";
			this.NguoiDuyet.HeaderText = "Người duyệt";
			this.NguoiDuyet.MinimumWidth = 6;
			this.NguoiDuyet.Name = "NguoiDuyet";
			this.NguoiDuyet.Width = 125;
			// 
			// NgayBD
			// 
			this.NgayBD.DataPropertyName = "NgayBD";
			this.NgayBD.HeaderText = "Ngày bắt đầu";
			this.NgayBD.MinimumWidth = 6;
			this.NgayBD.Name = "NgayBD";
			this.NgayBD.Width = 125;
			// 
			// NgayKT
			// 
			this.NgayKT.DataPropertyName = "NgayKT";
			this.NgayKT.HeaderText = "Ngày kết thúc";
			this.NgayKT.MinimumWidth = 6;
			this.NgayKT.Name = "NgayKT";
			this.NgayKT.Width = 125;
			// 
			// SoNgay
			// 
			this.SoNgay.DataPropertyName = "SoNgay";
			this.SoNgay.HeaderText = "Số ngày";
			this.SoNgay.MinimumWidth = 6;
			this.SoNgay.Name = "SoNgay";
			this.SoNgay.Width = 125;
			// 
			// NgayTao
			// 
			this.NgayTao.DataPropertyName = "NgayTao";
			this.NgayTao.HeaderText = "Ngày tạo";
			this.NgayTao.MinimumWidth = 6;
			this.NgayTao.Name = "NgayTao";
			this.NgayTao.Width = 125;
			// 
			// fQuanlydangkynghiphep
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.BlanchedAlmond;
			this.ClientSize = new System.Drawing.Size(982, 503);
			this.Controls.Add(this.btn_timnhanvien);
			this.Controls.Add(this.lb_manhanvien);
			this.Controls.Add(this.txb_manhanvien);
			this.Controls.Add(this.btn_dongdonnghiphep);
			this.Controls.Add(this.btn_xoadonnghiphep);
			this.Controls.Add(this.btn_suadonnghiphep);
			this.Controls.Add(this.btn_themdonnghiphep);
			this.Controls.Add(this.dgv_donnghiphep);
			this.Controls.Add(this.dtp_ngayketthuc);
			this.Controls.Add(this.dtp_ngaybatdau);
			this.Controls.Add(this.txb_lydo);
			this.Controls.Add(this.txb_nguoiduyet);
			this.Controls.Add(this.cb_trangthai);
			this.Controls.Add(this.cb_loaiphep);
			this.Controls.Add(this.txb_tennhanvien);
			this.Controls.Add(this.lb_nguoiduyet);
			this.Controls.Add(this.lb_trangthai);
			this.Controls.Add(this.lb_lydo);
			this.Controls.Add(this.lb_ngayketthuc);
			this.Controls.Add(this.lb_ngaybatdau);
			this.Controls.Add(this.lb_loaiphep);
			this.Controls.Add(this.lb_tennhanvien);
			this.Name = "fQuanlydangkynghiphep";
			this.Text = "Quản lý đăng ký nghỉ phép";
			((System.ComponentModel.ISupportInitialize)(this.dgv_donnghiphep)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lb_loaiphep;
		private System.Windows.Forms.Label lb_ngaybatdau;
		private System.Windows.Forms.Label lb_ngayketthuc;
		private System.Windows.Forms.Label lb_lydo;
		private System.Windows.Forms.Label lb_trangthai;
		private System.Windows.Forms.Label lb_tennhanvien;
		private System.Windows.Forms.Label lb_nguoiduyet;
		private System.Windows.Forms.TextBox txb_tennhanvien;
		private System.Windows.Forms.ComboBox cb_loaiphep;
		private System.Windows.Forms.ComboBox cb_trangthai;
		private System.Windows.Forms.TextBox txb_nguoiduyet;
		private System.Windows.Forms.TextBox txb_lydo;
		private System.Windows.Forms.DateTimePicker dtp_ngaybatdau;
		private System.Windows.Forms.DateTimePicker dtp_ngayketthuc;
		private System.Windows.Forms.DataGridView dgv_donnghiphep;
		private System.Windows.Forms.Button btn_themdonnghiphep;
		private System.Windows.Forms.Button btn_suadonnghiphep;
		private System.Windows.Forms.Button btn_xoadonnghiphep;
		private System.Windows.Forms.Button btn_dongdonnghiphep;
		private System.Windows.Forms.TextBox txb_manhanvien;
		private System.Windows.Forms.Label lb_manhanvien;
		private System.Windows.Forms.Button btn_timnhanvien;
		private System.Windows.Forms.DataGridViewTextBoxColumn MaDonNghiPhep;
		private System.Windows.Forms.DataGridViewTextBoxColumn TenNV;
		private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
		private System.Windows.Forms.DataGridViewTextBoxColumn LoaiPhep;
		private System.Windows.Forms.DataGridViewTextBoxColumn LyDo;
		private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai;
		private System.Windows.Forms.DataGridViewTextBoxColumn NguoiDuyet;
		private System.Windows.Forms.DataGridViewTextBoxColumn NgayBD;
		private System.Windows.Forms.DataGridViewTextBoxColumn NgayKT;
		private System.Windows.Forms.DataGridViewTextBoxColumn SoNgay;
		private System.Windows.Forms.DataGridViewTextBoxColumn NgayTao;
	}
}