using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Milestone_3.Models.Roles
{
    public class Role : IdentityRole
    {
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
      
    }
}
