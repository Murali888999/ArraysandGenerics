using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class A
    {
        static void Main(string[] args)
        {
            int[] m = new int[4] { 12,23,34,45};
            Console.WriteLine("elements of array are:");
            //for(int i = 0; i < 4; i++)
            //{
            //    Console.Write(m[i]+",");
            //}
            foreach(int i in m)
            {
                Console.Write(i +",");
            }
            Console.Read();
        }
    }
}
