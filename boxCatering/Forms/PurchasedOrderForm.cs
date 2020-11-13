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

namespace boxCatering.Forms
{
    public partial class PurchasedOrderForm : Form
    {
        int orderID = orderDetailsForm.orderID;

        public PurchasedOrderForm()
        {
            InitializeComponent();
            //sumOrderLabel10.userSummaryData = "hello";
            
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
            summaryService summaryserv = new summaryService();
            string[] customerInfo = new string[7];
            customerInfo = summaryserv.customerInformation(orderID);

            string[] dietInfo = new string[3];
            dietInfo = summaryserv.dietInformation(orderID);

            sumOrderLabel1.userSummaryData = customerInfo[0];
            sumOrderLabel2.userSummaryData = customerInfo[1];
            sumOrderLabel3.userSummaryData = customerInfo[2];
            sumOrderLabel4.userSummaryData = customerInfo[3];
            sumOrderLabel5.userSummaryData = customerInfo[4];
            sumOrderLabel6.userSummaryData = customerInfo[5];
            sumOrderLabel12.userSummaryData = customerInfo[6];
            sumOrderLabel10.userSummaryData = dietInfo[0];
            sumOrderLabel11.userSummaryData = dietInfo[1];
            sumOrderLabel8.userSummaryData = dietInfo[2] + "$";
            sumOrderLabel7.userSummaryData = (Convert.ToInt32(dietInfo[2]) + 30).ToString() + "$ " + " (costs of delivery)";

        }

        private void returnMAINForm_MouseMove(object sender, MouseEventArgs e)
        {
            Cursor.Current = Cursors.Hand;
        }
    }
}
