using QuanLyNhanSu.DAO;
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
	public partial class fQuanlykhenthuongkyluatUser : Form
	{

		private Color originalCloseButtonColor;

		BindingSource commendationList = new BindingSource();

		public fQuanlykhenthuongkyluatUser(string manv)
		{
			InitializeComponent();
			dgv_khenthuongkyluat.DataSource = commendationList;
			LoadCommendation(manv);
			txb_manhanvien.Text = manv;
			LoadTenNV(manv);
		}

		void LoadTenNV(string manv)
		{
			string tenNV = NhanvienDAO.Instance.GetStaffTen(manv);

			if (string.IsNullOrEmpty(tenNV))
			{
				MessageBox.Show("Không có mã nhân viên trong hệ thống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
				txb_tennhanvien.Text = "";
			}
			else
			{
				txb_tennhanvien.Text = tenNV;
			}
		}

		void BindingCommendationData()
		{

			txb_tennhanvien.DataBindings.Clear();
			txb_noidung.DataBindings.Clear();
			txb_hinhthuc.DataBindings.Clear();
			txb_thoigian.DataBindings.Clear();
			txb_tennhanvien.DataBindings.Add(new Binding("Text", dgv_khenthuongkyluat.DataSource, "TenNV", true, DataSourceUpdateMode.Never));
			txb_noidung.DataBindings.Add(new Binding("Text", dgv_khenthuongkyluat.DataSource, "NoiDung", true, DataSourceUpdateMode.Never));
			txb_hinhthuc.DataBindings.Add(new Binding("Text", dgv_khenthuongkyluat.DataSource, "HinhThuc", true, DataSourceUpdateMode.Never));
			txb_thoigian.DataBindings.Add(new Binding("Text", dgv_khenthuongkyluat.DataSource, "ThoiGian", true, DataSourceUpdateMode.Never));
		}
		void LoadCommendation(string manv)
		{
			commendationList.DataSource = KhenthuongkyluatDAO.Instance.GetCommendationsByMaNV(manv);
			BindingCommendationData();
		}

		#region Events
		private void btn_dongkhenthuongkyluat_Click(object sender, EventArgs e)
		{
			this.Close();
		}
		#endregion


		#region Hover

		private void btn_dongkhenthuongkyluat_MouseEnter(object sender, EventArgs e)
		{
			btn_dongkhenthuongkyluat.BackColor = Color.LightBlue;
		}
		private void btn_dongkhenthuongkyluat_MouseLeave(object sender, EventArgs e)
		{
			btn_dongkhenthuongkyluat.BackColor = originalCloseButtonColor;
		}
		#endregion


	}
}
