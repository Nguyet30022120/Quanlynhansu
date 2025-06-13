using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu.DTO
{
	public class PhucapDTO
	{
		public PhucapDTO(string maPhuCap, string tenNV, string loaiPhuCap, decimal soTienPhuCap, string maNV)
		{
			this.MaPhuCap = maPhuCap;
			this.MaNV = maNV;
			this.TenNV = tenNV;
			this.LoaiPhuCap = loaiPhuCap;
			this.SoTienPhuCap = soTienPhuCap;
		}

		public PhucapDTO(DataRow row)
		{
			this.MaPhuCap = row["Ma_PC"].ToString();
			this.MaNV = row["Ma_NV"].ToString();
			this.TenNV = row["HoTen"].ToString();
			this.LoaiPhuCap = row["LoaiPhuCap"].ToString();
			this.SoTienPhuCap = Convert.ToDecimal(row["SoTienPhuCap"]);
		}

		private string maPhuCap;

		private string maNV;

		private string tenNV;

		private string loaiPhuCap;

		private decimal soTienPhuCap;

		public string MaPhuCap { get => maPhuCap; set => maPhuCap=value; }
		public string MaNV { get => maNV; set => maNV=value; }
		public string TenNV { get => tenNV; set => tenNV=value; }
		public string LoaiPhuCap { get => loaiPhuCap; set => loaiPhuCap=value; }
		public decimal SoTienPhuCap { get => soTienPhuCap; set => soTienPhuCap=value; }
	}
}
