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
    public partial class sumOrderLabel : UserControl
    {
        public string orderSummaryLabel 
        {
            get
            {
                return summaryOrderLabel.Text;
            }
            set
            {
                summaryOrderLabel.Text = value;
            }
        }

        public string userSummaryData 
        {
            get
            {
                return summaryOrderUserData.Text;
            }
            set
            {
                summaryOrderUserData.Text = value;
                summaryOrderUserData.Location = new Point(summaryOrderLabel.Location.X+summaryOrderLabel.Width+5, 14);
            }
        }

        public sumOrderLabel()
        {
            InitializeComponent();
        }
    }
}
