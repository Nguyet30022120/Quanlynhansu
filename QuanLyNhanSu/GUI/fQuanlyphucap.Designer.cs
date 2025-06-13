namespace QuanLyNhanSu.GUI
{
	partial class fQuanlyphucap
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			this.lb_tienphucap = new System.Windows.Forms.Label();
			this.cb_loaiphucap = new System.Windows.Forms.ComboBox();
			this.btn_timmanhanvien = new System.Windows.Forms.Button();
			this.lb_manhanvien = new System.Windows.Forms.Label();
			this.txb_manhanvien = new System.Windows.Forms.TextBox();
			this.lb_loaiphucap = new System.Windows.Forms.Label();
			this.lb_tennhanvien = new System.Windows.Forms.Label();
			this.dgv_phucap = new System.Windows.Forms.DataGridView();
			this.MaPhuCap = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.LoaiPhuCap = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TienPC = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btn_dongphucap = new System.Windows.Forms.Button();
			this.btn_xoaphucap = new System.Windows.Forms.Button();
			this.btn_suaphucap = new System.Windows.Forms.Button();
			this.btn_themphucap = new System.Windows.Forms.Button();
			this.txb_tennhanvien = new System.Windows.Forms.TextBox();
			this.txb_tienphucap = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.dgv_phucap)).BeginInit();
			this.SuspendLayout();
			// 
			// lb_tienphucap
			// 
			this.lb_tienphucap.AutoSize = true;
			this.lb_tienphucap.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_tienphucap.Location = new System.Drawing.Point(734, 84);
			this.lb_tienphucap.Name = "lb_tienphucap";
			this.lb_tienphucap.Size = new System.Drawing.Size(98, 20);
			this.lb_tienphucap.TabIndex = 41;
			this.lb_tienphucap.Text = "Tiền phụ cấp";
			// 
			// cb_loaiphucap
			// 
			this.cb_loaiphucap.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cb_loaiphucap.FormattingEnabled = true;
			this.cb_loaiphucap.Items.AddRange(new object[] {
            "Phụ cấp chức vụ",
            "Phụ cấp ăn trưa",
            "Phụ cấp ăn tối",
            "Phụ cấp xăng xe"});
			this.cb_loaiphucap.Location = new System.Drawing.Point(916, 34);
			this.cb_loaiphucap.Name = "cb_loaiphucap";
			this.cb_loaiphucap.Size = new System.Drawing.Size(252, 28);
			this.cb_loaiphucap.TabIndex = 40;
			// 
			// btn_timmanhanvien
			// 
			this.btn_timmanhanvien.BackColor = System.Drawing.Color.DarkOrange;
			this.btn_timmanhanvien.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_timmanhanvien.Location = new System.Drawing.Point(508, 27);
			this.btn_timmanhanvien.Name = "btn_timmanhanvien";
			this.btn_timmanhanvien.Size = new System.Drawing.Size(115, 40);
			this.btn_timmanhanvien.TabIndex = 39;
			this.btn_timmanhanvien.Text = "Tìm kiếm";
			this.btn_timmanhanvien.UseVisualStyleBackColor = false;
			this.btn_timmanhanvien.Click += new System.EventHandler(this.btn_timmanhanvien_Click);
			this.btn_timmanhanvien.MouseEnter += new System.EventHandler(this.btn_timmanhanvien_MouseEnter);
			this.btn_timmanhanvien.MouseLeave += new System.EventHandler(this.btn_timmanhanvien_MouseLeave);
			// 
			// lb_manhanvien
			// 
			this.lb_manhanvien.AutoSize = true;
			this.lb_manhanvien.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_manhanvien.Location = new System.Drawing.Point(22, 34);
			this.lb_manhanvien.Name = "lb_manhanvien";
			this.lb_manhanvien.Size = new System.Drawing.Size(103, 20);
			this.lb_manhanvien.TabIndex = 38;
			this.lb_manhanvien.Text = "Mã nhân viên";
			// 
			// txb_manhanvien
			// 
			this.txb_manhanvien.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txb_manhanvien.Location = new System.Drawing.Point(201, 34);
			this.txb_manhanvien.Name = "txb_manhanvien";
			this.txb_manhanvien.Size = new System.Drawing.Size(252, 27);
			this.txb_manhanvien.TabIndex = 37;
			// 
			// lb_loaiphucap
			// 
			this.lb_loaiphucap.AutoSize = true;
			this.lb_loaiphucap.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_loaiphucap.Location = new System.Drawing.Point(734, 34);
			this.lb_loaiphucap.Name = "lb_loaiphucap";
			this.lb_loaiphucap.Size = new System.Drawing.Size(97, 20);
			this.lb_loaiphucap.TabIndex = 31;
			this.lb_loaiphucap.Text = "Loại phụ cấp";
			// 
			// lb_tennhanvien
			// 
			this.lb_tennhanvien.AutoSize = true;
			this.lb_tennhanvien.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_tennhanvien.Location = new System.Drawing.Point(22, 84);
			this.lb_tennhanvien.Name = "lb_tennhanvien";
			this.lb_tennhanvien.Size = new System.Drawing.Size(106, 20);
			this.lb_tennhanvien.TabIndex = 30;
			this.lb_tennhanvien.Text = "Tên nhân viên";
			// 
			// dgv_phucap
			// 
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.Tan;
			this.dgv_phucap.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dgv_phucap.BackgroundColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgv_phucap.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dgv_phucap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv_phucap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaPhuCap,
            this.MaNV,
            this.HoTen,
            this.LoaiPhuCap,
            this.TienPC});
			this.dgv_phucap.Location = new System.Drawing.Point(12, 177);
			this.dgv_phucap.Name = "dgv_phucap";
			this.dgv_phucap.RowHeadersWidth = 51;
			this.dgv_phucap.RowTemplate.Height = 24;
			this.dgv_phucap.Size = new System.Drawing.Size(1461, 589);
			this.dgv_phucap.TabIndex = 29;
			// 
			// MaPhuCap
			// 
			this.MaPhuCap.DataPropertyName = "MaPhuCap";
			this.MaPhuCap.HeaderText = "Mã phụ cấp";
			this.MaPhuCap.MinimumWidth = 6;
			this.MaPhuCap.Name = "MaPhuCap";
			this.MaPhuCap.Width = 125;
			// 
			// MaNV
			// 
			this.MaNV.DataPropertyName = "MaNV";
			this.MaNV.HeaderText = "Mã nhân viên";
			this.MaNV.MinimumWidth = 6;
			this.MaNV.Name = "MaNV";
			this.MaNV.Width = 125;
			// 
			// HoTen
			// 
			this.HoTen.DataPropertyName = "TenNV";
			this.HoTen.HeaderText = "Tên nhân viên";
			this.HoTen.MinimumWidth = 6;
			this.HoTen.Name = "HoTen";
			this.HoTen.Width = 125;
			// 
			// LoaiPhuCap
			// 
			this.LoaiPhuCap.DataPropertyName = "LoaiPhuCap";
			this.LoaiPhuCap.HeaderText = "Loại phụ cấp";
			this.LoaiPhuCap.MinimumWidth = 6;
			this.LoaiPhuCap.Name = "LoaiPhuCap";
			this.LoaiPhuCap.Width = 125;
			// 
			// TienPC
			// 
			this.TienPC.DataPropertyName = "SoTienPhuCap";
			this.TienPC.HeaderText = "Tiền phụ cấp";
			this.TienPC.MinimumWidth = 6;
			this.TienPC.Name = "TienPC";
			this.TienPC.Width = 125;
			// 
			// btn_dongphucap
			// 
			this.btn_dongphucap.BackColor = System.Drawing.Color.DarkOrange;
			this.btn_dongphucap.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_dongphucap.Location = new System.Drawing.Point(1355, 129);
			this.btn_dongphucap.Name = "btn_dongphucap";
			this.btn_dongphucap.Size = new System.Drawing.Size(115, 40);
			this.btn_dongphucap.TabIndex = 28;
			this.btn_dongphucap.Text = "Đóng";
			this.btn_dongphucap.UseVisualStyleBackColor = false;
			this.btn_dongphucap.Click += new System.EventHandler(this.btn_dongphucap_Click);
			this.btn_dongphucap.MouseEnter += new System.EventHandler(this.btn_dongphucap_MouseEnter);
			this.btn_dongphucap.MouseLeave += new System.EventHandler(this.btn_dongphucap_MouseLeave);
			// 
			// btn_xoaphucap
			// 
			this.btn_xoaphucap.BackColor = System.Drawing.Color.DarkOrange;
			this.btn_xoaphucap.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_xoaphucap.Location = new System.Drawing.Point(1355, 89);
			this.btn_xoaphucap.Name = "btn_xoaphucap";
			this.btn_xoaphucap.Size = new System.Drawing.Size(115, 40);
			this.btn_xoaphucap.TabIndex = 27;
			this.btn_xoaphucap.Text = "Xóa";
			this.btn_xoaphucap.UseVisualStyleBackColor = false;
			this.btn_xoaphucap.Click += new System.EventHandler(this.btn_xoaphucap_Click);
			this.btn_xoaphucap.MouseEnter += new System.EventHandler(this.btn_xoaphucap_MouseEnter);
			this.btn_xoaphucap.MouseLeave += new System.EventHandler(this.btn_xoaphucap_MouseLeave);
			// 
			// btn_suaphucap
			// 
			this.btn_suaphucap.BackColor = System.Drawing.Color.DarkOrange;
			this.btn_suaphucap.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_suaphucap.Location = new System.Drawing.Point(1355, 49);
			this.btn_suaphucap.Name = "btn_suaphucap";
			this.btn_suaphucap.Size = new System.Drawing.Size(115, 40);
			this.btn_suaphucap.TabIndex = 26;
			this.btn_suaphucap.Text = "Sửa ";
			this.btn_suaphucap.UseVisualStyleBackColor = false;
			this.btn_suaphucap.Click += new System.EventHandler(this.btn_suaphucap_Click);
			this.btn_suaphucap.MouseEnter += new System.EventHandler(this.btn_suaphucap_MouseEnter);
			this.btn_suaphucap.MouseLeave += new System.EventHandler(this.btn_suaphucap_MouseLeave);
			// 
			// btn_themphucap
			// 
			this.btn_themphucap.BackColor = System.Drawing.Color.DarkOrange;
			this.btn_themphucap.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_themphucap.Location = new System.Drawing.Point(1355, 9);
			this.btn_themphucap.Name = "btn_themphucap";
			this.btn_themphucap.Size = new System.Drawing.Size(115, 40);
			this.btn_themphucap.TabIndex = 25;
			this.btn_themphucap.Text = "Thêm";
			this.btn_themphucap.UseVisualStyleBackColor = false;
			this.btn_themphucap.Click += new System.EventHandler(this.btn_themphucap_Click);
			this.btn_themphucap.MouseEnter += new System.EventHandler(this.btn_themphucap_MouseEnter);
			this.btn_themphucap.MouseLeave += new System.EventHandler(this.btn_themphucap_MouseLeave);
			// 
			// txb_tennhanvien
			// 
			this.txb_tennhanvien.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txb_tennhanvien.Location = new System.Drawing.Point(201, 84);
			this.txb_tennhanvien.Name = "txb_tennhanvien";
			this.txb_tennhanvien.ReadOnly = true;
			this.txb_tennhanvien.Size = new System.Drawing.Size(252, 27);
			this.txb_tennhanvien.TabIndex = 23;
			// 
			// txb_tienphucap
			// 
			this.txb_tienphucap.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txb_tienphucap.Location = new System.Drawing.Point(916, 84);
			this.txb_tienphucap.Name = "txb_tienphucap";
			this.txb_tienphucap.Size = new System.Drawing.Size(252, 27);
			this.txb_tienphucap.TabIndex = 42;
			// 
			// fQuanlyphucap
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.BlanchedAlmond;
			this.ClientSize = new System.Drawing.Size(1482, 778);
			this.Controls.Add(this.txb_tienphucap);
			this.Controls.Add(this.lb_tienphucap);
			this.Controls.Add(this.cb_loaiphucap);
			this.Controls.Add(this.btn_timmanhanvien);
			this.Controls.Add(this.lb_manhanvien);
			this.Controls.Add(this.txb_manhanvien);
			this.Controls.Add(this.lb_loaiphucap);
			this.Controls.Add(this.lb_tennhanvien);
			this.Controls.Add(this.dgv_phucap);
			this.Controls.Add(this.btn_dongphucap);
			this.Controls.Add(this.btn_xoaphucap);
			this.Controls.Add(this.btn_suaphucap);
			this.Controls.Add(this.btn_themphucap);
			this.Controls.Add(this.txb_tennhanvien);
			this.Name = "fQuanlyphucap";
			this.Text = "Phụ cấp";
			((System.ComponentModel.ISupportInitialize)(this.dgv_phucap)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lb_tienphucap;
		private System.Windows.Forms.ComboBox cb_loaiphucap;
		private System.Windows.Forms.Button btn_timmanhanvien;
		private System.Windows.Forms.Label lb_manhanvien;
		private System.Windows.Forms.TextBox txb_manhanvien;
		private System.Windows.Forms.Label lb_loaiphucap;
		private System.Windows.Forms.Label lb_tennhanvien;
		private System.Windows.Forms.DataGridView dgv_phucap;
		private System.Windows.Forms.Button btn_dongphucap;
		private System.Windows.Forms.Button btn_xoaphucap;
		private System.Windows.Forms.Button btn_suaphucap;
		private System.Windows.Forms.Button btn_themphucap;
		private System.Windows.Forms.TextBox txb_tennhanvien;
		private System.Windows.Forms.TextBox txb_tienphucap;
		private System.Windows.Forms.DataGridViewTextBoxColumn MaPhuCap;
		private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
		private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
		private System.Windows.Forms.DataGridViewTextBoxColumn LoaiPhuCap;
		private System.Windows.Forms.DataGridViewTextBoxColumn TienPC;
	}
}