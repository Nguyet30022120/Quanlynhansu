using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanSu.GUI
{
	public partial class fQuanlydangkylichlamviec : Form
	{
		private void Form1_Load(object sender, EventArgs e)
		{
			// Hiển thị chỉ ngày trong tuần hiện tại (7 ngày)
			DateTime today = DateTime.Today;
			monthCalendar1.BoldedDates = new DateTime[] { today };
			monthCalendar1.SelectionRange = new SelectionRange(today, today.AddDays(6));
		}

		public fQuanlydangkylichlamviec()
		{
			InitializeComponent();
		}
	}
}
