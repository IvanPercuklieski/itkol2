using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication.Models
{
    public class UserRoles
    {
        public string email {  get; set; }
        public string selectedRole { get; set; }

        public List<string> Roles { get; set; }

        public UserRoles() {
            Roles = new List<string>()
            {
                "Editor",
                "Admin",
                "User"
            };        
        }
    }
}