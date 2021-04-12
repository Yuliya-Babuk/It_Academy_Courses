using System.Collections.Generic;

namespace ManagingStudyingProcess
{
    class MasterStudent : IStudent, IPublishable
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string GroupNumber { get; set; }
        public List<string> Publications { get; set; }

    }
}
