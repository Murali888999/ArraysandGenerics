using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class findingmin
    {
        static void Main(string[] args)
        {
            int[] T = { 1, 5, 7, 3, 8 };
            int min = T[0];
            for (int i = 1; i < T.Length; i++)
            {
                if (min > T[i])
                {
                    min = T[i];
                }
               
            }
            Console.WriteLine(min);
            Console.Read();
        }
    }
}
