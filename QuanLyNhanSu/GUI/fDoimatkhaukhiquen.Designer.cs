namespace QuanLyNhanSu.GUI
{
	partial class fDoimatkhaukhiquen
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
			this.txb_tendangnhap = new System.Windows.Forms.TextBox();
			this.lb_matk = new System.Windows.Forms.Label();
			this.btn_dong = new System.Windows.Forms.Button();
			this.btn_doimatkhau = new System.Windows.Forms.Button();
			this.lb_nhaplaimatkhau = new System.Windows.Forms.Label();
			this.lb_matkhaumoi = new System.Windows.Forms.Label();
			this.txb_nhaplaimatkhaumoi = new System.Windows.Forms.TextBox();
			this.txb_matkhaumoi = new System.Windows.Forms.TextBox();
			this.txb_email = new System.Windows.Forms.TextBox();
			this.lb_email = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// txb_tendangnhap
			// 
			this.txb_tendangnhap.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txb_tendangnhap.Location = new System.Drawing.Point(249, 118);
			this.txb_tendangnhap.Name = "txb_tendangnhap";
			this.txb_tendangnhap.Size = new System.Drawing.Size(252, 27);
			this.txb_tendangnhap.TabIndex = 19;
			// 
			// lb_matk
			// 
			this.lb_matk.AutoSize = true;
			this.lb_matk.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_matk.Location = new System.Drawing.Point(49, 118);
			this.lb_matk.Name = "lb_matk";
			this.lb_matk.Size = new System.Drawing.Size(112, 20);
			this.lb_matk.TabIndex = 18;
			this.lb_matk.Text = "Tên đăng nhập";
			// 
			// btn_dong
			// 
			this.btn_dong.BackColor = System.Drawing.Color.DarkOrange;
			this.btn_dong.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_dong.Location = new System.Drawing.Point(419, 325);
			this.btn_dong.Name = "btn_dong";
			this.btn_dong.Size = new System.Drawing.Size(115, 40);
			this.btn_dong.TabIndex = 17;
			this.btn_dong.Text = "Đóng";
			this.btn_dong.UseVisualStyleBackColor = false;
			this.btn_dong.Click += new System.EventHandler(this.btn_dong_Click);
			// 
			// btn_doimatkhau
			// 
			this.btn_doimatkhau.BackColor = System.Drawing.Color.DarkOrange;
			this.btn_doimatkhau.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_doimatkhau.Location = new System.Drawing.Point(281, 325);
			this.btn_doimatkhau.Name = "btn_doimatkhau";
			this.btn_doimatkhau.Size = new System.Drawing.Size(132, 40);
			this.btn_doimatkhau.TabIndex = 16;
			this.btn_doimatkhau.Text = "Đổi mật khẩu";
			this.btn_doimatkhau.UseVisualStyleBackColor = false;
			this.btn_doimatkhau.Click += new System.EventHandler(this.btn_doimatkhau_Click_1);
			// 
			// lb_nhaplaimatkhau
			// 
			this.lb_nhaplaimatkhau.AutoSize = true;
			this.lb_nhaplaimatkhau.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_nhaplaimatkhau.Location = new System.Drawing.Point(49, 238);
			this.lb_nhaplaimatkhau.Name = "lb_nhaplaimatkhau";
			this.lb_nhaplaimatkhau.Size = new System.Drawing.Size(168, 20);
			this.lb_nhaplaimatkhau.TabIndex = 15;
			this.lb_nhaplaimatkhau.Text = "Nhập lại mật khẩu mới";
			// 
			// lb_matkhaumoi
			// 
			this.lb_matkhaumoi.AutoSize = true;
			this.lb_matkhaumoi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_matkhaumoi.Location = new System.Drawing.Point(49, 178);
			this.lb_matkhaumoi.Name = "lb_matkhaumoi";
			this.lb_matkhaumoi.Size = new System.Drawing.Size(106, 20);
			this.lb_matkhaumoi.TabIndex = 14;
			this.lb_matkhaumoi.Text = "Mật khẩu mới";
			// 
			// txb_nhaplaimatkhaumoi
			// 
			this.txb_nhaplaimatkhaumoi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txb_nhaplaimatkhaumoi.Location = new System.Drawing.Point(249, 238);
			this.txb_nhaplaimatkhaumoi.Name = "txb_nhaplaimatkhaumoi";
			this.txb_nhaplaimatkhaumoi.Size = new System.Drawing.Size(252, 27);
			this.txb_nhaplaimatkhaumoi.TabIndex = 12;
			// 
			// txb_matkhaumoi
			// 
			this.txb_matkhaumoi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txb_matkhaumoi.Location = new System.Drawing.Point(249, 178);
			this.txb_matkhaumoi.Name = "txb_matkhaumoi";
			this.txb_matkhaumoi.Size = new System.Drawing.Size(252, 27);
			this.txb_matkhaumoi.TabIndex = 11;
			// 
			// txb_email
			// 
			this.txb_email.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txb_email.Location = new System.Drawing.Point(249, 60);
			this.txb_email.Name = "txb_email";
			this.txb_email.Size = new System.Drawing.Size(252, 27);
			this.txb_email.TabIndex = 20;
			// 
			// lb_email
			// 
			this.lb_email.AutoSize = true;
			this.lb_email.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_email.Location = new System.Drawing.Point(49, 58);
			this.lb_email.Name = "lb_email";
			this.lb_email.Size = new System.Drawing.Size(47, 20);
			this.lb_email.TabIndex = 21;
			this.lb_email.Text = "Email";
			// 
			// fDoimatkhaukhiquen
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.BlanchedAlmond;
			this.ClientSize = new System.Drawing.Size(582, 413);
			this.Controls.Add(this.lb_email);
			this.Controls.Add(this.txb_email);
			this.Controls.Add(this.txb_tendangnhap);
			this.Controls.Add(this.lb_matk);
			this.Controls.Add(this.btn_dong);
			this.Controls.Add(this.btn_doimatkhau);
			this.Controls.Add(this.lb_nhaplaimatkhau);
			this.Controls.Add(this.lb_matkhaumoi);
			this.Controls.Add(this.txb_nhaplaimatkhaumoi);
			this.Controls.Add(this.txb_matkhaumoi);
			this.Name = "fDoimatkhaukhiquen";
			this.Text = "fDoimatkhaukhiquen";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txb_tendangnhap;
		private System.Windows.Forms.Label lb_matk;
		private System.Windows.Forms.Button btn_dong;
		private System.Windows.Forms.Button btn_doimatkhau;
		private System.Windows.Forms.Label lb_nhaplaimatkhau;
		private System.Windows.Forms.Label lb_matkhaumoi;
		private System.Windows.Forms.TextBox txb_nhaplaimatkhaumoi;
		private System.Windows.Forms.TextBox txb_matkhaumoi;
		private System.Windows.Forms.TextBox txb_email;
		private System.Windows.Forms.Label lb_email;
	}
}