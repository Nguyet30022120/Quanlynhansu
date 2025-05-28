namespace QuanLyNhanSu.GUI
{
	partial class fBangcong
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
			this.cb_nam = new System.Windows.Forms.ComboBox();
			this.cb_thang = new System.Windows.Forms.ComboBox();
			this.lb_nam = new System.Windows.Forms.Label();
			this.lb_thang = new System.Windows.Forms.Label();
			this.btn_add = new System.Windows.Forms.Button();
			this.btn_edit = new System.Windows.Forms.Button();
			this.btn_delete = new System.Windows.Forms.Button();
			this.btn_close = new System.Windows.Forms.Button();
			this.dgv_kycong = new System.Windows.Forms.DataGridView();
			this.MaKyCong = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Nam = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NgayTinhCong = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NgayCong = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.KyCong = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btn_viewdetail = new System.Windows.Forms.Button();
			this.dtp_ngaytinhcong = new System.Windows.Forms.DateTimePicker();
			this.cb_ngaycong = new System.Windows.Forms.ComboBox();
			this.lb_ngaycong = new System.Windows.Forms.Label();
			this.lb_ngaytinhcong = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dgv_kycong)).BeginInit();
			this.SuspendLayout();
			// 
			// cb_nam
			// 
			this.cb_nam.FormattingEnabled = true;
			this.cb_nam.Items.AddRange(new object[] {
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            "2023"});
			this.cb_nam.Location = new System.Drawing.Point(129, 40);
			this.cb_nam.Name = "cb_nam";
			this.cb_nam.Size = new System.Drawing.Size(121, 24);
			this.cb_nam.TabIndex = 0;
			this.cb_nam.SelectedIndexChanged += new System.EventHandler(this.cb_nam_SelectedIndexChanged);
			// 
			// cb_thang
			// 
			this.cb_thang.FormattingEnabled = true;
			this.cb_thang.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
			this.cb_thang.Location = new System.Drawing.Point(427, 40);
			this.cb_thang.Name = "cb_thang";
			this.cb_thang.Size = new System.Drawing.Size(121, 24);
			this.cb_thang.TabIndex = 1;
			this.cb_thang.SelectedIndexChanged += new System.EventHandler(this.cb_thang_SelectedIndexChanged);
			// 
			// lb_nam
			// 
			this.lb_nam.AutoSize = true;
			this.lb_nam.Location = new System.Drawing.Point(35, 40);
			this.lb_nam.Name = "lb_nam";
			this.lb_nam.Size = new System.Drawing.Size(36, 16);
			this.lb_nam.TabIndex = 3;
			this.lb_nam.Text = "Năm";
			this.lb_nam.Click += new System.EventHandler(this.lb_nam_Click);
			// 
			// lb_thang
			// 
			this.lb_thang.AutoSize = true;
			this.lb_thang.Location = new System.Drawing.Point(333, 43);
			this.lb_thang.Name = "lb_thang";
			this.lb_thang.Size = new System.Drawing.Size(46, 16);
			this.lb_thang.TabIndex = 4;
			this.lb_thang.Text = "Tháng";
			this.lb_thang.Click += new System.EventHandler(this.lb_thang_Click);
			// 
			// btn_add
			// 
			this.btn_add.Location = new System.Drawing.Point(1033, 32);
			this.btn_add.Name = "btn_add";
			this.btn_add.Size = new System.Drawing.Size(75, 23);
			this.btn_add.TabIndex = 5;
			this.btn_add.Text = "Thêm";
			this.btn_add.UseVisualStyleBackColor = true;
			this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
			// 
			// btn_edit
			// 
			this.btn_edit.Location = new System.Drawing.Point(1033, 89);
			this.btn_edit.Name = "btn_edit";
			this.btn_edit.Size = new System.Drawing.Size(75, 23);
			this.btn_edit.TabIndex = 6;
			this.btn_edit.Text = "Sửa";
			this.btn_edit.UseVisualStyleBackColor = true;
			this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
			// 
			// btn_delete
			// 
			this.btn_delete.Location = new System.Drawing.Point(1033, 127);
			this.btn_delete.Name = "btn_delete";
			this.btn_delete.Size = new System.Drawing.Size(75, 23);
			this.btn_delete.TabIndex = 7;
			this.btn_delete.Text = "Xóa";
			this.btn_delete.UseVisualStyleBackColor = true;
			this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
			// 
			// btn_close
			// 
			this.btn_close.Location = new System.Drawing.Point(1033, 177);
			this.btn_close.Name = "btn_close";
			this.btn_close.Size = new System.Drawing.Size(75, 23);
			this.btn_close.TabIndex = 8;
			this.btn_close.Text = "Đóng";
			this.btn_close.UseVisualStyleBackColor = true;
			this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
			// 
			// dgv_kycong
			// 
			this.dgv_kycong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv_kycong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaKyCong,
            this.Nam,
            this.NgayTinhCong,
            this.NgayCong,
            this.TrangThai,
            this.KyCong});
			this.dgv_kycong.Location = new System.Drawing.Point(12, 221);
			this.dgv_kycong.Name = "dgv_kycong";
			this.dgv_kycong.RowHeadersWidth = 51;
			this.dgv_kycong.RowTemplate.Height = 24;
			this.dgv_kycong.Size = new System.Drawing.Size(1210, 578);
			this.dgv_kycong.TabIndex = 9;
			this.dgv_kycong.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgv_kycong_CellContentClick);
			// 
			// MaKyCong
			// 
			this.MaKyCong.DataPropertyName = "MaKyCong";
			this.MaKyCong.HeaderText = "Mã kỳ công";
			this.MaKyCong.MinimumWidth = 6;
			this.MaKyCong.Name = "MaKyCong";
			this.MaKyCong.Width = 125;
			// 
			// Nam
			// 
			this.Nam.DataPropertyName = "Nam";
			this.Nam.HeaderText = "Năm";
			this.Nam.MinimumWidth = 6;
			this.Nam.Name = "Nam";
			this.Nam.Width = 125;
			// 
			// NgayTinhCong
			// 
			this.NgayTinhCong.DataPropertyName = "NgayTinhCong";
			this.NgayTinhCong.HeaderText = "Ngày Tính Công";
			this.NgayTinhCong.MinimumWidth = 6;
			this.NgayTinhCong.Name = "NgayTinhCong";
			this.NgayTinhCong.Width = 125;
			// 
			// NgayCong
			// 
			this.NgayCong.DataPropertyName = "NgayCong";
			this.NgayCong.HeaderText = "Ngày công";
			this.NgayCong.MinimumWidth = 6;
			this.NgayCong.Name = "NgayCong";
			this.NgayCong.Width = 125;
			// 
			// TrangThai
			// 
			this.TrangThai.DataPropertyName = "TrangThai";
			this.TrangThai.HeaderText = "Trạng thái";
			this.TrangThai.MinimumWidth = 6;
			this.TrangThai.Name = "TrangThai";
			this.TrangThai.Width = 125;
			// 
			// KyCong
			// 
			this.KyCong.DataPropertyName = "KyCong";
			this.KyCong.HeaderText = "Kỳ công";
			this.KyCong.MinimumWidth = 6;
			this.KyCong.Name = "KyCong";
			this.KyCong.Width = 125;
			// 
			// btn_viewdetail
			// 
			this.btn_viewdetail.Location = new System.Drawing.Point(844, 32);
			this.btn_viewdetail.Name = "btn_viewdetail";
			this.btn_viewdetail.Size = new System.Drawing.Size(155, 23);
			this.btn_viewdetail.TabIndex = 10;
			this.btn_viewdetail.Text = "Xem bảng công chi tiết";
			this.btn_viewdetail.UseVisualStyleBackColor = true;
			this.btn_viewdetail.Click += new System.EventHandler(this.btn_viewdetail_Click);
			// 
			// dtp_ngaytinhcong
			// 
			this.dtp_ngaytinhcong.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtp_ngaytinhcong.Location = new System.Drawing.Point(435, 100);
			this.dtp_ngaytinhcong.Name = "dtp_ngaytinhcong";
			this.dtp_ngaytinhcong.Size = new System.Drawing.Size(200, 22);
			this.dtp_ngaytinhcong.TabIndex = 11;
			this.dtp_ngaytinhcong.ValueChanged += new System.EventHandler(this.dtp_ngaytinhcong_ValueChanged);
			// 
			// cb_ngaycong
			// 
			this.cb_ngaycong.FormattingEnabled = true;
			this.cb_ngaycong.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15",
            "16",
            "17",
            "18",
            "19",
            "20",
            "21",
            "22",
            "23",
            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"});
			this.cb_ngaycong.Location = new System.Drawing.Point(129, 102);
			this.cb_ngaycong.Name = "cb_ngaycong";
			this.cb_ngaycong.Size = new System.Drawing.Size(121, 24);
			this.cb_ngaycong.TabIndex = 12;
			this.cb_ngaycong.SelectedIndexChanged += new System.EventHandler(this.cb_ngaycong_SelectedIndexChanged);
			// 
			// lb_ngaycong
			// 
			this.lb_ngaycong.AutoSize = true;
			this.lb_ngaycong.Location = new System.Drawing.Point(38, 104);
			this.lb_ngaycong.Name = "lb_ngaycong";
			this.lb_ngaycong.Size = new System.Drawing.Size(73, 16);
			this.lb_ngaycong.TabIndex = 13;
			this.lb_ngaycong.Text = "Ngày công";
			this.lb_ngaycong.Click += new System.EventHandler(this.lb_ngaycong_Click);
			// 
			// lb_ngaytinhcong
			// 
			this.lb_ngaytinhcong.AutoSize = true;
			this.lb_ngaytinhcong.Location = new System.Drawing.Point(333, 105);
			this.lb_ngaytinhcong.Name = "lb_ngaytinhcong";
			this.lb_ngaytinhcong.Size = new System.Drawing.Size(96, 16);
			this.lb_ngaytinhcong.TabIndex = 14;
			this.lb_ngaytinhcong.Text = "Ngày tính công";
			this.lb_ngaytinhcong.Click += new System.EventHandler(this.lb_ngaytinhcong_Click);
			// 
			// fBangcong
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1234, 811);
			this.Controls.Add(this.lb_ngaytinhcong);
			this.Controls.Add(this.lb_ngaycong);
			this.Controls.Add(this.cb_ngaycong);
			this.Controls.Add(this.dtp_ngaytinhcong);
			this.Controls.Add(this.btn_viewdetail);
			this.Controls.Add(this.dgv_kycong);
			this.Controls.Add(this.btn_close);
			this.Controls.Add(this.btn_delete);
			this.Controls.Add(this.btn_edit);
			this.Controls.Add(this.btn_add);
			this.Controls.Add(this.lb_thang);
			this.Controls.Add(this.lb_nam);
			this.Controls.Add(this.cb_thang);
			this.Controls.Add(this.cb_nam);
			this.Name = "fBangcong";
			this.Text = "fBangcong";
			((System.ComponentModel.ISupportInitialize)(this.dgv_kycong)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox cb_nam;
		private System.Windows.Forms.ComboBox cb_thang;
		private System.Windows.Forms.Label lb_nam;
		private System.Windows.Forms.Label lb_thang;
		private System.Windows.Forms.Button btn_add;
		private System.Windows.Forms.Button btn_edit;
		private System.Windows.Forms.Button btn_delete;
		private System.Windows.Forms.Button btn_close;
		private System.Windows.Forms.DataGridView dgv_kycong;
		private System.Windows.Forms.Button btn_viewdetail;
		private System.Windows.Forms.DataGridViewTextBoxColumn MaKyCong;
		private System.Windows.Forms.DataGridViewTextBoxColumn Nam;
		private System.Windows.Forms.DataGridViewTextBoxColumn NgayTinhCong;
		private System.Windows.Forms.DataGridViewTextBoxColumn NgayCong;
		private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai;
		private System.Windows.Forms.DataGridViewTextBoxColumn KyCong;
		private System.Windows.Forms.DateTimePicker dtp_ngaytinhcong;
		private System.Windows.Forms.ComboBox cb_ngaycong;
		private System.Windows.Forms.Label lb_ngaycong;
		private System.Windows.Forms.Label lb_ngaytinhcong;
	}
}