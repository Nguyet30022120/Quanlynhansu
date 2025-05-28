namespace QuanLyNhanSu.GUI
{
	partial class fBangcongchitiet
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
			this.btn_phatsinhcong = new System.Windows.Forms.Button();
			this.dgv_bangcongchitiet = new System.Windows.Forms.DataGridView();
			this.btn_dongbangcongchitiet = new System.Windows.Forms.Button();
			this.btn_refresh = new System.Windows.Forms.Button();
			this.btn_xembangcong = new System.Windows.Forms.Button();
			this.lb_thang = new System.Windows.Forms.Label();
			this.lb_nam = new System.Windows.Forms.Label();
			this.cb_thang = new System.Windows.Forms.ComboBox();
			this.cb_nam = new System.Windows.Forms.ComboBox();
			this.sqlCommandBuilder1 = new Microsoft.Data.SqlClient.SqlCommandBuilder();
			this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.D1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.D2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.D3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.D4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.D5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.D6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.D7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.D8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.D9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.D10 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.D11 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.D12 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.D13 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.D14 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.D15 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.D16 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.D17 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.D18 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.D19 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.D20 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.D21 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.D22 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.D23 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.D24 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.D25 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.D26 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.D27 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.D28 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.D29 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.D30 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.D31 = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dgv_bangcongchitiet)).BeginInit();
			this.SuspendLayout();
			// 
			// btn_phatsinhcong
			// 
			this.btn_phatsinhcong.Location = new System.Drawing.Point(844, 29);
			this.btn_phatsinhcong.Name = "btn_phatsinhcong";
			this.btn_phatsinhcong.Size = new System.Drawing.Size(128, 23);
			this.btn_phatsinhcong.TabIndex = 24;
			this.btn_phatsinhcong.Text = "Phát sinh công";
			this.btn_phatsinhcong.UseVisualStyleBackColor = true;
			// 
			// dgv_bangcongchitiet
			// 
			this.dgv_bangcongchitiet.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv_bangcongchitiet.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNV,
            this.HoTen,
            this.D1,
            this.D2,
            this.D3,
            this.D4,
            this.D5,
            this.D6,
            this.D7,
            this.D8,
            this.D9,
            this.D10,
            this.D11,
            this.D12,
            this.D13,
            this.D14,
            this.D15,
            this.D16,
            this.D17,
            this.D18,
            this.D19,
            this.D20,
            this.D21,
            this.D22,
            this.D23,
            this.D24,
            this.D25,
            this.D26,
            this.D27,
            this.D28,
            this.D29,
            this.D30,
            this.D31});
			this.dgv_bangcongchitiet.Location = new System.Drawing.Point(3, 210);
			this.dgv_bangcongchitiet.Name = "dgv_bangcongchitiet";
			this.dgv_bangcongchitiet.RowHeadersWidth = 51;
			this.dgv_bangcongchitiet.RowTemplate.Height = 24;
			this.dgv_bangcongchitiet.Size = new System.Drawing.Size(1183, 439);
			this.dgv_bangcongchitiet.TabIndex = 23;
			// 
			// btn_dongbangcongchitiet
			// 
			this.btn_dongbangcongchitiet.Location = new System.Drawing.Point(844, 158);
			this.btn_dongbangcongchitiet.Name = "btn_dongbangcongchitiet";
			this.btn_dongbangcongchitiet.Size = new System.Drawing.Size(128, 23);
			this.btn_dongbangcongchitiet.TabIndex = 22;
			this.btn_dongbangcongchitiet.Text = "Đóng";
			this.btn_dongbangcongchitiet.UseVisualStyleBackColor = true;
			// 
			// btn_refresh
			// 
			this.btn_refresh.Location = new System.Drawing.Point(844, 129);
			this.btn_refresh.Name = "btn_refresh";
			this.btn_refresh.Size = new System.Drawing.Size(128, 23);
			this.btn_refresh.TabIndex = 21;
			this.btn_refresh.Text = "Refresh";
			this.btn_refresh.UseVisualStyleBackColor = true;
			// 
			// btn_xembangcong
			// 
			this.btn_xembangcong.Location = new System.Drawing.Point(844, 83);
			this.btn_xembangcong.Name = "btn_xembangcong";
			this.btn_xembangcong.Size = new System.Drawing.Size(128, 23);
			this.btn_xembangcong.TabIndex = 19;
			this.btn_xembangcong.Text = "Xem bảng công";
			this.btn_xembangcong.UseVisualStyleBackColor = true;
			// 
			// lb_thang
			// 
			this.lb_thang.AutoSize = true;
			this.lb_thang.Location = new System.Drawing.Point(333, 40);
			this.lb_thang.Name = "lb_thang";
			this.lb_thang.Size = new System.Drawing.Size(46, 16);
			this.lb_thang.TabIndex = 18;
			this.lb_thang.Text = "Tháng";
			// 
			// lb_nam
			// 
			this.lb_nam.AutoSize = true;
			this.lb_nam.Location = new System.Drawing.Point(35, 37);
			this.lb_nam.Name = "lb_nam";
			this.lb_nam.Size = new System.Drawing.Size(36, 16);
			this.lb_nam.TabIndex = 17;
			this.lb_nam.Text = "Năm";
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
			this.cb_thang.Location = new System.Drawing.Point(427, 37);
			this.cb_thang.Name = "cb_thang";
			this.cb_thang.Size = new System.Drawing.Size(94, 24);
			this.cb_thang.TabIndex = 16;
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
			this.cb_nam.Location = new System.Drawing.Point(129, 37);
			this.cb_nam.Name = "cb_nam";
			this.cb_nam.Size = new System.Drawing.Size(94, 24);
			this.cb_nam.TabIndex = 15;
			// 
			// MaNV
			// 
			this.MaNV.HeaderText = "Mã nhân viên";
			this.MaNV.MinimumWidth = 6;
			this.MaNV.Name = "MaNV";
			this.MaNV.Width = 125;
			// 
			// HoTen
			// 
			this.HoTen.HeaderText = "Họ tên";
			this.HoTen.MinimumWidth = 6;
			this.HoTen.Name = "HoTen";
			this.HoTen.Width = 125;
			// 
			// D1
			// 
			this.D1.HeaderText = "D1";
			this.D1.MinimumWidth = 6;
			this.D1.Name = "D1";
			this.D1.Width = 125;
			// 
			// D2
			// 
			this.D2.HeaderText = "D2";
			this.D2.MinimumWidth = 6;
			this.D2.Name = "D2";
			this.D2.Width = 125;
			// 
			// D3
			// 
			this.D3.HeaderText = "D3";
			this.D3.MinimumWidth = 6;
			this.D3.Name = "D3";
			this.D3.Width = 125;
			// 
			// D4
			// 
			this.D4.HeaderText = "D4";
			this.D4.MinimumWidth = 6;
			this.D4.Name = "D4";
			this.D4.Width = 125;
			// 
			// D5
			// 
			this.D5.HeaderText = "D5";
			this.D5.MinimumWidth = 6;
			this.D5.Name = "D5";
			this.D5.Width = 125;
			// 
			// D6
			// 
			this.D6.HeaderText = "D6";
			this.D6.MinimumWidth = 6;
			this.D6.Name = "D6";
			this.D6.Width = 125;
			// 
			// D7
			// 
			this.D7.HeaderText = "D7";
			this.D7.MinimumWidth = 6;
			this.D7.Name = "D7";
			this.D7.Width = 125;
			// 
			// D8
			// 
			this.D8.HeaderText = "D8";
			this.D8.MinimumWidth = 6;
			this.D8.Name = "D8";
			this.D8.Width = 125;
			// 
			// D9
			// 
			this.D9.HeaderText = "D9";
			this.D9.MinimumWidth = 6;
			this.D9.Name = "D9";
			this.D9.Width = 125;
			// 
			// D10
			// 
			this.D10.HeaderText = "D10";
			this.D10.MinimumWidth = 6;
			this.D10.Name = "D10";
			this.D10.Width = 125;
			// 
			// D11
			// 
			this.D11.HeaderText = "D11";
			this.D11.MinimumWidth = 6;
			this.D11.Name = "D11";
			this.D11.Width = 125;
			// 
			// D12
			// 
			this.D12.HeaderText = "D12";
			this.D12.MinimumWidth = 6;
			this.D12.Name = "D12";
			this.D12.Width = 125;
			// 
			// D13
			// 
			this.D13.HeaderText = "D13";
			this.D13.MinimumWidth = 6;
			this.D13.Name = "D13";
			this.D13.Width = 125;
			// 
			// D14
			// 
			this.D14.HeaderText = "D14";
			this.D14.MinimumWidth = 6;
			this.D14.Name = "D14";
			this.D14.Width = 125;
			// 
			// D15
			// 
			this.D15.HeaderText = "D15";
			this.D15.MinimumWidth = 6;
			this.D15.Name = "D15";
			this.D15.Width = 125;
			// 
			// D16
			// 
			this.D16.HeaderText = "D16";
			this.D16.MinimumWidth = 6;
			this.D16.Name = "D16";
			this.D16.Width = 125;
			// 
			// D17
			// 
			this.D17.HeaderText = "D17";
			this.D17.MinimumWidth = 6;
			this.D17.Name = "D17";
			this.D17.Width = 125;
			// 
			// D18
			// 
			this.D18.HeaderText = "D18";
			this.D18.MinimumWidth = 6;
			this.D18.Name = "D18";
			this.D18.Width = 125;
			// 
			// D19
			// 
			this.D19.HeaderText = "D19";
			this.D19.MinimumWidth = 6;
			this.D19.Name = "D19";
			this.D19.Width = 125;
			// 
			// D20
			// 
			this.D20.HeaderText = "D20";
			this.D20.MinimumWidth = 6;
			this.D20.Name = "D20";
			this.D20.Width = 125;
			// 
			// D21
			// 
			this.D21.HeaderText = "D21";
			this.D21.MinimumWidth = 6;
			this.D21.Name = "D21";
			this.D21.Width = 125;
			// 
			// D22
			// 
			this.D22.HeaderText = "D22";
			this.D22.MinimumWidth = 6;
			this.D22.Name = "D22";
			this.D22.Width = 125;
			// 
			// D23
			// 
			this.D23.HeaderText = "D23";
			this.D23.MinimumWidth = 6;
			this.D23.Name = "D23";
			this.D23.Width = 125;
			// 
			// D24
			// 
			this.D24.HeaderText = "D24";
			this.D24.MinimumWidth = 6;
			this.D24.Name = "D24";
			this.D24.Width = 125;
			// 
			// D25
			// 
			this.D25.HeaderText = "D25";
			this.D25.MinimumWidth = 6;
			this.D25.Name = "D25";
			this.D25.Width = 125;
			// 
			// D26
			// 
			this.D26.HeaderText = "D26";
			this.D26.MinimumWidth = 6;
			this.D26.Name = "D26";
			this.D26.Width = 125;
			// 
			// D27
			// 
			this.D27.HeaderText = "D27";
			this.D27.MinimumWidth = 6;
			this.D27.Name = "D27";
			this.D27.Width = 125;
			// 
			// D28
			// 
			this.D28.HeaderText = "D28";
			this.D28.MinimumWidth = 6;
			this.D28.Name = "D28";
			this.D28.Width = 125;
			// 
			// D29
			// 
			this.D29.HeaderText = "D29";
			this.D29.MinimumWidth = 6;
			this.D29.Name = "D29";
			this.D29.Width = 125;
			// 
			// D30
			// 
			this.D30.HeaderText = "D30";
			this.D30.MinimumWidth = 6;
			this.D30.Name = "D30";
			this.D30.Width = 125;
			// 
			// D31
			// 
			this.D31.HeaderText = "D31";
			this.D31.MinimumWidth = 6;
			this.D31.Name = "D31";
			this.D31.Width = 125;
			// 
			// fBangcongchitiet
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1198, 661);
			this.Controls.Add(this.btn_phatsinhcong);
			this.Controls.Add(this.dgv_bangcongchitiet);
			this.Controls.Add(this.btn_dongbangcongchitiet);
			this.Controls.Add(this.btn_refresh);
			this.Controls.Add(this.btn_xembangcong);
			this.Controls.Add(this.lb_thang);
			this.Controls.Add(this.lb_nam);
			this.Controls.Add(this.cb_thang);
			this.Controls.Add(this.cb_nam);
			this.Name = "fBangcongchitiet";
			this.Text = "Bảng công chi tiết";
			((System.ComponentModel.ISupportInitialize)(this.dgv_bangcongchitiet)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button btn_phatsinhcong;
		private System.Windows.Forms.DataGridView dgv_bangcongchitiet;
		private System.Windows.Forms.Button btn_dongbangcongchitiet;
		private System.Windows.Forms.Button btn_refresh;
		private System.Windows.Forms.Button btn_xembangcong;
		private System.Windows.Forms.Label lb_thang;
		private System.Windows.Forms.Label lb_nam;
		private System.Windows.Forms.ComboBox cb_thang;
		private System.Windows.Forms.ComboBox cb_nam;
		private Microsoft.Data.SqlClient.SqlCommandBuilder sqlCommandBuilder1;
		private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
		private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
		private System.Windows.Forms.DataGridViewTextBoxColumn D1;
		private System.Windows.Forms.DataGridViewTextBoxColumn D2;
		private System.Windows.Forms.DataGridViewTextBoxColumn D3;
		private System.Windows.Forms.DataGridViewTextBoxColumn D4;
		private System.Windows.Forms.DataGridViewTextBoxColumn D5;
		private System.Windows.Forms.DataGridViewTextBoxColumn D6;
		private System.Windows.Forms.DataGridViewTextBoxColumn D7;
		private System.Windows.Forms.DataGridViewTextBoxColumn D8;
		private System.Windows.Forms.DataGridViewTextBoxColumn D9;
		private System.Windows.Forms.DataGridViewTextBoxColumn D10;
		private System.Windows.Forms.DataGridViewTextBoxColumn D11;
		private System.Windows.Forms.DataGridViewTextBoxColumn D12;
		private System.Windows.Forms.DataGridViewTextBoxColumn D13;
		private System.Windows.Forms.DataGridViewTextBoxColumn D14;
		private System.Windows.Forms.DataGridViewTextBoxColumn D15;
		private System.Windows.Forms.DataGridViewTextBoxColumn D16;
		private System.Windows.Forms.DataGridViewTextBoxColumn D17;
		private System.Windows.Forms.DataGridViewTextBoxColumn D18;
		private System.Windows.Forms.DataGridViewTextBoxColumn D19;
		private System.Windows.Forms.DataGridViewTextBoxColumn D20;
		private System.Windows.Forms.DataGridViewTextBoxColumn D21;
		private System.Windows.Forms.DataGridViewTextBoxColumn D22;
		private System.Windows.Forms.DataGridViewTextBoxColumn D23;
		private System.Windows.Forms.DataGridViewTextBoxColumn D24;
		private System.Windows.Forms.DataGridViewTextBoxColumn D25;
		private System.Windows.Forms.DataGridViewTextBoxColumn D26;
		private System.Windows.Forms.DataGridViewTextBoxColumn D27;
		private System.Windows.Forms.DataGridViewTextBoxColumn D28;
		private System.Windows.Forms.DataGridViewTextBoxColumn D29;
		private System.Windows.Forms.DataGridViewTextBoxColumn D30;
		private System.Windows.Forms.DataGridViewTextBoxColumn D31;
	}
}