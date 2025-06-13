namespace QuanLyNhanSu.GUI
{
	partial class fQuanlybaohiem
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
			this.txb_tennhanvien = new System.Windows.Forms.TextBox();
			this.txb_mota = new System.Windows.Forms.TextBox();
			this.btn_thembaohiem = new System.Windows.Forms.Button();
			this.btn_suabaohiem = new System.Windows.Forms.Button();
			this.btn_xoabaohiem = new System.Windows.Forms.Button();
			this.btn_dongbaohiem = new System.Windows.Forms.Button();
			this.dgv_baohiem = new System.Windows.Forms.DataGridView();
			this.Ma_BH = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.LoaiBaoHiem = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Mota = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NgayBD = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NgayKT = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TienBH = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.lb_tennhanvien = new System.Windows.Forms.Label();
			this.lb_loaibaohiem = new System.Windows.Forms.Label();
			this.lb_mota = new System.Windows.Forms.Label();
			this.dtp_ngaybatdau = new System.Windows.Forms.DateTimePicker();
			this.dtp_ngayketthuc = new System.Windows.Forms.DateTimePicker();
			this.lb_ngaybatdau = new System.Windows.Forms.Label();
			this.lb_ngayketthuc = new System.Windows.Forms.Label();
			this.txb_manhanvien = new System.Windows.Forms.TextBox();
			this.lb_manhanvien = new System.Windows.Forms.Label();
			this.btn_timnhanvien = new System.Windows.Forms.Button();
			this.cb_loaibaohiem = new System.Windows.Forms.ComboBox();
			this.lb_tienbaohiem = new System.Windows.Forms.Label();
			this.txb_tienbaohiem = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.dgv_baohiem)).BeginInit();
			this.SuspendLayout();
			// 
			// txb_tennhanvien
			// 
			this.txb_tennhanvien.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txb_tennhanvien.Location = new System.Drawing.Point(203, 57);
			this.txb_tennhanvien.Name = "txb_tennhanvien";
			this.txb_tennhanvien.ReadOnly = true;
			this.txb_tennhanvien.Size = new System.Drawing.Size(252, 27);
			this.txb_tennhanvien.TabIndex = 0;
			// 
			// txb_mota
			// 
			this.txb_mota.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txb_mota.Location = new System.Drawing.Point(203, 150);
			this.txb_mota.Multiline = true;
			this.txb_mota.Name = "txb_mota";
			this.txb_mota.Size = new System.Drawing.Size(252, 62);
			this.txb_mota.TabIndex = 2;
			// 
			// btn_thembaohiem
			// 
			this.btn_thembaohiem.BackColor = System.Drawing.Color.DarkOrange;
			this.btn_thembaohiem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_thembaohiem.Location = new System.Drawing.Point(1355, 15);
			this.btn_thembaohiem.Name = "btn_thembaohiem";
			this.btn_thembaohiem.Size = new System.Drawing.Size(115, 40);
			this.btn_thembaohiem.TabIndex = 3;
			this.btn_thembaohiem.Text = "Thêm";
			this.btn_thembaohiem.UseVisualStyleBackColor = false;
			this.btn_thembaohiem.Click += new System.EventHandler(this.btn_addbh_Click);
			this.btn_thembaohiem.MouseEnter += new System.EventHandler(this.btn_thembaohiem_MouseEnter);
			this.btn_thembaohiem.MouseLeave += new System.EventHandler(this.btn_thembaohiem_MouseLeave);
			// 
			// btn_suabaohiem
			// 
			this.btn_suabaohiem.BackColor = System.Drawing.Color.DarkOrange;
			this.btn_suabaohiem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_suabaohiem.Location = new System.Drawing.Point(1355, 55);
			this.btn_suabaohiem.Name = "btn_suabaohiem";
			this.btn_suabaohiem.Size = new System.Drawing.Size(115, 40);
			this.btn_suabaohiem.TabIndex = 4;
			this.btn_suabaohiem.Text = "Sửa ";
			this.btn_suabaohiem.UseVisualStyleBackColor = false;
			this.btn_suabaohiem.Click += new System.EventHandler(this.btn_editbh_Click);
			this.btn_suabaohiem.MouseEnter += new System.EventHandler(this.btn_suabaohiem_MouseEnter);
			this.btn_suabaohiem.MouseLeave += new System.EventHandler(this.btn_suabaohiem_MouseLeave);
			// 
			// btn_xoabaohiem
			// 
			this.btn_xoabaohiem.BackColor = System.Drawing.Color.DarkOrange;
			this.btn_xoabaohiem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_xoabaohiem.Location = new System.Drawing.Point(1355, 95);
			this.btn_xoabaohiem.Name = "btn_xoabaohiem";
			this.btn_xoabaohiem.Size = new System.Drawing.Size(115, 40);
			this.btn_xoabaohiem.TabIndex = 5;
			this.btn_xoabaohiem.Text = "Xóa";
			this.btn_xoabaohiem.UseVisualStyleBackColor = false;
			this.btn_xoabaohiem.Click += new System.EventHandler(this.btn_deletebh_Click);
			this.btn_xoabaohiem.MouseEnter += new System.EventHandler(this.btn_xoabaohiem_MouseEnter);
			this.btn_xoabaohiem.MouseLeave += new System.EventHandler(this.btn_xoabaohiem_MouseLeave);
			// 
			// btn_dongbaohiem
			// 
			this.btn_dongbaohiem.BackColor = System.Drawing.Color.DarkOrange;
			this.btn_dongbaohiem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_dongbaohiem.Location = new System.Drawing.Point(1355, 135);
			this.btn_dongbaohiem.Name = "btn_dongbaohiem";
			this.btn_dongbaohiem.Size = new System.Drawing.Size(115, 40);
			this.btn_dongbaohiem.TabIndex = 6;
			this.btn_dongbaohiem.Text = "Đóng";
			this.btn_dongbaohiem.UseVisualStyleBackColor = false;
			this.btn_dongbaohiem.Click += new System.EventHandler(this.btn_closebh_Click);
			this.btn_dongbaohiem.MouseEnter += new System.EventHandler(this.btn_dongbaohiem_MouseEnter);
			this.btn_dongbaohiem.MouseLeave += new System.EventHandler(this.btn_dongbaohiem_MouseLeave);
			// 
			// dgv_baohiem
			// 
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.Tan;
			this.dgv_baohiem.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dgv_baohiem.BackgroundColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgv_baohiem.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dgv_baohiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv_baohiem.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Ma_BH,
            this.HoTen,
            this.LoaiBaoHiem,
            this.Mota,
            this.NgayBD,
            this.NgayKT,
            this.TienBH});
			this.dgv_baohiem.GridColor = System.Drawing.Color.Gray;
			this.dgv_baohiem.Location = new System.Drawing.Point(6, 228);
			this.dgv_baohiem.Name = "dgv_baohiem";
			this.dgv_baohiem.RowHeadersWidth = 51;
			this.dgv_baohiem.RowTemplate.Height = 24;
			this.dgv_baohiem.Size = new System.Drawing.Size(1471, 545);
			this.dgv_baohiem.TabIndex = 7;
			// 
			// Ma_BH
			// 
			this.Ma_BH.DataPropertyName = "MaBH";
			this.Ma_BH.HeaderText = "Mã bảo hiểm";
			this.Ma_BH.MinimumWidth = 6;
			this.Ma_BH.Name = "Ma_BH";
			this.Ma_BH.Width = 125;
			// 
			// HoTen
			// 
			this.HoTen.DataPropertyName = "TenNV";
			this.HoTen.HeaderText = "Tên nhân viên";
			this.HoTen.MinimumWidth = 6;
			this.HoTen.Name = "HoTen";
			this.HoTen.Width = 125;
			// 
			// LoaiBaoHiem
			// 
			this.LoaiBaoHiem.DataPropertyName = "LoaiBH";
			this.LoaiBaoHiem.HeaderText = "Loại bảo hiểm";
			this.LoaiBaoHiem.MinimumWidth = 6;
			this.LoaiBaoHiem.Name = "LoaiBaoHiem";
			this.LoaiBaoHiem.Width = 125;
			// 
			// Mota
			// 
			this.Mota.DataPropertyName = "MoTa";
			this.Mota.HeaderText = "Mô tả";
			this.Mota.MinimumWidth = 6;
			this.Mota.Name = "Mota";
			this.Mota.Width = 125;
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
			// TienBH
			// 
			this.TienBH.DataPropertyName = "TienBH";
			this.TienBH.HeaderText = "Tiền bảo hiểm";
			this.TienBH.MinimumWidth = 6;
			this.TienBH.Name = "TienBH";
			this.TienBH.Width = 125;
			// 
			// lb_tennhanvien
			// 
			this.lb_tennhanvien.AutoSize = true;
			this.lb_tennhanvien.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_tennhanvien.Location = new System.Drawing.Point(30, 60);
			this.lb_tennhanvien.Name = "lb_tennhanvien";
			this.lb_tennhanvien.Size = new System.Drawing.Size(106, 20);
			this.lb_tennhanvien.TabIndex = 8;
			this.lb_tennhanvien.Text = "Tên nhân viên";
			// 
			// lb_loaibaohiem
			// 
			this.lb_loaibaohiem.AutoSize = true;
			this.lb_loaibaohiem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_loaibaohiem.Location = new System.Drawing.Point(30, 105);
			this.lb_loaibaohiem.Name = "lb_loaibaohiem";
			this.lb_loaibaohiem.Size = new System.Drawing.Size(107, 20);
			this.lb_loaibaohiem.TabIndex = 9;
			this.lb_loaibaohiem.Text = "Loại bảo hiểm";
			// 
			// lb_mota
			// 
			this.lb_mota.AutoSize = true;
			this.lb_mota.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_mota.Location = new System.Drawing.Point(30, 150);
			this.lb_mota.Name = "lb_mota";
			this.lb_mota.Size = new System.Drawing.Size(50, 20);
			this.lb_mota.TabIndex = 10;
			this.lb_mota.Text = "Mô tả";
			// 
			// dtp_ngaybatdau
			// 
			this.dtp_ngaybatdau.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtp_ngaybatdau.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtp_ngaybatdau.Location = new System.Drawing.Point(948, 86);
			this.dtp_ngaybatdau.Name = "dtp_ngaybatdau";
			this.dtp_ngaybatdau.Size = new System.Drawing.Size(252, 27);
			this.dtp_ngaybatdau.TabIndex = 13;
			// 
			// dtp_ngayketthuc
			// 
			this.dtp_ngayketthuc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtp_ngayketthuc.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtp_ngayketthuc.Location = new System.Drawing.Point(948, 148);
			this.dtp_ngayketthuc.Name = "dtp_ngayketthuc";
			this.dtp_ngayketthuc.Size = new System.Drawing.Size(252, 27);
			this.dtp_ngayketthuc.TabIndex = 14;
			// 
			// lb_ngaybatdau
			// 
			this.lb_ngaybatdau.AutoSize = true;
			this.lb_ngaybatdau.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_ngaybatdau.Location = new System.Drawing.Point(763, 91);
			this.lb_ngaybatdau.Name = "lb_ngaybatdau";
			this.lb_ngaybatdau.Size = new System.Drawing.Size(103, 20);
			this.lb_ngaybatdau.TabIndex = 15;
			this.lb_ngaybatdau.Text = "Ngày bắt đầu";
			// 
			// lb_ngayketthuc
			// 
			this.lb_ngayketthuc.AutoSize = true;
			this.lb_ngayketthuc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_ngayketthuc.Location = new System.Drawing.Point(763, 150);
			this.lb_ngayketthuc.Name = "lb_ngayketthuc";
			this.lb_ngayketthuc.Size = new System.Drawing.Size(107, 20);
			this.lb_ngayketthuc.TabIndex = 16;
			this.lb_ngayketthuc.Text = "Ngày kết thúc";
			// 
			// txb_manhanvien
			// 
			this.txb_manhanvien.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txb_manhanvien.Location = new System.Drawing.Point(203, 12);
			this.txb_manhanvien.Name = "txb_manhanvien";
			this.txb_manhanvien.Size = new System.Drawing.Size(252, 27);
			this.txb_manhanvien.TabIndex = 17;
			// 
			// lb_manhanvien
			// 
			this.lb_manhanvien.AutoSize = true;
			this.lb_manhanvien.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_manhanvien.Location = new System.Drawing.Point(30, 15);
			this.lb_manhanvien.Name = "lb_manhanvien";
			this.lb_manhanvien.Size = new System.Drawing.Size(103, 20);
			this.lb_manhanvien.TabIndex = 18;
			this.lb_manhanvien.Text = "Mã nhân viên";
			// 
			// btn_timnhanvien
			// 
			this.btn_timnhanvien.BackColor = System.Drawing.Color.DarkOrange;
			this.btn_timnhanvien.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_timnhanvien.Location = new System.Drawing.Point(517, 5);
			this.btn_timnhanvien.Name = "btn_timnhanvien";
			this.btn_timnhanvien.Size = new System.Drawing.Size(115, 40);
			this.btn_timnhanvien.TabIndex = 19;
			this.btn_timnhanvien.Text = "Tìm kiếm";
			this.btn_timnhanvien.UseVisualStyleBackColor = false;
			this.btn_timnhanvien.Click += new System.EventHandler(this.btn_findmanv_Click);
			this.btn_timnhanvien.MouseEnter += new System.EventHandler(this.btn_timnhanvien_MouseEnter);
			this.btn_timnhanvien.MouseLeave += new System.EventHandler(this.btn_timnhanvien_MouseLeave);
			// 
			// cb_loaibaohiem
			// 
			this.cb_loaibaohiem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cb_loaibaohiem.FormattingEnabled = true;
			this.cb_loaibaohiem.Items.AddRange(new object[] {
            "BHYT",
            "BHXH",
            "BHTN",
            "Khác"});
			this.cb_loaibaohiem.Location = new System.Drawing.Point(203, 107);
			this.cb_loaibaohiem.Name = "cb_loaibaohiem";
			this.cb_loaibaohiem.Size = new System.Drawing.Size(252, 28);
			this.cb_loaibaohiem.TabIndex = 20;
			// 
			// lb_tienbaohiem
			// 
			this.lb_tienbaohiem.AutoSize = true;
			this.lb_tienbaohiem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_tienbaohiem.Location = new System.Drawing.Point(763, 35);
			this.lb_tienbaohiem.Name = "lb_tienbaohiem";
			this.lb_tienbaohiem.Size = new System.Drawing.Size(108, 20);
			this.lb_tienbaohiem.TabIndex = 21;
			this.lb_tienbaohiem.Text = "Tiền bảo hiểm";
			// 
			// txb_tienbaohiem
			// 
			this.txb_tienbaohiem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txb_tienbaohiem.Location = new System.Drawing.Point(948, 28);
			this.txb_tienbaohiem.Name = "txb_tienbaohiem";
			this.txb_tienbaohiem.Size = new System.Drawing.Size(252, 27);
			this.txb_tienbaohiem.TabIndex = 22;
			// 
			// fQuanlybaohiem
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.BlanchedAlmond;
			this.ClientSize = new System.Drawing.Size(1482, 778);
			this.Controls.Add(this.txb_tienbaohiem);
			this.Controls.Add(this.lb_tienbaohiem);
			this.Controls.Add(this.cb_loaibaohiem);
			this.Controls.Add(this.btn_timnhanvien);
			this.Controls.Add(this.lb_manhanvien);
			this.Controls.Add(this.txb_manhanvien);
			this.Controls.Add(this.lb_ngayketthuc);
			this.Controls.Add(this.lb_ngaybatdau);
			this.Controls.Add(this.dtp_ngayketthuc);
			this.Controls.Add(this.dtp_ngaybatdau);
			this.Controls.Add(this.lb_mota);
			this.Controls.Add(this.lb_loaibaohiem);
			this.Controls.Add(this.lb_tennhanvien);
			this.Controls.Add(this.dgv_baohiem);
			this.Controls.Add(this.btn_dongbaohiem);
			this.Controls.Add(this.btn_xoabaohiem);
			this.Controls.Add(this.btn_suabaohiem);
			this.Controls.Add(this.btn_thembaohiem);
			this.Controls.Add(this.txb_mota);
			this.Controls.Add(this.txb_tennhanvien);
			this.Name = "fQuanlybaohiem";
			this.ShowInTaskbar = false;
			this.Text = "Bảo hiểm";
			((System.ComponentModel.ISupportInitialize)(this.dgv_baohiem)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txb_tennhanvien;
		private System.Windows.Forms.TextBox txb_mota;
		private System.Windows.Forms.Button btn_thembaohiem;
		private System.Windows.Forms.Button btn_suabaohiem;
		private System.Windows.Forms.Button btn_xoabaohiem;
		private System.Windows.Forms.Button btn_dongbaohiem;
		private System.Windows.Forms.DataGridView dgv_baohiem;
		private System.Windows.Forms.Label lb_tennhanvien;
		private System.Windows.Forms.Label lb_loaibaohiem;
		private System.Windows.Forms.Label lb_mota;
		private System.Windows.Forms.DateTimePicker dtp_ngaybatdau;
		private System.Windows.Forms.DateTimePicker dtp_ngayketthuc;
		private System.Windows.Forms.Label lb_ngaybatdau;
		private System.Windows.Forms.Label lb_ngayketthuc;
		private System.Windows.Forms.TextBox txb_manhanvien;
		private System.Windows.Forms.Label lb_manhanvien;
		private System.Windows.Forms.Button btn_timnhanvien;
		private System.Windows.Forms.ComboBox cb_loaibaohiem;
		private System.Windows.Forms.DataGridViewTextBoxColumn Ma_BH;
		private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
		private System.Windows.Forms.DataGridViewTextBoxColumn LoaiBaoHiem;
		private System.Windows.Forms.DataGridViewTextBoxColumn Mota;
		private System.Windows.Forms.DataGridViewTextBoxColumn NgayBD;
		private System.Windows.Forms.DataGridViewTextBoxColumn NgayKT;
		private System.Windows.Forms.DataGridViewTextBoxColumn TienBH;
		private System.Windows.Forms.Label lb_tienbaohiem;
		private System.Windows.Forms.TextBox txb_tienbaohiem;
	}
}