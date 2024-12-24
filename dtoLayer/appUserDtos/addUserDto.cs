using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dtoLayer.appUserDtos
{
    public class addUserDto
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; } // mail yerine Email
        public string Role { get; set; } // Kullanıcının atanacağı rol
        //public string Password { get; set; }
    }
}
