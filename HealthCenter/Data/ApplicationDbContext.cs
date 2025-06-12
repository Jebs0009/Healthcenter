using HealthCenter.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace HealthCenter.Data
{
	public class ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : IdentityDbContext<ApplicationUser>(options)
	{
		public DbSet<SystemCodeDetail> SystemCodeDetails { get; set; }
        public DbSet<SystemCode> SystemCode { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.Entity<ApplicationUser>()
                .HasOne(f=>f.Gender)
                .WithMany()
                .HasForeignKey(f => f.GenderId)
                .OnDelete(DeleteBehavior.Restrict);
            
            builder.Entity<ApplicationUser>()
                .HasOne(f => f.Maritalstatus)
                .WithMany()
                .HasForeignKey(f => f.MaritalstatusId)
                .OnDelete(DeleteBehavior.Restrict);
            
            builder.Entity<ApplicationUser>()
                .HasOne(f => f.BloodGroup)
                .WithMany()
                .HasForeignKey(f => f.BloodGroupId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<SystemCode>()
                .HasOne(f => f.ModifiedBy)
                .WithMany()
                .HasForeignKey(f => f.ModifiedById)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<SystemCodeDetail>()
                .HasOne(f => f.ModifiedBy)
                .WithMany()
                .HasForeignKey(f => f.ModifiedById)
                .OnDelete(DeleteBehavior.Restrict);

            builder.Entity<SystemCodeDetail>()
                .HasOne(f => f.SystemCode)
                .WithMany()
                .HasForeignKey(f => f.SystemCodeId)
                .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
