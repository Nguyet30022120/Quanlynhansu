namespace QuanLyNhanSu.GUI
{
	partial class fQuanlycong
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
			this.btn_themcong = new System.Windows.Forms.Button();
			this.btn_suacong = new System.Windows.Forms.Button();
			this.btn_xoacong = new System.Windows.Forms.Button();
			this.btn_dongcong = new System.Windows.Forms.Button();
			this.lb_loaicong = new System.Windows.Forms.Label();
			this.lb_heso = new System.Windows.Forms.Label();
			this.txb_loaicong = new System.Windows.Forms.TextBox();
			this.txb_heso = new System.Windows.Forms.TextBox();
			this.dgv_quanlycong = new System.Windows.Forms.DataGridView();
			this.MaLoaiCong = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TenLoaiCong = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.HeSo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dgv_quanlycong)).BeginInit();
			this.SuspendLayout();
			// 
			// btn_themcong
			// 
			this.btn_themcong.BackColor = System.Drawing.Color.DarkOrange;
			this.btn_themcong.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_themcong.Location = new System.Drawing.Point(827, 10);
			this.btn_themcong.Name = "btn_themcong";
			this.btn_themcong.Size = new System.Drawing.Size(115, 40);
			this.btn_themcong.TabIndex = 0;
			this.btn_themcong.Text = "Thêm";
			this.btn_themcong.UseVisualStyleBackColor = false;
			this.btn_themcong.Click += new System.EventHandler(this.btn_addcong_Click);
			// 
			// btn_suacong
			// 
			this.btn_suacong.BackColor = System.Drawing.Color.DarkOrange;
			this.btn_suacong.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_suacong.Location = new System.Drawing.Point(827, 50);
			this.btn_suacong.Name = "btn_suacong";
			this.btn_suacong.Size = new System.Drawing.Size(115, 40);
			this.btn_suacong.TabIndex = 1;
			this.btn_suacong.Text = "Sửa";
			this.btn_suacong.UseVisualStyleBackColor = false;
			this.btn_suacong.Click += new System.EventHandler(this.btn_editcong_Click);
			// 
			// btn_xoacong
			// 
			this.btn_xoacong.BackColor = System.Drawing.Color.DarkOrange;
			this.btn_xoacong.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_xoacong.Location = new System.Drawing.Point(827, 90);
			this.btn_xoacong.Name = "btn_xoacong";
			this.btn_xoacong.Size = new System.Drawing.Size(115, 40);
			this.btn_xoacong.TabIndex = 2;
			this.btn_xoacong.Text = "Xóa";
			this.btn_xoacong.UseVisualStyleBackColor = false;
			this.btn_xoacong.Click += new System.EventHandler(this.btn_deletecong_Click);
			// 
			// btn_dongcong
			// 
			this.btn_dongcong.BackColor = System.Drawing.Color.DarkOrange;
			this.btn_dongcong.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_dongcong.Location = new System.Drawing.Point(827, 130);
			this.btn_dongcong.Name = "btn_dongcong";
			this.btn_dongcong.Size = new System.Drawing.Size(115, 40);
			this.btn_dongcong.TabIndex = 3;
			this.btn_dongcong.Text = "Đóng";
			this.btn_dongcong.UseVisualStyleBackColor = false;
			this.btn_dongcong.Click += new System.EventHandler(this.btn_closecong_Click);
			// 
			// lb_loaicong
			// 
			this.lb_loaicong.AutoSize = true;
			this.lb_loaicong.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_loaicong.Location = new System.Drawing.Point(30, 20);
			this.lb_loaicong.Name = "lb_loaicong";
			this.lb_loaicong.Size = new System.Drawing.Size(76, 20);
			this.lb_loaicong.TabIndex = 4;
			this.lb_loaicong.Text = "Loại công";
			// 
			// lb_heso
			// 
			this.lb_heso.AutoSize = true;
			this.lb_heso.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_heso.Location = new System.Drawing.Point(30, 75);
			this.lb_heso.Name = "lb_heso";
			this.lb_heso.Size = new System.Drawing.Size(48, 20);
			this.lb_heso.TabIndex = 5;
			this.lb_heso.Text = "Hệ số";
			// 
			// txb_loaicong
			// 
			this.txb_loaicong.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txb_loaicong.Location = new System.Drawing.Point(140, 20);
			this.txb_loaicong.Name = "txb_loaicong";
			this.txb_loaicong.Size = new System.Drawing.Size(252, 27);
			this.txb_loaicong.TabIndex = 6;
			// 
			// txb_heso
			// 
			this.txb_heso.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txb_heso.Location = new System.Drawing.Point(140, 75);
			this.txb_heso.Name = "txb_heso";
			this.txb_heso.Size = new System.Drawing.Size(252, 27);
			this.txb_heso.TabIndex = 7;
			// 
			// dgv_quanlycong
			// 
			this.dgv_quanlycong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv_quanlycong.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaLoaiCong,
            this.TenLoaiCong,
            this.HeSo});
			this.dgv_quanlycong.Location = new System.Drawing.Point(13, 176);
			this.dgv_quanlycong.Name = "dgv_quanlycong";
			this.dgv_quanlycong.RowHeadersWidth = 51;
			this.dgv_quanlycong.RowTemplate.Height = 24;
			this.dgv_quanlycong.Size = new System.Drawing.Size(957, 315);
			this.dgv_quanlycong.TabIndex = 8;
			// 
			// MaLoaiCong
			// 
			this.MaLoaiCong.DataPropertyName = "MaLoaiCong";
			this.MaLoaiCong.HeaderText = "Mã loại công";
			this.MaLoaiCong.MinimumWidth = 6;
			this.MaLoaiCong.Name = "MaLoaiCong";
			this.MaLoaiCong.Width = 125;
			// 
			// TenLoaiCong
			// 
			this.TenLoaiCong.DataPropertyName = "TenLoaiCong";
			this.TenLoaiCong.HeaderText = "Loại công";
			this.TenLoaiCong.MinimumWidth = 6;
			this.TenLoaiCong.Name = "TenLoaiCong";
			this.TenLoaiCong.Width = 125;
			// 
			// HeSo
			// 
			this.HeSo.DataPropertyName = "HeSo";
			this.HeSo.HeaderText = "Hệ số";
			this.HeSo.MinimumWidth = 6;
			this.HeSo.Name = "HeSo";
			this.HeSo.Width = 125;
			// 
			// fQuanlycong
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.BlanchedAlmond;
			this.ClientSize = new System.Drawing.Size(982, 503);
			this.Controls.Add(this.dgv_quanlycong);
			this.Controls.Add(this.txb_heso);
			this.Controls.Add(this.txb_loaicong);
			this.Controls.Add(this.lb_heso);
			this.Controls.Add(this.lb_loaicong);
			this.Controls.Add(this.btn_dongcong);
			this.Controls.Add(this.btn_xoacong);
			this.Controls.Add(this.btn_suacong);
			this.Controls.Add(this.btn_themcong);
			this.Name = "fQuanlycong";
			this.Text = "Quản lý công";
			((System.ComponentModel.ISupportInitialize)(this.dgv_quanlycong)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btn_themcong;
		private System.Windows.Forms.Button btn_suacong;
		private System.Windows.Forms.Button btn_xoacong;
		private System.Windows.Forms.Button btn_dongcong;
		private System.Windows.Forms.Label lb_loaicong;
		private System.Windows.Forms.Label lb_heso;
		private System.Windows.Forms.TextBox txb_loaicong;
		private System.Windows.Forms.TextBox txb_heso;
		private System.Windows.Forms.DataGridView dgv_quanlycong;
		private System.Windows.Forms.DataGridViewTextBoxColumn MaLoaiCong;
		private System.Windows.Forms.DataGridViewTextBoxColumn TenLoaiCong;
		private System.Windows.Forms.DataGridViewTextBoxColumn HeSo;
	}
}