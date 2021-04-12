using System;
using System.Collections.Generic;

namespace ManagingStudyingProcess
{
    class Group
    {
        public string GroupNumber { get; set; }
        public List<IStudent> ListOfStudents { get; private set; } = new List<IStudent>();
     
        public Group(string groupNumber)
        {
            GroupNumber = groupNumber;
        }

        public void AddStudent(IStudent student)
        {
            ListOfStudents.Add(student);

            HandleEventSubscription(student, s => Subscribe(s));

        }     

        public void DeleteStudent(IStudent student)
        {
            ListOfStudents.Remove(student);

            HandleEventSubscription(student, s => Unsubscribe(s));
        }
        private void HandleEventSubscription(IStudent student, Action<IStudent> action)
        {
            if
                (student.GetType() == typeof(Student))
            {
                action(student);
            }
        }

        private void Subscribe(IStudent student)
        {
            (student as Student).GradeGiven += OnGradeGiven;
        }
        private void Unsubscribe(IStudent student)
        {
            (student as Student).GradeGiven -= OnGradeGiven;
        }

        private void OnGradeGiven(object sender, GradeEventArgs e)
        {
            Student student = sender as Student;
            Console.WriteLine($"{student.Name} {student.Surname} from group number  {GroupNumber}  {e.Grade}");
        }
    }
}
