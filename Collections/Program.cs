using System;
using System.Collections.Generic;
using System.Linq;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> initialList = new List<int>();
            List<int> outputList = new List<int>();
            Console.WriteLine("Enter initial list of 5 integers:");
            for (int i = 0; i < 5; i++)
            {
                int.TryParse(Console.ReadLine(), out int output);
                initialList.Add(output);

                int integer = 0;
                int.TryParse((initialList[i].ToString().ToCharArray().Last()).ToString(), out integer);
                outputList.Add(integer);
            }
            Console.WriteLine("List of last integers from initial list:");
            foreach (int integer in outputList)
            {
                Console.WriteLine(integer);
            }

        }

    }

}

