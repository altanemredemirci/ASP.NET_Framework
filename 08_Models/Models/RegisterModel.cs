﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _08_Models.Models
{
    public class RegisterModel
    {
        [Required(ErrorMessage ="İsim Girsene Arkadaşım")]
        public string FirstName { get; set; }
        [Required]
        public string LastName { get; set; }
        [Required]      
        public string UserName { get; set; }
        [Required, DataType(DataType.EmailAddress)]
        public string Email { get; set; }

        [Required]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Required]
        [Compare("Password")]
        public string RePassword { get; set; }
    }
}