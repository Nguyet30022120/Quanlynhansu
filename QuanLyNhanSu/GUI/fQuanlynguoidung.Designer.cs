namespace QuanLyNhanSu
{
	partial class fQuanlynguoidung
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
			this.btn_suanguoidung = new System.Windows.Forms.Button();
			this.btn_xoanguoidung = new System.Windows.Forms.Button();
			this.btn_dongnguoidung = new System.Windows.Forms.Button();
			this.dgv_nguoidung = new System.Windows.Forms.DataGridView();
			this.lb_hoten = new System.Windows.Forms.Label();
			this.lb_chucvu = new System.Windows.Forms.Label();
			this.lb_phongban = new System.Windows.Forms.Label();
			this.txb_hoten = new System.Windows.Forms.TextBox();
			this.txb_chucvu = new System.Windows.Forms.TextBox();
			this.txb_phongban = new System.Windows.Forms.TextBox();
			this.lb_vaitro = new System.Windows.Forms.Label();
			this.la_motaquyenhan = new System.Windows.Forms.Label();
			this.cb_vaitro = new System.Windows.Forms.ComboBox();
			this.txb_motaquyenhan = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.dgv_nguoidung)).BeginInit();
			this.SuspendLayout();
			// 
			// btn_suanguoidung
			// 
			this.btn_suanguoidung.BackColor = System.Drawing.Color.DarkOrange;
			this.btn_suanguoidung.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_suanguoidung.Location = new System.Drawing.Point(827, 20);
			this.btn_suanguoidung.Name = "btn_suanguoidung";
			this.btn_suanguoidung.Size = new System.Drawing.Size(115, 40);
			this.btn_suanguoidung.TabIndex = 1;
			this.btn_suanguoidung.Text = "Sửa";
			this.btn_suanguoidung.UseVisualStyleBackColor = false;
			this.btn_suanguoidung.Click += new System.EventHandler(this.btn_suanguoidung_Click);
			// 
			// btn_xoanguoidung
			// 
			this.btn_xoanguoidung.BackColor = System.Drawing.Color.DarkOrange;
			this.btn_xoanguoidung.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_xoanguoidung.Location = new System.Drawing.Point(827, 63);
			this.btn_xoanguoidung.Name = "btn_xoanguoidung";
			this.btn_xoanguoidung.Size = new System.Drawing.Size(115, 40);
			this.btn_xoanguoidung.TabIndex = 2;
			this.btn_xoanguoidung.Text = "Xóa";
			this.btn_xoanguoidung.UseVisualStyleBackColor = false;
			this.btn_xoanguoidung.Click += new System.EventHandler(this.btn_xoanguoidung_Click);
			// 
			// btn_dongnguoidung
			// 
			this.btn_dongnguoidung.BackColor = System.Drawing.Color.DarkOrange;
			this.btn_dongnguoidung.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_dongnguoidung.Location = new System.Drawing.Point(827, 107);
			this.btn_dongnguoidung.Name = "btn_dongnguoidung";
			this.btn_dongnguoidung.Size = new System.Drawing.Size(115, 40);
			this.btn_dongnguoidung.TabIndex = 3;
			this.btn_dongnguoidung.Text = "Đóng";
			this.btn_dongnguoidung.UseVisualStyleBackColor = false;
			this.btn_dongnguoidung.Click += new System.EventHandler(this.btn_dongnguoidung_Click);
			// 
			// dgv_nguoidung
			// 
			this.dgv_nguoidung.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv_nguoidung.Location = new System.Drawing.Point(4, 176);
			this.dgv_nguoidung.Name = "dgv_nguoidung";
			this.dgv_nguoidung.RowHeadersWidth = 51;
			this.dgv_nguoidung.RowTemplate.Height = 24;
			this.dgv_nguoidung.Size = new System.Drawing.Size(975, 324);
			this.dgv_nguoidung.TabIndex = 4;
			// 
			// lb_hoten
			// 
			this.lb_hoten.AutoSize = true;
			this.lb_hoten.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_hoten.Location = new System.Drawing.Point(30, 20);
			this.lb_hoten.Name = "lb_hoten";
			this.lb_hoten.Size = new System.Drawing.Size(56, 20);
			this.lb_hoten.TabIndex = 5;
			this.lb_hoten.Text = "Họ tên";
			// 
			// lb_chucvu
			// 
			this.lb_chucvu.AutoSize = true;
			this.lb_chucvu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_chucvu.Location = new System.Drawing.Point(30, 70);
			this.lb_chucvu.Name = "lb_chucvu";
			this.lb_chucvu.Size = new System.Drawing.Size(65, 20);
			this.lb_chucvu.TabIndex = 6;
			this.lb_chucvu.Text = "Chức vụ";
			// 
			// lb_phongban
			// 
			this.lb_phongban.AutoSize = true;
			this.lb_phongban.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_phongban.Location = new System.Drawing.Point(30, 120);
			this.lb_phongban.Name = "lb_phongban";
			this.lb_phongban.Size = new System.Drawing.Size(84, 20);
			this.lb_phongban.TabIndex = 7;
			this.lb_phongban.Text = "Phòng ban";
			// 
			// txb_hoten
			// 
			this.txb_hoten.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txb_hoten.Location = new System.Drawing.Point(120, 20);
			this.txb_hoten.Name = "txb_hoten";
			this.txb_hoten.ReadOnly = true;
			this.txb_hoten.Size = new System.Drawing.Size(252, 27);
			this.txb_hoten.TabIndex = 8;
			// 
			// txb_chucvu
			// 
			this.txb_chucvu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txb_chucvu.Location = new System.Drawing.Point(120, 70);
			this.txb_chucvu.Name = "txb_chucvu";
			this.txb_chucvu.ReadOnly = true;
			this.txb_chucvu.Size = new System.Drawing.Size(252, 27);
			this.txb_chucvu.TabIndex = 9;
			// 
			// txb_phongban
			// 
			this.txb_phongban.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txb_phongban.Location = new System.Drawing.Point(120, 120);
			this.txb_phongban.Name = "txb_phongban";
			this.txb_phongban.ReadOnly = true;
			this.txb_phongban.Size = new System.Drawing.Size(252, 27);
			this.txb_phongban.TabIndex = 10;
			// 
			// lb_vaitro
			// 
			this.lb_vaitro.AutoSize = true;
			this.lb_vaitro.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_vaitro.Location = new System.Drawing.Point(415, 20);
			this.lb_vaitro.Name = "lb_vaitro";
			this.lb_vaitro.Size = new System.Drawing.Size(55, 20);
			this.lb_vaitro.TabIndex = 11;
			this.lb_vaitro.Text = "Vai trò";
			// 
			// la_motaquyenhan
			// 
			this.la_motaquyenhan.AutoSize = true;
			this.la_motaquyenhan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.la_motaquyenhan.Location = new System.Drawing.Point(415, 70);
			this.la_motaquyenhan.Name = "la_motaquyenhan";
			this.la_motaquyenhan.Size = new System.Drawing.Size(127, 20);
			this.la_motaquyenhan.TabIndex = 12;
			this.la_motaquyenhan.Text = "Mô tả quyền hạn";
			// 
			// cb_vaitro
			// 
			this.cb_vaitro.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cb_vaitro.FormattingEnabled = true;
			this.cb_vaitro.Items.AddRange(new object[] {
            "admin",
            "user"});
			this.cb_vaitro.Location = new System.Drawing.Point(550, 20);
			this.cb_vaitro.Name = "cb_vaitro";
			this.cb_vaitro.Size = new System.Drawing.Size(252, 28);
			this.cb_vaitro.TabIndex = 13;
			// 
			// txb_motaquyenhan
			// 
			this.txb_motaquyenhan.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txb_motaquyenhan.Location = new System.Drawing.Point(550, 70);
			this.txb_motaquyenhan.Multiline = true;
			this.txb_motaquyenhan.Name = "txb_motaquyenhan";
			this.txb_motaquyenhan.Size = new System.Drawing.Size(252, 77);
			this.txb_motaquyenhan.TabIndex = 14;
			// 
			// fQuanlynguoidung
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.BlanchedAlmond;
			this.ClientSize = new System.Drawing.Size(982, 503);
			this.Controls.Add(this.txb_motaquyenhan);
			this.Controls.Add(this.cb_vaitro);
			this.Controls.Add(this.la_motaquyenhan);
			this.Controls.Add(this.lb_vaitro);
			this.Controls.Add(this.txb_phongban);
			this.Controls.Add(this.txb_chucvu);
			this.Controls.Add(this.txb_hoten);
			this.Controls.Add(this.lb_phongban);
			this.Controls.Add(this.lb_chucvu);
			this.Controls.Add(this.lb_hoten);
			this.Controls.Add(this.dgv_nguoidung);
			this.Controls.Add(this.btn_dongnguoidung);
			this.Controls.Add(this.btn_xoanguoidung);
			this.Controls.Add(this.btn_suanguoidung);
			this.Name = "fQuanlynguoidung";
			this.Text = "Quản lý người dùng";
			((System.ComponentModel.ISupportInitialize)(this.dgv_nguoidung)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Button btn_suanguoidung;
		private System.Windows.Forms.Button btn_xoanguoidung;
		private System.Windows.Forms.Button btn_dongnguoidung;
		private System.Windows.Forms.DataGridView dgv_nguoidung;
		private System.Windows.Forms.Label lb_hoten;
		private System.Windows.Forms.Label lb_chucvu;
		private System.Windows.Forms.Label lb_phongban;
		private System.Windows.Forms.TextBox txb_hoten;
		private System.Windows.Forms.TextBox txb_chucvu;
		private System.Windows.Forms.TextBox txb_phongban;
		private System.Windows.Forms.Label lb_vaitro;
		private System.Windows.Forms.Label la_motaquyenhan;
		private System.Windows.Forms.ComboBox cb_vaitro;
		private System.Windows.Forms.TextBox txb_motaquyenhan;
	}
}