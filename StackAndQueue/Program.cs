using System;
using System.Collections.Generic;

namespace StackAndQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Student> students = new List<Student>
            {
                new Student("Yuliya", "Babuk"),
                new Student("Maria", "Vetrova"),
                new Student ("Narim", "Ignatov"),
                new Student("Hanna", "Vasilieva"),
            };

            Stack<Student> stack = new Stack<Student>(students.Count);

            foreach (Student student in students)
            {
                stack.Push(student);
                Console.WriteLine($"Task from {student.Name} {student.Surname} is received");
            }

            Console.WriteLine("\nExample how Stack works:\n");
            while (stack.Count > 0) //while (stack.TryPop(out var student))
            {
                Student student = stack.Pop();
                Console.WriteLine($"{student.Name} {student.Surname} got a cup of coffee");
            }

            Console.WriteLine("\n**********************************");

            Queue<Student> queue = new Queue<Student>(students.Count);

            foreach (Student student in students)
            {
                queue.Enqueue(student);
                Console.WriteLine($"Task from {student.Name} {student.Surname} is received");
            }

            Console.WriteLine("\nExample how Queue works:\n");

            while (queue.Count > 0)
            {
                Student student = queue.Dequeue();
                Console.WriteLine($"{student.Name} {student.Surname} got a cup of coffee");
            }

            Console.WriteLine("\n**********************************");

            MyQueue<Student> myQueue = new MyQueue<Student>();

            foreach (Student student in students)
            {
                myQueue.Enqueue(student);
                Console.WriteLine($"Task from {student.Name} {student.Surname} is received");
            }

            Console.WriteLine("\nExample how myQueue works:\n");

            foreach (Student student in students)
            {
                myQueue.Dequeue();
                Console.WriteLine($"{student.Name} {student.Surname} got a cup of coffee");
            }
        }
    }
}
