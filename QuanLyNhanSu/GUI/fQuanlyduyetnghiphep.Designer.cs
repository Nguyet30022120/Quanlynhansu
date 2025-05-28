namespace QuanLyNhanSu.GUI
{
	partial class fQuanlyduyetnghiphep
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
			this.dgv_duyetdonnghiphep = new System.Windows.Forms.DataGridView();
			this.btn_duyet = new System.Windows.Forms.Button();
			this.btn_tuchoi = new System.Windows.Forms.Button();
			this.btn_dong = new System.Windows.Forms.Button();
			this.txb_madonnghiphep = new System.Windows.Forms.TextBox();
			this.lb_madonnghiphep = new System.Windows.Forms.Label();
			this.btn_timkiemdonnghiphep = new System.Windows.Forms.Button();
			this.txb_timkiemdonnghiphep = new System.Windows.Forms.TextBox();
			this.MaDonNghiPhep = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TenNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.LoaiPhep = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.LyDo = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.TrangThai = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NguoiDuyet = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NgayBD = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NgayKT = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.SoNgay = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.NgayTao = new System.Windows.Forms.DataGridViewTextBoxColumn();
			this.lb_goiy = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.dgv_duyetdonnghiphep)).BeginInit();
			this.SuspendLayout();
			// 
			// dgv_duyetdonnghiphep
			// 
			this.dgv_duyetdonnghiphep.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgv_duyetdonnghiphep.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MaDonNghiPhep,
            this.TenNV,
            this.MaNV,
            this.LoaiPhep,
            this.LyDo,
            this.TrangThai,
            this.NguoiDuyet,
            this.NgayBD,
            this.NgayKT,
            this.SoNgay,
            this.NgayTao});
			this.dgv_duyetdonnghiphep.Location = new System.Drawing.Point(7, 90);
			this.dgv_duyetdonnghiphep.Name = "dgv_duyetdonnghiphep";
			this.dgv_duyetdonnghiphep.RowHeadersWidth = 51;
			this.dgv_duyetdonnghiphep.RowTemplate.Height = 24;
			this.dgv_duyetdonnghiphep.Size = new System.Drawing.Size(973, 409);
			this.dgv_duyetdonnghiphep.TabIndex = 0;
			// 
			// btn_duyet
			// 
			this.btn_duyet.BackColor = System.Drawing.Color.DarkOrange;
			this.btn_duyet.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_duyet.Location = new System.Drawing.Point(570, 20);
			this.btn_duyet.Name = "btn_duyet";
			this.btn_duyet.Size = new System.Drawing.Size(115, 40);
			this.btn_duyet.TabIndex = 1;
			this.btn_duyet.Text = "Duyệt";
			this.btn_duyet.UseVisualStyleBackColor = false;
			this.btn_duyet.Click += new System.EventHandler(this.btn_duyet_Click);
			// 
			// btn_tuchoi
			// 
			this.btn_tuchoi.BackColor = System.Drawing.Color.DarkOrange;
			this.btn_tuchoi.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_tuchoi.Location = new System.Drawing.Point(680, 20);
			this.btn_tuchoi.Name = "btn_tuchoi";
			this.btn_tuchoi.Size = new System.Drawing.Size(115, 40);
			this.btn_tuchoi.TabIndex = 2;
			this.btn_tuchoi.Text = "Từ chối";
			this.btn_tuchoi.UseVisualStyleBackColor = false;
			this.btn_tuchoi.Click += new System.EventHandler(this.btn_tuchoi_Click);
			// 
			// btn_dong
			// 
			this.btn_dong.BackColor = System.Drawing.Color.DarkOrange;
			this.btn_dong.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_dong.Location = new System.Drawing.Point(790, 20);
			this.btn_dong.Name = "btn_dong";
			this.btn_dong.Size = new System.Drawing.Size(115, 40);
			this.btn_dong.TabIndex = 3;
			this.btn_dong.Text = "Đóng";
			this.btn_dong.UseVisualStyleBackColor = false;
			this.btn_dong.Click += new System.EventHandler(this.btn_dong_Click);
			// 
			// txb_madonnghiphep
			// 
			this.txb_madonnghiphep.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txb_madonnghiphep.Location = new System.Drawing.Point(74, 59);
			this.txb_madonnghiphep.Name = "txb_madonnghiphep";
			this.txb_madonnghiphep.Size = new System.Drawing.Size(188, 27);
			this.txb_madonnghiphep.TabIndex = 4;
			// 
			// lb_madonnghiphep
			// 
			this.lb_madonnghiphep.AutoSize = true;
			this.lb_madonnghiphep.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_madonnghiphep.Location = new System.Drawing.Point(6, 62);
			this.lb_madonnghiphep.Name = "lb_madonnghiphep";
			this.lb_madonnghiphep.Size = new System.Drawing.Size(62, 20);
			this.lb_madonnghiphep.TabIndex = 5;
			this.lb_madonnghiphep.Text = "Mã đơn";
			// 
			// btn_timkiemdonnghiphep
			// 
			this.btn_timkiemdonnghiphep.BackColor = System.Drawing.Color.DarkOrange;
			this.btn_timkiemdonnghiphep.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.btn_timkiemdonnghiphep.Location = new System.Drawing.Point(291, 20);
			this.btn_timkiemdonnghiphep.Name = "btn_timkiemdonnghiphep";
			this.btn_timkiemdonnghiphep.Size = new System.Drawing.Size(115, 40);
			this.btn_timkiemdonnghiphep.TabIndex = 6;
			this.btn_timkiemdonnghiphep.Text = "Tìm kiếm";
			this.btn_timkiemdonnghiphep.UseVisualStyleBackColor = false;
			this.btn_timkiemdonnghiphep.Click += new System.EventHandler(this.btn_timkiemdonnghiphep_Click);
			// 
			// txb_timkiemdonnghiphep
			// 
			this.txb_timkiemdonnghiphep.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.txb_timkiemdonnghiphep.Location = new System.Drawing.Point(10, 20);
			this.txb_timkiemdonnghiphep.Name = "txb_timkiemdonnghiphep";
			this.txb_timkiemdonnghiphep.Size = new System.Drawing.Size(252, 27);
			this.txb_timkiemdonnghiphep.TabIndex = 7;
			// 
			// MaDonNghiPhep
			// 
			this.MaDonNghiPhep.DataPropertyName = "MaDonNghiPhep";
			this.MaDonNghiPhep.HeaderText = "Mã đơn";
			this.MaDonNghiPhep.MinimumWidth = 6;
			this.MaDonNghiPhep.Name = "MaDonNghiPhep";
			this.MaDonNghiPhep.Width = 50;
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
			this.MaNV.Width = 50;
			// 
			// LoaiPhep
			// 
			this.LoaiPhep.DataPropertyName = "LoaiPhep";
			this.LoaiPhep.HeaderText = "Loại phép";
			this.LoaiPhep.MinimumWidth = 6;
			this.LoaiPhep.Name = "LoaiPhep";
			this.LoaiPhep.Width = 125;
			// 
			// LyDo
			// 
			this.LyDo.DataPropertyName = "LyDo";
			this.LyDo.HeaderText = "Lý do";
			this.LyDo.MinimumWidth = 6;
			this.LyDo.Name = "LyDo";
			this.LyDo.Width = 125;
			// 
			// TrangThai
			// 
			this.TrangThai.DataPropertyName = "TrangThai";
			this.TrangThai.HeaderText = "Trạng thái";
			this.TrangThai.MinimumWidth = 6;
			this.TrangThai.Name = "TrangThai";
			this.TrangThai.Width = 125;
			// 
			// NguoiDuyet
			// 
			this.NguoiDuyet.DataPropertyName = "NguoiDuyet";
			this.NguoiDuyet.HeaderText = "Người duyệt";
			this.NguoiDuyet.MinimumWidth = 6;
			this.NguoiDuyet.Name = "NguoiDuyet";
			this.NguoiDuyet.Width = 125;
			// 
			// NgayBD
			// 
			this.NgayBD.DataPropertyName = "NgayBD";
			this.NgayBD.HeaderText = "Ngày bắt đầu";
			this.NgayBD.MinimumWidth = 6;
			this.NgayBD.Name = "NgayBD";
			this.NgayBD.Width = 125;
			// 
			// NgayKT
			// 
			this.NgayKT.DataPropertyName = "NgayKT";
			this.NgayKT.HeaderText = "Ngày kết thúc";
			this.NgayKT.MinimumWidth = 6;
			this.NgayKT.Name = "NgayKT";
			this.NgayKT.Width = 125;
			// 
			// SoNgay
			// 
			this.SoNgay.DataPropertyName = "SoNgay";
			this.SoNgay.HeaderText = "Số ngày";
			this.SoNgay.MinimumWidth = 6;
			this.SoNgay.Name = "SoNgay";
			this.SoNgay.Width = 125;
			// 
			// NgayTao
			// 
			this.NgayTao.DataPropertyName = "NgayTao";
			this.NgayTao.HeaderText = "Ngày tạo";
			this.NgayTao.MinimumWidth = 6;
			this.NgayTao.Name = "NgayTao";
			this.NgayTao.Width = 125;
			// 
			// lb_goiy
			// 
			this.lb_goiy.AutoSize = true;
			this.lb_goiy.Font = new System.Drawing.Font("Segoe UI", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.lb_goiy.Location = new System.Drawing.Point(300, 69);
			this.lb_goiy.Name = "lb_goiy";
			this.lb_goiy.Size = new System.Drawing.Size(307, 17);
			this.lb_goiy.TabIndex = 46;
			this.lb_goiy.Text = "(Tìm kiếm theo mã đơn, mã nhân viên, tên nhân viên)";
			// 
			// fQuanlyduyetnghiphep
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.BlanchedAlmond;
			this.ClientSize = new System.Drawing.Size(982, 503);
			this.Controls.Add(this.lb_goiy);
			this.Controls.Add(this.txb_timkiemdonnghiphep);
			this.Controls.Add(this.btn_timkiemdonnghiphep);
			this.Controls.Add(this.lb_madonnghiphep);
			this.Controls.Add(this.txb_madonnghiphep);
			this.Controls.Add(this.btn_dong);
			this.Controls.Add(this.btn_tuchoi);
			this.Controls.Add(this.btn_duyet);
			this.Controls.Add(this.dgv_duyetdonnghiphep);
			this.Name = "fQuanlyduyetnghiphep";
			this.Text = "Quản lý duyệt nghỉ phép";
			((System.ComponentModel.ISupportInitialize)(this.dgv_duyetdonnghiphep)).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.DataGridView dgv_duyetdonnghiphep;
		private System.Windows.Forms.Button btn_duyet;
		private System.Windows.Forms.Button btn_tuchoi;
		private System.Windows.Forms.Button btn_dong;
		private System.Windows.Forms.TextBox txb_madonnghiphep;
		private System.Windows.Forms.Label lb_madonnghiphep;
		private System.Windows.Forms.Button btn_timkiemdonnghiphep;
		private System.Windows.Forms.TextBox txb_timkiemdonnghiphep;
		private System.Windows.Forms.DataGridViewTextBoxColumn MaDonNghiPhep;
		private System.Windows.Forms.DataGridViewTextBoxColumn TenNV;
		private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
		private System.Windows.Forms.DataGridViewTextBoxColumn LoaiPhep;
		private System.Windows.Forms.DataGridViewTextBoxColumn LyDo;
		private System.Windows.Forms.DataGridViewTextBoxColumn TrangThai;
		private System.Windows.Forms.DataGridViewTextBoxColumn NguoiDuyet;
		private System.Windows.Forms.DataGridViewTextBoxColumn NgayBD;
		private System.Windows.Forms.DataGridViewTextBoxColumn NgayKT;
		private System.Windows.Forms.DataGridViewTextBoxColumn SoNgay;
		private System.Windows.Forms.DataGridViewTextBoxColumn NgayTao;
		private System.Windows.Forms.Label lb_goiy;
	}
}