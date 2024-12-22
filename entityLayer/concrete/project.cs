using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
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
        public string CreatedByUserId { get; set; }
        [StringLength(15)]
        public string Status { get; set; }
    }
}
