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
			this.lb_manv = new System.Windows.Forms.Label();
			this.lb_tennv = new System.Windows.Forms.Label();
			this.lb_giocheckout = new System.Windows.Forms.Label();
			this.lb_ngaycheckout = new System.Windows.Forms.Label();
			this.txb_manv = new System.Windows.Forms.TextBox();
			this.txb_tennv = new System.Windows.Forms.TextBox();
			this.dtp_giocheckout = new System.Windows.Forms.DateTimePicker();
			this.dtp_ngaycheckout = new System.Windows.Forms.DateTimePicker();
			this.btn_editcheckout = new System.Windows.Forms.Button();
			this.btn_closecheckout = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lb_manv
			// 
			this.lb_manv.AutoSize = true;
			this.lb_manv.Location = new System.Drawing.Point(123, 122);
			this.lb_manv.Name = "lb_manv";
			this.lb_manv.Size = new System.Drawing.Size(86, 16);
			this.lb_manv.TabIndex = 0;
			this.lb_manv.Text = "Mã nhân viên";
			// 
			// lb_tennv
			// 
			this.lb_tennv.AutoSize = true;
			this.lb_tennv.Location = new System.Drawing.Point(123, 224);
			this.lb_tennv.Name = "lb_tennv";
			this.lb_tennv.Size = new System.Drawing.Size(91, 16);
			this.lb_tennv.TabIndex = 1;
			this.lb_tennv.Text = "Tên nhân viên";
			// 
			// lb_giocheckout
			// 
			this.lb_giocheckout.AutoSize = true;
			this.lb_giocheckout.Location = new System.Drawing.Point(123, 322);
			this.lb_giocheckout.Name = "lb_giocheckout";
			this.lb_giocheckout.Size = new System.Drawing.Size(85, 16);
			this.lb_giocheckout.TabIndex = 2;
			this.lb_giocheckout.Text = "Giờ checkout";
			// 
			// lb_ngaycheckout
			// 
			this.lb_ngaycheckout.AutoSize = true;
			this.lb_ngaycheckout.Location = new System.Drawing.Point(123, 413);
			this.lb_ngaycheckout.Name = "lb_ngaycheckout";
			this.lb_ngaycheckout.Size = new System.Drawing.Size(97, 16);
			this.lb_ngaycheckout.TabIndex = 3;
			this.lb_ngaycheckout.Text = "Ngày checkout";
			// 
			// txb_manv
			// 
			this.txb_manv.Location = new System.Drawing.Point(226, 122);
			this.txb_manv.Name = "txb_manv";
			this.txb_manv.Size = new System.Drawing.Size(100, 22);
			this.txb_manv.TabIndex = 4;
			// 
			// txb_tennv
			// 
			this.txb_tennv.Location = new System.Drawing.Point(226, 218);
			this.txb_tennv.Name = "txb_tennv";
			this.txb_tennv.Size = new System.Drawing.Size(100, 22);
			this.txb_tennv.TabIndex = 5;
			// 
			// dtp_giocheckout
			// 
			this.dtp_giocheckout.Format = System.Windows.Forms.DateTimePickerFormat.Time;
			this.dtp_giocheckout.Location = new System.Drawing.Point(226, 315);
			this.dtp_giocheckout.Name = "dtp_giocheckout";
			this.dtp_giocheckout.Size = new System.Drawing.Size(200, 22);
			this.dtp_giocheckout.TabIndex = 6;
			// 
			// dtp_ngaycheckout
			// 
			this.dtp_ngaycheckout.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtp_ngaycheckout.Location = new System.Drawing.Point(226, 413);
			this.dtp_ngaycheckout.Name = "dtp_ngaycheckout";
			this.dtp_ngaycheckout.Size = new System.Drawing.Size(200, 22);
			this.dtp_ngaycheckout.TabIndex = 7;
			// 
			// btn_editcheckout
			// 
			this.btn_editcheckout.Location = new System.Drawing.Point(370, 490);
			this.btn_editcheckout.Name = "btn_editcheckout";
			this.btn_editcheckout.Size = new System.Drawing.Size(75, 23);
			this.btn_editcheckout.TabIndex = 8;
			this.btn_editcheckout.Text = "Sửa";
			this.btn_editcheckout.UseVisualStyleBackColor = true;
			this.btn_editcheckout.Click += new System.EventHandler(this.btn_editcheckout_Click_1);
			// 
			// btn_closecheckout
			// 
			this.btn_closecheckout.Location = new System.Drawing.Point(551, 490);
			this.btn_closecheckout.Name = "btn_closecheckout";
			this.btn_closecheckout.Size = new System.Drawing.Size(75, 23);
			this.btn_closecheckout.TabIndex = 9;
			this.btn_closecheckout.Text = "Đóng";
			this.btn_closecheckout.UseVisualStyleBackColor = true;
			this.btn_closecheckout.Click += new System.EventHandler(this.btn_closecheckout_Click);
			// 
			// fSuaCheckout
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(707, 725);
			this.Controls.Add(this.btn_closecheckout);
			this.Controls.Add(this.btn_editcheckout);
			this.Controls.Add(this.dtp_ngaycheckout);
			this.Controls.Add(this.dtp_giocheckout);
			this.Controls.Add(this.txb_tennv);
			this.Controls.Add(this.txb_manv);
			this.Controls.Add(this.lb_ngaycheckout);
			this.Controls.Add(this.lb_giocheckout);
			this.Controls.Add(this.lb_tennv);
			this.Controls.Add(this.lb_manv);
			this.Name = "fSuaCheckout";
			this.Text = "Sửa checkout";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lb_manv;
		private System.Windows.Forms.Label lb_tennv;
		private System.Windows.Forms.Label lb_giocheckout;
		private System.Windows.Forms.Label lb_ngaycheckout;
		private System.Windows.Forms.TextBox txb_manv;
		private System.Windows.Forms.TextBox txb_tennv;
		private System.Windows.Forms.DateTimePicker dtp_giocheckout;
		private System.Windows.Forms.DateTimePicker dtp_ngaycheckout;
		private System.Windows.Forms.Button btn_editcheckout;
		private System.Windows.Forms.Button btn_closecheckout;
	}
}