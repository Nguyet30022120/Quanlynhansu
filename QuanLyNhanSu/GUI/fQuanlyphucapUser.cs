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
	public partial class fQuanlyphucapUser : Form
	{

		private Color originalCloseButtonColor;


		BindingSource phucapList = new BindingSource();
		public fQuanlyphucapUser(string manv)
		{
			InitializeComponent();
			dgv_phucap.DataSource = phucapList;
			originalCloseButtonColor = btn_dongphucap.BackColor;
			LoadPhuCap(manv);
			txb_manhanvien.Text = manv;
			LoadTenNV(manv);

		}
		void LoadTenNV(string manv)
		{
			string tenNV = NhanvienDAO.Instance.GetStaffTen(manv);

			if (string.IsNullOrEmpty(tenNV))
			{
				MessageBox.Show("Không có mã nhân viên trong hệ thống!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
				txb_tennhanvien.Text = "";
			}
			else
			{
				txb_tennhanvien.Text = tenNV;
			}
		}

		void BindingPhuCapData()
		{

			txb_tennhanvien.DataBindings.Clear();
			txb_loaiphucap.DataBindings.Clear();
			txb_tienphucap.DataBindings.Clear();

			txb_tennhanvien.DataBindings.Add(new Binding("Text", dgv_phucap.DataSource, "TenNV", true, DataSourceUpdateMode.Never));
			txb_loaiphucap.DataBindings.Add(new Binding("Text", dgv_phucap.DataSource, "LoaiPhuCap", true, DataSourceUpdateMode.Never));
			txb_tienphucap.DataBindings.Add(new Binding("Text", dgv_phucap.DataSource, "SoTienPhuCap", true, DataSourceUpdateMode.Never));
		}
		void LoadPhuCap(string manv)
		{
			phucapList.DataSource = PhucapDAO.Instance.GetListPhuCap(manv);
			BindingPhuCapData();
		}

		#region Events
		
		private void btn_dongphucap_Click(object sender, EventArgs e)
		{
			this.Close();
		}
		#endregion

		#region Hover
		
		private void btn_dongphucap_MouseEnter(object sender, EventArgs e)
		{
			btn_dongphucap.BackColor = Color.LightBlue;
		}
		private void btn_dongphucap_MouseLeave(object sender, EventArgs e)
		{
			btn_dongphucap.BackColor = originalCloseButtonColor;
		}

		#endregion

	}
}
