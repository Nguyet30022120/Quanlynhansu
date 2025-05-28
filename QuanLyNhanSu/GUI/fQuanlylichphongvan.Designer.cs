namespace QuanLyNhanSu.GUI
{
	partial class fQuanlylichphongvan
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
			this.lb_tenungvien = new System.Windows.Forms.Label();
			this.lb_ngayphongvan = new System.Windows.Forms.Label();
			this.lb_giophongvan = new System.Windows.Forms.Label();
			this.txb_tenungvien = new System.Windows.Forms.TextBox();
			this.lb_diadiem = new System.Windows.Forms.Label();
			this.lb_nguoiphongvan = new System.Windows.Forms.Label();
			this.lb_trangthai = new System.Windows.Forms.Label();
			this.dtp_ngayphongvan = new System.Windows.Forms.DateTimePicker();
			this.dtp_giophongvan = new System.Windows.Forms.DateTimePicker();
			this.txb_nguoiphongvan = new System.Windows.Forms.TextBox();
			this.dgv_lichpv = new System.Windows.Forms.DataGridView();
			this.MaPV = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TenUV = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MaHS = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NguoiPV = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ThoiGianPV = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NgayPV = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DiaDiem = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btn_themlichphongvan = new System.Windows.Forms.Button();
			this.btn_sualichphongvan = new System.Windows.Forms.Button();
			this.btn_xoalichphongvan = new System.Windows.Forms.Button();
			this.btn_donglichphongvan = new System.Windows.Forms.Button();
			this.txb_findlichpv = new System.Windows.Forms.TextBox();
			this.btn_timlichphongvan = new System.Windows.Forms.Button();
			this.cb_diadiem = new System.Windows.Forms.ComboBox();
			this.cb_trangthai = new System.Windows.Forms.ComboBox();
			this.pn_lichphongvan = new System.Windows.Forms.Panel();
			this.lb_goiy = new System.Windows.Forms.Label();
			this.txb_mahoso = new System.Windows.Forms.TextBox();
			this.lb_mahoso = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dgv_lichpv)).BeginInit();
			this.pn_lichphongvan.SuspendLayout();
			this.SuspendLayout();
			// 
			// lb_tenungvien
			// 
			this.lb_tenungvien.AutoSize = true;
			this.lb_tenungvien.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_tenungvien.Location = new System.Drawing.Point(30, 45);
			this.lb_tenungvien.Name = "lb_tenungvien";
			this.lb_tenungvien.Size = new System.Drawing.Size(99, 20);
			this.lb_tenungvien.TabIndex = 20;
			this.lb_tenungvien.Text = "Tên ứng viên";
			// 
			// lb_ngayphongvan
			// 
			this.lb_ngayphongvan.AutoSize = true;
			this.lb_ngayphongvan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_ngayphongvan.Location = new System.Drawing.Point(432, 45);
			this.lb_ngayphongvan.Name = "lb_ngayphongvan";
			this.lb_ngayphongvan.Size = new System.Drawing.Size(124, 20);
			this.lb_ngayphongvan.TabIndex = 21;
			this.lb_ngayphongvan.Text = "Ngày phỏng vấn";
			// 
			// lb_giophongvan
			// 
			this.lb_giophongvan.AutoSize = true;
			this.lb_giophongvan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_giophongvan.Location = new System.Drawing.Point(432, 75);
			this.lb_giophongvan.Name = "lb_giophongvan";
			this.lb_giophongvan.Size = new System.Drawing.Size(111, 20);
			this.lb_giophongvan.TabIndex = 22;
			this.lb_giophongvan.Text = "Giờ phỏng vấn";
			// 
			// txb_tenungvien
			// 
			this.txb_tenungvien.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txb_tenungvien.Location = new System.Drawing.Point(165, 45);
			this.txb_tenungvien.Name = "txb_tenungvien";
			this.txb_tenungvien.Size = new System.Drawing.Size(252, 27);
			this.txb_tenungvien.TabIndex = 23;
			// 
			// lb_diadiem
			// 
			this.lb_diadiem.AutoSize = true;
			this.lb_diadiem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_diadiem.Location = new System.Drawing.Point(30, 105);
			this.lb_diadiem.Name = "lb_diadiem";
			this.lb_diadiem.Size = new System.Drawing.Size(71, 20);
			this.lb_diadiem.TabIndex = 24;
			this.lb_diadiem.Text = "Địa điểm";
			// 
			// lb_nguoiphongvan
			// 
			this.lb_nguoiphongvan.AutoSize = true;
			this.lb_nguoiphongvan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_nguoiphongvan.Location = new System.Drawing.Point(30, 75);
			this.lb_nguoiphongvan.Name = "lb_nguoiphongvan";
			this.lb_nguoiphongvan.Size = new System.Drawing.Size(131, 20);
			this.lb_nguoiphongvan.TabIndex = 25;
			this.lb_nguoiphongvan.Text = "Người phỏng vấn";
			// 
			// lb_trangthai
			// 
			this.lb_trangthai.AutoSize = true;
			this.lb_trangthai.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_trangthai.Location = new System.Drawing.Point(432, 15);
			this.lb_trangthai.Name = "lb_trangthai";
			this.lb_trangthai.Size = new System.Drawing.Size(80, 20);
			this.lb_trangthai.TabIndex = 26;
			this.lb_trangthai.Text = "Trạng thái";
			// 
			// dtp_ngayphongvan
			// 
			this.dtp_ngayphongvan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtp_ngayphongvan.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtp_ngayphongvan.Location = new System.Drawing.Point(558, 45);
			this.dtp_ngayphongvan.Name = "dtp_ngayphongvan";
			this.dtp_ngayphongvan.Size = new System.Drawing.Size(252, 27);
			this.dtp_ngayphongvan.TabIndex = 28;
			// 
			// dtp_giophongvan
			// 
			this.dtp_giophongvan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtp_giophongvan.Format = System.Windows.Forms.DateTimePickerFormat.Time;
			this.dtp_giophongvan.Location = new System.Drawing.Point(558, 75);
			this.dtp_giophongvan.Name = "dtp_giophongvan";
			this.dtp_giophongvan.Size = new System.Drawing.Size(252, 27);
			this.dtp_giophongvan.TabIndex = 29;
			// 
			// txb_nguoiphongvan
			// 
			this.txb_nguoiphongvan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txb_nguoiphongvan.Location = new System.Drawing.Point(165, 75);
			this.txb_nguoiphongvan.Name = "txb_nguoiphongvan";
			this.txb_nguoiphongvan.Size = new System.Drawing.Size(252, 27);
			this.txb_nguoiphongvan.TabIndex = 30;
			// 
			// dgv_lichpv
			// 
			this.dgv_lichpv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv_lichpv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaPV,
            this.TenUV,
            this.MaHS,
            this.NguoiPV,
            this.ThoiGianPV,
            this.NgayPV,
            this.DiaDiem,
            this.TrangThai});
			this.dgv_lichpv.Location = new System.Drawing.Point(3, 218);
			this.dgv_lichpv.Name = "dgv_lichpv";
			this.dgv_lichpv.RowHeadersWidth = 51;
			this.dgv_lichpv.RowTemplate.Height = 24;
			this.dgv_lichpv.Size = new System.Drawing.Size(976, 273);
			this.dgv_lichpv.TabIndex = 32;
			// 
			// MaPV
			// 
			this.MaPV.DataPropertyName = "MaPV";
			this.MaPV.HeaderText = "Mã phỏng vấn";
			this.MaPV.MinimumWidth = 6;
			this.MaPV.Name = "MaPV";
			this.MaPV.Width = 125;
			// 
			// TenUV
			// 
			this.TenUV.DataPropertyName = "TenUV";
			this.TenUV.HeaderText = "Tên ứng viên";
			this.TenUV.MinimumWidth = 6;
			this.TenUV.Name = "TenUV";
			this.TenUV.Width = 125;
			// 
			// MaHS
			// 
			this.MaHS.DataPropertyName = "MaHS";
			this.MaHS.HeaderText = "Mã hồ sơ";
			this.MaHS.MinimumWidth = 6;
			this.MaHS.Name = "MaHS";
			this.MaHS.Width = 125;
			// 
			// NguoiPV
			// 
			this.NguoiPV.DataPropertyName = "NguoiPV";
			this.NguoiPV.HeaderText = "Người phỏng vấn";
			this.NguoiPV.MinimumWidth = 6;
			this.NguoiPV.Name = "NguoiPV";
			this.NguoiPV.Width = 125;
			// 
			// ThoiGianPV
			// 
			this.ThoiGianPV.DataPropertyName = "ThoiGianPV";
			this.ThoiGianPV.HeaderText = "Giờ phỏng vấn";
			this.ThoiGianPV.MinimumWidth = 6;
			this.ThoiGianPV.Name = "ThoiGianPV";
			this.ThoiGianPV.Width = 125;
			// 
			// NgayPV
			// 
			this.NgayPV.DataPropertyName = "NgayPV";
			this.NgayPV.HeaderText = "Ngày phỏng vấn";
			this.NgayPV.MinimumWidth = 6;
			this.NgayPV.Name = "NgayPV";
			this.NgayPV.Width = 125;
			// 
			// DiaDiem
			// 
			this.DiaDiem.DataPropertyName = "DiaDiem";
			this.DiaDiem.HeaderText = "Địa điểm";
			this.DiaDiem.MinimumWidth = 6;
			this.DiaDiem.Name = "DiaDiem";
			this.DiaDiem.Width = 125;
			// 
			// TrangThai
			// 
			this.TrangThai.DataPropertyName = "TrangThai";
			this.TrangThai.HeaderText = "Trạng thái";
			this.TrangThai.MinimumWidth = 6;
			this.TrangThai.Name = "TrangThai";
			this.TrangThai.Width = 125;
			// 
			// btn_themlichphongvan
			// 
			this.btn_themlichphongvan.BackColor = System.Drawing.Color.DarkOrange;
			this.btn_themlichphongvan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_themlichphongvan.Location = new System.Drawing.Point(827, 10);
			this.btn_themlichphongvan.Name = "btn_themlichphongvan";
			this.btn_themlichphongvan.Size = new System.Drawing.Size(115, 40);
			this.btn_themlichphongvan.TabIndex = 33;
			this.btn_themlichphongvan.Text = "Thêm";
			this.btn_themlichphongvan.UseVisualStyleBackColor = false;
			this.btn_themlichphongvan.Click += new System.EventHandler(this.btn_addlich_Click);
			// 
			// btn_sualichphongvan
			// 
			this.btn_sualichphongvan.BackColor = System.Drawing.Color.DarkOrange;
			this.btn_sualichphongvan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_sualichphongvan.Location = new System.Drawing.Point(827, 50);
			this.btn_sualichphongvan.Name = "btn_sualichphongvan";
			this.btn_sualichphongvan.Size = new System.Drawing.Size(115, 40);
			this.btn_sualichphongvan.TabIndex = 34;
			this.btn_sualichphongvan.Text = "Sửa";
			this.btn_sualichphongvan.UseVisualStyleBackColor = false;
			this.btn_sualichphongvan.Click += new System.EventHandler(this.btn_editlichpv_Click);
			// 
			// btn_xoalichphongvan
			// 
			this.btn_xoalichphongvan.BackColor = System.Drawing.Color.DarkOrange;
			this.btn_xoalichphongvan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_xoalichphongvan.Location = new System.Drawing.Point(827, 90);
			this.btn_xoalichphongvan.Name = "btn_xoalichphongvan";
			this.btn_xoalichphongvan.Size = new System.Drawing.Size(115, 40);
			this.btn_xoalichphongvan.TabIndex = 35;
			this.btn_xoalichphongvan.Text = "Xóa";
			this.btn_xoalichphongvan.UseVisualStyleBackColor = false;
			this.btn_xoalichphongvan.Click += new System.EventHandler(this.btn_deletelichpv_Click);
			// 
			// btn_donglichphongvan
			// 
			this.btn_donglichphongvan.BackColor = System.Drawing.Color.DarkOrange;
			this.btn_donglichphongvan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_donglichphongvan.Location = new System.Drawing.Point(827, 130);
			this.btn_donglichphongvan.Name = "btn_donglichphongvan";
			this.btn_donglichphongvan.Size = new System.Drawing.Size(115, 40);
			this.btn_donglichphongvan.TabIndex = 36;
			this.btn_donglichphongvan.Text = "Đóng";
			this.btn_donglichphongvan.UseVisualStyleBackColor = false;
			this.btn_donglichphongvan.Click += new System.EventHandler(this.btn_closelichpv_Click);
			// 
			// txb_findlichpv
			// 
			this.txb_findlichpv.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txb_findlichpv.Location = new System.Drawing.Point(34, 180);
			this.txb_findlichpv.Name = "txb_findlichpv";
			this.txb_findlichpv.Size = new System.Drawing.Size(776, 27);
			this.txb_findlichpv.TabIndex = 38;
			// 
			// btn_timlichphongvan
			// 
			this.btn_timlichphongvan.BackColor = System.Drawing.Color.DarkOrange;
			this.btn_timlichphongvan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_timlichphongvan.Location = new System.Drawing.Point(827, 170);
			this.btn_timlichphongvan.Name = "btn_timlichphongvan";
			this.btn_timlichphongvan.Size = new System.Drawing.Size(115, 40);
			this.btn_timlichphongvan.TabIndex = 39;
			this.btn_timlichphongvan.Text = "Tìm kiếm";
			this.btn_timlichphongvan.UseVisualStyleBackColor = false;
			this.btn_timlichphongvan.Click += new System.EventHandler(this.btn_findlichpv_Click);
			// 
			// cb_diadiem
			// 
			this.cb_diadiem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cb_diadiem.FormattingEnabled = true;
			this.cb_diadiem.Location = new System.Drawing.Point(165, 105);
			this.cb_diadiem.Name = "cb_diadiem";
			this.cb_diadiem.Size = new System.Drawing.Size(252, 28);
			this.cb_diadiem.TabIndex = 40;
			// 
			// cb_trangthai
			// 
			this.cb_trangthai.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cb_trangthai.FormattingEnabled = true;
			this.cb_trangthai.Location = new System.Drawing.Point(558, 15);
			this.cb_trangthai.Name = "cb_trangthai";
			this.cb_trangthai.Size = new System.Drawing.Size(252, 28);
			this.cb_trangthai.TabIndex = 41;
			// 
			// pn_lichphongvan
			// 
			this.pn_lichphongvan.Controls.Add(this.lb_goiy);
			this.pn_lichphongvan.Controls.Add(this.txb_mahoso);
			this.pn_lichphongvan.Controls.Add(this.lb_mahoso);
			this.pn_lichphongvan.Controls.Add(this.txb_tenungvien);
			this.pn_lichphongvan.Controls.Add(this.btn_donglichphongvan);
			this.pn_lichphongvan.Controls.Add(this.cb_trangthai);
			this.pn_lichphongvan.Controls.Add(this.btn_xoalichphongvan);
			this.pn_lichphongvan.Controls.Add(this.dtp_ngayphongvan);
			this.pn_lichphongvan.Controls.Add(this.btn_sualichphongvan);
			this.pn_lichphongvan.Controls.Add(this.cb_diadiem);
			this.pn_lichphongvan.Controls.Add(this.btn_themlichphongvan);
			this.pn_lichphongvan.Controls.Add(this.lb_ngayphongvan);
			this.pn_lichphongvan.Controls.Add(this.btn_timlichphongvan);
			this.pn_lichphongvan.Controls.Add(this.lb_tenungvien);
			this.pn_lichphongvan.Controls.Add(this.dtp_giophongvan);
			this.pn_lichphongvan.Controls.Add(this.txb_findlichpv);
			this.pn_lichphongvan.Controls.Add(this.lb_trangthai);
			this.pn_lichphongvan.Controls.Add(this.lb_giophongvan);
			this.pn_lichphongvan.Controls.Add(this.lb_nguoiphongvan);
			this.pn_lichphongvan.Controls.Add(this.txb_nguoiphongvan);
			this.pn_lichphongvan.Controls.Add(this.lb_diadiem);
			this.pn_lichphongvan.Location = new System.Drawing.Point(3, 2);
			this.pn_lichphongvan.Name = "pn_lichphongvan";
			this.pn_lichphongvan.Size = new System.Drawing.Size(976, 220);
			this.pn_lichphongvan.TabIndex = 42;
			// 
			// lb_goiy
			// 
			this.lb_goiy.AutoSize = true;
			this.lb_goiy.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_goiy.Location = new System.Drawing.Point(34, 153);
			this.lb_goiy.Name = "lb_goiy";
			this.lb_goiy.Size = new System.Drawing.Size(571, 17);
			this.lb_goiy.TabIndex = 44;
			this.lb_goiy.Text = "(Tìm kiếm theo mã hồ sơ, tên ứng viên, người phỏng vấn, địa điểm, trạng thái hoặc" +
    " ngày phỏng vấn)";
			// 
			// txb_mahoso
			// 
			this.txb_mahoso.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txb_mahoso.Location = new System.Drawing.Point(165, 15);
			this.txb_mahoso.Name = "txb_mahoso";
			this.txb_mahoso.Size = new System.Drawing.Size(252, 27);
			this.txb_mahoso.TabIndex = 43;
			// 
			// lb_mahoso
			// 
			this.lb_mahoso.AutoSize = true;
			this.lb_mahoso.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_mahoso.Location = new System.Drawing.Point(30, 15);
			this.lb_mahoso.Name = "lb_mahoso";
			this.lb_mahoso.Size = new System.Drawing.Size(73, 20);
			this.lb_mahoso.TabIndex = 42;
			this.lb_mahoso.Text = "Mã hồ sơ";
			// 
			// fQuanlylichphongvan
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.BlanchedAlmond;
			this.ClientSize = new System.Drawing.Size(982, 503);
			this.Controls.Add(this.pn_lichphongvan);
			this.Controls.Add(this.dgv_lichpv);
			this.Name = "fQuanlylichphongvan";
			this.Text = "Quản lý lịch phỏng vấn";
			((System.ComponentModel.ISupportInitialize)(this.dgv_lichpv)).EndInit();
			this.pn_lichphongvan.ResumeLayout(false);
			this.pn_lichphongvan.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.Label lb_tenungvien;
		private System.Windows.Forms.Label lb_ngayphongvan;
		private System.Windows.Forms.Label lb_giophongvan;
		private System.Windows.Forms.TextBox txb_tenungvien;
		private System.Windows.Forms.Label lb_diadiem;
		private System.Windows.Forms.Label lb_nguoiphongvan;
		private System.Windows.Forms.Label lb_trangthai;
		private System.Windows.Forms.DateTimePicker dtp_ngayphongvan;
		private System.Windows.Forms.DateTimePicker dtp_giophongvan;
		private System.Windows.Forms.TextBox txb_nguoiphongvan;
		private System.Windows.Forms.DataGridView dgv_lichpv;
		private System.Windows.Forms.Button btn_themlichphongvan;
		private System.Windows.Forms.Button btn_sualichphongvan;
		private System.Windows.Forms.Button btn_xoalichphongvan;
		private System.Windows.Forms.Button btn_donglichphongvan;
		private System.Windows.Forms.TextBox txb_findlichpv;
		private System.Windows.Forms.Button btn_timlichphongvan;
		private System.Windows.Forms.ComboBox cb_diadiem;
		private System.Windows.Forms.ComboBox cb_trangthai;
		private System.Windows.Forms.Panel pn_lichphongvan;
		private System.Windows.Forms.TextBox txb_mahoso;
		private System.Windows.Forms.Label lb_mahoso;
		private System.Windows.Forms.Label lb_goiy;
		private System.Windows.Forms.DataGridViewTextBoxColumn MaPV;
		private System.Windows.Forms.DataGridViewTextBoxColumn TenUV;
		private System.Windows.Forms.DataGridViewTextBoxColumn MaHS;
		private System.Windows.Forms.DataGridViewTextBoxColumn NguoiPV;
		private System.Windows.Forms.DataGridViewTextBoxColumn ThoiGianPV;
		private System.Windows.Forms.DataGridViewTextBoxColumn NgayPV;
		private System.Windows.Forms.DataGridViewTextBoxColumn DiaDiem;
		private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai;
	}
}