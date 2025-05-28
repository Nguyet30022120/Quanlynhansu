using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu.DTO
{
	public class LevelDTO
	{
		public LevelDTO(string maTD, string tenNV, string loaiBC, string chuyenNganh, string truongHoc, string maNV)
		{
			this.maTD = maTD;
			this.tenNV = tenNV;
			this.loaiBC = loaiBC;
			this.chuyenNganh = chuyenNganh;
			this.truongHoc = truongHoc;
			//this.maNV = maNV;
		}

		public LevelDTO(DataRow row)
		{
			this.maTD = row["Ma_TD"].ToString();
			this.tenNV = row["TenNhanVien"].ToString();
			this.loaiBC = row["LoaiBangCap"].ToString();
			this.chuyenNganh = row["ChuyenNganh"].ToString();
			this.truongHoc = row["TruongHoc"].ToString();
			//this.maNV = row["Ma_NV"].ToString();
		}
		private string tenNV;

		private string maTD;

		private string loaiBC;

		private string chuyenNganh;

		private string truongHoc;

		private string maNV;
		public string TenNV { get => tenNV; set => tenNV=value; }
		public string LoaiBC { get => loaiBC; set => loaiBC=value; }
		public string ChuyenNganh { get => chuyenNganh; set => chuyenNganh=value; }
		public string TruongHoc { get => truongHoc; set => truongHoc=value; }
		public string MaTD { get => maTD; set => maTD=value; }
		//public string MaNV { get => maNV; set => maNV=value; }
	}
}
