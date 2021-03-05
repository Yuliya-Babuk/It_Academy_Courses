using System;

namespace ArraysAndStringsPractice
{
    public class OneDimArray
    {
        public void Run()

        {
            int[] oneDimArray = new int[8];
            Console.WriteLine("Please enter " + oneDimArray.Length + " elements");
            int lastNegativeElement = 0;
            int elementNumber = 0;
            for (int i = 0; i < oneDimArray.Length; i++)
            {
                while (!int.TryParse(Console.ReadLine(), out oneDimArray[i]))

                {
                    Console.WriteLine("Invalid input, please try again");
                }

                if (oneDimArray[i] < 0)

                {
                    lastNegativeElement = oneDimArray[i];
                    elementNumber = i;
                }
            }
            Console.WriteLine($"Last negative element is number {elementNumber + 1} => {lastNegativeElement}");
        }

    }
}
