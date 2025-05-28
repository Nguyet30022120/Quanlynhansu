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

namespace QuanLyNhanSu
{
	public partial class fQuanlyhopdong : Form
	{
		BindingSource contractList = new BindingSource();
		public fQuanlyhopdong()
		{
			InitializeComponent();
			dgv_contract.DataSource = contractList;
			LoadContract();
			BindingContractData();
		}

		void BindingContractData()
		{
			txb_tennhanvien.DataBindings.Add(new Binding("Text", dgv_contract.DataSource, "TenNV", true, DataSourceUpdateMode.Never));
			//txb_mahd.DataBindings.Add(new Binding("Text", dgv_contract.DataSource, "MaHD", true, DataSourceUpdateMode.Never));
			dtp_ngaydk.DataBindings.Add(new Binding("Value", dgv_contract.DataSource, "NgayDK", true, DataSourceUpdateMode.Never));
			dtp_ngayhh.DataBindings.Add(new Binding("Value", dgv_contract.DataSource, "NgayHH", true, DataSourceUpdateMode.Never));
			txb_status.DataBindings.Add(new Binding("Text", dgv_contract.DataSource, "TrangThai", true, DataSourceUpdateMode.Never));
		}
		void LoadContract()
		{
			contractList.DataSource = HopdongDAO.Instance.GetListHopDong();
		}


		private void btn_addhd_Click(object sender, EventArgs e)
		{
			try
			{
				string manv = txb_tennhanvien.Text;
				DateTime ngaydk = dtp_ngaydk.Value;
				DateTime ngayhh = dtp_ngayhh.Value;
				if (HopdongDAO.Instance.InsertHopDong(manv, ngaydk, ngayhh))
				{
					MessageBox.Show("Thêm hợp đồng thành công");
					LoadContract();
				}
				else
				{
					MessageBox.Show("Thêm hợp đồng thất bại");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error: " + ex.Message, "ThongBao", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				LoadContract();
			}
		}

		private void btn_edithd_Click(object sender, EventArgs e)
		{
			{

				try
				{
					string mahd = dgv_contract.CurrentRow.Cells["MaHD"].Value.ToString();
					DateTime ngaydk = dtp_ngaydk.Value;
					DateTime ngayhh = dtp_ngayhh.Value;

					if (HopdongDAO.Instance.UpdateHopDong(mahd, ngaydk, ngayhh))
					{
						MessageBox.Show("Sửa hợp đồng thành công.");
					}
					else
					{
						MessageBox.Show("Sửa hợp đồng thất bại.");
					}

				}
				catch (Exception ex)
				{
					MessageBox.Show("Error: " + ex.Message, "ThongBao", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				finally
				{
					LoadContract();
				}
			}
		}

		private void btn_deletehd_Click(object sender, EventArgs e)
		{
			{

				try
				{
					string mahd = dgv_contract.CurrentRow.Cells["MaHD"].Value.ToString();


					if (HopdongDAO.Instance.DeleteContract(mahd))
					{
						MessageBox.Show("Xóa hợp đồng thành công.");
					}
					else
					{
						MessageBox.Show("Xóa hợp đồng thất bại.");
					}

				}
				catch (Exception ex)
				{
					MessageBox.Show("Error: " + ex.Message, "ThongBao", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				finally
				{
					LoadContract();
				}
			}
		}

		private void btn_closehd_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btn_updatehd_Click(object sender, EventArgs e)
		{

			{

				try
				{


					if (HopdongDAO.Instance.UpdateTrangThai())
					{
						MessageBox.Show("Cập nhật trạng thái thành công.");
					}
					else
					{
						MessageBox.Show("Cập nhật trạng thái thất bại.");
					}

				}
				catch (Exception ex)
				{
					MessageBox.Show("Error: " + ex.Message, "ThongBao", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				finally
				{
					LoadContract();
				}
			}
		}

		private void btn_findhd_Click(object sender, EventArgs e)
		{
			contractList.DataSource = HopdongDAO.Instance.SearchContract(txb_timhopdong.Text);
		}
	}
}
