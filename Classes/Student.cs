using System;

namespace Classes
{
    class Student
    {
        public string Name { get; private set; }

        public string Surname { get; private set; }

        public int[] Marks { get; private set; }

        public Student(string name, string surname, int[] marks)
        {
            Name = name;
            Surname = surname;
            Marks = marks;
        }
           
        public float CalculateAverageMark()
        {
            int sumMarks = 0;

            for (int i = 0; i < Marks.Length; i++)
            {
                sumMarks += Marks[i];
            }

            float averageMark = (float)sumMarks / Marks.Length;

            return averageMark;
        }
        public void OutputMarks()
        {
            for (int i = 0; i < Marks.Length; i++)
            {
                Console.Write(Marks[i] + "\t");
            }

            Console.WriteLine();
        }
        public void TransferToAnotherGroup(Group groupEx, Group groupNew)
        {
            groupEx.ListOfStudents.Remove(this);
            groupNew.ListOfStudents.Add(this);
        }
        

    }
}
