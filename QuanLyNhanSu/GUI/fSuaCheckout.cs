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
	public partial class fSuaCheckout : Form
	{
		BindingSource checkoutList = new BindingSource();
		public fSuaCheckout(string manv)
		{
			InitializeComponent();
			LoadDataCheckOut(manv);
		}
		void LoadDataCheckOut(string manv)
		{
			List<CheckoutDTO> data = CheckoutDAO.Instance.GetCheckOutByMaNV(manv);

			if (data.Count > 0)
			{
				CheckoutDTO checkout = data[0];
				txb_manv.Text = checkout.MaNV;
				txb_tennv.Text = checkout.TenNV;
				dtp_giocheckout.Value = DateTime.Today.Add(checkout.GioCheckOut);
				dtp_ngaycheckout.Value = checkout.NgayCheckOut;
			}
			else
			{
				MessageBox.Show("Không tìm thấy dữ liệu ứng viên.");
			}
		}
		void LoadCheckOut(string manv)
		{
			checkoutList.DataSource = CheckoutDAO.Instance.GetCheckOutByMaNV(manv);
		}

		private void btn_editcheckout_Click_1(object sender, EventArgs e)
		{
			try
			{
				string manv = txb_manv.Text;
				string tennv = txb_tennv.Text;
				DateTime thoigiancheckout = dtp_giocheckout.Value;
				DateTime ngaycheckout = dtp_ngaycheckout.Value;

				if (CheckoutDAO.Instance.UpdateCheckOut(manv, thoigiancheckout, ngaycheckout))
				{
					MessageBox.Show("Sửa checkout thành công.");
					LoadCheckOut(txb_manv.Text);
				}
				else
				{
					MessageBox.Show("Sửa checkout thất bại.");
				}

			}
			catch (Exception ex)
			{
				MessageBox.Show("Error: " + ex.Message, "ThongBao", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				LoadCheckOut(txb_manv.Text);
			}
		}

		private void btn_closecheckout_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}

}

