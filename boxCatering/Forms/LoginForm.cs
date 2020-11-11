using boxCatering.Classes;
using boxCatering.Forms;
using boxCatering.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace boxCatering
{
    public partial class Form1 : Form
    {

        public static string userLogin;

        public static string userLoginDisplay
        {
            get { return userLogin; }
            set { userLogin = value; }
        }


        public void authUser()
        {
            string login = loginTextBox.Text;
            string password = passwordTextBox.Text;
            userLoginDisplay = loginTextBox.Text;
            bool isLogged = false;

            UserService userservice = new UserService();
            isLogged = userservice.userAuthenticationInBase(login, password);

            if (isLogged)
            {
                MessageBox.Show("You're logged !");
                this.Hide();
                MainForm mainform = new MainForm();
                mainform.Show();

            }
            else
            {
                MessageBox.Show("Incorrect password !");
                isLogged = false;
            }
        }

        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            authUser();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void passwordTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                authUser();
            }
        }

        public void clearingInputs()
        {
            loginRegister.Text = "";
            passwordRegister.Text = "";
            rePasswordRegister.Text = "";
            emailRegister.Text = "";
            agreeCheckbox.Checked = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!agreeCheckbox.Checked)
            {
                MessageBox.Show("Accept agreement ! ");
                return;
            }
            else
            {
                if (passwordRegister.Text == rePasswordRegister.Text)
                {
                    User user = new User(loginRegister.Text, passwordRegister.Text, emailRegister.Text, false);

                    UserService userservice = new UserService();
                    userservice.addUserToBase(user);
                    MessageBox.Show("New user has been created, you can log in.");
                    clearingInputs();
                }
                else
                {
                    MessageBox.Show("Passwords don't match ! ");
                    return;
                }
                
            }
            
           

        }

    }
}
