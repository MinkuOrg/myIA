using System;
using System.Collections.Generic;

namespace InternalAudit.Models
{
    public partial class TblMasterDistrict
    {
        public int DistrictRecNo { get; set; }
        public string DistrictName { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
    }
}
