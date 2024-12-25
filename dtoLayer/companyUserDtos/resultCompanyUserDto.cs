using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dtoLayer.companyUserDtos
{
    public class resultCompanyUserDto
    {
        public int companyUserID { get; set; }
        public string companyUserName { get; set; }
        public int companyUserEmail { get; set; }
        public int companyUserPassword { get; set; }
        public int roleID { get; set; }
    }
}
