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

        private void ButtonSubmit_Click(object sender, EventArgs e, EAPEntities eAPEntities)
        {
            string name = textBoxName.Text;
            string email = textBoxEmail.Text;
            string department = textBoxDepartment.Text;
            var dob = dateTimePickerDOB.Value;
            string psw = textBoxPassword.Text;
            string rpsw = textBoxRetypePassword.Text;
            var isValid = true;

            

            if (string.IsNullOrWhiteSpace(name) || string.IsNullOrWhiteSpace(email) || string.IsNullOrWhiteSpace(department) || string.IsNullOrWhiteSpace(psw) || string.IsNullOrWhiteSpace(rpsw))
            {
                isValid = false;
                MessageBox.Show ("Error: Please Enter Data In All Fields!\n\r");
            }
            if (isValid == true)
            {
                    var eapbd = new EAPBioData();
                    eapbd.Name = name;
                    eapbd.Email = email;
                    eapbd.Department = department;
                    eapbd.DOB = dob;
                    eapbd.Password = psw;
                    eapbd.RetypePassword = rpsw;

                    eAPEntities.EAPBioDatas.Add(eapbd);
                    eAPEntities.SaveChanges();
         
                MessageBox.Show($"Account Sucessfully Created for {name}\n\r");
              }
        }

        private void ButtonBackReg_Click(object sender, EventArgs e)
        {
            var mainpage = new MainPage();
            mainpage.Show();
        }
    }
}
