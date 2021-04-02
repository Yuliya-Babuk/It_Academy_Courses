using System;
using System.Collections.Generic;
using System.Text;

namespace ManagingStudyingProcess
{
    class Student
    {
        public string Name { get; set; }

        public string Surname { get; set; }

        public List<int> Marks { get; set; }

        public string GroupNumber { get; set; }

        public Student(string name, string surname, string groupNumber)
        {
            Name = name;
            Surname = surname;
            GroupNumber = groupNumber;
            Marks = new List<int>();
        }
        //public override bool Equals(Student student)
        //{
        //    return base.Equals(student);
        //}
        //public override int GetHashCode()
        //{
        //    return base.GetHashCode();
        //}

        public void GiveGrade(int mark)
        {
            Marks.Add(mark);
        }

    }
}
