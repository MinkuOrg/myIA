using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace InternalAudit.Models
{
    public partial class NoonMealPdlForm2
    {
        public int NoonMealRecNo { get; set; }
        public int? InstitutionsName { get; set; }
        public int? TotalCenter { get; set; }
        public string Completed { get; set; }
         
        public string Pending { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
        public int? FinancialYear { get; set; }
        public int? PeriodCategory { get; set; }
        public int? Period { get; set; }
        public int? FormRecNo { get; set; }

        [NotMapped]
        public string FinancialYearName { get; set; }
        [NotMapped]
        public string PeriodCategoryName { get; set; }
        [NotMapped]
        public string PeriodName { get; set; }
        [NotMapped]
        public string InstitutionName { get; set; }
    }
}
