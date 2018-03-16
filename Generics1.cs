using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methods
{
    class Generics1
    {
        public void test7<T>(T s)
        {
            Console.WriteLine(s);
        }
    }
    class A2
    {
        static void Main(string[] args)
        {
            Generics1 obj = new Generics1();
            obj.test7("Murali");
            obj.test7(123);
            obj.test7(23.5);
            obj.test7('K');
            Console.Read();
        }
    }
}
