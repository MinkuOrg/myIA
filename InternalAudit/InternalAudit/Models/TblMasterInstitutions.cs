using System;
using System.Collections.Generic;

namespace InternalAudit.Models
{
    public partial class TblMasterInstitutions
    {
        public int InstitutionsRecNo { get; set; }
        public string District { get; set; }
        public string InstitutionsCategory { get; set; }
        public string InstitutionsName { get; set; }
        public string InstitutionsDetails { get; set; }
        public string Contact { get; set; }
        public string EmaiId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }
    }
}
