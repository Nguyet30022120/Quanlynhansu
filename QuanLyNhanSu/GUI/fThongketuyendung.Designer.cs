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
			this.lb_nam = new System.Windows.Forms.Label();
			this.lb_thang = new System.Windows.Forms.Label();
			this.btn_xuatbaocao = new System.Windows.Forms.Button();
			this.btn_dong = new System.Windows.Forms.Button();
			this.btn_thongkenhanvien = new System.Windows.Forms.Button();
			this.dgv_tuyendungthongke = new System.Windows.Forms.DataGridView();
			this.KetQua = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Nam = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.Thang = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.pn_chart = new System.Windows.Forms.Panel();
			((System.ComponentModel.ISupportInitialize)(this.dgv_tuyendungthongke)).BeginInit();
			this.SuspendLayout();
			// 
			// cb_nam
			// 
			this.cb_nam.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cb_nam.FormattingEnabled = true;
			this.cb_nam.Location = new System.Drawing.Point(80, 35);
			this.cb_nam.Name = "cb_nam";
			this.cb_nam.Size = new System.Drawing.Size(100, 28);
			this.cb_nam.TabIndex = 0;
			// 
			// cb_thang
			// 
			this.cb_thang.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.cb_thang.FormattingEnabled = true;
			this.cb_thang.Location = new System.Drawing.Point(339, 35);
			this.cb_thang.Name = "cb_thang";
			this.cb_thang.Size = new System.Drawing.Size(100, 28);
			this.cb_thang.TabIndex = 1;
			// 
			// lb_nam
			// 
			this.lb_nam.AutoSize = true;
			this.lb_nam.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_nam.Location = new System.Drawing.Point(15, 35);
			this.lb_nam.Name = "lb_nam";
			this.lb_nam.Size = new System.Drawing.Size(43, 20);
			this.lb_nam.TabIndex = 2;
			this.lb_nam.Text = "Năm";
			// 
			// lb_thang
			// 
			this.lb_thang.AutoSize = true;
			this.lb_thang.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_thang.Location = new System.Drawing.Point(265, 35);
			this.lb_thang.Name = "lb_thang";
			this.lb_thang.Size = new System.Drawing.Size(53, 20);
			this.lb_thang.TabIndex = 3;
			this.lb_thang.Text = "Tháng";
			// 
			// btn_xuatbaocao
			// 
			this.btn_xuatbaocao.BackColor = System.Drawing.Color.DarkOrange;
			this.btn_xuatbaocao.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_xuatbaocao.Location = new System.Drawing.Point(1169, 28);
			this.btn_xuatbaocao.Name = "btn_xuatbaocao";
			this.btn_xuatbaocao.Size = new System.Drawing.Size(137, 40);
			this.btn_xuatbaocao.TabIndex = 21;
			this.btn_xuatbaocao.Text = "Xuất báo cáo";
			this.btn_xuatbaocao.UseVisualStyleBackColor = false;
			this.btn_xuatbaocao.Click += new System.EventHandler(this.btn_xuatbaocao_Click);
			this.btn_xuatbaocao.MouseEnter += new System.EventHandler(this.btn_xuatbaocao_MouseEnter);
			this.btn_xuatbaocao.MouseLeave += new System.EventHandler(this.btn_xuatbaocao_MouseLeave);
			// 
			// btn_dong
			// 
			this.btn_dong.BackColor = System.Drawing.Color.DarkOrange;
			this.btn_dong.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_dong.Location = new System.Drawing.Point(1355, 28);
			this.btn_dong.Name = "btn_dong";
			this.btn_dong.Size = new System.Drawing.Size(115, 40);
			this.btn_dong.TabIndex = 20;
			this.btn_dong.Text = "Đóng";
			this.btn_dong.UseVisualStyleBackColor = false;
			this.btn_dong.Click += new System.EventHandler(this.btn_dong_Click);
			this.btn_dong.MouseEnter += new System.EventHandler(this.btn_dong_MouseEnter);
			this.btn_dong.MouseLeave += new System.EventHandler(this.btn_dong_MouseLeave);
			// 
			// btn_thongkenhanvien
			// 
			this.btn_thongkenhanvien.BackColor = System.Drawing.Color.DarkOrange;
			this.btn_thongkenhanvien.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_thongkenhanvien.Location = new System.Drawing.Point(996, 28);
			this.btn_thongkenhanvien.Name = "btn_thongkenhanvien";
			this.btn_thongkenhanvien.Size = new System.Drawing.Size(115, 40);
			this.btn_thongkenhanvien.TabIndex = 19;
			this.btn_thongkenhanvien.Text = "Thống kê";
			this.btn_thongkenhanvien.UseVisualStyleBackColor = false;
			this.btn_thongkenhanvien.Click += new System.EventHandler(this.btn_thongkenhanvien_Click);
			this.btn_thongkenhanvien.MouseEnter += new System.EventHandler(this.btn_thongkenhanvien_MouseEnter);
			this.btn_thongkenhanvien.MouseLeave += new System.EventHandler(this.btn_thongkenhanvien_MouseLeave);
			// 
			// dgv_tuyendungthongke
			// 
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.Tan;
			this.dgv_tuyendungthongke.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dgv_tuyendungthongke.BackgroundColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgv_tuyendungthongke.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dgv_tuyendungthongke.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv_tuyendungthongke.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.KetQua,
            this.SoLuong,
            this.Nam,
            this.Thang});
			this.dgv_tuyendungthongke.Location = new System.Drawing.Point(13, 93);
			this.dgv_tuyendungthongke.Name = "dgv_tuyendungthongke";
			this.dgv_tuyendungthongke.RowHeadersWidth = 51;
			this.dgv_tuyendungthongke.RowTemplate.Height = 24;
			this.dgv_tuyendungthongke.Size = new System.Drawing.Size(544, 673);
			this.dgv_tuyendungthongke.TabIndex = 22;
			// 
			// KetQua
			// 
			this.KetQua.DataPropertyName = "KetQua";
			this.KetQua.HeaderText = "Kết quả";
			this.KetQua.MinimumWidth = 6;
			this.KetQua.Name = "KetQua";
			this.KetQua.Width = 150;
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
			// pn_chart
			// 
			this.pn_chart.BackColor = System.Drawing.Color.SeaShell;
			this.pn_chart.Location = new System.Drawing.Point(563, 93);
			this.pn_chart.Name = "pn_chart";
			this.pn_chart.Size = new System.Drawing.Size(907, 673);
			this.pn_chart.TabIndex = 23;
			// 
			// fThongketuyendung
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.BlanchedAlmond;
			this.ClientSize = new System.Drawing.Size(1482, 778);
			this.Controls.Add(this.pn_chart);
			this.Controls.Add(this.dgv_tuyendungthongke);
			this.Controls.Add(this.btn_xuatbaocao);
			this.Controls.Add(this.btn_dong);
			this.Controls.Add(this.btn_thongkenhanvien);
			this.Controls.Add(this.lb_thang);
			this.Controls.Add(this.lb_nam);
			this.Controls.Add(this.cb_thang);
			this.Controls.Add(this.cb_nam);
			this.Name = "fThongketuyendung";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.Text = "Thống kê tuyển dụng";
			((System.ComponentModel.ISupportInitialize)(this.dgv_tuyendungthongke)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.ComboBox cb_nam;
		private System.Windows.Forms.ComboBox cb_thang;
		private System.Windows.Forms.Label lb_nam;
		private System.Windows.Forms.Label lb_thang;
		private System.Windows.Forms.Button btn_xuatbaocao;
		private System.Windows.Forms.Button btn_dong;
		private System.Windows.Forms.Button btn_thongkenhanvien;
		private System.Windows.Forms.DataGridView dgv_tuyendungthongke;
		private System.Windows.Forms.Panel pn_chart;
		private System.Windows.Forms.DataGridViewTextBoxColumn KetQua;
		private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
		private System.Windows.Forms.DataGridViewTextBoxColumn Nam;
		private System.Windows.Forms.DataGridViewTextBoxColumn Thang;
	}
}