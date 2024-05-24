using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace task1
{
	public partial class Form1 : Form
	{
		private OleDbConnection connection = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.16.0;Data Source=DatabaseTurist.accdb");

		public Form1()
		{
			InitializeComponent();
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			try
			{
				connection.Open();
				MessageBox.Show("Соединение установлено");
			}
			catch (Exception ex)
			{
				MessageBox.Show("Ошибка соединения: " + ex.Message);
			}
			finally
			{
				connection.Close();
			}

		}
		private void SelectAllTours()
		{
			string query = "SELECT * FROM Tours";
			OleDbDataAdapter adapter = new OleDbDataAdapter(query, connection);
			DataTable dt = new DataTable();
			adapter.Fill(dt);
			dataGridView1.DataSource = dt;
		}
		private void DeleteTour(int tourId)
		{
			string query = $"DELETE FROM Tours WHERE TourId = {tourId}";
			OleDbCommand command = new OleDbCommand(query, connection);
			try
			{
				connection.Open();
				command.ExecuteNonQuery();
				MessageBox.Show("Тур удален");
			}
			catch (Exception ex)
			{
				MessageBox.Show("Ошибка удаления тура: " + ex.Message);
			}
			finally
			{
				connection.Close();
			}
		}
		private void AddTourist(string surname, string firstName, string patronymic)
		{
			string query = $"INSERT INTO Tourists (Surname, FirstName, Patronymic) VALUES ('{surname}', '{firstName}', '{patronymic}')";
			OleDbCommand command = new OleDbCommand(query, connection);
			try
			{
				connection.Open();
				command.ExecuteNonQuery();
				MessageBox.Show("Турист добавлен");
			}
			catch (Exception ex)
			{
				MessageBox.Show("Ошибка добавления туриста: " + ex.Message);
			}
			finally
			{
				connection.Close();
			}
		}
		private void UpdateTourist(int touristId, string newSurname, string newFirstName, string newPatronymic)
		{
			string query = $"UPDATE Tourists SET Surname = '{newSurname}', FirstName = '{newFirstName}', Patronymic = '{newPatronymic}' WHERE TouristId = {touristId}";
			OleDbCommand command = new OleDbCommand(query, connection);
			try
			{
				connection.Open();
				command.ExecuteNonQuery();
				MessageBox.Show("Турист изменен");
			}
			catch (Exception ex)
			{
				MessageBox.Show("Ошибка изменения туриста: " + ex.Message);
			}
			finally
			{
				connection.Close();
			}
		}

		private void btnAddTourist_Click(object sender, EventArgs e)
		{
			string surname = txtAddSurname.Text;
			string firstName = txtAddFirstName.Text;
			string patronymic = txtAddPatronymic.Text;
			AddTourist(surname, firstName, patronymic);
			SelectAllTours();
		}

		private void btnUpdateTourist_Click(object sender, EventArgs e)
		{
			int touristIdToUpdate;
			if (int.TryParse(txtUpdateTouristId.Text, out touristIdToUpdate))
			{
				string newSurname = txtUpdateSurname.Text;
				string newFirstName = txtUpdateFirstName.Text;
				string newPatronymic = txtUpdatePatronymic.Text;

				UpdateTourist(touristIdToUpdate, newSurname, newFirstName, newPatronymic);
				SelectAllTours(); 
			}
			else
			{
				MessageBox.Show("Некорректный идентификатор туриста");
			}
		}

		private void btnDeleteTour_Click(object sender, EventArgs e)
		{
			int tourIdToDelete;
			if (int.TryParse(txtTourIdToDelete.Text, out tourIdToDelete))
			{
				DeleteTour(tourIdToDelete);
			}
			else
			{
				MessageBox.Show("Некорректный идентификатор тура");
			}
		}
	}
}
