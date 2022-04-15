using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContactUs
{
    public partial class Test : Form
    {
        public Test()
        {
            InitializeComponent();
        }

        private void btnContactView_Click(object sender, EventArgs e)
        {
            Hide();
            new ContactView().Show();
        }
    }
}
