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
	public partial class fQuanlytrinhdochuyenmon : Form
	{
		BindingSource levelList = new BindingSource();
		public fQuanlytrinhdochuyenmon()
		{
			InitializeComponent();
			dgv_trinhdo.DataSource = levelList;
			
		}

		void BindingLevelData()
		{
			// Clear old bindings
			txb_tennhanvien.DataBindings.Clear();
			cb_loaibangcap.DataBindings.Clear();
			txb_chuyennganh.DataBindings.Clear();
			txb_truonghoc.DataBindings.Clear();
			txb_tennhanvien.DataBindings.Add(new Binding("Text", dgv_trinhdo.DataSource, "TenNV", true, DataSourceUpdateMode.Never));
			cb_loaibangcap.DataBindings.Add(new Binding("Text", dgv_trinhdo.DataSource, "LoaiBC", true, DataSourceUpdateMode.Never));
			txb_chuyennganh.DataBindings.Add(new Binding("Text", dgv_trinhdo.DataSource, "ChuyenNganh", true, DataSourceUpdateMode.Never));
			txb_truonghoc.DataBindings.Add(new Binding("Text", dgv_trinhdo.DataSource, "TruongHoc", true, DataSourceUpdateMode.Never));
		}
		void LoadLevel(string manv)
		{
			levelList.DataSource = TrinhdochuyenmonDAO.Instance.GetListTrinhDo(manv);
			BindingLevelData();
		}

		private void btn_addtd_Click(object sender, EventArgs e)
		{
			string manv = txb_manv.Text;
			try
			{
				//string manv = txb_manv.Text;
				string chuyennganh = txb_chuyennganh.Text;
				string loaibc = cb_loaibangcap.Text;
				string truonghoc = txb_truonghoc.Text;

				if (TrinhdochuyenmonDAO.Instance.InsertTrinhDo(manv, loaibc,chuyennganh,truonghoc))
				{
					MessageBox.Show("Thêm trình độ thành công");
					LoadLevel(manv);
				}
				else
				{
					MessageBox.Show("Thêm trình độ thất bại");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error: " + ex.Message, "ThongBao", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				LoadLevel(manv);
			}
		}

		private void btn_edittd_Click(object sender, EventArgs e)
		{
			string manv = txb_manv.Text;
			try
			{
				string matd = dgv_trinhdo.CurrentRow.Cells["MaTD"].Value.ToString();
				string loaibc = cb_loaibangcap.Text;
				string chuyennganh = txb_chuyennganh.Text;
				string truonghoc = txb_truonghoc.Text;

				if (TrinhdochuyenmonDAO.Instance.UpdateTrinhDo(matd, loaibc,chuyennganh,truonghoc))
				{
					MessageBox.Show("Sửa trình độ thành công.");
				}
				else
				{
					MessageBox.Show("Sửa trình độ thất bại.");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error: " + ex.Message, "ThongBao", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				LoadLevel(manv);
			}
		}

		private void btn_deletetd_Click(object sender, EventArgs e)
		{
			string manv = txb_manv.Text;
			try
			{
				string matd = dgv_trinhdo.CurrentRow.Cells["MaTD"].Value.ToString(); ;
				if (TrinhdochuyenmonDAO.Instance.DeleteTrinhDo(matd))
				{
					MessageBox.Show("Xóa trình độ thành công.");
				}
				else
				{
					MessageBox.Show("Xóa trình độ thất bại.");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error: " + ex.Message, "ThongBao", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				LoadLevel(manv);
			}
		}

		private void btn_closetd_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btn_findtd_Click(object sender, EventArgs e)
		{
			LoadLevel(txb_manv.Text);
		}


	}
}
