using System;
using System.Collections.Generic;

namespace E_learningPlatform.Models
{    public class EditUserViewModel
    {
        public Guid Id { get; set; }
        public string UserName { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public List<string> SelectedRoles { get; set; } = new List<string>();
        public IList<string> Roles { get; set; } = new List<string>(); // Current roles of the user
    }
}