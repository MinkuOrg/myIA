using System;
using System.ComponentModel.DataAnnotations;

namespace InternalAudit.DTO
{
  public  class TblMasterInstitutionsDTO
    {
        [Required(ErrorMessage ="District is required")]
        public string District { get; set; }
        
        public string InstitutionsCategory { get; set; }
        [Required(ErrorMessage = "InstitutionsName is required")]
        public string InstitutionsName { get; set; }
        public string InstitutionsDetails { get; set; }
        [Required]
        [DataType(DataType.PhoneNumber)]
        public string Contact { get; set; }
        [Required]
        [EmailAddress(ErrorMessage ="Please Insert Valid E-MailId")]
        public string EmaiId { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreatedDate { get; set; }

    }
}
