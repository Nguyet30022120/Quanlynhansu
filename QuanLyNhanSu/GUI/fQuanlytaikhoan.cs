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
		private Color originalCloseButtonColor;
		public fQuanlytaikhoan(string maTK)
		{
			InitializeComponent();
			LoadDataUser(maTK);
			originalCloseButtonColor = btn_dongtaikhoan.BackColor;
		}

		void LoadDataUser(string maTK)
		{
			List<UserDTO> data = NguoidungDAO.Instance.GetInforNVByUsername(maTK);

			if (data.Count > 0)
			{
				UserDTO user = data[0];
				txb_cccd.Text = user.CCCD;
				txb_manhanvien.Text = user.MaNV;
				txb_tennhanvien.Text = user.TenNV;
				txb_chucvu.Text = user.ChucVu;
				txb_cuahang.Text = user.CuaHang;
				txb_mataikhoan.Text = user.MaTK;
				txb_taikhoan.Text = user.TaiKhoan;
				txb_vaitro.Text = user.VaiTro;
				txb_motaquyenhan.Text = user.MoTaQuyenHan;
				txb_sodienthoai.Text = user.SoDienThoai;
				txb_diachi.Text = user.DiaChi;
				txb_gioitinh.Text = user.GioiTinh == 1 ? "Nam" : "Nữ";
				txb_ngaysinh.Text = user.NgaySinh.HasValue ? user.NgaySinh.Value.ToString("yyyy-MM-dd") : DateTime.Now.ToString("yyyy-MM-dd");


			}
			else
			{
				MessageBox.Show("Không tìm thấy thông tin nhân viên", "Thông báo", MessageBoxButtons.OK,MessageBoxIcon.Error);
			}
		}
		#region Hovers
		private void btn_dongtaikhoan_MouseEnter(object sender, EventArgs e)
		{
			btn_dongtaikhoan.BackColor = Color.LightBlue;
		}
		private void btn_dongtaikhoan_MouseLeave(object sender, EventArgs e)
		{
			btn_dongtaikhoan.BackColor = originalCloseButtonColor;
		}
		#endregion

		#region Events

		private void btn_dongtaikhoan_Click(object sender, EventArgs e)
		{
			this.Close();
		}
		#endregion
	}
}
