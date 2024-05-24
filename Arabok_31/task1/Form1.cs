using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task1
{
	public partial class Form1 : Form
	{
		private string connectionString = "your_connection_string";
		public Form1()
		{
			InitializeComponent();
		}
		private void button1_Click(object sender, EventArgs e)
		{
			туристыTableAdapter.Update(DatabaseTuristDataSet);
			информация_о_туристахTableAdapter.Update(DatabaseTuristDataSet);

		}
		private void SelectAllTours()
		{
			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				connection.Open();
				SqlDataAdapter adapter = new SqlDataAdapter("SELECT * FROM Tours", connection);
				DataTable dataTable = new DataTable();
				adapter.Fill(dataTable);
				// Assuming you have a DataGridView named dataGridViewTours
				dataGridView1.DataSource = dataTable;
			}
		}

		private void DeleteTour(int tourId)
		{
			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				connection.Open();
				SqlCommand command = new SqlCommand("DELETE FROM Tours WHERE TourId = @TourId", connection);
				command.Parameters.AddWithValue("@TourId", tourId);
				command.ExecuteNonQuery();
			}
		}

		private void AddTourist(string lastName, string firstName, string middleName)
		{
			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				connection.Open();
				SqlCommand command = new SqlCommand("INSERT INTO Tourists (LastName, FirstName, MiddleName) VALUES (@LastName, @FirstName, @MiddleName)", connection);
				command.Parameters.AddWithValue("@LastName", lastName);
				command.Parameters.AddWithValue("@FirstName", firstName);
				command.Parameters.AddWithValue("@MiddleName", middleName);
				command.ExecuteNonQuery();
			}
		}

		private void UpdateTourist(int touristId, string lastName, string firstName, string middleName)
		{
			using (SqlConnection connection = new SqlConnection(connectionString))
			{
				connection.Open();
				SqlCommand command = new SqlCommand("UPDATE Tourists SET LastName = @LastName, FirstName = @FirstName, MiddleName = @MiddleName WHERE TouristId = @TouristId", connection);
				command.Parameters.AddWithValue("@TouristId", touristId);
				command.Parameters.AddWithValue("@LastName", lastName);
				command.Parameters.AddWithValue("@FirstName", firstName);
				command.Parameters.AddWithValue("@MiddleName", middleName);
				command.ExecuteNonQuery();
			}
		}
	}
}
