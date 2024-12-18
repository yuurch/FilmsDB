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
    public partial class User_Viewed : Form
    {
        DB db = new DB();
        public User_Viewed()
        {
            InitializeComponent();
            db.ShowTable(userdata, "User_Viewed");
        }

        private void userdata_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void userg_Click(object sender, EventArgs e)
        {
            this.Close();
            mainmenu mn = new mainmenu();
            mn.Show();
        }
    }
}
