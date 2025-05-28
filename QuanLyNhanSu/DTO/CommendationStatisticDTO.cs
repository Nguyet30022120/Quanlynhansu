using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu.DTO
{
	public class CommendationStatisticDTO
	{
		public CommendationStatisticDTO(string tenNV, string maNV, int nam, int khenThuong, int kyLuat)
		{
			this.tenNV = tenNV;
			this.maNV = maNV;
			this.nam = nam;
			this.khenThuong = khenThuong;
			this.kyLuat = kyLuat;
		}
		public CommendationStatisticDTO(DataRow row)
		{
			this.tenNV = row["HoTen"].ToString();
			this.maNV = row["Ma_NV"].ToString();
			this.nam = (int)row["Nam"];
			this.khenThuong = (int)row["KhenThuong"];
			this.kyLuat = (int)row["KyLuat"];
		}

		private string tenNV;

		private string maNV;

		private int nam;

		private int khenThuong;

		private int kyLuat;

		public string TenNV { get => tenNV; set => tenNV=value; }
		public string MaNV { get => maNV; set => maNV=value; }
		public int Nam { get => nam; set => nam=value; }
		public int KhenThuong { get => khenThuong; set => khenThuong=value; }
		public int KyLuat { get => kyLuat; set => kyLuat=value; }
	}
}
