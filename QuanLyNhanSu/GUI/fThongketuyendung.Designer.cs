namespace QuanLyNhanSu.GUI
{
	partial class fThongketuyendung
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
			this.cb_nam = new System.Windows.Forms.ComboBox();
			this.cb_thang = new System.Windows.Forms.ComboBox();
			this.Năm = new System.Windows.Forms.Label();
			this.lb_thang = new System.Windows.Forms.Label();
			this.btn_xuatbaocao = new System.Windows.Forms.Button();
			this.btn_dong = new System.Windows.Forms.Button();
			this.btn_thongkenhanvien = new System.Windows.Forms.Button();
			this.dgv_tuyendungtk = new System.Windows.Forms.DataGridView();
			this.panel_chart = new System.Windows.Forms.Panel();
			this.KetQua = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Nam = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Thang = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dgv_tuyendungtk)).BeginInit();
			this.SuspendLayout();
			// 
			// cb_nam
			// 
			this.cb_nam.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cb_nam.FormattingEnabled = true;
			this.cb_nam.Location = new System.Drawing.Point(100, 32);
			this.cb_nam.Name = "cb_nam";
			this.cb_nam.Size = new System.Drawing.Size(252, 28);
			this.cb_nam.TabIndex = 0;
			// 
			// cb_thang
			// 
			this.cb_thang.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cb_thang.FormattingEnabled = true;
			this.cb_thang.Location = new System.Drawing.Point(563, 32);
			this.cb_thang.Name = "cb_thang";
			this.cb_thang.Size = new System.Drawing.Size(252, 28);
			this.cb_thang.TabIndex = 1;
			// 
			// Năm
			// 
			this.Năm.AutoSize = true;
			this.Năm.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Năm.Location = new System.Drawing.Point(23, 32);
			this.Năm.Name = "Năm";
			this.Năm.Size = new System.Drawing.Size(43, 20);
			this.Năm.TabIndex = 2;
			this.Năm.Text = "Năm";
			// 
			// lb_thang
			// 
			this.lb_thang.AutoSize = true;
			this.lb_thang.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_thang.Location = new System.Drawing.Point(478, 35);
			this.lb_thang.Name = "lb_thang";
			this.lb_thang.Size = new System.Drawing.Size(53, 20);
			this.lb_thang.TabIndex = 3;
			this.lb_thang.Text = "Tháng";
			// 
			// btn_xuatbaocao
			// 
			this.btn_xuatbaocao.BackColor = System.Drawing.Color.DarkOrange;
			this.btn_xuatbaocao.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_xuatbaocao.Location = new System.Drawing.Point(1169, 22);
			this.btn_xuatbaocao.Name = "btn_xuatbaocao";
			this.btn_xuatbaocao.Size = new System.Drawing.Size(137, 40);
			this.btn_xuatbaocao.TabIndex = 21;
			this.btn_xuatbaocao.Text = "Xuất báo cáo";
			this.btn_xuatbaocao.UseVisualStyleBackColor = false;
			this.btn_xuatbaocao.Click += new System.EventHandler(this.btn_xuatbaocao_Click);
			// 
			// btn_dong
			// 
			this.btn_dong.BackColor = System.Drawing.Color.DarkOrange;
			this.btn_dong.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_dong.Location = new System.Drawing.Point(1355, 22);
			this.btn_dong.Name = "btn_dong";
			this.btn_dong.Size = new System.Drawing.Size(115, 40);
			this.btn_dong.TabIndex = 20;
			this.btn_dong.Text = "Đóng";
			this.btn_dong.UseVisualStyleBackColor = false;
			this.btn_dong.Click += new System.EventHandler(this.btn_dong_Click);
			// 
			// btn_thongkenhanvien
			// 
			this.btn_thongkenhanvien.BackColor = System.Drawing.Color.DarkOrange;
			this.btn_thongkenhanvien.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_thongkenhanvien.Location = new System.Drawing.Point(996, 22);
			this.btn_thongkenhanvien.Name = "btn_thongkenhanvien";
			this.btn_thongkenhanvien.Size = new System.Drawing.Size(115, 40);
			this.btn_thongkenhanvien.TabIndex = 19;
			this.btn_thongkenhanvien.Text = "Thống kê";
			this.btn_thongkenhanvien.UseVisualStyleBackColor = false;
			this.btn_thongkenhanvien.Click += new System.EventHandler(this.btn_thongkenhanvien_Click);
			// 
			// dgv_tuyendungtk
			// 
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.Tan;
			this.dgv_tuyendungtk.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dgv_tuyendungtk.BackgroundColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgv_tuyendungtk.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dgv_tuyendungtk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv_tuyendungtk.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.KetQua,
            this.SoLuong,
            this.Nam,
            this.Thang});
			this.dgv_tuyendungtk.Location = new System.Drawing.Point(13, 93);
			this.dgv_tuyendungtk.Name = "dgv_tuyendungtk";
			this.dgv_tuyendungtk.RowHeadersWidth = 51;
			this.dgv_tuyendungtk.RowTemplate.Height = 24;
			this.dgv_tuyendungtk.Size = new System.Drawing.Size(462, 673);
			this.dgv_tuyendungtk.TabIndex = 22;
			// 
			// panel_chart
			// 
			this.panel_chart.BackColor = System.Drawing.Color.SeaShell;
			this.panel_chart.Location = new System.Drawing.Point(481, 93);
			this.panel_chart.Name = "panel_chart";
			this.panel_chart.Size = new System.Drawing.Size(989, 673);
			this.panel_chart.TabIndex = 23;
			// 
			// KetQua
			// 
			this.KetQua.DataPropertyName = "KetQua";
			this.KetQua.HeaderText = "Kết quả";
			this.KetQua.MinimumWidth = 6;
			this.KetQua.Name = "KetQua";
			// 
			// SoLuong
			// 
			this.SoLuong.DataPropertyName = "SoLuong";
			this.SoLuong.HeaderText = "Số lượng";
			this.SoLuong.MinimumWidth = 6;
			this.SoLuong.Name = "SoLuong";
			this.SoLuong.Width = 50;
			// 
			// Nam
			// 
			this.Nam.DataPropertyName = "Nam";
			this.Nam.HeaderText = "Năm";
			this.Nam.MinimumWidth = 6;
			this.Nam.Name = "Nam";
			this.Nam.Width = 75;
			// 
			// Thang
			// 
			this.Thang.DataPropertyName = "Thang";
			this.Thang.HeaderText = "Tháng";
			this.Thang.MinimumWidth = 6;
			this.Thang.Name = "Thang";
			this.Thang.Width = 75;
			// 
			// fThongketuyendung
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.BlanchedAlmond;
			this.ClientSize = new System.Drawing.Size(1482, 778);
			this.Controls.Add(this.panel_chart);
			this.Controls.Add(this.dgv_tuyendungtk);
			this.Controls.Add(this.btn_xuatbaocao);
			this.Controls.Add(this.btn_dong);
			this.Controls.Add(this.btn_thongkenhanvien);
			this.Controls.Add(this.lb_thang);
			this.Controls.Add(this.Năm);
			this.Controls.Add(this.cb_thang);
			this.Controls.Add(this.cb_nam);
			this.Name = "fThongketuyendung";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.Text = "Thống kê tuyển dụng";
			((System.ComponentModel.ISupportInitialize)(this.dgv_tuyendungtk)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox cb_nam;
		private System.Windows.Forms.ComboBox cb_thang;
		private System.Windows.Forms.Label Năm;
		private System.Windows.Forms.Label lb_thang;
		private System.Windows.Forms.Button btn_xuatbaocao;
		private System.Windows.Forms.Button btn_dong;
		private System.Windows.Forms.Button btn_thongkenhanvien;
		private System.Windows.Forms.DataGridView dgv_tuyendungtk;
		private System.Windows.Forms.Panel panel_chart;
		private System.Windows.Forms.DataGridViewTextBoxColumn KetQua;
		private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
		private System.Windows.Forms.DataGridViewTextBoxColumn Nam;
		private System.Windows.Forms.DataGridViewTextBoxColumn Thang;
	}
}