using System;
using System.Threading;

namespace Classes2
{
    class Student
    {
        public string Name { get; private set; }

        private string group;
        public string Group { get { return group; } }

        private DateTime lastGroupModified;

        public void ChangeGroup (string group)
        {
            if ((DateTime.Now - lastGroupModified).TotalSeconds <1)
            {
                throw new Exception("Group can not be changed more than 1 time in a day");
            }
            
                this.group = group;
                lastGroupModified = DateTime.Now;
            
        }
        public Student (string name, string group)
        {
           Name = name;
           this.group = group;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student(group: "101", name: "Ivan");
            student.ChangeGroup("102");
            Console.WriteLine($"{student.Name} - {student.Group} ");
            Thread.Sleep(500);
            student.ChangeGroup("103");
            Console.WriteLine($"{student.Name} - {student.Group} ");

        }
    }
}
