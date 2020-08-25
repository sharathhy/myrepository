using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPCRUDoperation
{
    public struct TimeEntry
    {
        public long ?Id { get; set; }
        public long ProjectId { get; set; }
        public long UserId { get; set; }
        public DateTime Date { get; set; }
        public int Hours { get; set; }

        public TimeEntry(long id,long Projectid,long Userid, DateTime date, int hours)
        {
            Id = id;
            ProjectId = Projectid;
            UserId = Userid;
            Date = date;
            Hours = hours;
        }
        public TimeEntry( long Projectid, long Userid, DateTime date, int hours)
        {
            Id = null;
            ProjectId = Projectid;
            UserId = Userid;
            Date = date;
            Hours = hours;
        }
    }
}
