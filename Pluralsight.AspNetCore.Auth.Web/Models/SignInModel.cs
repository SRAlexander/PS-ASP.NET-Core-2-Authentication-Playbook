using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Pluralsight.AspNetCore.Auth.Web.Models
{
    public class SignInModel
    {
        [Required(ErrorMessage="You have to supply a username")]
        public string Username { get; set; }
        [Required(ErrorMessage = "You have to supply a password")]
        public string Password { get; set; }
    }
}