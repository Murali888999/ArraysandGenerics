using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methods
{
    class Generic3<U, V>
    {
        public void test(U s1, V s2)
        {
            Console.WriteLine("values are S1 and s2:{0},{1}", s1, s2);
        }
    }
    class Generic3
    { 
        static void Main(string[] args)
        {
            Generic3<string, string> obj = new Generic3<string, string>();
            Generic3<string, int> obj1 = new Generic3<string, int>();
            Generic3<double, string> obj2 = new Generic3<double, string>();
            obj.test("Murali", "Mohan");
            obj1.test("Murali", 23);
            obj2.test(54.5, "K");
            Console.Read();

        }
    }
}
