namespace QuanLyNhanSu.GUI
{
	partial class fCheckoutUser
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
			this.components = new System.ComponentModel.Container();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
			this.btn_xoacheckout = new System.Windows.Forms.Button();
			this.btn_checkout = new System.Windows.Forms.Button();
			this.txb_manhanvien = new System.Windows.Forms.TextBox();
			this.lb_giocheckout = new System.Windows.Forms.Label();
			this.lb_tennhanvien = new System.Windows.Forms.Label();
			this.lb_manhanvien = new System.Windows.Forms.Label();
			this.giocheckout = new System.Windows.Forms.Timer(this.components);
			this.dgv_checkout = new System.Windows.Forms.DataGridView();
			this.MaCheckOut = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NgayCheckOut = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Giocheck_out = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.txb_tennhanvien = new System.Windows.Forms.TextBox();
			this.btn_dongcheckout = new System.Windows.Forms.Button();
			((System.ComponentModel.ISupportInitialize)(this.dgv_checkout)).BeginInit();
			this.SuspendLayout();
			// 
			// btn_xoacheckout
			// 
			this.btn_xoacheckout.BackColor = System.Drawing.Color.DarkOrange;
			this.btn_xoacheckout.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_xoacheckout.Location = new System.Drawing.Point(61, 412);
			this.btn_xoacheckout.Name = "btn_xoacheckout";
			this.btn_xoacheckout.Size = new System.Drawing.Size(115, 40);
			this.btn_xoacheckout.TabIndex = 17;
			this.btn_xoacheckout.Text = "Xóa";
			this.btn_xoacheckout.UseVisualStyleBackColor = false;
			this.btn_xoacheckout.Click += new System.EventHandler(this.btn_deletecheckout_Click);
			this.btn_xoacheckout.MouseEnter += new System.EventHandler(this.btn_xoacheckout_MouseEnter);
			this.btn_xoacheckout.MouseLeave += new System.EventHandler(this.btn_xoacheckout_MouseLeave);
			// 
			// btn_checkout
			// 
			this.btn_checkout.BackColor = System.Drawing.Color.DarkOrange;
			this.btn_checkout.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_checkout.Location = new System.Drawing.Point(61, 339);
			this.btn_checkout.Name = "btn_checkout";
			this.btn_checkout.Size = new System.Drawing.Size(115, 40);
			this.btn_checkout.TabIndex = 16;
			this.btn_checkout.Text = "Check out";
			this.btn_checkout.UseVisualStyleBackColor = false;
			this.btn_checkout.Click += new System.EventHandler(this.btn_checkout_Click);
			this.btn_checkout.MouseEnter += new System.EventHandler(this.btn_checkout_MouseEnter);
			// 
			// txb_manhanvien
			// 
			this.txb_manhanvien.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txb_manhanvien.Location = new System.Drawing.Point(140, 13);
			this.txb_manhanvien.Name = "txb_manhanvien";
			this.txb_manhanvien.ReadOnly = true;
			this.txb_manhanvien.Size = new System.Drawing.Size(252, 27);
			this.txb_manhanvien.TabIndex = 14;
			// 
			// lb_giocheckout
			// 
			this.lb_giocheckout.AutoSize = true;
			this.lb_giocheckout.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_giocheckout.Location = new System.Drawing.Point(12, 211);
			this.lb_giocheckout.Name = "lb_giocheckout";
			this.lb_giocheckout.Size = new System.Drawing.Size(223, 45);
			this.lb_giocheckout.TabIndex = 13;
			this.lb_giocheckout.Text = "Giờ checkout";
			// 
			// lb_tennhanvien
			// 
			this.lb_tennhanvien.AutoSize = true;
			this.lb_tennhanvien.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_tennhanvien.Location = new System.Drawing.Point(588, 20);
			this.lb_tennhanvien.Name = "lb_tennhanvien";
			this.lb_tennhanvien.Size = new System.Drawing.Size(106, 20);
			this.lb_tennhanvien.TabIndex = 12;
			this.lb_tennhanvien.Text = "Tên nhân viên";
			// 
			// lb_manhanvien
			// 
			this.lb_manhanvien.AutoSize = true;
			this.lb_manhanvien.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_manhanvien.Location = new System.Drawing.Point(31, 20);
			this.lb_manhanvien.Name = "lb_manhanvien";
			this.lb_manhanvien.Size = new System.Drawing.Size(103, 20);
			this.lb_manhanvien.TabIndex = 11;
			this.lb_manhanvien.Text = "Mã nhân viên";
			// 
			// giocheckout
			// 
			this.giocheckout.Enabled = true;
			// 
			// dgv_checkout
			// 
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.Tan;
			this.dgv_checkout.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dgv_checkout.BackgroundColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgv_checkout.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dgv_checkout.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv_checkout.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaCheckOut,
            this.MaNV,
            this.TenNV,
            this.NgayCheckOut,
            this.Giocheck_out});
			this.dgv_checkout.Location = new System.Drawing.Point(245, 63);
			this.dgv_checkout.Name = "dgv_checkout";
			this.dgv_checkout.RowHeadersWidth = 51;
			this.dgv_checkout.RowTemplate.Height = 24;
			this.dgv_checkout.Size = new System.Drawing.Size(725, 426);
			this.dgv_checkout.TabIndex = 18;
			// 
			// MaCheckOut
			// 
			this.MaCheckOut.DataPropertyName = "MaCheckOut";
			this.MaCheckOut.HeaderText = "Mã checkout";
			this.MaCheckOut.MinimumWidth = 6;
			this.MaCheckOut.Name = "MaCheckOut";
			this.MaCheckOut.Width = 75;
			// 
			// MaNV
			// 
			this.MaNV.DataPropertyName = "MaNV";
			this.MaNV.HeaderText = "Mã nhân viên";
			this.MaNV.MinimumWidth = 6;
			this.MaNV.Name = "MaNV";
			this.MaNV.Width = 75;
			// 
			// TenNV
			// 
			this.TenNV.DataPropertyName = "TenNV";
			this.TenNV.HeaderText = "Tên nhân viên";
			this.TenNV.MinimumWidth = 6;
			this.TenNV.Name = "TenNV";
			this.TenNV.Width = 125;
			// 
			// NgayCheckOut
			// 
			this.NgayCheckOut.DataPropertyName = "NgayCheckOut";
			this.NgayCheckOut.HeaderText = "Ngày checkout";
			this.NgayCheckOut.MinimumWidth = 6;
			this.NgayCheckOut.Name = "NgayCheckOut";
			this.NgayCheckOut.Width = 125;
			// 
			// Giocheck_out
			// 
			this.Giocheck_out.DataPropertyName = "GioCheckOut";
			this.Giocheck_out.HeaderText = "Giờ checkout";
			this.Giocheck_out.MinimumWidth = 6;
			this.Giocheck_out.Name = "Giocheck_out";
			this.Giocheck_out.Width = 125;
			// 
			// txb_tennhanvien
			// 
			this.txb_tennhanvien.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txb_tennhanvien.Location = new System.Drawing.Point(718, 17);
			this.txb_tennhanvien.Name = "txb_tennhanvien";
			this.txb_tennhanvien.ReadOnly = true;
			this.txb_tennhanvien.Size = new System.Drawing.Size(252, 27);
			this.txb_tennhanvien.TabIndex = 20;
			// 
			// btn_dongcheckout
			// 
			this.btn_dongcheckout.BackColor = System.Drawing.Color.DarkOrange;
			this.btn_dongcheckout.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_dongcheckout.Location = new System.Drawing.Point(61, 449);
			this.btn_dongcheckout.Name = "btn_dongcheckout";
			this.btn_dongcheckout.Size = new System.Drawing.Size(115, 40);
			this.btn_dongcheckout.TabIndex = 19;
			this.btn_dongcheckout.Text = "Đóng";
			this.btn_dongcheckout.UseVisualStyleBackColor = false;
			this.btn_dongcheckout.Click += new System.EventHandler(this.btn_closecheckout_Click);
			this.btn_dongcheckout.MouseEnter += new System.EventHandler(this.btn_dongcheckout_MouseEnter);
			this.btn_dongcheckout.MouseLeave += new System.EventHandler(this.btn_dongcheckout_MouseLeave);
			// 
			// fCheckoutUser
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.BlanchedAlmond;
			this.ClientSize = new System.Drawing.Size(982, 503);
			this.Controls.Add(this.btn_xoacheckout);
			this.Controls.Add(this.btn_checkout);
			this.Controls.Add(this.txb_manhanvien);
			this.Controls.Add(this.lb_giocheckout);
			this.Controls.Add(this.lb_tennhanvien);
			this.Controls.Add(this.lb_manhanvien);
			this.Controls.Add(this.dgv_checkout);
			this.Controls.Add(this.txb_tennhanvien);
			this.Controls.Add(this.btn_dongcheckout);
			this.Name = "fCheckoutUser";
			this.Text = "fCheckoutUser";
			((System.ComponentModel.ISupportInitialize)(this.dgv_checkout)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Button btn_xoacheckout;
		private System.Windows.Forms.Button btn_checkout;
		private System.Windows.Forms.TextBox txb_manhanvien;
		private System.Windows.Forms.Label lb_giocheckout;
		private System.Windows.Forms.Label lb_tennhanvien;
		private System.Windows.Forms.Label lb_manhanvien;
		private System.Windows.Forms.Timer giocheckout;
		private System.Windows.Forms.DataGridView dgv_checkout;
		private System.Windows.Forms.DataGridViewTextBoxColumn MaCheckOut;
		private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
		private System.Windows.Forms.DataGridViewTextBoxColumn TenNV;
		private System.Windows.Forms.DataGridViewTextBoxColumn NgayCheckOut;
		private System.Windows.Forms.DataGridViewTextBoxColumn Giocheck_out;
		private System.Windows.Forms.TextBox txb_tennhanvien;
		private System.Windows.Forms.Button btn_dongcheckout;
	}
}