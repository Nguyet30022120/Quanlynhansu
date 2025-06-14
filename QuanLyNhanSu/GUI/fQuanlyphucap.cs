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
	public partial class fQuanlyphucap : Form
	{
		private Color originalAddButtonColor;
		private Color originalEditButtonColor;
		private Color originalDeleteButtonColor;
		private Color originalCloseButtonColor;
		private Color originalSearchButtonColor;

		BindingSource phucapList = new BindingSource();
		public fQuanlyphucap()
		{
			InitializeComponent();
			dgv_phucap.DataSource = phucapList;
			originalAddButtonColor = btn_themphucap.BackColor;
			originalEditButtonColor = btn_suaphucap.BackColor;
			originalDeleteButtonColor = btn_xoaphucap.BackColor;
			originalCloseButtonColor = btn_dongphucap.BackColor;
			originalSearchButtonColor = btn_timmanhanvien.BackColor;

		}

		void BindingPhuCapData()
		{

			txb_tennhanvien.DataBindings.Clear();
			cb_loaiphucap.DataBindings.Clear();
			txb_tienphucap.DataBindings.Clear();

			txb_tennhanvien.DataBindings.Add(new Binding("Text", dgv_phucap.DataSource, "TenNV", true, DataSourceUpdateMode.Never));
			cb_loaiphucap.DataBindings.Add(new Binding("Text", dgv_phucap.DataSource, "LoaiPhuCap", true, DataSourceUpdateMode.Never));
			txb_tienphucap.DataBindings.Add(new Binding("Text", dgv_phucap.DataSource, "SoTienPhuCap", true, DataSourceUpdateMode.Never));
		}
		void LoadPhuCap(string manv)
		{
			phucapList.DataSource = PhucapDAO.Instance.GetListPhuCap(manv);
			BindingPhuCapData();
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

		#region Events
		private void btn_timmanhanvien_Click(object sender, EventArgs e)
		{
			string manv = txb_manhanvien.Text.Trim();
			LoadPhuCap(manv);
			if (!string.IsNullOrEmpty(manv))
			{
				LoadTenNV(manv);
			}
		}

		private void btn_themphucap_Click(object sender, EventArgs e)
		{
			string manv = txb_manhanvien.Text;
			try
			{
				string loaipc = cb_loaiphucap.Text;
				decimal tienpc = txb_tienphucap.Text == "" ? 0 : Convert.ToDecimal(txb_tienphucap.Text);

				if (PhucapDAO.Instance.InsertPhuCap(manv, loaipc, tienpc))
				{
					MessageBox.Show("Thêm phụ cấp thành công","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
					LoadPhuCap(manv);
				}
				else
				{
					MessageBox.Show("Thêm phụ cấp thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Không tìm thấy mã nhân viên trong hệ thống!","Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
			}
			finally
			{
				LoadPhuCap(manv);
			}
		}

		private void btn_suaphucap_Click(object sender, EventArgs e)
		{
			string manv = txb_manhanvien.Text;
			try
			{
				string mapc = dgv_phucap.CurrentRow.Cells["MaPhuCap"].Value.ToString();
				string loaipc = cb_loaiphucap.Text;
				decimal tienpc = txb_tienphucap.Text == "" ? 0 : Convert.ToDecimal(txb_tienphucap.Text);

				if (PhucapDAO.Instance.UpdatePhuCap(mapc, loaipc, manv, tienpc))
				{
					MessageBox.Show("Sửa phụ cấp thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				else
				{
					MessageBox.Show("Sửa phụ cấp thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				LoadPhuCap(manv);
			}
		}

		private void btn_xoaphucap_Click(object sender, EventArgs e)
		{
			string manv = txb_manhanvien.Text;
			try
			{
				string mapc = dgv_phucap.CurrentRow.Cells["MaPhuCap"].Value.ToString();
				if (PhucapDAO.Instance.DeletePhuCap(mapc))
				{
					MessageBox.Show("Xóa phụ cấp thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
				}
				else
				{
					MessageBox.Show("Xóa phụ cấp thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				LoadPhuCap(manv);
			}
		}

		private void btn_dongphucap_Click(object sender, EventArgs e)
		{
			this.Close();
		}
		#endregion

		#region Hover
		private void btn_themphucap_MouseEnter(object sender, EventArgs e)
		{
			btn_themphucap.BackColor = Color.LightBlue;
		}
		private void btn_themphucap_MouseLeave(object sender, EventArgs e)
		{
			btn_themphucap.BackColor = originalAddButtonColor;
		}
		private void btn_suaphucap_MouseEnter(object sender, EventArgs e)
		{
			btn_suaphucap.BackColor = Color.LightBlue;
		}
		private void btn_suaphucap_MouseLeave(object sender, EventArgs e)
		{
			btn_suaphucap.BackColor = originalEditButtonColor;
		}
		private void btn_xoaphucap_MouseEnter(object sender, EventArgs e)
		{
			btn_xoaphucap.BackColor = Color.LightBlue;
		}
		private void btn_xoaphucap_MouseLeave(object sender, EventArgs e)
		{
			btn_xoaphucap.BackColor = originalDeleteButtonColor;
		}
		private void btn_dongphucap_MouseEnter(object sender, EventArgs e)
		{
			btn_dongphucap.BackColor = Color.LightBlue;
		}
		private void btn_dongphucap_MouseLeave(object sender, EventArgs e)
		{
			btn_dongphucap.BackColor = originalCloseButtonColor;
		}
		private void btn_timmanhanvien_MouseEnter(object sender, EventArgs e)
		{
			btn_timmanhanvien.BackColor = Color.LightBlue;
		}
		private void btn_timmanhanvien_MouseLeave(object sender, EventArgs e)
		{
			btn_timmanhanvien.BackColor = originalSearchButtonColor;
		}
		#endregion

	}
}
