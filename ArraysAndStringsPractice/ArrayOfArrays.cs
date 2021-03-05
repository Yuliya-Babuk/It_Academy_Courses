using System;

namespace ArraysAndStringsPractice
{
    class ArrayOfArrays
    {
        public void Run()
        {
            Console.WriteLine("Please number of arrays:");
            int numberArrays = ParseInput();
            int[][] arrayOfArrays = new int[numberArrays][];

            InitializeTwoDimArray(numberArrays, arrayOfArrays);

            int maxIndex = 0;

            for (int i = 0; i < numberArrays; i++)
            {
                int maxElement = arrayOfArrays[i][0];
                for (int j = 0; j < arrayOfArrays[i].Length; j++)
                {

                    if (arrayOfArrays[i][j] > maxElement)
                    {
                        maxIndex = j;
                        maxElement = arrayOfArrays[i][j];
                    }
                }
                for (int j = maxIndex; j < arrayOfArrays[i].Length - 1; j++)
                {
                    arrayOfArrays[i][j + 1] = 0;
                }
            }
            for (int i = 0; i < numberArrays; i++)
            {
                for (int j = 0; j < arrayOfArrays[i].Length; j++)
                    Console.Write($"{arrayOfArrays[i][j]}\t");
                Console.WriteLine();
            }
        }

        private static void InitializeTwoDimArray(int numberArrays, int[][] arrayOfArrays)
        {

            for (int i = 0; i < numberArrays; i++)
            {
                Console.WriteLine($"Please enter dimension for {i + 1} array: ");
                int dimensionOfArray = ParseInput();

                for (int j = 0; j < dimensionOfArray; j++)
                {
                    arrayOfArrays[i][j] = ParseInput();
                }
            }

        }
        private static int ParseInput()
        {
            int result;

            while (!int.TryParse(Console.ReadLine(), out result))

            {
                Console.WriteLine("Invalid input, please try again");
            }

            return result;
        }
    }
}

