using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Wolsza.Controls
{
    public partial class cardInfo : UserControl
    {
        public string cardNum
        {
            get
            {
                return cardNumber.Text;
            }
            set
            {
                cardNumber.Text = value;
            }
        }
        public string cardExpDate
        {
            get
            {
                return expDate.Text;
            }
            set
            {
                expDate.Text = value;
            }
        }
        public string cardCcvNumber
        {
            get
            {
                return ccvNumber.Text;
            }
            set
            {
                ccvNumber.Text = value;
            }
        }

        public cardInfo()
        {
            InitializeComponent();
        }
    }
}
