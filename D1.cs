using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class D1
    {
        static void Main(string[] args)
        {
            int[][] j = new int[3][];
            j[0] = new int[4] { 2, 3, 4, 5 };
            j[1] = new int[3] { 4, 5, 6 };
            j[2] = new int[2] { 4, 5 };
            //for(int r = 0; r < j.Length; r++)
            //{
            //    for (int c = 0; c < j[r].Length; c++)
            //    {
            //        Console.Write(j[r][c] + ",");
            //    }
            //    Console.WriteLine();
            //}  
            foreach(int[] r in j)
            {
                foreach(int c in r)
                {
                    Console.Write(c + ",");
                }
                Console.WriteLine();
            }          
            Console.Read();
        }
    }
}
