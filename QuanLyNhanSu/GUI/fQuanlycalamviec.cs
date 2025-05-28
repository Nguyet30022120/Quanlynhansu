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
	public partial class fQuanlycalamviec : Form
	{
		BindingSource loaicaList = new BindingSource();
		public fQuanlycalamviec()
		{
			InitializeComponent();
			dgv_calamviec.DataSource = loaicaList;
			LoadLoaiCa();
			BindingCaLamViecData();
		}
		void BindingCaLamViecData()
		{
			txb_loaica.DataBindings.Add(new Binding("Text", dgv_calamviec.DataSource, "TenLoaiCa", true, DataSourceUpdateMode.Never));
			txb_heso.DataBindings.Add(new Binding("Text", dgv_calamviec.DataSource, "HeSo", true, DataSourceUpdateMode.Never));
		}
		void LoadLoaiCa()
		{
			loaicaList.DataSource = LoaicaDAO.Instance.GetListLoaiCa();
		}

		private void btn_addca_Click(object sender, EventArgs e)
		{
			try
			{
				string loaica = txb_loaica.Text;
				decimal heso = Convert.ToDecimal(txb_heso.Text);

				if (LoaicaDAO.Instance.InsertLoaiCa(loaica, heso))
				{
					MessageBox.Show("Thêm ca thành công");
					LoadLoaiCa();
				}
				else
				{
					MessageBox.Show("Thêm ca thất bại");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error: " + ex.Message, "ThongBao", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				LoadLoaiCa();
			}
		}

		private void btn_editca_Click(object sender, EventArgs e)
		{
			try
			{
				int maloaica = Convert.ToInt32(dgv_calamviec.CurrentRow.Cells["MaLoaiCa"].Value);
				string loaica = txb_loaica.Text;
				decimal heso = Convert.ToDecimal(txb_heso.Text);

				if (LoaicaDAO.Instance.UpdateLoaiCa(maloaica,loaica, heso))
				{
					MessageBox.Show("Sửa ca thành công");
					LoadLoaiCa();
				}
				else
				{
					MessageBox.Show("Sửa ca thất bại");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error: " + ex.Message, "ThongBao", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				LoadLoaiCa();
			}
		}

		private void btn_deleteca_Click(object sender, EventArgs e)
		{
			try
			{
				int maloaica = Convert.ToInt32(dgv_calamviec.CurrentRow.Cells["MaLoaiCa"].Value);

				if (LoaicaDAO.Instance.DeleteLoaiCa(maloaica))
				{
					MessageBox.Show("Xóa ca thành công");
					LoadLoaiCa();
				}
				else
				{
					MessageBox.Show("Xóa ca thất bại");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error: " + ex.Message, "ThongBao", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				LoadLoaiCa();
			}
		}

		private void btn_closeca_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}
}
