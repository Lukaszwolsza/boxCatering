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
    public partial class dietBox: UserControl
    {
        public string firstLabel
        {
            get
            {
                return firstDescLabel.Text;
            }
            set
            {
                firstDescLabel.Text = value;
            }
        }
        public string secondLabel
        {
            get
            {
                return secondDescLabel.Text;
            }
            set
            {
                secondDescLabel.Text = value;
            }
        }
        public string thirdLabel
        {
            get
            {
                return thirdDescLabel.Text;
            }
            set
            {
                thirdDescLabel.Text = value;
            }
        }
        public string dietName
        {
            get
            {
                return dietNameLabel.Text;
            }
            set
            {
                dietNameLabel.Text = value;
                dietNameLabel.Location = new Point((233 - dietNameLabel.Size.Width) / 2, 8);
            }
        }


        [Browsable(true)]
        [Category("Action")]
        [Description("Invoked when user clicks button")]
        static public event EventHandler OrderBtnClick;
        public void orderDietBtn_Click(object sender, EventArgs e)
        {
            OrderBtnClick?.Invoke(this, e);
        }

        public dietBox()
        {
            InitializeComponent();
            
        }




        //private void orderDietBtn_Click(object sender, EventArgs e)
        //{
        //    orderButtonClick?.Invoke(this, new EventArgs());
        //}

        //protected virtual void OnClickedOrderButton() 
        //{
        //    orderDietBtn.
        //    orderButtonClick?.Invoke();
        //}

    }
}
