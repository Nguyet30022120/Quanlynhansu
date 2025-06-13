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
	public partial class fCheckout : Form
	{
		private Color originalAddButtonColor;
		private Color originalDeleteButtonColor;
		private Color originalCloseButtonColor;
		private Color originalSearchButtonColor;

		BindingSource checkoutList = new BindingSource();
		public fCheckout()
		{
			InitializeComponent();
			lb_giocheckout.Text = DateTime.Now.ToLongTimeString();
			giocheckout.Start();
			dgv_checkout.DataSource = checkoutList;
			var col = dgv_checkout.Columns["GioCheckOut"];
			if (col != null)
				col.DefaultCellStyle.Format = "HH:mm:ss";
			originalSearchButtonColor = btn_timnhanvien.BackColor;
			originalAddButtonColor = btn_checkout.BackColor;
			originalDeleteButtonColor = btn_xoacheckout.BackColor;
			originalCloseButtonColor = btn_dongcheckout.BackColor;
		}

		private void giocheckout_Tick(object sender, EventArgs e)
		{
			lb_giocheckout.Text = DateTime.Now.ToLongTimeString();
		}
		void LoadTenNV()
		{
			txb_tennhanvien.DataBindings.Clear();
			txb_tennhanvien.DataBindings.Add(new Binding("Text", dgv_checkout.DataSource, "TenNV", true, DataSourceUpdateMode.Never));
		}
		void LoadCheckOut(string manv)
		{
			checkoutList.DataSource = CheckoutDAO.Instance.GetCheckOutByMaNV(manv);
		}
		#region Events
		private void btn_findnv_Click(object sender, EventArgs e)
		{
			try
			{
				LoadCheckOut(txb_manhanvien.Text);
				LoadTenNV();
			}
			catch (Exception ex)
			{
				MessageBox.Show("Lỗi tìm kiếm nhân viên: " + ex.Message, "ThongBao", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btn_checkout_Click(object sender, EventArgs e)
		{
			try
			{
				string manv = txb_manhanvien.Text;
				var list = CheckoutDAO.Instance.GetCheckOutByMaNV(manv);
				bool daCheckOut = list.Any(c => c.NgayCheckOut.Date == DateTime.Now.Date);

				if (daCheckOut)
				{
					MessageBox.Show("Nhân viên đã checkout hôm nay!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
					return;
				}

				if (CheckoutDAO.Instance.InsertCheckOut(manv))
				{
					MessageBox.Show("Thêm checkout thành công.", "Thông báo");
					LoadCheckOut(txb_manhanvien.Text);
				}
				else
				{
					MessageBox.Show("Thêm checkout thất bại.", "Thông báo");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show(ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				LoadCheckOut(txb_manhanvien.Text);
			}
		}


		private void btn_deletecheckout_Click(object sender, EventArgs e)
		{
			try
			{
				int macheckout = Convert.ToInt32(dgv_checkout.CurrentRow.Cells["MaCheckOut"].Value);
				if (CheckoutDAO.Instance.DeleteCheckOut(macheckout))
				{
					MessageBox.Show("Xóa checkout thành công.", "Thông báo");
					LoadCheckOut(txb_manhanvien.Text);
				}
				else
				{
					MessageBox.Show("Xóa checkout thất bại.", "Thông báo");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error: " + ex.Message, "ThongBao", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				LoadCheckOut(txb_manhanvien.Text);
			}
		}

		private void btn_closecheckout_Click(object sender, EventArgs e)
		{
			this.Close();
		}
		#endregion

		#region Hover
		private void btn_timnhanvien_MouseEnter(object sender, EventArgs e)
		{
			btn_timnhanvien.BackColor = Color.LightBlue;
		}
		private void btn_timnhanvien_MouseLeave(object sender, EventArgs e)
		{
			btn_timnhanvien.BackColor = originalSearchButtonColor;
		}
		private void btn_checkout_MouseEnter(object sender, EventArgs e)
		{
			btn_checkout.BackColor = Color.LightBlue;
		}
		private void btn_checkout_MouseLeave(object sender, EventArgs e)
		{
			btn_checkout.BackColor = originalAddButtonColor;
		}
		private void btn_xoacheckout_MouseEnter(object sender, EventArgs e)
		{
			btn_xoacheckout.BackColor = Color.LightBlue;
		}
		private void btn_xoacheckout_MouseLeave(object sender, EventArgs e)
		{
			btn_xoacheckout.BackColor = originalDeleteButtonColor;
		}
		private void btn_dongcheckout_MouseEnter(object sender, EventArgs e)
		{
			btn_dongcheckout.BackColor = Color.LightBlue;
		}
		private void btn_dongcheckout_MouseLeave(object sender, EventArgs e)
		{
			btn_dongcheckout.BackColor = originalCloseButtonColor;
		}
		#endregion
	}
}
