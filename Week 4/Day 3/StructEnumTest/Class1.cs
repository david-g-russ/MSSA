using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StructEnumTest
{
    enum Status
    {
        NotStarted = 1,
        InProgress,
        OnHold,
        Completed,
        Deleted
    }

    internal class ToDo
    {
        public int TaskID { get; set; }
        public string Description { get; set; }
        public int EstimatedHours { get; set; }
        public Status Status { get; set; }
    }
}
