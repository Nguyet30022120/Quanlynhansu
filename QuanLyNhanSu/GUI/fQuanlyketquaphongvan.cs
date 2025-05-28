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
	public partial class fQuanlyketquaphongvan : Form
	{
		BindingSource resultList = new BindingSource();
		public fQuanlyketquaphongvan()
		{
			InitializeComponent();
			LoadResult();
			dgv_ketqua.DataSource = resultList;
			BindingResultData();
			LoadCbKetLuan();

		}
		void LoadResult()
		{
			resultList.DataSource = KetquaphongvanDAO.Instance.GetListResult();
		}

		void LoadCbKetLuan()
		{
			List<string> diaDiem = new List<string>()
			{
				"Được tuyển", "Không đạt", "Cần đào tạo thêm"
			};
			cb_ketluan.DataSource = diaDiem;
		}
		void BindingResultData()
		{
			txb_mahoso.DataBindings.Add(new Binding("Text", dgv_ketqua.DataSource, "MaHS", true, DataSourceUpdateMode.Never));
			txb_tenungvien.DataBindings.Add(new Binding("Text", dgv_ketqua.DataSource, "TenUV", true, DataSourceUpdateMode.Never));
			txb_danhgia.DataBindings.Add(new Binding("Text", dgv_ketqua.DataSource, "DanhGia", true, DataSourceUpdateMode.Never));
			dtp_ngaydanhgia.DataBindings.Add(new Binding("Value", dgv_ketqua.DataSource, "NgayDanhGia", true, DataSourceUpdateMode.Never));
			cb_ketluan.DataBindings.Add(new Binding("Text", dgv_ketqua.DataSource, "KetLuan", true, DataSourceUpdateMode.Never));
		}

		private void btn_addkq_Click(object sender, EventArgs e)
		{
			try
			{
				string mahs = txb_mahoso.Text;
				string tenuv = txb_tenungvien.Text;
				string danhgia = txb_danhgia.Text;
				string ketluan = cb_ketluan.Text;
				DateTime ngaydanhgia = dtp_ngaydanhgia.Value;

				if (KetquaphongvanDAO.Instance.InsertResult(mahs, danhgia, ketluan, ngaydanhgia))
				{
					MessageBox.Show("Thêm kết quả phỏng vấn thành công");
					LoadResult();
				}
				else
				{
					MessageBox.Show("Thêm kết quả phỏng vấn thất bại");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btn_editkq_Click(object sender, EventArgs e)
		{
			{

				try
				{
					string makq = dgv_ketqua.CurrentRow.Cells["MaKQ"].Value.ToString();
					string tenuv = txb_tenungvien.Text;
					string danhgia = txb_danhgia.Text;
					string ketluan = cb_ketluan.Text;
					DateTime ngaydanhgia = dtp_ngaydanhgia.Value;


					if (KetquaphongvanDAO.Instance.UpdateResult(makq, tenuv, danhgia, ketluan, ngaydanhgia))
					{
						MessageBox.Show("Sửa kết quả phỏng vấn thành công");
					}
					else
					{
						MessageBox.Show("Sửa kết quả phỏng vấn thất bại");
					}

				}
				catch (Exception ex)
				{
					MessageBox.Show("Error: " + ex.Message, "ThongBao", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				finally
				{
					LoadResult();
				}
			}
		}

		private void btn_deletekq_Click(object sender, EventArgs e)
		{
			{

				try
				{
					string makq = dgv_ketqua.CurrentRow.Cells["MaKQ"].Value.ToString();


					if (KetquaphongvanDAO.Instance.DeleteResult(makq))
					{
						MessageBox.Show("Xóa kết quả phỏng vấn thành công");
					}
					else
					{
						MessageBox.Show("Xóa kết quả phỏng vấn thất bại");
					}

				}
				catch (Exception ex)
				{
					MessageBox.Show("Error: " + ex.Message, "ThongBao", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
				finally
				{
					LoadResult();
				}
			}
		}

		private void btn_closekq_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btn_findkq_Click(object sender, EventArgs e)
		{
			resultList.DataSource = KetquaphongvanDAO.Instance.SearchResult(txb_timketqua.Text);
		}

		private void btn_tiepnhan_Click(object sender, EventArgs e)
		{
			DialogResult result = MessageBox.Show("Bạn có muốn tạo tài khoản cho ứng viên này luôn không?",
										"Xác nhận",
										MessageBoxButtons.YesNo,
										MessageBoxIcon.Question);

			if (result == DialogResult.Yes)
			{
				string mahs = txb_mahoso.Text;
				fQuanlytiepnhannhanvien schedule = new fQuanlytiepnhannhanvien(mahs);
				schedule.ShowDialog();
			}
			else
			{

			}
		}
	}
}
