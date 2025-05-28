using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu.DTO
{
	public class KycongDTO
	{
		public KycongDTO(int maKyCong, int nam, int thang, bool khoa, DateTime ngayTinhCong, int ngayCong, string kyCong)
		{
			this.MaKyCong = maKyCong;
			this.Nam = nam;
			this.Thang = thang;
			this.NgayTinhCong = ngayTinhCong;
			this.NgayCong = ngayCong;
			this.KyCong = KyCong;
		}

		public KycongDTO(DataRow row)
		{
			this.MaKyCong = (int)row["MaKyCong"];
			this.Nam = (int)row["Nam"];
			this.Thang = (int)row["Thang"];
			this.NgayTinhCong = (DateTime)row["NgayTinhCong"];
			this.NgayCong = Convert.ToInt32(row["NgayCongTongThang"]);
			this.KyCong = row["KyCong"].ToString();
		}
		private int maKyCong;

		private int nam;

		private int thang;

		private bool khoa;

		private DateTime ngayTinhCong;

		private int ngayCong;

		private string kyCong;

		public int Nam { get => nam; set => nam=value; }
		public int Thang { get => thang; set => thang=value; }
		public DateTime NgayTinhCong { get => ngayTinhCong; set => ngayTinhCong=value; }
		public int MaKyCong { get => maKyCong; set => maKyCong=value; }
		public int NgayCong { get => ngayCong; set => ngayCong=value; }
		public string KyCong { get => kyCong; set => kyCong=value; }
	}
}
