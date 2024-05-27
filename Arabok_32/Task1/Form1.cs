using System;
using System.Data;
using System.Data.OleDb;
using System.Configuration;
using System.Windows.Forms;

namespace Task1
{
    public partial class Form1 : Form
    {
        DataSet dataSet;
        BindingSource bindingSource1;
        BindingSource bindingSource2;

        public Form1()
        {
            InitializeComponent();
            InitializeBindings();
            LoadData();
            BindData();
        }

        private void InitializeBindings()
        {
            bindingSource1 = new BindingSource();
            bindingSource2 = new BindingSource();
            dataGridView1.DataSource = bindingSource1;
            dataGridView2.DataSource = bindingSource2;
            bindingNavigator1.BindingSource = bindingSource1; 
        }

        private void LoadData()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["DbConnectionString"].ConnectionString;
            using (OleDbConnection connection = new OleDbConnection(connectionString))
            {
                dataSet = new DataSet();

                string[] tableNames = { "Туристы", "Туры" };

                foreach (string tableName in tableNames)
                {
                    OleDbDataAdapter adapter = new OleDbDataAdapter($"SELECT * FROM {tableName}", connection);
                    adapter.Fill(dataSet, tableName);
                }
            }
        }

        private void BindData()
        {
            bindingSource1.DataSource = dataSet.Tables[0];
            bindingSource2.DataSource = dataSet.Tables[1];


            textBox1.DataBindings.Add("Text", bindingSource1, "Фамилия"); 
            textBox2.DataBindings.Add("Text", bindingSource1, "Имя"); 
            textBox3.DataBindings.Add("Text", bindingSource1, "Отчество"); 
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentRow != null)
            {
                var row = ((DataRowView)dataGridView1.CurrentRow.DataBoundItem).Row;
                if (row != null)
                {
                    textBox1.Text = row["Фамилия"].ToString(); 
                    textBox2.Text = row["Имя"].ToString(); 
                    textBox3.Text = row["Отчество"].ToString(); 
                }
            }
        }
    }
}
