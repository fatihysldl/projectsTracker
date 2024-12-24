using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dtoLayer.appUserDtos
{
    public class updateUserDto
    {
        public string Id { get; set; } // Güncelleme için zorunlu
        public string Name { get; set; }
        public string Surname { get; set; }
        public string Email { get; set; }
        public string Role { get; set; } // İsteğe bağlı
        //public string Password { get; set; } // Şifre güncellemesi
    }
}
