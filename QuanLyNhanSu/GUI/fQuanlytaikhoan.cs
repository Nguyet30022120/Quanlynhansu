using QuanLyNhanSu.DAO;
using QuanLyNhanSu.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanSu
{
	public partial class fQuanlytaikhoan : Form
	{
		public fQuanlytaikhoan(string maTK)
		{
			InitializeComponent();
			LoadDataUser(maTK);
		}

		void LoadDataUser(string maTK)
		{
			List<NguoidungDTO> data = NguoidungDAO.Instance.GetInforNVByUsername(maTK);

			if (data.Count > 0)
			{
				NguoidungDTO user = data[0];
				txb_cccd.Text = user.CCCD;
				txb_manhanvien.Text = user.MaNV;
				txb_tennv.Text = user.NameNV;
				txb_chucvu.Text = user.ChucVu;
				cb_phongban.Text = user.PhongBan;
				txb_matk.Text = user.MaTK;
				txb_taikhoan.Text = user.TaiKhoan;
				cb_vaitro.Text = user.VaiTro;
				txb_motaquyenhan.Text = user.MoTaQuyenHan;
				txb_sodienthoai.Text = user.SoDienThoai;
				txb_diachi.Text = user.DiaChi;
				cb_gioitinh.Text = user.GioiTinh == 1 ? "Nam" : "Nữ";
				dtp_ngaysinh.Value = user.NgaySinh ?? DateTime.Now;


			}
			else
			{
				MessageBox.Show("No data found for the given username.");
			}
		}

		private void btn_dongtaikhoan_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
