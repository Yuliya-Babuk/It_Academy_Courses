using System;
using System.Linq;

namespace ManagingStudyingProcess
{
    class Program

    {
        static void Main(string[] args)
        {

            Groups groups = new Groups();
            Math.Po
            bool canContinue = true;
            while (canContinue)
            {
                Console.WriteLine("Enter a action:\n");

                Console.WriteLine("for groups:\n\n" +
                    "-сg - to сreate a new group;\n" +
                    "-rg - to look through a list of all groups;\n" +
                    "-ug - to update a group;\n" +
                    "-dg - to delete a group\n\n" +
                    "for students:\n\n" +
                    "-сs - to сreate a student;\n" +
                    "-ms - to сreate a master student;\n" +
                    "-rs - to look through a list of students;\n" +
                    "-us - to update a student;\n" +
                    "-ds - to delete a student;\n" +
                    "-gs - to give a grade to a student;\n\n" +
                    "-q - to exit");

                string userInput = Console.ReadLine().Trim('-');

                //string[] parsedInput = userInput.Split(" ", StringSplitOptions.RemoveEmptyEntries);
                // проверить на пустоту

                switch (userInput)
                {
                    case ("cg"):
                        {
                            groups.CreateGroup();
                            break;
                        }
                    case ("rg"):
                        {
                            groups.PrintGroups();
                            break;
                        }
                    case ("ug"):
                        {
                            Group group = FindGroup(groups);
                            if (group != null)
                            {
                                Console.WriteLine("Enter new group number:");
                                group.GroupNumber = Console.ReadLine();
                            }
                            break;
                        }
                    case ("dg"):
                        {
                            Group group = FindGroup(groups);
                            groups.ListOfGroups.Remove(group);
                        }
                        break;

                    case ("cs"):
                        {
                            Console.WriteLine("Input student's name, surname and group, using whitespaces in between:");
                            string[] input = Console.ReadLine().Split(" ", 3);
                            if (input.Length < 3)
                            {
                                Console.WriteLine("Please, check your input");
                                break;
                            }
                            Student student = new Student(input[0], input[1], input[2]);
                            Group group = groups.ListOfGroups.FirstOrDefault(g => g.GroupNumber == student.GroupNumber);
                            if (group == null)
                            {
                                Console.WriteLine("The group was not found, first create the group");
                            }
                            else
                            {
                                group.AddStudent(student);
                            }
                        }
                        break;

                    case ("ms"):
                        {
                            Console.WriteLine("Input master student's name, surname and group, using whitespaces in between:");
                            string[] input = Console.ReadLine().Split(" ", 3);
                            if (input.Length < 3)
                            {
                                Console.WriteLine("Please, check your input");
                                break;
                            }
                            MasterStudent masterStudent = new MasterStudent() { Name = input[0], Surname = input[1], GroupNumber = input[2] };
                            Group group = groups.ListOfGroups.FirstOrDefault(g => g.GroupNumber == masterStudent.GroupNumber);
                            if (group == null)
                            {
                                Console.WriteLine("The group was not found, first create the group");
                            }
                            else
                            {
                                group.AddStudent(masterStudent);
                            }
                            break;
                        }
                    case ("rs"):
                        {
                            if (groups.ListOfGroups.Count() < 1)
                            {
                                Console.WriteLine("Create a group first");
                            }

                            foreach (Group group in groups.ListOfGroups)
                            {
                                {
                                    Console.WriteLine($"Group number: {group.GroupNumber}");

                                    if (group.ListOfStudents.OfType<Student>().Any())
                                    {
                                        foreach (Student student in group.ListOfStudents)
                                        {
                                            Console.WriteLine($"{student.Name}, {student.Surname} marks: {string.Join(", ", student.Marks)}");
                                        }
                                    }
                                    if (group.ListOfStudents.OfType<MasterStudent>().Any())
                                    {
                                        foreach (MasterStudent student in group.ListOfStudents)
                                        {
                                            Console.WriteLine($"{student.Name}, {student.Surname} publications: {string.Join(", ", student.Publications)}");
                                        }
                                    }
                                }
                                if (group.ListOfStudents.Count() < 1)
                                {
                                    Console.WriteLine("There is no any student in the group");
                                }
                            }
                            break;
                        }
                    case ("us"):
                        {
                            IStudent student = FindStudent(groups);
                            if (student != null)
                            {
                                Console.WriteLine("Please, input new information about the student:");
                                Console.WriteLine("Input student's name:");
                                student.Name = Console.ReadLine();
                                Console.WriteLine("Input student's surname:");
                                student.Surname = Console.ReadLine();
                                Console.WriteLine("Input student's group number:");
                                student.GroupNumber = Console.ReadLine();
                            }
                        }
                        break;

                    case ("ds"):
                        {
                            IStudent student = FindStudent(groups);
                            groups.ListOfGroups.FirstOrDefault(g => g.GroupNumber == student.GroupNumber).DeleteStudent(student);

                            break;

                        }
                    case ("gs"):
                        {
                            Student student = FindStudent(groups) as Student;
                            if (student != null)
                            {
                                int mark;
                                Console.WriteLine("Input student's mark:");
                                if (int.TryParse(Console.ReadLine(), out mark))
                                {
                                    student.GiveGrade(mark);
                                }
                            }
                            break;
                        }
                    case ("q"):
                        {
                            canContinue = false;
                            break;
                        }
                }
            }


            static Group FindGroup(Groups groups)
            {
                Console.WriteLine("Enter a group number you want to update:");
                Group group = groups.ListOfGroups.FirstOrDefault(g => g.GroupNumber == Console.ReadLine());
                if (group == null)
                {
                    Console.WriteLine("The group was not found, check your input");
                }

                return group;
            }

            static IStudent FindStudent(Groups groups)
            {
                Console.WriteLine("Input student's name:");
                string name = Console.ReadLine();
                Console.WriteLine("Input student's surname:");
                string surname = Console.ReadLine();
                Console.WriteLine("Input student's group number:");
                string groupNumber = Console.ReadLine();
                Group group = groups.ListOfGroups.FirstOrDefault(g => g.GroupNumber == groupNumber);
                if (group == null)
                {
                    Console.WriteLine("The group was not found, first create the group");
                    return null;
                }
                else
                {
                    IStudent student = group.ListOfStudents.FirstOrDefault(s => s.Name == name && s.Surname == surname);
                    if (student == null)
                    {
                        Console.WriteLine("The student was not found, try again");
                    }
                    return student;
                }
            }


        }

    }
}
