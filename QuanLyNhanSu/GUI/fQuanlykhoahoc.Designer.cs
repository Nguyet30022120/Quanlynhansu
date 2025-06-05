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
			this.lb_tenkhoahoc = new System.Windows.Forms.Label();
			this.lb_mota = new System.Windows.Forms.Label();
			this.txb_tenkh = new System.Windows.Forms.TextBox();
			this.txb_motakh = new System.Windows.Forms.TextBox();
			this.dgv_khoahoc = new System.Windows.Forms.DataGridView();
			this.MaKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MoTa = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btn_themkhoahoc = new System.Windows.Forms.Button();
			this.btn_suakhoahoc = new System.Windows.Forms.Button();
			this.btn_xoakhoahoc = new System.Windows.Forms.Button();
			this.btn_dongkhoahoc = new System.Windows.Forms.Button();
			this.txb_findkh = new System.Windows.Forms.TextBox();
			this.btn_timkhoahoc = new System.Windows.Forms.Button();
			this.panel1 = new System.Windows.Forms.Panel();
			((System.ComponentModel.ISupportInitialize)(this.dgv_khoahoc)).BeginInit();
			this.panel1.SuspendLayout();
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
			// txb_tenkh
			// 
			this.txb_tenkh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txb_tenkh.Location = new System.Drawing.Point(189, 25);
			this.txb_tenkh.Name = "txb_tenkh";
			this.txb_tenkh.Size = new System.Drawing.Size(252, 27);
			this.txb_tenkh.TabIndex = 4;
			// 
			// txb_motakh
			// 
			this.txb_motakh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txb_motakh.Location = new System.Drawing.Point(186, 66);
			this.txb_motakh.Name = "txb_motakh";
			this.txb_motakh.Size = new System.Drawing.Size(970, 27);
			this.txb_motakh.TabIndex = 5;
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
			this.TenKH.Width = 125;
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
			// 
			// txb_findkh
			// 
			this.txb_findkh.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txb_findkh.Location = new System.Drawing.Point(9, 134);
			this.txb_findkh.Name = "txb_findkh";
			this.txb_findkh.Size = new System.Drawing.Size(1147, 27);
			this.txb_findkh.TabIndex = 11;
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
			// 
			// panel1
			// 
			this.panel1.Controls.Add(this.btn_dongkhoahoc);
			this.panel1.Controls.Add(this.txb_findkh);
			this.panel1.Controls.Add(this.btn_xoakhoahoc);
			this.panel1.Controls.Add(this.btn_timkhoahoc);
			this.panel1.Controls.Add(this.btn_suakhoahoc);
			this.panel1.Controls.Add(this.lb_mota);
			this.panel1.Controls.Add(this.btn_themkhoahoc);
			this.panel1.Controls.Add(this.txb_motakh);
			this.panel1.Controls.Add(this.lb_tenkhoahoc);
			this.panel1.Location = new System.Drawing.Point(3, 5);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1476, 217);
			this.panel1.TabIndex = 13;
			// 
			// fQuanlykhoahoc
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.BlanchedAlmond;
			this.ClientSize = new System.Drawing.Size(1482, 778);
			this.Controls.Add(this.dgv_khoahoc);
			this.Controls.Add(this.txb_tenkh);
			this.Controls.Add(this.panel1);
			this.Name = "fQuanlykhoahoc";
			this.Text = "Quản lý khóa học";
			this.Load += new System.EventHandler(this.fCourseManagement_Load);
			((System.ComponentModel.ISupportInitialize)(this.dgv_khoahoc)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion
		private System.Windows.Forms.Label lb_tenkhoahoc;
		private System.Windows.Forms.Label lb_mota;
		private System.Windows.Forms.TextBox txb_tenkh;
		private System.Windows.Forms.TextBox txb_motakh;
		private System.Windows.Forms.DataGridView dgv_khoahoc;
		private System.Windows.Forms.Button btn_themkhoahoc;
		private System.Windows.Forms.Button btn_suakhoahoc;
		private System.Windows.Forms.Button btn_xoakhoahoc;
		private System.Windows.Forms.Button btn_dongkhoahoc;
		private System.Windows.Forms.TextBox txb_findkh;
		private System.Windows.Forms.Button btn_timkhoahoc;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.DataGridViewTextBoxColumn MaKH;
		private System.Windows.Forms.DataGridViewTextBoxColumn TenKH;
		private System.Windows.Forms.DataGridViewTextBoxColumn MoTa;
	}
}