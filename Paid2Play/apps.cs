﻿using Paid2Play.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paid2Play
{
    public partial class apps : Form
    {
        public apps()
        {
            InitializeComponent();
        }
        
        private void homeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menu x = new menu();
            x.home();
        }

        private void profileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menu x = new menu();
            x.profile();
        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            menu x = new menu();
            x.signin();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mysql conn = new mysql();
            Process proc = new Process();
            proc.StartInfo.FileName = "https://www.dropbox.com/s/s8i5zhevhejxk9o/game.zip?dl=0";
            proc.StartInfo.UseShellExecute = true;
            proc.Start();
            Account x = new Account();
            string user = x.getName();
            string y = "1";
            decimal amount = System.Convert.ToDecimal(y);
            x.setCredits(user, amount);
            conn.connect();
            DateTime date = DateTime.Now;
            conn.addActivity("Asteroid", date.ToString());
            
   


        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void apps_Load(object sender, EventArgs e)
        {
            //images
            var Asteroids = Resources.asteroid;
          

            mysql conn = new mysql();
            conn.connect();
            string str = conn.getGame(1);
            string[] broken = new string[] { };
            broken = str.Split('1');
            string x = broken[0];
            dataGridView1.Rows.Add(new object[] { broken[0], broken[1], broken[2], Asteroids });

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
