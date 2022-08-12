using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EAPAPP
{
    public partial class FormLogin : Form
    {
        private readonly EAPEntities _db;

        public FormLogin()
        {
            InitializeComponent();
            _db = new EAPEntities();
        }

        private void ButtonBackLog_Click(object sender, EventArgs e)
        {
            var mainpage = new MainPage();
            mainpage.Show();
        }

        private void checkBoxShow_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShow.Checked)
            {
                textBoxPassLog.UseSystemPasswordChar = true;
            }
            else
            {
                textBoxPassLog.UseSystemPasswordChar = false;
            }
        }

        private void buttonExitL_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormLogin_Load(object sender, EventArgs e)
        {

        }

        private void ButtonEnter_Click(object sender, EventArgs e)
        {
            try
            {
                SHA256 sha = SHA256.Create();

                

                var emailusername = textBoxEmailLog.Text.Trim();
                var emailpassword = textBoxPassLog.Text.Trim();

                byte[] data = sha.ComputeHash(Encoding.UTF8.GetBytes(emailpassword));

                StringBuilder sBuilder = new StringBuilder();

                for (int i = 0; i < data.Length; i++)
                {
                    sBuilder.Append(data[i].ToString("x2"));
                }

                var hashed_password = sBuilder.ToString();
               

                var user = _db.EAPLogins.FirstOrDefault(q => q.Email == emailusername && q.Password == hashed_password);

                if(user == null)
                {
                    MessageBox.Show("Please Provide Valid Credentials");
                }
                else
                {
                    var home = new Home();
                    home.Show();
                    Hide();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Please Try Again!");
            }
        }
    }
}
