﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paid2Play
{
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }
       
        

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menu x = new menu();
            x.signin();
        }

        private void appsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menu x = new menu();
            x.apps();
        }

        private void profileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menu x = new menu();
            x.profile();
        }

        private void navMenu_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Home_Load(object sender, EventArgs e)
        {

        }
    }
}
