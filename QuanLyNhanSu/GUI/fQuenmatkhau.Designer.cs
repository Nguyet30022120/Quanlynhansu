namespace QuanLyNhanSu.GUI
{
	partial class fQuenmatkhau
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fQuenmatkhau));
			this.lb_header = new System.Windows.Forms.Label();
			this.txb_email = new System.Windows.Forms.TextBox();
			this.btn_guiyeucau = new System.Windows.Forms.Button();
			this.btn_huy = new System.Windows.Forms.Button();
			this.txb_OTP = new System.Windows.Forms.TextBox();
			this.btn_xacnhan = new System.Windows.Forms.Button();
			this.lb_email = new System.Windows.Forms.Label();
			this.lb_maOTP = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// lb_header
			// 
			this.lb_header.AutoSize = true;
			this.lb_header.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_header.Location = new System.Drawing.Point(92, 25);
			this.lb_header.Name = "lb_header";
			this.lb_header.Size = new System.Drawing.Size(385, 23);
			this.lb_header.TabIndex = 0;
			this.lb_header.Text = "NHẬP EMAIL CỦA BẠN ĐỂ LẤY LẠI MẬT KHẨU";
			// 
			// txb_email
			// 
			this.txb_email.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txb_email.Location = new System.Drawing.Point(116, 72);
			this.txb_email.Name = "txb_email";
			this.txb_email.Size = new System.Drawing.Size(403, 27);
			this.txb_email.TabIndex = 3;
			// 
			// btn_guiyeucau
			// 
			this.btn_guiyeucau.BackColor = System.Drawing.Color.DarkOrange;
			this.btn_guiyeucau.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_guiyeucau.Location = new System.Drawing.Point(116, 216);
			this.btn_guiyeucau.Name = "btn_guiyeucau";
			this.btn_guiyeucau.Size = new System.Drawing.Size(115, 40);
			this.btn_guiyeucau.TabIndex = 4;
			this.btn_guiyeucau.Text = "Gửi yêu cầu";
			this.btn_guiyeucau.UseVisualStyleBackColor = false;
			this.btn_guiyeucau.Click += new System.EventHandler(this.btn_laylaimatkhau_Click);
			this.btn_guiyeucau.MouseEnter += new System.EventHandler(this.btn_guiyeucau_MouseEnter);
			this.btn_guiyeucau.MouseLeave += new System.EventHandler(this.btn_guiyeucau_MouseLeave);
			// 
			// btn_huy
			// 
			this.btn_huy.BackColor = System.Drawing.Color.DarkOrange;
			this.btn_huy.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_huy.Location = new System.Drawing.Point(455, 216);
			this.btn_huy.Name = "btn_huy";
			this.btn_huy.Size = new System.Drawing.Size(115, 40);
			this.btn_huy.TabIndex = 5;
			this.btn_huy.Text = "Hủy";
			this.btn_huy.UseVisualStyleBackColor = false;
			this.btn_huy.Click += new System.EventHandler(this.btn_huy_Click);
			this.btn_huy.MouseEnter += new System.EventHandler(this.btn_huy_MouseEnter);
			this.btn_huy.MouseLeave += new System.EventHandler(this.btn_huy_MouseLeave);
			// 
			// txb_OTP
			// 
			this.txb_OTP.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txb_OTP.Location = new System.Drawing.Point(116, 132);
			this.txb_OTP.Name = "txb_OTP";
			this.txb_OTP.Size = new System.Drawing.Size(403, 27);
			this.txb_OTP.TabIndex = 6;
			// 
			// btn_xacnhan
			// 
			this.btn_xacnhan.BackColor = System.Drawing.Color.DarkOrange;
			this.btn_xacnhan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_xacnhan.Location = new System.Drawing.Point(283, 216);
			this.btn_xacnhan.Name = "btn_xacnhan";
			this.btn_xacnhan.Size = new System.Drawing.Size(115, 40);
			this.btn_xacnhan.TabIndex = 7;
			this.btn_xacnhan.Text = "Xác nhận";
			this.btn_xacnhan.UseVisualStyleBackColor = false;
			this.btn_xacnhan.Click += new System.EventHandler(this.btn_xacnhan_Click);
			this.btn_xacnhan.MouseEnter += new System.EventHandler(this.btn_xacnhan_MouseEnter);
			this.btn_xacnhan.MouseLeave += new System.EventHandler(this.btn_xacnhan_MouseLeave);
			// 
			// lb_email
			// 
			this.lb_email.AutoSize = true;
			this.lb_email.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_email.Location = new System.Drawing.Point(31, 72);
			this.lb_email.Name = "lb_email";
			this.lb_email.Size = new System.Drawing.Size(47, 20);
			this.lb_email.TabIndex = 8;
			this.lb_email.Text = "Email";
			// 
			// lb_maOTP
			// 
			this.lb_maOTP.AutoSize = true;
			this.lb_maOTP.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_maOTP.Location = new System.Drawing.Point(31, 135);
			this.lb_maOTP.Name = "lb_maOTP";
			this.lb_maOTP.Size = new System.Drawing.Size(63, 20);
			this.lb_maOTP.TabIndex = 9;
			this.lb_maOTP.Text = "Mã OTP";
			// 
			// fQuenmatkhau
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.BlanchedAlmond;
			this.ClientSize = new System.Drawing.Size(582, 300);
			this.Controls.Add(this.lb_maOTP);
			this.Controls.Add(this.lb_email);
			this.Controls.Add(this.btn_xacnhan);
			this.Controls.Add(this.txb_OTP);
			this.Controls.Add(this.btn_huy);
			this.Controls.Add(this.btn_guiyeucau);
			this.Controls.Add(this.txb_email);
			this.Controls.Add(this.lb_header);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "fQuenmatkhau";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Quên mật khẩu";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lb_header;
		private System.Windows.Forms.TextBox txb_email;
		private System.Windows.Forms.Button btn_guiyeucau;
		private System.Windows.Forms.Button btn_huy;
		private System.Windows.Forms.TextBox txb_OTP;
		private System.Windows.Forms.Button btn_xacnhan;
		private System.Windows.Forms.Label lb_email;
		private System.Windows.Forms.Label lb_maOTP;
	}
}