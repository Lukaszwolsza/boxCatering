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
    public partial class formElement : UserControl
    {

        public string formUserLabel {
            get
            {
                return labelName.Text;
            }
            set
            {
                labelName.Text = value;
            }
        }
        public string formUserInput
        {
            get 
            {
                return formInput.Text;
            }
            set
            {
                formInput.Text = value;
            }
        }

        public formElement()
        {
            InitializeComponent();
        }
    }
}
