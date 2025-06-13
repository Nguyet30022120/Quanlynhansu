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
	public partial class fQuanlybaohiem : Form
	{
		private Color originalAddButtonColor;
		private Color originalEditButtonColor;
		private Color originalDeleteButtonColor;
		private Color originalFindButtonColor;
		private Color originalCloseButtonColor;

		BindingSource insuranceList = new BindingSource();
		public fQuanlybaohiem()
		{
			InitializeComponent();
			dgv_baohiem.DataSource = insuranceList;
			originalAddButtonColor = btn_thembaohiem.BackColor;
			originalEditButtonColor = btn_suabaohiem.BackColor;
			originalDeleteButtonColor = btn_xoabaohiem.BackColor;
			originalFindButtonColor = btn_timnhanvien.BackColor;
			originalCloseButtonColor = btn_dongbaohiem.BackColor;
		}

		void BindingInsuranceData()
		{
			
			txb_tennhanvien.DataBindings.Clear();
			cb_loaibaohiem.DataBindings.Clear();
			dtp_ngaybatdau.DataBindings.Clear();
			dtp_ngayketthuc.DataBindings.Clear();
			txb_mota.DataBindings.Clear();
			txb_tienbaohiem.DataBindings.Clear();

			txb_tennhanvien.DataBindings.Add(new Binding("Text", dgv_baohiem.DataSource, "TenNV", true, DataSourceUpdateMode.Never));
			cb_loaibaohiem.DataBindings.Add(new Binding("Text", dgv_baohiem.DataSource, "LoaiBH", true, DataSourceUpdateMode.Never));
			txb_mota.DataBindings.Add(new Binding("Text", dgv_baohiem.DataSource, "MoTa", true, DataSourceUpdateMode.Never));
			dtp_ngaybatdau.DataBindings.Add(new Binding("Value", dgv_baohiem.DataSource, "NgayBD", true, DataSourceUpdateMode.Never));
			dtp_ngayketthuc.DataBindings.Add(new Binding("Value", dgv_baohiem.DataSource, "NgayKT", true, DataSourceUpdateMode.Never));
			txb_tienbaohiem.DataBindings.Add(new Binding("Text", dgv_baohiem.DataSource, "TienBH", true, DataSourceUpdateMode.Never));
		}
		void LoadInsurance(string manv)
		{
			insuranceList.DataSource = BaohiemDAO.Instance.GetListInsurance(manv);
			BindingInsuranceData();
		}
		#region Events
		private void btn_findmanv_Click(object sender, EventArgs e)
		{
			LoadInsurance(txb_manhanvien.Text);
		}

		private void btn_addbh_Click(object sender, EventArgs e)
		{
			string manv = txb_manhanvien.Text;
			try
			{
				string loaibh = cb_loaibaohiem.Text;
				string mota = txb_mota.Text;
				DateTime ngaybd = dtp_ngaybatdau.Value;
				DateTime ngaykt = dtp_ngayketthuc.Value;
				decimal tienbh = txb_tienbaohiem.Text == "" ? 0 : Convert.ToDecimal(txb_tienbaohiem.Text);

				if (BaohiemDAO.Instance.InsertInsurance(manv, loaibh,mota,ngaybd,ngaykt,tienbh))
				{
					MessageBox.Show("Thêm bảo hiểm thành công","Thông báo");
					LoadInsurance(manv);
				}
				else
				{
					MessageBox.Show("Thêm bảo hiểm thất bại", "Thông báo");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Hãy nhập mã nhân viên!", "Thông báo");
			}
			finally
			{
				LoadInsurance(manv);
			}
		}

		private void btn_editbh_Click(object sender, EventArgs e)
		{
			string manv = txb_manhanvien.Text;
			try
			{
				string mabh = dgv_baohiem.CurrentRow.Cells["Ma_BH"].Value.ToString();
				string loaibh = cb_loaibaohiem.Text;
				string mota = txb_mota.Text;
				DateTime ngaybd = dtp_ngaybatdau.Value;
				DateTime ngaykt = dtp_ngayketthuc.Value;
				decimal tienbh = txb_tienbaohiem.Text == "" ? 0 : Convert.ToDecimal(txb_tienbaohiem.Text);

				if (BaohiemDAO.Instance.UpdateInsurance(mabh,loaibh,mota, ngaybd, ngaykt, manv, tienbh))
				{
					MessageBox.Show("Sửa bảo hiểm thành công.", "Thông báo");
				}
				else
				{
					MessageBox.Show("Sửa bảo hiểm thất bại.", "Thông báo");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error: " + ex.Message, "ThongBao", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				LoadInsurance(manv);
			}
		}

		private void btn_deletebh_Click(object sender, EventArgs e)
		{
			string manv = txb_manhanvien.Text;
			try
			{
				string mabh = dgv_baohiem.CurrentRow.Cells["Ma_BH"].Value.ToString();
				if (BaohiemDAO.Instance.DeleteInsurance(mabh))
				{
					MessageBox.Show("Xóa bảo hiểm thành công.", "Thông báo");
				}
				else
				{
					MessageBox.Show("Xóa bảo hiểm thất bại.", "Thông báo");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error: " + ex.Message, "ThongBao", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				LoadInsurance(manv);
			}
		}

		private void btn_closebh_Click(object sender, EventArgs e)
		{
			this.Close();
		}
		#endregion

		#region Hover
		private void btn_thembaohiem_MouseEnter(object sender, EventArgs e)
		{
			btn_thembaohiem.BackColor = Color.LightBlue;
		}
		private void btn_thembaohiem_MouseLeave(object sender, EventArgs e)
		{
			btn_thembaohiem.BackColor = originalAddButtonColor;
		}
		private void btn_suabaohiem_MouseEnter(object sender, EventArgs e)
		{
			btn_suabaohiem.BackColor = Color.LightBlue;
		}
		private void btn_suabaohiem_MouseLeave(object sender, EventArgs e)
		{
			btn_suabaohiem.BackColor = originalEditButtonColor;
		}
		private void btn_xoabaohiem_MouseEnter(object sender, EventArgs e)
		{
			btn_xoabaohiem.BackColor = Color.LightBlue;
		}
		private void btn_xoabaohiem_MouseLeave(object sender, EventArgs e)
		{
			btn_xoabaohiem.BackColor = originalDeleteButtonColor;
		}
		private void btn_timnhanvien_MouseEnter(object sender, EventArgs e)
		{
			btn_timnhanvien.BackColor = Color.LightBlue;
		}
		private void btn_timnhanvien_MouseLeave(object sender, EventArgs e)
		{
			btn_timnhanvien.BackColor = originalFindButtonColor;
		}
		private void btn_dongbaohiem_MouseEnter(object sender, EventArgs e)
		{
			btn_dongbaohiem.BackColor = Color.LightBlue;
		}
		private void btn_dongbaohiem_MouseLeave(object sender, EventArgs e)
		{
			btn_dongbaohiem.BackColor = originalCloseButtonColor;
		}
		#endregion
	}
}
