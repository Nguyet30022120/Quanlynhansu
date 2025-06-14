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
		private Color originalEditButtonColor;
		private Color originalSearchButtonColor;
		private Color originalCloseButtonColor;

		BindingSource luongList = new BindingSource();

		public fQuanlyluongcoban()
		{
			InitializeComponent();
			luongList.DataSource = LuongcobanDAO.Instance.GetLuongCoBan();
			dgv_luongcoban.DataSource = luongList;
			BindingLuongCoBanData();
			originalCloseButtonColor = btn_dong.BackColor;
			originalEditButtonColor = btn_sua.BackColor;
			originalSearchButtonColor = btn_tim.BackColor;
		}

		void BindingLuongCoBanData()
		{
			txb_tennhanvien.DataBindings.Add(new Binding("Text", dgv_luongcoban.DataSource, "TenNV", true, DataSourceUpdateMode.Never));
			txb_luongcoban.DataBindings.Add(new Binding("Text", dgv_luongcoban.DataSource, "LuongCoSo", true, DataSourceUpdateMode.Never));
		}
		#region Events
		private void btn_dong_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btn_sua_Click(object sender, EventArgs e)
		{
			try
			{
				string maLuong = dgv_luongcoban.CurrentRow.Cells["MaLuong"].Value.ToString();
				decimal luongCoSo = Convert.ToDecimal(txb_luongcoban.Text);

				if (LuongcobanDAO.Instance.UpdateLuongCoBan(maLuong, luongCoSo))
				{
					MessageBox.Show("Cập nhật lương cơ bản thành công", "Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
					luongList.DataSource = LuongcobanDAO.Instance.GetLuongCoBan();
				}
				else
				{
					MessageBox.Show("Cập nhật lương cơ bản thất bại", "Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Error);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error: " + ex.Message, "Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}

		private void btn_tim_Click(object sender, EventArgs e)
		{
			try
			{
				string searchValue = txb_timnhanvien.Text.Trim();

				var ketQua = LuongcobanDAO.Instance.SearchLuongCoBan(searchValue);

				if (ketQua != null && ketQua.Count > 0)
				{
					luongList.DataSource = ketQua;
				}
				else
				{
					MessageBox.Show("Không tìm thấy kết quả nào.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
					luongList.DataSource = LuongcobanDAO.Instance.GetLuongCoBan(); 
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
		}
		#endregion
		#region Hovers
		private void btn_dong_MouseEnter(object sender, EventArgs e)
		{
			btn_dong.BackColor = Color.LightBlue;
		}
		private void btn_dong_MouseLeave(object sender, EventArgs e)
		{
			btn_dong.BackColor = originalCloseButtonColor;
		}
		private void btn_sua_MouseEnter(object sender, EventArgs e)
		{
			btn_sua.BackColor = Color.LightBlue;
		}
		private void btn_sua_MouseLeave(object sender, EventArgs e)
		{
			btn_sua.BackColor = originalEditButtonColor;
		}
		private void btn_tim_MouseEnter(object sender, EventArgs e)
		{
			btn_tim.BackColor = Color.LightBlue;
		}
		private void btn_tim_MouseLeave(object sender, EventArgs e)
		{
			btn_tim.BackColor = originalSearchButtonColor;
		}
		#endregion


	}
}
