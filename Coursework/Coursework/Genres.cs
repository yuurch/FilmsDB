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
    public partial class Genres : Form
    {
        DB db = new DB();
        public Genres()
        {
            InitializeComponent();
            db.ShowTable(datagenres, "TVSeries_Actors");
        }

        private void datagenres_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ggenres_Click(object sender, EventArgs e)
        {
            this.Close();
            mainmenu mn = new mainmenu();
            mn.Show();
        }
    }
}
