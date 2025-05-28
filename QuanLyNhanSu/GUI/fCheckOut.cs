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
	public partial class fCheckOut : Form
	{
		BindingSource checkoutList = new BindingSource();
		public fCheckOut()
		{
			InitializeComponent();
			lb_giocheckout.Text = DateTime.Now.ToLongTimeString();
			giocheckout.Start();
			dgv_checkout.DataSource = checkoutList;
			var col = dgv_checkout.Columns["GioCheckOut"];
			if (col != null)
				col.DefaultCellStyle.Format = "HH:mm:ss";
		}

		private void giocheckout_Tick(object sender, EventArgs e)
		{
			lb_giocheckout.Text = DateTime.Now.ToLongTimeString();
		}
		void LoadTenNV()
		{
			lb_tennhanvien.DataBindings.Clear();
			lb_tennhanvien.DataBindings.Add(new Binding("Text", dgv_checkout.DataSource, "TenNV", true, DataSourceUpdateMode.Never));
		}
		void LoadCheckOut(string manv)
		{
			checkoutList.DataSource = CheckoutDAO.Instance.GetCheckOutByMaNV(manv);
		}

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
				if (CheckoutDAO.Instance.InsertCheckOut(manv))
				{
					MessageBox.Show("Thêm checkout thành công");
					LoadCheckOut(txb_manhanvien.Text);
				}
				else
				{
					MessageBox.Show("Thêm checkout thất bại");
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

		private void btn_editcheckout_Click(object sender, EventArgs e)
		{
			DialogResult result = MessageBox.Show("Bạn có muốn sửa checkout cho nhân viên này?",
							"Xác nhận",
							MessageBoxButtons.YesNo,
							MessageBoxIcon.Question);

			if (result == DialogResult.Yes)
			{
				string manv = txb_manhanvien.Text;
				fSuaCheckout editCheckout = new fSuaCheckout(manv);
				editCheckout.ShowDialog();
			}
			else if (result == DialogResult.No)
			{
			}
		}

		private void btn_deletecheckout_Click(object sender, EventArgs e)
		{
			try
			{
				int macheckout = Convert.ToInt32(dgv_checkout.CurrentRow.Cells["MaCheckOut"].Value);
				if (CheckoutDAO.Instance.DeleteCheckOut(macheckout))
				{
					MessageBox.Show("Xóa checkout thành công");
					LoadCheckOut(txb_manhanvien.Text);
				}
				else
				{
					MessageBox.Show("Xóa checkout thất bại");
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
	}
}
