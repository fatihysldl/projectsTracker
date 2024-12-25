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
        public DbSet<companyUser> companyUsers { get; set; }
        public DbSet<appUserProject> appUserProjects { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // companyUser ve AppUser arasında 1-N ilişkisi
            modelBuilder.Entity<AppUser>()
                .HasOne(a => a.companyUser) // AppUser bir şirket yöneticisine ait
                .WithMany(c => c.appUsers) // companyUser birden fazla çalışanı olabilir
                .HasForeignKey(a => a.companyUserID) // AppUser'da foreign key olarak companyUserID kullanılır
                .OnDelete(DeleteBehavior.Restrict); // Cascade yerine Restrict ile veri bütünlüğü korunur

            modelBuilder.Entity<companyUser>() //company userda role idyi defaul olarak manager ayarlar
               .Property(c => c.roleID)
               .HasDefaultValue(1);

            

            base.OnModelCreating(modelBuilder);


            // Çoka çok ilişki için bağlantı tablosu yapılandırması
            modelBuilder.Entity<AppUserProject>()
                .HasKey(ap => new { ap.AppUserId, ap.ProjectId });

            modelBuilder.Entity<AppUserProject>()
                .HasOne(ap => ap.AppUser)
                .WithMany(au => au.AppUserProjects)
                .HasForeignKey(ap => ap.AppUserId);

            modelBuilder.Entity<AppUserProject>()
                .HasOne(ap => ap.Project)
                .WithMany(p => p.AppUserProjects)
                .HasForeignKey(ap => ap.ProjectId);
        }
    }
}
