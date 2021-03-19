using System;
using System.Collections.Generic;

namespace ClassWork(StackExample)
{
    public enum StackOperation
    {
        Push,
        Pop
    }

    class Program
    {
        static void Main(string[] args)
        {
            Stack<string> stack = new Stack<string>();
            Queue<string> queue = new Queue<string>();

            Random random = new Random();
            for (int i = 0; i < 100; i++)
            {
                StackOperation operation = random.Next(2) == 0
                    ? StackOperation.Push
                    : StackOperation.Pop;


                if (operation == StackOperation.Push)
                {
                    var stackItem = random.Next(100).ToString();
                    stack.Push(stackItem);
                    Console.WriteLine($"Add to stack {stackItem}");
                }

                else
                {
                    if (stack.TryPop(out string stackItem))
                    {
                        Console.WriteLine($"Take from stack {stackItem}");
                    }
                    else
                        Console.WriteLine("Empty");

                }
            }
        }
    }
}
