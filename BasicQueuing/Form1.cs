using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicQueuing
{

    public partial class QueuingForm : Form
    {
        // declaringg the CashierClass 
        private CashierClass cashier;
        public QueuingForm()
        {
            InitializeComponent();
            // Initializing the CashierClass
            cashier = new CashierClass();
        }

        private void btnCashier_Click(object sender, EventArgs e)
        {
            // Generate a new cashier number and display it in the label
            lblQueue.Text = cashier.CashierGeneratedNumber("P - ");
            CashierClass.getnumberInQueue = lblQueue.Text;
            CashierClass.CashierQueue.Enqueue(CashierClass.getnumberInQueue);

        }
    }
}
