using System;
using System.Collections.Generic;

namespace InternalAudit.Models
{
    public partial class TblMasterPeriod
    {
        public int PeriodRecNo { get; set; }
        public int? PeriodCategory { get; set; }
        public string PeriodName { get; set; }
    }
}
