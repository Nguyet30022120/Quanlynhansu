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
	public partial class fQuanlydangkynghiphepUser : Form
	{
		private Color originalAddButtonColor;
		private Color originalCloseButtonColor;
		private Color originalEditButtonColor;

		BindingSource donNghiPhepList = new BindingSource();

		private List<string> staffNames = new List<string>();
		public fQuanlydangkynghiphepUser(string manv)
		{
			InitializeComponent();
			dgv_donnghiphep.DataSource = donNghiPhepList;
			txb_manhanvien.Text = manv;
			LoadTenNV(manv);
			LoadDonNghiPhep(manv);
			LoadStaffNames();
			LoadCbLoaiPhep();
			SetupAutoCompleteForNguoiDuyet();
			originalAddButtonColor = btn_themdonnghiphep.BackColor;
			originalCloseButtonColor = btn_dongdonnghiphep.BackColor;
			originalEditButtonColor = btn_suadonnghiphep.BackColor;

		}
		void BindingDonNghiPhepData()
		{
			txb_tennhanvien.DataBindings.Clear();
			cb_loaiphep.DataBindings.Clear();
			txb_lydo.DataBindings.Clear();
			dtp_ngaybatdau.DataBindings.Clear();
			dtp_ngayketthuc.DataBindings.Clear();
			txb_trangthai.DataBindings.Clear();
			txb_nguoiduyet.DataBindings.Clear();

			txb_tennhanvien.DataBindings.Add(new Binding("Text", dgv_donnghiphep.DataSource, "TenNV", true, DataSourceUpdateMode.Never));
			cb_loaiphep.DataBindings.Add(new Binding("Text", dgv_donnghiphep.DataSource, "LoaiPhep", true, DataSourceUpdateMode.Never));
			txb_lydo.DataBindings.Add(new Binding("Text", dgv_donnghiphep.DataSource, "LyDo", true, DataSourceUpdateMode.Never));
			dtp_ngaybatdau.DataBindings.Add(new Binding("Value", dgv_donnghiphep.DataSource, "NgayBD", true, DataSourceUpdateMode.Never));
			dtp_ngayketthuc.DataBindings.Add(new Binding("Value", dgv_donnghiphep.DataSource, "NgayKT", true, DataSourceUpdateMode.Never));
			txb_trangthai.DataBindings.Add(new Binding("Text", dgv_donnghiphep.DataSource, "TrangThai", true, DataSourceUpdateMode.Never));
			txb_nguoiduyet.DataBindings.Add(new Binding("Text", dgv_donnghiphep.DataSource, "NguoiDuyet", true, DataSourceUpdateMode.Never));

		}
		void LoadTenNV(string manv)
		{
			txb_tennhanvien.Text = NhanvienDAO.Instance.GetStaffTen(manv);
		}

		void LoadDonNghiPhep(string manv)
		{
			donNghiPhepList.DataSource = DonnghiphepDAO.Instance.GetDonNghiPhep(manv);
			BindingDonNghiPhepData();
		}
		private void LoadStaffNames()
		{
			staffNames = NhanvienDAO.Instance.GetStaffName();
		}
		void LoadCbLoaiPhep()
		{
			List<string> loaiPhep = new List<string>()
			{
				"Nghỉ không lương", "Nghỉ ốm", "Nghỉ phép năm", "Nghỉ thai sản", "Nghỉ việc riêng", "Nghỉ việc khác"
			};
			cb_loaiphep.DataSource = loaiPhep;
		}
		private void SetupAutoCompleteForNguoiDuyet()
		{
			var autoComplete = new AutoCompleteStringCollection();
			autoComplete.AddRange(staffNames.ToArray());

			txb_nguoiduyet.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			txb_nguoiduyet.AutoCompleteSource = AutoCompleteSource.CustomSource;
			txb_nguoiduyet.AutoCompleteCustomSource = autoComplete;
		}

		#region Events

		private void btn_adddonnghiphep_Click(object sender, System.EventArgs e)
		{
			string manv = txb_manhanvien.Text;
			try
			{
				string tennv = txb_tennhanvien.Text;
				string loaiphep = cb_loaiphep.Text;
				string trangthai = txb_trangthai.Text;
				string lydo = txb_lydo.Text;
				DateTime ngaybd = dtp_ngaybatdau.Value;
				DateTime ngaykt = dtp_ngayketthuc.Value;
				string nguoiduyet = txb_nguoiduyet.Text;

				if (DonnghiphepDAO.Instance.InsertDonNghiPhep(manv, loaiphep, trangthai, lydo, ngaybd, ngaykt, nguoiduyet))
				{
					MessageBox.Show("Thêm đơn nghỉ phép thành công", "Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Information);
					LoadDonNghiPhep(manv);
				}
				else
				{
					MessageBox.Show("Thêm đơn nghỉ phép thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				LoadDonNghiPhep(manv);
			}
		}

		private void btn_editdonnghiphep_Click(object sender, EventArgs e)
		{
			string manv = txb_manhanvien.Text;
			try
			{
				int madonnghiphep = Convert.ToInt32(dgv_donnghiphep.CurrentRow.Cells["MaDonNghiPhep"].Value);
				string tennv = txb_tennhanvien.Text;
				string loaiphep = cb_loaiphep.Text;
				string trangthai = txb_trangthai.Text;
				string lydo = txb_lydo.Text;
				DateTime ngaybd = dtp_ngaybatdau.Value;
				DateTime ngaykt = dtp_ngayketthuc.Value;
				string nguoiduyet = txb_nguoiduyet.Text;

				if (DonnghiphepDAO.Instance.UpdateDonNghiPhep(madonnghiphep, tennv, loaiphep, trangthai, lydo, ngaybd, ngaykt, nguoiduyet))
				{
					MessageBox.Show("Sửa đơn nghỉ phép thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
					LoadDonNghiPhep(manv);
				}
				else
				{
					MessageBox.Show("Sửa đơn nghỉ phép thất bại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error: " + ex.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				LoadDonNghiPhep(manv);
			}
		}


		private void btn_closedonnghiphep_Click(object sender, EventArgs e)
		{
			this.Close();
		}
		#endregion

		#region Hover
		private void btn_themdonnghiphep_MouseEnter(object sender, EventArgs e)
		{
			btn_themdonnghiphep.BackColor = Color.LightBlue;
		}
		private void btn_themdonnghiphep_MouseLeave(object sender, EventArgs e)
		{
			btn_themdonnghiphep.BackColor = originalAddButtonColor;
		}

		private void btn_dongdonnghiphep_MouseEnter(object sender, EventArgs e)
		{
			btn_dongdonnghiphep.BackColor = Color.LightBlue;
		}
		private void btn_dongdonnghiphep_MouseLeave(object sender, EventArgs e)
		{
			btn_dongdonnghiphep.BackColor = originalCloseButtonColor;
		}

		private void btn_suadonnghiphep_MouseEnter(object sender, EventArgs e)
		{
			btn_suadonnghiphep.BackColor = Color.LightBlue;
		}
		private void btn_suadonnghiphep_MouseLeave(object sender, EventArgs e)
		{
			btn_suadonnghiphep.BackColor = originalEditButtonColor;
		}
		#endregion

	}
}
