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
		private Color originalAddButtonColor;
		private Color originalEditButtonColor;
		private Color originalDeleteButtonColor;
		private Color originalFindButtonColor;
		private Color originalCloseButtonColor;

		BindingSource commendationList = new BindingSource();

		public fQuanlykhenthuongkyluatUser(string manv)
		{
			InitializeComponent();
			dgv_khenthuongkyluat.DataSource = commendationList;
			LoadCommendation(manv);
			originalCloseButtonColor = btn_dongkhenthuongkyluat.BackColor;
			txb_manhanvien.Text = manv;
			LoadTenNV(manv);
		}

		void LoadTenNV(string manv)
		{
			txb_tennhanvien.Text = NhanvienDAO.Instance.GetStaffTen(manv);
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
		//void LoadCbHinhThuc()
		//{
		//	List<KeyValuePair<int, string>> hinhthuc = new List<KeyValuePair<int, string>>()
		//	{
		//		new KeyValuePair<int, string>(1, "Khen thưởng"),
		//		new KeyValuePair<int, string>(0, "Kỷ luật")
		//	};
		//	cb_hinhthuc.DataSource = hinhthuc;
		//	cb_hinhthuc.DisplayMember = "Value";
		//	cb_hinhthuc.ValueMember = "Key";
		//}
		#region Events
		//private void btn_findnv_Click(object sender, EventArgs e)
		//{
		//	LoadCommendation(txb_manhanvien.Text);
		//}

		//private void btn_addkt_Click(object sender, EventArgs e)
		//{
		//	string manv = txb_manhanvien.Text;
		//	try
		//	{
		//		string noidung = txb_noidung.Text;
		//		int hinhthuc = (int)cb_hinhthuc.SelectedValue;
		//		DateTime thoigian = dtp_thoigian.Value;
		//		string tennv = txb_tennhanvien.Text;

		//		if (KhenthuongkyluatDAO.Instance.InsertCommendation(manv, noidung, hinhthuc, thoigian))
		//		{
		//			MessageBox.Show("Thêm khen thưởng/kỷ luật thành công", "Thông báo");
		//			LoadCommendation(manv);
		//		}
		//		else
		//		{
		//			MessageBox.Show("Thêm khen thưởng/kỷ luật thất bại", "Thông báo");
		//		}
		//	}
		//	catch (Exception ex)
		//	{
		//		MessageBox.Show("Hãy nhập mã nhân viên!", "Thông báo");
		//	}
		//	finally
		//	{
		//		LoadCommendation(manv);
		//	}
		//}

		//private void btn_editkt_Click(object sender, EventArgs e)
		//{
		//	string manv = txb_manhanvien.Text;
		//	try
		//	{
		//		string maktkl = dgv_khenthuongkyluat.CurrentRow.Cells["MaKTKL"].Value.ToString();
		//		string noidung = txb_noidung.Text;
		//		int hinhthuc = (int)cb_hinhthuc.SelectedValue;
		//		DateTime thoigian = dtp_thoigian.Value;
		//		string tennv = txb_tennhanvien.Text;

		//		if (KhenthuongkyluatDAO.Instance.UpdateCommendation(maktkl, noidung, hinhthuc, thoigian))
		//		{
		//			MessageBox.Show("Sửa khen thưởng/kỷ luật thành công.", "Thông báo");
		//		}
		//		else
		//		{
		//			MessageBox.Show("Sửa khen thưởng/kỷ luật thất bại.", "Thông báo");
		//		}
		//	}
		//	catch (Exception ex)
		//	{
		//		MessageBox.Show("Error: " + ex.Message, "ThongBao", MessageBoxButtons.OK, MessageBoxIcon.Error);
		//	}
		//	finally
		//	{
		//		LoadCommendation(manv);
		//	}
		//}

		//private void btn_deletekt_Click(object sender, EventArgs e)
		//{
		//	string manv = txb_manhanvien.Text;
		//	try
		//	{
		//		string matd = dgv_khenthuongkyluat.CurrentRow.Cells["MaKTKL"].Value.ToString(); ;
		//		if (KhenthuongkyluatDAO.Instance.DeleteCommendation(matd))
		//		{
		//			MessageBox.Show("Xóa khen thưởng/kỷ luật thành công.", "Thông báo");
		//		}
		//		else
		//		{
		//			MessageBox.Show("Xóa khen thưởng/kỷ luật thất bại.", "Thông báo");
		//		}
		//	}
		//	catch (Exception ex)
		//	{
		//		MessageBox.Show("Error: " + ex.Message, "ThongBao", MessageBoxButtons.OK, MessageBoxIcon.Error);
		//	}
		//	finally
		//	{
		//		LoadCommendation(manv);
		//	}
		//}

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

		private void btn_dongkhenthuongkyluat_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
