using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace InternalAudit.Models
{
    public partial class AuditPdlFormI
    {
        public int AuditPdlFormIrecNo { get; set; }
        public int? FinancialYear { get; set; }
        public int? District { get; set; }
        public int? Institutions { get; set; }
        public string CentreInstitutionDetails { get; set; }
        public string PendencyReasons { get; set; }
        public int? FormRecNo { get; set; }
        [NotMapped]
        public string FinancialYearName { get; set; }
        [NotMapped]
        public string DistrictName { get; set; }
        [NotMapped]
        public string InstitutionName { get; set; }
    }
}
