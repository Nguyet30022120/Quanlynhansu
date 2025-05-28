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
			this.lb_nhapemail = new System.Windows.Forms.Label();
			this.txb_email = new System.Windows.Forms.TextBox();
			this.btn_laylaimatkhau = new System.Windows.Forms.Button();
			this.btn_huy = new System.Windows.Forms.Button();
			this.SuspendLayout();
			// 
			// lb_nhapemail
			// 
			this.lb_nhapemail.AutoSize = true;
			this.lb_nhapemail.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_nhapemail.Location = new System.Drawing.Point(54, 46);
			this.lb_nhapemail.Name = "lb_nhapemail";
			this.lb_nhapemail.Size = new System.Drawing.Size(327, 23);
			this.lb_nhapemail.TabIndex = 0;
			this.lb_nhapemail.Text = "Nhập email của bạn để lấy lại mật khẩu";
			// 
			// txb_email
			// 
			this.txb_email.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txb_email.Location = new System.Drawing.Point(58, 107);
			this.txb_email.Name = "txb_email";
			this.txb_email.Size = new System.Drawing.Size(403, 27);
			this.txb_email.TabIndex = 3;
			// 
			// btn_laylaimatkhau
			// 
			this.btn_laylaimatkhau.BackColor = System.Drawing.Color.DarkOrange;
			this.btn_laylaimatkhau.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_laylaimatkhau.Location = new System.Drawing.Point(306, 190);
			this.btn_laylaimatkhau.Name = "btn_laylaimatkhau";
			this.btn_laylaimatkhau.Size = new System.Drawing.Size(115, 40);
			this.btn_laylaimatkhau.TabIndex = 4;
			this.btn_laylaimatkhau.Text = "Gửi yêu cầu";
			this.btn_laylaimatkhau.UseVisualStyleBackColor = false;
			this.btn_laylaimatkhau.Click += new System.EventHandler(this.btn_laylaimatkhau_Click);
			// 
			// btn_huy
			// 
			this.btn_huy.BackColor = System.Drawing.Color.DarkOrange;
			this.btn_huy.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_huy.Location = new System.Drawing.Point(459, 190);
			this.btn_huy.Name = "btn_huy";
			this.btn_huy.Size = new System.Drawing.Size(115, 40);
			this.btn_huy.TabIndex = 5;
			this.btn_huy.Text = "Hủy";
			this.btn_huy.UseVisualStyleBackColor = false;
			this.btn_huy.Click += new System.EventHandler(this.btn_huy_Click);
			// 
			// fQuenmatkhau
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(582, 300);
			this.Controls.Add(this.btn_huy);
			this.Controls.Add(this.btn_laylaimatkhau);
			this.Controls.Add(this.txb_email);
			this.Controls.Add(this.lb_nhapemail);
			this.Name = "fQuenmatkhau";
			this.Text = "Quên mật khẩu";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lb_nhapemail;
		private System.Windows.Forms.TextBox txb_email;
		private System.Windows.Forms.Button btn_laylaimatkhau;
		private System.Windows.Forms.Button btn_huy;
	}
}