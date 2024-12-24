using entityLayer.concrete;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dataAccessLayer.concrete
{
    public class context : IdentityDbContext<AppUser,AppRole,int>
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("server=MuhammedFatih\\SQLEXPRESS; initial catalog=projectTracker; integrated security=true; TrustServerCertificate=True;");
        }
        public DbSet<project> projects { get; set; }
        public DbSet<taskStage> taskStages { get; set; }

    }
}
