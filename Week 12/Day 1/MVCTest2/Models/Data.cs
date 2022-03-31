using System.Collections.Generic;

namespace MVCTest2.Models
{
    //Step 3: Method implementation
    public class Data : IData
    {
        public List<Employee> Employees { get; set; }

        public Data()
        {
            Employees = new List<Employee>()
            {
                new Employee()
                {
                    Id=101,
                    Name="Elena",
                    Age=34,
                    Address="NY",
                    ImageName="DR logo.png",
                    Email="elena@company.com",
                    Dept=Dept.HR
                },
                new Employee()
                {
                    Id=131,
                    Name="Ele",
                    Age=34,
                    Address="NW",
                    ImageName="DR logo.png",
                    Email="ele@company.com",
                    Dept=Dept.Finance
                },
                new Employee()
                {
                    Id=102,
                    Name="Elea",
                    Age=34,
                    Address="NA",
                    ImageName="DR logo.png",
                    Email="elea@company.com",
                    Dept=Dept.IT
                }
            };
        }

        public void AddEmployee(Employee employee)
        {
            Employees.Add(employee);
        }

        public void UpdateEmployee(Employee employee)
        {
            var emp = GetEmployee(employee.Id);
            if(emp != null)
            {
                emp.Id = employee.Id;
                emp.Name = employee.Name;
                emp.Age = employee.Age;
                emp.Address = employee.Address;
                emp.ImageName = employee.ImageName;
                emp.Email = employee.Email;
                emp.Dept = employee.Dept;
            }
        }

        public void DeleteEmployee(int? id)
        {
            var emp = GetEmployee(id);
            if(emp != null)
                Employees.Remove(emp);
        }

        public Employee GetEmployee(int? id)
        {
            if(id== null)
                return null;
            else
                return Employees.Find(x => x.Id == id);
        }

        public List<Employee> InitializeData()
        {
            return Employees;
        }
    }
}
