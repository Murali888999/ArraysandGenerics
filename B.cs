using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class B
    {
        static void Main(string[] args)
        {
            string[] m = new string[4] { "Mu", "ra", "li", "K" };
            Console.WriteLine("elements of array are:");
            for (int i = 0; i < 4; i++)
            {
                Console.Write(m[i] + ",");
            }
            //foreach (String i in m)
            //{
            //    Console.Write(i + "");
            //}
            Console.Read();
        }
    }
}
