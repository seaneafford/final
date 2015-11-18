using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication58
{
    class Program
    {
        static void Main(string[] args)
        {
            //simple calculator
            Console.WriteLine("Enter the Two numbers you wish to alter");
          double  x = double.Parse(Console.ReadLine());
          double y =  double.Parse(Console.ReadLine());
            Console.WriteLine("What operation do you want to preform?");
        char r =  char.Parse(Console.ReadLine());
            if (r == '*')//else if statments to figue our which method to use
            {
                Multiply(x, y);
            }

            else if (r == '/')
            {
                Divide(x, y);
            }
            else if (r == '+')
            {
                Add(x, y);
            }

            else if (r == '-')
            {
                Subtract(x, y);
            }
            
        }
        //methods
        static void Divide(double x, double y)
        {
            double z = x / y;
            Console.WriteLine(z);
        }

        static void Subtract(double x, double y)
        {
            double z = x - y;
            Console.WriteLine(z);
        }
        static void  Add(double x, double y)
        {
            double z = x + y;
            Console.WriteLine(z);
        }

        static void Multiply(double x, double y)
        {
            double z = x * y;
            Console.WriteLine(z);

        }
    }

}
