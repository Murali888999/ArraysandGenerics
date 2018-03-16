using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class findmax
    {
        static void Main(string[] args)
        {
            int[] T = { 1, 5, 7, 3, 8 };
            int max = T[0];
            for (int i = 1; i < T.Length; i++)
            {
                if (max < T[i])
                {
                    max = T[i];
                }                
            }
            Console.WriteLine(max);
            Console.Read();
        }
    }
}
