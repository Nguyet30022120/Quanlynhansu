namespace QuanLyNhanSu.GUI
{
    partial class fBangluong
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_luubangluong = new System.Windows.Forms.Button();
            this.btn_xuatbaocao = new System.Windows.Forms.Button();
            this.btn_tinhluong = new System.Windows.Forms.Button();
            this.cb_nhanvien = new System.Windows.Forms.ComboBox();
            this.cb_nam = new System.Windows.Forms.ComboBox();
            this.cb_thang = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dgv_bangluong = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lbl_luongcaonhat = new System.Windows.Forms.Label();
            this.lbl_luongthapnhat = new System.Windows.Forms.Label();
            this.lbl_luongtrungbinh = new System.Windows.Forms.Label();
            this.lbl_tongluong = new System.Windows.Forms.Label();
            this.lbl_tongnhanvien = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_bangluong)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightBlue;
            this.panel1.Controls.Add(this.btn_close);
            this.panel1.Controls.Add(this.btn_luubangluong);
            this.panel1.Controls.Add(this.btn_xuatbaocao);
            this.panel1.Controls.Add(this.btn_tinhluong);
            this.panel1.Controls.Add(this.cb_nhanvien);
            this.panel1.Controls.Add(this.cb_nam);
            this.panel1.Controls.Add(this.cb_thang);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1400, 150);
            this.panel1.TabIndex = 0;
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btn_close.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btn_close.Location = new System.Drawing.Point(1250, 88);
            this.btn_close.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(112, 44);
            this.btn_close.TabIndex = 10;
            this.btn_close.Text = "Đóng";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_luubangluong
            // 
            this.btn_luubangluong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.btn_luubangluong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btn_luubangluong.Location = new System.Drawing.Point(1100, 88);
            this.btn_luubangluong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_luubangluong.Name = "btn_luubangluong";
            this.btn_luubangluong.Size = new System.Drawing.Size(135, 44);
            this.btn_luubangluong.TabIndex = 9;
            this.btn_luubangluong.Text = "Lưu bảng lương";
            this.btn_luubangluong.UseVisualStyleBackColor = false;
            this.btn_luubangluong.Click += new System.EventHandler(this.btn_luubangluong_Click);
            // 
            // btn_xuatbaocao
            // 
            this.btn_xuatbaocao.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btn_xuatbaocao.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btn_xuatbaocao.Location = new System.Drawing.Point(950, 88);
            this.btn_xuatbaocao.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_xuatbaocao.Name = "btn_xuatbaocao";
            this.btn_xuatbaocao.Size = new System.Drawing.Size(135, 44);
            this.btn_xuatbaocao.TabIndex = 8;
            this.btn_xuatbaocao.Text = "Xuất báo cáo";
            this.btn_xuatbaocao.UseVisualStyleBackColor = false;
            this.btn_xuatbaocao.Click += new System.EventHandler(this.btn_xuatbaocao_Click);
            // 
            // btn_tinhluong
            // 
            this.btn_tinhluong.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn_tinhluong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.btn_tinhluong.Location = new System.Drawing.Point(800, 88);
            this.btn_tinhluong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn_tinhluong.Name = "btn_tinhluong";
            this.btn_tinhluong.Size = new System.Drawing.Size(135, 44);
            this.btn_tinhluong.TabIndex = 7;
            this.btn_tinhluong.Text = "Tính lương";
            this.btn_tinhluong.UseVisualStyleBackColor = false;
            this.btn_tinhluong.Click += new System.EventHandler(this.btn_tinhluong_Click);
            // 
            // cb_nhanvien
            // 
            this.cb_nhanvien.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_nhanvien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cb_nhanvien.FormattingEnabled = true;
            this.cb_nhanvien.Location = new System.Drawing.Point(550, 94);
            this.cb_nhanvien.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cb_nhanvien.Name = "cb_nhanvien";
            this.cb_nhanvien.Size = new System.Drawing.Size(224, 33);
            this.cb_nhanvien.TabIndex = 6;
            this.cb_nhanvien.SelectedIndexChanged += new System.EventHandler(this.cb_nhanvien_SelectedIndexChanged);
            // 
            // cb_nam
            // 
            this.cb_nam.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_nam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cb_nam.FormattingEnabled = true;
            this.cb_nam.Location = new System.Drawing.Point(394, 94);
            this.cb_nam.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cb_nam.Name = "cb_nam";
            this.cb_nam.Size = new System.Drawing.Size(112, 33);
            this.cb_nam.TabIndex = 5;
            this.cb_nam.SelectedIndexChanged += new System.EventHandler(this.cb_nam_SelectedIndexChanged);
            // 
            // cb_thang
            // 
            this.cb_thang.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cb_thang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.cb_thang.FormattingEnabled = true;
            this.cb_thang.Location = new System.Drawing.Point(135, 94);
            this.cb_thang.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cb_thang.Name = "cb_thang";
            this.cb_thang.Size = new System.Drawing.Size(112, 33);
            this.cb_thang.TabIndex = 4;
            this.cb_thang.SelectedIndexChanged += new System.EventHandler(this.cb_thang_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(440, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(116, 25);
            this.label4.TabIndex = 3;
            this.label4.Text = "Nhân viên:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(326, 98);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Năm:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(56, 98);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 25);
            this.label2.TabIndex = 1;
            this.label2.Text = "Tháng:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.DarkBlue;
            this.label1.Location = new System.Drawing.Point(600, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 37);
            this.label1.TabIndex = 0;
            this.label1.Text = "BẢNG LƯƠNG";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dgv_bangluong);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 150);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1400, 388);
            this.panel2.TabIndex = 1;
            // 
            // dgv_bangluong
            // 
            this.dgv_bangluong.AllowUserToAddRows = false;
            this.dgv_bangluong.AllowUserToDeleteRows = false;
            this.dgv_bangluong.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_bangluong.BackgroundColor = System.Drawing.Color.White;
            this.dgv_bangluong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_bangluong.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgv_bangluong.Location = new System.Drawing.Point(0, 0);
            this.dgv_bangluong.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgv_bangluong.Name = "dgv_bangluong";
            this.dgv_bangluong.ReadOnly = true;
            this.dgv_bangluong.RowHeadersWidth = 51;
            this.dgv_bangluong.RowTemplate.Height = 24;
            this.dgv_bangluong.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgv_bangluong.Size = new System.Drawing.Size(1400, 388);
            this.dgv_bangluong.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightGray;
            this.panel3.Controls.Add(this.lbl_luongcaonhat);
            this.panel3.Controls.Add(this.lbl_luongthapnhat);
            this.panel3.Controls.Add(this.lbl_luongtrungbinh);
            this.panel3.Controls.Add(this.lbl_tongluong);
            this.panel3.Controls.Add(this.lbl_tongnhanvien);
            this.panel3.Controls.Add(this.label9);
            this.panel3.Controls.Add(this.label8);
            this.panel3.Controls.Add(this.label7);
            this.panel3.Controls.Add(this.label6);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 538);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1400, 100);
            this.panel3.TabIndex = 2;
            // 
            // lbl_luongcaonhat
            // 
            this.lbl_luongcaonhat.AutoSize = true;
            this.lbl_luongcaonhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.lbl_luongcaonhat.ForeColor = System.Drawing.Color.Green;
            this.lbl_luongcaonhat.Location = new System.Drawing.Point(1120, 58);
            this.lbl_luongcaonhat.Name = "lbl_luongcaonhat";
            this.lbl_luongcaonhat.Size = new System.Drawing.Size(25, 26);
            this.lbl_luongcaonhat.TabIndex = 9;
            this.lbl_luongcaonhat.Text = "0";
            // 
            // lbl_luongthapnhat
            // 
            this.lbl_luongthapnhat.AutoSize = true;
            this.lbl_luongthapnhat.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.lbl_luongthapnhat.ForeColor = System.Drawing.Color.Red;
            this.lbl_luongthapnhat.Location = new System.Drawing.Point(1120, 25);
            this.lbl_luongthapnhat.Name = "lbl_luongthapnhat";
            this.lbl_luongthapnhat.Size = new System.Drawing.Size(25, 26);
            this.lbl_luongthapnhat.TabIndex = 8;
            this.lbl_luongthapnhat.Text = "0";
            // 
            // lbl_luongtrungbinh
            // 
            this.lbl_luongtrungbinh.AutoSize = true;
            this.lbl_luongtrungbinh.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.lbl_luongtrungbinh.ForeColor = System.Drawing.Color.Blue;
            this.lbl_luongtrungbinh.Location = new System.Drawing.Point(720, 58);
            this.lbl_luongtrungbinh.Name = "lbl_luongtrungbinh";
            this.lbl_luongtrungbinh.Size = new System.Drawing.Size(25, 26);
            this.lbl_luongtrungbinh.TabIndex = 7;
            this.lbl_luongtrungbinh.Text = "0";
            // 
            // lbl_tongluong
            // 
            this.lbl_tongluong.AutoSize = true;
            this.lbl_tongluong.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.lbl_tongluong.ForeColor = System.Drawing.Color.DarkGreen;
            this.lbl_tongluong.Location = new System.Drawing.Point(720, 25);
            this.lbl_tongluong.Name = "lbl_tongluong";
            this.lbl_tongluong.Size = new System.Drawing.Size(25, 26);
            this.lbl_tongluong.TabIndex = 6;
            this.lbl_tongluong.Text = "0";
            // 
            // lbl_tongnhanvien
            // 
            this.lbl_tongnhanvien.AutoSize = true;
            this.lbl_tongnhanvien.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.lbl_tongnhanvien.ForeColor = System.Drawing.Color.Purple;
            this.lbl_tongnhanvien.Location = new System.Drawing.Point(250, 40);
            this.lbl_tongnhanvien.Name = "lbl_tongnhanvien";
            this.lbl_tongnhanvien.Size = new System.Drawing.Size(25, 26);
            this.lbl_tongnhanvien.TabIndex = 5;
            this.lbl_tongnhanvien.Text = "0";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(950, 60);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(178, 25);
            this.label9.TabIndex = 4;
            this.label9.Text = "Lương cao nhất:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(950, 27);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(186, 25);
            this.label8.TabIndex = 3;
            this.label8.Text = "Lương thấp nhất:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(550, 60);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(191, 25);
            this.label7.TabIndex = 2;
            this.label7.Text = "Lương trung bình:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(550, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 25);
            this.label6.TabIndex = 1;
            this.label6.Text = "Tổng lương:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(80, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(176, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Tổng nhân viên:";
            // 
            // fBangluong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1400, 638);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Sizable;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MaximizeBox = true;
            this.MinimizeBox = true;
            this.Name = "fBangluong";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bảng Lương";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_bangluong)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_luubangluong;
        private System.Windows.Forms.Button btn_xuatbaocao;
        private System.Windows.Forms.Button btn_tinhluong;
        private System.Windows.Forms.ComboBox cb_nhanvien;
        private System.Windows.Forms.ComboBox cb_nam;
        private System.Windows.Forms.ComboBox cb_thang;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dgv_bangluong;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label lbl_luongcaonhat;
        private System.Windows.Forms.Label lbl_luongthapnhat;
        private System.Windows.Forms.Label lbl_luongtrungbinh;
        private System.Windows.Forms.Label lbl_tongluong;
        private System.Windows.Forms.Label lbl_tongnhanvien;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
    }
} 