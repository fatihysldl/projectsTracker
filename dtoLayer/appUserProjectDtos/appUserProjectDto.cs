using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dtoLayer.appUserProjectDtos
{
    public class appUserProjectDto
    {
        public int ProjectId { get; set; }  // Proje ID'si
        public List<int> UserIds { get; set; }  // Projeye eklenecek kullanıcı ID'leri
    }
}
