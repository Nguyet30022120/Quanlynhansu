using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyNhanSu.DAO
{
	public class DataProvider
	{
		private static DataProvider instance;

		private string connectionSTR = "Data Source=.;Initial Catalog=QuanLyNhanSu;Integrated Security=True;TrustServerCertificate=True";

		public static DataProvider Instance { get => instance == null ? instance = new DataProvider() : instance; private set => instance=value; }

		public DataTable ExecuteQuery(string query, object[] parameter = null)
		{
			DataTable data = new DataTable();

			using (SqlConnection connection = new SqlConnection(connectionSTR))
			{
				connection.Open();
				using (SqlCommand command = new SqlCommand(query, connection))
				{
					// Thêm tham số nếu có
					if (parameter != null)
					{
						// Tìm tất cả tham số bắt đầu bằng @ trong câu truy vấn
						string[] listPara = query.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
						int i = 0;
						foreach (string item in listPara)
						{
							if (item.StartsWith("@"))
							{
								command.Parameters.AddWithValue(item, parameter[i]);
								i++;
							}
						}
					}

					// Thực thi câu truy vấn và đổ dữ liệu vào DataTable
					using (SqlDataAdapter adapter = new SqlDataAdapter(command))
					{
						adapter.Fill(data);
					}
				}
			}
			return data;
		}
		// Trả về bảng dữ liệu

		public int ExcuteNonQuery(string query, object[] parameter = null)
		{
			int data = 0;

			using (SqlConnection connection = new SqlConnection(connectionSTR))
			{
				connection.Open();
				using (SqlCommand command = new SqlCommand(query, connection))
				{
					// Thêm tham số nếu có
					if (parameter != null)
					{
						// Tìm tất cả tham số bắt đầu bằng @ trong câu truy vấn
						string[] listPara = query.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
						int i = 0;
						foreach (string item in listPara)
						{
							if (item.StartsWith("@"))
							{
								command.Parameters.AddWithValue(item, parameter[i]);
								i++;
							}
						}
					}

					data = command.ExecuteNonQuery();
				}
			}
			return data;
		}
		// Sử dụng trong Update, Insert, Delete

		public object ExcuteScalar(string query, object[] parameter = null)
		{
			object data = 0;

			using (SqlConnection connection = new SqlConnection(connectionSTR))
			{
				connection.Open();
				using (SqlCommand command = new SqlCommand(query, connection))
				{
					// Thêm tham số nếu có
					if (parameter != null)
					{
						// Tìm tất cả tham số bắt đầu bằng @ trong câu truy vấn
						string[] listPara = query.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
						int i = 0;
						foreach (string item in listPara)
						{
							if (item.StartsWith("@"))
							{
								command.Parameters.AddWithValue(item, parameter[i]);
								i++;
							}
						}
					}

					data = command.ExecuteScalar();
				}
			}
			return data;
		}
		// Trả về kết quả

	}

}



