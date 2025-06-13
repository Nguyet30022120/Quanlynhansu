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
		private Color originalAddButtonColor;
		private Color originalEditButtonColor;
		private Color originalDeleteButtonColor;
		private Color originalCloseButtonColor;
		private Color originalUpdateButtonColor;
		private Color originalSearchButtonColor;

		BindingSource contractList = new BindingSource();
		public fQuanlyhopdong()
		{
			InitializeComponent();
			dgv_hopdong.DataSource = contractList;
			LoadContract();
			BindingContractData();
			originalAddButtonColor = btn_themhopdong.BackColor;
			originalEditButtonColor = btn_suahopdong.BackColor;
			originalDeleteButtonColor = btn_xoahopdong.BackColor;
			originalCloseButtonColor = btn_donghopdong.BackColor;
			originalUpdateButtonColor = btn_capnhathopdong.BackColor;
			originalSearchButtonColor = btn_timhopdong.BackColor;
		}

		void BindingContractData()
		{
			txb_tennhanvien.DataBindings.Add(new Binding("Text", dgv_hopdong.DataSource, "TenNV", true, DataSourceUpdateMode.Never));
			dtp_ngaybatdau.DataBindings.Add(new Binding("Value", dgv_hopdong.DataSource, "NgayDK", true, DataSourceUpdateMode.Never));
			dtp_ngayhethan.DataBindings.Add(new Binding("Value", dgv_hopdong.DataSource, "NgayHH", true, DataSourceUpdateMode.Never));
			txb_trangthai.DataBindings.Add(new Binding("Text", dgv_hopdong.DataSource, "TrangThai", true, DataSourceUpdateMode.Never));
		}
		void LoadContract()
		{
			contractList.DataSource = HopdongDAO.Instance.GetListHopDong();
		}
		#region Hover

		private void btn_themhopdong_MouseEnter(object sender, EventArgs e)
		{
			btn_themhopdong.BackColor = Color.LightBlue;
		}
		private void btn_themhopdong_MouseLeave(object sender, EventArgs e)
		{
			btn_themhopdong.BackColor = originalAddButtonColor;
		}
		private void btn_suahopdong_MouseEnter(object sender, EventArgs e)
		{
			btn_suahopdong.BackColor = Color.LightBlue;
		}
		private void btn_suahopdong_MouseLeave(object sender, EventArgs e)
		{
			btn_suahopdong.BackColor = originalEditButtonColor;
		}
		private void btn_xoahopdong_MouseEnter(object sender, EventArgs e)
		{
			btn_xoahopdong.BackColor = Color.LightBlue;
		}
		private void btn_xoahopdong_MouseLeave(object sender, EventArgs e)
		{
			btn_xoahopdong.BackColor = originalDeleteButtonColor;
		}
		private void btn_donghopdong_MouseEnter(object sender, EventArgs e)
		{
			btn_donghopdong.BackColor = Color.LightBlue;
		}
		private void btn_donghopdong_MouseLeave(object sender, EventArgs e)
		{
			btn_donghopdong.BackColor = originalCloseButtonColor;
		}
		private void btn_capnhathopdong_MouseEnter(object sender, EventArgs e)
		{
			btn_capnhathopdong.BackColor = Color.LightBlue;
		}
		private void btn_capnhathopdong_MouseLeave(object sender, EventArgs e)
		{
			btn_capnhathopdong.BackColor = originalUpdateButtonColor;
		}
		private void btn_timhopdong_MouseEnter(object sender, EventArgs e)
		{
			btn_timhopdong.BackColor = Color.LightBlue;
		}
		private void btn_timhopdong_MouseLeave(object sender, EventArgs e)
		{
			btn_timhopdong.BackColor = originalSearchButtonColor;
		}
		#endregion

		#region Events
		private void btn_addhd_Click(object sender, EventArgs e)
		{
			try
			{
				string manv = dgv_hopdong.CurrentRow.Cells["MaNV"].Value.ToString();
				DateTime ngaydk = dtp_ngaybatdau.Value;
				DateTime ngayhh = dtp_ngayhethan.Value;
				if (HopdongDAO.Instance.InsertHopDong(manv, ngaydk, ngayhh))
				{
					MessageBox.Show("Thêm hợp đồng thành công","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
					LoadContract();
				}
				else
				{
					MessageBox.Show("Thêm hợp đồng thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
					string mahd = dgv_hopdong.CurrentRow.Cells["MaHD"].Value.ToString();
					DateTime ngaydk = dtp_ngaybatdau.Value;
					DateTime ngayhh = dtp_ngayhethan.Value;

					if (HopdongDAO.Instance.UpdateHopDong(mahd, ngaydk, ngayhh))
					{
						MessageBox.Show("Sửa hợp đồng thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
					else
					{
						MessageBox.Show("Sửa hợp đồng thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}

				}
				catch (Exception ex)
				{
					MessageBox.Show("Error: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
					string mahd = dgv_hopdong.CurrentRow.Cells["MaHD"].Value.ToString();


					if (HopdongDAO.Instance.DeleteContract(mahd))
					{
						MessageBox.Show("Xóa hợp đồng thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
					else
					{
						MessageBox.Show("Xóa hợp đồng thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}

				}
				catch (Exception ex)
				{
					MessageBox.Show("Error: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
						MessageBox.Show("Cập nhật trạng thái thành công.", "Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Information);
					}
					else
					{
						MessageBox.Show("Cập nhật trạng thái thất bại.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
					}

				}
				catch (Exception ex)
				{
					MessageBox.Show("Error: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
#endregion




