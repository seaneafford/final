using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How Old are you?!");
            int x = Convert.ToInt32(Console.ReadLine());//converting the readline to an int 
            if (x >= 18)//conditional

            {
                Console.WriteLine("How tall are you");//do
            }
            else
            {
                Console.WriteLine("You cant ride");//otherwise
            }

                double y = Convert.ToDouble(Console.ReadLine());
                if (y>= 5.0)
                {
                    Console.WriteLine("Enter!!");
                } 

                else
                {
                    Console.WriteLine("DO NOT ENTER!!!");
                }
            }
        }
    }

