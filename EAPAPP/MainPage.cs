﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EAPAPP
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }

 
        private void ButtonReg_Click(object sender, EventArgs e)
        {
            var formreg = new FormRegistrationPage();
            formreg.ShowDialog();
            formreg.Show();
        }

        private void ButtonLog_Click(object sender, EventArgs e)
        {
            var formlog = new FormLogin();
            formlog.Show();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
