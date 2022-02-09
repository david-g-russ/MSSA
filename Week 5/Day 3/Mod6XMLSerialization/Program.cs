using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Soap;
namespace Mod6XMLSerialization
{
    class Program
    {
        static void Main(string[] args)
        {
            Employee emp = new Employee();
            emp.Eid = 101;
            emp.Ename = "deepali";
            emp.Address = "NY";
            FileStream fileStreamxml = new FileStream(@"C:\Files\empxml.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            SoapFormatter soapFormatter = new SoapFormatter();
            soapFormatter.Serialize(fileStreamxml, emp);
            fileStreamxml.Close();
            Console.WriteLine("data is serialized..");
            
            FileStream fileStreamxmlnew = new FileStream(@"C:\Files\empxml.xml", FileMode.OpenOrCreate, FileAccess.ReadWrite);

            Employee employee =(Employee)soapFormatter.Deserialize(fileStreamxmlnew);

            Console.WriteLine($"{employee.Eid} , {employee.Ename}, {employee.Address}");

            fileStreamxmlnew.Close();
            Console.ReadLine();
        }
    }
}
