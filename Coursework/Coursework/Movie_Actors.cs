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
    public partial class Movie_Actors : Form
    {
        DB db = new DB();
        public Movie_Actors()
        {
            InitializeComponent();
            db.ShowTable(magrid, "Movie_Actors");
        }

        private void magrid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void menum_Click(object sender, EventArgs e)
        {
            this.Close();
            mainmenu mn = new mainmenu();
            mn.Show();
        }

        private void actoadd_Click(object sender, EventArgs e)
        {
            try
            {
                DB db = new DB();
                MySqlCommand comm = new MySqlCommand("INSERT INTO Movie_Actors (actor_id) VALUES (@aID)", db.getConnection());

                
                comm.Parameters.Add("@aID", MySqlDbType.VarChar).Value = actorbox.Text;
              

                db.openConnection();

                if (comm.ExecuteNonQuery() > 0)
                {
                    MessageBox.Show("Інформація додана успішно!", "Успіх!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    db.ShowTable(magrid, "Movie_Actors");
                    moviebox.Text = null;
                    actorbox.Text = null;
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
