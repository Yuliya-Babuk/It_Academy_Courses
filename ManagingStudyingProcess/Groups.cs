using System;
using System.Collections.Generic;
using System.Linq;

namespace ManagingStudyingProcess
{
    class Groups
    {
        public List<Group> ListOfGroups { get; set; }

        public Groups()
        {
            ListOfGroups = new List<Group>();
        }
        public void CreateGroup()
        {
            Console.WriteLine("Enter a group number you want to create:");
            Group group = new Group(Console.ReadLine());
            ListOfGroups.Add(group);
        }
        public void PrintGroups()
        {
            if (ListOfGroups.Count() < 1)
            {
                Console.WriteLine("Create a group first");
                return;
            }
            Console.WriteLine("List of the groups:");
            foreach (Group group in ListOfGroups)
            {
                Console.WriteLine(group.GroupNumber);
            }
        }
        public void EditGroup(string groupNumber, string newGroupNumber)
        {
            if (ListOfGroups.Any(g => g.GroupNumber == newGroupNumber))
            {
                Console.WriteLine("A group with this number was found, you can not use this number");
                return;
            }

            Group group = ListOfGroups.FirstOrDefault(g => g.GroupNumber == groupNumber);
            if (group == null)
            {
                Console.WriteLine("The group was not found, please, try again");
                return;
            }
            group.GroupNumber = newGroupNumber;
        }

    }
}

