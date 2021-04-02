using System.Collections.Generic;

namespace ManagingStudyingProcess
{
    class Group
    {
        public string GroupNumber { get; set; }
        public List<Student> ListOfStudents { get; private set; } = new List<Student>();

        public Group(string groupNumber)
        {
            GroupNumber = groupNumber;
        }

        public void AddStudent(Student student)
        {
            ListOfStudents.Add(student);
        }
        public void DeleteStudent(Student student)
        {
            ListOfStudents.Remove(student);
        }
    }
}
