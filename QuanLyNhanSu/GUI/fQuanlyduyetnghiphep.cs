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
	public partial class fQuanlyduyetnghiphep : Form
	{
		BindingSource duyetDonNghiPhepList = new BindingSource();

		private List<string> staffNames = new List<string>();

		public fQuanlyduyetnghiphep()
		{
			InitializeComponent();
			dgv_duyetdonnghiphep.DataSource = duyetDonNghiPhepList;
			LoadDonNghiPhep();
		}
		void BindingDonNghiPhepData()
		{
			txb_madonnghiphep.DataBindings.Clear();
			txb_madonnghiphep.DataBindings.Add(new Binding("Text", dgv_duyetdonnghiphep.DataSource, "MaDonNghiPhep", true, DataSourceUpdateMode.Never));
		}
		void LoadDonNghiPhep()
		{
			duyetDonNghiPhepList.DataSource = DonnghiphepDAO.Instance.GetDonNghiPhepCanDuyet();
			BindingDonNghiPhepData();
		}
		private void btn_dong_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btn_duyet_Click(object sender, EventArgs e)
		{
			try
			{
				int madon = txb_madonnghiphep.Text == "" ? 0 : Convert.ToInt32(txb_madonnghiphep.Text);

				if (DonnghiphepDAO.Instance.DuyetDonNghiPhep(madon))
				{
					MessageBox.Show("Duyệt đơn nghỉ phép thành công");
					LoadDonNghiPhep();
				}
				else
				{
					MessageBox.Show("Duyệt đơn nghỉ phép thất bại");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error: " + ex.Message, "ThongBao", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				LoadDonNghiPhep();
			}
		}

		private void btn_tuchoi_Click(object sender, EventArgs e)
		{
			try
			{
				int madon = txb_madonnghiphep.Text == "" ? 0 : Convert.ToInt32(txb_madonnghiphep.Text);

				if (DonnghiphepDAO.Instance.TuChoiDonNghiPhep(madon))
				{
					MessageBox.Show("Từ chối đơn nghỉ phép thành công");
					LoadDonNghiPhep();
				}
				else
				{
					MessageBox.Show("Từ chối đơn nghỉ phép thất bại");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error: " + ex.Message, "ThongBao", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				LoadDonNghiPhep();
			}
		}

		private void btn_timkiemdonnghiphep_Click(object sender, EventArgs e)
		{
			duyetDonNghiPhepList.DataSource = DonnghiphepDAO.Instance.SearchDonnghiphep(txb_timkiemdonnghiphep.Text);
		}
	}
}
