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
    
    public partial class TVSeries_Genres : Form
    {
        DB db = new DB();
        public TVSeries_Genres()
        {

            InitializeComponent();
            db.ShowTable(tvdata, "TVSeries_Genres");
        }

        private void tvdata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
            mainmenu mn = new mainmenu();
            mn.Show();
        }
    }
}
