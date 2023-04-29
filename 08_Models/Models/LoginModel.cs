﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace _08_Models.Models
{
    public class LoginModel
    {
        [Required]
        [Display(Name = "Kullanıcı Adı:")]
        public string UserName { get; set; }
        [Required]
        public string Password { get; set; }
    }
}