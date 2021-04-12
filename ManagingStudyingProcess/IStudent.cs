using System;
using System.Collections.Generic;
using System.Text;

namespace ManagingStudyingProcess
{
    interface IStudent
    {
        string Name { get; set; }  //public by default for Interfaces
        string Surname { get; set; }
        string GroupNumber { get; set; }

    }
}
