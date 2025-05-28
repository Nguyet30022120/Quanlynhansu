namespace QuanLyNhanSu
{
	partial class fDoimatkhau
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
			this.txb_matkhaucu = new System.Windows.Forms.TextBox();
			this.txb_matkhaumoi = new System.Windows.Forms.TextBox();
			this.txb_nhaplaimatkhaumoi = new System.Windows.Forms.TextBox();
			this.lb_matkhaucu = new System.Windows.Forms.Label();
			this.lb_matkhaumoi = new System.Windows.Forms.Label();
			this.lb_nhaplaimatkhau = new System.Windows.Forms.Label();
			this.btn_doimatkhau = new System.Windows.Forms.Button();
			this.btn_dong = new System.Windows.Forms.Button();
			this.lb_matk = new System.Windows.Forms.Label();
			this.txb_matk = new System.Windows.Forms.TextBox();
			this.SuspendLayout();
			// 
			// txb_matkhaucu
			// 
			this.txb_matkhaucu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txb_matkhaucu.Location = new System.Drawing.Point(245, 140);
			this.txb_matkhaucu.Name = "txb_matkhaucu";
			this.txb_matkhaucu.Size = new System.Drawing.Size(252, 27);
			this.txb_matkhaucu.TabIndex = 0;
			// 
			// txb_matkhaumoi
			// 
			this.txb_matkhaumoi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txb_matkhaumoi.Location = new System.Drawing.Point(245, 205);
			this.txb_matkhaumoi.Name = "txb_matkhaumoi";
			this.txb_matkhaumoi.Size = new System.Drawing.Size(252, 27);
			this.txb_matkhaumoi.TabIndex = 1;
			// 
			// txb_nhaplaimatkhaumoi
			// 
			this.txb_nhaplaimatkhaumoi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txb_nhaplaimatkhaumoi.Location = new System.Drawing.Point(245, 265);
			this.txb_nhaplaimatkhaumoi.Name = "txb_nhaplaimatkhaumoi";
			this.txb_nhaplaimatkhaumoi.Size = new System.Drawing.Size(252, 27);
			this.txb_nhaplaimatkhaumoi.TabIndex = 2;
			// 
			// lb_matkhaucu
			// 
			this.lb_matkhaucu.AutoSize = true;
			this.lb_matkhaucu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_matkhaucu.Location = new System.Drawing.Point(45, 140);
			this.lb_matkhaucu.Name = "lb_matkhaucu";
			this.lb_matkhaucu.Size = new System.Drawing.Size(95, 20);
			this.lb_matkhaucu.TabIndex = 3;
			this.lb_matkhaucu.Text = "Mật khẩu cũ";
			// 
			// lb_matkhaumoi
			// 
			this.lb_matkhaumoi.AutoSize = true;
			this.lb_matkhaumoi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_matkhaumoi.Location = new System.Drawing.Point(45, 205);
			this.lb_matkhaumoi.Name = "lb_matkhaumoi";
			this.lb_matkhaumoi.Size = new System.Drawing.Size(106, 20);
			this.lb_matkhaumoi.TabIndex = 4;
			this.lb_matkhaumoi.Text = "Mật khẩu mới";
			// 
			// lb_nhaplaimatkhau
			// 
			this.lb_nhaplaimatkhau.AutoSize = true;
			this.lb_nhaplaimatkhau.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_nhaplaimatkhau.Location = new System.Drawing.Point(45, 265);
			this.lb_nhaplaimatkhau.Name = "lb_nhaplaimatkhau";
			this.lb_nhaplaimatkhau.Size = new System.Drawing.Size(168, 20);
			this.lb_nhaplaimatkhau.TabIndex = 5;
			this.lb_nhaplaimatkhau.Text = "Nhập lại mật khẩu mới";
			// 
			// btn_doimatkhau
			// 
			this.btn_doimatkhau.BackColor = System.Drawing.Color.DarkOrange;
			this.btn_doimatkhau.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_doimatkhau.Location = new System.Drawing.Point(300, 341);
			this.btn_doimatkhau.Name = "btn_doimatkhau";
			this.btn_doimatkhau.Size = new System.Drawing.Size(115, 40);
			this.btn_doimatkhau.TabIndex = 6;
			this.btn_doimatkhau.Text = "Đổi mật khẩu";
			this.btn_doimatkhau.UseVisualStyleBackColor = false;
			this.btn_doimatkhau.Click += new System.EventHandler(this.btn_doimatkhau_Click);
			// 
			// btn_dong
			// 
			this.btn_dong.BackColor = System.Drawing.Color.DarkOrange;
			this.btn_dong.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_dong.Location = new System.Drawing.Point(415, 341);
			this.btn_dong.Name = "btn_dong";
			this.btn_dong.Size = new System.Drawing.Size(115, 40);
			this.btn_dong.TabIndex = 7;
			this.btn_dong.Text = "Đóng";
			this.btn_dong.UseVisualStyleBackColor = false;
			this.btn_dong.Click += new System.EventHandler(this.btn_exit_Click);
			// 
			// lb_matk
			// 
			this.lb_matk.AutoSize = true;
			this.lb_matk.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_matk.Location = new System.Drawing.Point(45, 75);
			this.lb_matk.Name = "lb_matk";
			this.lb_matk.Size = new System.Drawing.Size(100, 20);
			this.lb_matk.TabIndex = 8;
			this.lb_matk.Text = "Mã tài khoản";
			// 
			// txb_matk
			// 
			this.txb_matk.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txb_matk.Location = new System.Drawing.Point(245, 75);
			this.txb_matk.Name = "txb_matk";
			this.txb_matk.Size = new System.Drawing.Size(252, 27);
			this.txb_matk.TabIndex = 9;
			// 
			// fDoimatkhau
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.BlanchedAlmond;
			this.ClientSize = new System.Drawing.Size(582, 413);
			this.Controls.Add(this.txb_matk);
			this.Controls.Add(this.lb_matk);
			this.Controls.Add(this.btn_dong);
			this.Controls.Add(this.btn_doimatkhau);
			this.Controls.Add(this.lb_nhaplaimatkhau);
			this.Controls.Add(this.lb_matkhaumoi);
			this.Controls.Add(this.lb_matkhaucu);
			this.Controls.Add(this.txb_nhaplaimatkhaumoi);
			this.Controls.Add(this.txb_matkhaumoi);
			this.Controls.Add(this.txb_matkhaucu);
			this.Name = "fDoimatkhau";
			this.Text = "Đổi mật khẩu";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txb_matkhaucu;
		private System.Windows.Forms.TextBox txb_matkhaumoi;
		private System.Windows.Forms.TextBox txb_nhaplaimatkhaumoi;
		private System.Windows.Forms.Label lb_matkhaucu;
		private System.Windows.Forms.Label lb_matkhaumoi;
		private System.Windows.Forms.Label lb_nhaplaimatkhau;
		private System.Windows.Forms.Button btn_doimatkhau;
		private System.Windows.Forms.Button btn_dong;
		private System.Windows.Forms.Label lb_matk;
		private System.Windows.Forms.TextBox txb_matk;
	}
}