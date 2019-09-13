using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace InternalAudit.Models
{
    public partial class Annexure2FormB
    {
        public int Annexure2FormBrecNo { get; set; }
        public string AdministrativeDepartment { get; set; }
        public string InstitutionDetails { get; set; }
        public int? FinancialYear { get; set; }
        public string AuditFees { get; set; }

        [NotMapped]
        public string FinancialYearName { get; set; }

        public int? FormRecNo { get; set; }
    }
}
