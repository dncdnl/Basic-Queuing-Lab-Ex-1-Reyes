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
            // Using a Try-Catch block to handle the case when the queue is empty
            try
            {
                // Check if the queue is empty before dequeuing
                string nextCustomer = CashierClass.CashierQueue.Peek(); // This is used to check if it is empty
                CashierClass.CashierQueue.Dequeue();

                // Checking if the nextCustomer is null or empty
                CustomerView customerView = null;

                // Using the Foreach loop to display the next customer in the queue
                foreach (Form form in Application.OpenForms)
                {
                    if(form is CustomerView existingView)
                    {
                        // Update the label in the CustomerView form with the next customer
                        customerView = existingView;
                        break;
                    }
                }
                if (customerView == null)
                {
                    // If the CustomerView form is not open, create a new instance
                    customerView = new CustomerView();
                    customerView.Show();
                }
                // Update the label in the CustomerView form with the next customer
                customerView.lblQueueNumber.Text = nextCustomer;
            }
            catch (InvalidOperationException)
            {
                // Display a message box if the queue is empty
                MessageBox.Show("Queue Empty");
            }

            // Clear the list box before displaying the queue
            DisplayCashierQueue(CashierClass.CashierQueue);

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
