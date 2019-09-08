using System;
using System.Collections.Generic;
using System.Text;
using JobWebsite.Models;
using JobWebsite.Models.Job;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace JobWebsite.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser>
    {
        public DbSet<Job> Jobs { get; set; }
        public DbSet<JobType> JobTypes { get; set; }
        public DbSet<JobCategory> JobCategories { get; set; }
        public DbSet<JobBenefit> JobBenefits { get; set; }
        public DbSet<JobPosistion> JobPosistions { get; set; }
        public DbSet<JobKeySkill> JobKeySkills { get; set; }
        public DbSet<UserType> UserTypes { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<ApplicationUser>()
            .HasOne(b => b.UserType);

            modelBuilder.Entity<UserType>()
                .Property(b => b.CreatedDate)
                .HasDefaultValue(DateTime.Now);
            modelBuilder.Entity<UserType>()
                .HasOne(x=>x.CreatedBy);
            modelBuilder.Entity<UserType>()
                .HasOne(x=>x.UpdatedBy);

            modelBuilder.Entity<Job>()
                .Property(b => b.CreatedDate)
                .HasDefaultValue(DateTime.Now);

            modelBuilder.Entity<JobType>()
                .Property(b => b.CreatedDate)
                .HasDefaultValue(DateTime.Now);

            modelBuilder.Entity<JobBenefit>()
                .Property(b => b.CreatedDate)
                .HasDefaultValue(DateTime.Now);

            modelBuilder.Entity<JobCategory>()
                .Property(b => b.CreatedDate)
                .HasDefaultValue(DateTime.Now);

            modelBuilder.Entity<JobKeySkill>()
                .Property(b => b.CreatedDate)
                .HasDefaultValue(DateTime.Now);

            modelBuilder.Entity<JobPosistion>()
                .Property(b => b.CreatedDate)
                .HasDefaultValue(DateTime.Now);

            modelBuilder.Entity<UserType>()
                .Property(b => b.CreatedDate)
                .HasDefaultValue(DateTime.Now);
                
            modelBuilder.Entity<JobBenefitJob>().HasKey(sc => new { sc.JobId, sc.JobBenefitId });
            modelBuilder.Entity<JobBenefitJob>()
                .HasOne(pt => pt.Job)
                .WithMany(p => p.JobBenefitJob)
                .HasForeignKey(pt => pt.JobId);
            modelBuilder.Entity<JobBenefitJob>()
                .HasOne(pt => pt.JobBenefit)
                .WithMany(t => t.JobBenefitJob)
                .HasForeignKey(pt => pt.JobBenefitId);


            modelBuilder.Entity<JobKeySkillsJob>().HasKey(sc => new { sc.JobId, sc.JobKeySkillId });
            modelBuilder.Entity<JobKeySkillsJob>()
                .HasOne(pt => pt.Job)
                .WithMany(p => p.JobKeySkillsJob)
                .HasForeignKey(pt => pt.JobId);
            modelBuilder.Entity<JobKeySkillsJob>()
                .HasOne(pt => pt.JobKeySkill)
                .WithMany(t => t.JobKeySkillsJob)
                .HasForeignKey(pt => pt.JobKeySkillId);
        }
    }
}
