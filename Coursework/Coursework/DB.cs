using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coursework
{
   
    internal class DB
    {

        MySqlConnection connection = new MySqlConnection("server=localhost;port=3306;username=root;password=1234;database=MovieDatabase");
        public MySqlConnection Connection => connection;

        public void openConnection()
        {
            if(connection.State == System.Data.ConnectionState.Closed)
                connection.Open();
        }

        public void closeConnection()
        {
            if (connection.State == System.Data.ConnectionState.Open)
                connection.Close();
        }

        public MySqlConnection getConnection()
        {
            return connection;
        }
        public void ShowTable(DataGridView dataGrid, string table)
        {

            DB bD = new DB();

            string query = $"SELECT * FROM `{table}`";
            try
            {
                bD.openConnection();

                // Створюємо DataAdapter для заповнення даних
                MySqlDataAdapter dataAdapter = new MySqlDataAdapter(query, bD.getConnection());

                // Створюємо DataTable, щоб зберегти дані
                DataTable dataTable = new DataTable();

                // Заповнюємо DataTable даними з бази
                dataAdapter.Fill(dataTable);

                // Встановлюємо DataSource для DataGridView
                dataGrid.DataSource = dataTable;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Помилка: " + ex.Message);
            }
        }
    }
}
