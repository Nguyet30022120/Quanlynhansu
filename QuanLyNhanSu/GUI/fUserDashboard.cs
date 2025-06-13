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

namespace QuanLyNhanSu.GUI
{
	public partial class fUserDashboard : Form
	{
		private string userName;
		private string matk;
		private string manv;

		private Color originalQuanlynguoidungButtonColor;
		private Color originalDoimatkhauButtonColor;
		private Color originalQuanlytaikhoanButtonColor;
		private Color originalDangxuatButtonColor;

		private Color originalNhanvienButtonColor;
		private Color originalPhongbanButtonColor;
		private Color originalChucvuButtonColor;
		private Color originalTrinhdoButtonColor;
		private Color originalHopdongButtonColor;
		private Color originalDaotaoButtonColor;

		private Color originalCheckinButtonColor;
		private Color originalCheckoutButtonColor;
		private Color originalDangkynghiphepButtonColor;
		private Color originalDuyetnghiphepButtonColor;
		private Color originalThaydoigiolamviecButtonColor;
		private Color originalCalamviecButtonColor;
		private Color originalCongButtonColor;
		private Color originalBangcongButtonColor;

		private Color originalNguonungvienButtonColor;
		private Color originalHosoungvienButtonColor;
		private Color originalLichphongvanButtonColor;
		private Color originalKetquaButtonColor;

		private Color originalBangluongButtonColor;
		private Color originalThueColor;
		private Color originalBaohiemButtonColor;
		private Color originalKhenthuongkyluatButtonColor;

		private Color originalBaocaotongquannhansuButtonColor;
		private Color originalThongkenghiphepButtonColor;
		private Color originalThongkeluongButtonColor;
		private Color originalThongkekhenthuongkyluatButtonColor;



		public fUserDashboard(string userName)
		{
			InitializeComponent();
			this.userName = userName;
			LoadUserInfo(userName);
			LoadUserMaNVInfo(userName);


			originalDoimatkhauButtonColor = btn_doimatkhau.BackColor;
			originalQuanlytaikhoanButtonColor = btn_quanlytaikhoan.BackColor;
			originalDangxuatButtonColor = btn_dangxuat.BackColor;

			//originalNhanvienButtonColor = btn_quanlythongtinnhanvien.BackColor;
			//originalPhongbanButtonColor = btn_quanlyphongban.BackColor;
			//originalChucvuButtonColor = btn_quanlychucvu.BackColor;
			//originalTrinhdoButtonColor = btn_quanlytrinhdochuyenmon.BackColor;
			//originalHopdongButtonColor = btn_quanlyhopdonglaodong.BackColor;
			//originalDaotaoButtonColor = btn_quanlydaotaovaphattriennhanvien.BackColor;

			originalCheckinButtonColor = btn_checkin.BackColor;
			originalCheckoutButtonColor = btn_checkout.BackColor;
			originalDangkynghiphepButtonColor = btn_dangkynghiphep.BackColor;
			//originalDuyetnghiphepButtonColor = btn_duyetnghiphep.BackColor;
			//originalThaydoigiolamviecButtonColor = btn_thaydoigiolamviec.BackColor;
			//originalCalamviecButtonColor = btn_quanlycalamviec.BackColor;
			//originalCongButtonColor = btn_quanlycong.BackColor;
			originalBangcongButtonColor = btn_quanlybangcong.BackColor;

			//originalNguonungvienButtonColor = btn_quanlynguonungvien.BackColor;
			//originalHosoungvienButtonColor = btn_quanlyhosoungvien.BackColor;
			//originalLichphongvanButtonColor = btn_quanlylichpv.BackColor;
			//originalKetquaButtonColor = btn_quanlyketquaphongvan.BackColor;

			originalBangluongButtonColor = btn_quanlybangluong.BackColor;
			originalThueColor = btn_quanlyphucap.BackColor;
			originalBaohiemButtonColor = btn_quanlybaohiem.BackColor;
			originalKhenthuongkyluatButtonColor = btn_qlkhenthuongkyluat.BackColor;

			//originalBaocaotongquannhansuButtonColor = btn_baocaotongquannhansu.BackColor;
			//originalThongkenghiphepButtonColor = btn_thongkeluotnghiphepcuanhanvien.BackColor;
			//originalThongkeluongButtonColor = btn_baocaoluongthuong.BackColor;
			//originalThongkekhenthuongkyluatButtonColor = btn_thongkethongtinkhenthuongkyluat.BackColor;
		}

