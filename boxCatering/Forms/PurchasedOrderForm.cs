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
    public partial class PurchasedOrderForm : Form
    {
        public PurchasedOrderForm()
        {
            InitializeComponent();
            sumOrderLabel10.userSummaryData = "hello";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
            orderDetailsForm orderdetailform = new orderDetailsForm("");
            orderdetailform.Show();
        }

        private void cardInfo1_Load(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            DialogResult dialogres;
            dialogres = MessageBox.Show("Thanks for your order !");
            if(dialogres == System.Windows.Forms.DialogResult.OK)
            {
                this.Close();
                MainForm mainform = new MainForm();
                mainform.Show();
            }
            
        }

        private void sumOrderLabel6_Load(object sender, EventArgs e)
        {

        }

        private void PurchasedOrderForm_Load(object sender, EventArgs e)
        {

        }

        private void returnMAINForm_MouseMove(object sender, MouseEventArgs e)
        {
            Cursor.Current = Cursors.Hand;
        }
    }
}
