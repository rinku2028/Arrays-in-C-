using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp10
{
    class rankofarray
    {
        public static void Main(string []args)
        {
            int[] array1 = new int[5] { 1, 2, 3, 4, 5 };
            int[,] array2 = new int[10, 3];
            Console.WriteLine("Total dimensions of Array is : " + array1.Rank);
            Console.WriteLine("Total dimensions of Array is : " + array2.Rank);
            Console.ReadLine();
        }
    }
}