		void LoadUserInfo(string userName)
		{
			string name = TaikhoanDAO.Instance.GetNameNvByUsername(userName);
			lb_namenv.Text = "Xin chào " + name;

		}
		void LoadUserMaNVInfo(string userName)
		{
			string name = TaikhoanDAO.Instance.GetMaNvByUsername(userName);
			manv = name;

		}

		#region menu event
		private void btn_dangxuat_Click(object sender, EventArgs e)
		{
			this.Close();
		}



		private void btn_doimatkhau_Click(object sender, EventArgs e)
		{
			fDoimatkhau f = new fDoimatkhau(userName);
			this.Hide();
			f.ShowDialog();
			this.Show();
		}

		private void btn_quanlytaikhoan_Click(object sender, EventArgs e)
		{
			fQuanlytaikhoan f = new fQuanlytaikhoan(userName);
			this.Hide();
			f.ShowDialog();
			this.Show();
		}


		private void btn_doimatkhau_MouseEnter(object sender, EventArgs e)
		{
			btn_doimatkhau.BackColor = System.Drawing.Color.LightBlue;
		}
		private void btn_doimatkhau_MouseLeave(object sender, EventArgs e)
		{
			btn_doimatkhau.BackColor = originalDoimatkhauButtonColor;
		}
		private void btn_quanlytaikhoan_MouseEnter(object sender, EventArgs e)
		{
			btn_quanlytaikhoan.BackColor = System.Drawing.Color.LightBlue;
		}
		private void btn_quanlytaikhoan_MouseLeave(object sender, EventArgs e)
		{
			btn_quanlytaikhoan.BackColor = originalQuanlytaikhoanButtonColor;
		}
		private void btn_dangxuat_MouseEnter(object sender, EventArgs e)
		{
			btn_dangxuat.BackColor = System.Drawing.Color.LightBlue;
		}
		private void btn_dangxuat_MouseLeave(object sender, EventArgs e)
		{
			btn_dangxuat.BackColor = originalDangxuatButtonColor;
		}
		#endregion

		#region category
		
		

		#region checkin/out
		private void btn_checkin_Click(object sender, EventArgs e)
		{
			fCheckinUser f = new fCheckinUser(manv);
			this.Hide();
			f.ShowDialog();
			this.Show();
		}

		private void btn_checkout_Click(object sender, EventArgs e)
		{
			fCheckoutUser f = new fCheckoutUser(manv);
			this.Hide();
			f.ShowDialog();
			this.Show();
		}

		private void btn_dangkynghiphep_Click(object sender, EventArgs e)
		{
			fQuanlydangkynghiphepUser f = new fQuanlydangkynghiphepUser(manv);
			this.Hide();
			f.ShowDialog();
			this.Show();
		}


		//private void btn_quanlycalamviec_Click(object sender, EventArgs e)
		//{
		//	fQuanlycalamviec f = new fQuanlycalamviec();
		//	this.Hide();
		//	f.ShowDialog();
		//	this.Show();
		//}

		//private void btn_quanlycong_Click(object sender, EventArgs e)
		//{
		//	fQuanlycong f = new fQuanlycong();
		//	this.Hide();
		//	f.ShowDialog();
		//	this.Show();
		//}

		private void btn_quanlybangcong_Click(object sender, EventArgs e)
		{
			fQuanlybangcongUser f = new fQuanlybangcongUser(manv);
			this.Hide();
			f.ShowDialog();
			this.Show();
		}

		private void btn_checkin_MouseEnter(object sender, EventArgs e)
		{
			btn_checkin.BackColor = System.Drawing.Color.LightBlue;
		}
		private void btn_checkin_MouseLeave(object sender, EventArgs e)
		{
			btn_checkin.BackColor = originalCheckinButtonColor;
		}

