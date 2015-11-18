using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication75
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<int> nums = new Queue<int>();//instatiating new que named nums
            nums.Enqueue(2);
            nums.Enqueue(3);// adds to que
            nums.Enqueue(76);
            Console.WriteLine(nums.Contains(6)); //contains method to see if that number is in the stucture. returns a boolean value.
            foreach (int numas in nums)//looping through to write everything in the que to the console
            {
                Console.WriteLine(numas);
                
                
            }
        }
    }
}
