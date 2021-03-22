using System;
using System.Collections.Generic;
using System.Linq;


namespace ExamTask
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,,] mas = { { {1,2 },{3,4 } },
                {{4,5},{6,7} },
                {{7,8},{9,10} },
                {{10,11},{12,13} } };
            Console.Write("{");
            for (int i = 0; i <= mas.GetUpperBound(0); i++)
            {
                Console.Write("{");
                for (int j = 0; j <= mas.GetUpperBound(1); j++)
                {
                    Console.Write("{");
                    for (int k = 0; k <= mas.GetUpperBound(2); k++)
                    {
                        Console.Write(mas[i, j, k]);
                        if (k != mas.GetUpperBound(2))
                            Console.Write(",");

                    }
                    Console.Write("}");
                    if (j != mas.GetUpperBound(1))
                        Console.Write(",");
                }
                Console.Write("}");
                if (i != mas.GetUpperBound(0))
                    Console.Write(",");
            }
            Console.Write("}");

            Console.WriteLine("\nEnter a string:");
            string input = Console.ReadLine();
            string output = "";

            for (int i = 0; i < input.Length; i++)

            {
                if (i % 2 == 0)
                {
                    output = output + input[i];
                }

            }
            Console.WriteLine(output);

            List<int> listInput = new List<int>();
            Random rn = new Random();
            for (int i = 0; i < rn.Next(7, 9); i++)
            {
                listInput.Add(rn.Next(50));
                Console.Write(listInput[i] + "\t");
            }
            List<int> maxNumber = listInput.Where(n => n % 2 == 0).OrderByDescending(n => n).Take(3).ToList();
            Console.Write("\n3 max even numbers from the list:\n");
            foreach (int number in maxNumber)
            {
                Console.Write(number + "\t");
            }
        }
    }
}
