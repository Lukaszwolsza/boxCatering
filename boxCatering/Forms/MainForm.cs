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
    public partial class MainForm : Form
    {

        private dietBox dietbox;
        
        public MainForm()
        {
            InitializeComponent();

            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void rightArrowButton_Click(object sender, EventArgs e)
        {
            this.Close();
            HomeForm homeform = new HomeForm();
            homeform.Show();
        }

        private void leftArrowButton_Click(object sender, EventArgs e)
        {
            this.Close();
            ContactForm contactform = new ContactForm();
            contactform.Show();
        }

        

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            dietBox.OrderBtnClick += DietBox_OrderBtnClick;
        }

        private void DietBox_OrderBtnClick(object sender, EventArgs e)
        {
            this.Close();
            orderDetailsForm orderdetailsform = new orderDetailsForm();
            orderdetailsform.Show();
        }

        private void dietBox3_Load(object sender, EventArgs e)
        {

        }

        private void dietBox2_Load(object sender, EventArgs e)
        {

        }

        //dietBox.OrderButtonClick += new EventHandler(UserControl_ButtonClick);

        //protected void UserControl_ButtonClick(object sender, EventArgs e)
        //{
        //    //handle the event 
        //}


    }
}
