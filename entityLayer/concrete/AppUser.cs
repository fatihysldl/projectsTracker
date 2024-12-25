using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace entityLayer.concrete
{
    public class AppUser : IdentityUser<int>
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        [ForeignKey("roleID")]
        public int roleID { get; set; }
        public AppRole? AppRole { get; set; }
        [ForeignKey("companyUserID")]
        public int companyUserID { get; set; }
        [JsonIgnore]
        public companyUser? companyUser { get; set; }
       
        public List<project> Projects { get; set; }

        
        


      
        

    }
}
