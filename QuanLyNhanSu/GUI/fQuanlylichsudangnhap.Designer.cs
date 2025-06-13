namespace QuanLyNhanSu.GUI
{
	partial class fQuanlylichsudangnhap
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
			this.dgv_lichsudangnhap = new System.Windows.Forms.DataGridView();
			this.btn_dong = new System.Windows.Forms.Button();
			this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.UserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.ThoiGianDangNhap = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.DiaChiIP = new System.Windows.Forms.DataGridViewTextBoxColumn();
			((System.ComponentModel.ISupportInitialize)(this.dgv_lichsudangnhap)).BeginInit();
			this.SuspendLayout();
			// 
			// dgv_lichsudangnhap
			// 
			dataGridViewCellStyle1.BackColor = System.Drawing.Color.Tan;
			this.dgv_lichsudangnhap.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
			this.dgv_lichsudangnhap.BackgroundColor = System.Drawing.Color.White;
			dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgv_lichsudangnhap.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
			this.dgv_lichsudangnhap.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv_lichsudangnhap.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.UserName,
            this.ThoiGianDangNhap,
            this.DiaChiIP});
			this.dgv_lichsudangnhap.Location = new System.Drawing.Point(12, 12);
			this.dgv_lichsudangnhap.Name = "dgv_lichsudangnhap";
			this.dgv_lichsudangnhap.RowHeadersWidth = 51;
			this.dgv_lichsudangnhap.RowTemplate.Height = 24;
			this.dgv_lichsudangnhap.Size = new System.Drawing.Size(958, 583);
			this.dgv_lichsudangnhap.TabIndex = 0;
			// 
			// btn_dong
			// 
			this.btn_dong.BackColor = System.Drawing.Color.DarkOrange;
			this.btn_dong.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_dong.Location = new System.Drawing.Point(855, 601);
			this.btn_dong.Name = "btn_dong";
			this.btn_dong.Size = new System.Drawing.Size(115, 40);
			this.btn_dong.TabIndex = 1;
			this.btn_dong.Text = "Đóng";
			this.btn_dong.UseVisualStyleBackColor = false;
			this.btn_dong.Click += new System.EventHandler(this.btn_dong_Click);
			this.btn_dong.MouseEnter += new System.EventHandler(this.btn_dong_MouseEnter);
			this.btn_dong.MouseLeave += new System.EventHandler(this.btn_dong_MouseLeave);
			// 
			// STT
			// 
			this.STT.DataPropertyName = "ID";
			this.STT.HeaderText = "STT";
			this.STT.MinimumWidth = 6;
			this.STT.Name = "STT";
			this.STT.Width = 125;
			// 
			// UserName
			// 
			this.UserName.DataPropertyName = "UserName";
			this.UserName.HeaderText = "Tài khoản";
			this.UserName.MinimumWidth = 6;
			this.UserName.Name = "UserName";
			this.UserName.Width = 150;
			// 
			// ThoiGianDangNhap
			// 
			this.ThoiGianDangNhap.DataPropertyName = "ThoiGianDangNhap";
			this.ThoiGianDangNhap.HeaderText = "Thời gian đăng nhập";
			this.ThoiGianDangNhap.MinimumWidth = 6;
			this.ThoiGianDangNhap.Name = "ThoiGianDangNhap";
			this.ThoiGianDangNhap.Width = 200;
			// 
			// DiaChiIP
			// 
			this.DiaChiIP.DataPropertyName = "DiaChiIP";
			this.DiaChiIP.HeaderText = "Địa chỉ IP";
			this.DiaChiIP.MinimumWidth = 6;
			this.DiaChiIP.Name = "DiaChiIP";
			this.DiaChiIP.Width = 150;
			// 
			// fQuanlylichsudangnhap
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.BlanchedAlmond;
			this.ClientSize = new System.Drawing.Size(982, 653);
			this.Controls.Add(this.btn_dong);
			this.Controls.Add(this.dgv_lichsudangnhap);
			this.Name = "fQuanlylichsudangnhap";
			this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
			this.Text = "Lịch sử đăng nhập";
			((System.ComponentModel.ISupportInitialize)(this.dgv_lichsudangnhap)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.DataGridView dgv_lichsudangnhap;
		private System.Windows.Forms.Button btn_dong;
		private System.Windows.Forms.DataGridViewTextBoxColumn STT;
		private System.Windows.Forms.DataGridViewTextBoxColumn UserName;
		private System.Windows.Forms.DataGridViewTextBoxColumn ThoiGianDangNhap;
		private System.Windows.Forms.DataGridViewTextBoxColumn DiaChiIP;
	}
}