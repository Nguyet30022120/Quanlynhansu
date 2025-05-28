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
	public partial class fBangcong : Form
	{
		BindingSource kycongList = new BindingSource();
		public fBangcong()
		{
			InitializeComponent();
			dgv_kycong.DataSource = kycongList;
			LoadKyCong();
			BindingKyCongData();
		}
		void BindingKyCongData()
		{
			cb_nam.Text = DateTime.Now.Year.ToString();
			cb_thang.Text = DateTime.Now.Month.ToString();
			cb_nam.DataBindings.Add(new Binding("Text", dgv_kycong.DataSource, "Nam", true, DataSourceUpdateMode.Never));
			cb_thang.DataBindings.Add(new Binding("Text", dgv_kycong.DataSource, "Thang", true, DataSourceUpdateMode.Never));
			cb_ngaycong.DataBindings.Add(new Binding("Text", dgv_kycong.DataSource, "NgayCong", true, DataSourceUpdateMode.Never));
			dtp_ngaytinhcong.DataBindings.Add(new Binding("Value", dgv_kycong.DataSource, "NgayTinhCong", true, DataSourceUpdateMode.Never));
		}
		void LoadKyCong()
		{
			kycongList.DataSource = KycongDAO.Instance.GetListKyCong();
		}

		private void btn_add_Click(object sender, EventArgs e)
		{
			try
			{
				int nam = Convert.ToInt32(cb_nam.Text);
				int thang = Convert.ToInt32(cb_thang.Text);
				int ngaycongtrongthang = Function.Functions.demSoNgayLamViecTrongThang(thang, nam);
				DateTime ngaytinhcong = DateTime.Now;


				if (KycongDAO.Instance.InsertKyCong(nam,thang,ngaytinhcong, ngaycongtrongthang))
				{
					MessageBox.Show("Thêm kỳ công thành công");
					LoadKyCong();
				}
				else
				{
					MessageBox.Show("Thêm kỳ công thất bại");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error: " + ex.Message, "ThongBao", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				LoadKyCong();
			}
		}

		private void btn_edit_Click(object sender, EventArgs e)
		{
			try
			{
				int makycong = Convert.ToInt32(dgv_kycong.CurrentRow.Cells["MaKyCong"].Value);
				int nam = Convert.ToInt32(cb_nam.Text);
				int thang = Convert.ToInt32(cb_thang.Text);
				int ngaycongtrongthang = Convert.ToInt32(cb_ngaycong.Text);
				DateTime ngaytinhcong = dtp_ngaytinhcong.Value;


				if (KycongDAO.Instance.UpdateKyCong(makycong, ngaytinhcong, ngaycongtrongthang))
				{
					MessageBox.Show("Sửa kỳ công thành công");
					LoadKyCong();
				}
				else
				{
					MessageBox.Show("Sửa kỳ công thất bại");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error: " + ex.Message, "ThongBao", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				LoadKyCong();
			}
		}

		private void btn_delete_Click(object sender, EventArgs e)
		{
			try
			{
				int makycong = Convert.ToInt32(dgv_kycong.CurrentRow.Cells["MaKyCong"].Value);
				if (KycongDAO.Instance.DeleteKyCong(makycong))
				{
					MessageBox.Show("Xóa kỳ công thành công");
					LoadKyCong();
				}
				else
				{
					MessageBox.Show("Xóa kỳ công thất bại");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error: " + ex.Message, "ThongBao", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				LoadKyCong();
			}

		}

		private void btn_close_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btn_viewdetail_Click(object sender, EventArgs e)
		{
			fBangcongchitiet f = new fBangcongchitiet();
			this.Hide();
			f.ShowDialog();
			this.Show();
		}

		private void lb_ngaycong_Click(object sender, EventArgs e)
		{

		}

		private void cb_ngaycong_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void dtp_ngaytinhcong_ValueChanged(object sender, EventArgs e)
		{

		}

		private void lb_ngaytinhcong_Click(object sender, EventArgs e)
		{

		}

		private void dgv_kycong_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}

		private void lb_thang_Click(object sender, EventArgs e)
		{

		}

		private void lb_nam_Click(object sender, EventArgs e)
		{

		}

		private void cb_thang_SelectedIndexChanged(object sender, EventArgs e)
		{

		}

		private void cb_nam_SelectedIndexChanged(object sender, EventArgs e)
		{

		}
	}
}
