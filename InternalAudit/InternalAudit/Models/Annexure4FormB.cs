using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace InternalAudit.Models
{
    public partial class Annexure4FormB
    {
        public int Annexure4FormBrecNo { get; set; }
        public int? Institutions { get; set; }
        public int? FinancialYear { get; set; }
        public string AuditFees { get; set; }
        public int? FormRecNo { get; set; }

        [NotMapped]
        public string FinancialYearName { get; set; }
    
        [NotMapped]
        public string InstitutionName { get; set; }
    }
}
