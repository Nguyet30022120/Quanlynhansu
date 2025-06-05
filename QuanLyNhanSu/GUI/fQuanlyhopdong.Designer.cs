namespace QuanLyNhanSu
{
	partial class fQuanlyhopdong
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
			this.panel1 = new System.Windows.Forms.Panel();
			this.btn_timhopdong = new System.Windows.Forms.Button();
			this.txb_timhopdong = new System.Windows.Forms.TextBox();
			this.txb_status = new System.Windows.Forms.TextBox();
			this.lb_status = new System.Windows.Forms.Label();
			this.btn_capnhathopdong = new System.Windows.Forms.Button();
			this.btn_donghopdong = new System.Windows.Forms.Button();
			this.btn_xoahopdong = new System.Windows.Forms.Button();
			this.btn_suahopdong = new System.Windows.Forms.Button();
			this.btn_themhopdong = new System.Windows.Forms.Button();
			this.dtp_ngayhh = new System.Windows.Forms.DateTimePicker();
			this.dtp_ngaydk = new System.Windows.Forms.DateTimePicker();
			this.txb_tennhanvien = new System.Windows.Forms.TextBox();
			this.lb_ngayhethan = new System.Windows.Forms.Label();
			this.lb_ngaydangky = new System.Windows.Forms.Label();
			this.lb_tennhanvien = new System.Windows.Forms.Label();
			this.dgv_contract = new System.Windows.Forms.DataGridView();
			this.MaHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TenNhanVien = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NgayDK = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NgayHH = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgv_contract)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.btn_timhopdong);
			this.panel1.Controls.Add(this.txb_timhopdong);
			this.panel1.Controls.Add(this.txb_status);
			this.panel1.Controls.Add(this.lb_status);
			this.panel1.Controls.Add(this.btn_capnhathopdong);
			this.panel1.Controls.Add(this.btn_donghopdong);
			this.panel1.Controls.Add(this.btn_xoahopdong);
			this.panel1.Controls.Add(this.btn_suahopdong);
			this.panel1.Controls.Add(this.btn_themhopdong);
			this.panel1.Controls.Add(this.dtp_ngayhh);
			this.panel1.Controls.Add(this.dtp_ngaydk);
			this.panel1.Controls.Add(this.txb_tennhanvien);
			this.panel1.Controls.Add(this.lb_ngayhethan);
			this.panel1.Controls.Add(this.lb_ngaydangky);
			this.panel1.Controls.Add(this.lb_tennhanvien);
			this.panel1.Location = new System.Drawing.Point(8, 5);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1472, 218);
			this.panel1.TabIndex = 0;
			// 
			// btn_timhopdong
			// 
			this.btn_timhopdong.BackColor = System.Drawing.Color.DarkOrange;
			this.btn_timhopdong.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_timhopdong.Location = new System.Drawing.Point(1347, 165);
			this.btn_timhopdong.Name = "btn_timhopdong";
			this.btn_timhopdong.Size = new System.Drawing.Size(115, 40);
			this.btn_timhopdong.TabIndex = 12;
			this.btn_timhopdong.Text = "Tìm kiếm";
			this.btn_timhopdong.UseVisualStyleBackColor = false;
			this.btn_timhopdong.Click += new System.EventHandler(this.btn_findhd_Click);
			// 
			// txb_timhopdong
			// 
			this.txb_timhopdong.Font = new System.Drawing.Font("Segoe UI", 9F);
			this.txb_timhopdong.Location = new System.Drawing.Point(34, 177);
			this.txb_timhopdong.Name = "txb_timhopdong";
			this.txb_timhopdong.Size = new System.Drawing.Size(1295, 27);
			this.txb_timhopdong.TabIndex = 12;
			// 
			// txb_status
			// 
			this.txb_status.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txb_status.Location = new System.Drawing.Point(194, 115);
			this.txb_status.Name = "txb_status";
			this.txb_status.ReadOnly = true;
			this.txb_status.Size = new System.Drawing.Size(252, 27);
			this.txb_status.TabIndex = 14;
			// 
			// lb_status
			// 
			this.lb_status.AutoSize = true;
			this.lb_status.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_status.Location = new System.Drawing.Point(30, 115);
			this.lb_status.Name = "lb_status";
			this.lb_status.Size = new System.Drawing.Size(80, 20);
			this.lb_status.TabIndex = 13;
			this.lb_status.Text = "Trạng thái";
			// 
			// btn_capnhathopdong
			// 
			this.btn_capnhathopdong.BackColor = System.Drawing.Color.DarkOrange;
			this.btn_capnhathopdong.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_capnhathopdong.Location = new System.Drawing.Point(508, 108);
			this.btn_capnhathopdong.Name = "btn_capnhathopdong";
			this.btn_capnhathopdong.Size = new System.Drawing.Size(115, 40);
			this.btn_capnhathopdong.TabIndex = 12;
			this.btn_capnhathopdong.Text = "Cập nhật";
			this.btn_capnhathopdong.UseVisualStyleBackColor = false;
			this.btn_capnhathopdong.Click += new System.EventHandler(this.btn_updatehd_Click);
			// 
			// btn_donghopdong
			// 
			this.btn_donghopdong.BackColor = System.Drawing.Color.DarkOrange;
			this.btn_donghopdong.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_donghopdong.Location = new System.Drawing.Point(1347, 125);
			this.btn_donghopdong.Name = "btn_donghopdong";
			this.btn_donghopdong.Size = new System.Drawing.Size(115, 40);
			this.btn_donghopdong.TabIndex = 11;
			this.btn_donghopdong.Text = "Đóng";
			this.btn_donghopdong.UseVisualStyleBackColor = false;
			this.btn_donghopdong.Click += new System.EventHandler(this.btn_closehd_Click);
			// 
			// btn_xoahopdong
			// 
			this.btn_xoahopdong.BackColor = System.Drawing.Color.DarkOrange;
			this.btn_xoahopdong.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_xoahopdong.Location = new System.Drawing.Point(1347, 85);
			this.btn_xoahopdong.Name = "btn_xoahopdong";
			this.btn_xoahopdong.Size = new System.Drawing.Size(115, 40);
			this.btn_xoahopdong.TabIndex = 10;
			this.btn_xoahopdong.Text = "Xóa";
			this.btn_xoahopdong.UseVisualStyleBackColor = false;
			this.btn_xoahopdong.Click += new System.EventHandler(this.btn_deletehd_Click);
			// 
			// btn_suahopdong
			// 
			this.btn_suahopdong.BackColor = System.Drawing.Color.DarkOrange;
			this.btn_suahopdong.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_suahopdong.Location = new System.Drawing.Point(1347, 45);
			this.btn_suahopdong.Name = "btn_suahopdong";
			this.btn_suahopdong.Size = new System.Drawing.Size(115, 40);
			this.btn_suahopdong.TabIndex = 9;
			this.btn_suahopdong.Text = "Sửa";
			this.btn_suahopdong.UseVisualStyleBackColor = false;
			this.btn_suahopdong.Click += new System.EventHandler(this.btn_edithd_Click);
			// 
			// btn_themhopdong
			// 
			this.btn_themhopdong.BackColor = System.Drawing.Color.DarkOrange;
			this.btn_themhopdong.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_themhopdong.Location = new System.Drawing.Point(1347, 5);
			this.btn_themhopdong.Name = "btn_themhopdong";
			this.btn_themhopdong.Size = new System.Drawing.Size(115, 40);
			this.btn_themhopdong.TabIndex = 8;
			this.btn_themhopdong.Text = "Thêm";
			this.btn_themhopdong.UseVisualStyleBackColor = false;
			this.btn_themhopdong.Click += new System.EventHandler(this.btn_addhd_Click);
			// 
			// dtp_ngayhh
			// 
			this.dtp_ngayhh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtp_ngayhh.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtp_ngayhh.Location = new System.Drawing.Point(695, 65);
			this.dtp_ngayhh.Name = "dtp_ngayhh";
			this.dtp_ngayhh.Size = new System.Drawing.Size(252, 27);
			this.dtp_ngayhh.TabIndex = 7;
			// 
			// dtp_ngaydk
			// 
			this.dtp_ngaydk.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtp_ngaydk.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtp_ngaydk.Location = new System.Drawing.Point(194, 65);
			this.dtp_ngaydk.Name = "dtp_ngaydk";
			this.dtp_ngaydk.Size = new System.Drawing.Size(252, 27);
			this.dtp_ngaydk.TabIndex = 6;
			// 
			// txb_tennhanvien
			// 
			this.txb_tennhanvien.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txb_tennhanvien.Location = new System.Drawing.Point(194, 15);
			this.txb_tennhanvien.Name = "txb_tennhanvien";
			this.txb_tennhanvien.ReadOnly = true;
			this.txb_tennhanvien.Size = new System.Drawing.Size(252, 27);
			this.txb_tennhanvien.TabIndex = 5;
			// 
			// lb_ngayhethan
			// 
			this.lb_ngayhethan.AutoSize = true;
			this.lb_ngayhethan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_ngayhethan.Location = new System.Drawing.Point(520, 65);
			this.lb_ngayhethan.Name = "lb_ngayhethan";
			this.lb_ngayhethan.Size = new System.Drawing.Size(103, 20);
			this.lb_ngayhethan.TabIndex = 3;
			this.lb_ngayhethan.Text = "Ngày hết hạn";
			// 
			// lb_ngaydangky
			// 
			this.lb_ngaydangky.AutoSize = true;
			this.lb_ngaydangky.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_ngaydangky.Location = new System.Drawing.Point(31, 65);
			this.lb_ngaydangky.Name = "lb_ngaydangky";
			this.lb_ngaydangky.Size = new System.Drawing.Size(105, 20);
			this.lb_ngaydangky.TabIndex = 2;
			this.lb_ngaydangky.Text = "Ngày đăng ký";
			// 
			// lb_tennhanvien
			// 
			this.lb_tennhanvien.AutoSize = true;
			this.lb_tennhanvien.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_tennhanvien.Location = new System.Drawing.Point(30, 15);
			this.lb_tennhanvien.Name = "lb_tennhanvien";
			this.lb_tennhanvien.Size = new System.Drawing.Size(106, 20);
			this.lb_tennhanvien.TabIndex = 1;
			this.lb_tennhanvien.Text = "Tên nhân viên";
			// 
			// dgv_contract
			// 
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.Tan;
			this.dgv_contract.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dgv_contract.BackgroundColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgv_contract.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dgv_contract.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv_contract.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaHD,
            this.MaNV,
            this.TenNhanVien,
            this.NgayDK,
            this.NgayHH,
            this.TrangThai});
			this.dgv_contract.Location = new System.Drawing.Point(8, 221);
			this.dgv_contract.Name = "dgv_contract";
			this.dgv_contract.RowHeadersWidth = 51;
			this.dgv_contract.RowTemplate.Height = 24;
			this.dgv_contract.Size = new System.Drawing.Size(1472, 553);
			this.dgv_contract.TabIndex = 1;
			// 
			// MaHD
			// 
			this.MaHD.DataPropertyName = "MaHD";
			this.MaHD.HeaderText = "Mã hợp đồng";
			this.MaHD.MinimumWidth = 6;
			this.MaHD.Name = "MaHD";
			this.MaHD.Width = 125;
			// 
			// MaNV
			// 
			this.MaNV.DataPropertyName = "MaNV";
			this.MaNV.HeaderText = "Mã nhân viên";
			this.MaNV.MinimumWidth = 6;
			this.MaNV.Name = "MaNV";
			this.MaNV.Width = 125;
			// 
			// TenNhanVien
			// 
			this.TenNhanVien.DataPropertyName = "TenNV";
			this.TenNhanVien.HeaderText = "Tên nhân viên";
			this.TenNhanVien.MinimumWidth = 6;
			this.TenNhanVien.Name = "TenNhanVien";
			this.TenNhanVien.Width = 200;
			// 
			// NgayDK
			// 
			this.NgayDK.DataPropertyName = "NgayDK";
			this.NgayDK.HeaderText = "Ngày đăng ký";
			this.NgayDK.MinimumWidth = 6;
			this.NgayDK.Name = "NgayDK";
			this.NgayDK.Width = 125;
			// 
			// NgayHH
			// 
			this.NgayHH.DataPropertyName = "NgayHH";
			this.NgayHH.HeaderText = "Ngày hết hạn";
			this.NgayHH.MinimumWidth = 6;
			this.NgayHH.Name = "NgayHH";
			this.NgayHH.Width = 125;
			// 
			// TrangThai
			// 
			this.TrangThai.DataPropertyName = "TrangThai";
			this.TrangThai.HeaderText = "Trạng Thái";
			this.TrangThai.MinimumWidth = 6;
			this.TrangThai.Name = "TrangThai";
			this.TrangThai.Width = 125;
			// 
			// fQuanlyhopdong
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.BlanchedAlmond;
			this.ClientSize = new System.Drawing.Size(1482, 778);
			this.Controls.Add(this.dgv_contract);
			this.Controls.Add(this.panel1);
			this.Name = "fQuanlyhopdong";
			this.Text = "Quản lý hợp đồng lao động";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgv_contract)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.DataGridView dgv_contract;
		private System.Windows.Forms.DateTimePicker dtp_ngayhh;
		private System.Windows.Forms.DateTimePicker dtp_ngaydk;
		private System.Windows.Forms.TextBox txb_tennhanvien;
		private System.Windows.Forms.Label lb_ngayhethan;
		private System.Windows.Forms.Label lb_ngaydangky;
		private System.Windows.Forms.Label lb_tennhanvien;
		private System.Windows.Forms.Button btn_donghopdong;
		private System.Windows.Forms.Button btn_xoahopdong;
		private System.Windows.Forms.Button btn_suahopdong;
		private System.Windows.Forms.Button btn_themhopdong;
		private System.Windows.Forms.Button btn_timhopdong;
		private System.Windows.Forms.TextBox txb_timhopdong;
		private System.Windows.Forms.Button btn_capnhathopdong;
		private System.Windows.Forms.TextBox txb_status;
		private System.Windows.Forms.Label lb_status;
		private System.Windows.Forms.DataGridViewTextBoxColumn MaHD;
		private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
		private System.Windows.Forms.DataGridViewTextBoxColumn TenNhanVien;
		private System.Windows.Forms.DataGridViewTextBoxColumn NgayDK;
		private System.Windows.Forms.DataGridViewTextBoxColumn NgayHH;
		private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai;
	}
}