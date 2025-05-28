namespace QuanLyNhanSu
{
	partial class fQuanlytrinhdochuyenmon
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
			this.pn_trinhdo = new System.Windows.Forms.Panel();
			this.lb_tennhanvien = new System.Windows.Forms.Label();
			this.txb_tennhanvien = new System.Windows.Forms.TextBox();
			this.btn_timnhanvien = new System.Windows.Forms.Button();
			this.txb_truonghoc = new System.Windows.Forms.TextBox();
			this.lb_truonghoc = new System.Windows.Forms.Label();
			this.cb_loaibangcap = new System.Windows.Forms.ComboBox();
			this.btn_dongtrinhdo = new System.Windows.Forms.Button();
			this.btn_xoatrinhdo = new System.Windows.Forms.Button();
			this.btn_suatrinhdo = new System.Windows.Forms.Button();
			this.lb_chuyennganh = new System.Windows.Forms.Label();
			this.lb_loaibangcap = new System.Windows.Forms.Label();
			this.lb_manhanvien = new System.Windows.Forms.Label();
			this.txb_chuyennganh = new System.Windows.Forms.TextBox();
			this.txb_manv = new System.Windows.Forms.TextBox();
			this.dgv_trinhdo = new System.Windows.Forms.DataGridView();
			this.MaTD = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.LoaiBC = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ChuyenNganh = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TruongHoc = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btn_themtrinhdo = new System.Windows.Forms.Button();
			this.pn_trinhdo.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgv_trinhdo)).BeginInit();
			this.SuspendLayout();
			// 
			// pn_trinhdo
			// 
			this.pn_trinhdo.Controls.Add(this.btn_timnhanvien);
			this.pn_trinhdo.Controls.Add(this.lb_manhanvien);
			this.pn_trinhdo.Controls.Add(this.lb_tennhanvien);
			this.pn_trinhdo.Controls.Add(this.txb_manv);
			this.pn_trinhdo.Controls.Add(this.txb_tennhanvien);
			this.pn_trinhdo.Controls.Add(this.txb_truonghoc);
			this.pn_trinhdo.Controls.Add(this.lb_truonghoc);
			this.pn_trinhdo.Controls.Add(this.cb_loaibangcap);
			this.pn_trinhdo.Controls.Add(this.btn_dongtrinhdo);
			this.pn_trinhdo.Controls.Add(this.btn_xoatrinhdo);
			this.pn_trinhdo.Controls.Add(this.btn_suatrinhdo);
			this.pn_trinhdo.Controls.Add(this.btn_themtrinhdo);
			this.pn_trinhdo.Controls.Add(this.lb_chuyennganh);
			this.pn_trinhdo.Controls.Add(this.lb_loaibangcap);
			this.pn_trinhdo.Controls.Add(this.txb_chuyennganh);
			this.pn_trinhdo.Location = new System.Drawing.Point(11, 1);
			this.pn_trinhdo.Name = "pn_trinhdo";
			this.pn_trinhdo.Size = new System.Drawing.Size(962, 177);
			this.pn_trinhdo.TabIndex = 0;
			// 
			// lb_tennhanvien
			// 
			this.lb_tennhanvien.AutoSize = true;
			this.lb_tennhanvien.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_tennhanvien.Location = new System.Drawing.Point(8, 60);
			this.lb_tennhanvien.Name = "lb_tennhanvien";
			this.lb_tennhanvien.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lb_tennhanvien.Size = new System.Drawing.Size(112, 21);
			this.lb_tennhanvien.TabIndex = 14;
			this.lb_tennhanvien.Text = "Tên nhân viên ";
			// 
			// txb_tennhanvien
			// 
			this.txb_tennhanvien.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txb_tennhanvien.Location = new System.Drawing.Point(135, 54);
			this.txb_tennhanvien.Name = "txb_tennhanvien";
			this.txb_tennhanvien.Size = new System.Drawing.Size(252, 27);
			this.txb_tennhanvien.TabIndex = 13;
			// 
			// btn_timnhanvien
			// 
			this.btn_timnhanvien.BackColor = System.Drawing.Color.DarkOrange;
			this.btn_timnhanvien.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_timnhanvien.Location = new System.Drawing.Point(443, 7);
			this.btn_timnhanvien.Name = "btn_timnhanvien";
			this.btn_timnhanvien.Size = new System.Drawing.Size(115, 40);
			this.btn_timnhanvien.TabIndex = 2;
			this.btn_timnhanvien.Text = "Tìm kiếm";
			this.btn_timnhanvien.UseVisualStyleBackColor = false;
			this.btn_timnhanvien.Click += new System.EventHandler(this.btn_findtd_Click);
			// 
			// txb_truonghoc
			// 
			this.txb_truonghoc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txb_truonghoc.Location = new System.Drawing.Point(569, 54);
			this.txb_truonghoc.Name = "txb_truonghoc";
			this.txb_truonghoc.Size = new System.Drawing.Size(252, 27);
			this.txb_truonghoc.TabIndex = 12;
			// 
			// lb_truonghoc
			// 
			this.lb_truonghoc.AutoSize = true;
			this.lb_truonghoc.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_truonghoc.Location = new System.Drawing.Point(439, 57);
			this.lb_truonghoc.Name = "lb_truonghoc";
			this.lb_truonghoc.Size = new System.Drawing.Size(91, 21);
			this.lb_truonghoc.TabIndex = 11;
			this.lb_truonghoc.Text = "Trường học";
			// 
			// cb_loaibangcap
			// 
			this.cb_loaibangcap.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cb_loaibangcap.FormattingEnabled = true;
			this.cb_loaibangcap.Location = new System.Drawing.Point(135, 97);
			this.cb_loaibangcap.Name = "cb_loaibangcap";
			this.cb_loaibangcap.Size = new System.Drawing.Size(252, 28);
			this.cb_loaibangcap.TabIndex = 10;
			// 
			// btn_dongtrinhdo
			// 
			this.btn_dongtrinhdo.BackColor = System.Drawing.Color.DarkOrange;
			this.btn_dongtrinhdo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_dongtrinhdo.Location = new System.Drawing.Point(827, 130);
			this.btn_dongtrinhdo.Name = "btn_dongtrinhdo";
			this.btn_dongtrinhdo.Size = new System.Drawing.Size(115, 40);
			this.btn_dongtrinhdo.TabIndex = 9;
			this.btn_dongtrinhdo.Text = "Đóng";
			this.btn_dongtrinhdo.UseVisualStyleBackColor = false;
			this.btn_dongtrinhdo.Click += new System.EventHandler(this.btn_closetd_Click);
			// 
			// btn_xoatrinhdo
			// 
			this.btn_xoatrinhdo.BackColor = System.Drawing.Color.DarkOrange;
			this.btn_xoatrinhdo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_xoatrinhdo.Location = new System.Drawing.Point(827, 90);
			this.btn_xoatrinhdo.Name = "btn_xoatrinhdo";
			this.btn_xoatrinhdo.Size = new System.Drawing.Size(115, 40);
			this.btn_xoatrinhdo.TabIndex = 8;
			this.btn_xoatrinhdo.Text = "Xóa";
			this.btn_xoatrinhdo.UseVisualStyleBackColor = false;
			this.btn_xoatrinhdo.Click += new System.EventHandler(this.btn_deletetd_Click);
			// 
			// btn_suatrinhdo
			// 
			this.btn_suatrinhdo.BackColor = System.Drawing.Color.DarkOrange;
			this.btn_suatrinhdo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_suatrinhdo.Location = new System.Drawing.Point(827, 50);
			this.btn_suatrinhdo.Name = "btn_suatrinhdo";
			this.btn_suatrinhdo.Size = new System.Drawing.Size(115, 40);
			this.btn_suatrinhdo.TabIndex = 7;
			this.btn_suatrinhdo.Text = "Sửa";
			this.btn_suatrinhdo.UseVisualStyleBackColor = false;
			this.btn_suatrinhdo.Click += new System.EventHandler(this.btn_edittd_Click);
			// 
			// lb_chuyennganh
			// 
			this.lb_chuyennganh.AutoSize = true;
			this.lb_chuyennganh.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_chuyennganh.Location = new System.Drawing.Point(439, 100);
			this.lb_chuyennganh.Name = "lb_chuyennganh";
			this.lb_chuyennganh.Size = new System.Drawing.Size(110, 21);
			this.lb_chuyennganh.TabIndex = 5;
			this.lb_chuyennganh.Text = "Chuyên ngành";
			// 
			// lb_loaibangcap
			// 
			this.lb_loaibangcap.AutoSize = true;
			this.lb_loaibangcap.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_loaibangcap.Location = new System.Drawing.Point(8, 100);
			this.lb_loaibangcap.Name = "lb_loaibangcap";
			this.lb_loaibangcap.Size = new System.Drawing.Size(104, 21);
			this.lb_loaibangcap.TabIndex = 4;
			this.lb_loaibangcap.Text = "Loại bằng cấp";
			// 
			// lb_manhanvien
			// 
			this.lb_manhanvien.AutoSize = true;
			this.lb_manhanvien.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_manhanvien.Location = new System.Drawing.Point(8, 20);
			this.lb_manhanvien.Name = "lb_manhanvien";
			this.lb_manhanvien.RightToLeft = System.Windows.Forms.RightToLeft.No;
			this.lb_manhanvien.Size = new System.Drawing.Size(106, 21);
			this.lb_manhanvien.TabIndex = 3;
			this.lb_manhanvien.Text = "Mã nhân viên";
			// 
			// txb_chuyennganh
			// 
			this.txb_chuyennganh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txb_chuyennganh.Location = new System.Drawing.Point(569, 97);
			this.txb_chuyennganh.Name = "txb_chuyennganh";
			this.txb_chuyennganh.Size = new System.Drawing.Size(252, 27);
			this.txb_chuyennganh.TabIndex = 2;
			// 
			// txb_manv
			// 
			this.txb_manv.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txb_manv.Location = new System.Drawing.Point(135, 14);
			this.txb_manv.Name = "txb_manv";
			this.txb_manv.Size = new System.Drawing.Size(252, 27);
			this.txb_manv.TabIndex = 0;
			// 
			// dgv_trinhdo
			// 
			this.dgv_trinhdo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv_trinhdo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaTD,
            this.TenNV,
            this.LoaiBC,
            this.ChuyenNganh,
            this.TruongHoc});
			this.dgv_trinhdo.Location = new System.Drawing.Point(11, 177);
			this.dgv_trinhdo.Name = "dgv_trinhdo";
			this.dgv_trinhdo.RowHeadersWidth = 51;
			this.dgv_trinhdo.RowTemplate.Height = 24;
			this.dgv_trinhdo.Size = new System.Drawing.Size(962, 564);
			this.dgv_trinhdo.TabIndex = 1;
			// 
			// MaTD
			// 
			this.MaTD.DataPropertyName = "MaTD";
			this.MaTD.HeaderText = "Mã trình độ";
			this.MaTD.MinimumWidth = 6;
			this.MaTD.Name = "MaTD";
			this.MaTD.Width = 125;
			// 
			// TenNV
			// 
			this.TenNV.DataPropertyName = "TenNV";
			this.TenNV.HeaderText = "Tên nhân viên";
			this.TenNV.MinimumWidth = 6;
			this.TenNV.Name = "TenNV";
			this.TenNV.Width = 125;
			// 
			// LoaiBC
			// 
			this.LoaiBC.DataPropertyName = "LoaiBC";
			this.LoaiBC.HeaderText = "Loại bằng cấp";
			this.LoaiBC.MinimumWidth = 6;
			this.LoaiBC.Name = "LoaiBC";
			this.LoaiBC.Width = 125;
			// 
			// ChuyenNganh
			// 
			this.ChuyenNganh.DataPropertyName = "ChuyenNganh";
			this.ChuyenNganh.HeaderText = "Chuyên ngành";
			this.ChuyenNganh.MinimumWidth = 6;
			this.ChuyenNganh.Name = "ChuyenNganh";
			this.ChuyenNganh.Width = 125;
			// 
			// TruongHoc
			// 
			this.TruongHoc.DataPropertyName = "TruongHoc";
			this.TruongHoc.HeaderText = "Trường học";
			this.TruongHoc.MinimumWidth = 6;
			this.TruongHoc.Name = "TruongHoc";
			this.TruongHoc.Width = 125;
			// 
			// btn_themtrinhdo
			// 
			this.btn_themtrinhdo.BackColor = System.Drawing.Color.DarkOrange;
			this.btn_themtrinhdo.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_themtrinhdo.Image = global::QuanLyNhanSu.Properties.Resources.add2;
			this.btn_themtrinhdo.Location = new System.Drawing.Point(827, 10);
			this.btn_themtrinhdo.Name = "btn_themtrinhdo";
			this.btn_themtrinhdo.Size = new System.Drawing.Size(115, 40);
			this.btn_themtrinhdo.TabIndex = 6;
			this.btn_themtrinhdo.Text = "Thêm";
			this.btn_themtrinhdo.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
			this.btn_themtrinhdo.UseVisualStyleBackColor = false;
			this.btn_themtrinhdo.Click += new System.EventHandler(this.btn_addtd_Click);
			// 
			// fQuanlytrinhdochuyenmon
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.BlanchedAlmond;
			this.ClientSize = new System.Drawing.Size(982, 753);
			this.Controls.Add(this.dgv_trinhdo);
			this.Controls.Add(this.pn_trinhdo);
			this.Name = "fQuanlytrinhdochuyenmon";
			this.Text = "Quản lý trình độ ";
			this.pn_trinhdo.ResumeLayout(false);
			this.pn_trinhdo.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgv_trinhdo)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel pn_trinhdo;
		private System.Windows.Forms.DataGridView dgv_trinhdo;
		private System.Windows.Forms.Button btn_dongtrinhdo;
		private System.Windows.Forms.Button btn_xoatrinhdo;
		private System.Windows.Forms.Button btn_suatrinhdo;
		private System.Windows.Forms.Button btn_themtrinhdo;
		private System.Windows.Forms.Label lb_chuyennganh;
		private System.Windows.Forms.Label lb_loaibangcap;
		private System.Windows.Forms.Label lb_manhanvien;
		private System.Windows.Forms.TextBox txb_chuyennganh;
		private System.Windows.Forms.TextBox txb_manv;
		private System.Windows.Forms.Button btn_timnhanvien;
		private System.Windows.Forms.TextBox txb_truonghoc;
		private System.Windows.Forms.Label lb_truonghoc;
		private System.Windows.Forms.ComboBox cb_loaibangcap;
		private System.Windows.Forms.Label lb_tennhanvien;
		private System.Windows.Forms.TextBox txb_tennhanvien;
		private System.Windows.Forms.DataGridViewTextBoxColumn MaTD;
		private System.Windows.Forms.DataGridViewTextBoxColumn TenNV;
		private System.Windows.Forms.DataGridViewTextBoxColumn LoaiBC;
		private System.Windows.Forms.DataGridViewTextBoxColumn ChuyenNganh;
		private System.Windows.Forms.DataGridViewTextBoxColumn TruongHoc;
	}
}