		private void btn_checkout_MouseEnter(object sender, EventArgs e)
		{
			btn_checkout.BackColor = System.Drawing.Color.LightBlue;
		}
		private void btn_checkout_MouseLeave(object sender, EventArgs e)
		{
			btn_checkout.BackColor = originalCheckoutButtonColor;
		}

		private void btn_dangkynghiphep_MouseEnter(object sender, EventArgs e)
		{
			btn_dangkynghiphep.BackColor = System.Drawing.Color.LightBlue;
		}
		private void btn_dangkynghiphep_MouseLeave(object sender, EventArgs e)
		{
			btn_dangkynghiphep.BackColor = originalDangkynghiphepButtonColor;
		}

		//private void btn_duyetnghiphep_MouseEnter(object sender, EventArgs e)
		//{
		//	btn_duyetnghiphep.BackColor = System.Drawing.Color.LightBlue;
		//}
		//private void btn_duyetnghiphep_MouseLeave(object sender, EventArgs e)
		//{
		//	btn_duyetnghiphep.BackColor = originalDuyetnghiphepButtonColor;
		//}

		//private void btn_thaydoigiolamviec_MouseEnter(object sender, EventArgs e)
		//{
		//	btn_thaydoigiolamviec.BackColor = System.Drawing.Color.LightBlue;
		//}
		//private void btn_thaydoigiolamviec_MouseLeave(object sender, EventArgs e)
		//{
		//	btn_thaydoigiolamviec.BackColor = originalThaydoigiolamviecButtonColor;
		//}

		//private void btn_quanlycalamviec_MouseEnter(object sender, EventArgs e)
		//{
		//	btn_quanlycalamviec.BackColor = System.Drawing.Color.LightBlue;
		//}
		//private void btn_quanlycalamviec_MouseLeave(object sender, EventArgs e)
		//{
		//	btn_quanlycalamviec.BackColor = originalCalamviecButtonColor;
		//}

		//private void btn_quanlycong_MouseEnter(object sender, EventArgs e)
		//{
		//	btn_quanlycong.BackColor = System.Drawing.Color.LightBlue;
		//}
		//private void btn_quanlycong_MouseLeave(object sender, EventArgs e)
		//{
		//	btn_quanlycong.BackColor = originalCongButtonColor;
		//}

		private void btn_quanlybangcong_MouseEnter(object sender, EventArgs e)
		{
			btn_quanlybangcong.BackColor = System.Drawing.Color.LightBlue;
		}
		private void btn_quanlybangcong_MouseLeave(object sender, EventArgs e)
		{
			btn_quanlybangcong.BackColor = originalBangcongButtonColor;
		}


		#endregion

		#region recruitment
		private void btn_quanlynguonungvien_Click(object sender, EventArgs e)
		{
			fQuanlynguonungvien f = new fQuanlynguonungvien();
			this.Hide();
			f.ShowDialog();
			this.Show();
		}

		private void btn_quanlyhosoungvien_Click(object sender, EventArgs e)
		{
			fQuanlyhosoungvien f = new fQuanlyhosoungvien();
			this.Hide();
			f.ShowDialog();
			this.Show();
		}
		private void btn_quanlylichpv_Click(object sender, EventArgs e)
		{
			fQuanlylichphongvan f = new fQuanlylichphongvan();
			this.Hide();
			f.ShowDialog();
			this.Show();
		}
		private void btn_quanlyketquaphongvan_Click(object sender, EventArgs e)
		{
			fQuanlyketquaphongvan f = new fQuanlyketquaphongvan();
			this.Hide();
			f.ShowDialog();
			this.Show();
		}
		//private void btn_quanlylichpv_MouseEnter(object sender, EventArgs e)
		//{
		//	btn_quanlylichpv.BackColor = System.Drawing.Color.LightBlue;
		//}
		//private void btn_quanlylichpv_MouseLeave(object sender, EventArgs e)
		//{
		//	btn_quanlylichpv.BackColor = originalLichphongvanButtonColor;
		//}

