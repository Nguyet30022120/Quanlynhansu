namespace QuanLyNhanSu.GUI
{
	partial class fSuaCheckout
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
			this.lb_manhanvien = new System.Windows.Forms.Label();
			this.lb_tennhanvien = new System.Windows.Forms.Label();
			this.lb_giocheckout = new System.Windows.Forms.Label();
			this.lb_ngaycheckout = new System.Windows.Forms.Label();
			this.txb_manhanvien = new System.Windows.Forms.TextBox();
			this.txb_tennhanvien = new System.Windows.Forms.TextBox();
			this.dtp_giocheckout = new System.Windows.Forms.DateTimePicker();
			this.dtp_ngaycheckout = new System.Windows.Forms.DateTimePicker();
			this.btn_suacheckout = new System.Windows.Forms.Button();
			this.btn_dongcheckout = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lb_manhanvien
			// 
			this.lb_manhanvien.AutoSize = true;
			this.lb_manhanvien.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_manhanvien.Location = new System.Drawing.Point(70, 45);
			this.lb_manhanvien.Name = "lb_manhanvien";
			this.lb_manhanvien.Size = new System.Drawing.Size(103, 20);
			this.lb_manhanvien.TabIndex = 0;
			this.lb_manhanvien.Text = "Mã nhân viên";
			// 
			// lb_tennhanvien
			// 
			this.lb_tennhanvien.AutoSize = true;
			this.lb_tennhanvien.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_tennhanvien.Location = new System.Drawing.Point(70, 95);
			this.lb_tennhanvien.Name = "lb_tennhanvien";
			this.lb_tennhanvien.Size = new System.Drawing.Size(106, 20);
			this.lb_tennhanvien.TabIndex = 1;
			this.lb_tennhanvien.Text = "Tên nhân viên";
			// 
			// lb_giocheckout
			// 
			this.lb_giocheckout.AutoSize = true;
			this.lb_giocheckout.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_giocheckout.Location = new System.Drawing.Point(70, 145);
			this.lb_giocheckout.Name = "lb_giocheckout";
			this.lb_giocheckout.Size = new System.Drawing.Size(100, 20);
			this.lb_giocheckout.TabIndex = 2;
			this.lb_giocheckout.Text = "Giờ checkout";
			// 
			// lb_ngaycheckout
			// 
			this.lb_ngaycheckout.AutoSize = true;
			this.lb_ngaycheckout.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_ngaycheckout.Location = new System.Drawing.Point(70, 195);
			this.lb_ngaycheckout.Name = "lb_ngaycheckout";
			this.lb_ngaycheckout.Size = new System.Drawing.Size(113, 20);
			this.lb_ngaycheckout.TabIndex = 3;
			this.lb_ngaycheckout.Text = "Ngày checkout";
			// 
			// txb_manhanvien
			// 
			this.txb_manhanvien.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txb_manhanvien.Location = new System.Drawing.Point(230, 45);
			this.txb_manhanvien.Name = "txb_manhanvien";
			this.txb_manhanvien.Size = new System.Drawing.Size(252, 27);
			this.txb_manhanvien.TabIndex = 4;
			// 
			// txb_tennhanvien
			// 
			this.txb_tennhanvien.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txb_tennhanvien.Location = new System.Drawing.Point(230, 95);
			this.txb_tennhanvien.Name = "txb_tennhanvien";
			this.txb_tennhanvien.Size = new System.Drawing.Size(252, 27);
			this.txb_tennhanvien.TabIndex = 5;
			// 
			// dtp_giocheckout
			// 
			this.dtp_giocheckout.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtp_giocheckout.Format = System.Windows.Forms.DateTimePickerFormat.Time;
			this.dtp_giocheckout.Location = new System.Drawing.Point(230, 145);
			this.dtp_giocheckout.Name = "dtp_giocheckout";
			this.dtp_giocheckout.Size = new System.Drawing.Size(252, 27);
			this.dtp_giocheckout.TabIndex = 6;
			// 
			// dtp_ngaycheckout
			// 
			this.dtp_ngaycheckout.CalendarFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtp_ngaycheckout.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtp_ngaycheckout.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtp_ngaycheckout.Location = new System.Drawing.Point(230, 195);
			this.dtp_ngaycheckout.Name = "dtp_ngaycheckout";
			this.dtp_ngaycheckout.Size = new System.Drawing.Size(252, 27);
			this.dtp_ngaycheckout.TabIndex = 7;
			// 
			// btn_suacheckout
			// 
			this.btn_suacheckout.BackColor = System.Drawing.Color.DarkOrange;
			this.btn_suacheckout.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_suacheckout.Location = new System.Drawing.Point(265, 275);
			this.btn_suacheckout.Name = "btn_suacheckout";
			this.btn_suacheckout.Size = new System.Drawing.Size(115, 40);
			this.btn_suacheckout.TabIndex = 8;
			this.btn_suacheckout.Text = "Sửa";
			this.btn_suacheckout.UseVisualStyleBackColor = false;
			this.btn_suacheckout.Click += new System.EventHandler(this.btn_editcheckout_Click_1);
			// 
			// btn_dongcheckout
			// 
			this.btn_dongcheckout.BackColor = System.Drawing.Color.DarkOrange;
			this.btn_dongcheckout.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_dongcheckout.Location = new System.Drawing.Point(430, 275);
			this.btn_dongcheckout.Name = "btn_dongcheckout";
			this.btn_dongcheckout.Size = new System.Drawing.Size(115, 40);
			this.btn_dongcheckout.TabIndex = 9;
			this.btn_dongcheckout.Text = "Đóng";
			this.btn_dongcheckout.UseVisualStyleBackColor = false;
			this.btn_dongcheckout.Click += new System.EventHandler(this.btn_closecheckout_Click);
			// 
			// fSuaCheckout
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.BlanchedAlmond;
			this.ClientSize = new System.Drawing.Size(582, 353);
			this.Controls.Add(this.btn_dongcheckout);
			this.Controls.Add(this.btn_suacheckout);
			this.Controls.Add(this.dtp_ngaycheckout);
			this.Controls.Add(this.dtp_giocheckout);
			this.Controls.Add(this.txb_tennhanvien);
			this.Controls.Add(this.txb_manhanvien);
			this.Controls.Add(this.lb_ngaycheckout);
			this.Controls.Add(this.lb_giocheckout);
			this.Controls.Add(this.lb_tennhanvien);
			this.Controls.Add(this.lb_manhanvien);
			this.Name = "fSuaCheckout";
			this.Text = "Sửa checkout";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lb_manhanvien;
		private System.Windows.Forms.Label lb_tennhanvien;
		private System.Windows.Forms.Label lb_giocheckout;
		private System.Windows.Forms.Label lb_ngaycheckout;
		private System.Windows.Forms.TextBox txb_manhanvien;
		private System.Windows.Forms.TextBox txb_tennhanvien;
		private System.Windows.Forms.DateTimePicker dtp_giocheckout;
		private System.Windows.Forms.DateTimePicker dtp_ngaycheckout;
		private System.Windows.Forms.Button btn_suacheckout;
		private System.Windows.Forms.Button btn_dongcheckout;
	}
}