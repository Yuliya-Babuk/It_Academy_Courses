using System;
using System.Collections.Generic;
using System.Linq;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
           
            List<int> initialList = new List<int>() { 1, 2, 3 };
            List<int> outputList = new List<int>() { 3, 4, 5 };
            var result1 = initialList.Union(outputList).ToList();

            return;
            //List<int> initialList = new List<int>();
            //List<int> outputList = new List<int>();
            Console.WriteLine("Enter initial list of 5 integers:");
            for (int i = 0; i < 5; i++)
            {
                int.TryParse(Console.ReadLine(), out int output);
                initialList.Add(output);
            }

            Console.WriteLine("List of last integers from initial list:");

            foreach (int integer in initialList)
            {
                outputList.Add(int.Parse(integer.ToString().ToCharArray().Last().ToString()));
            }

            foreach (int integer in outputList)
                Console.WriteLine(integer);


            List<int> initialListOfNumbers = new List<int>();
            var rndm = new Random();
            for (int i = 0; i < rndm.Next(5, 10); i++)
            {
                initialListOfNumbers.Add(rndm.Next(10));
            }

            foreach (var item in initialListOfNumbers)
            {
                Console.Write(item + "\t");
            }
            Dictionary<int, int> result = initialListOfNumbers
                .OrderBy(n => n)
                .GroupBy(n => n)
                .ToDictionary(key => key.Key, val => val.Count());

            Console.WriteLine("=====================================\nNumber Count");
            foreach (KeyValuePair<int, int> item in result)
            {
                Console.WriteLine(item.Key + "       " + item.Value);
            }

            var data = initialListOfNumbers
                .OrderBy(n => n)
                .GroupBy(n => n)
                .Select(n => $"{n.Key} repeats {n.Count()} time(s)");
            //.Select(n => new { Number = n.Key, Count = n.Count() }); //creating anonymous class

            //Console.WriteLine("=====================================\nNumber Count");
            foreach (var item in data)
            {
                //Console.WriteLine(item.Number + "       " + item.Count);
                Console.WriteLine(item);
            }
        }

    }

}


