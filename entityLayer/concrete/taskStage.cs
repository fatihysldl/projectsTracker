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
    public class taskStage
    {
        [Key]
        public int taskID { get; set; }
        [StringLength(30)]
        public string Name { get; set; }
        [StringLength(500)]
        public string? Description { get; set; }
        public string AssignedToUserId { get; set; }
        public bool IsApproved { get; set; }
        public int Order { get; set; }

        public int projectID { get; set; }
        
        [JsonIgnore]

        [ForeignKey("projectID")]
        public project? project { get; set; }

    }
}
