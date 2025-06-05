namespace QuanLyNhanSu
{
	partial class fQuanlyphongban
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
			this.pn_phongban = new System.Windows.Forms.Panel();
			this.txb_findpb = new System.Windows.Forms.TextBox();
			this.btn_exitpb = new System.Windows.Forms.Button();
			this.txb_tenpb = new System.Windows.Forms.TextBox();
			this.btn_findpb = new System.Windows.Forms.Button();
			this.btn_xoaphongban = new System.Windows.Forms.Button();
			this.btn_suaphongban = new System.Windows.Forms.Button();
			this.btn_themphongban = new System.Windows.Forms.Button();
			this.lb_diachipb = new System.Windows.Forms.Label();
			this.lb_tenpb = new System.Windows.Forms.Label();
			this.txb_diachipb = new System.Windows.Forms.TextBox();
			this.dgv_phongban = new System.Windows.Forms.DataGridView();
			this.MaPB = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TenPB = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DiaChi = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.pn_phongban.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgv_phongban)).BeginInit();
			this.SuspendLayout();
			// 
			// pn_phongban
			// 
			this.pn_phongban.BackColor = System.Drawing.Color.BlanchedAlmond;
			this.pn_phongban.Controls.Add(this.txb_findpb);
			this.pn_phongban.Controls.Add(this.btn_exitpb);
			this.pn_phongban.Controls.Add(this.txb_tenpb);
			this.pn_phongban.Controls.Add(this.btn_findpb);
			this.pn_phongban.Controls.Add(this.btn_xoaphongban);
			this.pn_phongban.Controls.Add(this.btn_suaphongban);
			this.pn_phongban.Controls.Add(this.btn_themphongban);
			this.pn_phongban.Controls.Add(this.lb_diachipb);
			this.pn_phongban.Controls.Add(this.lb_tenpb);
			this.pn_phongban.Controls.Add(this.txb_diachipb);
			this.pn_phongban.Location = new System.Drawing.Point(7, 3);
			this.pn_phongban.Name = "pn_phongban";
			this.pn_phongban.Size = new System.Drawing.Size(1471, 178);
			this.pn_phongban.TabIndex = 0;
			// 
			// txb_findpb
			// 
			this.txb_findpb.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txb_findpb.Location = new System.Drawing.Point(12, 20);
			this.txb_findpb.Name = "txb_findpb";
			this.txb_findpb.Size = new System.Drawing.Size(1209, 27);
			this.txb_findpb.TabIndex = 10;
			// 
			// btn_exitpb
			// 
			this.btn_exitpb.BackColor = System.Drawing.Color.DarkOrange;
			this.btn_exitpb.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_exitpb.Location = new System.Drawing.Point(1348, 120);
			this.btn_exitpb.Name = "btn_exitpb";
			this.btn_exitpb.Size = new System.Drawing.Size(115, 40);
			this.btn_exitpb.TabIndex = 9;
			this.btn_exitpb.Text = "Đóng";
			this.btn_exitpb.UseVisualStyleBackColor = false;
			this.btn_exitpb.Click += new System.EventHandler(this.btn_exitpb_Click);
			// 
			// txb_tenpb
			// 
			this.txb_tenpb.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txb_tenpb.Location = new System.Drawing.Point(131, 81);
			this.txb_tenpb.Name = "txb_tenpb";
			this.txb_tenpb.Size = new System.Drawing.Size(252, 27);
			this.txb_tenpb.TabIndex = 1;
			// 
			// btn_findpb
			// 
			this.btn_findpb.BackColor = System.Drawing.Color.DarkOrange;
			this.btn_findpb.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_findpb.Location = new System.Drawing.Point(1227, 9);
			this.btn_findpb.Name = "btn_findpb";
			this.btn_findpb.Size = new System.Drawing.Size(115, 40);
			this.btn_findpb.TabIndex = 2;
			this.btn_findpb.Text = "Tìm kiếm";
			this.btn_findpb.UseVisualStyleBackColor = false;
			this.btn_findpb.Click += new System.EventHandler(this.btn_findpb_Click);
			// 
			// btn_xoaphongban
			// 
			this.btn_xoaphongban.BackColor = System.Drawing.Color.DarkOrange;
			this.btn_xoaphongban.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_xoaphongban.Location = new System.Drawing.Point(1348, 81);
			this.btn_xoaphongban.Name = "btn_xoaphongban";
			this.btn_xoaphongban.Size = new System.Drawing.Size(115, 40);
			this.btn_xoaphongban.TabIndex = 8;
			this.btn_xoaphongban.Text = "Xóa";
			this.btn_xoaphongban.UseVisualStyleBackColor = false;
			this.btn_xoaphongban.Click += new System.EventHandler(this.btn_deletepb_Click);
			// 
			// btn_suaphongban
			// 
			this.btn_suaphongban.BackColor = System.Drawing.Color.DarkOrange;
			this.btn_suaphongban.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_suaphongban.Location = new System.Drawing.Point(1348, 46);
			this.btn_suaphongban.Name = "btn_suaphongban";
			this.btn_suaphongban.Size = new System.Drawing.Size(115, 40);
			this.btn_suaphongban.TabIndex = 7;
			this.btn_suaphongban.Text = "Sửa";
			this.btn_suaphongban.UseVisualStyleBackColor = false;
			this.btn_suaphongban.Click += new System.EventHandler(this.btn_editpb_Click);
			// 
			// btn_themphongban
			// 
			this.btn_themphongban.BackColor = System.Drawing.Color.DarkOrange;
			this.btn_themphongban.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_themphongban.Location = new System.Drawing.Point(1348, 9);
			this.btn_themphongban.Name = "btn_themphongban";
			this.btn_themphongban.Size = new System.Drawing.Size(115, 40);
			this.btn_themphongban.TabIndex = 6;
			this.btn_themphongban.Text = "Thêm ";
			this.btn_themphongban.UseVisualStyleBackColor = false;
			this.btn_themphongban.Click += new System.EventHandler(this.btn_addpb_Click_1);
			// 
			// lb_diachipb
			// 
			this.lb_diachipb.AutoSize = true;
			this.lb_diachipb.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_diachipb.Location = new System.Drawing.Point(8, 130);
			this.lb_diachipb.Name = "lb_diachipb";
			this.lb_diachipb.Size = new System.Drawing.Size(56, 20);
			this.lb_diachipb.TabIndex = 5;
			this.lb_diachipb.Text = "Địa chỉ";
			// 
			// lb_tenpb
			// 
			this.lb_tenpb.AutoSize = true;
			this.lb_tenpb.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_tenpb.Location = new System.Drawing.Point(8, 81);
			this.lb_tenpb.Name = "lb_tenpb";
			this.lb_tenpb.Size = new System.Drawing.Size(75, 20);
			this.lb_tenpb.TabIndex = 4;
			this.lb_tenpb.Text = "Cửa hàng";
			// 
			// txb_diachipb
			// 
			this.txb_diachipb.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txb_diachipb.Location = new System.Drawing.Point(131, 124);
			this.txb_diachipb.Name = "txb_diachipb";
			this.txb_diachipb.Size = new System.Drawing.Size(530, 27);
			this.txb_diachipb.TabIndex = 2;
			// 
			// dgv_phongban
			// 
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.Tan;
			this.dgv_phongban.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dgv_phongban.BackgroundColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgv_phongban.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dgv_phongban.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv_phongban.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaPB,
            this.TenPB,
            this.DiaChi});
			this.dgv_phongban.Location = new System.Drawing.Point(7, 179);
			this.dgv_phongban.Name = "dgv_phongban";
			this.dgv_phongban.RowHeadersWidth = 51;
			this.dgv_phongban.RowTemplate.Height = 24;
			this.dgv_phongban.Size = new System.Drawing.Size(1471, 594);
			this.dgv_phongban.TabIndex = 1;
			// 
			// MaPB
			// 
			this.MaPB.DataPropertyName = "MaPB";
			this.MaPB.HeaderText = "Mã cửa hàng";
			this.MaPB.MinimumWidth = 6;
			this.MaPB.Name = "MaPB";
			this.MaPB.Width = 125;
			// 
			// TenPB
			// 
			this.TenPB.DataPropertyName = "TenPB";
			this.TenPB.HeaderText = "Cửa hàng";
			this.TenPB.MinimumWidth = 6;
			this.TenPB.Name = "TenPB";
			this.TenPB.Width = 125;
			// 
			// DiaChi
			// 
			this.DiaChi.DataPropertyName = "DiaChi";
			this.DiaChi.HeaderText = "Địa chỉ";
			this.DiaChi.MinimumWidth = 6;
			this.DiaChi.Name = "DiaChi";
			this.DiaChi.Width = 400;
			// 
			// fQuanlyphongban
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.BlanchedAlmond;
			this.ClientSize = new System.Drawing.Size(1482, 778);
			this.Controls.Add(this.dgv_phongban);
			this.Controls.Add(this.pn_phongban);
			this.Name = "fQuanlyphongban";
			this.Text = "Quản lý cửa hàng";
			this.pn_phongban.ResumeLayout(false);
			this.pn_phongban.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgv_phongban)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Panel pn_phongban;
		private System.Windows.Forms.DataGridView dgv_phongban;
		private System.Windows.Forms.TextBox txb_diachipb;
		private System.Windows.Forms.TextBox txb_tenpb;
		private System.Windows.Forms.Label lb_diachipb;
		private System.Windows.Forms.Label lb_tenpb;
		private System.Windows.Forms.Button btn_exitpb;
		private System.Windows.Forms.Button btn_xoaphongban;
		private System.Windows.Forms.Button btn_suaphongban;
		private System.Windows.Forms.Button btn_themphongban;
		private System.Windows.Forms.Button btn_findpb;
		private System.Windows.Forms.TextBox txb_findpb;
		private System.Windows.Forms.DataGridViewTextBoxColumn MaPB;
		private System.Windows.Forms.DataGridViewTextBoxColumn TenPB;
		private System.Windows.Forms.DataGridViewTextBoxColumn DiaChi;
	}
}