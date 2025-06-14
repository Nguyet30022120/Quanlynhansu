namespace QuanLyNhanSu.GUI
{
	partial class fQuanlykhenthuongkyluatUser
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			this.btn_dongkhenthuongkyluat = new System.Windows.Forms.Button();
			this.ThoiGian = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.HinhThuc = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NoiDung = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MaKTKL = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.dgv_khenthuongkyluat = new System.Windows.Forms.DataGridView();
			this.txb_noidung = new System.Windows.Forms.TextBox();
			this.txb_tennhanvien = new System.Windows.Forms.TextBox();
			this.txb_manhanvien = new System.Windows.Forms.TextBox();
			this.lb_tennhanvien = new System.Windows.Forms.Label();
			this.lb_noidung = new System.Windows.Forms.Label();
			this.lb_khenthuongkyluat = new System.Windows.Forms.Label();
			this.lb_thoigian = new System.Windows.Forms.Label();
			this.lb_manhanvien = new System.Windows.Forms.Label();
			this.txb_thoigian = new System.Windows.Forms.TextBox();
			this.txb_hinhthuc = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.dgv_khenthuongkyluat)).BeginInit();
			this.SuspendLayout();
			// 
			// btn_dongkhenthuongkyluat
			// 
			this.btn_dongkhenthuongkyluat.BackColor = System.Drawing.Color.DarkOrange;
			this.btn_dongkhenthuongkyluat.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_dongkhenthuongkyluat.Location = new System.Drawing.Point(1341, 56);
			this.btn_dongkhenthuongkyluat.Name = "btn_dongkhenthuongkyluat";
			this.btn_dongkhenthuongkyluat.Size = new System.Drawing.Size(115, 40);
			this.btn_dongkhenthuongkyluat.TabIndex = 31;
			this.btn_dongkhenthuongkyluat.Text = "Đóng";
			this.btn_dongkhenthuongkyluat.UseVisualStyleBackColor = false;
			this.btn_dongkhenthuongkyluat.Click += new System.EventHandler(this.btn_dongkhenthuongkyluat_Click);
			this.btn_dongkhenthuongkyluat.MouseEnter += new System.EventHandler(this.btn_dongkhenthuongkyluat_MouseEnter);
			this.btn_dongkhenthuongkyluat.MouseLeave += new System.EventHandler(this.btn_dongkhenthuongkyluat_MouseLeave);
			// 
			// ThoiGian
			// 
			this.ThoiGian.DataPropertyName = "ThoiGian";
			this.ThoiGian.HeaderText = "Thời gian";
			this.ThoiGian.MinimumWidth = 6;
			this.ThoiGian.Name = "ThoiGian";
			this.ThoiGian.Width = 125;
			// 
			// HinhThuc
			// 
			this.HinhThuc.DataPropertyName = "HinhThuc";
			this.HinhThuc.HeaderText = "Hình thức";
			this.HinhThuc.MinimumWidth = 6;
			this.HinhThuc.Name = "HinhThuc";
			this.HinhThuc.Width = 125;
			// 
			// NoiDung
			// 
			this.NoiDung.DataPropertyName = "NoiDung";
			this.NoiDung.HeaderText = "Nội dung";
			this.NoiDung.MinimumWidth = 6;
			this.NoiDung.Name = "NoiDung";
			this.NoiDung.Width = 250;
			// 
			// TenNV
			// 
			this.TenNV.DataPropertyName = "TenNV";
			this.TenNV.HeaderText = "Tên nhân viên";
			this.TenNV.MinimumWidth = 6;
			this.TenNV.Name = "TenNV";
			this.TenNV.Width = 125;
			// 
			// MaNV
			// 
			this.MaNV.DataPropertyName = "MaNV";
			this.MaNV.HeaderText = "Mã nhân viên";
			this.MaNV.MinimumWidth = 6;
			this.MaNV.Name = "MaNV";
			this.MaNV.Width = 125;
			// 
			// MaKTKL
			// 
			this.MaKTKL.DataPropertyName = "MaKTKL";
			this.MaKTKL.HeaderText = "Mã khen thưởng kỷ luật";
			this.MaKTKL.MinimumWidth = 6;
			this.MaKTKL.Name = "MaKTKL";
			this.MaKTKL.Width = 125;
			// 
			// dgv_khenthuongkyluat
			// 
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.Tan;
			this.dgv_khenthuongkyluat.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
			this.dgv_khenthuongkyluat.BackgroundColor = System.Drawing.Color.White;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgv_khenthuongkyluat.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
			this.dgv_khenthuongkyluat.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv_khenthuongkyluat.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaKTKL,
            this.MaNV,
            this.TenNV,
            this.NoiDung,
            this.HinhThuc,
            this.ThoiGian});
			this.dgv_khenthuongkyluat.Location = new System.Drawing.Point(4, 174);
			this.dgv_khenthuongkyluat.Name = "dgv_khenthuongkyluat";
			this.dgv_khenthuongkyluat.RowHeadersWidth = 51;
			this.dgv_khenthuongkyluat.RowTemplate.Height = 24;
			this.dgv_khenthuongkyluat.Size = new System.Drawing.Size(1474, 598);
			this.dgv_khenthuongkyluat.TabIndex = 26;
			// 
			// txb_noidung
			// 
			this.txb_noidung.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txb_noidung.Location = new System.Drawing.Point(141, 98);
			this.txb_noidung.Multiline = true;
			this.txb_noidung.Name = "txb_noidung";
			this.txb_noidung.ReadOnly = true;
			this.txb_noidung.Size = new System.Drawing.Size(252, 67);
			this.txb_noidung.TabIndex = 23;
			// 
			// txb_tennhanvien
			// 
			this.txb_tennhanvien.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txb_tennhanvien.Location = new System.Drawing.Point(141, 58);
			this.txb_tennhanvien.Name = "txb_tennhanvien";
			this.txb_tennhanvien.ReadOnly = true;
			this.txb_tennhanvien.Size = new System.Drawing.Size(252, 27);
			this.txb_tennhanvien.TabIndex = 22;
			// 
			// txb_manhanvien
			// 
			this.txb_manhanvien.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txb_manhanvien.Location = new System.Drawing.Point(141, 13);
			this.txb_manhanvien.Name = "txb_manhanvien";
			this.txb_manhanvien.ReadOnly = true;
			this.txb_manhanvien.Size = new System.Drawing.Size(252, 27);
			this.txb_manhanvien.TabIndex = 21;
			// 
			// lb_tennhanvien
			// 
			this.lb_tennhanvien.AutoSize = true;
			this.lb_tennhanvien.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_tennhanvien.Location = new System.Drawing.Point(21, 58);
			this.lb_tennhanvien.Name = "lb_tennhanvien";
			this.lb_tennhanvien.Size = new System.Drawing.Size(106, 20);
			this.lb_tennhanvien.TabIndex = 20;
			this.lb_tennhanvien.Text = "Tên nhân viên";
			// 
			// lb_noidung
			// 
			this.lb_noidung.AutoSize = true;
			this.lb_noidung.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_noidung.Location = new System.Drawing.Point(21, 98);
			this.lb_noidung.Name = "lb_noidung";
			this.lb_noidung.Size = new System.Drawing.Size(74, 20);
			this.lb_noidung.TabIndex = 19;
			this.lb_noidung.Text = "Nội dung";
			// 
			// lb_khenthuongkyluat
			// 
			this.lb_khenthuongkyluat.AutoSize = true;
			this.lb_khenthuongkyluat.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_khenthuongkyluat.Location = new System.Drawing.Point(644, 98);
			this.lb_khenthuongkyluat.Name = "lb_khenthuongkyluat";
			this.lb_khenthuongkyluat.Size = new System.Drawing.Size(157, 20);
			this.lb_khenthuongkyluat.TabIndex = 18;
			this.lb_khenthuongkyluat.Text = "Khen thưởng/Kỷ luật";
			// 
			// lb_thoigian
			// 
			this.lb_thoigian.AutoSize = true;
			this.lb_thoigian.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_thoigian.Location = new System.Drawing.Point(644, 56);
			this.lb_thoigian.Name = "lb_thoigian";
			this.lb_thoigian.Size = new System.Drawing.Size(74, 20);
			this.lb_thoigian.TabIndex = 17;
			this.lb_thoigian.Text = "Thời gian";
			// 
			// lb_manhanvien
			// 
			this.lb_manhanvien.AutoSize = true;
			this.lb_manhanvien.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_manhanvien.Location = new System.Drawing.Point(21, 18);
			this.lb_manhanvien.Name = "lb_manhanvien";
			this.lb_manhanvien.Size = new System.Drawing.Size(103, 20);
			this.lb_manhanvien.TabIndex = 16;
			this.lb_manhanvien.Text = "Mã nhân viên";
			// 
			// txb_thoigian
			// 
			this.txb_thoigian.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txb_thoigian.Location = new System.Drawing.Point(822, 49);
			this.txb_thoigian.Name = "txb_thoigian";
			this.txb_thoigian.ReadOnly = true;
			this.txb_thoigian.Size = new System.Drawing.Size(252, 27);
			this.txb_thoigian.TabIndex = 32;
			// 
			// txb_hinhthuc
			// 
			this.txb_hinhthuc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txb_hinhthuc.Location = new System.Drawing.Point(822, 91);
			this.txb_hinhthuc.Name = "txb_hinhthuc";
			this.txb_hinhthuc.ReadOnly = true;
			this.txb_hinhthuc.Size = new System.Drawing.Size(252, 27);
			this.txb_hinhthuc.TabIndex = 33;
			// 
			// fQuanlykhenthuongkyluatUser
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.BlanchedAlmond;
			this.ClientSize = new System.Drawing.Size(1482, 778);
			this.Controls.Add(this.txb_hinhthuc);
			this.Controls.Add(this.txb_thoigian);
			this.Controls.Add(this.btn_dongkhenthuongkyluat);
			this.Controls.Add(this.dgv_khenthuongkyluat);
			this.Controls.Add(this.txb_noidung);
			this.Controls.Add(this.txb_tennhanvien);
			this.Controls.Add(this.txb_manhanvien);
			this.Controls.Add(this.lb_tennhanvien);
			this.Controls.Add(this.lb_noidung);
			this.Controls.Add(this.lb_khenthuongkyluat);
			this.Controls.Add(this.lb_thoigian);
			this.Controls.Add(this.lb_manhanvien);
			this.Name = "fQuanlykhenthuongkyluatUser";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Khen thưởng kỷ luật";
			((System.ComponentModel.ISupportInitialize)(this.dgv_khenthuongkyluat)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btn_dongkhenthuongkyluat;
		private System.Windows.Forms.DataGridViewTextBoxColumn ThoiGian;
		private System.Windows.Forms.DataGridViewTextBoxColumn HinhThuc;
		private System.Windows.Forms.DataGridViewTextBoxColumn NoiDung;
		private System.Windows.Forms.DataGridViewTextBoxColumn TenNV;
		private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
		private System.Windows.Forms.DataGridViewTextBoxColumn MaKTKL;
		private System.Windows.Forms.DataGridView dgv_khenthuongkyluat;
		private System.Windows.Forms.TextBox txb_noidung;
		private System.Windows.Forms.TextBox txb_tennhanvien;
		private System.Windows.Forms.TextBox txb_manhanvien;
		private System.Windows.Forms.Label lb_tennhanvien;
		private System.Windows.Forms.Label lb_noidung;
		private System.Windows.Forms.Label lb_khenthuongkyluat;
		private System.Windows.Forms.Label lb_thoigian;
		private System.Windows.Forms.Label lb_manhanvien;
		private System.Windows.Forms.TextBox txb_thoigian;
		private System.Windows.Forms.TextBox txb_hinhthuc;
	}
}