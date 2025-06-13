using QuanLyNhanSu.DAO;
using QuanLyNhanSu.GUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading.Tasks.Sources;
using System.Windows.Forms;

namespace QuanLyNhanSu
{
	public partial class fQuanlydaotaonhanvien : Form
	{
		private Color originalAddButtonColor;
		private Color originalEditButtonColor;
		private Color originalDeleteButtonColor;
		private Color originalFindButtonColor;
		private Color originalCloseButtonColor;
		private Color originalViewCourseButtonColor;

		BindingSource trainingList = new BindingSource();
		public fQuanlydaotaonhanvien()
		{
			InitializeComponent();
			dgv_daotao.DataSource = trainingList;
			LoadTraining();
			BindingtrainingData();
			LoadCbTrangThai();
			LoadCbKetQua();
			LoadCbKhoaHoc();
			originalAddButtonColor = btn_themdaotao.BackColor;
			originalEditButtonColor = btn_suadaotao.BackColor;
			originalDeleteButtonColor = btn_xoadaotao.BackColor;
			originalFindButtonColor = btn_timnhanvien.BackColor;
			originalCloseButtonColor = btn_dongdaotao.BackColor;
			originalViewCourseButtonColor = btn_xemkhoahoc.BackColor;
			//LoadInitialData();
		}
		//void LoadInitialData()
		//{


		//	// Gọi hàm lấy toàn bộ trình độ của tất cả nhân viên
		//	trainingList.DataSource = DaotaoDAO.Instance.GetListDaoTaoAll();

		//	// Gán binding để hiển thị dữ liệu
		//	BindingtrainingData();
		//}
		void BindingtrainingData()
		{
			txb_manhanvien.DataBindings.Clear();
			txb_tennhanvien.DataBindings.Clear();
			cb_khoahoc.DataBindings.Clear();
			cb_ketqua.DataBindings.Clear();
			cb_trangthai.DataBindings.Clear();

			txb_tennhanvien.DataBindings.Add(new Binding("Text", dgv_daotao.DataSource, "TenNV", true, DataSourceUpdateMode.Never));
			cb_khoahoc.DataBindings.Add(new Binding("Text", dgv_daotao.DataSource, "TenKH", true, DataSourceUpdateMode.Never));
			cb_ketqua.DataBindings.Add(new Binding("Text", dgv_daotao.DataSource, "KetQua", true, DataSourceUpdateMode.Never));
			cb_trangthai.DataBindings.Add(new Binding("Text", dgv_daotao.DataSource, "TrangThai", true, DataSourceUpdateMode.Never));
		}
		void LoadTraining()
		{
			string manv = txb_manhanvien.Text;
			trainingList.DataSource = DaotaoDAO.Instance.GetListDaoTao(manv);
		}

		void LoadCbTrangThai()
		{
			List<string> trangThai = new List<string>()
			{"Đang học","Hoàn thành"};
			cb_trangthai.DataSource = trangThai;
		}
		void LoadCbKetQua()
		{
			List<string> ketQua = new List<string>()
			{"Đạt","Không Đạt"};
			cb_ketqua.DataSource = ketQua;
		}
		void LoadCbKhoaHoc()
		{
			cb_khoahoc.DataSource = KhoahocDAO.Instance.GetListCourse();
			cb_khoahoc.DisplayMember = "TenKhoaHoc";
			cb_khoahoc.ValueMember = "MaKhoaHoc";
		}

