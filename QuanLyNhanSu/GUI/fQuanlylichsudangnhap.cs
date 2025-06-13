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
	public partial class fQuanlylichsudangnhap : Form
	{
		private Color originalCloseButtonColor;
		public fQuanlylichsudangnhap()
		{
			InitializeComponent();
			this.Load += fLichSuDangNhap_Load;
			originalCloseButtonColor = btn_dong.BackColor;
		}
		#region Hovers
		private void btn_dong_MouseEnter(object sender, EventArgs e)
		{
			btn_dong.BackColor = Color.LightBlue;
		}
		private void btn_dong_MouseLeave(object sender, EventArgs e)
		{
			btn_dong.BackColor = originalCloseButtonColor;
		}
		#endregion

		#region Events

		private void fLichSuDangNhap_Load(object sender, EventArgs e)
		{
			dgv_lichsudangnhap.DataSource = LichsudangnhapDAO.Instance.GetAll();
		}

		private void btn_dong_Click(object sender, EventArgs e)
		{
			this.Close();
		}
		#endregion
	}
}