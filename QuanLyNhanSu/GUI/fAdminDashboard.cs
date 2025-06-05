using QuanLyNhanSu.DAO;
using QuanLyNhanSu.GUI;
using System;
using System.Windows.Forms;
using System.Drawing;
using Azure.Identity;

namespace QuanLyNhanSu
{
	public partial class AdminDashboard : Form
	{
		private string userName;

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



		public AdminDashboard(string userName)
		{
			InitializeComponent();
			this.userName = userName;
			LoadUserInfo(userName);
			originalQuanlynguoidungButtonColor = btn_quanlynguoidung.BackColor;
			originalDoimatkhauButtonColor = btn_doimatkhau.BackColor;
			originalQuanlytaikhoanButtonColor = btn_quanlytaikhoan.BackColor;
			originalDangxuatButtonColor = btn_dangxuat.BackColor;

			originalNhanvienButtonColor = btn_quanlythongtinnhanvien.BackColor;
			originalPhongbanButtonColor = btn_quanlyphongban.BackColor;
			originalChucvuButtonColor = btn_quanlychucvu.BackColor;
			originalTrinhdoButtonColor = btn_quanlytrinhdochuyenmon.BackColor;
			originalHopdongButtonColor = btn_quanlyhopdonglaodong.BackColor;
			originalDaotaoButtonColor = btn_quanlydaotaovaphattriennhanvien.BackColor;

			originalCheckinButtonColor = btn_checkin.BackColor;
			originalCheckoutButtonColor = btn_checkout.BackColor;
			originalDangkynghiphepButtonColor = btn_dangkynghiphep.BackColor;
			originalDuyetnghiphepButtonColor = btn_duyetnghiphep.BackColor;
			originalBangcongButtonColor = btn_quanlybangcong.BackColor;

			originalNguonungvienButtonColor = btn_quanlynguonungvien.BackColor;
			originalHosoungvienButtonColor = btn_quanlyhosoungvien.BackColor;
			originalLichphongvanButtonColor = btn_quanlylichpv.BackColor;
			originalKetquaButtonColor = btn_quanlyketquaphongvan.BackColor;

			originalBangluongButtonColor = btn_quanlybangluong.BackColor;
			originalThueColor = btn_quanlyphucap.BackColor;
			originalBaohiemButtonColor = btn_quanlybaohiem.BackColor;
			originalKhenthuongkyluatButtonColor = btn_qlkhenthuongkyluat.BackColor;

			originalBaocaotongquannhansuButtonColor = btn_baocaotongquannhansu.BackColor;
			originalThongkenghiphepButtonColor = btn_thongkeluotnghiphepcuanhanvien.BackColor;
			originalThongkeluongButtonColor = btn_baocaoluongthuong.BackColor;
			originalThongkekhenthuongkyluatButtonColor = btn_thongkethongtinkhenthuongkyluat.BackColor;
		}

		void LoadUserInfo(string userName)
		{
			string name = TaikhoanDAO.Instance.GetNameNvByUsername(userName);
			lb_namenv.Text = "Xin chào " + name;
		}

