namespace QuanLyNhanSu
{
	partial class fThongkekhenthuongkyluat
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
			this.btn_xuatbaocao = new System.Windows.Forms.Button();
			this.cb_nhanvien = new System.Windows.Forms.ComboBox();
			this.btn_dong = new System.Windows.Forms.Button();
			this.cb_nam = new System.Windows.Forms.ComboBox();
			this.btn_thongkenhanvien = new System.Windows.Forms.Button();
			this.txb_manv = new System.Windows.Forms.TextBox();
			this.lb_manhanvien = new System.Windows.Forms.Label();
			this.lb_nam = new System.Windows.Forms.Label();
			this.dgv_ktkltk = new System.Windows.Forms.DataGridView();
			this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Nam = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.KhenThuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.KyLuat = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.panel_chart = new System.Windows.Forms.Panel();
			this.panel1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgv_ktkltk)).BeginInit();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.btn_xuatbaocao);
			this.panel1.Controls.Add(this.cb_nhanvien);
			this.panel1.Controls.Add(this.btn_dong);
			this.panel1.Controls.Add(this.cb_nam);
			this.panel1.Controls.Add(this.btn_thongkenhanvien);
			this.panel1.Controls.Add(this.txb_manv);
			this.panel1.Controls.Add(this.lb_manhanvien);
			this.panel1.Controls.Add(this.lb_nam);
			this.panel1.Location = new System.Drawing.Point(7, 4);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1470, 107);
			this.panel1.TabIndex = 0;
			// 
			// btn_xuatbaocao
			// 
			this.btn_xuatbaocao.BackColor = System.Drawing.Color.DarkOrange;
			this.btn_xuatbaocao.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_xuatbaocao.Location = new System.Drawing.Point(1080, 21);
			this.btn_xuatbaocao.Name = "btn_xuatbaocao";
			this.btn_xuatbaocao.Size = new System.Drawing.Size(137, 40);
			this.btn_xuatbaocao.TabIndex = 12;
			this.btn_xuatbaocao.Text = "Xuất báo cáo";
			this.btn_xuatbaocao.UseVisualStyleBackColor = false;
			this.btn_xuatbaocao.Click += new System.EventHandler(this.btn_xuatbaocao_Click);
			// 
			// cb_nhanvien
			// 
			this.cb_nhanvien.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cb_nhanvien.FormattingEnabled = true;
			this.cb_nhanvien.Items.AddRange(new object[] {
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            "2030"});
			this.cb_nhanvien.Location = new System.Drawing.Point(525, 35);
			this.cb_nhanvien.Name = "cb_nhanvien";
			this.cb_nhanvien.Size = new System.Drawing.Size(212, 28);
			this.cb_nhanvien.TabIndex = 11;
			// 
			// btn_dong
			// 
			this.btn_dong.BackColor = System.Drawing.Color.DarkOrange;
			this.btn_dong.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_dong.Location = new System.Drawing.Point(1348, 21);
			this.btn_dong.Name = "btn_dong";
			this.btn_dong.Size = new System.Drawing.Size(115, 40);
			this.btn_dong.TabIndex = 9;
			this.btn_dong.Text = "Đóng";
			this.btn_dong.UseVisualStyleBackColor = false;
			this.btn_dong.Click += new System.EventHandler(this.btn_dong_Click);
			// 
			// cb_nam
			// 
			this.cb_nam.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cb_nam.FormattingEnabled = true;
			this.cb_nam.Items.AddRange(new object[] {
            "2021",
            "2022",
            "2023",
            "2024",
            "2025",
            "2026",
            "2027",
            "2028",
            "2029",
            "2030"});
			this.cb_nam.Location = new System.Drawing.Point(88, 35);
			this.cb_nam.Name = "cb_nam";
			this.cb_nam.Size = new System.Drawing.Size(95, 28);
			this.cb_nam.TabIndex = 8;
			// 
			// btn_thongkenhanvien
			// 
			this.btn_thongkenhanvien.BackColor = System.Drawing.Color.DarkOrange;
			this.btn_thongkenhanvien.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_thongkenhanvien.Location = new System.Drawing.Point(812, 21);
			this.btn_thongkenhanvien.Name = "btn_thongkenhanvien";
			this.btn_thongkenhanvien.Size = new System.Drawing.Size(115, 40);
			this.btn_thongkenhanvien.TabIndex = 6;
			this.btn_thongkenhanvien.Text = "Thống kê";
			this.btn_thongkenhanvien.UseVisualStyleBackColor = false;
			this.btn_thongkenhanvien.Click += new System.EventHandler(this.btn_thongkenv_Click);
			// 
			// txb_manv
			// 
			this.txb_manv.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txb_manv.Location = new System.Drawing.Point(561, 34);
			this.txb_manv.Name = "txb_manv";
			this.txb_manv.Size = new System.Drawing.Size(176, 27);
			this.txb_manv.TabIndex = 5;
			// 
			// lb_manhanvien
			// 
			this.lb_manhanvien.AutoSize = true;
			this.lb_manhanvien.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_manhanvien.Location = new System.Drawing.Point(374, 38);
			this.lb_manhanvien.Name = "lb_manhanvien";
			this.lb_manhanvien.Size = new System.Drawing.Size(90, 23);
			this.lb_manhanvien.TabIndex = 4;
			this.lb_manhanvien.Text = "Nhân viên";
			// 
			// lb_nam
			// 
			this.lb_nam.AutoSize = true;
			this.lb_nam.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_nam.Location = new System.Drawing.Point(17, 40);
			this.lb_nam.Name = "lb_nam";
			this.lb_nam.Size = new System.Drawing.Size(48, 23);
			this.lb_nam.TabIndex = 1;
			this.lb_nam.Text = "Năm";
			// 
			// dgv_ktkltk
			// 
			this.dgv_ktkltk.AllowUserToAddRows = false;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.Tan;
			this.dgv_ktkltk.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dgv_ktkltk.BackgroundColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgv_ktkltk.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dgv_ktkltk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv_ktkltk.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNV,
            this.TenNV,
            this.Nam,
            this.KhenThuong,
            this.KyLuat});
			this.dgv_ktkltk.Location = new System.Drawing.Point(7, 117);
			this.dgv_ktkltk.Name = "dgv_ktkltk";
			this.dgv_ktkltk.RowHeadersWidth = 51;
			this.dgv_ktkltk.RowTemplate.Height = 24;
			this.dgv_ktkltk.Size = new System.Drawing.Size(737, 657);
			this.dgv_ktkltk.TabIndex = 1;
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
			// Nam
			// 
			this.Nam.DataPropertyName = "Nam";
			this.Nam.HeaderText = "Năm";
			this.Nam.MinimumWidth = 6;
			this.Nam.Name = "Nam";
			this.Nam.Width = 50;
			// 
			// KhenThuong
			// 
			this.KhenThuong.DataPropertyName = "KhenThuong";
			this.KhenThuong.HeaderText = "Khen thưởng";
			this.KhenThuong.MinimumWidth = 6;
			this.KhenThuong.Name = "KhenThuong";
			this.KhenThuong.Width = 125;
			// 
			// KyLuat
			// 
			this.KyLuat.DataPropertyName = "KyLuat";
			this.KyLuat.HeaderText = "Kỷ luật";
			this.KyLuat.MinimumWidth = 6;
			this.KyLuat.Name = "KyLuat";
			this.KyLuat.Width = 125;
			// 
			// panel_chart
			// 
			this.panel_chart.BackColor = System.Drawing.Color.SeaShell;
			this.panel_chart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel_chart.Location = new System.Drawing.Point(747, 117);
			this.panel_chart.Name = "panel_chart";
			this.panel_chart.Size = new System.Drawing.Size(730, 657);
			this.panel_chart.TabIndex = 9;
			// 
			// fThongkekhenthuongkyluat
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.BlanchedAlmond;
			this.ClientSize = new System.Drawing.Size(1482, 778);
			this.Controls.Add(this.panel_chart);
			this.Controls.Add(this.dgv_ktkltk);
			this.Controls.Add(this.panel1);
			this.Name = "fThongkekhenthuongkyluat";
			this.Text = "Thống kê khen thưởng kỷ luật";
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgv_ktkltk)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.DataGridView dgv_ktkltk;
		private System.Windows.Forms.Label lb_nam;
		private System.Windows.Forms.Button btn_thongkenhanvien;
		private System.Windows.Forms.TextBox txb_manv;
		private System.Windows.Forms.Label lb_manhanvien;
		private System.Windows.Forms.Panel panel_chart;
		private System.Windows.Forms.ComboBox cb_nam;
		private System.Windows.Forms.Button btn_dong;
		private System.Windows.Forms.ComboBox cb_nhanvien;
		private System.Windows.Forms.Button btn_xuatbaocao;
		private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
		private System.Windows.Forms.DataGridViewTextBoxColumn TenNV;
		private System.Windows.Forms.DataGridViewTextBoxColumn Nam;
		private System.Windows.Forms.DataGridViewTextBoxColumn KhenThuong;
		private System.Windows.Forms.DataGridViewTextBoxColumn KyLuat;
	}
}