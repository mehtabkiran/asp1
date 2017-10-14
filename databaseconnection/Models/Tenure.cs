using System;
using System.Collections.Generic;

namespace databaseconnection.Models
{
    public partial class Tenure
    {
        public Tenure()
        {
            Finance = new HashSet<Finance>();
            SocietyEvent = new HashSet<SocietyEvent>();
        }

        public string SessionName { get; set; }
        public DateTime TStartDate { get; set; }
        public DateTime TEndDate { get; set; }
        public string AId { get; set; }
        public decimal? Budget { get; set; }

        public virtual ICollection<Finance> Finance { get; set; }
        public virtual ICollection<SocietyEvent> SocietyEvent { get; set; }
        public virtual Advisor A { get; set; }
    }
}
