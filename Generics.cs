using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methods
{
    class Generics<T>
    {
        public Generics(T msg)
        {
            Console.WriteLine(msg);
        }

    }
    class A1
    {
        static void Main(string[] args)
        {
            Generics<string> obj = new Generics<string>("Murali");
            Generics<int> obj1 = new Generics<int>(12);
            Generics<double> obj2 = new Generics<double>(22.4);
            Console.Read();
        }
    }
}
