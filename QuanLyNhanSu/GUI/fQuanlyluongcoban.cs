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
	public partial class fQuanlyluongcoban : Form
	{
		BindingSource luongList = new BindingSource();
		public fQuanlyluongcoban()
		{
			InitializeComponent();
			luongList.DataSource = LuongcobanDAO.Instance.GetLuongCoBan();
			dgv_luongcoban.DataSource = luongList;
			BindingLuongCoBanData();
		}
		//void LoadLuongCoBan()
		//{
		//	dgv_luongcoban.DataSource = luongList;
		//}
		void BindingLuongCoBanData()
		{
			txb_tennhanvien.DataBindings.Add(new Binding("Text", dgv_luongcoban.DataSource, "TenNV", true, DataSourceUpdateMode.Never));
			txb_luongcoban.DataBindings.Add(new Binding("Text", dgv_luongcoban.DataSource, "LuongCoSo", true, DataSourceUpdateMode.Never));
		}

		private void btn_dong_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btn_sua_Click(object sender, EventArgs e)
		{
			try
			{
				// Kiểm tra nếu chưa chọn dòng nào
				if (dgv_luongcoban.SelectedRows.Count == 0)
				{
					MessageBox.Show("Vui lòng chọn một dòng để sửa.", "Thông báo");
					return;
				}

				string maLuong = dgv_luongcoban.SelectedRows[0].Cells["MaLuong"].Value.ToString();
				decimal luongCoSo = Convert.ToDecimal(txb_luongcoban.Text);

				if (LuongcobanDAO.Instance.UpdateLuongCoBan(maLuong, luongCoSo))
				{
					MessageBox.Show("Cập nhật lương cơ bản thành công", "Thông báo");
					luongList.DataSource = LuongcobanDAO.Instance.GetLuongCoBan();
				}
				else
				{
					MessageBox.Show("Cập nhật lương cơ bản thất bại", "Thông báo");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Lỗi: " + ex.Message, "Thông báo");
			}
		}

		private void btn_tim_Click(object sender, EventArgs e)
		{
			try
			{
				string searchValue = txb_timnhanvien.Text.Trim();

				if (string.IsNullOrEmpty(searchValue))
				{
					MessageBox.Show("Vui lòng nhập giá trị tìm kiếm.", "Thông báo");
					return;
				}

				var ketQua = LuongcobanDAO.Instance.SearchLuongCoBan(searchValue);

				if (ketQua != null && ketQua.Count > 0)
				{
					luongList.DataSource = ketQua;
				}
				else
				{
					MessageBox.Show("Không tìm thấy kết quả nào.", "Thông báo");
					luongList.DataSource = LuongcobanDAO.Instance.GetLuongCoBan(); // Trả lại danh sách gốc
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Lỗi: " + ex.Message, "Thông báo");
			}
		}

	}
}
