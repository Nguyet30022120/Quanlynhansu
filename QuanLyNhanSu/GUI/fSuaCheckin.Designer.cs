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
			this.btn_suacheckin = new System.Windows.Forms.Button();
			this.btn_dongcheckin = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lb_manv
			// 
			this.lb_manv.AutoSize = true;
			this.lb_manv.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_manv.Location = new System.Drawing.Point(70, 45);
			this.lb_manv.Name = "lb_manv";
			this.lb_manv.Size = new System.Drawing.Size(103, 20);
			this.lb_manv.TabIndex = 0;
			this.lb_manv.Text = "Mã nhân viên";
			// 
			// lb_tennv
			// 
			this.lb_tennv.AutoSize = true;
			this.lb_tennv.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_tennv.Location = new System.Drawing.Point(70, 95);
			this.lb_tennv.Name = "lb_tennv";
			this.lb_tennv.Size = new System.Drawing.Size(106, 20);
			this.lb_tennv.TabIndex = 1;
			this.lb_tennv.Text = "Tên nhân viên";
			// 
			// lb_giocheckin
			// 
			this.lb_giocheckin.AutoSize = true;
			this.lb_giocheckin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_giocheckin.Location = new System.Drawing.Point(70, 145);
			this.lb_giocheckin.Name = "lb_giocheckin";
			this.lb_giocheckin.Size = new System.Drawing.Size(89, 20);
			this.lb_giocheckin.TabIndex = 2;
			this.lb_giocheckin.Text = "Giờ checkin";
			// 
			// lb_ngaycheckin
			// 
			this.lb_ngaycheckin.AutoSize = true;
			this.lb_ngaycheckin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_ngaycheckin.Location = new System.Drawing.Point(70, 195);
			this.lb_ngaycheckin.Name = "lb_ngaycheckin";
			this.lb_ngaycheckin.Size = new System.Drawing.Size(102, 20);
			this.lb_ngaycheckin.TabIndex = 3;
			this.lb_ngaycheckin.Text = "Ngày checkin";
			// 
			// txb_manv
			// 
			this.txb_manv.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txb_manv.Location = new System.Drawing.Point(230, 45);
			this.txb_manv.Name = "txb_manv";
			this.txb_manv.Size = new System.Drawing.Size(252, 27);
			this.txb_manv.TabIndex = 4;
			// 
			// txb_tennv
			// 
			this.txb_tennv.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txb_tennv.Location = new System.Drawing.Point(230, 95);
			this.txb_tennv.Name = "txb_tennv";
			this.txb_tennv.Size = new System.Drawing.Size(252, 27);
			this.txb_tennv.TabIndex = 5;
			// 
			// dtp_giocheckin
			// 
			this.dtp_giocheckin.CalendarFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtp_giocheckin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtp_giocheckin.Format = System.Windows.Forms.DateTimePickerFormat.Time;
			this.dtp_giocheckin.Location = new System.Drawing.Point(230, 145);
			this.dtp_giocheckin.Name = "dtp_giocheckin";
			this.dtp_giocheckin.Size = new System.Drawing.Size(252, 27);
			this.dtp_giocheckin.TabIndex = 6;
			// 
			// dtp_ngaycheckin
			// 
			this.dtp_ngaycheckin.CalendarFont = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtp_ngaycheckin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.dtp_ngaycheckin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
			this.dtp_ngaycheckin.Location = new System.Drawing.Point(230, 195);
			this.dtp_ngaycheckin.Name = "dtp_ngaycheckin";
			this.dtp_ngaycheckin.Size = new System.Drawing.Size(252, 27);
			this.dtp_ngaycheckin.TabIndex = 7;
			// 
			// btn_suacheckin
			// 
			this.btn_suacheckin.BackColor = System.Drawing.Color.DarkOrange;
			this.btn_suacheckin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_suacheckin.Location = new System.Drawing.Point(265, 275);
			this.btn_suacheckin.Name = "btn_suacheckin";
			this.btn_suacheckin.Size = new System.Drawing.Size(115, 40);
			this.btn_suacheckin.TabIndex = 8;
			this.btn_suacheckin.Text = "Sửa";
			this.btn_suacheckin.UseVisualStyleBackColor = false;
			this.btn_suacheckin.Click += new System.EventHandler(this.btn_editcheckin_Click);
			// 
			// btn_dongcheckin
			// 
			this.btn_dongcheckin.BackColor = System.Drawing.Color.DarkOrange;
			this.btn_dongcheckin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_dongcheckin.Location = new System.Drawing.Point(420, 275);
			this.btn_dongcheckin.Name = "btn_dongcheckin";
			this.btn_dongcheckin.Size = new System.Drawing.Size(115, 40);
			this.btn_dongcheckin.TabIndex = 9;
			this.btn_dongcheckin.Text = "Đóng";
			this.btn_dongcheckin.UseVisualStyleBackColor = false;
			this.btn_dongcheckin.Click += new System.EventHandler(this.btn_closecheckin_Click);
			// 
			// fSuaCheckin
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.BlanchedAlmond;
			this.ClientSize = new System.Drawing.Size(582, 353);
			this.Controls.Add(this.btn_dongcheckin);
			this.Controls.Add(this.btn_suacheckin);
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
		private System.Windows.Forms.Button btn_suacheckin;
		private System.Windows.Forms.Button btn_dongcheckin;
	}
}