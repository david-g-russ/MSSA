using System.Collections.Generic;

namespace MVCTest2.Models
{
    public class DBData : IData
    {
        private EmployeeContext _employeeContext;

        public List<Employee> Employees { get; set; }

        public DBData(EmployeeContext employeeContext)
        {
            _employeeContext = employeeContext;
        }

        public int GetDept(Employee employee)
        {
            string dep = employee.Dept.ToString();
            switch (dep)
            {
                case "HR":
                    employee.DeptId = 1;
                    break;
                case "IT":
                    employee.DeptId = 2;
                    break;
                case "Finance":
                    employee.DeptId = 3;
                    break;
                case "Marketing":
                    employee.DeptId = 4;
                    break;
                default:
                    break;
            }
            return employee.DeptId;
        }

        public void AddEmployee(Employee employee)
        {
            employee.DeptId = GetDept(employee);
            _employeeContext.Employees.Add(employee);
            _employeeContext.SaveChanges();
        }

        public void DeleteEmployee(int? id)
        {
            var emp = _employeeContext.Employees.Find(id);
            if (emp != null)
            {
                _employeeContext.Employees.Remove(emp);
                _employeeContext.SaveChanges();
            }

        }

        public Employee GetEmployee(int? id)
        {
            return _employeeContext.Employees.Find(id);
        }

        public IEnumerable<Employee> InitializeData()
        {
            return _employeeContext.Employees;
        }

        public void UpdateEmployee(Employee employee)
        {
            Employee emp = _employeeContext.Employees.Find(employee.Id);
            if (emp != null)
            {
                emp.Id = employee.Id;
                emp.Name = employee.Name;
                emp.Address = employee.Address;
                emp.Age = employee.Age;
                emp.Dept = employee.Dept;
                emp.Email = employee.Email;
                emp.DeptId = GetDept(employee);
            }
            
            _employeeContext.SaveChanges();
        }
    }
}
