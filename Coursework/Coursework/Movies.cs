﻿using System;
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
    public partial class Movies : Form
    {
        DB db = new DB();
        public Movies()
        {
            InitializeComponent();
            db.ShowTable(datafilm, "Movies");
        }

        private void menu_Click(object sender, EventArgs e)
        {
            this.Close();
            mainmenu mn = new mainmenu();
            mn.Show();
        }
    }
}
