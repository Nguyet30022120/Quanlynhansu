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
		private Color originalApproveButtonColor;
		private Color originalRejectButtonColor;
		private Color originalCloseButtonColor;
		private Color originalSearchButtonColor;

		BindingSource duyetDonNghiPhepList = new BindingSource();

		private List<string> staffNames = new List<string>();

		public fQuanlyduyetnghiphep()
		{
			InitializeComponent();
			dgv_duyetdonnghiphep.DataSource = duyetDonNghiPhepList;
			LoadDonNghiPhep();
			originalApproveButtonColor = btn_duyet.BackColor;
			originalRejectButtonColor = btn_tuchoi.BackColor;
			originalCloseButtonColor = btn_dong.BackColor;
			originalSearchButtonColor = btn_timkiemdonnghiphep.BackColor;
		}
		void LoadDonNghiPhep()
		{
			duyetDonNghiPhepList.DataSource = DonnghiphepDAO.Instance.GetDonNghiPhepCanDuyet();
		}
		#region Events
		private void btn_dong_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btn_duyet_Click(object sender, EventArgs e)
		{
			try
			{
				int madon = Convert.ToInt32(dgv_duyetdonnghiphep.CurrentRow.Cells["MaDonNghiPhep"].Value);

				if (DonnghiphepDAO.Instance.DuyetDonNghiPhep(madon))
				{
					MessageBox.Show("Duyệt đơn nghỉ phép thành công", "Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
					LoadDonNghiPhep();
				}
				else
				{
					MessageBox.Show("Duyệt đơn nghỉ phép thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
				int madon = Convert.ToInt32(dgv_duyetdonnghiphep.CurrentRow.Cells["MaDonNghiPhep"].Value);

				if (DonnghiphepDAO.Instance.TuChoiDonNghiPhep(madon))
				{
					MessageBox.Show("Từ chối đơn nghỉ phép thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
					LoadDonNghiPhep();
				}
				else
				{
					MessageBox.Show("Từ chối đơn nghỉ phép thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				LoadDonNghiPhep();
			}
		}

		private void btn_timkiemdonnghiphep_Click(object sender, EventArgs e)
		{
			string keyword = txb_timkiemdonnghiphep.Text.Trim();

			if (string.IsNullOrEmpty(keyword))
			{
				LoadDonNghiPhep(); 
			}
			else
			{
				duyetDonNghiPhepList.DataSource = DonnghiphepDAO.Instance.SearchDonnghiphep(keyword);
			}
		}
		#endregion
		#region Hovers
		private void btn_duyet_MouseEnter(object sender, EventArgs e)
		{
			btn_duyet.BackColor = Color.LightBlue;
		}
		private void btn_duyet_MouseLeave(object sender, EventArgs e)
		{
			btn_duyet.BackColor = originalApproveButtonColor;
		}
		private void btn_tuchoi_MouseEnter(object sender, EventArgs e)
		{
			btn_tuchoi.BackColor = Color.LightBlue;
		}
		private void btn_tuchoi_MouseLeave(object sender, EventArgs e)
		{
			btn_tuchoi.BackColor = originalRejectButtonColor;
		}
		private void btn_dong_MouseEnter(object sender, EventArgs e)
		{
			btn_dong.BackColor = Color.LightBlue;
		}
		private void btn_dong_MouseLeave(object sender, EventArgs e)
		{
			btn_dong.BackColor = originalCloseButtonColor;
		}
		private void btn_timkiemdonnghiphep_MouseEnter(object sender, EventArgs e)
		{
			btn_timkiemdonnghiphep.BackColor = Color.LightBlue;
		}
		private void btn_timkiemdonnghiphep_MouseLeave(object sender, EventArgs e)
		{
			btn_timkiemdonnghiphep.BackColor = originalSearchButtonColor;
		}
		#endregion
	}
}
