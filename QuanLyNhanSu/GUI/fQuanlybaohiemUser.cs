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
	public partial class fQuanlybaohiemUser : Form
	{
		private Color originalAddButtonColor;
		private Color originalEditButtonColor;
		private Color originalDeleteButtonColor;
		private Color originalFindButtonColor;
		private Color originalCloseButtonColor;

		BindingSource insuranceList = new BindingSource();
		public fQuanlybaohiemUser()
		{
			InitializeComponent();
			dgv_baohiem.DataSource = insuranceList;
			originalCloseButtonColor = btn_dongbaohiem.BackColor;
		}

		void BindingInsuranceData()
		{

			txb_tennhanvien.DataBindings.Clear();
			txb_loaibaohiem.DataBindings.Clear();
			txb_ngaybatdau.DataBindings.Clear();
			txb_ngayketthuc.DataBindings.Clear();
			txb_mota.DataBindings.Clear();
			txb_tienbaohiem.DataBindings.Clear();

			txb_tennhanvien.DataBindings.Add(new Binding("Text", dgv_baohiem.DataSource, "TenNV", true, DataSourceUpdateMode.Never));
			txb_loaibaohiem.DataBindings.Add(new Binding("Text", dgv_baohiem.DataSource, "LoaiBH", true, DataSourceUpdateMode.Never));
			txb_mota.DataBindings.Add(new Binding("Text", dgv_baohiem.DataSource, "MoTa", true, DataSourceUpdateMode.Never));
			txb_ngaybatdau.DataBindings.Add(new Binding("Value", dgv_baohiem.DataSource, "NgayBD", true, DataSourceUpdateMode.Never));
			txb_ngayketthuc.DataBindings.Add(new Binding("Value", dgv_baohiem.DataSource, "NgayKT", true, DataSourceUpdateMode.Never));
			txb_tienbaohiem.DataBindings.Add(new Binding("Text", dgv_baohiem.DataSource, "TienBH", true, DataSourceUpdateMode.Never));
		}
		void LoadInsurance(string manv)
		{
			insuranceList.DataSource = BaohiemDAO.Instance.GetListInsurance(manv);
			BindingInsuranceData();
		}
		#region Events

		private void btn_dongbaohiem_Click(object sender, EventArgs e)
		{
			this.Close();
		}


		#endregion

		#region Hover

		private void btn_dongbaohiem_MouseEnter(object sender, EventArgs e)
		{
			btn_dongbaohiem.BackColor = Color.LightBlue;
		}
		private void btn_dongbaohiem_MouseLeave(object sender, EventArgs e)
		{
			btn_dongbaohiem.BackColor = originalCloseButtonColor;
		}
		#endregion


	}
}
