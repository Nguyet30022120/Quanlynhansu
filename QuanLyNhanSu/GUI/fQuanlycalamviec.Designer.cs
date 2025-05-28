namespace QuanLyNhanSu.GUI
{
	partial class fQuanlycalamviec
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
			this.dgv_calamviec = new System.Windows.Forms.DataGridView();
			this.MaLoaiCa = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TenLoaiCa = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.HeSo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.lb_loaica = new System.Windows.Forms.Label();
			this.lb_heso = new System.Windows.Forms.Label();
			this.txb_loaica = new System.Windows.Forms.TextBox();
			this.txb_heso = new System.Windows.Forms.TextBox();
			this.btn_themca = new System.Windows.Forms.Button();
			this.btn_suaca = new System.Windows.Forms.Button();
			this.btn_xoaca = new System.Windows.Forms.Button();
			this.btn_dongca = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgv_calamviec)).BeginInit();
			this.SuspendLayout();
			// 
			// dgv_calamviec
			// 
			this.dgv_calamviec.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv_calamviec.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaLoaiCa,
            this.TenLoaiCa,
            this.HeSo});
			this.dgv_calamviec.Location = new System.Drawing.Point(13, 176);
			this.dgv_calamviec.Name = "dgv_calamviec";
			this.dgv_calamviec.RowHeadersWidth = 51;
			this.dgv_calamviec.RowTemplate.Height = 24;
			this.dgv_calamviec.Size = new System.Drawing.Size(957, 315);
			this.dgv_calamviec.TabIndex = 0;
			// 
			// MaLoaiCa
			// 
			this.MaLoaiCa.DataPropertyName = "MaLoaiCa";
			this.MaLoaiCa.HeaderText = "Mã loại ca";
			this.MaLoaiCa.MinimumWidth = 6;
			this.MaLoaiCa.Name = "MaLoaiCa";
			this.MaLoaiCa.Width = 125;
			// 
			// TenLoaiCa
			// 
			this.TenLoaiCa.DataPropertyName = "TenLoaiCa";
			this.TenLoaiCa.HeaderText = "Loại ca";
			this.TenLoaiCa.MinimumWidth = 6;
			this.TenLoaiCa.Name = "TenLoaiCa";
			this.TenLoaiCa.Width = 125;
			// 
			// HeSo
			// 
			this.HeSo.DataPropertyName = "HeSo";
			this.HeSo.HeaderText = "Hệ số";
			this.HeSo.MinimumWidth = 6;
			this.HeSo.Name = "HeSo";
			this.HeSo.Width = 125;
			// 
			// lb_loaica
			// 
			this.lb_loaica.AutoSize = true;
			this.lb_loaica.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_loaica.Location = new System.Drawing.Point(30, 20);
			this.lb_loaica.Name = "lb_loaica";
			this.lb_loaica.Size = new System.Drawing.Size(57, 20);
			this.lb_loaica.TabIndex = 1;
			this.lb_loaica.Text = "Loại ca";
			// 
			// lb_heso
			// 
			this.lb_heso.AutoSize = true;
			this.lb_heso.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_heso.Location = new System.Drawing.Point(30, 90);
			this.lb_heso.Name = "lb_heso";
			this.lb_heso.Size = new System.Drawing.Size(48, 20);
			this.lb_heso.TabIndex = 2;
			this.lb_heso.Text = "Hệ số";
			// 
			// txb_loaica
			// 
			this.txb_loaica.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txb_loaica.Location = new System.Drawing.Point(140, 20);
			this.txb_loaica.Name = "txb_loaica";
			this.txb_loaica.Size = new System.Drawing.Size(252, 27);
			this.txb_loaica.TabIndex = 3;
			// 
			// txb_heso
			// 
			this.txb_heso.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txb_heso.Location = new System.Drawing.Point(140, 90);
			this.txb_heso.Name = "txb_heso";
			this.txb_heso.Size = new System.Drawing.Size(252, 27);
			this.txb_heso.TabIndex = 4;
			// 
			// btn_themca
			// 
			this.btn_themca.BackColor = System.Drawing.Color.DarkOrange;
			this.btn_themca.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_themca.Location = new System.Drawing.Point(827, 10);
			this.btn_themca.Name = "btn_themca";
			this.btn_themca.Size = new System.Drawing.Size(115, 40);
			this.btn_themca.TabIndex = 5;
			this.btn_themca.Text = "Thêm";
			this.btn_themca.UseVisualStyleBackColor = false;
			this.btn_themca.Click += new System.EventHandler(this.btn_addca_Click);
			// 
			// btn_suaca
			// 
			this.btn_suaca.BackColor = System.Drawing.Color.DarkOrange;
			this.btn_suaca.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_suaca.Location = new System.Drawing.Point(827, 50);
			this.btn_suaca.Name = "btn_suaca";
			this.btn_suaca.Size = new System.Drawing.Size(115, 40);
			this.btn_suaca.TabIndex = 6;
			this.btn_suaca.Text = "Sửa";
			this.btn_suaca.UseVisualStyleBackColor = false;
			this.btn_suaca.Click += new System.EventHandler(this.btn_editca_Click);
			// 
			// btn_xoaca
			// 
			this.btn_xoaca.BackColor = System.Drawing.Color.DarkOrange;
			this.btn_xoaca.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_xoaca.Location = new System.Drawing.Point(827, 90);
			this.btn_xoaca.Name = "btn_xoaca";
			this.btn_xoaca.Size = new System.Drawing.Size(115, 40);
			this.btn_xoaca.TabIndex = 7;
			this.btn_xoaca.Text = "Xóa";
			this.btn_xoaca.UseVisualStyleBackColor = false;
			this.btn_xoaca.Click += new System.EventHandler(this.btn_deleteca_Click);
			// 
			// btn_dongca
			// 
			this.btn_dongca.BackColor = System.Drawing.Color.DarkOrange;
			this.btn_dongca.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_dongca.Location = new System.Drawing.Point(827, 130);
			this.btn_dongca.Name = "btn_dongca";
			this.btn_dongca.Size = new System.Drawing.Size(115, 40);
			this.btn_dongca.TabIndex = 8;
			this.btn_dongca.Text = "Đóng";
			this.btn_dongca.UseVisualStyleBackColor = false;
			this.btn_dongca.Click += new System.EventHandler(this.btn_closeca_Click);
			// 
			// fQuanlycalamviec
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.BlanchedAlmond;
			this.ClientSize = new System.Drawing.Size(982, 503);
			this.Controls.Add(this.btn_dongca);
			this.Controls.Add(this.btn_xoaca);
			this.Controls.Add(this.btn_suaca);
			this.Controls.Add(this.btn_themca);
			this.Controls.Add(this.txb_heso);
			this.Controls.Add(this.txb_loaica);
			this.Controls.Add(this.lb_heso);
			this.Controls.Add(this.lb_loaica);
			this.Controls.Add(this.dgv_calamviec);
			this.Name = "fQuanlycalamviec";
			this.Text = "Quản lý ca làm việc";
			((System.ComponentModel.ISupportInitialize)(this.dgv_calamviec)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dgv_calamviec;
		private System.Windows.Forms.Label lb_loaica;
		private System.Windows.Forms.Label lb_heso;
		private System.Windows.Forms.TextBox txb_loaica;
		private System.Windows.Forms.TextBox txb_heso;
		private System.Windows.Forms.Button btn_themca;
		private System.Windows.Forms.Button btn_suaca;
		private System.Windows.Forms.Button btn_xoaca;
		private System.Windows.Forms.Button btn_dongca;
		private System.Windows.Forms.DataGridViewTextBoxColumn MaLoaiCa;
		private System.Windows.Forms.DataGridViewTextBoxColumn TenLoaiCa;
		private System.Windows.Forms.DataGridViewTextBoxColumn HeSo;
	}
}