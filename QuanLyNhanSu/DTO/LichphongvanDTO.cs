using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu.DTO
{
	public class LichphongvanDTO
	{
		string maPV;

		string maHS;

		string tenUV;

		DateTime ngayPV;

		TimeSpan thoigianPV;

		string diaDiem;

		string nguoiPV;

		string trangThai;

		public LichphongvanDTO(string maPV, string tenUV, TimeSpan thoiGianPV, string diaDiem, string nguoiPV, DateTime ngayPV, string trangThai, string maHS)
		{
			this.MaPV = maPV;
			this.TenUV = tenUV;
			this.ThoigianPV = thoiGianPV;
			this.DiaDiem = diaDiem;
			this.NguoiPV = nguoiPV;
			this.NgayPV = ngayPV;
			this.TrangThai = trangThai;
			this.maHS=maHS;
		}

		public LichphongvanDTO(DataRow row)
		{
			this.MaPV=row["Ma_PV"].ToString();
			this.TenUV=row["HoTen"].ToString();
			this.NguoiPV=row["NguoiPV"].ToString();
			this.NgayPV=Convert.ToDateTime(row["NgayPV"]);
			this.ThoigianPV = TimeSpan.Parse(row["ThoiGianPV"].ToString());
			this.TrangThai=row["TrangThai"].ToString();
			this.DiaDiem=row["DiaDiem"].ToString() ;
			this.maHS = row["Ma_HS"].ToString();
		}


		public string MaPV { get => maPV; set => maPV=value; }
		public string TenUV { get => tenUV; set => tenUV=value; }

		public string NguoiPV { get => nguoiPV; set => nguoiPV=value; }
		public string TrangThai { get => trangThai; set => trangThai=value; }
		public string DiaDiem { get => diaDiem; set => diaDiem=value; }
		public DateTime NgayPV { get => ngayPV; set => ngayPV=value; }
		public string MaHS { get => maHS; set => maHS=value; }
		public TimeSpan ThoigianPV { get => thoigianPV; set => thoigianPV=value; }
	}
}
