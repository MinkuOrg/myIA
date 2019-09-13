using System;
using System.Collections.Generic;
using System.Text;

namespace InternalAudit.DTO
{
    public class MessageDTO
    {
        public string Message { get; set; }
        public string Status { get; set; }
        public string SamePageAction { get; set; }
        public string SamePageController { get; set; }
        public string BackPageAction { get; set; }
        public string BackPageController { get; set; }

    }
}
