using System;
using System.Collections.Generic;

namespace Classes
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("Yuliya", "Babuk", new[] { 5, 4, 4, 5 });
            Student student2 = new Student("Yan", "Antonov", new[] { 5, 5, 5, 5 });

            Group group1 = new Group("1", new List<Student> { student1, student2 });
            Group group2 = new Group("2", new List<Student> { new Student("Alex", "Baron", new[] { 3, 4, 2, 3 }),
            new Student("Aleh", "Barin", new[] { 3, 4, 3, 3 })});

            group1.PrintAverageMarks();
            group1.PrintMarks();
            Console.WriteLine();
            group2.PrintAverageMarks();
            group2.PrintMarks();

            student1.TransferToAnotherGroup(group1, group2);
            group2.TransferToAnotherGroup(group2.ListOfStudents[0], group1);
        }
    }
}
