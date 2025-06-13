namespace QuanLyNhanSu.GUI
{
	partial class fQuanlynguonungvien
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
			this.lb_nguonungvien = new System.Windows.Forms.Label();
			this.lb_soluonghoso = new System.Windows.Forms.Label();
			this.txb_soluonghs = new System.Windows.Forms.TextBox();
			this.dgv_nguonungvien = new System.Windows.Forms.DataGridView();
			this.TenNguon = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SoLuongHoSo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.btn_themnguonungvien = new System.Windows.Forms.Button();
			this.btn_xoanguonungvien = new System.Windows.Forms.Button();
			this.txb_timnguonungvien = new System.Windows.Forms.TextBox();
			this.btn_timnguonungvien = new System.Windows.Forms.Button();
			this.btn_dongnguonungvien = new System.Windows.Forms.Button();
			this.btn_load = new System.Windows.Forms.Button();
			this.pn_chart = new System.Windows.Forms.Panel();
			this.panel1 = new System.Windows.Forms.Panel();
			this.pn_nguonungvien = new System.Windows.Forms.Panel();
			this.txb_nguonungvien = new System.Windows.Forms.TextBox();
			this.lb_goiy = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dgv_nguonungvien)).BeginInit();
			this.pn_nguonungvien.SuspendLayout();
			this.SuspendLayout();
			// 
			// lb_nguonungvien
			// 
			this.lb_nguonungvien.AutoSize = true;
			this.lb_nguonungvien.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_nguonungvien.Location = new System.Drawing.Point(8, 20);
			this.lb_nguonungvien.Name = "lb_nguonungvien";
			this.lb_nguonungvien.Size = new System.Drawing.Size(122, 20);
			this.lb_nguonungvien.TabIndex = 0;
			this.lb_nguonungvien.Text = "Nguồn ứng viên";
			// 
			// lb_soluonghoso
			// 
			this.lb_soluonghoso.AutoSize = true;
			this.lb_soluonghoso.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_soluonghoso.Location = new System.Drawing.Point(10, 61);
			this.lb_soluonghoso.Name = "lb_soluonghoso";
			this.lb_soluonghoso.Size = new System.Drawing.Size(113, 20);
			this.lb_soluonghoso.TabIndex = 1;
			this.lb_soluonghoso.Text = "Số lượng hồ sơ";
			// 
			// txb_soluonghs
			// 
			this.txb_soluonghs.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txb_soluonghs.Location = new System.Drawing.Point(201, 58);
			this.txb_soluonghs.Name = "txb_soluonghs";
			this.txb_soluonghs.ReadOnly = true;
			this.txb_soluonghs.Size = new System.Drawing.Size(252, 27);
			this.txb_soluonghs.TabIndex = 3;
			// 
			// dgv_nguonungvien
			// 
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.Tan;
			this.dgv_nguonungvien.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
			this.dgv_nguonungvien.BackgroundColor = System.Drawing.Color.White;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgv_nguonungvien.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
			this.dgv_nguonungvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv_nguonungvien.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.TenNguon,
            this.SoLuongHoSo});
			this.dgv_nguonungvien.Location = new System.Drawing.Point(3, 137);
			this.dgv_nguonungvien.Name = "dgv_nguonungvien";
			this.dgv_nguonungvien.RowHeadersWidth = 51;
			this.dgv_nguonungvien.RowTemplate.Height = 24;
			this.dgv_nguonungvien.Size = new System.Drawing.Size(1476, 629);
			this.dgv_nguonungvien.TabIndex = 5;
			// 
			// TenNguon
			// 
			this.TenNguon.DataPropertyName = "TenNguon";
			this.TenNguon.HeaderText = "Nguồn ứng viên";
			this.TenNguon.MinimumWidth = 6;
			this.TenNguon.Name = "TenNguon";
			this.TenNguon.Width = 200;
			// 
			// SoLuongHoSo
			// 
			this.SoLuongHoSo.DataPropertyName = "SoLuongHoSo";
			this.SoLuongHoSo.HeaderText = "Số lượng hồ sơ";
			this.SoLuongHoSo.MinimumWidth = 6;
			this.SoLuongHoSo.Name = "SoLuongHoSo";
			this.SoLuongHoSo.Width = 200;
			// 
			// btn_themnguonungvien
			// 
			this.btn_themnguonungvien.BackColor = System.Drawing.Color.DarkOrange;
			this.btn_themnguonungvien.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_themnguonungvien.Location = new System.Drawing.Point(1352, 3);
			this.btn_themnguonungvien.Name = "btn_themnguonungvien";
			this.btn_themnguonungvien.Size = new System.Drawing.Size(115, 40);
			this.btn_themnguonungvien.TabIndex = 6;
			this.btn_themnguonungvien.Text = "Thêm";
			this.btn_themnguonungvien.UseVisualStyleBackColor = false;
			this.btn_themnguonungvien.Click += new System.EventHandler(this.btn_addnguonuv_Click);
			this.btn_themnguonungvien.MouseEnter += new System.EventHandler(this.btn_addnguonuv_MouseEnter);
			this.btn_themnguonungvien.MouseLeave += new System.EventHandler(this.btn_addnguonuv_MouseLeave);
			// 
			// btn_xoanguonungvien
			// 
			this.btn_xoanguonungvien.BackColor = System.Drawing.Color.DarkOrange;
			this.btn_xoanguonungvien.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_xoanguonungvien.Location = new System.Drawing.Point(1352, 43);
			this.btn_xoanguonungvien.Name = "btn_xoanguonungvien";
			this.btn_xoanguonungvien.Size = new System.Drawing.Size(115, 40);
			this.btn_xoanguonungvien.TabIndex = 7;
			this.btn_xoanguonungvien.Text = "Xóa";
			this.btn_xoanguonungvien.UseVisualStyleBackColor = false;
			this.btn_xoanguonungvien.Click += new System.EventHandler(this.btn_deletenguonuv_Click);
			this.btn_xoanguonungvien.MouseEnter += new System.EventHandler(this.btn_deletenguonuv_MouseEnter);
			this.btn_xoanguonungvien.MouseLeave += new System.EventHandler(this.btn_deletenguonuv_MouseLeave);
			// 
			// txb_timnguonungvien
			// 
			this.txb_timnguonungvien.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txb_timnguonungvien.Location = new System.Drawing.Point(9, 96);
			this.txb_timnguonungvien.Name = "txb_timnguonungvien";
			this.txb_timnguonungvien.Size = new System.Drawing.Size(1159, 27);
			this.txb_timnguonungvien.TabIndex = 8;
			// 
			// btn_timnguonungvien
			// 
			this.btn_timnguonungvien.BackColor = System.Drawing.Color.DarkOrange;
			this.btn_timnguonungvien.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_timnguonungvien.Location = new System.Drawing.Point(1202, 89);
			this.btn_timnguonungvien.Name = "btn_timnguonungvien";
			this.btn_timnguonungvien.Size = new System.Drawing.Size(115, 40);
			this.btn_timnguonungvien.TabIndex = 9;
			this.btn_timnguonungvien.Text = "Tìm kiếm";
			this.btn_timnguonungvien.UseVisualStyleBackColor = false;
			this.btn_timnguonungvien.Click += new System.EventHandler(this.btn_findnguonuv_Click);
			this.btn_timnguonungvien.MouseEnter += new System.EventHandler(this.btn_findnguonuv_MouseEnter);
			this.btn_timnguonungvien.MouseLeave += new System.EventHandler(this.btn_findnguonuv_MouseLeave);
			// 
			// btn_dongnguonungvien
			// 
			this.btn_dongnguonungvien.BackColor = System.Drawing.Color.DarkOrange;
			this.btn_dongnguonungvien.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_dongnguonungvien.Location = new System.Drawing.Point(1352, 83);
			this.btn_dongnguonungvien.Name = "btn_dongnguonungvien";
			this.btn_dongnguonungvien.Size = new System.Drawing.Size(115, 40);
			this.btn_dongnguonungvien.TabIndex = 10;
			this.btn_dongnguonungvien.Text = "Đóng";
			this.btn_dongnguonungvien.UseVisualStyleBackColor = false;
			this.btn_dongnguonungvien.Click += new System.EventHandler(this.btn_closenguonuv_Click);
			this.btn_dongnguonungvien.MouseEnter += new System.EventHandler(this.btn_closenguonuv_MouseEnter);
			this.btn_dongnguonungvien.MouseLeave += new System.EventHandler(this.btn_closenguonuv_MouseLeave);
			// 
			// btn_load
			// 
			this.btn_load.BackColor = System.Drawing.Color.DarkOrange;
			this.btn_load.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_load.Location = new System.Drawing.Point(657, 714);
			this.btn_load.Name = "btn_load";
			this.btn_load.Size = new System.Drawing.Size(115, 40);
			this.btn_load.TabIndex = 12;
			this.btn_load.Text = "Load";
			this.btn_load.UseVisualStyleBackColor = false;
			this.btn_load.Click += new System.EventHandler(this.btn_load_Click);
			this.btn_load.MouseEnter += new System.EventHandler(this.btn_load_MouseEnter);
			this.btn_load.MouseLeave += new System.EventHandler(this.btn_load_MouseLeave);
			// 
			// pn_chart
			// 
			this.pn_chart.BackColor = System.Drawing.Color.SeaShell;
			this.pn_chart.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
			this.pn_chart.Location = new System.Drawing.Point(793, 137);
			this.pn_chart.Name = "pn_chart";
			this.pn_chart.Size = new System.Drawing.Size(686, 629);
			this.pn_chart.TabIndex = 13;
			// 
			// panel1
			// 
			this.panel1.Location = new System.Drawing.Point(3, 2);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(0, 0);
			this.panel1.TabIndex = 14;
			// 
			// pn_nguonungvien
			// 
			this.pn_nguonungvien.Controls.Add(this.txb_nguonungvien);
			this.pn_nguonungvien.Controls.Add(this.lb_goiy);
			this.pn_nguonungvien.Controls.Add(this.btn_timnguonungvien);
			this.pn_nguonungvien.Controls.Add(this.btn_dongnguonungvien);
			this.pn_nguonungvien.Controls.Add(this.btn_themnguonungvien);
			this.pn_nguonungvien.Controls.Add(this.txb_timnguonungvien);
			this.pn_nguonungvien.Controls.Add(this.txb_soluonghs);
			this.pn_nguonungvien.Controls.Add(this.btn_xoanguonungvien);
			this.pn_nguonungvien.Location = new System.Drawing.Point(3, 2);
			this.pn_nguonungvien.Name = "pn_nguonungvien";
			this.pn_nguonungvien.Size = new System.Drawing.Size(1476, 179);
			this.pn_nguonungvien.TabIndex = 15;
			// 
			// txb_nguonungvien
			// 
			this.txb_nguonungvien.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txb_nguonungvien.Location = new System.Drawing.Point(201, 18);
			this.txb_nguonungvien.Name = "txb_nguonungvien";
			this.txb_nguonungvien.Size = new System.Drawing.Size(252, 27);
			this.txb_nguonungvien.TabIndex = 46;
			// 
			// lb_goiy
			// 
			this.lb_goiy.AutoSize = true;
			this.lb_goiy.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_goiy.Location = new System.Drawing.Point(978, 68);
			this.lb_goiy.Name = "lb_goiy";
			this.lb_goiy.Size = new System.Drawing.Size(158, 17);
			this.lb_goiy.TabIndex = 45;
			this.lb_goiy.Text = "(Tìm kiếm nguồn ứng viên)";
			// 
			// fQuanlynguonungvien
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.BlanchedAlmond;
			this.ClientSize = new System.Drawing.Size(1482, 778);
			this.Controls.Add(this.pn_chart);
			this.Controls.Add(this.panel1);
			this.Controls.Add(this.btn_load);
			this.Controls.Add(this.dgv_nguonungvien);
			this.Controls.Add(this.lb_soluonghoso);
			this.Controls.Add(this.lb_nguonungvien);
			this.Controls.Add(this.pn_nguonungvien);
			this.Name = "fQuanlynguonungvien";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Nguồn ứng viên";
			((System.ComponentModel.ISupportInitialize)(this.dgv_nguonungvien)).EndInit();
			this.pn_nguonungvien.ResumeLayout(false);
			this.pn_nguonungvien.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label lb_nguonungvien;
		private System.Windows.Forms.Label lb_soluonghoso;
		private System.Windows.Forms.TextBox txb_soluonghs;
		private System.Windows.Forms.DataGridView dgv_nguonungvien;
		private System.Windows.Forms.Button btn_themnguonungvien;
		private System.Windows.Forms.Button btn_xoanguonungvien;
		private System.Windows.Forms.TextBox txb_timnguonungvien;
		private System.Windows.Forms.Button btn_timnguonungvien;
		private System.Windows.Forms.Button btn_dongnguonungvien;
		private System.Windows.Forms.Button btn_load;
		private System.Windows.Forms.Panel pn_chart;
		private System.Windows.Forms.Panel panel1;
		private System.Windows.Forms.Panel pn_nguonungvien;
		private System.Windows.Forms.DataGridViewTextBoxColumn TenNguon;
		private System.Windows.Forms.DataGridViewTextBoxColumn SoLuongHoSo;
		private System.Windows.Forms.Label lb_goiy;
		private System.Windows.Forms.TextBox txb_nguonungvien;
	}
}