using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu.DTO
{
	public class HRStatisticPBDTO
	{
		public HRStatisticPBDTO(string phongBan, int soLuong)
		{
			this.PhongBan = phongBan;
			this.SoLuong = soLuong;
		}

		public HRStatisticPBDTO(DataRow row)
		{
			this.PhongBan = row["PhongBan"].ToString();
			this.SoLuong = (int)row["SoLuong"];
		}

		private string phongBan;

		private int soLuong;

		public string PhongBan { get => phongBan; set => phongBan=value; }
		public int SoLuong { get => soLuong; set => soLuong=value; }
	}
}