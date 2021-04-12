using System;
using System.Collections.Generic;
using System.Text;

namespace ManagingStudyingProcess
{
    interface IGradable
    {
        public List<int> Marks { get; set; }

        public event EventHandler<GradeEventArgs> GradeGiven;
    }
}
