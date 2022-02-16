using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousMethodTest
{
    internal class Program
    {
        public delegate bool Mydel(int num);
        public delegate int AddDel(int num1, int num2);
        static void Main(string[] args)
        {
            // normal function call
            bool result = Check(100);

            // delegate call
            Mydel del = new Mydel(Check);
            result = del(100);

            //anonymous method
            Mydel anonymous = delegate (int num)
                {
                    return num > 10;
                };
            result = anonymous(100);

            // lamba expressions, used for Language Integrated Queries (LINQ)
            Mydel lambda = (num) =>
                {
                    return num > 10;
                };
            lambda(100);

            AddDel addDel = (num1, num2) =>
                {
                    return num1 + num2;
                };
            addDel(100, 200);

        }
        public static bool Check(int num)
        {
            return (num > 10);
        }
    }
}
