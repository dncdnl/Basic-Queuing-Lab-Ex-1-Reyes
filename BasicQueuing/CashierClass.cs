using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace BasicQueuing
{

    internal class CashierClass
    {
        private int x;
        public static string getnumberInQueue = "";
        public static Queue<string> CashierQueue;
        public CashierClass()
        {
            // Initialize the queue and the counter
            x = 10000;
            CashierQueue = new Queue<string>();
        }


    public string CashierGeneratedNumber(string CashierNumber)
        {
            x++;
            CashierNumber = CashierNumber + x.ToString();
            return CashierNumber;
        }
    }
}
