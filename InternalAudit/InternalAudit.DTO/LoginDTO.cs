﻿using System;
using System.ComponentModel.DataAnnotations;

namespace InternalAudit.DTO
{
     public class LoginDTO
    {
        [Required(ErrorMessage ="Username is required")]
        public string UserName { get; set; }
        [Required(ErrorMessage = "Password is required")]
        public string Password { get; set; }
    }
}
