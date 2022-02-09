using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Json;

namespace Mod6JSONserialization
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student() { Age = 12, Id = 123456, Name = "Jennifer" , Address = 123};

            Stream fileStream = new FileStream(@"C:\Files\jsonstore.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite); // create or open a read/write file named jsonstore.txt
            DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(Student)); // 
            serializer.WriteObject(fileStream, student);
            fileStream.Close();
            Console.WriteLine("Data is serialized.");

            Stream stream = new FileStream(@"C:\Files\jsonstore.txt", FileMode.Open, FileAccess.Read);
            DataContractJsonSerializer jsonSerializer = new DataContractJsonSerializer(typeof(Student));
            Student stud = (Student)jsonSerializer.ReadObject(stream);
            stream.Close();
            Console.WriteLine($"{stud.Name}, {stud.Age}, {stud.Id}, {stud.Address}");

            Console.ReadLine();
        }
    }
}