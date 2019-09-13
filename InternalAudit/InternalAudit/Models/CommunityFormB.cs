using System;
using System.Collections.Generic;

namespace InternalAudit.Models
{
    public partial class CommunityFormB
    {
        public int CommunityFormBrecNo { get; set; }
        public string DistrictOffice { get; set; }
        public string OfficerPersonnelsName { get; set; }
        public string PostName { get; set; }
        public string Grade { get; set; }
        public DateTime? JoiningDate { get; set; }
        public string Gender { get; set; }
        public string Religion { get; set; }
        public string Category { get; set; }
        public int? FormRecNo { get; set; }
    }
}
