using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace boxCatering.Forms
{
    public partial class orderDetailsForm : Form
    {
        public orderDetailsForm()
        {
            InitializeComponent();
        }

        private void returnMAINForm_Click(object sender, EventArgs e)
        {
            this.Close();
            MainForm mainform = new MainForm();
            mainform.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            PurchasedOrderForm purchasedorderform = new PurchasedOrderForm();
            purchasedorderform.Show();
        }
    }
}
