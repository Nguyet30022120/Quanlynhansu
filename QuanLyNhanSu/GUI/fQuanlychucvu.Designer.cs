namespace QuanLyNhanSu
{
	partial class fQuanlychucvu
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
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(fQuanlychucvu));
			this.pn_chucvu = new System.Windows.Forms.Panel();
			this.lb_goiy = new System.Windows.Forms.Label();
			this.btn_timchucvu = new System.Windows.Forms.Button();
			this.btn_dongchucvu = new System.Windows.Forms.Button();
			this.txb_timchucvu = new System.Windows.Forms.TextBox();
			this.btn_xoachucvu = new System.Windows.Forms.Button();
			this.btn_suachucvu = new System.Windows.Forms.Button();
			this.btn_themchucvu = new System.Windows.Forms.Button();
			this.txb_motachucvu = new System.Windows.Forms.TextBox();
			this.txb_tenchucvu = new System.Windows.Forms.TextBox();
			this.lb_motachucvu = new System.Windows.Forms.Label();
			this.lb_tenchucvu = new System.Windows.Forms.Label();
			this.dgv_chucvu = new System.Windows.Forms.DataGridView();
			this.MaCV = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TenCV = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MoTa = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.pn_chucvu.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgv_chucvu)).BeginInit();
			this.SuspendLayout();
			// 
			// pn_chucvu
			// 
			this.pn_chucvu.BackColor = System.Drawing.Color.BlanchedAlmond;
			this.pn_chucvu.Controls.Add(this.lb_goiy);
			this.pn_chucvu.Controls.Add(this.btn_timchucvu);
			this.pn_chucvu.Controls.Add(this.btn_dongchucvu);
			this.pn_chucvu.Controls.Add(this.txb_timchucvu);
			this.pn_chucvu.Controls.Add(this.btn_xoachucvu);
			this.pn_chucvu.Controls.Add(this.btn_suachucvu);
			this.pn_chucvu.Controls.Add(this.btn_themchucvu);
			this.pn_chucvu.Controls.Add(this.txb_motachucvu);
			this.pn_chucvu.Controls.Add(this.txb_tenchucvu);
			this.pn_chucvu.Controls.Add(this.lb_motachucvu);
			this.pn_chucvu.Controls.Add(this.lb_tenchucvu);
			this.pn_chucvu.Location = new System.Drawing.Point(9, 9);
			this.pn_chucvu.Name = "pn_chucvu";
			this.pn_chucvu.Size = new System.Drawing.Size(1469, 179);
			this.pn_chucvu.TabIndex = 0;
			// 
			// lb_goiy
			// 
			this.lb_goiy.AutoSize = true;
			this.lb_goiy.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_goiy.Location = new System.Drawing.Point(1036, 61);
			this.lb_goiy.Name = "lb_goiy";
			this.lb_goiy.Size = new System.Drawing.Size(136, 17);
			this.lb_goiy.TabIndex = 48;
			this.lb_goiy.Text = "(Tìm kiếm tên chức vụ)";
			// 
			// btn_timchucvu
			// 
			this.btn_timchucvu.BackColor = System.Drawing.Color.DarkOrange;
			this.btn_timchucvu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_timchucvu.Location = new System.Drawing.Point(1201, 13);
			this.btn_timchucvu.Name = "btn_timchucvu";
			this.btn_timchucvu.Size = new System.Drawing.Size(115, 40);
			this.btn_timchucvu.TabIndex = 10;
			this.btn_timchucvu.Text = "Tìm kiếm";
			this.btn_timchucvu.UseVisualStyleBackColor = false;
			this.btn_timchucvu.Click += new System.EventHandler(this.btn_findcv_Click);
			this.btn_timchucvu.MouseEnter += new System.EventHandler(this.btn_timchucvu_MouseEnter);
			this.btn_timchucvu.MouseLeave += new System.EventHandler(this.btn_timchucvu_MouseLeave);
			// 
			// btn_dongchucvu
			// 
			this.btn_dongchucvu.BackColor = System.Drawing.Color.DarkOrange;
			this.btn_dongchucvu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_dongchucvu.Location = new System.Drawing.Point(1346, 130);
			this.btn_dongchucvu.Name = "btn_dongchucvu";
			this.btn_dongchucvu.Size = new System.Drawing.Size(115, 40);
			this.btn_dongchucvu.TabIndex = 9;
			this.btn_dongchucvu.Text = "Đóng";
			this.btn_dongchucvu.UseVisualStyleBackColor = false;
			this.btn_dongchucvu.Click += new System.EventHandler(this.btn_closecv_Click);
			this.btn_dongchucvu.MouseEnter += new System.EventHandler(this.btn_dongchucvu_MouseEnter);
			this.btn_dongchucvu.MouseLeave += new System.EventHandler(this.btn_dongchucvu_MouseLeave);
			// 
			// txb_timchucvu
			// 
			this.txb_timchucvu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txb_timchucvu.Location = new System.Drawing.Point(12, 20);
			this.txb_timchucvu.Name = "txb_timchucvu";
			this.txb_timchucvu.Size = new System.Drawing.Size(1160, 27);
			this.txb_timchucvu.TabIndex = 10;
			// 
			// btn_xoachucvu
			// 
			this.btn_xoachucvu.BackColor = System.Drawing.Color.DarkOrange;
			this.btn_xoachucvu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_xoachucvu.Location = new System.Drawing.Point(1346, 89);
			this.btn_xoachucvu.Name = "btn_xoachucvu";
			this.btn_xoachucvu.Size = new System.Drawing.Size(115, 40);
			this.btn_xoachucvu.TabIndex = 8;
			this.btn_xoachucvu.Text = "Xóa";
			this.btn_xoachucvu.UseVisualStyleBackColor = false;
			this.btn_xoachucvu.Click += new System.EventHandler(this.btn_deletecv_Click);
			this.btn_xoachucvu.MouseEnter += new System.EventHandler(this.btn_xoachucvu_MouseEnter);
			this.btn_xoachucvu.MouseLeave += new System.EventHandler(this.btn_xoachucvu_MouseLeave);
			// 
			// btn_suachucvu
			// 
			this.btn_suachucvu.BackColor = System.Drawing.Color.DarkOrange;
			this.btn_suachucvu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_suachucvu.Location = new System.Drawing.Point(1346, 49);
			this.btn_suachucvu.Name = "btn_suachucvu";
			this.btn_suachucvu.Size = new System.Drawing.Size(115, 40);
			this.btn_suachucvu.TabIndex = 7;
			this.btn_suachucvu.Text = "Sửa";
			this.btn_suachucvu.UseVisualStyleBackColor = false;
			this.btn_suachucvu.Click += new System.EventHandler(this.btn_editcv_Click);
			this.btn_suachucvu.MouseEnter += new System.EventHandler(this.btn_suachucvu_MouseEnter);
			this.btn_suachucvu.MouseLeave += new System.EventHandler(this.btn_suachucvu_MouseLeave);
			// 
			// btn_themchucvu
			// 
			this.btn_themchucvu.BackColor = System.Drawing.Color.DarkOrange;
			this.btn_themchucvu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_themchucvu.Location = new System.Drawing.Point(1346, 10);
			this.btn_themchucvu.Name = "btn_themchucvu";
			this.btn_themchucvu.Size = new System.Drawing.Size(115, 40);
			this.btn_themchucvu.TabIndex = 6;
			this.btn_themchucvu.Text = "Thêm";
			this.btn_themchucvu.UseVisualStyleBackColor = false;
			this.btn_themchucvu.Click += new System.EventHandler(this.btn_addcv_Click);
			this.btn_themchucvu.MouseEnter += new System.EventHandler(this.btn_themchucvu_MouseEnter);
			this.btn_themchucvu.MouseLeave += new System.EventHandler(this.btn_themchucvu_MouseLeave);
			// 
			// txb_motachucvu
			// 
			this.txb_motachucvu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txb_motachucvu.Location = new System.Drawing.Point(131, 130);
			this.txb_motachucvu.Name = "txb_motachucvu";
			this.txb_motachucvu.Size = new System.Drawing.Size(1185, 27);
			this.txb_motachucvu.TabIndex = 5;
			// 
			// txb_tenchucvu
			// 
			this.txb_tenchucvu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txb_tenchucvu.Location = new System.Drawing.Point(131, 81);
			this.txb_tenchucvu.Name = "txb_tenchucvu";
			this.txb_tenchucvu.Size = new System.Drawing.Size(252, 27);
			this.txb_tenchucvu.TabIndex = 4;
			// 
			// lb_motachucvu
			// 
			this.lb_motachucvu.AutoSize = true;
			this.lb_motachucvu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_motachucvu.Location = new System.Drawing.Point(8, 130);
			this.lb_motachucvu.Name = "lb_motachucvu";
			this.lb_motachucvu.Size = new System.Drawing.Size(108, 20);
			this.lb_motachucvu.TabIndex = 2;
			this.lb_motachucvu.Text = "Mô tả chức vụ";
			// 
			// lb_tenchucvu
			// 
			this.lb_tenchucvu.AutoSize = true;
			this.lb_tenchucvu.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_tenchucvu.Location = new System.Drawing.Point(8, 81);
			this.lb_tenchucvu.Name = "lb_tenchucvu";
			this.lb_tenchucvu.Size = new System.Drawing.Size(92, 20);
			this.lb_tenchucvu.TabIndex = 0;
			this.lb_tenchucvu.Text = "Tên chức vụ";
			// 
			// dgv_chucvu
			// 
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.Tan;
			this.dgv_chucvu.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dgv_chucvu.BackgroundColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgv_chucvu.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dgv_chucvu.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv_chucvu.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaCV,
            this.TenCV,
            this.MoTa});
			this.dgv_chucvu.Location = new System.Drawing.Point(9, 194);
			this.dgv_chucvu.Name = "dgv_chucvu";
			this.dgv_chucvu.RowHeadersWidth = 51;
			this.dgv_chucvu.RowTemplate.Height = 24;
			this.dgv_chucvu.Size = new System.Drawing.Size(1469, 578);
			this.dgv_chucvu.TabIndex = 1;
			// 
			// MaCV
			// 
			this.MaCV.DataPropertyName = "MaChucVu";
			this.MaCV.HeaderText = "Mã chức vụ";
			this.MaCV.MinimumWidth = 6;
			this.MaCV.Name = "MaCV";
			this.MaCV.Width = 125;
			// 
			// TenCV
			// 
			this.TenCV.DataPropertyName = "TenChucVu";
			this.TenCV.HeaderText = "Tên chức vụ";
			this.TenCV.MinimumWidth = 6;
			this.TenCV.Name = "TenCV";
			this.TenCV.Width = 125;
			// 
			// MoTa
			// 
			this.MoTa.DataPropertyName = "MoTaChucVu";
			this.MoTa.HeaderText = "Mô tả";
			this.MoTa.MinimumWidth = 6;
			this.MoTa.Name = "MoTa";
			this.MoTa.Width = 400;
			// 
			// fQuanlychucvu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.BlanchedAlmond;
			this.ClientSize = new System.Drawing.Size(1482, 778);
			this.Controls.Add(this.dgv_chucvu);
			this.Controls.Add(this.pn_chucvu);
			this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
			this.Name = "fQuanlychucvu";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Chức vụ";
			this.pn_chucvu.ResumeLayout(false);
			this.pn_chucvu.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgv_chucvu)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel pn_chucvu;
		private System.Windows.Forms.DataGridView dgv_chucvu;
		private System.Windows.Forms.Label lb_tenchucvu;
		private System.Windows.Forms.Button btn_dongchucvu;
		private System.Windows.Forms.Button btn_xoachucvu;
		private System.Windows.Forms.Button btn_suachucvu;
		private System.Windows.Forms.Button btn_themchucvu;
		private System.Windows.Forms.TextBox txb_motachucvu;
		private System.Windows.Forms.TextBox txb_tenchucvu;
		private System.Windows.Forms.Label lb_motachucvu;
		private System.Windows.Forms.TextBox txb_timchucvu;
		private System.Windows.Forms.Button btn_timchucvu;
		private System.Windows.Forms.DataGridViewTextBoxColumn MaCV;
		private System.Windows.Forms.DataGridViewTextBoxColumn TenCV;
		private System.Windows.Forms.DataGridViewTextBoxColumn MoTa;
		private System.Windows.Forms.Label lb_goiy;
	}
}