using System;
using System.Collections.Generic;

namespace databaseconnection.Models
{
    public partial class Finance
    {
        public string TransId { get; set; }
        public decimal TAmount { get; set; }
        public string SessionName { get; set; }
        public string AId { get; set; }
        public string EvName { get; set; }
        public decimal EvExpenditure { get; set; }
        public decimal? Budget { get; set; }
        public decimal? IncomeFromEvent { get; set; }
        public decimal? SocietyAmount { get; set; }

        public virtual Advisor A { get; set; }
        public virtual SocietyEvent EvNameNavigation { get; set; }
        public virtual Tenure SessionNameNavigation { get; set; }
    }
}
