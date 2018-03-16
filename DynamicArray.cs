using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class DynamicArray
    {
        static void Main(string[] args)
        {
            int[] a = new int[5] { 4, 6, 8, 9, 1 };
            Console.WriteLine("array elements are:");
            foreach(int i in a)
            {
                Console.Write(i + " "); 
            }
            Console.WriteLine("\n after modify array elements are:");
            int b = Convert.ToInt32(Console.ReadLine());
            Array.Resize(ref a, b); //New array size is replacing with existing array
            foreach(int i in a)
            {
                Console.Write(i + " "); 
            }
            Console.Read();
        }       
    }
}
