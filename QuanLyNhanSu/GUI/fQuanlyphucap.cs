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
		BindingSource phucapList = new BindingSource();
		public fQuanlyphucap()
		{
			InitializeComponent();
			dgv_phucap.DataSource = phucapList;

		}

		void BindingPhuCapData()
		{

			txb_tennhanvien.DataBindings.Clear();
			cb_loaipc.DataBindings.Clear();
			txb_tienpc.DataBindings.Clear();

			txb_tennhanvien.DataBindings.Add(new Binding("Text", dgv_phucap.DataSource, "TenNV", true, DataSourceUpdateMode.Never));
			cb_loaipc.DataBindings.Add(new Binding("Text", dgv_phucap.DataSource, "LoaiPhuCap", true, DataSourceUpdateMode.Never));
			txb_tienpc.DataBindings.Add(new Binding("Text", dgv_phucap.DataSource, "SoTienPhuCap", true, DataSourceUpdateMode.Never));
		}
		void LoadPhuCap(string manv)
		{
			phucapList.DataSource = PhucapDAO.Instance.GetListPhuCap(manv);
			BindingPhuCapData();
		}


		private void btn_timmanhanvien_Click(object sender, EventArgs e)
		{
			LoadPhuCap(txb_manhanvien.Text);
		}

		private void btn_themphucap_Click(object sender, EventArgs e)
		{
			string manv = txb_manhanvien.Text;
			try
			{
				string loaipc = cb_loaipc.Text;
				decimal tienpc = txb_tienpc.Text == "" ? 0 : Convert.ToDecimal(txb_tienpc.Text);

				if (PhucapDAO.Instance.InsertPhuCap(manv, loaipc, tienpc))
				{
					MessageBox.Show("Thêm phụ cấp thành công");
					LoadPhuCap(manv);
				}
				else
				{
					MessageBox.Show("Thêm phụ cấp thất bại");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error: " + ex.Message, "ThongBao", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
				string loaipc = cb_loaipc.Text;
				decimal tienpc = txb_tienpc.Text == "" ? 0 : Convert.ToDecimal(txb_tienpc.Text);

				if (PhucapDAO.Instance.UpdatePhuCap(mapc, loaipc, manv, tienpc))
				{
					MessageBox.Show("Sửa phụ cấp thành công.");
				}
				else
				{
					MessageBox.Show("Sửa phụ cấp thất bại.");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error: " + ex.Message, "ThongBao", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
					MessageBox.Show("Xóa phụ cấp thành công.");
				}
				else
				{
					MessageBox.Show("Xóa phụ cấp thất bại.");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error: " + ex.Message, "ThongBao", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
	}
}
