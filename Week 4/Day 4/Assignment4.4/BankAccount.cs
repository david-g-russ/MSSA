using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4._4
{
    delegate void LowBalanceDel(); // declare delegate
    internal class BankAccount
    {
        public string FName { get; set; }
        public string LName { get; set; }
        public int ActNum { get; set; }

        public event LowBalanceDel LowBalance; // assign delegate to event
        private Double balance;
        public Double Balance
        {
            get { return this.balance; }
            set
            {
                if (value < 200.00)
                {
                    LowBalance(); // raise event if balance < $200
                }
                else
                {
                    this.balance = value;
                }
            }
        }
    }
}