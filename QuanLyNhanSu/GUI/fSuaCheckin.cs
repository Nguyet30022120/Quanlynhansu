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
	public partial class fSuaCheckin : Form
	{
		BindingSource checkinList = new BindingSource();
		public fSuaCheckin(string manv)
		{
			InitializeComponent();
			LoadDataCheckIn(manv);
		}
		void LoadDataCheckIn(string manv)
		{
			List<CheckinDTO> data = CheckinDAO.Instance.GetCheckInByMaNV(manv);

			if (data.Count > 0)
			{
				CheckinDTO checkin = data[0];
				txb_manv.Text = checkin.MaNV;
				txb_tennv.Text = checkin.TenNV;
				dtp_thoigiancheckin.Value = DateTime.Today.Add(checkin.GioCheckIn);
			}
			else
			{
				MessageBox.Show("Không tìm thấy dữ liệu ứng viên.");
			}
		}
		void LoadCheckIn(string manv)
		{
			checkinList.DataSource = CheckinDAO.Instance.GetCheckInByMaNV(manv);
		}

		private void btn_editcheckin_Click(object sender, EventArgs e)
		{
			try
			{
				string manv = txb_manv.Text;
				string tennv = txb_tennv.Text;
				DateTime thoigiancheckin = dtp_thoigiancheckin.Value;
				DateTime ngaycheckin = dtp_thoigiancheckin.Value.Date;

				if (CheckinDAO.Instance.UpdateCheckIn(manv, thoigiancheckin, ngaycheckin))
				{
					MessageBox.Show("Sửa checkin thành công.");
					LoadCheckIn(txb_manv.Text);
				}
				else
				{
					MessageBox.Show("Sửa checkin thất bại.");
				}

			}
			catch (Exception ex)
			{
				MessageBox.Show("Error: " + ex.Message, "ThongBao", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				LoadCheckIn(txb_manv.Text);
			}
		}

		private void btn_closecheckin_Click(object sender, EventArgs e)
		{
			this.Close();
		}
	}

}