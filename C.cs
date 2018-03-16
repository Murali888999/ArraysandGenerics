using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class C
    {
        static void Main(string[] args)
        {
            int[,] t = new int[3, 3] { { 1, 2, 4 }, { 23, 34, 54 }, { 6, 7, 4 } };
            Console.WriteLine("array elements are:");
            for(int i =0;i<3;i++)
            {
                for (int j = 0; j <3; j++)
                {
                    Console.Write(t[i, j]+",");
                }
                Console.WriteLine();
            }
            Console.Read();
        }
    }
}
