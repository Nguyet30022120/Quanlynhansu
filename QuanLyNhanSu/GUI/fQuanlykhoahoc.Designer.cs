namespace QuanLyNhanSu.GUI
{
	partial class fQuanlykhoahoc
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fQuanlykhoahoc));
			this.lb_tenkhoahoc = new System.Windows.Forms.Label();
			this.lb_mota = new System.Windows.Forms.Label();
			this.txb_tenkhoahoc = new System.Windows.Forms.TextBox();
			this.txb_mota = new System.Windows.Forms.TextBox();
			this.dgv_khoahoc = new System.Windows.Forms.DataGridView();
			this.MaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MoTa = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btn_themkhoahoc = new System.Windows.Forms.Button();
			this.btn_suakhoahoc = new System.Windows.Forms.Button();
			this.btn_xoakhoahoc = new System.Windows.Forms.Button();
			this.btn_dongkhoahoc = new System.Windows.Forms.Button();
			this.txb_timkhoahoc = new System.Windows.Forms.TextBox();
			this.btn_timkhoahoc = new System.Windows.Forms.Button();
			this.pn_khoahoc = new System.Windows.Forms.Panel();
			this.lb_goiy = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dgv_khoahoc)).BeginInit();
			this.pn_khoahoc.SuspendLayout();
			this.SuspendLayout();
			// 
			// lb_tenkhoahoc
			// 
			this.lb_tenkhoahoc.AutoSize = true;
			this.lb_tenkhoahoc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_tenkhoahoc.Location = new System.Drawing.Point(9, 22);
			this.lb_tenkhoahoc.Name = "lb_tenkhoahoc";
			this.lb_tenkhoahoc.Size = new System.Drawing.Size(101, 20);
			this.lb_tenkhoahoc.TabIndex = 1;
			this.lb_tenkhoahoc.Text = "Tên khóa học";
			// 
			// lb_mota
			// 
			this.lb_mota.AutoSize = true;
			this.lb_mota.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_mota.Location = new System.Drawing.Point(9, 69);
			this.lb_mota.Name = "lb_mota";
			this.lb_mota.Size = new System.Drawing.Size(54, 20);
			this.lb_mota.TabIndex = 2;
			this.lb_mota.Text = "Mô tả ";
			// 
			// txb_tenkhoahoc
			// 
			this.txb_tenkhoahoc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txb_tenkhoahoc.Location = new System.Drawing.Point(189, 25);
			this.txb_tenkhoahoc.Name = "txb_tenkhoahoc";
			this.txb_tenkhoahoc.Size = new System.Drawing.Size(970, 27);
			this.txb_tenkhoahoc.TabIndex = 4;
			// 
			// txb_mota
			// 
			this.txb_mota.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txb_mota.Location = new System.Drawing.Point(186, 66);
			this.txb_mota.Name = "txb_mota";
			this.txb_mota.Size = new System.Drawing.Size(970, 27);
			this.txb_mota.TabIndex = 5;
			// 
			// dgv_khoahoc
			// 
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.Tan;
			this.dgv_khoahoc.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dgv_khoahoc.BackgroundColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgv_khoahoc.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dgv_khoahoc.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv_khoahoc.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaKH,
            this.TenKH,
            this.MoTa});
			this.dgv_khoahoc.Location = new System.Drawing.Point(3, 178);
			this.dgv_khoahoc.Name = "dgv_khoahoc";
			this.dgv_khoahoc.RowHeadersWidth = 51;
			this.dgv_khoahoc.RowTemplate.Height = 24;
			this.dgv_khoahoc.Size = new System.Drawing.Size(1476, 599);
			this.dgv_khoahoc.TabIndex = 6;
			// 
			// MaKH
			// 
			this.MaKH.DataPropertyName = "MaKhoaHoc";
			this.MaKH.HeaderText = "Mã khóa học";
			this.MaKH.MinimumWidth = 6;
			this.MaKH.Name = "MaKH";
			this.MaKH.Width = 125;
			// 
			// TenKH
			// 
			this.TenKH.DataPropertyName = "TenKhoaHoc";
			this.TenKH.HeaderText = "Tên khóa học";
			this.TenKH.MinimumWidth = 6;
			this.TenKH.Name = "TenKH";
			this.TenKH.Width = 200;
			// 
			// MoTa
			// 
			this.MoTa.DataPropertyName = "MoTaKhoaHoc";
			this.MoTa.HeaderText = "Mô tả";
			this.MoTa.MinimumWidth = 6;
			this.MoTa.Name = "MoTa";
			this.MoTa.Width = 400;
			// 
			// btn_themkhoahoc
			// 
			this.btn_themkhoahoc.BackColor = System.Drawing.Color.DarkOrange;
			this.btn_themkhoahoc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_themkhoahoc.Location = new System.Drawing.Point(1352, 7);
			this.btn_themkhoahoc.Name = "btn_themkhoahoc";
			this.btn_themkhoahoc.Size = new System.Drawing.Size(115, 40);
			this.btn_themkhoahoc.TabIndex = 7;
			this.btn_themkhoahoc.Text = "Thêm";
			this.btn_themkhoahoc.UseVisualStyleBackColor = false;
			this.btn_themkhoahoc.Click += new System.EventHandler(this.btn_addkh_Click);
			this.btn_themkhoahoc.MouseEnter += new System.EventHandler(this.btn_themkhoahoc_MouseEnter);
			this.btn_themkhoahoc.MouseLeave += new System.EventHandler(this.btn_themkhoahoc_MouseLeave);
			// 
			// btn_suakhoahoc
			// 
			this.btn_suakhoahoc.BackColor = System.Drawing.Color.DarkOrange;
			this.btn_suakhoahoc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_suakhoahoc.Location = new System.Drawing.Point(1352, 47);
			this.btn_suakhoahoc.Name = "btn_suakhoahoc";
			this.btn_suakhoahoc.Size = new System.Drawing.Size(115, 40);
			this.btn_suakhoahoc.TabIndex = 8;
			this.btn_suakhoahoc.Text = "Sửa";
			this.btn_suakhoahoc.UseVisualStyleBackColor = false;
			this.btn_suakhoahoc.Click += new System.EventHandler(this.btn_editkh_Click);
			this.btn_suakhoahoc.MouseEnter += new System.EventHandler(this.btn_suakhoahoc_MouseEnter);
			this.btn_suakhoahoc.MouseLeave += new System.EventHandler(this.btn_suakhoahoc_MouseLeave);
			// 
			// btn_xoakhoahoc
			// 
			this.btn_xoakhoahoc.BackColor = System.Drawing.Color.DarkOrange;
			this.btn_xoakhoahoc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_xoakhoahoc.Location = new System.Drawing.Point(1352, 87);
			this.btn_xoakhoahoc.Name = "btn_xoakhoahoc";
			this.btn_xoakhoahoc.Size = new System.Drawing.Size(115, 40);
			this.btn_xoakhoahoc.TabIndex = 9;
			this.btn_xoakhoahoc.Text = "Xóa";
			this.btn_xoakhoahoc.UseVisualStyleBackColor = false;
			this.btn_xoakhoahoc.Click += new System.EventHandler(this.btn_deletekh_Click);
			this.btn_xoakhoahoc.MouseEnter += new System.EventHandler(this.btn_xoakhoahoc_MouseEnter);
			this.btn_xoakhoahoc.MouseLeave += new System.EventHandler(this.btn_xoakhoahoc_MouseLeave);
			// 
			// btn_dongkhoahoc
			// 
			this.btn_dongkhoahoc.BackColor = System.Drawing.Color.DarkOrange;
			this.btn_dongkhoahoc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_dongkhoahoc.Location = new System.Drawing.Point(1352, 127);
			this.btn_dongkhoahoc.Name = "btn_dongkhoahoc";
			this.btn_dongkhoahoc.Size = new System.Drawing.Size(115, 40);
			this.btn_dongkhoahoc.TabIndex = 10;
			this.btn_dongkhoahoc.Text = "Đóng";
			this.btn_dongkhoahoc.UseVisualStyleBackColor = false;
			this.btn_dongkhoahoc.Click += new System.EventHandler(this.btn_closekh_Click);
			this.btn_dongkhoahoc.MouseEnter += new System.EventHandler(this.btn_dongkhoahoc_MouseEnter);
			this.btn_dongkhoahoc.MouseLeave += new System.EventHandler(this.btn_dongkhoahoc_MouseLeave);
			// 
			// txb_timkhoahoc
			// 
			this.txb_timkhoahoc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txb_timkhoahoc.Location = new System.Drawing.Point(9, 134);
			this.txb_timkhoahoc.Name = "txb_timkhoahoc";
			this.txb_timkhoahoc.Size = new System.Drawing.Size(1147, 27);
			this.txb_timkhoahoc.TabIndex = 11;
			// 
			// btn_timkhoahoc
			// 
			this.btn_timkhoahoc.BackColor = System.Drawing.Color.DarkOrange;
			this.btn_timkhoahoc.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_timkhoahoc.Location = new System.Drawing.Point(1183, 127);
			this.btn_timkhoahoc.Name = "btn_timkhoahoc";
			this.btn_timkhoahoc.Size = new System.Drawing.Size(115, 40);
			this.btn_timkhoahoc.TabIndex = 12;
			this.btn_timkhoahoc.Text = "Tìm kiếm";
			this.btn_timkhoahoc.UseVisualStyleBackColor = false;
			this.btn_timkhoahoc.Click += new System.EventHandler(this.btn_findkh_Click);
			this.btn_timkhoahoc.MouseEnter += new System.EventHandler(this.btn_timkhoahoc_MouseEnter);
			this.btn_timkhoahoc.MouseLeave += new System.EventHandler(this.btn_timkhoahoc_MouseLeave);
			// 
			// pn_khoahoc
			// 
			this.pn_khoahoc.Controls.Add(this.lb_goiy);
			this.pn_khoahoc.Controls.Add(this.btn_dongkhoahoc);
			this.pn_khoahoc.Controls.Add(this.txb_timkhoahoc);
			this.pn_khoahoc.Controls.Add(this.btn_xoakhoahoc);
			this.pn_khoahoc.Controls.Add(this.btn_timkhoahoc);
			this.pn_khoahoc.Controls.Add(this.btn_suakhoahoc);
			this.pn_khoahoc.Controls.Add(this.lb_mota);
			this.pn_khoahoc.Controls.Add(this.btn_themkhoahoc);
			this.pn_khoahoc.Controls.Add(this.txb_mota);
			this.pn_khoahoc.Controls.Add(this.lb_tenkhoahoc);
			this.pn_khoahoc.Location = new System.Drawing.Point(3, 5);
			this.pn_khoahoc.Name = "pn_khoahoc";
			this.pn_khoahoc.Size = new System.Drawing.Size(1476, 174);
			this.pn_khoahoc.TabIndex = 13;
			// 
			// lb_goiy
			// 
			this.lb_goiy.AutoSize = true;
			this.lb_goiy.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_goiy.Location = new System.Drawing.Point(10, 110);
			this.lb_goiy.Name = "lb_goiy";
			this.lb_goiy.Size = new System.Drawing.Size(122, 17);
			this.lb_goiy.TabIndex = 46;
			this.lb_goiy.Text = "(Tìm kiếm khóa học)";
			// 
			// fQuanlykhoahoc
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.BlanchedAlmond;
			this.ClientSize = new System.Drawing.Size(1482, 778);
			this.Controls.Add(this.dgv_khoahoc);
			this.Controls.Add(this.txb_tenkhoahoc);
			this.Controls.Add(this.pn_khoahoc);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "fQuanlykhoahoc";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Khóa học";
			this.Load += new System.EventHandler(this.fCourseManagement_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgv_khoahoc)).EndInit();
			this.pn_khoahoc.ResumeLayout(false);
			this.pn_khoahoc.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label lb_tenkhoahoc;
		private System.Windows.Forms.Label lb_mota;
		private System.Windows.Forms.TextBox txb_tenkhoahoc;
		private System.Windows.Forms.TextBox txb_mota;
		private System.Windows.Forms.DataGridView dgv_khoahoc;
		private System.Windows.Forms.Button btn_themkhoahoc;
		private System.Windows.Forms.Button btn_suakhoahoc;
		private System.Windows.Forms.Button btn_xoakhoahoc;
		private System.Windows.Forms.Button btn_dongkhoahoc;
		private System.Windows.Forms.TextBox txb_timkhoahoc;
		private System.Windows.Forms.Button btn_timkhoahoc;
		private System.Windows.Forms.Panel pn_khoahoc;
		private System.Windows.Forms.Label lb_goiy;
		private System.Windows.Forms.DataGridViewTextBoxColumn MaKH;
		private System.Windows.Forms.DataGridViewTextBoxColumn TenKH;
		private System.Windows.Forms.DataGridViewTextBoxColumn MoTa;
	}
}