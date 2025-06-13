using Bunifu.UI.WinForms.Renderers.Loader;

namespace QuanLyNhanSu.GUI
{
	partial class fCheckinUser
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
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
			System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
			this.txb_tennhanvien = new System.Windows.Forms.TextBox();
			this.btn_dongcheckin = new System.Windows.Forms.Button();
			this.btn_xoacheckin = new System.Windows.Forms.Button();
			this.GioCheckIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NgayCheckIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MaCheckIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.sqlDataAdapter1 = new Microsoft.Data.SqlClient.SqlDataAdapter();
			this.btn_checkin = new System.Windows.Forms.Button();
			this.timer1 = new System.Windows.Forms.Timer(this.components);
			this.dgv_checkin = new System.Windows.Forms.DataGridView();
			this.lb_giocheckin = new System.Windows.Forms.Label();
			this.lb_tennhanvien = new System.Windows.Forms.Label();
			this.lb_manhanvien = new System.Windows.Forms.Label();
			this.txb_manhanvien = new System.Windows.Forms.TextBox();
			((System.ComponentModel.ISupportInitialize)(this.dgv_checkin)).BeginInit();
			this.SuspendLayout();
			// 
			// txb_tennhanvien
			// 
			this.txb_tennhanvien.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txb_tennhanvien.Location = new System.Drawing.Point(711, 12);
			this.txb_tennhanvien.Name = "txb_tennhanvien";
			this.txb_tennhanvien.ReadOnly = true;
			this.txb_tennhanvien.Size = new System.Drawing.Size(252, 27);
			this.txb_tennhanvien.TabIndex = 21;
			// 
			// btn_dongcheckin
			// 
			this.btn_dongcheckin.BackColor = System.Drawing.Color.DarkOrange;
			this.btn_dongcheckin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_dongcheckin.Location = new System.Drawing.Point(54, 448);
			this.btn_dongcheckin.Name = "btn_dongcheckin";
			this.btn_dongcheckin.Size = new System.Drawing.Size(115, 40);
			this.btn_dongcheckin.TabIndex = 19;
			this.btn_dongcheckin.Text = "Đóng";
			this.btn_dongcheckin.UseVisualStyleBackColor = false;
			this.btn_dongcheckin.Click += new System.EventHandler(this.btn_closecheckin_Click);
			this.btn_dongcheckin.MouseEnter += new System.EventHandler(this.btn_dongcheckin_MouseEnter);
			this.btn_dongcheckin.MouseLeave += new System.EventHandler(this.btn_dongcheckin_MouseLeave);


