namespace QuanLyNhanSu.GUI
{
	partial class fQuanlyketquaphongvan
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
			this.txb_tenungvien = new System.Windows.Forms.TextBox();
			this.txb_danhgia = new System.Windows.Forms.TextBox();
			this.dtp_ngaydanhgia = new System.Windows.Forms.DateTimePicker();
			this.cb_ketluan = new System.Windows.Forms.ComboBox();
			this.btn_themketqua = new System.Windows.Forms.Button();
			this.btn_suaketqua = new System.Windows.Forms.Button();
			this.btn_xoaketqua = new System.Windows.Forms.Button();
			this.btn_dongketqua = new System.Windows.Forms.Button();
			this.btn_tiepnhan = new System.Windows.Forms.Button();
			this.dgv_ketqua = new System.Windows.Forms.DataGridView();
			this.MaKQ = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MaHS = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TenUV = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DanhGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.KetLuan = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NgayDanhGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.lb_tenungvien = new System.Windows.Forms.Label();
			this.lb_danhgia = new System.Windows.Forms.Label();
			this.lb_ketluan = new System.Windows.Forms.Label();
			this.lb_ngaydanhgia = new System.Windows.Forms.Label();
			this.txb_timketqua = new System.Windows.Forms.TextBox();
			this.btn_timketqua = new System.Windows.Forms.Button();
			this.txb_mahoso = new System.Windows.Forms.TextBox();
			this.lb_mahoso = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.lb_goiy = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dgv_ketqua)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// txb_tenungvien
			// 
			this.txb_tenungvien.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txb_tenungvien.Location = new System.Drawing.Point(165, 68);
			this.txb_tenungvien.Name = "txb_tenungvien";
			this.txb_tenungvien.Size = new System.Drawing.Size(252, 27);
			this.txb_tenungvien.TabIndex = 1;
			// 
			// txb_danhgia
			// 
			this.txb_danhgia.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txb_danhgia.Location = new System.Drawing.Point(545, 15);
			this.txb_danhgia.Multiline = true;
			this.txb_danhgia.Name = "txb_danhgia";
			this.txb_danhgia.Size = new System.Drawing.Size(252, 81);
			this.txb_danhgia.TabIndex = 2;
			// 
			// dtp_ngaydanhgia
			// 
			this.dtp_ngaydanhgia.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtp_ngaydanhgia.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtp_ngaydanhgia.Location = new System.Drawing.Point(1012, 13);
			this.dtp_ngaydanhgia.Name = "dtp_ngaydanhgia";
			this.dtp_ngaydanhgia.Size = new System.Drawing.Size(252, 27);
			this.dtp_ngaydanhgia.TabIndex = 3;
			// 
			// cb_ketluan
			// 
			this.cb_ketluan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cb_ketluan.FormattingEnabled = true;
			this.cb_ketluan.Location = new System.Drawing.Point(1012, 68);
			this.cb_ketluan.Name = "cb_ketluan";
			this.cb_ketluan.Size = new System.Drawing.Size(252, 28);
			this.cb_ketluan.TabIndex = 4;
			// 
			// btn_themketqua
			// 
			this.btn_themketqua.BackColor = System.Drawing.Color.DarkOrange;
			this.btn_themketqua.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_themketqua.Location = new System.Drawing.Point(1350, 8);
			this.btn_themketqua.Name = "btn_themketqua";
			this.btn_themketqua.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.btn_themketqua.Size = new System.Drawing.Size(115, 40);
			this.btn_themketqua.TabIndex = 5;
			this.btn_themketqua.Text = "Thêm";
			this.btn_themketqua.UseVisualStyleBackColor = false;
			this.btn_themketqua.Click += new System.EventHandler(this.btn_addkq_Click);
			// 
			// btn_suaketqua
			// 
			this.btn_suaketqua.BackColor = System.Drawing.Color.DarkOrange;
			this.btn_suaketqua.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_suaketqua.Location = new System.Drawing.Point(1350, 48);
			this.btn_suaketqua.Name = "btn_suaketqua";
			this.btn_suaketqua.Size = new System.Drawing.Size(115, 40);
			this.btn_suaketqua.TabIndex = 6;
			this.btn_suaketqua.Text = "Sửa";
			this.btn_suaketqua.UseVisualStyleBackColor = false;
			this.btn_suaketqua.Click += new System.EventHandler(this.btn_editkq_Click);
			// 
			// btn_xoaketqua
			// 
			this.btn_xoaketqua.BackColor = System.Drawing.Color.DarkOrange;
			this.btn_xoaketqua.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_xoaketqua.Location = new System.Drawing.Point(1350, 88);
			this.btn_xoaketqua.Name = "btn_xoaketqua";
			this.btn_xoaketqua.Size = new System.Drawing.Size(115, 40);
			this.btn_xoaketqua.TabIndex = 7;
			this.btn_xoaketqua.Text = "Xóa";
			this.btn_xoaketqua.UseVisualStyleBackColor = false;
			this.btn_xoaketqua.Click += new System.EventHandler(this.btn_deletekq_Click);
			// 
			// btn_dongketqua
			// 
			this.btn_dongketqua.BackColor = System.Drawing.Color.DarkOrange;
			this.btn_dongketqua.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_dongketqua.Location = new System.Drawing.Point(1350, 128);
			this.btn_dongketqua.Name = "btn_dongketqua";
			this.btn_dongketqua.Size = new System.Drawing.Size(115, 40);
			this.btn_dongketqua.TabIndex = 8;
			this.btn_dongketqua.Text = "Đóng";
			this.btn_dongketqua.UseVisualStyleBackColor = false;
			this.btn_dongketqua.Click += new System.EventHandler(this.btn_closekq_Click);
			// 
			// btn_tiepnhan
			// 
			this.btn_tiepnhan.BackColor = System.Drawing.Color.DarkOrange;
			this.btn_tiepnhan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_tiepnhan.Location = new System.Drawing.Point(1149, 130);
			this.btn_tiepnhan.Name = "btn_tiepnhan";
			this.btn_tiepnhan.Size = new System.Drawing.Size(115, 40);
			this.btn_tiepnhan.TabIndex = 9;
			this.btn_tiepnhan.Text = "Tiếp nhận";
			this.btn_tiepnhan.UseVisualStyleBackColor = false;
			this.btn_tiepnhan.Click += new System.EventHandler(this.btn_tiepnhan_Click);
			// 
			// dgv_ketqua
			// 
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.Tan;
			this.dgv_ketqua.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dgv_ketqua.BackgroundColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgv_ketqua.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dgv_ketqua.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv_ketqua.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaKQ,
            this.MaHS,
            this.TenUV,
            this.DanhGia,
            this.KetLuan,
            this.NgayDanhGia});
			this.dgv_ketqua.Location = new System.Drawing.Point(5, 229);
			this.dgv_ketqua.Name = "dgv_ketqua";
			this.dgv_ketqua.RowHeadersWidth = 51;
			this.dgv_ketqua.RowTemplate.Height = 24;
			this.dgv_ketqua.Size = new System.Drawing.Size(1470, 546);
			this.dgv_ketqua.TabIndex = 10;
			// 
			// MaKQ
			// 
			this.MaKQ.DataPropertyName = "MaKQ";
			this.MaKQ.HeaderText = "Mã kết quả";
			this.MaKQ.MinimumWidth = 6;
			this.MaKQ.Name = "MaKQ";
			this.MaKQ.Width = 125;
			// 
			// MaHS
			// 
			this.MaHS.DataPropertyName = "MaHS";
			this.MaHS.HeaderText = "Mã hồ sơ";
			this.MaHS.MinimumWidth = 6;
			this.MaHS.Name = "MaHS";
			this.MaHS.Width = 125;
			// 
			// TenUV
			// 
			this.TenUV.DataPropertyName = "TenUV";
			this.TenUV.HeaderText = "Tên ứng viên";
			this.TenUV.MinimumWidth = 6;
			this.TenUV.Name = "TenUV";
			this.TenUV.Width = 200;
			// 
			// DanhGia
			// 
			this.DanhGia.DataPropertyName = "DanhGia";
			this.DanhGia.HeaderText = "Đánh giá";
			this.DanhGia.MinimumWidth = 6;
			this.DanhGia.Name = "DanhGia";
			this.DanhGia.Width = 200;
			// 
			// KetLuan
			// 
			this.KetLuan.DataPropertyName = "KetLuan";
			this.KetLuan.HeaderText = "Kết luận";
			this.KetLuan.MinimumWidth = 6;
			this.KetLuan.Name = "KetLuan";
			this.KetLuan.Width = 125;
			// 
			// NgayDanhGia
			// 
			this.NgayDanhGia.DataPropertyName = "NgayDanhGia";
			this.NgayDanhGia.HeaderText = "Ngày đánh giá";
			this.NgayDanhGia.MinimumWidth = 6;
			this.NgayDanhGia.Name = "NgayDanhGia";
			this.NgayDanhGia.Width = 150;
			// 
			// lb_tenungvien
			// 
			this.lb_tenungvien.AutoSize = true;
			this.lb_tenungvien.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_tenungvien.Location = new System.Drawing.Point(30, 75);
			this.lb_tenungvien.Name = "lb_tenungvien";
			this.lb_tenungvien.Size = new System.Drawing.Size(99, 20);
			this.lb_tenungvien.TabIndex = 12;
			this.lb_tenungvien.Text = "Tên ứng viên";
			// 
			// lb_danhgia
			// 
			this.lb_danhgia.AutoSize = true;
			this.lb_danhgia.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_danhgia.Location = new System.Drawing.Point(468, 15);
			this.lb_danhgia.Name = "lb_danhgia";
			this.lb_danhgia.Size = new System.Drawing.Size(71, 20);
			this.lb_danhgia.TabIndex = 13;
			this.lb_danhgia.Text = "Đánh giá";
			// 
			// lb_ketluan
			// 
			this.lb_ketluan.AutoSize = true;
			this.lb_ketluan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_ketluan.Location = new System.Drawing.Point(863, 75);
			this.lb_ketluan.Name = "lb_ketluan";
			this.lb_ketluan.Size = new System.Drawing.Size(67, 20);
			this.lb_ketluan.TabIndex = 14;
			this.lb_ketluan.Text = "Kết luận";
			// 
			// lb_ngaydanhgia
			// 
			this.lb_ngaydanhgia.AutoSize = true;
			this.lb_ngaydanhgia.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_ngaydanhgia.Location = new System.Drawing.Point(863, 18);
			this.lb_ngaydanhgia.Name = "lb_ngaydanhgia";
			this.lb_ngaydanhgia.Size = new System.Drawing.Size(110, 20);
			this.lb_ngaydanhgia.TabIndex = 15;
			this.lb_ngaydanhgia.Text = "Ngày đánh giá";
			// 
			// txb_timketqua
			// 
			this.txb_timketqua.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txb_timketqua.Location = new System.Drawing.Point(30, 177);
			this.txb_timketqua.Name = "txb_timketqua";
			this.txb_timketqua.Size = new System.Drawing.Size(1300, 27);
			this.txb_timketqua.TabIndex = 16;
			// 
			// btn_timketqua
			// 
			this.btn_timketqua.BackColor = System.Drawing.Color.DarkOrange;
			this.btn_timketqua.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_timketqua.Location = new System.Drawing.Point(1350, 168);
			this.btn_timketqua.Name = "btn_timketqua";
			this.btn_timketqua.Size = new System.Drawing.Size(115, 40);
			this.btn_timketqua.TabIndex = 17;
			this.btn_timketqua.Text = "Tìm kiếm";
			this.btn_timketqua.UseVisualStyleBackColor = false;
			this.btn_timketqua.Click += new System.EventHandler(this.btn_findkq_Click);
			// 
			// txb_mahoso
			// 
			this.txb_mahoso.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txb_mahoso.Location = new System.Drawing.Point(165, 15);
			this.txb_mahoso.Name = "txb_mahoso";
			this.txb_mahoso.Size = new System.Drawing.Size(252, 27);
			this.txb_mahoso.TabIndex = 18;
			// 
			// lb_mahoso
			// 
			this.lb_mahoso.AutoSize = true;
			this.lb_mahoso.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_mahoso.Location = new System.Drawing.Point(30, 15);
			this.lb_mahoso.Name = "lb_mahoso";
			this.lb_mahoso.Size = new System.Drawing.Size(73, 20);
			this.lb_mahoso.TabIndex = 19;
			this.lb_mahoso.Text = "Mã hồ sơ";
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.lb_goiy);
			this.panel1.Controls.Add(this.txb_danhgia);
			this.panel1.Controls.Add(this.txb_timketqua);
			this.panel1.Controls.Add(this.btn_tiepnhan);
			this.panel1.Controls.Add(this.btn_timketqua);
			this.panel1.Controls.Add(this.btn_dongketqua);
			this.panel1.Controls.Add(this.txb_mahoso);
			this.panel1.Controls.Add(this.btn_xoaketqua);
			this.panel1.Controls.Add(this.lb_mahoso);
			this.panel1.Controls.Add(this.btn_suaketqua);
			this.panel1.Controls.Add(this.lb_ngaydanhgia);
			this.panel1.Controls.Add(this.btn_themketqua);
			this.panel1.Controls.Add(this.txb_tenungvien);
			this.panel1.Controls.Add(this.lb_ketluan);
			this.panel1.Controls.Add(this.lb_tenungvien);
			this.panel1.Controls.Add(this.lb_danhgia);
			this.panel1.Controls.Add(this.cb_ketluan);
			this.panel1.Controls.Add(this.dtp_ngaydanhgia);
			this.panel1.Location = new System.Drawing.Point(5, 4);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1470, 219);
			this.panel1.TabIndex = 20;
			// 
			// lb_goiy
			// 
			this.lb_goiy.AutoSize = true;
			this.lb_goiy.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_goiy.Location = new System.Drawing.Point(27, 153);
			this.lb_goiy.Name = "lb_goiy";
			this.lb_goiy.Size = new System.Drawing.Size(306, 17);
			this.lb_goiy.TabIndex = 20;
			this.lb_goiy.Text = "(Tìm kiếm theo mã hồ sơ, tên ứng viên hoặc kết luận)";
			// 
			// fQuanlyketquaphongvan
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.BlanchedAlmond;
			this.ClientSize = new System.Drawing.Size(1482, 778);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.dgv_ketqua);
			this.Name = "fQuanlyketquaphongvan";
			this.Text = "Quản lý kết quả phỏng vấn";
			((System.ComponentModel.ISupportInitialize)(this.dgv_ketqua)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion
		private System.Windows.Forms.TextBox txb_tenungvien;
		private System.Windows.Forms.TextBox txb_danhgia;
		private System.Windows.Forms.DateTimePicker dtp_ngaydanhgia;
		private System.Windows.Forms.ComboBox cb_ketluan;
		private System.Windows.Forms.Button btn_themketqua;
		private System.Windows.Forms.Button btn_suaketqua;
		private System.Windows.Forms.Button btn_xoaketqua;
		private System.Windows.Forms.Button btn_dongketqua;
		private System.Windows.Forms.Button btn_tiepnhan;
		private System.Windows.Forms.DataGridView dgv_ketqua;
		private System.Windows.Forms.Label lb_tenungvien;
		private System.Windows.Forms.Label lb_danhgia;
		private System.Windows.Forms.Label lb_ketluan;
		private System.Windows.Forms.Label lb_ngaydanhgia;
		private System.Windows.Forms.TextBox txb_timketqua;
		private System.Windows.Forms.Button btn_timketqua;
		private System.Windows.Forms.TextBox txb_mahoso;
		private System.Windows.Forms.Label lb_mahoso;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Label lb_goiy;
		private System.Windows.Forms.DataGridViewTextBoxColumn MaKQ;
		private System.Windows.Forms.DataGridViewTextBoxColumn MaHS;
		private System.Windows.Forms.DataGridViewTextBoxColumn TenUV;
		private System.Windows.Forms.DataGridViewTextBoxColumn DanhGia;
		private System.Windows.Forms.DataGridViewTextBoxColumn KetLuan;
		private System.Windows.Forms.DataGridViewTextBoxColumn NgayDanhGia;
	}
}