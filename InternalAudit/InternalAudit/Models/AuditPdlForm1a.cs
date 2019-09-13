using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InternalAudit.Models
{
    public partial class AuditPdlForm1a
    {
        public int AuditPdlForm1ArecNo { get; set; }
        [Required(ErrorMessage = "Please Select FinancialYear !")]
        public int? FinancialYear { get; set; }
        [Required(ErrorMessage = "Please Select District !")]
        public int? District { get; set; }
        [Required(ErrorMessage = "Please Select Institutions !")]
        public int? Institutions { get; set; }
        [Required(ErrorMessage = "Please Select NoOfInstitutions !")]
        public int? NoOfInstitutions { get; set; }
        [Required(ErrorMessage = "Please Select InstPendingPrevMonth !")]
        public int? InstPendingPrevMonth { get; set; }
        [Required(ErrorMessage = "Please Select InstCompletedThisMonth !")]
        public int? InstCompletedThisMonth { get; set; }
        [Required(ErrorMessage = "Please Select InstPendingEndMonth !")]
        public int? InstPendingEndMonth { get; set; }

        public int? FormRecNo { get; set; }

        [NotMapped]
        public string FinancialYearName { get; set; }
        [NotMapped]
        public string DistrictName { get; set; }
        [NotMapped]
        public string InstitutionName { get; set; }
    }
}
