namespace QuanLyNhanSu.GUI
{
	partial class fQuanlybangcongUser
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
			this.lb_tonggiolam = new System.Windows.Forms.Label();
			this.lb_tonggio = new System.Windows.Forms.Label();
			this.pn_tongquan = new System.Windows.Forms.Panel();
			this.lb_thang = new System.Windows.Forms.Label();
			this.lb_nam = new System.Windows.Forms.Label();
			this.lb_manhanvien = new System.Windows.Forms.Label();
			this.cb_thang = new System.Windows.Forms.ComboBox();
			this.cb_nam = new System.Windows.Forms.ComboBox();
			this.btn_xuatbaocao = new System.Windows.Forms.Button();
			this.btn_close = new System.Windows.Forms.Button();
			this.label1 = new System.Windows.Forms.Label();
			this.txb_manhanvien = new System.Windows.Forms.TextBox();
			this.txb_tennhanvien = new System.Windows.Forms.TextBox();
			this.pn_quanlybangcong = new System.Windows.Forms.Panel();
			this.btn_xem = new System.Windows.Forms.Button();
			this.panel_calendar = new System.Windows.Forms.Panel();
			this.pn_days = new System.Windows.Forms.Panel();
			this.panel_legend = new System.Windows.Forms.Panel();
			this.label_red = new System.Windows.Forms.Label();
			this.button_red_sample = new System.Windows.Forms.Button();
			this.label_green = new System.Windows.Forms.Label();
			this.button_green_sample = new System.Windows.Forms.Button();
			this.label9 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.pn_tongquan.SuspendLayout();
			this.pn_quanlybangcong.SuspendLayout();
			this.panel_calendar.SuspendLayout();
			this.panel_legend.SuspendLayout();
			this.panel2.SuspendLayout();
			this.SuspendLayout();
			// 
			// lb_tonggiolam
			// 
			this.lb_tonggiolam.AutoSize = true;
			this.lb_tonggiolam.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_tonggiolam.Location = new System.Drawing.Point(690, 42);
			this.lb_tonggiolam.Name = "lb_tonggiolam";
			this.lb_tonggiolam.Size = new System.Drawing.Size(203, 35);
			this.lb_tonggiolam.TabIndex = 0;
			this.lb_tonggiolam.Text = "Tổng số giờ làm";
			// 
			// lb_tonggio
			// 
			this.lb_tonggio.AutoSize = true;
			this.lb_tonggio.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_tonggio.ForeColor = System.Drawing.Color.Black;
			this.lb_tonggio.Location = new System.Drawing.Point(953, 34);
			this.lb_tonggio.Name = "lb_tonggio";
			this.lb_tonggio.Size = new System.Drawing.Size(39, 45);
			this.lb_tonggio.TabIndex = 3;
			this.lb_tonggio.Text = "0";
			// 
			// pn_tongquan
			// 
			this.pn_tongquan.BackColor = System.Drawing.Color.Tan;
			this.pn_tongquan.Controls.Add(this.lb_tonggio);
			this.pn_tongquan.Controls.Add(this.lb_tonggiolam);
			this.pn_tongquan.Dock = System.Windows.Forms.DockStyle.Bottom;
			this.pn_tongquan.Location = new System.Drawing.Point(0, 678);
			this.pn_tongquan.Name = "pn_tongquan";
			this.pn_tongquan.Size = new System.Drawing.Size(1482, 100);
			this.pn_tongquan.TabIndex = 13;
			// 
			// lb_thang
			// 
			this.lb_thang.AutoSize = true;
			this.lb_thang.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_thang.Location = new System.Drawing.Point(551, 80);
			this.lb_thang.Name = "lb_thang";
			this.lb_thang.Size = new System.Drawing.Size(53, 20);
			this.lb_thang.TabIndex = 1;
			this.lb_thang.Text = "Tháng";
			// 
			// lb_nam
			// 
			this.lb_nam.AutoSize = true;
			this.lb_nam.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_nam.Location = new System.Drawing.Point(551, 30);
			this.lb_nam.Name = "lb_nam";
			this.lb_nam.Size = new System.Drawing.Size(43, 20);
			this.lb_nam.TabIndex = 2;
			this.lb_nam.Text = "Năm";
			// 
			// lb_manhanvien
			// 
			this.lb_manhanvien.AutoSize = true;
			this.lb_manhanvien.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_manhanvien.Location = new System.Drawing.Point(34, 30);
			this.lb_manhanvien.Name = "lb_manhanvien";
			this.lb_manhanvien.Size = new System.Drawing.Size(103, 20);
			this.lb_manhanvien.TabIndex = 3;
			this.lb_manhanvien.Text = "Mã nhân viên";
			// 
			// cb_thang
			// 
			this.cb_thang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cb_thang.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cb_thang.FormattingEnabled = true;
			this.cb_thang.Location = new System.Drawing.Point(640, 80);
			this.cb_thang.Name = "cb_thang";
			this.cb_thang.Size = new System.Drawing.Size(100, 28);
			this.cb_thang.TabIndex = 4;
			// 
			// cb_nam
			// 
			this.cb_nam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cb_nam.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cb_nam.FormattingEnabled = true;
			this.cb_nam.Location = new System.Drawing.Point(640, 30);
			this.cb_nam.Name = "cb_nam";
			this.cb_nam.Size = new System.Drawing.Size(100, 28);
			this.cb_nam.TabIndex = 5;
			// 
			// btn_xuatbaocao
			// 
			this.btn_xuatbaocao.BackColor = System.Drawing.Color.DarkOrange;
			this.btn_xuatbaocao.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_xuatbaocao.Location = new System.Drawing.Point(1363, 45);
			this.btn_xuatbaocao.Name = "btn_xuatbaocao";
			this.btn_xuatbaocao.Size = new System.Drawing.Size(137, 40);
			this.btn_xuatbaocao.TabIndex = 8;
			this.btn_xuatbaocao.Text = "Xuất báo cáo";
			this.btn_xuatbaocao.UseVisualStyleBackColor = false;
			this.btn_xuatbaocao.Click += new System.EventHandler(this.btn_xuatbaocao_Click);
			this.btn_xuatbaocao.MouseEnter += new System.EventHandler(this.btn_xuatbaocao_MouseEnter);
			this.btn_xuatbaocao.MouseLeave += new System.EventHandler(this.btn_xuatbaocao_MouseLeave);
			// 
			// btn_close
			// 
			this.btn_close.BackColor = System.Drawing.Color.DarkOrange;
			this.btn_close.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_close.Location = new System.Drawing.Point(1563, 45);
			this.btn_close.Name = "btn_close";
			this.btn_close.Size = new System.Drawing.Size(115, 40);
			this.btn_close.TabIndex = 9;
			this.btn_close.Text = "Đóng";
			this.btn_close.UseVisualStyleBackColor = false;
			this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
			this.btn_close.MouseEnter += new System.EventHandler(this.btn_close_MouseEnter);
			this.btn_close.MouseLeave += new System.EventHandler(this.btn_close_MouseLeave);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(34, 80);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(106, 20);
			this.label1.TabIndex = 10;
			this.label1.Text = "Tên nhân viên";
			// 
			// txb_manhanvien
			// 
			this.txb_manhanvien.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txb_manhanvien.Location = new System.Drawing.Point(180, 30);
			this.txb_manhanvien.Name = "txb_manhanvien";
			this.txb_manhanvien.ReadOnly = true;
			this.txb_manhanvien.Size = new System.Drawing.Size(252, 27);
			this.txb_manhanvien.TabIndex = 11;
			// 
			// txb_tennhanvien
			// 
			this.txb_tennhanvien.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txb_tennhanvien.Location = new System.Drawing.Point(180, 80);
			this.txb_tennhanvien.Name = "txb_tennhanvien";
			this.txb_tennhanvien.ReadOnly = true;
			this.txb_tennhanvien.Size = new System.Drawing.Size(252, 27);
			this.txb_tennhanvien.TabIndex = 12;
			// 
			// pn_quanlybangcong
			// 
			this.pn_quanlybangcong.BackColor = System.Drawing.Color.BlanchedAlmond;
			this.pn_quanlybangcong.Controls.Add(this.txb_tennhanvien);
			this.pn_quanlybangcong.Controls.Add(this.txb_manhanvien);
			this.pn_quanlybangcong.Controls.Add(this.label1);
			this.pn_quanlybangcong.Controls.Add(this.btn_close);
			this.pn_quanlybangcong.Controls.Add(this.btn_xuatbaocao);
			this.pn_quanlybangcong.Controls.Add(this.btn_xem);
			this.pn_quanlybangcong.Controls.Add(this.cb_nam);
			this.pn_quanlybangcong.Controls.Add(this.cb_thang);
			this.pn_quanlybangcong.Controls.Add(this.lb_manhanvien);
			this.pn_quanlybangcong.Controls.Add(this.lb_nam);
			this.pn_quanlybangcong.Controls.Add(this.lb_thang);
			this.pn_quanlybangcong.Dock = System.Windows.Forms.DockStyle.Top;
			this.pn_quanlybangcong.Location = new System.Drawing.Point(0, 0);
			this.pn_quanlybangcong.Name = "pn_quanlybangcong";
			this.pn_quanlybangcong.Size = new System.Drawing.Size(1482, 129);
			this.pn_quanlybangcong.TabIndex = 11;
			// 
			// btn_xem
			// 
			this.btn_xem.BackColor = System.Drawing.Color.DarkOrange;
			this.btn_xem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_xem.Location = new System.Drawing.Point(1190, 45);
			this.btn_xem.Name = "btn_xem";
			this.btn_xem.Size = new System.Drawing.Size(115, 40);
			this.btn_xem.TabIndex = 7;
			this.btn_xem.Text = "Thống kê";
			this.btn_xem.UseVisualStyleBackColor = false;
			this.btn_xem.Click += new System.EventHandler(this.btn_xem_Click);
			this.btn_xem.MouseEnter += new System.EventHandler(this.btn_thongke_MouseEnter);
			this.btn_xem.MouseLeave += new System.EventHandler(this.btn_thongke_MouseLeave);
			// 
			// panel_calendar
			// 
			this.panel_calendar.BackColor = System.Drawing.Color.White;
			this.panel_calendar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.panel_calendar.Controls.Add(this.pn_days);
			this.panel_calendar.Controls.Add(this.panel_legend);
			this.panel_calendar.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel_calendar.Location = new System.Drawing.Point(0, 0);
			this.panel_calendar.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.panel_calendar.Name = "panel_calendar";
			this.panel_calendar.Size = new System.Drawing.Size(1482, 649);
			this.panel_calendar.TabIndex = 1;
			// 
			// pn_days
			// 
			this.pn_days.AutoScroll = true;
			this.pn_days.BackColor = System.Drawing.Color.White;
			this.pn_days.Dock = System.Windows.Forms.DockStyle.Fill;
			this.pn_days.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.pn_days.Location = new System.Drawing.Point(0, 0);
			this.pn_days.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
			this.pn_days.Name = "pn_days";
			this.pn_days.Padding = new System.Windows.Forms.Padding(13, 12, 13, 12);
			this.pn_days.Size = new System.Drawing.Size(1480, 583);
			this.pn_days.TabIndex = 0;
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
			this.panel_legend.Location = new System.Drawing.Point(0, 583);
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
			// panel2
			// 
			this.panel2.Controls.Add(this.panel_calendar);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(0, 129);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1482, 649);
			this.panel2.TabIndex = 12;
			// 
			// fQuanlybangcongUser
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.BlanchedAlmond;
			this.ClientSize = new System.Drawing.Size(1482, 778);
			this.Controls.Add(this.pn_tongquan);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.pn_quanlybangcong);
			this.Name = "fQuanlybangcongUser";
			this.Text = "Bảng công";
			this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
			this.pn_tongquan.ResumeLayout(false);
			this.pn_tongquan.PerformLayout();
			this.pn_quanlybangcong.ResumeLayout(false);
			this.pn_quanlybangcong.PerformLayout();
			this.panel_calendar.ResumeLayout(false);
			this.panel_legend.ResumeLayout(false);
			this.panel_legend.PerformLayout();
			this.panel2.ResumeLayout(false);
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label lb_tonggiolam;
		private System.Windows.Forms.Label lb_tonggio;
		private System.Windows.Forms.Panel pn_tongquan;
		private System.Windows.Forms.Label lb_thang;
		private System.Windows.Forms.Label lb_nam;
		private System.Windows.Forms.Label lb_manhanvien;
		private System.Windows.Forms.ComboBox cb_thang;
		private System.Windows.Forms.ComboBox cb_nam;
		private System.Windows.Forms.Button btn_xuatbaocao;
		private System.Windows.Forms.Button btn_close;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txb_manhanvien;
		private System.Windows.Forms.TextBox txb_tennhanvien;
		private System.Windows.Forms.Panel pn_quanlybangcong;
		private System.Windows.Forms.Button btn_xem;
		private System.Windows.Forms.Panel panel_calendar;
		private System.Windows.Forms.Panel pn_days;
		private System.Windows.Forms.Panel panel_legend;
		private System.Windows.Forms.Label label_red;
		private System.Windows.Forms.Button button_red_sample;
		private System.Windows.Forms.Label label_green;
		private System.Windows.Forms.Button button_green_sample;
		private System.Windows.Forms.Label label9;
		private System.Windows.Forms.Panel panel2;
	}
}