using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
namespace Mod6Serializationdemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Serialization: Converting the state of object into persistant media like file or transfer the object over the wire
           
            //Binary Serialization
            string filepath = @"C:\Files\newdata.txt";
            Employee emp = new Employee();
            emp.Eid = 101;
            emp.Ename = "XYZ";
            emp.Address = "NY";
            //where
            #region Binary Serialization
            FileStream fileStream = new FileStream(filepath, FileMode.OpenOrCreate, FileAccess.ReadWrite);
            //how
            BinaryFormatter binaryFormatter = new BinaryFormatter();
            binaryFormatter.Serialize(fileStream, emp);//where , what

            Console.WriteLine("Data is serialized in binary");
            Console.ReadLine();
            fileStream.Close();

            #endregion
            // Binary Deserialization
            FileStream stream = new FileStream(filepath, FileMode.Open, FileAccess.Read);
            Employee employee =(Employee)binaryFormatter.Deserialize(stream);
            Console.WriteLine("Deserialized data:");
            Console.WriteLine($"{employee.Eid}, {employee.Ename}, {employee.Address}");
            stream.Close();

            Console.ReadLine();
            //StreamWriter sw = new StreamWriter(fileStream);
            //sw.WriteLine(emp);
            //sw.Close();
            //fileStream.Close();

        }
    }
}
