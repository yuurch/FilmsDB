using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Coursework
{
    public partial class TVSeries_Actors : Form
    {
        DB db = new DB();
        public TVSeries_Actors()
        {
            InitializeComponent();
            db.ShowTable(datatv, "TVSeries_Actors");
        }

        private void gtv_Click(object sender, EventArgs e)
        {
            this.Close();
            mainmenu mn = new mainmenu();
            mn.Show();
        }
    }
}
