namespace QuanLyNhanSu.GUI
{
	partial class fBangluongUser
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
			this.label1 = new System.Windows.Forms.Label();
			this.txb_manhanvien = new System.Windows.Forms.TextBox();
			this.txb_tennhanvien = new System.Windows.Forms.TextBox();
			this.btn_close = new System.Windows.Forms.Button();
			this.btn_xuatbaocao = new System.Windows.Forms.Button();
			this.btn_tinhluong = new System.Windows.Forms.Button();
			this.cb_nam = new System.Windows.Forms.ComboBox();
			this.label4 = new System.Windows.Forms.Label();
			this.cb_thang = new System.Windows.Forms.ComboBox();
			this.label3 = new System.Windows.Forms.Label();
			this.panel2 = new System.Windows.Forms.Panel();
			this.dgv_bangluong = new System.Windows.Forms.DataGridView();
			this.label2 = new System.Windows.Forms.Label();
			this.panel1 = new System.Windows.Forms.Panel();
			this.panel2.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.dgv_bangluong)).BeginInit();
			this.panel1.SuspendLayout();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(290, 9);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(117, 23);
			this.label1.TabIndex = 15;
			this.label1.Text = "Mã nhân viên";
			// 
			// txb_manhanvien
			// 
			this.txb_manhanvien.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txb_manhanvien.Location = new System.Drawing.Point(448, 5);
			this.txb_manhanvien.Name = "txb_manhanvien";
			this.txb_manhanvien.ReadOnly = true;
			this.txb_manhanvien.Size = new System.Drawing.Size(252, 27);
			this.txb_manhanvien.TabIndex = 14;
			// 
			// txb_tennhanvien
			// 
			this.txb_tennhanvien.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txb_tennhanvien.Location = new System.Drawing.Point(448, 56);
			this.txb_tennhanvien.Name = "txb_tennhanvien";
			this.txb_tennhanvien.ReadOnly = true;
			this.txb_tennhanvien.Size = new System.Drawing.Size(252, 27);
			this.txb_tennhanvien.TabIndex = 13;
			// 
			// btn_close
			// 
			this.btn_close.BackColor = System.Drawing.Color.DarkOrange;
			this.btn_close.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_close.Location = new System.Drawing.Point(1353, 20);
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
			this.btn_xuatbaocao.Location = new System.Drawing.Point(1178, 20);
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
			this.btn_tinhluong.Location = new System.Drawing.Point(1004, 20);
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
			this.cb_nam.Location = new System.Drawing.Point(95, 56);
			this.cb_nam.Name = "cb_nam";
			this.cb_nam.Size = new System.Drawing.Size(100, 28);
			this.cb_nam.TabIndex = 5;
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label4.Location = new System.Drawing.Point(290, 56);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(119, 23);
			this.label4.TabIndex = 3;
			this.label4.Text = "Tên nhân viên";
			// 
			// cb_thang
			// 
			this.cb_thang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.cb_thang.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cb_thang.FormattingEnabled = true;
			this.cb_thang.Location = new System.Drawing.Point(95, 8);
			this.cb_thang.Name = "cb_thang";
			this.cb_thang.Size = new System.Drawing.Size(100, 28);
			this.cb_thang.TabIndex = 4;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(12, 61);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(48, 23);
			this.label3.TabIndex = 2;
			this.label3.Text = "Năm";
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
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(12, 9);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(60, 23);
			this.label2.TabIndex = 1;
			this.label2.Text = "Tháng";
			// 
			// panel1
			// 
			this.panel1.BackColor = System.Drawing.Color.BlanchedAlmond;
			this.panel1.Controls.Add(this.label1);
			this.panel1.Controls.Add(this.txb_manhanvien);
			this.panel1.Controls.Add(this.txb_tennhanvien);
			this.panel1.Controls.Add(this.btn_close);
			this.panel1.Controls.Add(this.btn_xuatbaocao);
			this.panel1.Controls.Add(this.btn_tinhluong);
			this.panel1.Controls.Add(this.cb_nam);
			this.panel1.Controls.Add(this.cb_thang);
			this.panel1.Controls.Add(this.label4);
			this.panel1.Controls.Add(this.label3);
			this.panel1.Controls.Add(this.label2);
			this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
			this.panel1.Location = new System.Drawing.Point(0, 0);
			this.panel1.Name = "panel1";
			this.panel1.Size = new System.Drawing.Size(1482, 115);
			this.panel1.TabIndex = 3;
			// 
			// fBangluongUser
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.BlanchedAlmond;
			this.ClientSize = new System.Drawing.Size(1482, 778);
			this.Controls.Add(this.panel2);
			this.Controls.Add(this.panel1);
			this.Name = "fBangluongUser";
			this.Text = "fBangluongUser";
			this.panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.dgv_bangluong)).EndInit();
			this.panel1.ResumeLayout(false);
			this.panel1.PerformLayout();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.TextBox txb_manhanvien;
		private System.Windows.Forms.TextBox txb_tennhanvien;
		private System.Windows.Forms.Button btn_close;
		private System.Windows.Forms.Button btn_xuatbaocao;
		private System.Windows.Forms.Button btn_tinhluong;
		private System.Windows.Forms.ComboBox cb_nam;
		private System.Windows.Forms.Label label4;
		private System.Windows.Forms.ComboBox cb_thang;
		private System.Windows.Forms.Label label3;
		private System.Windows.Forms.Panel panel2;
		private System.Windows.Forms.DataGridView dgv_bangluong;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Panel panel1;
	}
}