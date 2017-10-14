using System;
using System.Collections.Generic;

namespace databaseconnection.Models
{
    public partial class SocietyEvent
    {
        public SocietyEvent()
        {
            Finance = new HashSet<Finance>();
            Subevent = new HashSet<Subevent>();
        }

        public string EvName { get; set; }
        public string EvType { get; set; }
        public DateTime EvStartDate { get; set; }
        public DateTime EvEndDate { get; set; }
        public DateTime EvDateOfApproval { get; set; }
        public string AId { get; set; }
        public string SessionName { get; set; }

        public virtual ICollection<Finance> Finance { get; set; }
        public virtual ICollection<Subevent> Subevent { get; set; }
        public virtual Advisor A { get; set; }
        public virtual Tenure SessionNameNavigation { get; set; }
    }
}
