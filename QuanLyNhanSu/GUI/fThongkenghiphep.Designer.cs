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
			this.btn_thongkenv = new System.Windows.Forms.Button();
			this.btn_thongketheongay = new System.Windows.Forms.Button();
			this.txb_manv = new System.Windows.Forms.TextBox();
			this.lb_maNV = new System.Windows.Forms.Label();
			this.lb_tennv = new System.Windows.Forms.Label();
			this.lb_ngaybd = new System.Windows.Forms.Label();
			this.dtp_ngaybd = new System.Windows.Forms.DateTimePicker();
			this.lb_ngaykt = new System.Windows.Forms.Label();
			this.dtp_ngaykt = new System.Windows.Forms.DateTimePicker();
			this.dgv_nghipheptk = new System.Windows.Forms.DataGridView();
			this.lb_name = new System.Windows.Forms.Label();
			this.btn_load = new System.Windows.Forms.Button();
			this.panel_chart = new System.Windows.Forms.Panel();
			this.elementHost1 = new System.Windows.Forms.Integration.ElementHost();
			this.cartesianChart1 = new LiveCharts.Wpf.CartesianChart();
			((System.ComponentModel.ISupportInitialize)(this.dgv_nghipheptk)).BeginInit();
			this.panel_chart.SuspendLayout();
			this.SuspendLayout();
			// 
			// btn_thongkenv
			// 
			this.btn_thongkenv.Location = new System.Drawing.Point(383, 73);
			this.btn_thongkenv.Name = "btn_thongkenv";
			this.btn_thongkenv.Size = new System.Drawing.Size(75, 23);
			this.btn_thongkenv.TabIndex = 1;
			this.btn_thongkenv.Text = "Thống kê";
			this.btn_thongkenv.UseVisualStyleBackColor = true;
			this.btn_thongkenv.Click += new System.EventHandler(this.btn_thongkenv_Click);
			// 
			// btn_thongketheongay
			// 
			this.btn_thongketheongay.Location = new System.Drawing.Point(383, 210);
			this.btn_thongketheongay.Name = "btn_thongketheongay";
			this.btn_thongketheongay.Size = new System.Drawing.Size(75, 23);
			this.btn_thongketheongay.TabIndex = 2;
			this.btn_thongketheongay.Text = "Thống kê";
			this.btn_thongketheongay.UseVisualStyleBackColor = true;
			this.btn_thongketheongay.Click += new System.EventHandler(this.btn_thongketheongay_Click);
			// 
			// txb_manv
			// 
			this.txb_manv.Location = new System.Drawing.Point(163, 44);
			this.txb_manv.Name = "txb_manv";
			this.txb_manv.Size = new System.Drawing.Size(100, 22);
			this.txb_manv.TabIndex = 3;
			// 
			// lb_maNV
			// 
			this.lb_maNV.AutoSize = true;
			this.lb_maNV.Location = new System.Drawing.Point(28, 49);
			this.lb_maNV.Name = "lb_maNV";
			this.lb_maNV.Size = new System.Drawing.Size(86, 16);
			this.lb_maNV.TabIndex = 6;
			this.lb_maNV.Text = "Mã nhân viên";
			// 
			// lb_tennv
			// 
			this.lb_tennv.AutoSize = true;
			this.lb_tennv.Location = new System.Drawing.Point(31, 137);
			this.lb_tennv.Name = "lb_tennv";
			this.lb_tennv.Size = new System.Drawing.Size(91, 16);
			this.lb_tennv.TabIndex = 7;
			this.lb_tennv.Text = "Tên nhân viên";
			// 
			// lb_ngaybd
			// 
			this.lb_ngaybd.AutoSize = true;
			this.lb_ngaybd.Location = new System.Drawing.Point(31, 190);
			this.lb_ngaybd.Name = "lb_ngaybd";
			this.lb_ngaybd.Size = new System.Drawing.Size(56, 16);
			this.lb_ngaybd.TabIndex = 8;
			this.lb_ngaybd.Text = "Từ ngày";
			// 
			// dtp_ngaybd
			// 
			this.dtp_ngaybd.Location = new System.Drawing.Point(163, 184);
			this.dtp_ngaybd.Name = "dtp_ngaybd";
			this.dtp_ngaybd.Size = new System.Drawing.Size(200, 22);
			this.dtp_ngaybd.TabIndex = 9;
			// 
			// lb_ngaykt
			// 
			this.lb_ngaykt.AutoSize = true;
			this.lb_ngaykt.Location = new System.Drawing.Point(31, 248);
			this.lb_ngaykt.Name = "lb_ngaykt";
			this.lb_ngaykt.Size = new System.Drawing.Size(64, 16);
			this.lb_ngaykt.TabIndex = 10;
			this.lb_ngaykt.Text = "Đến ngày";
			// 
			// dtp_ngaykt
			// 
			this.dtp_ngaykt.Location = new System.Drawing.Point(163, 242);
			this.dtp_ngaykt.Name = "dtp_ngaykt";
			this.dtp_ngaykt.Size = new System.Drawing.Size(200, 22);
			this.dtp_ngaykt.TabIndex = 11;
			// 
			// dgv_nghipheptk
			// 
			this.dgv_nghipheptk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv_nghipheptk.Location = new System.Drawing.Point(481, 12);
			this.dgv_nghipheptk.Name = "dgv_nghipheptk";
			this.dgv_nghipheptk.RowHeadersWidth = 51;
			this.dgv_nghipheptk.RowTemplate.Height = 24;
			this.dgv_nghipheptk.Size = new System.Drawing.Size(538, 252);
			this.dgv_nghipheptk.TabIndex = 12;
			// 
			// lb_name
			// 
			this.lb_name.AutoSize = true;
			this.lb_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_name.Location = new System.Drawing.Point(179, 137);
			this.lb_name.Name = "lb_name";
			this.lb_name.Size = new System.Drawing.Size(79, 20);
			this.lb_name.TabIndex = 14;
			this.lb_name.Text = "lb_name";
			// 
			// btn_load
			// 
			this.btn_load.Location = new System.Drawing.Point(38, 260);
			this.btn_load.Name = "btn_load";
			this.btn_load.Size = new System.Drawing.Size(75, 23);
			this.btn_load.TabIndex = 15;
			this.btn_load.Text = "Load";
			this.btn_load.UseVisualStyleBackColor = true;
			this.btn_load.Click += new System.EventHandler(this.btn_load_Click_1);
			// 
			// panel_chart
			// 
			this.panel_chart.Controls.Add(this.elementHost1);
			this.panel_chart.Location = new System.Drawing.Point(13, 289);
			this.panel_chart.Name = "panel_chart";
			this.panel_chart.Size = new System.Drawing.Size(1006, 407);
			this.panel_chart.TabIndex = 13;
			// 
			// elementHost1
			// 
			this.elementHost1.Location = new System.Drawing.Point(18, 22);
			this.elementHost1.Name = "elementHost1";
			this.elementHost1.Size = new System.Drawing.Size(973, 370);
			this.elementHost1.TabIndex = 0;
			this.elementHost1.Text = "elementHost1";
			this.elementHost1.Child = this.cartesianChart1;
			// 
			// fOnLeavingStatistics
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1031, 708);
			this.Controls.Add(this.btn_load);
			this.Controls.Add(this.lb_name);
			this.Controls.Add(this.panel_chart);
			this.Controls.Add(this.dgv_nghipheptk);
			this.Controls.Add(this.dtp_ngaykt);
			this.Controls.Add(this.lb_ngaykt);
			this.Controls.Add(this.dtp_ngaybd);
			this.Controls.Add(this.lb_ngaybd);
			this.Controls.Add(this.lb_tennv);
			this.Controls.Add(this.lb_maNV);
			this.Controls.Add(this.txb_manv);
			this.Controls.Add(this.btn_thongketheongay);
			this.Controls.Add(this.btn_thongkenv);
			this.Name = "fOnLeavingStatistics";
			this.Text = "fOnLeavingStatistics";
			this.Load += new System.EventHandler(this.fOnLeavingStatistics_Load_1);
			((System.ComponentModel.ISupportInitialize)(this.dgv_nghipheptk)).EndInit();
			this.panel_chart.ResumeLayout(false);
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btn_thongkenv;
		private System.Windows.Forms.Button btn_thongketheongay;
		private System.Windows.Forms.TextBox txb_manv;
		private System.Windows.Forms.Label lb_maNV;
		private System.Windows.Forms.Label lb_tennv;
		private System.Windows.Forms.Label lb_ngaybd;
		private System.Windows.Forms.DateTimePicker dtp_ngaybd;
		private System.Windows.Forms.Label lb_ngaykt;
		private System.Windows.Forms.DateTimePicker dtp_ngaykt;
		private System.Windows.Forms.DataGridView dgv_nghipheptk;
		private System.Windows.Forms.Label lb_name;
		private System.Windows.Forms.Button btn_load;
		private System.Windows.Forms.Panel panel_chart;
		private System.Windows.Forms.Integration.ElementHost elementHost1;
		private LiveCharts.Wpf.CartesianChart cartesianChart1;
	}
}