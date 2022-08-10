using System;
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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void checkOutToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkInToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var checkin = new CheckIn();
            checkin.Show();
        }

        private void checkOutToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            var checkout = new FormCheckOut();
            checkout.Show();
        }
    }
}
