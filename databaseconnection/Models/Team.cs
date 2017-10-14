using System;
using System.Collections.Generic;

namespace databaseconnection.Models
{
    public partial class Team
    {
        public Team()
        {
            Participant = new HashSet<Participant>();
        }

        public string RollNumber { get; set; }
        public string TName { get; set; }
        public string TDepName { get; set; }
        public string TEmail { get; set; }
        public string TSemester { get; set; }
        public string TAddress { get; set; }
        public string TPhoneNumber { get; set; }
        public string TGender { get; set; }
        public string TCgpa { get; set; }

        public virtual ICollection<Participant> Participant { get; set; }
    }
}
