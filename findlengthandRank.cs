using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class findlengthandRank
    {
        static void Main(string[] args)
        {
            //int[] i = new int[3] { 2, 5, 6 }; 
            //int[,] i = new int[2,3]{ { 5, 6,7 }, { 8, 9, 3 } };
            int[][] i = new int[3][];
            i[0] = new int[4] { 5, 6, 3, 1 };
            i[1] = new int[2] { 6, 7 };
            i[2] = new int[1] { 3 };
            Console.WriteLine("length of i is:" + i.Length);
            Console.WriteLine("rank of i is:" + i.Rank);
            Console.Read();
        }
    }
}
