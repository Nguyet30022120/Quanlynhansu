using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Security.AccessControl;

namespace QuanLyNhanSu.DTO
{
	public class AccountDTO
	{
		public AccountDTO(string maTK, string taiKhoan,  string moTaQuyenHan, string vaiTro, string matKhau = null)
		{
			this.MaTK = maTK;
			this.TaiKhoan = taiKhoan;
			this.MatKhau = matKhau;
			this.MoTaQuyenHan = moTaQuyenHan;
			this.VaiTro = vaiTro;
		}
		
		public AccountDTO(DataRow row) 
		{
			this.MaTK = row["Ma_TK"].ToString();
			this.TaiKhoan = row["TaiKhoan"].ToString();
			this.MoTaQuyenHan = row["MoTaQuyenHan"].ToString();
			this.MatKhau = row["MatKhau"].ToString();
			this.VaiTro = row["VaiTro"].ToString() ;
		}

		private string maTK;

		private string taiKhoan;
		
		private string matKhau;

		private string moTaQuyenHan;

		private string vaiTro;

		public string MaTK { get => maTK; set => maTK=value; }
		//dấu => thay thế cho dấu {} 
		public string TaiKhoan { get => taiKhoan; set => taiKhoan=value; }
		public string MatKhau { get => matKhau; set => matKhau=value; }
		public string MoTaQuyenHan { get => moTaQuyenHan; set => moTaQuyenHan=value; }
		public string VaiTro { get => vaiTro; set => vaiTro=value; }
	}
}
