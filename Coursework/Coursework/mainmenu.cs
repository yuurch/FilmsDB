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
    public partial class mainmenu : Form
    {
        public mainmenu()
        {
            InitializeComponent();
        }

        private void mainmenu_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Actors actors = new Actors();
            actors.Show();  
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Hide();
            Movie_Genres mg = new Movie_Genres();
            mg.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
                Movie_Actors ma = new Movie_Actors();
            ma.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
                TVSeries_Actors tv = new TVSeries_Actors();
            tv.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Hide();
            Genres ge = new Genres();
            ge.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Hide();
            Movies mv = new Movies();   
            mv.Show();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            this.Hide();
            TVSeries_Genres tg =    new TVSeries_Genres();
            tg.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            this.Hide();
            User_Viewed uv = new User_Viewed();
            uv.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            this.Hide();
            TVSeries tss= new TVSeries();
            tss.Show();
        }
    }
}
