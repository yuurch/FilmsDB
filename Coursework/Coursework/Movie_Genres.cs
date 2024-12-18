using MySql.Data.MySqlClient;
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
    public partial class Movie_Genres : Form
    {
        DB db = new DB();
        public Movie_Genres()
        {
            InitializeComponent();
            db.ShowTable(dataGridView1, "Movie_Genres");
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
          private void gmovie_Click(object sender, EventArgs e)
        {
            this.Close();
            mainmenu mn = new mainmenu();
            mn.Show();
        }

        private void movieadd_Click(object sender, EventArgs e)
        {
            try
            {
                DB db = new DB();
                MySqlCommand comm = new MySqlCommand("INSERT INTO Movie_Genres (movie_id, genre_id) VALUES (@mID, @gID)", db.getConnection());

                comm.Parameters.Add("@mID", MySqlDbType.VarChar).Value = film.Text;
                comm.Parameters.Add("@gID", MySqlDbType.VarChar).Value = genre.Text;
              

                db.openConnection();

                if (comm.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Інформація додана успішно!", "Успіх!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    db.ShowTable(dataGridView1, "Movie_Genres");
                    film.Text = null;
                    genre.Text = null;
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

        private void delmovie_Click(object sender, EventArgs e)
        {
            try
            {
                DB db = new DB();
                MySqlCommand comm = new MySqlCommand("DELETE FROM Movie_Genres WHERE movie_id = @mID AND genre_id = @gID", db.getConnection());

                comm.Parameters.Add("@mID", MySqlDbType.VarChar).Value = film.Text;
                comm.Parameters.Add("@gID", MySqlDbType.VarChar).Value = genre.Text;

                db.openConnection();

                if (comm.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Інформація видалена успішно!", "Успіх!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    db.ShowTable(dataGridView1, "Movie_Genres");
                    film.Text = null;
                    genre.Text = null;
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

        private void editmovie_Click(object sender, EventArgs e)
        {
            try
            {
                DB db = new DB();
                MySqlCommand comm = new MySqlCommand("UPDATE Movie_Genres SET movie_id, genre_id = @gID", db.getConnection());

                comm.Parameters.Add("@mID", MySqlDbType.VarChar).Value = film.Text;
                comm.Parameters.Add("@gID", MySqlDbType.VarChar).Value = genre.Text;

                db.openConnection();

                if (comm.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Інформація змінена успішно!", "Успіх!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    db.ShowTable(dataGridView1, "Movie_Genres");
                    film.Text = null;
                    genre.Text = null;
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

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Close();
            mainmenu mn = new mainmenu();
            mn.Show();
        }
    }
}
