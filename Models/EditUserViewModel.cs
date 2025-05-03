using System;
using System.Collections.Generic;

namespace E_learningPlatform.Models
{
    public class EditUserViewModel
    {
        public Guid Id { get; set; }
        public string UserName { get; set; }
        public string Email { get; set; }
        public List<string> SelectedRoles { get; set; } = new List<string>();
        public IList<string> Roles { get; set; } // Current roles of the user
    }
}