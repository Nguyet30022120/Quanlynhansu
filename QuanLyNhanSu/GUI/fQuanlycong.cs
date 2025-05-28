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
	public partial class fQuanlycong : Form
	{
		BindingSource loaicongList = new BindingSource();
		public fQuanlycong()
		{
			InitializeComponent();
			dgv_quanlycong.DataSource = loaicongList;
			LoadLoaiCong();
			BindingCongData();
		}
		void BindingCongData()
		{
			txb_loaicong.DataBindings.Add(new Binding("Text", dgv_quanlycong.DataSource, "TenLoaiCong", true, DataSourceUpdateMode.Never));
			txb_heso.DataBindings.Add(new Binding("Text", dgv_quanlycong.DataSource, "HeSo", true, DataSourceUpdateMode.Never));
		}
		void LoadLoaiCong()
		{
			loaicongList.DataSource = LoaicongDAO.Instance.GetListLoaiCong();
		}

		private void btn_addcong_Click(object sender, EventArgs e)
		{
			try
			{
				string loaicong = txb_loaicong.Text;
				decimal heso = Convert.ToDecimal(txb_heso.Text);

				if (LoaicongDAO.Instance.InsertLoaiCong(loaicong, heso))
				{
					MessageBox.Show("Thêm công thành công");
					LoadLoaiCong();
				}
				else
				{
					MessageBox.Show("Thêm công thất bại");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error: " + ex.Message, "ThongBao", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				LoadLoaiCong();
			}
		}

		private void btn_editcong_Click(object sender, EventArgs e)
		{
			try
			{
				int maloaicong = Convert.ToInt32(dgv_quanlycong.CurrentRow.Cells["MaLoaiCong"].Value);
				string loaicong = txb_loaicong.Text;
				decimal heso = Convert.ToDecimal(txb_heso.Text);

				if (LoaicongDAO.Instance.UpdateLoaiCong(maloaicong, loaicong, heso))
				{
					MessageBox.Show("Sửa công thành công");
					LoadLoaiCong();
				}
				else
				{
					MessageBox.Show("Sửa công thất bại");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error: " + ex.Message, "ThongBao", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				LoadLoaiCong();
			}
		}

		private void btn_deletecong_Click(object sender, EventArgs e)
		{
			try
			{
				int maloaicong = Convert.ToInt32(dgv_quanlycong.CurrentRow.Cells["MaLoaiCong"].Value);

				if (LoaicongDAO.Instance.DeleteLoaiCong(maloaicong))
				{
					MessageBox.Show("Xóa công thành công");
					LoadLoaiCong();
				}
				else
				{
					MessageBox.Show("Xóa công thất bại");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error: " + ex.Message, "ThongBao", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				LoadLoaiCong();
			}
		}

		private void btn_closecong_Click(object sender, EventArgs e)
		{
			this.Close();
		}

	}
}
