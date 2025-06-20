﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu.DTO
{
	public class KhoahocDTO
	{
		public KhoahocDTO(string maKhoaHoc, string tenKhoaHoc, string moTaKhoaHoc)
		{
			this.MaKhoaHoc = maKhoaHoc;
			this.TenKhoaHoc = tenKhoaHoc;
			this.MoTaKhoaHoc = moTaKhoaHoc;
		}

		public KhoahocDTO(DataRow row)
		{
			this.MaKhoaHoc = row["Ma_KH"].ToString();
			this.TenKhoaHoc = row["TenKhoaHoc"].ToString();
			this.MoTaKhoaHoc = row["MoTa"].ToString();
		}


		private string maKhoaHoc;

		private string tenKhoaHoc;

		private string moTaKhoaHoc;

		public string MaKhoaHoc { get => maKhoaHoc; set => maKhoaHoc=value; }
		public string TenKhoaHoc { get => tenKhoaHoc; set => tenKhoaHoc=value; }
		public string MoTaKhoaHoc { get => moTaKhoaHoc; set => moTaKhoaHoc=value; }
	}
}
