using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace entityLayer.concrete
{
    public class project
    {
        [Key]
        public int projectID { get; set; }
        [StringLength(25)]
        public string name { get; set; }
        [StringLength(500)]
        public string? description { get; set; }
        public DateTime startDate { get; set;}
        public DateTime? endDate { get; set;}
        public int CreatedByUserId { get; set; }
        [StringLength(15)]
        public string Status { get; set; }
        [ForeignKey("companyUserID")]
        public int companyUserID { get; set; }
        [JsonIgnore]
        public companyUser? companyUser { get; set; }

        [JsonIgnore]

        [ForeignKey("CreatedByUserId")]
        public AppUser? AppUser { get; set; }        

    }
}
