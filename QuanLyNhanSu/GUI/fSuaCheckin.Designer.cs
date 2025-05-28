namespace QuanLyNhanSu.GUI
{
	partial class fSuaCheckin
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
			this.lb_giocheckin = new System.Windows.Forms.Label();
			this.lb_ngaycheckin = new System.Windows.Forms.Label();
			this.txb_manv = new System.Windows.Forms.TextBox();
			this.txb_tennv = new System.Windows.Forms.TextBox();
			this.dtp_giocheckin = new System.Windows.Forms.DateTimePicker();
			this.dtp_ngaycheckin = new System.Windows.Forms.DateTimePicker();
			this.btn_editcheckin = new System.Windows.Forms.Button();
			this.btn_closecheckin = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lb_manv
			// 
			this.lb_manv.AutoSize = true;
			this.lb_manv.Location = new System.Drawing.Point(109, 138);
			this.lb_manv.Name = "lb_manv";
			this.lb_manv.Size = new System.Drawing.Size(86, 16);
			this.lb_manv.TabIndex = 0;
			this.lb_manv.Text = "Mã nhân viên";
			// 
			// lb_tennv
			// 
			this.lb_tennv.AutoSize = true;
			this.lb_tennv.Location = new System.Drawing.Point(109, 208);
			this.lb_tennv.Name = "lb_tennv";
			this.lb_tennv.Size = new System.Drawing.Size(91, 16);
			this.lb_tennv.TabIndex = 1;
			this.lb_tennv.Text = "Tên nhân viên";
			// 
			// lb_giocheckin
			// 
			this.lb_giocheckin.AutoSize = true;
			this.lb_giocheckin.Location = new System.Drawing.Point(109, 288);
			this.lb_giocheckin.Name = "lb_giocheckin";
			this.lb_giocheckin.Size = new System.Drawing.Size(77, 16);
			this.lb_giocheckin.TabIndex = 2;
			this.lb_giocheckin.Text = "Giờ checkin";
			// 
			// lb_ngaycheckin
			// 
			this.lb_ngaycheckin.AutoSize = true;
			this.lb_ngaycheckin.Location = new System.Drawing.Point(109, 350);
			this.lb_ngaycheckin.Name = "lb_ngaycheckin";
			this.lb_ngaycheckin.Size = new System.Drawing.Size(89, 16);
			this.lb_ngaycheckin.TabIndex = 3;
			this.lb_ngaycheckin.Text = "Ngày checkin";
			// 
			// txb_manv
			// 
			this.txb_manv.Location = new System.Drawing.Point(230, 131);
			this.txb_manv.Name = "txb_manv";
			this.txb_manv.Size = new System.Drawing.Size(100, 22);
			this.txb_manv.TabIndex = 4;
			// 
			// txb_tennv
			// 
			this.txb_tennv.Location = new System.Drawing.Point(230, 202);
			this.txb_tennv.Name = "txb_tennv";
			this.txb_tennv.Size = new System.Drawing.Size(100, 22);
			this.txb_tennv.TabIndex = 5;
			// 
			// dtp_giocheckin
			// 
			this.dtp_giocheckin.Format = System.Windows.Forms.DateTimePickerFormat.Time;
			this.dtp_giocheckin.Location = new System.Drawing.Point(230, 288);
			this.dtp_giocheckin.Name = "dtp_giocheckin";
			this.dtp_giocheckin.Size = new System.Drawing.Size(200, 22);
			this.dtp_giocheckin.TabIndex = 6;
			// 
			// dtp_ngaycheckin
			// 
			this.dtp_ngaycheckin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtp_ngaycheckin.Location = new System.Drawing.Point(230, 350);
			this.dtp_ngaycheckin.Name = "dtp_ngaycheckin";
			this.dtp_ngaycheckin.Size = new System.Drawing.Size(200, 22);
			this.dtp_ngaycheckin.TabIndex = 7;
			// 
			// btn_editcheckin
			// 
			this.btn_editcheckin.Location = new System.Drawing.Point(294, 459);
			this.btn_editcheckin.Name = "btn_editcheckin";
			this.btn_editcheckin.Size = new System.Drawing.Size(75, 23);
			this.btn_editcheckin.TabIndex = 8;
			this.btn_editcheckin.Text = "Sửa";
			this.btn_editcheckin.UseVisualStyleBackColor = true;
			this.btn_editcheckin.Click += new System.EventHandler(this.btn_editcheckin_Click);
			// 
			// btn_closecheckin
			// 
			this.btn_closecheckin.Location = new System.Drawing.Point(458, 459);
			this.btn_closecheckin.Name = "btn_closecheckin";
			this.btn_closecheckin.Size = new System.Drawing.Size(75, 23);
			this.btn_closecheckin.TabIndex = 9;
			this.btn_closecheckin.Text = "Đóng";
			this.btn_closecheckin.UseVisualStyleBackColor = true;
			this.btn_closecheckin.Click += new System.EventHandler(this.btn_closecheckin_Click);
			// 
			// fSuaCheckin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(644, 670);
			this.Controls.Add(this.btn_closecheckin);
			this.Controls.Add(this.btn_editcheckin);
			this.Controls.Add(this.dtp_ngaycheckin);
			this.Controls.Add(this.dtp_giocheckin);
			this.Controls.Add(this.txb_tennv);
			this.Controls.Add(this.txb_manv);
			this.Controls.Add(this.lb_ngaycheckin);
			this.Controls.Add(this.lb_giocheckin);
			this.Controls.Add(this.lb_tennv);
			this.Controls.Add(this.lb_manv);
			this.Name = "fSuaCheckin";
			this.Text = "Sửa checkin";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lb_manv;
		private System.Windows.Forms.Label lb_tennv;
		private System.Windows.Forms.Label lb_giocheckin;
		private System.Windows.Forms.Label lb_ngaycheckin;
		private System.Windows.Forms.TextBox txb_manv;
		private System.Windows.Forms.TextBox txb_tennv;
		private System.Windows.Forms.DateTimePicker dtp_giocheckin;
		private System.Windows.Forms.DateTimePicker dtp_ngaycheckin;
		private System.Windows.Forms.Button btn_editcheckin;
		private System.Windows.Forms.Button btn_closecheckin;
	}
}