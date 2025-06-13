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

namespace QuanLyNhanSu
{
	public partial class fQuanlytrinhdochuyenmon : Form
	{
		private Color originalAddButtonColor;
		private Color originalEditButtonColor;
		private Color originalDeleteButtonColor;
		private Color originalFindButtonColor;
		private Color originalCloseButtonColor;

		BindingSource levelList = new BindingSource();
		public fQuanlytrinhdochuyenmon()
		{
			InitializeComponent();
			dgv_trinhdo.DataSource = levelList;
			originalAddButtonColor = btn_themtrinhdo.BackColor;
			originalEditButtonColor = btn_suatrinhdo.BackColor;
			originalDeleteButtonColor = btn_xoatrinhdo.BackColor;
			originalFindButtonColor = btn_timnhanvien.BackColor;
			originalCloseButtonColor = btn_dongtrinhdo.BackColor;

			//LoadIntialData();
		}

		void BindingLevelData()
		{
			txb_tennhanvien.DataBindings.Clear();
			cb_loaibangcap.DataBindings.Clear();
			txb_chuyennganh.DataBindings.Clear();
			txb_truonghoc.DataBindings.Clear();
			txb_tennhanvien.DataBindings.Add(new Binding("Text", dgv_trinhdo.DataSource, "TenNV", true, DataSourceUpdateMode.Never));
			cb_loaibangcap.DataBindings.Add(new Binding("Text", dgv_trinhdo.DataSource, "LoaiBC", true, DataSourceUpdateMode.Never));
			txb_chuyennganh.DataBindings.Add(new Binding("Text", dgv_trinhdo.DataSource, "ChuyenNganh", true, DataSourceUpdateMode.Never));
			txb_truonghoc.DataBindings.Add(new Binding("Text", dgv_trinhdo.DataSource, "TruongHoc", true, DataSourceUpdateMode.Never));
		}
		//void LoadIntialData()
		//{
		//	// Hiển thị "--Tất cả nhân viên--" khi mở form
		//	txb_tennhanvien.Text = "--Tất cả nhân viên--";

		//	// Gọi hàm lấy toàn bộ trình độ của tất cả nhân viên
		//	levelList.DataSource = TrinhdochuyenmonDAO.Instance.GetListTrinhDoAll();

		//	// Gán binding để hiển thị dữ liệu
		//	BindingLevelData();

		//}
		void LoadLevel(string manv)
		{
			levelList.DataSource = TrinhdochuyenmonDAO.Instance.GetListTrinhDo(manv);
			BindingLevelData();
		}
		#region Events
		private void btn_addtd_Click(object sender, EventArgs e)
		{
			string manv = txb_manhanvien.Text;
			try
			{
				string chuyennganh = txb_chuyennganh.Text;
				string loaibc = cb_loaibangcap.Text;
				string truonghoc = txb_truonghoc.Text;

				if (TrinhdochuyenmonDAO.Instance.InsertTrinhDo(manv, loaibc,chuyennganh,truonghoc))
				{
					MessageBox.Show("Thêm trình độ thành công", "Thông báo");
					LoadLevel(manv);
				}
				else
				{
					MessageBox.Show("Thêm trình độ thất bại", "Thông báo");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Hãy nhập mã nhân viên!","Thông báo");
			}
			finally
			{
				LoadLevel(manv);
			}
		}

		private void btn_edittd_Click(object sender, EventArgs e)
		{
			string manv = txb_manhanvien.Text;
			try
			{
				string matd = dgv_trinhdo.CurrentRow.Cells["MaTD"].Value.ToString();
				string loaibc = cb_loaibangcap.Text;
				string chuyennganh = txb_chuyennganh.Text;
				string truonghoc = txb_truonghoc.Text;

				if (TrinhdochuyenmonDAO.Instance.UpdateTrinhDo(matd, loaibc,chuyennganh,truonghoc))
				{
					MessageBox.Show("Sửa trình độ thành công.", "Thông báo");
				}
				else
				{
					MessageBox.Show("Sửa trình độ thất bại.", "Thông báo");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error: " + ex.Message, "ThongBao", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				LoadLevel(manv);
			}
		}

		private void btn_deletetd_Click(object sender, EventArgs e)
		{
			string manv = txb_manhanvien.Text;
			try
			{
				string matd = dgv_trinhdo.CurrentRow.Cells["MaTD"].Value.ToString(); ;
				if (TrinhdochuyenmonDAO.Instance.DeleteTrinhDo(matd))
				{
					MessageBox.Show("Xóa trình độ thành công.","Thông báo");
				}
				else
				{
					MessageBox.Show("Xóa trình độ thất bại.", "Thông báo");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error: " + ex.Message, "ThongBao", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				LoadLevel(manv);
			}
		}

		private void btn_closetd_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btn_findtd_Click(object sender, EventArgs e)
		{
			LoadLevel(txb_manhanvien.Text);
		}
		#endregion

		#region Hover
		private void btn_themtrinhdo_MouseEnter(object sender, EventArgs e)
		{
			btn_themtrinhdo.BackColor = Color.LightBlue;
		}
		private void btn_themtrinhdo_MouseLeave(object sender, EventArgs e)
		{
			btn_themtrinhdo.BackColor = originalAddButtonColor;
		}
		private void btn_suatrinhdo_MouseEnter(object sender, EventArgs e)
		{
			btn_suatrinhdo.BackColor = Color.LightBlue;
		}
		private void btn_suatrinhdo_MouseLeave(object sender, EventArgs e)
		{
			btn_suatrinhdo.BackColor = originalEditButtonColor;
		}
		private void btn_xoatrinhdo_MouseEnter(object sender, EventArgs e)
		{
			btn_xoatrinhdo.BackColor = Color.LightBlue;
		}
		private void btn_xoatrinhdo_MouseLeave(object sender, EventArgs e)
		{
			btn_xoatrinhdo.BackColor = originalDeleteButtonColor;
		}
		private void btn_timnhanvien_MouseEnter(object sender, EventArgs e)
		{
			btn_timnhanvien.BackColor = Color.LightBlue;
		}
		private void btn_timnhanvien_MouseLeave(object sender, EventArgs e)
		{
			btn_timnhanvien.BackColor = originalFindButtonColor;
		}
		private void btn_dongtrinhdo_MouseEnter(object sender, EventArgs e)
		{
			btn_dongtrinhdo.BackColor = Color.LightBlue;
		}
		private void btn_dongtrinhdo_MouseLeave(object sender, EventArgs e)
		{
			btn_dongtrinhdo.BackColor = originalCloseButtonColor;
		}
		#endregion

	}
}
