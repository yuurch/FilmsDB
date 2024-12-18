using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Coursework
{
    public partial class TVSeries : Form
    {
        DB db = new DB();
        public TVSeries()
        {
            InitializeComponent();
            db.ShowTable(sdata, "TVSeries");
        }

        private void sdata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void menu_Click(object sender, EventArgs e)
        {
            this.Close();
            mainmenu mn = new mainmenu();
            mn.Show();
        }
    }
}
