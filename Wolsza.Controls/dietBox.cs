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

        public string dietDescription {
            get
            {
                return dietDesc.Text;
            }
            set
            {
                dietDesc.Text = value;
            }
        }

        //public string orderBtn
        //{
        //    get
        //    {
        //        return orderBtn.Name;
        //    }
        //    set
        //    {

        //    }
        //}

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

        private void orderDietBtn_MouseMove(object sender, MouseEventArgs e)
        {
            Cursor.Current = Cursors.Hand;
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
