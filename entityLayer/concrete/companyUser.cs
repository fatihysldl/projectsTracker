using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace entityLayer.concrete
{
    public class companyUser
    {
        public int companyUserID { get; set; }
        public string companyUserName { get; set; }
        public string companyUserEmail { get; set; }
        public string companyUserPassword { get; set; }
        public int roleID { get; set; }
        [JsonIgnore]
        [ForeignKey("roleID")]      
        public AppRole? AppRole { get; set; }
        public List<project> projects { get; set; }
        public List<AppUser> appUsers { get; set; }
    }
}
