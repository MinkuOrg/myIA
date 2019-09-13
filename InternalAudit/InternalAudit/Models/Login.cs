using System;
using System.Collections.Generic;

namespace InternalAudit.Models
{
    public partial class Login
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public int Id { get; set; }
    }
}
