using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace trycatch
{
    class Program
    {
        //code snippit to demonstrate how try catch and finally work in exception catching
        static void Main(string[] args)
            
        {
            try
            {
                Console.WriteLine("How old are you now??");
                int age = int.Parse(Console.ReadLine());//parsing to convert to int
                Console.WriteLine("You will be " + (age + 85) + " at the turn of the next century"); //string concatnation
            }
            catch(FormatException)//format exception catches something that cant be parsed i.e a letter.
            {

                Console.WriteLine("This is HUMILIATING.... try typing in a number value instead guy.");//funny print out message
            }
            finally
            {
                Console.WriteLine("Well thats how try and catch works.");//prints reguardless because its a finally
            }
        }
    }
}
