using ClassWorkStackExample;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ClassWorkStackExample
{
    public enum StackOperation
    {
        Push,
        Pop
    }

    class Student
    {
        public string Name { get; set; }

        public string Surname { get; set; }
        public Group Group { get; set; }
        public void TransferToAnotherGroup(Group gr)
        {
            Group = gr;
        }

    }
    class Group
    {
        public string Number { get; set; }
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



            Student s = new Student();

            Group gr1 = new Group() { Number = "g1" };

            Student st1 = new Student { Surname = "Ivanov", Name = "Oleg", Group = gr1 };
            Student st2 = new Student { Name = "s2", Group = gr1 };

            Group gr2 = new Group() { Number = "g2" };

            Student st3 = new Student { Name = "s3", Group = gr2 };
            Student st4 = new Student { Name = "s4", Group = gr2 };


            List<Student> students = new List<Student> { st1, st2, st3, st4 };

            List<string> initials = students.Select(student => student.Surname + " " + student.Name[0].ToString()).ToList();

            st1.TransferToAnotherGroup(gr2);

            List<Student> studentsGr1 = GetStudentsByGroup(students, gr1);
            List<Student> studentsGr2 = GetStudentsByGroup(students, gr2);

            static List<Student> GetStudentsByGroup(List<Student> allStudents, Group group)
            {
                List<Student> studentsByGroup = new List<Student>();

                foreach (var student in allStudents)
                {
                    if (student.Group == group)
                        studentsByGroup.Add(student);
                }

                return studentsByGroup;
            }

        }
    }
}

