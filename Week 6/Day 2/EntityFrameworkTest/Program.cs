using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace EntityFrameworkTest
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // old method, subject to SQL injection attacks
            SqlConnection connection = new SqlConnection("connection string");
            SqlCommand command = new SqlCommand("select * from Employees");
            command.Connection = connection;

            // entity framework and LINQ
        }
    }
}
