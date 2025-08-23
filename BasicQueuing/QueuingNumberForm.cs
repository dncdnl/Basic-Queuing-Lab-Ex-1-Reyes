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
    public partial class QueuingNumberForm: Form
    {
        public QueuingNumberForm()
        {
            InitializeComponent();
        }

        private void QueuingNumberForm_Load(object sender, EventArgs e)
        {
            // Display the first number in the queue when the form loads
            lblServingNumber.Text = CashierClass.CashierQueue.Peek();
        }
    }
}