		#region Events
		private void btn_adddt_Click(object sender, EventArgs e)
		{
			try
			{
				string manv = txb_manhanvien.Text;
				string tenkh = cb_khoahoc.Text;
				if (DaotaoDAO.Instance.InsertDaoTao(manv, tenkh))
				{
					MessageBox.Show("Thêm đào tạo thành công", "Thông báo");
					LoadTraining();
				}
				else
				{
					MessageBox.Show("Thêm đào tạo thất bại","Thông báo");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Hãy nhập mã nhân viên!", "Thông báo");
			}
			finally
			{
				LoadTraining();
			}
		}

		private void editdt_Click(object sender, EventArgs e)
		{
			{

				try
				{
					string madt = dgv_daotao.CurrentRow.Cells["MaDT"].Value.ToString();
					string tennv = txb_tennhanvien.Text;
					string tenkh = cb_khoahoc.Text;
					string trangthai = cb_trangthai.Text;
					string ketqua = cb_ketqua.Text;

					if (DaotaoDAO.Instance.UpdateDaoTao(madt, tennv,tenkh,trangthai,ketqua))
					{
						MessageBox.Show("Sửa đào tạo thành công.", "Thông báo");
					}
					else
					{
						MessageBox.Show("Sửa đào tạo thất bại.", "Thông báo");
					}

				}
				catch (Exception ex)
				{
					MessageBox.Show("Error: " + ex.Message, "ThongBao", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				finally
				{
					LoadTraining();
				}
			}
		}

		private void btn_deletedt_Click(object sender, EventArgs e)
		{
			{

				try
				{
					string madt = dgv_daotao.CurrentRow.Cells["MaDT"].Value.ToString();

					if (DaotaoDAO.Instance.DeleteDaoTao(madt))
					{
						MessageBox.Show("Xóa đào tạo thành công.", "Thông báo");
					}
					else
					{
						MessageBox.Show("Xóa đào tạo thất bại.", "Thông báo");
					}

				}
				catch (Exception ex)
				{
					MessageBox.Show("Error: " + ex.Message, "ThongBao", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				finally
				{
					LoadTraining();
				}
			}
		}

		private void btn_closedt_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btn_finddt_Click(object sender, EventArgs e)
		{
			string manv = txb_manhanvien.Text;
			trainingList.DataSource = DaotaoDAO.Instance.GetListDaoTao(manv);
		}

		private void btn_viewkh_Click(object sender, EventArgs e)
		{
			fQuanlykhoahoc f = new fQuanlykhoahoc();
			this.Hide();
			f.ShowDialog();
			this.Show();
		}
		#endregion

		private void btn_themdaotao_MouseEnter(object sender, EventArgs e)
		{
			btn_themdaotao.BackColor = Color.LightBlue;
		}
		private void btn_themdaotao_MouseLeave(object sender, EventArgs e)
		{
			btn_themdaotao.BackColor = originalAddButtonColor;
		}
		private void btn_suadaotao_MouseEnter(object sender, EventArgs e)
		{
			btn_suadaotao.BackColor = Color.LightBlue;
		}
		private void btn_suadaotao_MouseLeave(object sender, EventArgs e)
		{
			btn_suadaotao.BackColor = originalEditButtonColor;
		}
		private void btn_xoadaotao_MouseEnter(object sender, EventArgs e)
		{
			btn_xoadaotao.BackColor = Color.LightBlue;
		}
		private void btn_xoadaotao_MouseLeave(object sender, EventArgs e)
		{
			btn_xoadaotao.BackColor = originalDeleteButtonColor;
		}
		private void btn_timnhanvien_MouseEnter(object sender, EventArgs e)
		{
			btn_timnhanvien.BackColor = Color.LightBlue;
		}
		private void btn_timnhanvien_MouseLeave(object sender, EventArgs e)
		{
			btn_timnhanvien.BackColor = originalFindButtonColor;
		}
		private void btn_dongdaotao_MouseEnter(object sender, EventArgs e)
		{
			btn_dongdaotao.BackColor = Color.LightBlue;
		}
		private void btn_dongdaotao_MouseLeave(object sender, EventArgs e)
		{
			btn_dongdaotao.BackColor = originalCloseButtonColor;
		}
		private void btn_xemkhoahoc_MouseEnter(object sender, EventArgs e)
		{
			btn_xemkhoahoc.BackColor = Color.LightBlue;
		}
		private void btn_xemkhoahoc_MouseLeave(object sender, EventArgs e)
		{
			btn_xemkhoahoc.BackColor = originalViewCourseButtonColor;
		}
		}
}
