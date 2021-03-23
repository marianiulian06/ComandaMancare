using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace comandamancare.Models
{
    public class SignIns
    { 
            [Required]
            [Display(Name = "Nume de utilizator")]
            public string Username { get; set; }

            [Required]
            [Display(Name = "Parola")]
            public string Password { get; set; }
        }
}