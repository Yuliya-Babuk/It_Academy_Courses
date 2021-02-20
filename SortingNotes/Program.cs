using System;

namespace SortingNotes
{
    class Program
    {
        static void Main(string[] args)

        {
            Console.Write("Enter quantity of notes:\t");

            int quantity = int.Parse(Console.ReadLine());
            
            int[] cash = new int[quantity];

            Console.WriteLine("Enter notes");

            for (int i = 0; i < quantity; i++)
            {
               
                cash[i] = int.Parse(Console.ReadLine());

            }

            for (int i = 0; i < quantity; i++)
            {
                for (int j = i+1; j <= (quantity - 1); j++)
                {
                    if (cash[i] > cash[j])
                    {
                        int temp = cash[i];
                        cash[i] = cash[j];
                        cash[j] = temp;
                    }

                }
            }

            Console.WriteLine("Notes after sorting:");

            for (int i=0; i < quantity; i++)
            {
                Console.Write(cash[i] + "\t");
               
            }
       
        }
    }
}
