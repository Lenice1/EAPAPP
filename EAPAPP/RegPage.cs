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
    public partial class FormRegistrationPage : Form
    {
        public FormRegistrationPage()
        {
            InitializeComponent();
        }

        private async void ButtonSubmit_Click(object sender, EventArgs e)
        {


            if (string.IsNullOrEmpty(textBoxEmail.Text))
            {
                MessageBox.Show("Please Enter Your Email!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBoxEmail.Focus();
                return;
            }

            if (textBoxPassword.Text != textBoxRetypePassword.Text)
            {
                MessageBox.Show("Password & Retyped Password Do Not Match!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                return;
            }
            IUserRepository repository = new UserRepository();
            bool result = await repository.Insert(new User() { Name = textBoxName.Text, Email = textBoxEmail.Text, Department = textBoxDepartment.Text, Password = textBoxPassword.Text });


            if (result)
                MessageBox.Show("Registration Successful!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);

            else

                MessageBox.Show("Error!", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void ButtonBackReg_Click(object sender, EventArgs e)
        {
            var mainpage = new MainPage();
            mainpage.Show();
        }

        private void buttonExitR_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void checkBoxShowP_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowP.Checked)
            {
                textBoxPassword.UseSystemPasswordChar = true;
            }
            else
            {
                textBoxPassword.UseSystemPasswordChar = false;
            }

        }

        private void checkBoxRP_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxRP.Checked)
            {
                textBoxRetypePassword.UseSystemPasswordChar = true;
            }
            else
            {
                textBoxRetypePassword.UseSystemPasswordChar = false;
            }
        }


    }
}

