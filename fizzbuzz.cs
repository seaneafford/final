﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication55
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = int.Parse(Console.ReadLine());
            if (x % 3 == 0 && x % 5 == 0)
            {
                Console.WriteLine("fizzBuzz");
            }
            else if (x % 5 == 0)
            {
                Console.WriteLine("Buzz");

            }
            else if (x % 3 == 0)
            {
                Console.WriteLine("fizz");
            }
            else
            {
                Console.WriteLine(x); 
            }
        }
        

        
    }
}