			// 
			// btn_xoacheckin
			// 
			this.btn_xoacheckin.BackColor = System.Drawing.Color.DarkOrange;
			this.btn_xoacheckin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_xoacheckin.Location = new System.Drawing.Point(54, 411);
			this.btn_xoacheckin.Name = "btn_xoacheckin";
			this.btn_xoacheckin.Size = new System.Drawing.Size(115, 40);
			this.btn_xoacheckin.TabIndex = 18;
			this.btn_xoacheckin.Text = "Xóa";
			this.btn_xoacheckin.UseVisualStyleBackColor = false;
			this.btn_xoacheckin.Click += new System.EventHandler(this.btn_deletecheckin_Click);
			this.btn_xoacheckin.MouseEnter += new System.EventHandler(this.btn_xoacheckin_MouseEnter);
			this.btn_xoacheckin.MouseLeave += new System.EventHandler(this.btn_xoacheckin_MouseLeave);
			// 
			// GioCheckIn
			// 
			this.GioCheckIn.DataPropertyName = "GioCheckIn";
			this.GioCheckIn.HeaderText = "Giờ checkin";
			this.GioCheckIn.MinimumWidth = 6;
			this.GioCheckIn.Name = "GioCheckIn";
			this.GioCheckIn.Width = 125;
			// 
			// NgayCheckIn
			// 
			this.NgayCheckIn.DataPropertyName = "NgayCheckIn";
			this.NgayCheckIn.HeaderText = "Ngày checkin";
			this.NgayCheckIn.MinimumWidth = 6;
			this.NgayCheckIn.Name = "NgayCheckIn";
			this.NgayCheckIn.Width = 125;
			// 
			// TenNV
			// 
			this.TenNV.DataPropertyName = "TenNV";
			this.TenNV.HeaderText = "Tên nhân viên";
			this.TenNV.MinimumWidth = 6;
			this.TenNV.Name = "TenNV";
			this.TenNV.Width = 125;
			// 
			// MaNV
			// 
			this.MaNV.DataPropertyName = "MaNV";
			this.MaNV.HeaderText = "Mã nhân viên";
			this.MaNV.MinimumWidth = 6;
			this.MaNV.Name = "MaNV";
			this.MaNV.Width = 75;
			// 
			// MaCheckIn
			// 
			this.MaCheckIn.DataPropertyName = "MaCheckIn";
			this.MaCheckIn.HeaderText = "Mã checkin";
			this.MaCheckIn.MinimumWidth = 6;
			this.MaCheckIn.Name = "MaCheckIn";
			this.MaCheckIn.Width = 75;
			// 
			// btn_checkin
			// 
			this.btn_checkin.BackColor = System.Drawing.Color.DarkOrange;
			this.btn_checkin.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_checkin.Location = new System.Drawing.Point(54, 338);
			this.btn_checkin.Name = "btn_checkin";
			this.btn_checkin.Size = new System.Drawing.Size(115, 40);
			this.btn_checkin.TabIndex = 16;
			this.btn_checkin.Text = "Check in";
			this.btn_checkin.UseVisualStyleBackColor = false;
			this.btn_checkin.Click += new System.EventHandler(this.btn_checkin_Click);
			this.btn_checkin.MouseEnter += new System.EventHandler(this.btn_checkin_MouseEnter);
			this.btn_checkin.MouseLeave += new System.EventHandler(this.btn_checkin_MouseLeave);
			// 
			// timer1
			// 
			this.timer1.Enabled = true;
			this.timer1.Interval = 1000;
			// 
			// dgv_checkin
			// 
			dataGridViewCellStyle3.BackColor = System.Drawing.Color.Tan;
			this.dgv_checkin.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
			this.dgv_checkin.BackgroundColor = System.Drawing.Color.White;
			dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
			dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
			dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
			dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
			dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
			dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
			this.dgv_checkin.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
			this.dgv_checkin.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv_checkin.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaCheckIn,
            this.MaNV,
            this.TenNV,
            this.NgayCheckIn,
            this.GioCheckIn});
			this.dgv_checkin.Location = new System.Drawing.Point(238, 62);
			this.dgv_checkin.Name = "dgv_checkin";
			this.dgv_checkin.RowHeadersWidth = 51;
			this.dgv_checkin.RowTemplate.Height = 24;
			this.dgv_checkin.Size = new System.Drawing.Size(725, 426);
			this.dgv_checkin.TabIndex = 17;
			// 
			// lb_giocheckin
			// 
			this.lb_giocheckin.AutoSize = true;
			this.lb_giocheckin.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_giocheckin.Location = new System.Drawing.Point(21, 210);
			this.lb_giocheckin.Name = "lb_giocheckin";
			this.lb_giocheckin.Size = new System.Drawing.Size(181, 41);
			this.lb_giocheckin.TabIndex = 15;
			this.lb_giocheckin.Text = "Giờ checkin";
			// 
			// lb_tennhanvien
			// 
			this.lb_tennhanvien.AutoSize = true;
			this.lb_tennhanvien.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_tennhanvien.Location = new System.Drawing.Point(512, 19);
			this.lb_tennhanvien.Name = "lb_tennhanvien";
			this.lb_tennhanvien.Size = new System.Drawing.Size(106, 20);
			this.lb_tennhanvien.TabIndex = 14;
			this.lb_tennhanvien.Text = "Tên nhân viên";
			// 
			// lb_manhanvien
			// 
			this.lb_manhanvien.AutoSize = true;
			this.lb_manhanvien.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_manhanvien.Location = new System.Drawing.Point(24, 19);
			this.lb_manhanvien.Name = "lb_manhanvien";
			this.lb_manhanvien.Size = new System.Drawing.Size(103, 20);
			this.lb_manhanvien.TabIndex = 13;
			this.lb_manhanvien.Text = "Mã nhân viên";
			// 
			// txb_manhanvien
			// 
			this.txb_manhanvien.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txb_manhanvien.Location = new System.Drawing.Point(133, 12);
			this.txb_manhanvien.Name = "txb_manhanvien";
			this.txb_manhanvien.ReadOnly = true;
			this.txb_manhanvien.Size = new System.Drawing.Size(252, 27);
			this.txb_manhanvien.TabIndex = 12;
			// 
			// fCheckinUser
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.BlanchedAlmond;
			this.ClientSize = new System.Drawing.Size(982, 503);
			this.Controls.Add(this.txb_tennhanvien);
			this.Controls.Add(this.btn_dongcheckin);
			this.Controls.Add(this.btn_xoacheckin);
			this.Controls.Add(this.btn_checkin);
			this.Controls.Add(this.dgv_checkin);
			this.Controls.Add(this.lb_giocheckin);
			this.Controls.Add(this.lb_tennhanvien);
			this.Controls.Add(this.lb_manhanvien);
			this.Controls.Add(this.txb_manhanvien);
			this.Name = "fCheckinUser";
			this.Text = "fCheckinUser";
			((System.ComponentModel.ISupportInitialize)(this.dgv_checkin)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.TextBox txb_tennhanvien;
		private System.Windows.Forms.Button btn_dongcheckin;
		private System.Windows.Forms.Button btn_xoacheckin;
		private System.Windows.Forms.DataGridViewTextBoxColumn GioCheckIn;
		private System.Windows.Forms.DataGridViewTextBoxColumn NgayCheckIn;
		private System.Windows.Forms.DataGridViewTextBoxColumn TenNV;
		private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
		private System.Windows.Forms.DataGridViewTextBoxColumn MaCheckIn;
		private Microsoft.Data.SqlClient.SqlDataAdapter sqlDataAdapter1;
		private System.Windows.Forms.Button btn_checkin;
		private System.Windows.Forms.Timer timer1;
		private System.Windows.Forms.DataGridView dgv_checkin;
		private System.Windows.Forms.Label lb_giocheckin;
		private System.Windows.Forms.Label lb_tennhanvien;
		private System.Windows.Forms.Label lb_manhanvien;
		private System.Windows.Forms.TextBox txb_manhanvien;
	}
}