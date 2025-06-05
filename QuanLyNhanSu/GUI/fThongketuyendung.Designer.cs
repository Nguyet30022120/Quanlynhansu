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
			this.cb_nam = new System.Windows.Forms.ComboBox();
			this.cb_thang = new System.Windows.Forms.ComboBox();
			this.Năm = new System.Windows.Forms.Label();
			this.lb_thang = new System.Windows.Forms.Label();
			this.btn_xuatbaocao = new System.Windows.Forms.Button();
			this.btn_dong = new System.Windows.Forms.Button();
			this.btn_thongkenhanvien = new System.Windows.Forms.Button();
			this.dgv_tuyendungtk = new System.Windows.Forms.DataGridView();
			this.panel_chart = new System.Windows.Forms.Panel();
			((System.ComponentModel.ISupportInitialize)(this.dgv_tuyendungtk)).BeginInit();
			this.SuspendLayout();
			// 
			// cb_nam
			// 
			this.cb_nam.FormattingEnabled = true;
			this.cb_nam.Location = new System.Drawing.Point(146, 32);
			this.cb_nam.Name = "cb_nam";
			this.cb_nam.Size = new System.Drawing.Size(121, 24);
			this.cb_nam.TabIndex = 0;
			// 
			// cb_thang
			// 
			this.cb_thang.FormattingEnabled = true;
			this.cb_thang.Location = new System.Drawing.Point(373, 29);
			this.cb_thang.Name = "cb_thang";
			this.cb_thang.Size = new System.Drawing.Size(121, 24);
			this.cb_thang.TabIndex = 1;
			// 
			// Năm
			// 
			this.Năm.AutoSize = true;
			this.Năm.Location = new System.Drawing.Point(27, 32);
			this.Năm.Name = "Năm";
			this.Năm.Size = new System.Drawing.Size(36, 16);
			this.Năm.TabIndex = 2;
			this.Năm.Text = "Năm";
			// 
			// lb_thang
			// 
			this.lb_thang.AutoSize = true;
			this.lb_thang.Location = new System.Drawing.Point(299, 32);
			this.lb_thang.Name = "lb_thang";
			this.lb_thang.Size = new System.Drawing.Size(46, 16);
			this.lb_thang.TabIndex = 3;
			this.lb_thang.Text = "Tháng";
			// 
			// btn_xuatbaocao
			// 
			this.btn_xuatbaocao.BackColor = System.Drawing.Color.DarkOrange;
			this.btn_xuatbaocao.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_xuatbaocao.Location = new System.Drawing.Point(918, 32);
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
			this.btn_dong.Location = new System.Drawing.Point(1093, 32);
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
			this.btn_thongkenhanvien.Location = new System.Drawing.Point(768, 32);
			this.btn_thongkenhanvien.Name = "btn_thongkenhanvien";
			this.btn_thongkenhanvien.Size = new System.Drawing.Size(115, 40);
			this.btn_thongkenhanvien.TabIndex = 19;
			this.btn_thongkenhanvien.Text = "Thống kê";
			this.btn_thongkenhanvien.UseVisualStyleBackColor = false;
			this.btn_thongkenhanvien.Click += new System.EventHandler(this.btn_thongkenhanvien_Click);
			// 
			// dgv_tuyendungtk
			// 
			this.dgv_tuyendungtk.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv_tuyendungtk.Location = new System.Drawing.Point(13, 93);
			this.dgv_tuyendungtk.Name = "dgv_tuyendungtk";
			this.dgv_tuyendungtk.RowHeadersWidth = 51;
			this.dgv_tuyendungtk.RowTemplate.Height = 24;
			this.dgv_tuyendungtk.Size = new System.Drawing.Size(462, 557);
			this.dgv_tuyendungtk.TabIndex = 22;
			// 
			// panel_chart
			// 
			this.panel_chart.Location = new System.Drawing.Point(491, 93);
			this.panel_chart.Name = "panel_chart";
			this.panel_chart.Size = new System.Drawing.Size(516, 446);
			this.panel_chart.TabIndex = 23;
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
	}
}