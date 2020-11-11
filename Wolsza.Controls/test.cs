using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wolsza.Controls
{
    public partial class test : Component
    {
        public test()
        {
            InitializeComponent();
        }

        public test(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
