using System.Collections.Generic;
using System;

namespace Classes
{
    class Group
    {
        public string GroupNumber { get; private set; }
        public List<Student> ListOfStudents { get; private set; }

        public Group(string groupNumber, List<Student> students)
        {
            GroupNumber = groupNumber;
            ListOfStudents = students;
        }

        public void PrintAverageMarks()
        {
            Console.WriteLine("Group number: {0}\n\nAverage mark:", GroupNumber);
            foreach (Student student in ListOfStudents)
            {
                float averageMark = student.CalculateAverageMark();
                Console.WriteLine("{0} {1} {2:F2}", student.Name, student.Surname, averageMark);
            }
        }

        public void PrintMarks()
        {
            Console.WriteLine("\nStudent's marks :");
            foreach (Student student in ListOfStudents)
            {
               Console.WriteLine("{0} {1}", student.Name, student.Surname);
               student.OutputMarks();
            }
        }
        
        public void TransferToAnotherGroup(Student student, Group groupNew)
        {
            student.TransferToAnotherGroup(this, groupNew);                      
        }
    }
}
