using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dtoLayer.projectDtos
{
    public class updateProjectDto
    {
        public int projectID { get; set; }
        public string name { get; set; }
        public string? description { get; set; }
        public DateTime startDate { get; set; }
        public DateTime? endDate { get; set; }
        public string CreatedByUserId { get; set; }
        public string Status { get; set; }
    }
}
