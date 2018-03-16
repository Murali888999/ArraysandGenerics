using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace methods
{
    class Generics2
    {
        static void M3<G>(G s)
        {
            Console.WriteLine("value of K is:"+s);
        }
        static void Main(string[] args)
        {
            M3< String >("Murali");
            M3<int>(23);
            M3<double>(56.5);
            M3<char>('Y');
            Console.Read();

        }
    }
}
