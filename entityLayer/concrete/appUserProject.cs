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
    public class appUserProject
    {
        [Key]
        public int Id { get; set; }
        [ForeignKey("AppUser")]
        public int AppUserId { get; set; }
        [JsonIgnore]
        public AppUser? AppUser { get; set; }

        [ForeignKey("Project")]
        public int ProjectId { get; set; }
        [JsonIgnore]
        public project? Project { get; set; }
    }
}
