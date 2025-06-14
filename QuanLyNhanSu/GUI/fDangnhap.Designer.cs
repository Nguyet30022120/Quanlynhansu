namespace QuanLyNhanSu
{
	partial class fDangnhap
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fDangnhap));
			this.colorDialog1 = new System.Windows.Forms.ColorDialog();
			this.lb_password = new System.Windows.Forms.Label();
			this.txb_username = new System.Windows.Forms.TextBox();
			this.lb_username = new System.Windows.Forms.Label();
			this.btn_login = new System.Windows.Forms.Button();
			this.txb_password = new System.Windows.Forms.TextBox();
			this.btn_exit = new System.Windows.Forms.Button();
			this.lb_header = new System.Windows.Forms.Label();
			this.lb_quenmk = new System.Windows.Forms.Label();
			this.chb_hienmk = new System.Windows.Forms.CheckBox();
			this.SuspendLayout();
			// 
			// lb_password
			// 
			this.lb_password.AutoSize = true;
			this.lb_password.BackColor = System.Drawing.Color.Transparent;
			this.lb_password.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_password.Location = new System.Drawing.Point(859, 407);
			this.lb_password.Name = "lb_password";
			this.lb_password.Size = new System.Drawing.Size(75, 20);
			this.lb_password.TabIndex = 1;
			this.lb_password.Text = "Mật khẩu";
			// 
			// txb_username
			// 
			this.txb_username.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
			this.txb_username.BackColor = System.Drawing.Color.White;
			this.txb_username.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txb_username.Location = new System.Drawing.Point(998, 345);
			this.txb_username.Name = "txb_username";
			this.txb_username.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txb_username.Size = new System.Drawing.Size(252, 27);
			this.txb_username.TabIndex = 4;
			this.txb_username.Text = "admin";
			// 
			// lb_username
			// 
			this.lb_username.AutoSize = true;
			this.lb_username.BackColor = System.Drawing.Color.Transparent;
			this.lb_username.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_username.Location = new System.Drawing.Point(859, 348);
			this.lb_username.Name = "lb_username";
			this.lb_username.Size = new System.Drawing.Size(112, 20);
			this.lb_username.TabIndex = 0;
			this.lb_username.Text = "Tên đăng nhập";
			// 
			// btn_login
			// 
			this.btn_login.BackColor = System.Drawing.Color.DarkOrange;
			this.btn_login.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
			this.btn_login.Location = new System.Drawing.Point(998, 520);
			this.btn_login.Name = "btn_login";
			this.btn_login.Size = new System.Drawing.Size(115, 40);
			this.btn_login.TabIndex = 2;
			this.btn_login.Text = "Đăng nhập";
			this.btn_login.UseVisualStyleBackColor = false;
			this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
			this.btn_login.MouseEnter += new System.EventHandler(this.btn_login_MouseEnter);
			this.btn_login.MouseLeave += new System.EventHandler(this.btn_login_MouseLeave);
			// 
			// txb_password
			// 
			this.txb_password.BackColor = System.Drawing.Color.White;
			this.txb_password.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txb_password.Location = new System.Drawing.Point(998, 404);
			this.txb_password.Name = "txb_password";
			this.txb_password.ScrollBars = System.Windows.Forms.ScrollBars.Both;
			this.txb_password.Size = new System.Drawing.Size(252, 27);
			this.txb_password.TabIndex = 5;
			this.txb_password.Text = "1";
			this.txb_password.UseSystemPasswordChar = true;
			// 
			// btn_exit
			// 
			this.btn_exit.BackColor = System.Drawing.Color.DarkOrange;
			this.btn_exit.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_exit.Location = new System.Drawing.Point(1135, 520);
			this.btn_exit.Name = "btn_exit";
			this.btn_exit.Size = new System.Drawing.Size(115, 40);
			this.btn_exit.TabIndex = 3;
			this.btn_exit.Text = "Thoát";
			this.btn_exit.UseVisualStyleBackColor = false;
			this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
			this.btn_exit.MouseEnter += new System.EventHandler(this.btn_exit_MouseEnter);
			this.btn_exit.MouseLeave += new System.EventHandler(this.btn_exit_MouseLeave);
			// 
			// lb_header
			// 
			this.lb_header.AutoSize = true;
			this.lb_header.BackColor = System.Drawing.Color.BlanchedAlmond;
			this.lb_header.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_header.Location = new System.Drawing.Point(867, 250);
			this.lb_header.Name = "lb_header";
			this.lb_header.Size = new System.Drawing.Size(383, 35);
			this.lb_header.TabIndex = 6;
			this.lb_header.Text = "Vui lòng đăng nhập để sử dụng";
			// 
			// lb_quenmk
			// 
			this.lb_quenmk.AutoSize = true;
			this.lb_quenmk.BackColor = System.Drawing.Color.BlanchedAlmond;
			this.lb_quenmk.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_quenmk.Location = new System.Drawing.Point(1058, 594);
			this.lb_quenmk.Name = "lb_quenmk";
			this.lb_quenmk.Size = new System.Drawing.Size(108, 20);
			this.lb_quenmk.TabIndex = 7;
			this.lb_quenmk.Text = "Quên mật khẩu";
			this.lb_quenmk.Click += new System.EventHandler(this.lb_quenmk_Click);
			// 
			// chb_hienmk
			// 
			this.chb_hienmk.AutoSize = true;
			this.chb_hienmk.BackColor = System.Drawing.Color.BlanchedAlmond;
			this.chb_hienmk.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.chb_hienmk.Location = new System.Drawing.Point(998, 461);
			this.chb_hienmk.Name = "chb_hienmk";
			this.chb_hienmk.Size = new System.Drawing.Size(127, 24);
			this.chb_hienmk.TabIndex = 8;
			this.chb_hienmk.Text = "Hiện mật khẩu";
			this.chb_hienmk.UseVisualStyleBackColor = false;
			this.chb_hienmk.CheckedChanged += new System.EventHandler(this.chb_hienmk_CheckedChanged);
			// 
			// fDangnhap
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.BurlyWood;
			this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
			this.ClientSize = new System.Drawing.Size(1382, 703);
			this.Controls.Add(this.chb_hienmk);
			this.Controls.Add(this.lb_quenmk);
			this.Controls.Add(this.btn_exit);
			this.Controls.Add(this.lb_header);
			this.Controls.Add(this.btn_login);
			this.Controls.Add(this.txb_password);
			this.Controls.Add(this.lb_password);
			this.Controls.Add(this.lb_username);
			this.Controls.Add(this.txb_username);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "fDangnhap";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Đăng nhập";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.ColorDialog colorDialog1;
		private System.Windows.Forms.Label lb_password;
		private System.Windows.Forms.TextBox txb_username;
		private System.Windows.Forms.Label lb_username;
		private System.Windows.Forms.Button btn_login;
		private System.Windows.Forms.TextBox txb_password;
		private System.Windows.Forms.Button btn_exit;
		private System.Windows.Forms.Label lb_header;
		private System.Windows.Forms.Label lb_quenmk;
		private System.Windows.Forms.CheckBox chb_hienmk;
	}
}

