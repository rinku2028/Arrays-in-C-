﻿using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp10
{
    class upperlowerbound
    {
        public static void Main(string []args)
        {
            Array stringArray = Array.CreateInstance(typeof(String), 6);
            stringArray.SetValue("Mango", 0);
            stringArray.SetValue("Orange", 1);
            stringArray.SetValue("Apple", 2);
            stringArray.SetValue("Grape", 3);
            stringArray.SetValue("Cherry", 4);
            stringArray.SetValue("WaterMelon", 4);
            Console.WriteLine("The Lower Bound of the Array : {0}",
                              stringArray.GetLowerBound(0).ToString());
            Console.WriteLine("The Upper Bound of the Array : {0}",
                              stringArray.GetUpperBound(0).ToString());
            Console.ReadLine();

        }
    }
}