		//private void btn_quanlyketquaphongvan_MouseEnter(object sender, EventArgs e)
		//{
		//	btn_quanlyketquaphongvan.BackColor = System.Drawing.Color.LightBlue;
		//}
		//private void btn_quanlyketquaphongvan_MouseLeave(object sender, EventArgs e)
		//{
		//	btn_quanlyketquaphongvan.BackColor = originalKetquaButtonColor;
		//}

		//private void btn_quanlynguonungvien_MouseEnter(object sender, EventArgs e)
		//{
		//	btn_quanlynguonungvien.BackColor = System.Drawing.Color.LightBlue;
		//}
		//private void btn_quanlynguonungvien_MouseLeave(object sender, EventArgs e)
		//{
		//	btn_quanlynguonungvien.BackColor = originalNguonungvienButtonColor;
		//}
		//private void btn_quanlyhosoungvien_MouseEnter(object sender, EventArgs e)
		//{
		//	btn_quanlyhosoungvien.BackColor = System.Drawing.Color.LightBlue;
		//}
		//private void btn_quanlyhosoungvien_MouseLeave(object sender, EventArgs e)
		//{
		//	btn_quanlyhosoungvien.BackColor = originalHosoungvienButtonColor;
		//}

		#endregion

		#region compensation
		private void btn_quanlybangluong_Click(object sender, EventArgs e)
		{
			fBangluongUser f = new fBangluongUser(manv);
			this.Hide();
			f.ShowDialog();
			this.Show();
		}

		//private void btn_quanlythuongvaphucloinhanvien_Click(object sender, EventArgs e)
		//{
		//	fQuanlythuongvaphucloinhanvien f = new fQuanlythuongvaphucloinhanvien(manv);
		//	this.Hide();
		//	f.ShowDialog();
		//	this.Show();
		//}

		private void btn_quanlythuevabaohiemxahoi_Click(object sender, EventArgs e)
		{
			fQuanlybaohiemUser f = new fQuanlybaohiemUser(manv);
			this.Hide();
			f.ShowDialog();
			this.Show();
		}
		private void btn_quanlyphucap_Click(object sender, EventArgs e)
		{
			fQuanlyphucapUser f = new fQuanlyphucapUser(manv);
			this.Hide();
			f.ShowDialog();
			this.Show();
		}

		private void btn_qlkhenthuongkyluat_Click(object sender, EventArgs e)
		{
			fQuanlykhenthuongkyluatUser f = new fQuanlykhenthuongkyluatUser(manv);
			this.Hide();
			f.ShowDialog();
			this.Show();
		}
		private void btn_quanlybangluong_MouseEnter(object sender, EventArgs e)
		{
			btn_quanlybangluong.BackColor = System.Drawing.Color.LightBlue;
		}
		private void btn_quanlybangluong_MouseLeave(object sender, EventArgs e)
		{
			btn_quanlybangluong.BackColor = originalBangluongButtonColor;
		}

		private void btn_quanlythue_MouseEnter(object sender, EventArgs e)
		{
			btn_quanlyphucap.BackColor = System.Drawing.Color.LightBlue;
		}
		private void btn_quanlythue_MouseLeave(object sender, EventArgs e)
		{
			btn_quanlyphucap.BackColor = originalThueColor;
		}

		private void btn_quanlybaohiem_MouseEnter(object sender, EventArgs e)
		{
			btn_quanlybaohiem.BackColor = System.Drawing.Color.LightBlue;
		}
		private void btn_quanlybaohiem_MouseLeave(object sender, EventArgs e)
		{
			btn_quanlybaohiem.BackColor = originalBaohiemButtonColor;
		}

		private void btn_qlkhenthuongkyluat_MouseEnter(object sender, EventArgs e)
		{
			btn_qlkhenthuongkyluat.BackColor = System.Drawing.Color.LightBlue;
		}
		private void btn_qlkhenthuongkyluat_MouseLeave(object sender, EventArgs e)
		{
			btn_qlkhenthuongkyluat.BackColor = originalKhenthuongkyluatButtonColor;
		}

		#endregion
		#endregion
	}
}
