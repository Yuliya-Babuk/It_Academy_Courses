using System;

namespace ArraysAndStringsPractice
{
    class Program
    {
        static void Main(string[] args)
        {
            //new OneDimArray().Run();
            //new TwoDimArray().Run();
            //new VowelsCalculation().Run();
            //new CharsReplacement().Run();
            //new ArrayOfArrays().Run();
            int[,] array = new int[4, 4]
                {{2,-5,4,6},
                {-7,3,9,-8},
                {9,4,-2,8},
                {-5,3,7,1}};
            for (int i = 0; i <= array.GetUpperBound(0); i++)
            {
                for (int j = 0; j <= array.GetUpperBound(1); j++)
                {
                    if (i < j) //выше главное диагонали
                    {
                        array[i, j] = Math.Abs(array[i, j]);
                    } 
                    else if (i > j)
                    {
                        array[i, j] = Math.Abs(array[i, j]) * -1;
                    }

                    Console.Write($"{array[i, j]}      ");
                }
                Console.WriteLine();

            }
        }
    }
}




