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
	public partial class fQuanlykhenthuongkyluat : Form
	{
		private Color originalAddButtonColor;
		private Color originalEditButtonColor;
		private Color originalDeleteButtonColor;
		private Color originalFindButtonColor;
		private Color originalCloseButtonColor;

		BindingSource commendationList = new BindingSource();

		public fQuanlykhenthuongkyluat()
		{
			InitializeComponent();
			dgv_khenthuongkyluat.DataSource = commendationList;
			LoadCbHinhThuc();
			originalAddButtonColor = btn_themkhenthuongkyluat.BackColor;
			originalEditButtonColor = btn_suakhenthuongkyluat.BackColor;
			originalDeleteButtonColor = btn_xoakhenthuongkyluat.BackColor;
			originalFindButtonColor = btn_timnhanvien.BackColor;
			originalCloseButtonColor = btn_dongkhenthuongkyluat.BackColor;
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
			cb_hinhthuc.DataBindings.Clear();
			dtp_thoigian.DataBindings.Clear();
			txb_tennhanvien.DataBindings.Add(new Binding("Text", dgv_khenthuongkyluat.DataSource, "TenNV", true, DataSourceUpdateMode.Never));
			txb_noidung.DataBindings.Add(new Binding("Text", dgv_khenthuongkyluat.DataSource, "NoiDung", true, DataSourceUpdateMode.Never));
			cb_hinhthuc.DataBindings.Add(new Binding("Text", dgv_khenthuongkyluat.DataSource, "HinhThuc", true, DataSourceUpdateMode.Never));
			dtp_thoigian.DataBindings.Add(new Binding("Value", dgv_khenthuongkyluat.DataSource, "ThoiGian", true, DataSourceUpdateMode.Never));
		}
		void LoadCommendation(string manv)
		{
			commendationList.DataSource = KhenthuongkyluatDAO.Instance.GetCommendationsByMaNV(manv);
			BindingCommendationData();
		}
		void LoadCbHinhThuc()
		{
			List<KeyValuePair<int, string>> hinhthuc = new List<KeyValuePair<int, string>>()
			{
				new KeyValuePair<int, string>(1, "Khen thưởng"),
				new KeyValuePair<int, string>(0, "Kỷ luật")
			};
			cb_hinhthuc.DataSource = hinhthuc;
			cb_hinhthuc.DisplayMember = "Value";
			cb_hinhthuc.ValueMember = "Key";
		}
		#region Events
		private void btn_findnv_Click(object sender, EventArgs e)
		{
			string manv = txb_manhanvien.Text;
			LoadCommendation(txb_manhanvien.Text);
			if (!string.IsNullOrEmpty(manv))
			{
				LoadTenNV(manv);
			}
		}

		private void btn_addkt_Click(object sender, EventArgs e)
		{
			string manv = txb_manhanvien.Text;
			try
			{
				string noidung = txb_noidung.Text;
				int hinhthuc = (int)cb_hinhthuc.SelectedValue;
				DateTime thoigian = dtp_thoigian.Value;
				string tennv = txb_tennhanvien.Text;

				if (KhenthuongkyluatDAO.Instance.InsertCommendation(manv, noidung,hinhthuc,thoigian))
				{
					MessageBox.Show("Thêm khen thưởng/kỷ luật thành công", "Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
					LoadCommendation(manv);
				}
				else
				{
					MessageBox.Show("Thêm khen thưởng/kỷ luật thành công", "Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Không tìm thấy mã nhân viên trong hệ thống!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			finally
			{
				LoadCommendation(manv);
				LoadCbHinhThuc();
			}
		}

		private void btn_editkt_Click(object sender, EventArgs e)
		{
			string manv = txb_manhanvien.Text;
			try
			{
				string maktkl = dgv_khenthuongkyluat.CurrentRow.Cells["MaKTKL"].Value.ToString();
				string noidung = txb_noidung.Text;
				int hinhthuc = (int)cb_hinhthuc.SelectedValue;
				DateTime thoigian = dtp_thoigian.Value;
				string tennv = txb_tennhanvien.Text;

				if (KhenthuongkyluatDAO.Instance.UpdateCommendation(maktkl,noidung,hinhthuc,thoigian))
				{
					MessageBox.Show("Sửa khen thưởng/kỷ luật thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				else
				{
					MessageBox.Show("Sửa khen thưởng/kỷ luật thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				LoadCommendation(manv);
				LoadCbHinhThuc();
			}
		}

		private void btn_deletekt_Click(object sender, EventArgs e)
		{
			string manv = txb_manhanvien.Text;
			try
			{
				string matd = dgv_khenthuongkyluat.CurrentRow.Cells["MaKTKL"].Value.ToString(); ;
				if (KhenthuongkyluatDAO.Instance.DeleteCommendation(matd))
				{
					MessageBox.Show("Xóa khen thưởng/kỷ luật thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				else
				{
					MessageBox.Show("Xóa khen thưởng/kỷ luật thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				LoadCommendation(manv);
				LoadCbHinhThuc();
			}
		}

		private void btn_closekt_Click(object sender, EventArgs e)
		{
			this.Close();
		}
		#endregion

		#region Hover
		private void btn_themkhenthuongkyluat_MouseEnter(object sender, EventArgs e)
		{
			btn_themkhenthuongkyluat.BackColor = Color.LightBlue;
		}
		private void btn_themkhenthuongkyluat_MouseLeave(object sender, EventArgs e)
		{
			btn_themkhenthuongkyluat.BackColor = originalAddButtonColor;
		}
		private void btn_suakhenthuongkyluat_MouseEnter(object sender, EventArgs e)
		{
			btn_suakhenthuongkyluat.BackColor = Color.LightBlue;
		}
		private void btn_suakhenthuongkyluat_MouseLeave(object sender, EventArgs e)
		{
			btn_suakhenthuongkyluat.BackColor = originalEditButtonColor;
		}
		private void btn_xoakhenthuongkyluat_MouseEnter(object sender, EventArgs e)
		{
			btn_xoakhenthuongkyluat.BackColor = Color.LightBlue;
		}
		private void btn_xoakhenthuongkyluat_MouseLeave(object sender, EventArgs e)
		{
			btn_xoakhenthuongkyluat.BackColor = originalDeleteButtonColor;
		}
		private void btn_timnhanvien_MouseEnter(object sender, EventArgs e)
		{
			btn_timnhanvien.BackColor = Color.LightBlue;
		}
		private void btn_timnhanvien_MouseLeave(object sender, EventArgs e)
		{
			btn_timnhanvien.BackColor = originalFindButtonColor;
		}
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

