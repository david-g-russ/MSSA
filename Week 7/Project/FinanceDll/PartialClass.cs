using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinanceDll
{
    public partial class Transaction
    {
        public string LoanName { get; set; }
        public string CategoryName { get; set; }
    }

    public partial class Loan
    {
        public decimal RemainingBalance { get; set; }
    }

    public partial class Category
    {
        public decimal MonthValue { get; set; }
    }
}