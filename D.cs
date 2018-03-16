using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class D
    {
        static void Main(string[] args)
        {
            int[][] j = new int[2][];
            j[0] = new int[4] { 2, 3, 4, 5 };
            j[1] = new int[3]{ 4,5,6};
            for(int r=0; r<2;r++)
            {
                for(int c=0;c <j[r].Length;c++)
                {
                    Console.WriteLine(j[r, c]+",");
                }
            }
            Console.WriteLine();
            Console.Read();
        }
    }
}
