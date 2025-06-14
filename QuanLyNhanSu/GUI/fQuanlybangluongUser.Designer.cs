namespace QuanLyNhanSu.GUI
{
	partial class fQuanlybangluongUser
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			this.lb_manhanvien = new System.Windows.Forms.Label();
			this.txb_manhanvien = new System.Windows.Forms.TextBox();
			this.txb_tennhanvien = new System.Windows.Forms.TextBox();
			this.btn_close = new System.Windows.Forms.Button();
			this.btn_xuatbaocao = new System.Windows.Forms.Button();
			this.btn_tinhluong = new System.Windows.Forms.Button();
			this.cb_nam = new System.Windows.Forms.ComboBox();
			this.lb_tennhanvien = new System.Windows.Forms.Label();
			this.cb_thang = new System.Windows.Forms.ComboBox();
			this.lb_nam = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.dgv_bangluong = new System.Windows.Forms.DataGridView();
			this.lb_thang = new System.Windows.Forms.Label();
			this.pn_bangluong = new System.Windows.Forms.Panel();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgv_bangluong)).BeginInit();
			this.pn_bangluong.SuspendLayout();
			this.SuspendLayout();
			// 
			// lb_manhanvien
			// 
			this.lb_manhanvien.AutoSize = true;
			this.lb_manhanvien.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_manhanvien.Location = new System.Drawing.Point(30, 20);
			this.lb_manhanvien.Name = "lb_manhanvien";
			this.lb_manhanvien.Size = new System.Drawing.Size(103, 20);
			this.lb_manhanvien.TabIndex = 15;
			this.lb_manhanvien.Text = "Mã nhân viên";
			// 
			// txb_manhanvien
			// 
			this.txb_manhanvien.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txb_manhanvien.Location = new System.Drawing.Point(169, 20);
			this.txb_manhanvien.Name = "txb_manhanvien";
			this.txb_manhanvien.ReadOnly = true;
			this.txb_manhanvien.Size = new System.Drawing.Size(252, 27);
			this.txb_manhanvien.TabIndex = 14;
			// 
			// txb_tennhanvien
			// 
			this.txb_tennhanvien.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txb_tennhanvien.Location = new System.Drawing.Point(169, 60);
			this.txb_tennhanvien.Name = "txb_tennhanvien";
			this.txb_tennhanvien.ReadOnly = true;
			this.txb_tennhanvien.Size = new System.Drawing.Size(252, 27);
			this.txb_tennhanvien.TabIndex = 13;
			// 
			// btn_close
			// 
			this.btn_close.BackColor = System.Drawing.Color.DarkOrange;
			this.btn_close.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_close.Location = new System.Drawing.Point(1353, 36);
			this.btn_close.Name = "btn_close";
			this.btn_close.Size = new System.Drawing.Size(100, 35);
			this.btn_close.TabIndex = 10;
			this.btn_close.Text = "Đóng";
			this.btn_close.UseVisualStyleBackColor = false;
			this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
			this.btn_close.MouseEnter += new System.EventHandler(this.btn_close_MouseEnter);
			this.btn_close.MouseLeave += new System.EventHandler(this.btn_close_MouseLeave);
			// 
			// btn_xuatbaocao
			// 
			this.btn_xuatbaocao.BackColor = System.Drawing.Color.DarkOrange;
			this.btn_xuatbaocao.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_xuatbaocao.Location = new System.Drawing.Point(1178, 36);
			this.btn_xuatbaocao.Name = "btn_xuatbaocao";
			this.btn_xuatbaocao.Size = new System.Drawing.Size(120, 35);
			this.btn_xuatbaocao.TabIndex = 8;
			this.btn_xuatbaocao.Text = "Xuất báo cáo";
			this.btn_xuatbaocao.UseVisualStyleBackColor = false;
			this.btn_xuatbaocao.Click += new System.EventHandler(this.btn_xuatbaocao_Click);
			this.btn_xuatbaocao.MouseEnter += new System.EventHandler(this.btn_xuatbaocao_MouseEnter);
			this.btn_xuatbaocao.MouseLeave += new System.EventHandler(this.btn_xuatbaocao_MouseLeave);
			// 
			// btn_tinhluong
			// 
			this.btn_tinhluong.BackColor = System.Drawing.Color.DarkOrange;
			this.btn_tinhluong.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_tinhluong.Location = new System.Drawing.Point(1004, 36);
			this.btn_tinhluong.Name = "btn_tinhluong";
			this.btn_tinhluong.Size = new System.Drawing.Size(120, 35);
			this.btn_tinhluong.TabIndex = 7;
			this.btn_tinhluong.Text = "Tính lương";
			this.btn_tinhluong.UseVisualStyleBackColor = false;
			this.btn_tinhluong.Click += new System.EventHandler(this.btn_tinhluong_Click);
			this.btn_tinhluong.MouseEnter += new System.EventHandler(this.btn_tinhluong_MouseEnter);
			this.btn_tinhluong.MouseLeave += new System.EventHandler(this.btn_tinhluong_MouseLeave);
			// 
			// cb_nam
			// 
			this.cb_nam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cb_nam.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cb_nam.FormattingEnabled = true;
			this.cb_nam.Location = new System.Drawing.Point(609, 60);
			this.cb_nam.Name = "cb_nam";
			this.cb_nam.Size = new System.Drawing.Size(100, 28);
			this.cb_nam.TabIndex = 5;
			// 
			// lb_tennhanvien
			// 
			this.lb_tennhanvien.AutoSize = true;
			this.lb_tennhanvien.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_tennhanvien.Location = new System.Drawing.Point(30, 60);
			this.lb_tennhanvien.Name = "lb_tennhanvien";
			this.lb_tennhanvien.Size = new System.Drawing.Size(106, 20);
			this.lb_tennhanvien.TabIndex = 3;
			this.lb_tennhanvien.Text = "Tên nhân viên";
			// 
			// cb_thang
			// 
			this.cb_thang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cb_thang.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cb_thang.FormattingEnabled = true;
			this.cb_thang.Location = new System.Drawing.Point(609, 20);
			this.cb_thang.Name = "cb_thang";
			this.cb_thang.Size = new System.Drawing.Size(100, 28);
			this.cb_thang.TabIndex = 4;
			// 
			// lb_nam
			// 
			this.lb_nam.AutoSize = true;
			this.lb_nam.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_nam.Location = new System.Drawing.Point(514, 60);
			this.lb_nam.Name = "lb_nam";
			this.lb_nam.Size = new System.Drawing.Size(43, 20);
			this.lb_nam.TabIndex = 2;
			this.lb_nam.Text = "Năm";
			// 
			// panel2
			// 
			this.panel2.Controls.Add(this.dgv_bangluong);
			this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
			this.panel2.Location = new System.Drawing.Point(0, 115);
			this.panel2.Name = "panel2";
			this.panel2.Size = new System.Drawing.Size(1482, 663);
			this.panel2.TabIndex = 4;
			// 
			// dgv_bangluong
			// 
			this.dgv_bangluong.AllowUserToAddRows = false;
			this.dgv_bangluong.AllowUserToDeleteRows = false;
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.Tan;
			this.dgv_bangluong.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dgv_bangluong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
			this.dgv_bangluong.BackgroundColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgv_bangluong.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dgv_bangluong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
			dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
			dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
			this.dgv_bangluong.DefaultCellStyle = dataGridViewCellStyle3;
			this.dgv_bangluong.Dock = System.Windows.Forms.DockStyle.Fill;
			this.dgv_bangluong.Location = new System.Drawing.Point(0, 0);
			this.dgv_bangluong.Name = "dgv_bangluong";
			this.dgv_bangluong.ReadOnly = true;
			this.dgv_bangluong.RowHeadersWidth = 51;
			this.dgv_bangluong.RowTemplate.Height = 24;
			this.dgv_bangluong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
			this.dgv_bangluong.Size = new System.Drawing.Size(1482, 663);
			this.dgv_bangluong.TabIndex = 0;
			// 
			// lb_thang
			// 
			this.lb_thang.AutoSize = true;
			this.lb_thang.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_thang.Location = new System.Drawing.Point(514, 20);
			this.lb_thang.Name = "lb_thang";
			this.lb_thang.Size = new System.Drawing.Size(53, 20);
			this.lb_thang.TabIndex = 1;
			this.lb_thang.Text = "Tháng";
			// 
			// pn_bangluong
			// 
			this.pn_bangluong.BackColor = System.Drawing.Color.BlanchedAlmond;
			this.pn_bangluong.Controls.Add(this.lb_manhanvien);
			this.pn_bangluong.Controls.Add(this.txb_manhanvien);
			this.pn_bangluong.Controls.Add(this.txb_tennhanvien);
			this.pn_bangluong.Controls.Add(this.btn_close);
			this.pn_bangluong.Controls.Add(this.btn_xuatbaocao);
			this.pn_bangluong.Controls.Add(this.btn_tinhluong);
			this.pn_bangluong.Controls.Add(this.cb_nam);
			this.pn_bangluong.Controls.Add(this.cb_thang);
			this.pn_bangluong.Controls.Add(this.lb_tennhanvien);
			this.pn_bangluong.Controls.Add(this.lb_nam);
			this.pn_bangluong.Controls.Add(this.lb_thang);
			this.pn_bangluong.Dock = System.Windows.Forms.DockStyle.Top;
			this.pn_bangluong.Location = new System.Drawing.Point(0, 0);
			this.pn_bangluong.Name = "pn_bangluong";
			this.pn_bangluong.Size = new System.Drawing.Size(1482, 115);
			this.pn_bangluong.TabIndex = 3;
			// 
			// fQuanlybangluongUser
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.BlanchedAlmond;
			this.ClientSize = new System.Drawing.Size(1482, 778);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.pn_bangluong);
			this.Name = "fQuanlybangluongUser";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Bảng lương";
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgv_bangluong)).EndInit();
			this.pn_bangluong.ResumeLayout(false);
			this.pn_bangluong.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label lb_manhanvien;
		private System.Windows.Forms.TextBox txb_manhanvien;
		private System.Windows.Forms.TextBox txb_tennhanvien;
		private System.Windows.Forms.Button btn_close;
		private System.Windows.Forms.Button btn_xuatbaocao;
		private System.Windows.Forms.Button btn_tinhluong;
		private System.Windows.Forms.ComboBox cb_nam;
		private System.Windows.Forms.Label lb_tennhanvien;
		private System.Windows.Forms.ComboBox cb_thang;
		private System.Windows.Forms.Label lb_nam;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.DataGridView dgv_bangluong;
		private System.Windows.Forms.Label lb_thang;
		private System.Windows.Forms.Panel pn_bangluong;
	}
}