		#region menu event
		private void btn_dangxuat_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btn_quanlynguoidung_Click(object sender, EventArgs e)
		{
			fQuanlynguoidung f = new fQuanlynguoidung();
			this.Hide();
			f.ShowDialog();
			this.Show();
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

		private void btn_quanlynguoidung_MouseEnter(object sender, EventArgs e)
		{
			btn_quanlynguoidung.BackColor = System.Drawing.Color.LightBlue; 
		}
		private void btn_quanlynguoidung_MouseLeave(object sender, EventArgs e)
		{
			btn_quanlynguoidung.BackColor = originalQuanlynguoidungButtonColor;
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
		private void btn_quanlythongtinnhanvien_Click(object sender, EventArgs e)
		{
			fQuanlynhanvien f = new fQuanlynhanvien();
			this.Hide();
			f.ShowDialog();
			this.Show();
		}

		private void btn_quanlyphongban_Click(object sender, EventArgs e)
		{
			fQuanlyphongban f = new fQuanlyphongban();
			this.Hide();
			f.ShowDialog();
			this.Show();
		}

		private void btn_quanlychucvu_Click(object sender, EventArgs e)
		{
			fQuanlychucvu f = new fQuanlychucvu();
			this.Hide();
			f.ShowDialog();
			this.Show();
		}

		private void btn_quanlytrinhdochuyenmon_Click(object sender, EventArgs e)
		{
			fQuanlytrinhdochuyenmon f = new fQuanlytrinhdochuyenmon();
			this.Hide();
			f.ShowDialog();
			this.Show();
		}

		private void btn_quanlyhopdonglaodong_Click(object sender, EventArgs e)
		{
			fQuanlyhopdong f = new fQuanlyhopdong();
			this.Hide();
			f.ShowDialog();
			this.Show();
		}

		private void btn_quanlydaotaovaphattriennhanvien_Click(object sender, EventArgs e)
		{
			fQuanlydaotaonhanvien f = new fQuanlydaotaonhanvien();
			this.Hide();
			f.ShowDialog();
			this.Show();
		}
		private void btn_nhanvien_MouseEnter(object sender, EventArgs e)
		{
			btn_quanlythongtinnhanvien.BackColor = System.Drawing.Color.LightBlue;
		}
		private void btn_nhanvien_MouseLeave(object sender, EventArgs e)
		{
			btn_quanlythongtinnhanvien.BackColor = originalNhanvienButtonColor;
		}

		private void btn_phongban_MouseEnter(object sender, EventArgs e)
		{
			btn_quanlyphongban.BackColor = System.Drawing.Color.LightBlue;
		}
		private void btn_phongban_MouseLeave(object sender, EventArgs e)
		{
			btn_quanlyphongban.BackColor = originalPhongbanButtonColor;
		}

		private void btn_chucvu_MouseEnter(object sender, EventArgs e)
		{
			btn_quanlychucvu.BackColor = System.Drawing.Color.LightBlue;
		}
		private void btn_chucvu_MouseLeave(object sender, EventArgs e)
		{
			btn_quanlychucvu.BackColor = originalChucvuButtonColor;
		}

		private void btn_trinhdo_MouseEnter(object sender, EventArgs e)
		{
			btn_quanlytrinhdochuyenmon.BackColor = System.Drawing.Color.LightBlue;
		}
		private void btn_trinhdo_MouseLeave(object sender, EventArgs e)
		{
			btn_quanlytrinhdochuyenmon.BackColor = originalTrinhdoButtonColor;
		}

		private void btn_hopdong_MouseEnter(object sender, EventArgs e)
		{
			btn_quanlyhopdonglaodong.BackColor = System.Drawing.Color.LightBlue;
		}
		private void btn_hopdong_MouseLeave(object sender, EventArgs e)
		{
			btn_quanlyhopdonglaodong.BackColor = originalHopdongButtonColor;
		}

		private void btn_daotao_MouseEnter(object sender, EventArgs e)
		{
			btn_quanlydaotaovaphattriennhanvien.BackColor = System.Drawing.Color.LightBlue;
		}
		private void btn_daotao_MouseLeave(object sender, EventArgs e)
		{
			btn_quanlydaotaovaphattriennhanvien.BackColor = originalDaotaoButtonColor;
		}


		#endregion

		#region statistics
		private void btn_thongkethongtinkhenthuongkyluat_Click(object sender, EventArgs e)
		{
			fThongkekhenthuongkyluat f = new fThongkekhenthuongkyluat();
			this.Hide();
			f.ShowDialog();
			this.Show();
		}

		private void btn_thongkeluotnghiphepcuanhanvien_Click(object sender, EventArgs e)
		{
			fThongkenghiphep f = new fThongkenghiphep();
			this.Hide();
			f.ShowDialog();
			this.Show();
		}

		private void btn_baocaohieusuatnhanvien_Click(object sender, EventArgs e)
		{
			fThongketongquannhansu f = new fThongketongquannhansu();
			this.Hide();
			f.ShowDialog();
			this.Show();
		}

		private void btn_baocaochitraxuatphieuluong_Click(object sender, EventArgs e)
		{
			fThongkeluong f = new fThongkeluong();
			this.Hide();
			f.ShowDialog();
			this.Show();
		}
		private void btn_baocaotongquannhansu_MouseEnter(object sender, EventArgs e)
		{
			btn_baocaotongquannhansu.BackColor = System.Drawing.Color.LightBlue;
		}
		private void btn_baocaotongquannhansu_MouseLeave(object sender, EventArgs e)
		{
			btn_baocaotongquannhansu.BackColor = originalBaocaotongquannhansuButtonColor;
		}

		private void btn_thongkenghiphep_MouseEnter(object sender, EventArgs e)
		{
			btn_thongkeluotnghiphepcuanhanvien.BackColor = System.Drawing.Color.LightBlue;
		}
		private void btn_thongkenghiphep_MouseLeave(object sender, EventArgs e)
		{
			btn_thongkeluotnghiphepcuanhanvien.BackColor = originalThongkenghiphepButtonColor;
		}

		private void btn_thongkeluong_MouseEnter(object sender, EventArgs e)
		{
			btn_baocaoluongthuong.BackColor = System.Drawing.Color.LightBlue;
		}
		private void btn_thongkeluong_MouseLeave(object sender, EventArgs e)
		{
			btn_baocaoluongthuong.BackColor = originalThongkeluongButtonColor;
		}

		private void btn_thongkekhenthuongkyluat_MouseEnter(object sender, EventArgs e)
		{
			btn_thongkethongtinkhenthuongkyluat.BackColor = System.Drawing.Color.LightBlue;
		}
		private void btn_thongkekhenthuongkyluat_MouseLeave(object sender, EventArgs e)
		{
			btn_thongkethongtinkhenthuongkyluat.BackColor = originalThongkekhenthuongkyluatButtonColor;
		}


		#endregion

		#region checkin/out
		private void btn_checkin_Click(object sender, EventArgs e)
		{
			fCheckIn f = new fCheckIn();
			this.Hide();
			f.ShowDialog();
			this.Show();
		}

		private void btn_checkout_Click(object sender, EventArgs e)
		{
			fCheckOut f = new fCheckOut();
			this.Hide();
			f.ShowDialog();
			this.Show();
		}

		private void btn_dangkynghiphep_Click(object sender, EventArgs e)
		{
			fQuanlydangkynghiphep f = new fQuanlydangkynghiphep();
			this.Hide();
			f.ShowDialog();
			this.Show();
		}

		private void btn_duyetnghiphep_Click(object sender, EventArgs e)
		{
			fQuanlyduyetnghiphep f = new fQuanlyduyetnghiphep(); 
			this.Hide();
			f.ShowDialog();
			this.Show();
		}

		private void btn_quanlybangcong_Click(object sender, EventArgs e)
		{
			fBangcong f = new fBangcong();
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

		private void btn_duyetnghiphep_MouseEnter(object sender, EventArgs e)
		{
			btn_duyetnghiphep.BackColor = System.Drawing.Color.LightBlue;
		}
		private void btn_duyetnghiphep_MouseLeave(object sender, EventArgs e)
		{
			btn_duyetnghiphep.BackColor = originalDuyetnghiphepButtonColor;
		}

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
		private void btn_quanlylichpv_MouseEnter(object sender, EventArgs e)
		{
			btn_quanlylichpv.BackColor = System.Drawing.Color.LightBlue;
		}
		private void btn_quanlylichpv_MouseLeave(object sender, EventArgs e)
		{
			btn_quanlylichpv.BackColor = originalLichphongvanButtonColor;
		}

		private void btn_quanlyketquaphongvan_MouseEnter(object sender, EventArgs e)
		{
			btn_quanlyketquaphongvan.BackColor = System.Drawing.Color.LightBlue;
		}
		private void btn_quanlyketquaphongvan_MouseLeave(object sender, EventArgs e)
		{
			btn_quanlyketquaphongvan.BackColor = originalKetquaButtonColor;
		}

		private void btn_quanlynguonungvien_MouseEnter(object sender, EventArgs e)
		{
			btn_quanlynguonungvien.BackColor = System.Drawing.Color.LightBlue;
		}
		private void btn_quanlynguonungvien_MouseLeave(object sender, EventArgs e)
		{
			btn_quanlynguonungvien.BackColor = originalNguonungvienButtonColor;
		}
		private void btn_quanlyhosoungvien_MouseEnter(object sender, EventArgs e)
		{
			btn_quanlyhosoungvien.BackColor = System.Drawing.Color.LightBlue;
		}
		private void btn_quanlyhosoungvien_MouseLeave(object sender, EventArgs e)
		{
			btn_quanlyhosoungvien.BackColor = originalHosoungvienButtonColor;
		}

		#endregion

		#region compensation
		private void btn_quanlybangluong_Click(object sender, EventArgs e)
		{
			fBangluong f = new fBangluong();
			this.Hide();
			f.ShowDialog();
			this.Show();
		}


		private void btn_qlkhenthuongkyluat_Click(object sender, EventArgs e)
		{
			fQuanlykhenthuongkyluat f = new fQuanlykhenthuongkyluat();
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
		private void btn_quanlyphucap_Click(object sender, EventArgs e)
		{
			fQuanlyphucap f = new fQuanlyphucap();
			this.Hide();
			f.ShowDialog();
			this.Show();
		}

		private void btn_quanlybaohiem_Click(object sender, EventArgs e)
		{
			fQuanlybaohiem f = new fQuanlybaohiem();
			this.Hide();
			f.ShowDialog();
			this.Show();
		}

		#endregion

		private void tc_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void btn_thongketuyendung_Click(object sender, EventArgs e)
		{
			fThongketuyendung f = new fThongketuyendung();
			this.Hide();
			f.ShowDialog();
			this.Show();
		}


	}
}
