﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWorld
{
    class Arrays
    {
        static void Main(string[] args)
        {
            string[] friends = { "Mike", "Harvey", "Jessica", "Louis", "Donna" };

            for(int j = 0; j < 5;j++)
            {
                Console.WriteLine("Hello {0}", friends[j]);
            }

            Console.ReadKey();
        }
    }
}