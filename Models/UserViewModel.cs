using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace E_learningPlatform.Models
{
    public class UserViewModel
    {
        public Guid Id { get; set; }

        [Display(Name = "Username")]
        public string? UserName { get; set; }

        [Display(Name = "Email")]
        public string? Email { get; set; }

        [Display(Name = "Roles")]
        public IList<string> Roles { get; set; } = new List<string>();

        [Display(Name = "Email Confirmed")]
        public bool EmailConfirmed { get; set; }
    }
}