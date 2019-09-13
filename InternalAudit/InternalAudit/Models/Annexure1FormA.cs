using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace InternalAudit.Models
{
    public partial class Annexure1FormA
    {
        public int Annexure1FormArecNo { get; set; }
        public int? FinancialYear { get; set; }
        public int? District { get; set; }
        public string AgricultureExtenCentre { get; set; }
        public string PendencyDetail { get; set; }
        public int? FormRecNo { get; set; }

        [NotMapped]
        public string FinancialYearName { get; set; }
        [NotMapped]
        public string DistrictName { get; set; }
        
    }
}
