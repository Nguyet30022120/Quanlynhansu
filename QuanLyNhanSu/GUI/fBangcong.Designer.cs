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
			this.panel1 = new System.Windows.Forms.Panel();
			this.btn_debug_test = new System.Windows.Forms.Button();
			this.btn_close = new System.Windows.Forms.Button();
			this.btn_xuatbaocao = new System.Windows.Forms.Button();
			this.btn_xem = new System.Windows.Forms.Button();
			this.cb_nhanvien = new System.Windows.Forms.ComboBox();
			this.cb_nam = new System.Windows.Forms.ComboBox();
			this.cb_thang = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.lb_nam = new System.Windows.Forms.Label();
			this.lb_thang = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.panel_calendar = new System.Windows.Forms.Panel();
			this.panel_days = new System.Windows.Forms.Panel();
			this.panel_legend = new System.Windows.Forms.Panel();
			this.label_red = new System.Windows.Forms.Label();
			this.button_red_sample = new System.Windows.Forms.Button();
			this.label_green = new System.Windows.Forms.Label();
			this.button_green_sample = new System.Windows.Forms.Button();
			this.label9 = new System.Windows.Forms.Label();
			this.panel3 = new System.Windows.Forms.Panel();
			this.lbl_tongngayvang = new System.Windows.Forms.Label();
			this.lbl_tongngaylam = new System.Windows.Forms.Label();
			this.lbl_tonggio = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.panel1.SuspendLayout();
			this.panel2.SuspendLayout();
			this.panel_calendar.SuspendLayout();
			this.panel_legend.SuspendLayout();
			this.panel3.SuspendLayout();
			this.SuspendLayout();
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.LightBlue;
			this.panel1.Controls.Add(this.btn_close);
			this.panel1.Controls.Add(this.btn_xuatbaocao);
			this.panel1.Controls.Add(this.btn_xem);
			this.panel1.Controls.Add(this.cb_nhanvien);
			this.panel1.Controls.Add(this.cb_nam);
			this.panel1.Controls.Add(this.cb_thang);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.lb_nam);
			this.panel1.Controls.Add(this.lb_thang);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1482, 129);
			this.panel1.TabIndex = 0;
			// 
			// btn_debug_test
			// 
			this.btn_debug_test.BackColor = System.Drawing.Color.Orange;
			this.btn_debug_test.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold);
			this.btn_debug_test.Location = new System.Drawing.Point(56, 40);
			this.btn_debug_test.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
			this.btn_debug_test.Name = "btn_debug_test";
			this.btn_debug_test.Size = new System.Drawing.Size(120, 44);
			this.btn_debug_test.TabIndex = 10;
			this.btn_debug_test.Text = "🔍 Test DB";
			this.btn_debug_test.UseVisualStyleBackColor = false;
			this.btn_debug_test.Click += new System.EventHandler(this.btn_test_debug_Click);
			// 
			// btn_close
			// 
			this.btn_close.BackColor = System.Drawing.Color.DarkOrange;
			this.btn_close.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_close.Location = new System.Drawing.Point(1350, 22);
			this.btn_close.Name = "btn_close";
			this.btn_close.Size = new System.Drawing.Size(115, 40);
			this.btn_close.TabIndex = 9;
			this.btn_close.Text = "Đóng";
			this.btn_close.UseVisualStyleBackColor = false;
			this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
			// 
			// btn_xuatbaocao
			// 
			this.btn_xuatbaocao.BackColor = System.Drawing.Color.DarkOrange;
			this.btn_xuatbaocao.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_xuatbaocao.Location = new System.Drawing.Point(1109, 22);
			this.btn_xuatbaocao.Name = "btn_xuatbaocao";
			this.btn_xuatbaocao.Size = new System.Drawing.Size(137, 40);
			this.btn_xuatbaocao.TabIndex = 8;
			this.btn_xuatbaocao.Text = "Xuất báo cáo";
			this.btn_xuatbaocao.UseVisualStyleBackColor = false;
			this.btn_xuatbaocao.Click += new System.EventHandler(this.btn_xuatbaocao_Click);
			// 
			// btn_xem
			// 
			this.btn_xem.BackColor = System.Drawing.Color.DarkOrange;
			this.btn_xem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_xem.Location = new System.Drawing.Point(889, 22);
			this.btn_xem.Name = "btn_xem";
			this.btn_xem.Size = new System.Drawing.Size(115, 40);
			this.btn_xem.TabIndex = 7;
			this.btn_xem.Text = "Thống kê";
			this.btn_xem.UseVisualStyleBackColor = false;
			this.btn_xem.Click += new System.EventHandler(this.btn_xem_Click);
			// 
			// cb_nhanvien
			// 
			this.cb_nhanvien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cb_nhanvien.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cb_nhanvien.FormattingEnabled = true;
			this.cb_nhanvien.Location = new System.Drawing.Point(632, 29);
			this.cb_nhanvien.Name = "cb_nhanvien";
			this.cb_nhanvien.Size = new System.Drawing.Size(200, 28);
			this.cb_nhanvien.TabIndex = 6;
			this.cb_nhanvien.SelectedIndexChanged += new System.EventHandler(this.cb_nhanvien_SelectedIndexChanged);
			// 
			// cb_nam
			// 
			this.cb_nam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cb_nam.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cb_nam.FormattingEnabled = true;
			this.cb_nam.Location = new System.Drawing.Point(353, 29);
			this.cb_nam.Name = "cb_nam";
			this.cb_nam.Size = new System.Drawing.Size(100, 28);
			this.cb_nam.TabIndex = 5;
			this.cb_nam.SelectedIndexChanged += new System.EventHandler(this.cb_nam_SelectedIndexChanged);
			// 
			// cb_thang
			// 
			this.cb_thang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cb_thang.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cb_thang.FormattingEnabled = true;
			this.cb_thang.Location = new System.Drawing.Point(109, 29);
			this.cb_thang.Name = "cb_thang";
			this.cb_thang.Size = new System.Drawing.Size(100, 28);
			this.cb_thang.TabIndex = 4;
			this.cb_thang.SelectedIndexChanged += new System.EventHandler(this.cb_thang_SelectedIndexChanged);
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(506, 32);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(90, 23);
			this.label4.TabIndex = 3;
			this.label4.Text = "Nhân viên";
			// 
			// lb_nam
			// 
			this.lb_nam.AutoSize = true;
			this.lb_nam.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_nam.Location = new System.Drawing.Point(267, 33);
			this.lb_nam.Name = "lb_nam";
			this.lb_nam.Size = new System.Drawing.Size(48, 23);
			this.lb_nam.TabIndex = 2;
			this.lb_nam.Text = "Năm";
			// 
			// lb_thang
			// 
			this.lb_thang.AutoSize = true;
			this.lb_thang.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_thang.Location = new System.Drawing.Point(34, 30);
			this.lb_thang.Name = "lb_thang";
			this.lb_thang.Size = new System.Drawing.Size(60, 23);
			this.lb_thang.TabIndex = 1;
			this.lb_thang.Text = "Tháng";
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.panel_calendar);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(0, 129);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1482, 549);
			this.panel2.TabIndex = 1;
			// 
			// panel_calendar
			// 
			this.panel_calendar.BackColor = System.Drawing.Color.White;
			this.panel_calendar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel_calendar.Controls.Add(this.panel_days);
			this.panel_calendar.Controls.Add(this.panel_legend);
			this.panel_calendar.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel_calendar.Location = new System.Drawing.Point(0, 0);
			this.panel_calendar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.panel_calendar.Name = "panel_calendar";
			this.panel_calendar.Size = new System.Drawing.Size(1482, 549);
			this.panel_calendar.TabIndex = 1;
			// 
			// panel_days
			// 
			this.panel_days.AutoScroll = true;
			this.panel_days.BackColor = System.Drawing.Color.White;
			this.panel_days.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel_days.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.panel_days.Location = new System.Drawing.Point(0, 0);
			this.panel_days.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.panel_days.Name = "panel_days";
			this.panel_days.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
			this.panel_days.Size = new System.Drawing.Size(1480, 483);
			this.panel_days.TabIndex = 0;
			// 
			// panel_legend
			// 
			this.panel_legend.BackColor = System.Drawing.Color.BlanchedAlmond;
			this.panel_legend.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel_legend.Controls.Add(this.label_red);
			this.panel_legend.Controls.Add(this.button_red_sample);
			this.panel_legend.Controls.Add(this.label_green);
			this.panel_legend.Controls.Add(this.button_green_sample);
			this.panel_legend.Controls.Add(this.label9);
			this.panel_legend.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel_legend.Location = new System.Drawing.Point(0, 483);
			this.panel_legend.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.panel_legend.Name = "panel_legend";
			this.panel_legend.Size = new System.Drawing.Size(1480, 64);
			this.panel_legend.TabIndex = 2;
			// 
			// label_red
			// 
			this.label_red.AutoSize = true;
			this.label_red.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_red.Location = new System.Drawing.Point(78, 34);
			this.label_red.Name = "label_red";
			this.label_red.Size = new System.Drawing.Size(125, 20);
			this.label_red.TabIndex = 4;
			this.label_red.Text = "Chưa chấm công";
			// 
			// button_red_sample
			// 
			this.button_red_sample.BackColor = System.Drawing.Color.OrangeRed;
			this.button_red_sample.Enabled = false;
			this.button_red_sample.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button_red_sample.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_red_sample.ForeColor = System.Drawing.Color.White;
			this.button_red_sample.Location = new System.Drawing.Point(36, 30);
			this.button_red_sample.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.button_red_sample.Name = "button_red_sample";
			this.button_red_sample.Size = new System.Drawing.Size(31, 28);
			this.button_red_sample.TabIndex = 3;
			this.button_red_sample.Text = "X";
			this.button_red_sample.UseVisualStyleBackColor = false;
			// 
			// label_green
			// 
			this.label_green.AutoSize = true;
			this.label_green.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label_green.Location = new System.Drawing.Point(322, 35);
			this.label_green.Name = "label_green";
			this.label_green.Size = new System.Drawing.Size(108, 20);
			this.label_green.TabIndex = 2;
			this.label_green.Text = "Đã chấm công";
			// 
			// button_green_sample
			// 
			this.button_green_sample.BackColor = System.Drawing.Color.LightGreen;
			this.button_green_sample.Enabled = false;
			this.button_green_sample.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.button_green_sample.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.button_green_sample.ForeColor = System.Drawing.Color.White;
			this.button_green_sample.Location = new System.Drawing.Point(269, 30);
			this.button_green_sample.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.button_green_sample.Name = "button_green_sample";
			this.button_green_sample.Size = new System.Drawing.Size(31, 28);
			this.button_green_sample.TabIndex = 1;
			this.button_green_sample.Text = "✓";
			this.button_green_sample.UseVisualStyleBackColor = false;
			// 
			// label9
			// 
			this.label9.BackColor = System.Drawing.Color.DarkGray;
			this.label9.Dock = System.Windows.Forms.DockStyle.Top;
			this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.ForeColor = System.Drawing.Color.Black;
			this.label9.Location = new System.Drawing.Point(0, 0);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(1478, 28);
			this.label9.TabIndex = 0;
			this.label9.Text = "CHÚ THÍCH";
			this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// panel3
			// 
			this.panel3.BackColor = System.Drawing.Color.Tan;
			this.panel3.Controls.Add(this.lbl_tongngayvang);
			this.panel3.Controls.Add(this.lbl_tongngaylam);
			this.panel3.Controls.Add(this.lbl_tonggio);
			this.panel3.Controls.Add(this.label7);
			this.panel3.Controls.Add(this.label6);
			this.panel3.Controls.Add(this.label5);
			this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.panel3.Location = new System.Drawing.Point(0, 678);
			this.panel3.Name = "panel3";
			this.panel3.Size = new System.Drawing.Size(1482, 100);
			this.panel3.TabIndex = 2;
			// 
			// lbl_tongngayvang
			// 
			this.lbl_tongngayvang.AutoSize = true;
			this.lbl_tongngayvang.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_tongngayvang.ForeColor = System.Drawing.Color.Black;
			this.lbl_tongngayvang.Location = new System.Drawing.Point(1441, 47);
			this.lbl_tongngayvang.Name = "lbl_tongngayvang";
			this.lbl_tongngayvang.Size = new System.Drawing.Size(24, 28);
			this.lbl_tongngayvang.TabIndex = 5;
			this.lbl_tongngayvang.Text = "0";
			// 
			// lbl_tongngaylam
			// 
			this.lbl_tongngaylam.AutoSize = true;
			this.lbl_tongngaylam.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_tongngaylam.ForeColor = System.Drawing.Color.Black;
			this.lbl_tongngaylam.Location = new System.Drawing.Point(808, 47);
			this.lbl_tongngaylam.Name = "lbl_tongngaylam";
			this.lbl_tongngaylam.Size = new System.Drawing.Size(24, 28);
			this.lbl_tongngaylam.TabIndex = 4;
			this.lbl_tongngaylam.Text = "0";
			// 
			// lbl_tonggio
			// 
			this.lbl_tonggio.AutoSize = true;
			this.lbl_tonggio.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lbl_tonggio.ForeColor = System.Drawing.Color.Black;
			this.lbl_tonggio.Location = new System.Drawing.Point(205, 47);
			this.lbl_tonggio.Name = "lbl_tonggio";
			this.lbl_tonggio.Size = new System.Drawing.Size(24, 28);
			this.lbl_tonggio.TabIndex = 3;
			this.lbl_tonggio.Text = "0";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label7.Location = new System.Drawing.Point(1244, 47);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(191, 28);
			this.label7.TabIndex = 2;
			this.label7.Text = "Tổng số ngày vắng";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label6.Location = new System.Drawing.Point(618, 47);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(180, 28);
			this.label6.TabIndex = 1;
			this.label6.Text = "Tổng số ngày làm";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label5.Location = new System.Drawing.Point(12, 47);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(165, 28);
			this.label5.TabIndex = 0;
			this.label5.Text = "Tổng số giờ làm";
			// 
			// fBangcong
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(1482, 778);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel3);
			this.Controls.Add(this.panel1);
			this.Name = "fBangcong";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Bảng Chấm Công";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.panel_calendar.ResumeLayout(false);
			this.panel_legend.ResumeLayout(false);
			this.panel_legend.PerformLayout();
			this.panel3.ResumeLayout(false);
			this.panel3.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Button btn_debug_test;
		private System.Windows.Forms.Button btn_close;
		private System.Windows.Forms.Button btn_xuatbaocao;
		private System.Windows.Forms.Button btn_xem;
		private System.Windows.Forms.ComboBox cb_nhanvien;
		private System.Windows.Forms.ComboBox cb_nam;
		private System.Windows.Forms.ComboBox cb_thang;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.Label lb_nam;
		private System.Windows.Forms.Label lb_thang;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.Panel panel3;
		private System.Windows.Forms.Label lbl_tongngayvang;
		private System.Windows.Forms.Label lbl_tongngaylam;
		private System.Windows.Forms.Label lbl_tonggio;
		private System.Windows.Forms.Label label7;
		private System.Windows.Forms.Label label6;
		private System.Windows.Forms.Label label5;
		private System.Windows.Forms.Panel panel_calendar;
		private System.Windows.Forms.Panel panel_days;
		private System.Windows.Forms.Panel panel_legend;
		private System.Windows.Forms.Label label_red;
		private System.Windows.Forms.Button button_red_sample;
		private System.Windows.Forms.Label label_green;
		private System.Windows.Forms.Button button_green_sample;
		private System.Windows.Forms.Label label9;
	}
} 