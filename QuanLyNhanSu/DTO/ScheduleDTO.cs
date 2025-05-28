using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu.DTO
{
	public class ScheduleDTO
	{
		string maPV;

		string tenUV;

		DateTime ngayPV;

		DateTime thoiGianPV;

		string diaDiem;

		string nguoiPV;

		string trangThai;

		public ScheduleDTO(string maPV, string tenUV, DateTime thoiGianPV, string diaDiem, string nguoiPV, DateTime ngayPV, string trangThai)
		{
			this.MaPV = maPV;
			this.TenUV = tenUV;
			this.ThoiGianPV = thoiGianPV;
			this.DiaDiem = diaDiem;
			this.NguoiPV = nguoiPV;
			this.NgayPV = ngayPV;
			this.TrangThai = trangThai;
		}

		public ScheduleDTO(DataRow row)
		{
			this.MaPV=row["Ma_PV"].ToString();
			this.TenUV=row["HoTen"].ToString();
			this.NguoiPV=row["NguoiPV"].ToString();
			this.NgayPV=Convert.ToDateTime(row["NgayPV"]);
			this.ThoiGianPV = NgayPV.Date + ((TimeSpan)row["ThoigianPV"]);
			this.TrangThai=row["TrangThai"].ToString();
			this.DiaDiem=row["DiaDiem"].ToString() ;
		}


		public string MaPV { get => maPV; set => maPV=value; }
		public string TenUV { get => tenUV; set => tenUV=value; }
		public DateTime ThoiGianPV { get => thoiGianPV; set => thoiGianPV=value; }
		public string NguoiPV { get => nguoiPV; set => nguoiPV=value; }
		public string TrangThai { get => trangThai; set => trangThai=value; }
		public string DiaDiem { get => diaDiem; set => diaDiem=value; }
		public DateTime NgayPV { get => ngayPV; set => ngayPV=value; }
	}
}
