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
		BindingSource insuranceList = new BindingSource();
		public fQuanlybaohiem()
		{
			InitializeComponent();
			dgv_baohiem.DataSource = insuranceList;

		}

		void BindingInsuranceData()
		{
			// Clear old bindings
			txb_tennhanvien.DataBindings.Clear();
			cb_loaibh.DataBindings.Clear();
			dtp_ngaybd.DataBindings.Clear();
			dtp_ngaykt.DataBindings.Clear();
			txb_mota.DataBindings.Clear();

			txb_tennhanvien.DataBindings.Add(new Binding("Text", dgv_baohiem.DataSource, "TenNV", true, DataSourceUpdateMode.Never));
			cb_loaibh.DataBindings.Add(new Binding("Text", dgv_baohiem.DataSource, "LoaiBH", true, DataSourceUpdateMode.Never));
			txb_mota.DataBindings.Add(new Binding("Text", dgv_baohiem.DataSource, "MoTa", true, DataSourceUpdateMode.Never));
			dtp_ngaybd.DataBindings.Add(new Binding("Value", dgv_baohiem.DataSource, "NgayBD", true, DataSourceUpdateMode.Never));
			dtp_ngaykt.DataBindings.Add(new Binding("Value", dgv_baohiem.DataSource, "NgayKT", true, DataSourceUpdateMode.Never));
		}
		void LoadInsurance(string manv)
		{
			insuranceList.DataSource = BaohiemDAO.Instance.GetListInsurance(manv);
			BindingInsuranceData();
		}

		private void btn_findmanv_Click(object sender, EventArgs e)
		{
			LoadInsurance(txb_manhanvien.Text);
		}

		private void btn_addbh_Click(object sender, EventArgs e)
		{
			string manv = txb_manhanvien.Text;
			try
			{
				string loaibh = cb_loaibh.Text;
				string mota = txb_mota.Text;
				DateTime ngaybd = dtp_ngaybd.Value;
				DateTime ngaykt = dtp_ngaykt.Value;

				if (BaohiemDAO.Instance.InsertInsurance(manv, loaibh,mota,ngaybd,ngaykt))
				{
					MessageBox.Show("Thêm bảo hiểm thành công");
					LoadInsurance(manv);
				}
				else
				{
					MessageBox.Show("Thêm bảo hiểm thất bại");
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

		private void btn_editbh_Click(object sender, EventArgs e)
		{
			string manv = txb_manhanvien.Text;
			try
			{
				string mabh = dgv_baohiem.CurrentRow.Cells["Ma_BH"].Value.ToString();
				string loaibh = cb_loaibh.Text;
				string mota = txb_mota.Text;
				DateTime ngaybd = dtp_ngaybd.Value;
				DateTime ngaykt = dtp_ngaykt.Value;

				if (BaohiemDAO.Instance.UpdateInsurance(mabh,loaibh,mota, ngaybd, ngaykt, manv))
				{
					MessageBox.Show("Sửa bảo hiểm thành công.");
				}
				else
				{
					MessageBox.Show("Sửa bảo hiểm thất bại.");
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
					MessageBox.Show("Xóa bảo hiểm thành công.");
				}
				else
				{
					MessageBox.Show("Xóa bảo hiểm thất bại.");
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
	}
}
