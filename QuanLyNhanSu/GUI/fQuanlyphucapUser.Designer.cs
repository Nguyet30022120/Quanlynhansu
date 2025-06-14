namespace QuanLyNhanSu.GUI
{
	partial class fQuanlyphucapUser
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fQuanlyphucapUser));
			this.txb_tienphucap = new System.Windows.Forms.TextBox();
			this.btn_dongphucap = new System.Windows.Forms.Button();
			this.TienPC = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.LoaiPhuCap = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.HoTen = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.txb_tennhanvien = new System.Windows.Forms.TextBox();
			this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.lb_manhanvien = new System.Windows.Forms.Label();
			this.txb_manhanvien = new System.Windows.Forms.TextBox();
			this.lb_loaiphucap = new System.Windows.Forms.Label();
			this.lb_tennhanvien = new System.Windows.Forms.Label();
			this.dgv_phucap = new System.Windows.Forms.DataGridView();
			this.MaPhuCap = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.lb_tienphucap = new System.Windows.Forms.Label();
			this.txb_loaiphucap = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.dgv_phucap)).BeginInit();
			this.SuspendLayout();
			// 
			// txb_tienphucap
			// 
			this.txb_tienphucap.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txb_tienphucap.Location = new System.Drawing.Point(915, 86);
			this.txb_tienphucap.Name = "txb_tienphucap";
			this.txb_tienphucap.ReadOnly = true;
			this.txb_tienphucap.Size = new System.Drawing.Size(252, 27);
			this.txb_tienphucap.TabIndex = 56;
			// 
			// btn_dongphucap
			// 
			this.btn_dongphucap.BackColor = System.Drawing.Color.DarkOrange;
			this.btn_dongphucap.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_dongphucap.Location = new System.Drawing.Point(1357, 66);
			this.btn_dongphucap.Name = "btn_dongphucap";
			this.btn_dongphucap.Size = new System.Drawing.Size(115, 40);
			this.btn_dongphucap.TabIndex = 47;
			this.btn_dongphucap.Text = "Đóng";
			this.btn_dongphucap.UseVisualStyleBackColor = false;
			this.btn_dongphucap.Click += new System.EventHandler(this.btn_dongphucap_Click);
			this.btn_dongphucap.MouseEnter += new System.EventHandler(this.btn_dongphucap_MouseEnter);
			this.btn_dongphucap.MouseLeave += new System.EventHandler(this.btn_dongphucap_MouseLeave);
			// 
			// TienPC
			// 
			this.TienPC.DataPropertyName = "SoTienPhuCap";
			this.TienPC.HeaderText = "Tiền phụ cấp";
			this.TienPC.MinimumWidth = 6;
			this.TienPC.Name = "TienPC";
			this.TienPC.Width = 125;
			// 
			// LoaiPhuCap
			// 
			this.LoaiPhuCap.DataPropertyName = "LoaiPhuCap";
			this.LoaiPhuCap.HeaderText = "Loại phụ cấp";
			this.LoaiPhuCap.MinimumWidth = 6;
			this.LoaiPhuCap.Name = "LoaiPhuCap";
			this.LoaiPhuCap.Width = 125;
			// 
			// HoTen
			// 
			this.HoTen.DataPropertyName = "TenNV";
			this.HoTen.HeaderText = "Tên nhân viên";
			this.HoTen.MinimumWidth = 6;
			this.HoTen.Name = "HoTen";
			this.HoTen.Width = 125;
			// 
			// txb_tennhanvien
			// 
			this.txb_tennhanvien.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txb_tennhanvien.Location = new System.Drawing.Point(200, 86);
			this.txb_tennhanvien.Name = "txb_tennhanvien";
			this.txb_tennhanvien.ReadOnly = true;
			this.txb_tennhanvien.Size = new System.Drawing.Size(252, 27);
			this.txb_tennhanvien.TabIndex = 43;
			// 
			// MaNV
			// 
			this.MaNV.DataPropertyName = "MaNV";
			this.MaNV.HeaderText = "Mã nhân viên";
			this.MaNV.MinimumWidth = 6;
			this.MaNV.Name = "MaNV";
			this.MaNV.Width = 125;
			// 
			// lb_manhanvien
			// 
			this.lb_manhanvien.AutoSize = true;
			this.lb_manhanvien.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_manhanvien.Location = new System.Drawing.Point(21, 36);
			this.lb_manhanvien.Name = "lb_manhanvien";
			this.lb_manhanvien.Size = new System.Drawing.Size(103, 20);
			this.lb_manhanvien.TabIndex = 52;
			this.lb_manhanvien.Text = "Mã nhân viên";
			// 
			// txb_manhanvien
			// 
			this.txb_manhanvien.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txb_manhanvien.Location = new System.Drawing.Point(200, 36);
			this.txb_manhanvien.Name = "txb_manhanvien";
			this.txb_manhanvien.ReadOnly = true;
			this.txb_manhanvien.Size = new System.Drawing.Size(252, 27);
			this.txb_manhanvien.TabIndex = 51;
			// 
			// lb_loaiphucap
			// 
			this.lb_loaiphucap.AutoSize = true;
			this.lb_loaiphucap.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_loaiphucap.Location = new System.Drawing.Point(733, 36);
			this.lb_loaiphucap.Name = "lb_loaiphucap";
			this.lb_loaiphucap.Size = new System.Drawing.Size(97, 20);
			this.lb_loaiphucap.TabIndex = 50;
			this.lb_loaiphucap.Text = "Loại phụ cấp";
			// 
			// lb_tennhanvien
			// 
			this.lb_tennhanvien.AutoSize = true;
			this.lb_tennhanvien.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_tennhanvien.Location = new System.Drawing.Point(21, 86);
			this.lb_tennhanvien.Name = "lb_tennhanvien";
			this.lb_tennhanvien.Size = new System.Drawing.Size(106, 20);
			this.lb_tennhanvien.TabIndex = 49;
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
			this.dgv_phucap.Location = new System.Drawing.Point(11, 179);
			this.dgv_phucap.Name = "dgv_phucap";
			this.dgv_phucap.RowHeadersWidth = 51;
			this.dgv_phucap.RowTemplate.Height = 24;
			this.dgv_phucap.Size = new System.Drawing.Size(1461, 589);
			this.dgv_phucap.TabIndex = 48;
			// 
			// MaPhuCap
			// 
			this.MaPhuCap.DataPropertyName = "MaPhuCap";
			this.MaPhuCap.HeaderText = "Mã phụ cấp";
			this.MaPhuCap.MinimumWidth = 6;
			this.MaPhuCap.Name = "MaPhuCap";
			this.MaPhuCap.Width = 125;
			// 
			// lb_tienphucap
			// 
			this.lb_tienphucap.AutoSize = true;
			this.lb_tienphucap.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_tienphucap.Location = new System.Drawing.Point(733, 86);
			this.lb_tienphucap.Name = "lb_tienphucap";
			this.lb_tienphucap.Size = new System.Drawing.Size(98, 20);
			this.lb_tienphucap.TabIndex = 55;
			this.lb_tienphucap.Text = "Tiền phụ cấp";
			// 
			// txb_loaiphucap
			// 
			this.txb_loaiphucap.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txb_loaiphucap.Location = new System.Drawing.Point(915, 29);
			this.txb_loaiphucap.Name = "txb_loaiphucap";
			this.txb_loaiphucap.ReadOnly = true;
			this.txb_loaiphucap.Size = new System.Drawing.Size(252, 27);
			this.txb_loaiphucap.TabIndex = 57;
			// 
			// fQuanlyphucapUser
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.BlanchedAlmond;
			this.ClientSize = new System.Drawing.Size(1482, 778);
			this.Controls.Add(this.txb_loaiphucap);
			this.Controls.Add(this.txb_tienphucap);
			this.Controls.Add(this.btn_dongphucap);
			this.Controls.Add(this.txb_tennhanvien);
			this.Controls.Add(this.lb_manhanvien);
			this.Controls.Add(this.txb_manhanvien);
			this.Controls.Add(this.lb_loaiphucap);
			this.Controls.Add(this.lb_tennhanvien);
			this.Controls.Add(this.dgv_phucap);
			this.Controls.Add(this.lb_tienphucap);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "fQuanlyphucapUser";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Phụ cấp";
			((System.ComponentModel.ISupportInitialize)(this.dgv_phucap)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txb_tienphucap;
		private System.Windows.Forms.Button btn_dongphucap;
		private System.Windows.Forms.DataGridViewTextBoxColumn TienPC;
		private System.Windows.Forms.DataGridViewTextBoxColumn LoaiPhuCap;
		private System.Windows.Forms.DataGridViewTextBoxColumn HoTen;
		private System.Windows.Forms.TextBox txb_tennhanvien;
		private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
		private System.Windows.Forms.Label lb_manhanvien;
		private System.Windows.Forms.TextBox txb_manhanvien;
		private System.Windows.Forms.Label lb_loaiphucap;
		private System.Windows.Forms.Label lb_tennhanvien;
		private System.Windows.Forms.DataGridView dgv_phucap;
		private System.Windows.Forms.DataGridViewTextBoxColumn MaPhuCap;
		private System.Windows.Forms.Label lb_tienphucap;
		private System.Windows.Forms.TextBox txb_loaiphucap;
	}
}