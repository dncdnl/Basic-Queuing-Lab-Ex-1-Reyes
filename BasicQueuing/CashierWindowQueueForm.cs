using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BasicQueuing
{
    public partial class CashierWindowQueueForm : Form
    {
        public CashierWindowQueueForm()
        {
            InitializeComponent();
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            // Clear the list box before displaying the queue
            DisplayCashierQueue(CashierClass.CashierQueue);
        }

            // This method will display the cashier queue in the list box
            public void DisplayCashierQueue(IEnumerable CashierList)
        {
            listCashierQueue.Items.Clear();
            foreach (object obj in CashierList)
            {
                listCashierQueue.Items.Add(obj.ToString());
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            CustomerView customerView = new CustomerView();
            foreach (Form form in allForms)
            {
                if (form.Name == "CustomerView")
                {
                    openedForm = form;
                    openform = true;
                }
            }
            if (openform == true)
            {
                if (passControl != null)
                    customerView.lblCustomer.Text = CashierClass.CashierQueue.Peek();
                CashierClass.CashierQueue.Dequeue();
                passControl(customerView.lblCustomer);
            }
            else
            {
                customerView.ShowDialog();
                customerView.lblCustomer.Text = CashierClass.CashierQueue.Peek();
                CashierClass.CashierQueue.Dequeue();

            }

        // adding timer in the CashierWindowQueueForm
        private void timer1_Tick(object sender, EventArgs e)
        {
            Timer timer = new Timer();
            timer.Interval = (1*1000);
            timer.Tick += new EventHandler(timer1_Tick);
            timer.Start();
        }
    }
}
