using System;
using System.Collections.Generic;

namespace databaseconnection.Models
{
    public partial class Advisor
    {
        public Advisor()
        {
            Finance = new HashSet<Finance>();
            SocietyEvent = new HashSet<SocietyEvent>();
            Tenure = new HashSet<Tenure>();
        }

        public string AId { get; set; }
        public string AName { get; set; }
        public string ADepName { get; set; }
        public string AScale { get; set; }
        public string AGender { get; set; }
        public string AEmail { get; set; }
        public string APhone { get; set; }

        public virtual ICollection<Finance> Finance { get; set; }
        public virtual ICollection<SocietyEvent> SocietyEvent { get; set; }
        public virtual ICollection<Tenure> Tenure { get; set; }
    }
}
