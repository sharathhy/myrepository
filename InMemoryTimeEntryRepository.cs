using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPCRUDoperation
{
    public class InMemoryTimeEntryRepository:ITimeEntryRepository
    {
        private readonly Dictionary<long, TimeEntry> _timeenteries = new Dictionary<long, TimeEntry>();
        public TimeEntry Create(TimeEntry timeEntry)
        {
            var id = _timeenteries.Count + 1;
            timeEntry.Id = id;
            _timeenteries.Add(id,timeEntry);
            return timeEntry;
        }
        public TimeEntry Find(long id) => _timeenteries[id];
        public bool Contains(long id) => _timeenteries.ContainsKey(id);
        public IEnumerable<TimeEntry> List() => _timeenteries.Values.ToList();
        public TimeEntry Update(long id,TimeEntry timeEntry)
        {
            timeEntry.Id = id;
            _timeenteries[id] = timeEntry;
            return timeEntry;
        }
        public void Delete(long id) => _timeenteries.Remove(id);
    }
}
