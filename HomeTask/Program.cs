using System;
using System.Collections.Generic;
using System.Linq;

namespace HomeTask
{
    class Program

    {
        static void Increase(Dictionary<string, int> storage, string fruit, int amount, bool addable = true)
        {

            if (!storage.ContainsKey(fruit))
            {
                if (addable)
                {
                    storage.Add(fruit, amount);
                }

                else

                {
                    throw new ArgumentException($"Fruit {fruit} not found");
                }
            }
            else
            {
                storage[fruit] += amount;
            }
        }

        static void Decrease(Dictionary<string, int> storage, string fruit, int amount)
        {
            if (!storage.ContainsKey(fruit))
            {
                throw new ArgumentException($"Fruit {fruit} not found");
            }
            if (storage[fruit] < amount)
            {
                throw new ArgumentException($"Fruit {fruit} amount is less than {amount}");
            }
            storage[fruit] -= amount;
        }
        static void Print(Dictionary<string, int> storage)
        {
            foreach (var item in storage)
            {
                Console.WriteLine($"{item.Key}: {item.Value}");
            }
            Console.WriteLine("****************************");
        }
        static void Main(string[] args)
        {
           
           
                      return;

            Dictionary<string, int> fruitStorage = new Dictionary<string, int>()
            {{"Orange", 0}, {"Apple",0}, {"Banana",0}};
            Increase(fruitStorage, "Apple", 100);
            Increase(fruitStorage, "Orange", 150);
            Print(fruitStorage);
            Increase(fruitStorage, "Kiwi", 50);
            Print(fruitStorage);
            Decrease(fruitStorage, "Kiwi", 25);
            Print(fruitStorage);

            Console.ReadLine();
            return;


            //List<int> numbers = new List<int> { 4, 5, 70, 4, 0, -7, 2, 8 };

           // var result1 = numbers.OrderBy(x => x).Skip(2);

           // Console.WriteLine(string.Join(",", result1));

            return;


            int[] arrayInitial = new int[] { 4, 5, 70, 4, 0, -7, 2, 8 };

            for (int i = 0; i < arrayInitial.Length; i++)
            {
                Console.WriteLine(arrayInitial[i] + " is divided on");
                for (int j = 0; j < arrayInitial.Length; j++)
                {
                    try
                    {
                        if (arrayInitial[i] % arrayInitial[j] == 0)
                        {
                            Console.Write(arrayInitial[j] + " ");
                        }
                    }
                    catch (Exception ex)
                    {
                        Console.Write("");

                    }

                }
                Console.WriteLine();

            }

        }

    }
}

