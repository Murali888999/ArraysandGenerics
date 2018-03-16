using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class copyingarryelements
    {
        static void Main(string[] args)
        {
            int[] i = new int[3] { 7, 8, 9 };
            int[] j = new int[7] { 8, 3, 1, 2, 4, 0, 9 };
            Console.WriteLine("elements of i are:");
            {
                foreach(int k in i)
                {
                    Console.Write(k+" ");
                }
            }
            Console.WriteLine("\n elements of j are :");
            {
                foreach(int m in j)
                {
                    Console.Write(m+ " ");
                }
            }
            i.CopyTo(j, 4);
            Console.WriteLine("\n after copying elements of j are :");
            {
                foreach (int m in j)
                {
                    Console.Write(m + " ");
                }
            }
            Console.Read();
        }
        
    }
}
