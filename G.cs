using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class G
    {
        static void Main(string[] args)
        {
            int[] i = new int[3] { 7, 8, 9 };
            int[] j = new int[7] { 8, 3, 1, 2, 4, 0, 9 };
            Console.WriteLine("elements of i are:");
            {
                foreach (int k in i)
                {
                    Console.Write(k + " ");
                }
            }
            Console.WriteLine("\n elements of j are :");
            {
                foreach (int m in j)
                {
                    Console.Write(m + " ");
                }
            }
            //Array.Copy(i, 0, j,3,2);
            //Array.Sort(j);
            //Array.Sort(j, 2,3);
            //Array.Reverse(j);
            Array.Clear(j,1,4);
            Array.Reverse(j, 2, 3);
            Console.WriteLine("\n after clear elements of j are :");
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
