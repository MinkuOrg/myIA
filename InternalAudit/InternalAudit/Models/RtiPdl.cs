using System;
using System.Collections.Generic;

namespace InternalAudit.Models
{
    public partial class RtiPdl
    {
        public int RtiPdlRecNo { get; set; }
        public int? Details { get; set; }
        public int? OriginalPetitions { get; set; }
        public int? Appealpetitions { get; set; }
        public int? OriginalAppealPetitions { get; set; }
        public int? Total { get; set; }
    }
}
