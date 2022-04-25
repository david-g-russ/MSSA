using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace MVCTest2.Models
{
    public class Department
    {
        [Key]
        public int DeptId { get; set; }
        public string DeptName { get; set; }
        
        // 1 to many, table relation
        public virtual ICollection<Employee> Employees { get; set; }
    }
}
