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
    public partial class ViewRecords : Form
    {
        public ViewRecords()
        {
            InitializeComponent();
        }

        private void buttonExitVR_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonBackVR_Click(object sender, EventArgs e)
        {
            var home = new Home();
            home.Show();
        }
    }
}
