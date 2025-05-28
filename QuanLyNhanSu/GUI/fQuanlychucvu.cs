using QuanLyNhanSu.DAO;
using System;
using System.Windows.Forms;

namespace QuanLyNhanSu
{
	public partial class fQuanlychucvu : Form
	{
		BindingSource positionList = new BindingSource();
		public fQuanlychucvu()
		{
			InitializeComponent();
			dgv_chucvu.DataSource = positionList;
			LoadPosition();
			BindingPositionData();

		}
		void BindingPositionData()
		{
			//txb_macv.DataBindings.Add(new Binding("Text", dgv_chucvu.DataSource, "MaChucVu", true, DataSourceUpdateMode.Never));
			txb_tencv.DataBindings.Add(new Binding("Text", dgv_chucvu.DataSource, "TenChucVu", true, DataSourceUpdateMode.Never));
			txb_motacv.DataBindings.Add(new Binding("Text", dgv_chucvu.DataSource, "MoTaChucVu", true, DataSourceUpdateMode.Never));
		}
		void LoadPosition()
		{
			positionList.DataSource = ChucvuDAO.Instance.GetListChucVu();
		}

		private void Label1_Click(object sender, EventArgs e)
		{

		}

		private void btn_addcv_Click(object sender, EventArgs e)
		{
			try
			{
				string tencv = txb_tencv.Text;
				string motachuvu = txb_motacv.Text;
				if (ChucvuDAO.Instance.InsertPosition(tencv, motachuvu))
				{
					MessageBox.Show("Thêm chức vụ thành công");
					LoadPosition();
				}
				else
				{
					MessageBox.Show("Thêm chức vụ thất bại");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error: " + ex.Message, "ThongBao", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				LoadPosition();
			}
		}

		private void btn_editcv_Click(object sender, EventArgs e)
		{
			{
				try
				{
					int macv = Convert.ToInt32(dgv_chucvu.CurrentRow.Cells["MaCV"].Value);
					string tencv = txb_tencv.Text;
					string motachucvu = txb_motacv.Text;

					if (ChucvuDAO.Instance.UpdatePosition(macv, tencv, motachucvu))
					{
						MessageBox.Show("Sửa chức vụ thành công.");
					}
					else
					{
						MessageBox.Show("Sửa chức vụ thất bại.");
					}

				}
				catch (Exception ex)
				{
					MessageBox.Show("Error: " + ex.Message, "ThongBao", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				finally
				{
					LoadPosition();
				}
			}
		}

		private void btn_deletecv_Click(object sender, EventArgs e)
		{
			{

				try
				{
					int macv = Convert.ToInt32(dgv_chucvu.CurrentRow.Cells["MaCV"].Value);

					if (ChucvuDAO.Instance.DeletePosition(macv))
					{
						MessageBox.Show("Xóa chức vụ thành công.");
					}
					else
					{
						MessageBox.Show("Xóa chức vụ thất bại.");
					}

				}
				catch (Exception ex)
				{
					MessageBox.Show("Error: " + ex.Message, "ThongBao", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				finally
				{
					LoadPosition();
				}
			}
		}

		private void btn_closecv_Click(object sender, EventArgs e)
		{
			this.Close();
		}
		private void btn_findcv_Click(object sender, EventArgs e)
		{
			positionList.DataSource = ChucvuDAO.Instance.SearchPosition(txb_findcv.Text);
		}


	}
}
