﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paid2Play
{
    public partial class SignInPage : Form
    {
        public SignInPage()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // this is the button for the sign-up part of the form 
            // we want this button to log the email and password and pass it to our database and save it there so they can log in later 
            // we also want for this to bring us to the homepage
            mysql z = new mysql();
            z.connect();
            string user = upEMailTBOX.Text;
            string pass = UppwordTBOX.Text;
            z.addUser(user, pass);
            this.Hide();
            Home x = new Home();
            x.Show();
            
            



        }

        private void button1_Click(object sender, EventArgs e)
        {
            // this is the button for the sign in part of the form 
            // we want this to check the dredentials against our database and if they pass to bring up the homepage
            //if they dont pass pop up a message box
            mysql z = new mysql();
            z.connect();
            string user = InEmailtBOX.Text;
            string pass = INpwordtBOX.Text;
            bool check = z.verifyUser(user, pass);
            if(check == true)
            {
                this.Hide();
                Home x = new Home();
                x.Show();
            }
            else
            {
                MessageBox.Show("invalid username or password");
            }

           
        }

        private void SignInPage_Load(object sender, EventArgs e)
        {

        }
    }
}
