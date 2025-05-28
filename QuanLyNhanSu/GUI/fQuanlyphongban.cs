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

namespace QuanLyNhanSu
{
	public partial class fQuanlyphongban : Form
	{
		BindingSource officeList = new BindingSource();

		public fQuanlyphongban()
		{
			InitializeComponent();
			dgv_phongban.DataSource = officeList;
			LoadOffice();
			BindingOfficeData();
		}

		void BindingOfficeData()
		{
			//txb_mapb.DataBindings.Add(new Binding("Text", dgv_phongban.DataSource, "MaPB", true, DataSourceUpdateMode.Never));
			txb_tenpb.DataBindings.Add(new Binding("Text", dgv_phongban.DataSource, "TenPB", true, DataSourceUpdateMode.Never));
			txb_diachipb.DataBindings.Add(new Binding("Text", dgv_phongban.DataSource, "DiaChi", true, DataSourceUpdateMode.Never));
		}
		void LoadOffice()
		{
			officeList.DataSource = PhongbanDAO.Instance.GetListPhongBan();
		}


		private void btn_addpb_Click_1(object sender, EventArgs e)
		{
			try
			{
				string tenpb = txb_tenpb.Text;
				string diachi = txb_diachipb.Text;
				if (PhongbanDAO.Instance.InsertPhongBan(tenpb, diachi))
				{
					MessageBox.Show("Thêm phòng ban thành công");
					LoadOffice();
				}
				else
				{
					MessageBox.Show("Thêm phòng ban thất bại");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error: " + ex.Message, "ThongBao", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				LoadOffice();
			}
		}

		private void btn_editpb_Click(object sender, EventArgs e)
		{
			{

				try
				{
					string mapb = dgv_phongban.CurrentRow.Cells["MaPB"].Value.ToString();
					string tenpb = txb_tenpb.Text;
					string diachi = txb_diachipb.Text;

					if (PhongbanDAO.Instance.UpdateOffice(mapb, tenpb, diachi))
					{
						MessageBox.Show("Sửa phòng ban thành công.");
					}
					else
					{
						MessageBox.Show("Sửa phòng ban thất bại.");
					}

				}
				catch (Exception ex)
				{
					MessageBox.Show("Error: " + ex.Message, "ThongBao", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				finally
				{
					LoadOffice();
				}
			}
		}

		private void btn_deletepb_Click(object sender, EventArgs e)
		{
			{

				try
				{
					string mapb = dgv_phongban.CurrentRow.Cells["MaPB"].Value.ToString();


					if (PhongbanDAO.Instance.DeleteOffice(mapb))
					{
						MessageBox.Show("Xóa phòng ban thành công.");
					}
					else
					{
						MessageBox.Show("Xóa phòng ban thất bại.");
					}

				}
				catch (Exception ex)
				{
					MessageBox.Show("Error: " + ex.Message, "ThongBao", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				finally
				{
					LoadOffice();
				}
			}
		}

		private void btn_exitpb_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btn_findpb_Click(object sender, EventArgs e)
		{
			officeList.DataSource = PhongbanDAO.Instance.SearchOffice(txb_findpb.Text);
		}
	}
}
