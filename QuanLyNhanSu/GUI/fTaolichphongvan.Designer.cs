﻿namespace QuanLyNhanSu.GUI
{
	partial class fTaolichphongvan
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
			this.btn_themlichphongvan = new System.Windows.Forms.Button();
			this.txb_tenuv = new System.Windows.Forms.TextBox();
			this.lb_tenungvien = new System.Windows.Forms.Label();
			this.lb_ngaypv = new System.Windows.Forms.Label();
			this.lb_nguoiphongvan = new System.Windows.Forms.Label();
			this.lb_diadiem = new System.Windows.Forms.Label();
			this.dtp_ngayphongvan = new System.Windows.Forms.DateTimePicker();
			this.txb_nguoiphongvan = new System.Windows.Forms.TextBox();
			this.btn_dong = new System.Windows.Forms.Button();
			this.lb_giophongvan = new System.Windows.Forms.Label();
			this.dtp_giophongvan = new System.Windows.Forms.DateTimePicker();
			this.cb_diadiem = new System.Windows.Forms.ComboBox();
			this.lb_mahoso = new System.Windows.Forms.Label();
			this.txb_mahs = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// btn_themlichphongvan
			// 
			this.btn_themlichphongvan.BackColor = System.Drawing.Color.DarkOrange;
			this.btn_themlichphongvan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_themlichphongvan.Location = new System.Drawing.Point(206, 419);
			this.btn_themlichphongvan.Name = "btn_themlichphongvan";
			this.btn_themlichphongvan.Size = new System.Drawing.Size(115, 40);
			this.btn_themlichphongvan.TabIndex = 0;
			this.btn_themlichphongvan.Text = "Thêm";
			this.btn_themlichphongvan.UseVisualStyleBackColor = false;
			this.btn_themlichphongvan.Click += new System.EventHandler(this.btn_addlichpv_Click);
			// 
			// txb_tenuv
			// 
			this.txb_tenuv.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txb_tenuv.Location = new System.Drawing.Point(190, 100);
			this.txb_tenuv.Name = "txb_tenuv";
			this.txb_tenuv.Size = new System.Drawing.Size(252, 27);
			this.txb_tenuv.TabIndex = 1;
			// 
			// lb_tenungvien
			// 
			this.lb_tenungvien.AutoSize = true;
			this.lb_tenungvien.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_tenungvien.Location = new System.Drawing.Point(45, 100);
			this.lb_tenungvien.Name = "lb_tenungvien";
			this.lb_tenungvien.Size = new System.Drawing.Size(99, 20);
			this.lb_tenungvien.TabIndex = 5;
			this.lb_tenungvien.Text = "Tên ứng viên";
			// 
			// lb_ngaypv
			// 
			this.lb_ngaypv.AutoSize = true;
			this.lb_ngaypv.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_ngaypv.Location = new System.Drawing.Point(45, 150);
			this.lb_ngaypv.Name = "lb_ngaypv";
			this.lb_ngaypv.Size = new System.Drawing.Size(124, 20);
			this.lb_ngaypv.TabIndex = 6;
			this.lb_ngaypv.Text = "Ngày phỏng vấn";
			// 
			// lb_nguoiphongvan
			// 
			this.lb_nguoiphongvan.AutoSize = true;
			this.lb_nguoiphongvan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_nguoiphongvan.Location = new System.Drawing.Point(45, 250);
			this.lb_nguoiphongvan.Name = "lb_nguoiphongvan";
			this.lb_nguoiphongvan.Size = new System.Drawing.Size(131, 20);
			this.lb_nguoiphongvan.TabIndex = 7;
			this.lb_nguoiphongvan.Text = "Người phỏng vấn";
			// 
			// lb_diadiem
			// 
			this.lb_diadiem.AutoSize = true;
			this.lb_diadiem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_diadiem.Location = new System.Drawing.Point(45, 300);
			this.lb_diadiem.Name = "lb_diadiem";
			this.lb_diadiem.Size = new System.Drawing.Size(71, 20);
			this.lb_diadiem.TabIndex = 8;
			this.lb_diadiem.Text = "Địa điểm";
			// 
			// dtp_ngayphongvan
			// 
			this.dtp_ngayphongvan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtp_ngayphongvan.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtp_ngayphongvan.Location = new System.Drawing.Point(190, 150);
			this.dtp_ngayphongvan.Name = "dtp_ngayphongvan";
			this.dtp_ngayphongvan.Size = new System.Drawing.Size(252, 27);
			this.dtp_ngayphongvan.TabIndex = 9;
			// 
			// txb_nguoiphongvan
			// 
			this.txb_nguoiphongvan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txb_nguoiphongvan.Location = new System.Drawing.Point(190, 244);
			this.txb_nguoiphongvan.Name = "txb_nguoiphongvan";
			this.txb_nguoiphongvan.Size = new System.Drawing.Size(252, 27);
			this.txb_nguoiphongvan.TabIndex = 11;
			// 
			// btn_dong
			// 
			this.btn_dong.BackColor = System.Drawing.Color.DarkOrange;
			this.btn_dong.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_dong.Location = new System.Drawing.Point(327, 419);
			this.btn_dong.Name = "btn_dong";
			this.btn_dong.Size = new System.Drawing.Size(115, 40);
			this.btn_dong.TabIndex = 12;
			this.btn_dong.Text = "Thoát";
			this.btn_dong.UseVisualStyleBackColor = false;
			this.btn_dong.Click += new System.EventHandler(this.btn_close_Click);
			// 
			// lb_giophongvan
			// 
			this.lb_giophongvan.AutoSize = true;
			this.lb_giophongvan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_giophongvan.Location = new System.Drawing.Point(45, 200);
			this.lb_giophongvan.Name = "lb_giophongvan";
			this.lb_giophongvan.Size = new System.Drawing.Size(111, 20);
			this.lb_giophongvan.TabIndex = 13;
			this.lb_giophongvan.Text = "Giờ phỏng vấn";
			// 
			// dtp_giophongvan
			// 
			this.dtp_giophongvan.CalendarFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtp_giophongvan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtp_giophongvan.Format = System.Windows.Forms.DateTimePickerFormat.Time;
			this.dtp_giophongvan.Location = new System.Drawing.Point(190, 200);
			this.dtp_giophongvan.Name = "dtp_giophongvan";
			this.dtp_giophongvan.Size = new System.Drawing.Size(252, 27);
			this.dtp_giophongvan.TabIndex = 14;
			// 
			// cb_diadiem
			// 
			this.cb_diadiem.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cb_diadiem.FormattingEnabled = true;
			this.cb_diadiem.Location = new System.Drawing.Point(190, 300);
			this.cb_diadiem.Name = "cb_diadiem";
			this.cb_diadiem.Size = new System.Drawing.Size(252, 28);
			this.cb_diadiem.TabIndex = 15;
			// 
			// lb_mahoso
			// 
			this.lb_mahoso.AutoSize = true;
			this.lb_mahoso.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_mahoso.Location = new System.Drawing.Point(45, 50);
			this.lb_mahoso.Name = "lb_mahoso";
			this.lb_mahoso.Size = new System.Drawing.Size(73, 20);
			this.lb_mahoso.TabIndex = 16;
			this.lb_mahoso.Text = "Mã hồ sơ";
			// 
			// txb_mahs
			// 
			this.txb_mahs.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txb_mahs.Location = new System.Drawing.Point(190, 50);
			this.txb_mahs.Name = "txb_mahs";
			this.txb_mahs.Size = new System.Drawing.Size(252, 27);
			this.txb_mahs.TabIndex = 17;
			// 
			// fTaolichphongvan
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.BlanchedAlmond;
			this.ClientSize = new System.Drawing.Size(500, 502);
			this.Controls.Add(this.txb_mahs);
			this.Controls.Add(this.lb_mahoso);
			this.Controls.Add(this.cb_diadiem);
			this.Controls.Add(this.dtp_giophongvan);
			this.Controls.Add(this.lb_giophongvan);
			this.Controls.Add(this.btn_dong);
			this.Controls.Add(this.txb_nguoiphongvan);
			this.Controls.Add(this.dtp_ngayphongvan);
			this.Controls.Add(this.lb_diadiem);
			this.Controls.Add(this.lb_nguoiphongvan);
			this.Controls.Add(this.lb_ngaypv);
			this.Controls.Add(this.lb_tenungvien);
			this.Controls.Add(this.txb_tenuv);
			this.Controls.Add(this.btn_themlichphongvan);
			this.Name = "fTaolichphongvan";
			this.Text = "Tạo lịch phỏng vấn";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btn_themlichphongvan;
		private System.Windows.Forms.TextBox txb_tenuv;
		private System.Windows.Forms.Label lb_tenungvien;
		private System.Windows.Forms.Label lb_ngaypv;
		private System.Windows.Forms.Label lb_nguoiphongvan;
		private System.Windows.Forms.Label lb_diadiem;
		private System.Windows.Forms.DateTimePicker dtp_ngayphongvan;
		private System.Windows.Forms.TextBox txb_nguoiphongvan;
		private System.Windows.Forms.Button btn_dong;
		private System.Windows.Forms.Label lb_giophongvan;
		private System.Windows.Forms.DateTimePicker dtp_giophongvan;
		private System.Windows.Forms.ComboBox cb_diadiem;
		private System.Windows.Forms.Label lb_mahoso;
		private System.Windows.Forms.TextBox txb_mahs;
	}
}