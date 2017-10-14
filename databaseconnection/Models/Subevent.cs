using System;
using System.Collections.Generic;

namespace databaseconnection.Models
{
    public partial class Subevent
    {
        public Subevent()
        {
            Participant = new HashSet<Participant>();
        }

        public string SeId { get; set; }
        public string SeName { get; set; }
        public string EvName { get; set; }

        public virtual ICollection<Participant> Participant { get; set; }
        public virtual SocietyEvent EvNameNavigation { get; set; }
    }
}
