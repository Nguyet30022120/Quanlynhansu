namespace QuanLyNhanSu.GUI
{
	partial class fQuanlyluongcoban
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
			this.dgv_luongcoban = new System.Windows.Forms.DataGridView();
			this.lb_luongcoban = new System.Windows.Forms.Label();
			this.lb_tennhanvien = new System.Windows.Forms.Label();
			this.txb_tennhanvien = new System.Windows.Forms.TextBox();
			this.txb_luongcoban = new System.Windows.Forms.TextBox();
			this.btn_dong = new System.Windows.Forms.Button();
			this.txb_timnhanvien = new System.Windows.Forms.TextBox();
			this.btn_tim = new System.Windows.Forms.Button();
			this.btn_sualuongcoban = new System.Windows.Forms.Button();
			this.pn_khoahoc = new System.Windows.Forms.Panel();
			this.lb_goiy = new System.Windows.Forms.Label();
			this.btn_sua = new System.Windows.Forms.Button();
			this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MaLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.LuongCoSo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dgv_luongcoban)).BeginInit();
			this.pn_khoahoc.SuspendLayout();
			this.SuspendLayout();
			// 
			// dgv_luongcoban
			// 
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.Tan;
			this.dgv_luongcoban.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
			this.dgv_luongcoban.BackgroundColor = System.Drawing.Color.White;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgv_luongcoban.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
			this.dgv_luongcoban.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv_luongcoban.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaNV,
            this.TenNV,
            this.MaLuong,
            this.LuongCoSo});
			this.dgv_luongcoban.Location = new System.Drawing.Point(7, 173);
			this.dgv_luongcoban.Name = "dgv_luongcoban";
			this.dgv_luongcoban.RowHeadersWidth = 51;
			this.dgv_luongcoban.RowTemplate.Height = 24;
			this.dgv_luongcoban.Size = new System.Drawing.Size(1469, 613);
			this.dgv_luongcoban.TabIndex = 15;
			// 
			// lb_luongcoban
			// 
			this.lb_luongcoban.AutoSize = true;
			this.lb_luongcoban.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_luongcoban.Location = new System.Drawing.Point(9, 69);
			this.lb_luongcoban.Name = "lb_luongcoban";
			this.lb_luongcoban.Size = new System.Drawing.Size(161, 20);
			this.lb_luongcoban.TabIndex = 2;
			this.lb_luongcoban.Text = "Lương cơ bản mỗi giờ";
			// 
			// lb_tennhanvien
			// 
			this.lb_tennhanvien.AutoSize = true;
			this.lb_tennhanvien.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_tennhanvien.Location = new System.Drawing.Point(9, 22);
			this.lb_tennhanvien.Name = "lb_tennhanvien";
			this.lb_tennhanvien.Size = new System.Drawing.Size(106, 20);
			this.lb_tennhanvien.TabIndex = 1;
			this.lb_tennhanvien.Text = "Tên nhân viên";
			// 
			// txb_tennhanvien
			// 
			this.txb_tennhanvien.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txb_tennhanvien.Location = new System.Drawing.Point(221, 22);
			this.txb_tennhanvien.Name = "txb_tennhanvien";
			this.txb_tennhanvien.Size = new System.Drawing.Size(315, 27);
			this.txb_tennhanvien.TabIndex = 14;
			// 
			// txb_luongcoban
			// 
			this.txb_luongcoban.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txb_luongcoban.Location = new System.Drawing.Point(221, 66);
			this.txb_luongcoban.Name = "txb_luongcoban";
			this.txb_luongcoban.Size = new System.Drawing.Size(315, 27);
			this.txb_luongcoban.TabIndex = 5;
			// 
			// btn_dong
			// 
			this.btn_dong.BackColor = System.Drawing.Color.DarkOrange;
			this.btn_dong.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_dong.Location = new System.Drawing.Point(1339, 25);
			this.btn_dong.Name = "btn_dong";
			this.btn_dong.Size = new System.Drawing.Size(115, 40);
			this.btn_dong.TabIndex = 10;
			this.btn_dong.Text = "Đóng";
			this.btn_dong.UseVisualStyleBackColor = false;
			this.btn_dong.Click += new System.EventHandler(this.btn_dong_Click);
			// 
			// txb_timnhanvien
			// 
			this.txb_timnhanvien.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txb_timnhanvien.Location = new System.Drawing.Point(8, 122);
			this.txb_timnhanvien.Name = "txb_timnhanvien";
			this.txb_timnhanvien.Size = new System.Drawing.Size(1310, 27);
			this.txb_timnhanvien.TabIndex = 11;
			// 
			// btn_tim
			// 
			this.btn_tim.BackColor = System.Drawing.Color.DarkOrange;
			this.btn_tim.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_tim.Location = new System.Drawing.Point(1339, 115);
			this.btn_tim.Name = "btn_tim";
			this.btn_tim.Size = new System.Drawing.Size(115, 40);
			this.btn_tim.TabIndex = 12;
			this.btn_tim.Text = "Tìm kiếm";
			this.btn_tim.UseVisualStyleBackColor = false;
			this.btn_tim.Click += new System.EventHandler(this.btn_tim_Click);
			// 
			// btn_sualuongcoban
			// 
			this.btn_sualuongcoban.BackColor = System.Drawing.Color.DarkOrange;
			this.btn_sualuongcoban.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_sualuongcoban.Location = new System.Drawing.Point(2110, 55);
			this.btn_sualuongcoban.Name = "btn_sualuongcoban";
			this.btn_sualuongcoban.Size = new System.Drawing.Size(115, 40);
			this.btn_sualuongcoban.TabIndex = 8;
			this.btn_sualuongcoban.Text = "Sửa";
			this.btn_sualuongcoban.UseVisualStyleBackColor = false;
			// 
			// pn_khoahoc
			// 
			this.pn_khoahoc.Controls.Add(this.btn_sua);
			this.pn_khoahoc.Controls.Add(this.lb_goiy);
			this.pn_khoahoc.Controls.Add(this.txb_tennhanvien);
			this.pn_khoahoc.Controls.Add(this.btn_dong);
			this.pn_khoahoc.Controls.Add(this.txb_timnhanvien);
			this.pn_khoahoc.Controls.Add(this.btn_tim);
			this.pn_khoahoc.Controls.Add(this.btn_sualuongcoban);
			this.pn_khoahoc.Controls.Add(this.lb_luongcoban);
			this.pn_khoahoc.Controls.Add(this.txb_luongcoban);
			this.pn_khoahoc.Controls.Add(this.lb_tennhanvien);
			this.pn_khoahoc.Location = new System.Drawing.Point(4, 7);
			this.pn_khoahoc.Name = "pn_khoahoc";
			this.pn_khoahoc.Size = new System.Drawing.Size(1466, 160);
			this.pn_khoahoc.TabIndex = 16;
			// 
			// lb_goiy
			// 
			this.lb_goiy.AutoSize = true;
			this.lb_goiy.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_goiy.Location = new System.Drawing.Point(1076, 92);
			this.lb_goiy.Name = "lb_goiy";
			this.lb_goiy.Size = new System.Drawing.Size(229, 17);
			this.lb_goiy.TabIndex = 46;
			this.lb_goiy.Text = "(Tìm kiếm tên nhân viên, mã nhân viên)";
			// 
			// btn_sua
			// 
			this.btn_sua.BackColor = System.Drawing.Color.DarkOrange;
			this.btn_sua.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_sua.Location = new System.Drawing.Point(1339, 69);
			this.btn_sua.Name = "btn_sua";
			this.btn_sua.Size = new System.Drawing.Size(115, 40);
			this.btn_sua.TabIndex = 47;
			this.btn_sua.Text = "Sửa";
			this.btn_sua.UseVisualStyleBackColor = false;
			this.btn_sua.Click += new System.EventHandler(this.btn_sua_Click);
			// 
			// MaNV
			// 
			this.MaNV.DataPropertyName = "MaNV";
			this.MaNV.HeaderText = "Mã nhân viên";
			this.MaNV.MinimumWidth = 6;
			this.MaNV.Name = "MaNV";
			this.MaNV.Width = 125;
			// 
			// TenNV
			// 
			this.TenNV.DataPropertyName = "TenNV";
			this.TenNV.HeaderText = "Tên nhân viên";
			this.TenNV.MinimumWidth = 6;
			this.TenNV.Name = "TenNV";
			this.TenNV.Width = 200;
			// 
			// MaLuong
			// 
			this.MaLuong.DataPropertyName = "MaLuong";
			this.MaLuong.HeaderText = "Mã lương";
			this.MaLuong.MinimumWidth = 6;
			this.MaLuong.Name = "MaLuong";
			this.MaLuong.Width = 125;
			// 
			// LuongCoSo
			// 
			this.LuongCoSo.DataPropertyName = "LuongCoSo";
			this.LuongCoSo.HeaderText = "Lương cơ bản mỗi giờ";
			this.LuongCoSo.MinimumWidth = 6;
			this.LuongCoSo.Name = "LuongCoSo";
			this.LuongCoSo.Width = 200;
			// 
			// fQuanlyluongcoban
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.BlanchedAlmond;
			this.ClientSize = new System.Drawing.Size(1482, 778);
			this.Controls.Add(this.dgv_luongcoban);
			this.Controls.Add(this.pn_khoahoc);
			this.Name = "fQuanlyluongcoban";
			this.Text = "Lương cơ bản";
			((System.ComponentModel.ISupportInitialize)(this.dgv_luongcoban)).EndInit();
			this.pn_khoahoc.ResumeLayout(false);
			this.pn_khoahoc.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dgv_luongcoban;
		private System.Windows.Forms.Label lb_luongcoban;
		private System.Windows.Forms.Label lb_tennhanvien;
		private System.Windows.Forms.TextBox txb_tennhanvien;
		private System.Windows.Forms.TextBox txb_luongcoban;
		private System.Windows.Forms.Button btn_dong;
		private System.Windows.Forms.TextBox txb_timnhanvien;
		private System.Windows.Forms.Button btn_tim;
		private System.Windows.Forms.Button btn_sualuongcoban;
		private System.Windows.Forms.Panel pn_khoahoc;
		private System.Windows.Forms.Label lb_goiy;
		private System.Windows.Forms.Button btn_sua;
		private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
		private System.Windows.Forms.DataGridViewTextBoxColumn TenNV;
		private System.Windows.Forms.DataGridViewTextBoxColumn MaLuong;
		private System.Windows.Forms.DataGridViewTextBoxColumn LuongCoSo;
	}
}