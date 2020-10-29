using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Wolsza.Controls;

namespace boxCatering.Forms
{
    public partial class ContactForm : Form
    {
        public ContactForm()
        {
            InitializeComponent();
        }

        private void rightArrowButton_Click(object sender, EventArgs e)
        {
            this.Close();
            MainForm mainform = new MainForm();
            mainform.Show();
        }

        private void leftArrowButton_Click(object sender, EventArgs e)
        {
            this.Close();
            HomeForm homeform = new HomeForm();
            homeform.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void clearingInputs()
        {
            formElement1.formUserInput = "";
            formElement2.formUserInput = "";
            formElement3.formUserInput = "";
            newsletterCheckbox.Checked = false;
            errorMessage.Visible = false;
            MessageBox.Show("Your contact was sent !");
        }

        private void sendFormData_Click(object sender, EventArgs e)
        {
            if(!String.IsNullOrEmpty(formElement1.formUserInput) 
                && !String.IsNullOrEmpty(formElement2.formUserInput)
                && !String.IsNullOrEmpty(formElement3.formUserInput))
            {
                clearingInputs();
            }
            else
            {
                errorMessage.Visible = true;
            }
            
        }
    }
}
