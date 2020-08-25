using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPCRUDoperation
{
    public interface ITimeEntryRepository
    {
        TimeEntry Create(TimeEntry timeEntry);
        TimeEntry Find(long Id);
        bool Contains(long Id);
        IEnumerable<TimeEntry> List();
        TimeEntry Update(long Id, TimeEntry timeEntry);
        void Delete(long Id);
    }
}
