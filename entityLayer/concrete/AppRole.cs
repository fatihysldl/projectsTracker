using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace entityLayer.concrete
{
    public class AppRole : IdentityRole<int>
    {
        public string Description { get; set; }
        public List<AppUser> appUsers { get; set; }
        public List<companyUser> companyUsers { get; set; }
    }
}
