using QuanLyNhanSu.DAO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace QuanLyNhanSu.GUI
{
	public partial class fQuanlydangkynghiphep : Form
	{

		BindingSource donNghiPhepList = new BindingSource();

		private List<string> staffNames = new List<string>();
		public fQuanlydangkynghiphep()
		{
			InitializeComponent();
			dgv_donnghiphep.DataSource = donNghiPhepList;
			LoadDonNghiPhep(txb_manhanvien.Text);
			LoadStaffNames();
			LoadCbLoaiPhep();
			SetupAutoCompleteForNguoiDuyet();
			LoadCbTrangThai();
		}
		void BindingDonNghiPhepData()
		{
			txb_tennhanvien.DataBindings.Clear();
			cb_loaiphep.DataBindings.Clear();
			txb_lydo.DataBindings.Clear();
			dtp_ngaybatdau.DataBindings.Clear();
			dtp_ngayketthuc.DataBindings.Clear();
			cb_trangthai.DataBindings.Clear();
			txb_nguoiduyet.DataBindings.Clear();

			txb_tennhanvien.DataBindings.Add(new Binding("Text", dgv_donnghiphep.DataSource, "TenNV", true, DataSourceUpdateMode.Never));
			cb_loaiphep.DataBindings.Add(new Binding("Text", dgv_donnghiphep.DataSource, "LoaiPhep", true, DataSourceUpdateMode.Never));
			txb_lydo.DataBindings.Add(new Binding("Text", dgv_donnghiphep.DataSource, "LyDo", true, DataSourceUpdateMode.Never));
			dtp_ngaybatdau.DataBindings.Add(new Binding("Value", dgv_donnghiphep.DataSource, "NgayBD", true, DataSourceUpdateMode.Never));
			dtp_ngayketthuc.DataBindings.Add(new Binding("Value", dgv_donnghiphep.DataSource, "NgayKT", true, DataSourceUpdateMode.Never));
			cb_trangthai.DataBindings.Add(new Binding("Text", dgv_donnghiphep.DataSource, "TrangThai", true, DataSourceUpdateMode.Never));
			txb_nguoiduyet.DataBindings.Add(new Binding("Text", dgv_donnghiphep.DataSource, "NguoiDuyet", true, DataSourceUpdateMode.Never));

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
		void LoadCbTrangThai()
		{
			List<string> trangThai = new List<string>()
			{
				"Chờ duyệt", "Đã duyệt", "Từ chối"
			};
			cb_trangthai.DataSource = trangThai;
		}

		private void btn_findnv_Click(object sender, System.EventArgs e)
		{
			LoadDonNghiPhep(txb_manhanvien.Text);
		}

		private void btn_adddonnghiphep_Click(object sender, System.EventArgs e)
		{
			string manv = txb_manhanvien.Text;
			try
			{
				string tennv = txb_tennhanvien.Text;
				string loaiphep = cb_loaiphep.Text;
				string trangthai = cb_trangthai.Text;
				string lydo = txb_lydo.Text;
				DateTime ngaybd = dtp_ngaybatdau.Value;
				DateTime ngaykt = dtp_ngayketthuc.Value;
				string nguoiduyet = txb_nguoiduyet.Text;

				if (DonnghiphepDAO.Instance.InsertDonNghiPhep(tennv,loaiphep,trangthai,lydo,ngaybd,ngaykt,nguoiduyet))
				{
					MessageBox.Show("Thêm đơn nghỉ phép thành công");
					LoadDonNghiPhep(manv);
				}
				else
				{
					MessageBox.Show("Thêm đơn nghỉ phép thất bại");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error: " + ex.Message, "ThongBao", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
				string trangthai = cb_trangthai.Text;
				string lydo = txb_lydo.Text;
				DateTime ngaybd = dtp_ngaybatdau.Value;
				DateTime ngaykt = dtp_ngayketthuc.Value;
				string nguoiduyet = txb_nguoiduyet.Text;

				if (DonnghiphepDAO.Instance.UpdateDonNghiPhep(madonnghiphep, tennv, loaiphep, trangthai, lydo, ngaybd, ngaykt, nguoiduyet))
				{
					MessageBox.Show("Sửa đơn nghỉ phép thành công");
					LoadDonNghiPhep(manv);
				}
				else
				{
					MessageBox.Show("Sửa đơn nghỉ phép thất bại");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error: " + ex.Message, "ThongBao", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				LoadDonNghiPhep(manv);
			}
		}

		private void btn_deletedonnghiphep_Click(object sender, EventArgs e)
		{
			string manv = txb_manhanvien.Text;
			try
			{
				int madonnghiphep = Convert.ToInt32(dgv_donnghiphep.CurrentRow.Cells["MaDonNghiPhep"].Value);

				if (DonnghiphepDAO.Instance.DeleteDonNghiPhep(madonnghiphep))
				{
					MessageBox.Show("Xóa đơn nghỉ phép thành công");
					LoadDonNghiPhep(manv);
				}
				else
				{
					MessageBox.Show("Xóa đơn nghỉ phép thất bại");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error: " + ex.Message, "ThongBao", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

	}
}
