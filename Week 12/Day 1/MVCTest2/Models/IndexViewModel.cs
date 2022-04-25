using System.Collections.Generic;

namespace MVCTest2.Models
{
    // Step 4: Temp holder for displaying data on Index view
    public class IndexViewModel
    {
        public IEnumerable<Employee> Employees { get; set; }

    }
}
