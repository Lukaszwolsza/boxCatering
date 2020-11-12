using boxCatering.Classes;
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
using Wolsza.Controls;

namespace boxCatering.Forms
{
    public partial class orderDetailsForm : Form
    {
        public orderDetailsForm(string name)
        {
            InitializeComponent();
            sumOrderLabel10.userSummaryData = name;
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

        public Customer getCustomerInformation()
        {
            string name = formElement1.formUserInput;
            string surname = formElement2.formUserInput;
            string email = formElement3.formUserInput;
            string address = formElement4.formUserInput;
            int postcode = Convert.ToInt32(formElement5.formUserInput);
            string city = formElement6.formUserInput;
            int phone = Convert.ToInt32(formElement7.formUserInput);

            Customer customer = new Customer(name, surname, email, address, postcode, city, phone);
            return customer;
        }
        public Card getCardInformation()
        {
            long cardnumber = Convert.ToInt64(cardInfo1.cardNum);
            int cardexpdate = Convert.ToInt32(cardInfo1.cardExpDate);
            int cardCCV = Convert.ToInt32(cardInfo1.cardCcvNumber);

            Card card = new Card(cardnumber, cardexpdate, cardCCV);
            return card;
        }

        private void button1_Click(object sender, EventArgs e)
        {       
            customerService customerserv = new customerService();
            int customerID = customerserv.addCustomerToBase(getCustomerInformation());
 
            paymentService paymentserv = new paymentService();
            int paymentID = paymentserv.addCardToBase(getCardInformation());

            dietService dietserv = new dietService();
            int dietID = dietserv.getDietObj(sumOrderLabel10.userSummaryData);
            //int dietID = dietserv.getDietID(sumOrderLabel10.userSummaryData);
            
            //Order order = new Order(getCustomerInformation(), getCardInformation(), dietObj);

            orderService orderserv = new orderService();
            orderserv.addOrderToBase(customerID, dietID, paymentID);
            

            this.Close();
            PurchasedOrderForm purchasedorderform = new PurchasedOrderForm();
            purchasedorderform.Show();  
        }

        private void orderDetailsForm_Load(object sender, EventArgs e)
        {
            dietService dietserv = new dietService();
            string[] info = new string[2];
            info = dietserv.getDietType(sumOrderLabel10.userSummaryData);

            sumOrderLabel10.userSummaryData = info[0];
            sumOrderLabel11.userSummaryData = info[1];
        }
    }
}
