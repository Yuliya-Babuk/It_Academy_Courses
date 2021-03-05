using System;

namespace ArraysAndStringsPractice
{
    internal class VowelsCalculation
    {
        public void Run()
        {
            Console.WriteLine("Please enter a string ");
            string inputString = Console.ReadLine().ToLower();
            int vowelsNumber = 0;
            foreach (int i in inputString)
            {
                if (i == 'a' || i == 'o' | i == 'e' || i == 'i' || i == 'u')
                    vowelsNumber++;
            }
            Console.WriteLine($"\n\"{inputString}\" " + $"contains {vowelsNumber} vowels");

        }
    }
}