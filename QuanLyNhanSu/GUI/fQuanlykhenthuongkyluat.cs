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
	public partial class fQuanlykhenthuongkyluat : Form
	{

		BindingSource commendationList = new BindingSource();

		public fQuanlykhenthuongkyluat()
		{
			InitializeComponent();
			dgv_ktkl.DataSource = commendationList;
			LoadCbHinhThuc();
		}

		void BindingCommendationData()
		{
			// Clear old bindings
			txb_tennhanvien.DataBindings.Clear();
			txb_noidung.DataBindings.Clear();
			cb_hinhthuc.DataBindings.Clear();
			dtp_thoigian.DataBindings.Clear();
			txb_tennhanvien.DataBindings.Add(new Binding("Text", dgv_ktkl.DataSource, "TenNV", true, DataSourceUpdateMode.Never));
			txb_noidung.DataBindings.Add(new Binding("Text", dgv_ktkl.DataSource, "NoiDung", true, DataSourceUpdateMode.Never));
			cb_hinhthuc.DataBindings.Add(new Binding("Text", dgv_ktkl.DataSource, "HinhThuc", true, DataSourceUpdateMode.Never));
			dtp_thoigian.DataBindings.Add(new Binding("Value", dgv_ktkl.DataSource, "ThoiGian", true, DataSourceUpdateMode.Never));
		}
		void LoadCommendation(string manv)
		{
			commendationList.DataSource = KhenthuongkyluatDAO.Instance.GetCommendationsByMaNV(manv);
			BindingCommendationData();
		}
		void LoadCbHinhThuc()
		{
			List<KeyValuePair<int, string>> hinhthuc = new List<KeyValuePair<int, string>>()
			{
				new KeyValuePair<int, string>(1, "Khen thưởng"),
				new KeyValuePair<int, string>(0, "Kỷ luật")
			};
			cb_hinhthuc.DataSource = hinhthuc;
			cb_hinhthuc.DisplayMember = "Value";
			cb_hinhthuc.ValueMember = "Key";
		}

		private void btn_findnv_Click(object sender, EventArgs e)
		{
			LoadCommendation(txb_manhanvien.Text);
		}

		private void btn_addkt_Click(object sender, EventArgs e)
		{
			string manv = txb_manhanvien.Text;
			try
			{
				string noidung = txb_noidung.Text;
				int hinhthuc = (int)cb_hinhthuc.SelectedValue;
				DateTime thoigian = dtp_thoigian.Value;
				string tennv = txb_tennhanvien.Text;

				if (KhenthuongkyluatDAO.Instance.InsertCommendation(manv, noidung,hinhthuc,thoigian))
				{
					MessageBox.Show("Thêm khen thưởng/kỷ luật thành công");
					LoadCommendation(manv);
				}
				else
				{
					MessageBox.Show("Thêm khen thưởng/kỷ luật thất bại");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error: " + ex.Message, "ThongBao", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				LoadCommendation(manv);
			}
		}

		private void btn_editkt_Click(object sender, EventArgs e)
		{
			string manv = txb_manhanvien.Text;
			try
			{
				string maktkl = dgv_ktkl.CurrentRow.Cells["MaKTKL"].Value.ToString();
				string noidung = txb_noidung.Text;
				int hinhthuc = (int)cb_hinhthuc.SelectedValue;
				DateTime thoigian = dtp_thoigian.Value;
				string tennv = txb_tennhanvien.Text;

				if (KhenthuongkyluatDAO.Instance.UpdateCommendation(maktkl,noidung,hinhthuc,thoigian))
				{
					MessageBox.Show("Sửa khen thưởng/kỷ luật thành công.");
				}
				else
				{
					MessageBox.Show("Sửa khen thưởng/kỷ luật thất bại.");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error: " + ex.Message, "ThongBao", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				LoadCommendation(manv);
			}
		}

		private void btn_deletekt_Click(object sender, EventArgs e)
		{
			string manv = txb_manhanvien.Text;
			try
			{
				string matd = dgv_ktkl.CurrentRow.Cells["MaKTKL"].Value.ToString(); ;
				if (KhenthuongkyluatDAO.Instance.DeleteCommendation(matd))
				{
					MessageBox.Show("Xóa khen thưởng/kỷ luật thành công.");
				}
				else
				{
					MessageBox.Show("Xóa khen thưởng/kỷ luật thất bại.");
				}
			}
			catch (Exception ex)
			{
				MessageBox.Show("Error: " + ex.Message, "ThongBao", MessageBoxButtons.OK, MessageBoxIcon.Error);
			}
			finally
			{
				LoadCommendation(manv);
			}
		}

		private void btn_closekt_Click(object sender, EventArgs e)
		{
			this.Close();
		}

	}
	}

