using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu.DTO
{
	public class ThongketuyendungDTO
	{
		string ketQua;

		int soLuong;

		int nam;

		int thang;

		public ThongketuyendungDTO(string ketQua, int soLuong,int nam, int thang)
		{
			this.ketQua = ketQua;
			this.soLuong = soLuong;
			this.nam = nam;
			this.thang = thang;
		}

		public ThongketuyendungDTO(DataRow row)
		{
			this.KetQua = row["KetQua"].ToString();
			this.SoLuong = Convert.ToInt32(row["SoLuong"]);
			this.Nam = Convert.ToInt32(row["Nam"]);
			this.Thang = Convert.ToInt32(row["Thang"]);
		}

		public string KetQua { get => ketQua; set => ketQua=value; }
		public int SoLuong { get => soLuong; set => soLuong=value; }
		public int Nam { get => nam; set => nam=value; }
		public int Thang { get => thang; set => thang=value; }
	}
}
