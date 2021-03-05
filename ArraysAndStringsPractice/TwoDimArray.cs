using System;

namespace ArraysAndStringsPractice
{
    class TwoDimArray
    {
        public void Run()
        {
            Console.WriteLine("Please enter dimension of array!\nEnter number of rows: ");
            int rows = ParseInput();
            Console.WriteLine("Please enter number of columns: ");
            int columns = ParseInput();

            int[,] twoDimArray = new int[rows, columns];

            InitializeTwoDimArray(rows, columns, twoDimArray);

            int maxIndex = 0;

            for (int i = 0; i < rows; i++)
            {
                int maxElement = twoDimArray[i, 0];
                for (int j = 0; j < columns; j++)
                {

                    if (twoDimArray[i, j] > maxElement)
                    {
                        maxIndex = j;
                        maxElement = twoDimArray[i, j];
                    }
                }
                for (int j = maxIndex; j < columns - 1; j++)
                {
                    twoDimArray[i, j + 1] = 0;
                }
            }
            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                Console.Write($"{twoDimArray[i, j]}\t");
                Console.WriteLine();
            }
        }

        private static void InitializeTwoDimArray(int rows, int columns, int[,] twoDimArray)
        {

            for (int i = 0; i < rows; i++)
            {
                Console.WriteLine($"Please enter {columns} elements for {i + 1} row: ");
                for (int j = 0; j < columns; j++)
                {
                    twoDimArray[i, j] = ParseInput();
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
