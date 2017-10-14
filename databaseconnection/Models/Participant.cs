using System;
using System.Collections.Generic;

namespace databaseconnection.Models
{
    public partial class Participant
    {
        public string PId { get; set; }
        public string PName { get; set; }
        public string PPhone { get; set; }
        public string PUniName { get; set; }
        public string PGender { get; set; }
        public string PNocId { get; set; }
        public string RollNumber { get; set; }
        public string SeId { get; set; }

        public virtual Team RollNumberNavigation { get; set; }
        public virtual Subevent Se { get; set; }
    }
}
