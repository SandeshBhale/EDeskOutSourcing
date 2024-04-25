using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repo.Enums
{
    public enum TaskStatus
    {
        Created = 1,
        Assigned = 2,
        Reported = 3,
        Conflicted = 4,
        Closed = 5
    }
}
