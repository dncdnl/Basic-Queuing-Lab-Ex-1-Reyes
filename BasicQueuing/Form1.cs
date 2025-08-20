using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicQueuing
{
    public partial class QueuingForm : Form
    {
        public QueuingForm()
        {
            InitializeComponent();
        }

        private void btnCashier_Click(object sender, EventArgs e)
        {
            // calling and declaring the cashier class
            CashierClass cashier = new CashierClass();
        }
    }
}
