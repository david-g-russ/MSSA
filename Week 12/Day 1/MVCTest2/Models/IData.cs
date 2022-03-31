using System.Collections.Generic;

namespace MVCTest2.Models
    
{
    //Step 2: Interface
    public interface IData
    {
        List<Employee> Employees { get; set; }
        List<Employee> InitializeData();
        Employee GetEmployee(int? id);
        void AddEmployee(Employee employee);
        void UpdateEmployee(Employee employee);
        void DeleteEmployee(int? id);
    }
}