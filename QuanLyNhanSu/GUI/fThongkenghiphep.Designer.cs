namespace QuanLyNhanSu
{
	partial class fThongkenghiphep
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
			this.btn_thongkenhanvien = new System.Windows.Forms.Button();
			this.btn_thongketheongay = new System.Windows.Forms.Button();
			this.txb_manhanvien = new System.Windows.Forms.TextBox();
			this.lb_maNV = new System.Windows.Forms.Label();
			this.lb_tennhanvien = new System.Windows.Forms.Label();
			this.lb_ngaybatdau = new System.Windows.Forms.Label();
			this.dtp_ngaybatdau = new System.Windows.Forms.DateTimePicker();
			this.lb_ngayketthuc = new System.Windows.Forms.Label();
			this.dtp_ngaykt = new System.Windows.Forms.DateTimePicker();
			this.dgv_nghipheptk = new System.Windows.Forms.DataGridView();
			this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NgayBD = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NgayKT = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.LyDo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.elementHost1 = new System.Windows.Forms.Integration.ElementHost();
			this.cartesianChart1 = new LiveCharts.Wpf.CartesianChart();
			this.txb_tennhanvien = new System.Windows.Forms.TextBox();
			this.btn_dong = new System.Windows.Forms.Button();
			this.btn_xuatbaocao = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgv_nghipheptk)).BeginInit();
			this.SuspendLayout();
			// 
			// btn_thongkenhanvien
			// 
			this.btn_thongkenhanvien.BackColor = System.Drawing.Color.DarkOrange;
			this.btn_thongkenhanvien.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_thongkenhanvien.Location = new System.Drawing.Point(14, 263);
			this.btn_thongkenhanvien.Name = "btn_thongkenhanvien";
			this.btn_thongkenhanvien.Size = new System.Drawing.Size(115, 40);
			this.btn_thongkenhanvien.TabIndex = 1;
			this.btn_thongkenhanvien.Text = "Thống kê";
			this.btn_thongkenhanvien.UseVisualStyleBackColor = false;
			this.btn_thongkenhanvien.Click += new System.EventHandler(this.btn_thongkenv_Click);
			// 
			// btn_thongketheongay
			// 
			this.btn_thongketheongay.BackColor = System.Drawing.Color.DarkOrange;
			this.btn_thongketheongay.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_thongketheongay.Location = new System.Drawing.Point(453, 469);
			this.btn_thongketheongay.Name = "btn_thongketheongay";
			this.btn_thongketheongay.Size = new System.Drawing.Size(115, 40);
			this.btn_thongketheongay.TabIndex = 2;
			this.btn_thongketheongay.Text = "Thống kê";
			this.btn_thongketheongay.UseVisualStyleBackColor = false;
			this.btn_thongketheongay.Click += new System.EventHandler(this.btn_thongketheongay_Click);
			// 
			// txb_manhanvien
			// 
			this.txb_manhanvien.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txb_manhanvien.Location = new System.Drawing.Point(140, 30);
			this.txb_manhanvien.Name = "txb_manhanvien";
			this.txb_manhanvien.Size = new System.Drawing.Size(252, 27);
			this.txb_manhanvien.TabIndex = 3;
			// 
			// lb_maNV
			// 
			this.lb_maNV.AutoSize = true;
			this.lb_maNV.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_maNV.Location = new System.Drawing.Point(10, 30);
			this.lb_maNV.Name = "lb_maNV";
			this.lb_maNV.Size = new System.Drawing.Size(103, 20);
			this.lb_maNV.TabIndex = 6;
			this.lb_maNV.Text = "Mã nhân viên";
			// 
			// lb_tennhanvien
			// 
			this.lb_tennhanvien.AutoSize = true;
			this.lb_tennhanvien.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_tennhanvien.Location = new System.Drawing.Point(10, 80);
			this.lb_tennhanvien.Name = "lb_tennhanvien";
			this.lb_tennhanvien.Size = new System.Drawing.Size(106, 20);
			this.lb_tennhanvien.TabIndex = 7;
			this.lb_tennhanvien.Text = "Tên nhân viên";
			// 
			// lb_ngaybatdau
			// 
			this.lb_ngaybatdau.AutoSize = true;
			this.lb_ngaybatdau.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_ngaybatdau.Location = new System.Drawing.Point(10, 130);
			this.lb_ngaybatdau.Name = "lb_ngaybatdau";
			this.lb_ngaybatdau.Size = new System.Drawing.Size(66, 20);
			this.lb_ngaybatdau.TabIndex = 8;
			this.lb_ngaybatdau.Text = "Từ ngày";
			// 
			// dtp_ngaybatdau
			// 
			this.dtp_ngaybatdau.CalendarFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtp_ngaybatdau.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtp_ngaybatdau.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtp_ngaybatdau.Location = new System.Drawing.Point(140, 180);
			this.dtp_ngaybatdau.Name = "dtp_ngaybatdau";
			this.dtp_ngaybatdau.Size = new System.Drawing.Size(252, 27);
			this.dtp_ngaybatdau.TabIndex = 9;
			// 
			// lb_ngayketthuc
			// 
			this.lb_ngayketthuc.AutoSize = true;
			this.lb_ngayketthuc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_ngayketthuc.Location = new System.Drawing.Point(10, 180);
			this.lb_ngayketthuc.Name = "lb_ngayketthuc";
			this.lb_ngayketthuc.Size = new System.Drawing.Size(75, 20);
			this.lb_ngayketthuc.TabIndex = 10;
			this.lb_ngayketthuc.Text = "Đến ngày";
			// 
			// dtp_ngaykt
			// 
			this.dtp_ngaykt.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtp_ngaykt.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtp_ngaykt.Location = new System.Drawing.Point(140, 130);
			this.dtp_ngaykt.Name = "dtp_ngaykt";
			this.dtp_ngaykt.Size = new System.Drawing.Size(252, 27);
			this.dtp_ngaykt.TabIndex = 11;
			// 
			// dgv_nghipheptk
			// 
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.Tan;
			this.dgv_nghipheptk.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dgv_nghipheptk.BackgroundColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgv_nghipheptk.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dgv_nghipheptk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv_nghipheptk.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNV,
            this.TenNV,
            this.NgayBD,
            this.NgayKT,
            this.LyDo,
            this.TrangThai});
			this.dgv_nghipheptk.Location = new System.Drawing.Point(510, 12);
			this.dgv_nghipheptk.Name = "dgv_nghipheptk";
			this.dgv_nghipheptk.RowHeadersWidth = 51;
			this.dgv_nghipheptk.RowTemplate.Height = 24;
			this.dgv_nghipheptk.Size = new System.Drawing.Size(960, 416);
			this.dgv_nghipheptk.TabIndex = 12;
			// 
			// MaNV
			// 
			this.MaNV.DataPropertyName = "MaNV";
			this.MaNV.HeaderText = "Mã nhân viên";
			this.MaNV.MinimumWidth = 6;
			this.MaNV.Name = "MaNV";
			this.MaNV.Width = 125;
			// 
			// TenNV
			// 
			this.TenNV.DataPropertyName = "TenNV";
			this.TenNV.HeaderText = "Tên nhân viên";
			this.TenNV.MinimumWidth = 6;
			this.TenNV.Name = "TenNV";
			this.TenNV.Width = 125;
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
			// elementHost1
			// 
			this.elementHost1.BackColor = System.Drawing.Color.SeaShell;
			this.elementHost1.Location = new System.Drawing.Point(14, 434);
			this.elementHost1.Name = "elementHost1";
			this.elementHost1.Size = new System.Drawing.Size(1456, 336);
			this.elementHost1.TabIndex = 0;
			this.elementHost1.Text = "elementHost1";
			this.elementHost1.Child = this.cartesianChart1;
			// 
			// txb_tennhanvien
			// 
			this.txb_tennhanvien.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txb_tennhanvien.Location = new System.Drawing.Point(140, 80);
			this.txb_tennhanvien.Name = "txb_tennhanvien";
			this.txb_tennhanvien.Size = new System.Drawing.Size(252, 27);
			this.txb_tennhanvien.TabIndex = 16;
			// 
			// btn_dong
			// 
			this.btn_dong.BackColor = System.Drawing.Color.DarkOrange;
			this.btn_dong.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_dong.Location = new System.Drawing.Point(339, 263);
			this.btn_dong.Name = "btn_dong";
			this.btn_dong.Size = new System.Drawing.Size(115, 40);
			this.btn_dong.TabIndex = 17;
			this.btn_dong.Text = "Đóng";
			this.btn_dong.UseVisualStyleBackColor = false;
			this.btn_dong.Click += new System.EventHandler(this.btn_dong_Click);
			// 
			// btn_xuatbaocao
			// 
			this.btn_xuatbaocao.BackColor = System.Drawing.Color.DarkOrange;
			this.btn_xuatbaocao.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_xuatbaocao.Location = new System.Drawing.Point(164, 263);
			this.btn_xuatbaocao.Name = "btn_xuatbaocao";
			this.btn_xuatbaocao.Size = new System.Drawing.Size(137, 40);
			this.btn_xuatbaocao.TabIndex = 18;
			this.btn_xuatbaocao.Text = "Xuất báo cáo";
			this.btn_xuatbaocao.UseVisualStyleBackColor = false;
			this.btn_xuatbaocao.Click += new System.EventHandler(this.btn_xuatbaocao_Click);
			// 
			// fThongkenghiphep
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.BlanchedAlmond;
			this.ClientSize = new System.Drawing.Size(1482, 778);
			this.Controls.Add(this.btn_xuatbaocao);
			this.Controls.Add(this.elementHost1);
			this.Controls.Add(this.btn_dong);
			this.Controls.Add(this.dgv_nghipheptk);
			this.Controls.Add(this.txb_tennhanvien);
			this.Controls.Add(this.dtp_ngaykt);
			this.Controls.Add(this.lb_ngayketthuc);
			this.Controls.Add(this.dtp_ngaybatdau);
			this.Controls.Add(this.lb_ngaybatdau);
			this.Controls.Add(this.lb_tennhanvien);
			this.Controls.Add(this.lb_maNV);
			this.Controls.Add(this.txb_manhanvien);
			this.Controls.Add(this.btn_thongketheongay);
			this.Controls.Add(this.btn_thongkenhanvien);
			this.Name = "fThongkenghiphep";
			this.Text = "Thống kê lượt nghỉ phép";
			this.Load += new System.EventHandler(this.fThongkenghiphep_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgv_nghipheptk)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btn_thongkenhanvien;
		private System.Windows.Forms.Button btn_thongketheongay;
		private System.Windows.Forms.TextBox txb_manhanvien;
		private System.Windows.Forms.Label lb_maNV;
		private System.Windows.Forms.Label lb_tennhanvien;
		private System.Windows.Forms.Label lb_ngaybatdau;
		private System.Windows.Forms.DateTimePicker dtp_ngaybatdau;
		private System.Windows.Forms.Label lb_ngayketthuc;
		private System.Windows.Forms.DateTimePicker dtp_ngaykt;
		private System.Windows.Forms.DataGridView dgv_nghipheptk;
		private System.Windows.Forms.Integration.ElementHost elementHost1;
		private LiveCharts.Wpf.CartesianChart cartesianChart1;
		private System.Windows.Forms.TextBox txb_tennhanvien;
		private System.Windows.Forms.Button btn_dong;
		private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
		private System.Windows.Forms.DataGridViewTextBoxColumn TenNV;
		private System.Windows.Forms.DataGridViewTextBoxColumn NgayBD;
		private System.Windows.Forms.DataGridViewTextBoxColumn NgayKT;
		private System.Windows.Forms.DataGridViewTextBoxColumn LyDo;
		private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai;
		private System.Windows.Forms.Button btn_xuatbaocao;
	}
}