using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dtoLayer.taskStageDtos
{
    public class updateTaskStageDto
    {
        public int taskID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string AssignedToUserId { get; set; }
        public bool IsApproved { get; set; }
        public int Order { get; set; }

        public int projectID { get; set; }
    }
}
