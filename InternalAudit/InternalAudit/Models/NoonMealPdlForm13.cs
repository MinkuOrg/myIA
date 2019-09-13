using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace InternalAudit.Models
{
    public partial class NoonMealPdlForm13
    {
        public int NoonMealRecNo { get; set; }
        public string Subject { get; set; }
        public string AsstDirector { get; set; }
        public string Inspector { get; set; }
        public string DeputyInspector { get; set; }
        public string AssistantInspector { get; set; }
        public string JuniorAssistant { get; set; }
        public string Typist { get; set; }
        public string RecordClerk { get; set; }
        public string OfficeAssistant { get; set; }

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
