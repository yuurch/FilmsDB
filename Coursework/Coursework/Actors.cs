using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Relational;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coursework
{
    public partial class Actors : Form
    {
        DB db = new DB();
        public Actors()
        {
            InitializeComponent();
           db.ShowTable(dataGridView1,"Actors");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            mainmenu mn = new mainmenu();
            mn.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                DB db = new DB();
                MySqlCommand comm = new MySqlCommand("INSERT INTO Actors (first_name, last_name, birth_date) VALUES (@fN, @lN, @bD)", db.getConnection());

                comm.Parameters.Add("@fN", MySqlDbType.VarChar).Value = actorname.Text;
                comm.Parameters.Add("@lN", MySqlDbType.VarChar).Value = surnameactor.Text;
                comm.Parameters.Add("@bD", MySqlDbType.VarChar).Value = date.Text;

                db.openConnection();

                if (comm.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Інформація додана успішно!", "Успіх!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    db.ShowTable(dataGridView1, "Actors");
                    actorname.Text = null;
                    surnameactor.Text = null;
                    date.Text = null;
                }
                else
                    MessageBox.Show("Відхилено!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                db.closeConnection();
            }
            catch (FormatException)
            {
                MessageBox.Show("Не вірно введений формат данних!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                DB db = new DB();
                MySqlCommand comm = new MySqlCommand("DELETE FROM Actors WHERE first_name = @fN AND last_name = @lN AND birth_date = @bD", db.getConnection());

                comm.Parameters.Add("@fN", MySqlDbType.VarChar).Value = actorname.Text;
                comm.Parameters.Add("@lN", MySqlDbType.VarChar).Value = surnameactor.Text;
                comm.Parameters.Add("@bD", MySqlDbType.VarChar).Value = date.Text;

                db.openConnection();

                if (comm.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Інформація видалена успішно!", "Успіх!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    db.ShowTable(dataGridView1, "Actors");
                    actorname.Text = null;
                    surnameactor.Text = null;
                    date.Text = null;
                }
                else
                    MessageBox.Show("Відхилено!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                db.closeConnection();
            }
            catch (FormatException)
            {
                MessageBox.Show("Не вірно введений формат данних!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                DB db = new DB();
                MySqlCommand comm = new MySqlCommand("UPDATE Actors SET first_name = @fN, last_name = @lN , birth_date = @bD WHERE actor_id = @aID", db.getConnection());

                comm.Parameters.Add("@fN", MySqlDbType.VarChar).Value = actorname.Text;
                comm.Parameters.Add("@lN", MySqlDbType.VarChar).Value = surnameactor.Text;
                comm.Parameters.Add("@bD", MySqlDbType.VarChar).Value = date.Text;
                comm.Parameters.Add("@aID", MySqlDbType.Decimal).Value = ID.Text;

                db.openConnection();

                if (comm.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Інформація змінена успішно!", "Успіх!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    db.ShowTable(dataGridView1, "Actors");
                    actorname.Text = null;
                    surnameactor.Text = null;
                    date.Text = null;
                    ID.Text = null;
                }
                else
                    MessageBox.Show("Відхилено!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);

                db.closeConnection();
            }
            catch (FormatException)
            {
                MessageBox.Show("Не вірно введений формат данних!", "Помилка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
