using System;
using System.IO;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        //using (StreamReader reader = File.OpenText(args[0]))
        //while(!reader.EndOfStream)
        //{
        string line = "1 3 6 9 0 2 3 4";//reader.ReadLine();
                                        //if (null == line)
                                        //continue;
        string[] linez = line.Split();
        Stack<string> ints = new Stack<string>();
        foreach (string lines in linez)
        {
            ints.Push(lines);
        }

        for (int i = 0; i < ints.Count - 1; i++)


            if (i % 2 == 0)
            {
                ints.Pop();
            }
            else
            {
                Console.Write(ints.Pop() + " ");
            }


    }
}

