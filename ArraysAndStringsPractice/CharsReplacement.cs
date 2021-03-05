using System;

namespace ArraysAndStringsPractice
{
    internal class CharsReplacement
    {
        public void Run()
        {
            Console.WriteLine("Please enter a string ");
            string inputString = Console.ReadLine();
            string result = "";
            foreach (char c in inputString)
            {
                if (c == 'a')
                result += "A";
                else
                result += c;                               
            }
            Console.WriteLine($"\"{inputString}\" " + $"became \"{result}\"");
        }
    }
}