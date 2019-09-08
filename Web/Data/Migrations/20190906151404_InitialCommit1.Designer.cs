﻿// <auto-generated />
using System;
using JobWebsite.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace JobWebsite.Data.Migrations
{
    [DbContext(typeof(ApplicationDbContext))]
    [Migration("20190906151404_InitialCommit1")]
    partial class InitialCommit1
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "2.2.6-servicing-10079");

            modelBuilder.Entity("JobWebsite.Models.ApplicationUser", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<int>("AccessFailedCount");

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<DateTime?>("DateOfBirth");

                    b.Property<string>("Email")
                        .HasMaxLength(256);

                    b.Property<bool>("EmailConfirmed");

                    b.Property<string>("FirstName");

                    b.Property<string>("LastName");

                    b.Property<bool>("LockoutEnabled");

                    b.Property<DateTimeOffset?>("LockoutEnd");

                    b.Property<string>("NormalizedEmail")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedUserName")
                        .HasMaxLength(256);

                    b.Property<string>("PasswordHash");

                    b.Property<string>("PhoneNumber");

                    b.Property<bool>("PhoneNumberConfirmed");

                    b.Property<string>("SecurityStamp");

                    b.Property<bool>("TwoFactorEnabled");

                    b.Property<string>("UserName")
                        .HasMaxLength(256);

                    b.Property<int?>("UserTypeId");

                    b.HasKey("Id");

                    b.HasIndex("NormalizedEmail")
                        .HasName("EmailIndex");

                    b.HasIndex("NormalizedUserName")
                        .IsUnique()
                        .HasName("UserNameIndex");

                    b.HasIndex("UserTypeId");

                    b.ToTable("AspNetUsers");
                });

            modelBuilder.Entity("JobWebsite.Models.Job.Job", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Active");

                    b.Property<DateTime>("ClosingDate");

                    b.Property<string>("CreatedById");

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(new DateTime(2019, 9, 6, 16, 14, 4, 807, DateTimeKind.Local).AddTicks(7323));

                    b.Property<string>("Description");

                    b.Property<bool>("IsDraft");

                    b.Property<int?>("JobCategoryId");

                    b.Property<int?>("JobPosistionId");

                    b.Property<int?>("JobTypeId");

                    b.Property<int>("MaxSalary");

                    b.Property<int>("MinSalary");

                    b.Property<DateTime>("PublishDate");

                    b.Property<string>("Title");

                    b.Property<string>("UpdatedById");

                    b.Property<DateTime?>("UpdatedDate");

                    b.HasKey("Id");

                    b.HasIndex("CreatedById");

                    b.HasIndex("JobCategoryId");

                    b.HasIndex("JobPosistionId");

                    b.HasIndex("JobTypeId");

                    b.HasIndex("UpdatedById");

                    b.ToTable("Jobs");
                });

            modelBuilder.Entity("JobWebsite.Models.Job.JobBenefit", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Active");

                    b.Property<string>("CreatedById");

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(new DateTime(2019, 9, 6, 16, 14, 4, 808, DateTimeKind.Local).AddTicks(1697));

                    b.Property<string>("Description");

                    b.Property<string>("UpdatedById");

                    b.Property<DateTime?>("UpdatedDate");

                    b.HasKey("Id");

                    b.HasIndex("CreatedById");

                    b.HasIndex("UpdatedById");

                    b.ToTable("JobBenefits");
                });

            modelBuilder.Entity("JobWebsite.Models.Job.JobBenefitJob", b =>
                {
                    b.Property<int>("JobId");

                    b.Property<int>("JobBenefitId");

                    b.HasKey("JobId", "JobBenefitId");

                    b.HasIndex("JobBenefitId");

                    b.ToTable("JobBenefitJob");
                });

            modelBuilder.Entity("JobWebsite.Models.Job.JobCategory", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Active");

                    b.Property<string>("CreatedById");

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(new DateTime(2019, 9, 6, 16, 14, 4, 808, DateTimeKind.Local).AddTicks(3596));

                    b.Property<string>("Description");

                    b.Property<string>("UpdatedById");

                    b.Property<DateTime?>("UpdatedDate");

                    b.HasKey("Id");

                    b.HasIndex("CreatedById");

                    b.HasIndex("UpdatedById");

                    b.ToTable("JobCategories");
                });

            modelBuilder.Entity("JobWebsite.Models.Job.JobKeySkill", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Active");

                    b.Property<string>("CreatedById");

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(new DateTime(2019, 9, 6, 16, 14, 4, 808, DateTimeKind.Local).AddTicks(5532));

                    b.Property<string>("Description");

                    b.Property<string>("UpdatedById");

                    b.Property<DateTime?>("UpdatedDate");

                    b.HasKey("Id");

                    b.HasIndex("CreatedById");

                    b.HasIndex("UpdatedById");

                    b.ToTable("JobKeySkills");
                });

            modelBuilder.Entity("JobWebsite.Models.Job.JobKeySkillsJob", b =>
                {
                    b.Property<int>("JobId");

                    b.Property<int>("JobKeySkillId");

                    b.HasKey("JobId", "JobKeySkillId");

                    b.HasIndex("JobKeySkillId");

                    b.ToTable("JobKeySkillsJob");
                });

            modelBuilder.Entity("JobWebsite.Models.Job.JobPosistion", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Active");

                    b.Property<string>("CreatedById");

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(new DateTime(2019, 9, 6, 16, 14, 4, 808, DateTimeKind.Local).AddTicks(7342));

                    b.Property<string>("Description");

                    b.Property<string>("UpdatedById");

                    b.Property<DateTime?>("UpdatedDate");

                    b.HasKey("Id");

                    b.HasIndex("CreatedById");

                    b.HasIndex("UpdatedById");

                    b.ToTable("JobPosistions");
                });

            modelBuilder.Entity("JobWebsite.Models.Job.JobType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Active");

                    b.Property<string>("CreatedById");

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(new DateTime(2019, 9, 6, 16, 14, 4, 807, DateTimeKind.Local).AddTicks(9774));

                    b.Property<string>("Description");

                    b.Property<string>("UpdatedById");

                    b.Property<DateTime?>("UpdatedDate");

                    b.HasKey("Id");

                    b.HasIndex("CreatedById");

                    b.HasIndex("UpdatedById");

                    b.ToTable("JobTypes");
                });

            modelBuilder.Entity("JobWebsite.Models.UserType", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<bool>("Active");

                    b.Property<string>("CreatedById");

                    b.Property<DateTime>("CreatedDate")
                        .ValueGeneratedOnAdd()
                        .HasDefaultValue(new DateTime(2019, 9, 6, 16, 14, 4, 808, DateTimeKind.Local).AddTicks(7824));

                    b.Property<string>("Description");

                    b.Property<string>("UpdatedById");

                    b.Property<DateTime?>("UpdatedDate");

                    b.HasKey("Id");

                    b.HasIndex("CreatedById");

                    b.HasIndex("UpdatedById");

                    b.ToTable("UserTypes");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRole", b =>
                {
                    b.Property<string>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ConcurrencyStamp")
                        .IsConcurrencyToken();

                    b.Property<string>("Name")
                        .HasMaxLength(256);

                    b.Property<string>("NormalizedName")
                        .HasMaxLength(256);

                    b.HasKey("Id");

                    b.HasIndex("NormalizedName")
                        .IsUnique()
                        .HasName("RoleNameIndex");

                    b.ToTable("AspNetRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("RoleId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetRoleClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("ClaimType");

                    b.Property<string>("ClaimValue");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserClaims");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderKey")
                        .HasMaxLength(128);

                    b.Property<string>("ProviderDisplayName");

                    b.Property<string>("UserId")
                        .IsRequired();

                    b.HasKey("LoginProvider", "ProviderKey");

                    b.HasIndex("UserId");

                    b.ToTable("AspNetUserLogins");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("RoleId");

                    b.HasKey("UserId", "RoleId");

                    b.HasIndex("RoleId");

                    b.ToTable("AspNetUserRoles");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.Property<string>("UserId");

                    b.Property<string>("LoginProvider")
                        .HasMaxLength(128);

                    b.Property<string>("Name")
                        .HasMaxLength(128);

                    b.Property<string>("Value");

                    b.HasKey("UserId", "LoginProvider", "Name");

                    b.ToTable("AspNetUserTokens");
                });

            modelBuilder.Entity("JobWebsite.Models.ApplicationUser", b =>
                {
                    b.HasOne("JobWebsite.Models.UserType", "UserType")
                        .WithMany()
                        .HasForeignKey("UserTypeId");
                });

            modelBuilder.Entity("JobWebsite.Models.Job.Job", b =>
                {
                    b.HasOne("JobWebsite.Models.ApplicationUser", "CreatedBy")
                        .WithMany()
                        .HasForeignKey("CreatedById");

                    b.HasOne("JobWebsite.Models.Job.JobCategory", "JobCategory")
                        .WithMany()
                        .HasForeignKey("JobCategoryId");

                    b.HasOne("JobWebsite.Models.Job.JobPosistion", "JobPosistion")
                        .WithMany()
                        .HasForeignKey("JobPosistionId");

                    b.HasOne("JobWebsite.Models.Job.JobType", "JobType")
                        .WithMany()
                        .HasForeignKey("JobTypeId");

                    b.HasOne("JobWebsite.Models.ApplicationUser", "UpdatedBy")
                        .WithMany()
                        .HasForeignKey("UpdatedById");
                });

            modelBuilder.Entity("JobWebsite.Models.Job.JobBenefit", b =>
                {
                    b.HasOne("JobWebsite.Models.ApplicationUser", "CreatedBy")
                        .WithMany()
                        .HasForeignKey("CreatedById");

                    b.HasOne("JobWebsite.Models.ApplicationUser", "UpdatedBy")
                        .WithMany()
                        .HasForeignKey("UpdatedById");
                });

            modelBuilder.Entity("JobWebsite.Models.Job.JobBenefitJob", b =>
                {
                    b.HasOne("JobWebsite.Models.Job.JobBenefit", "JobBenefit")
                        .WithMany("JobBenefitJob")
                        .HasForeignKey("JobBenefitId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("JobWebsite.Models.Job.Job", "Job")
                        .WithMany("JobBenefitJob")
                        .HasForeignKey("JobId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("JobWebsite.Models.Job.JobCategory", b =>
                {
                    b.HasOne("JobWebsite.Models.ApplicationUser", "CreatedBy")
                        .WithMany()
                        .HasForeignKey("CreatedById");

                    b.HasOne("JobWebsite.Models.ApplicationUser", "UpdatedBy")
                        .WithMany()
                        .HasForeignKey("UpdatedById");
                });

            modelBuilder.Entity("JobWebsite.Models.Job.JobKeySkill", b =>
                {
                    b.HasOne("JobWebsite.Models.ApplicationUser", "CreatedBy")
                        .WithMany()
                        .HasForeignKey("CreatedById");

                    b.HasOne("JobWebsite.Models.ApplicationUser", "UpdatedBy")
                        .WithMany()
                        .HasForeignKey("UpdatedById");
                });

            modelBuilder.Entity("JobWebsite.Models.Job.JobKeySkillsJob", b =>
                {
                    b.HasOne("JobWebsite.Models.Job.Job", "Job")
                        .WithMany("JobKeySkillsJob")
                        .HasForeignKey("JobId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("JobWebsite.Models.Job.JobKeySkill", "JobKeySkill")
                        .WithMany("JobKeySkillsJob")
                        .HasForeignKey("JobKeySkillId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("JobWebsite.Models.Job.JobPosistion", b =>
                {
                    b.HasOne("JobWebsite.Models.ApplicationUser", "CreatedBy")
                        .WithMany()
                        .HasForeignKey("CreatedById");

                    b.HasOne("JobWebsite.Models.ApplicationUser", "UpdatedBy")
                        .WithMany()
                        .HasForeignKey("UpdatedById");
                });

            modelBuilder.Entity("JobWebsite.Models.Job.JobType", b =>
                {
                    b.HasOne("JobWebsite.Models.ApplicationUser", "CreatedBy")
                        .WithMany()
                        .HasForeignKey("CreatedById");

                    b.HasOne("JobWebsite.Models.ApplicationUser", "UpdatedBy")
                        .WithMany()
                        .HasForeignKey("UpdatedById");
                });

            modelBuilder.Entity("JobWebsite.Models.UserType", b =>
                {
                    b.HasOne("JobWebsite.Models.ApplicationUser", "CreatedBy")
                        .WithMany()
                        .HasForeignKey("CreatedById");

                    b.HasOne("JobWebsite.Models.ApplicationUser", "UpdatedBy")
                        .WithMany()
                        .HasForeignKey("UpdatedById");
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityRoleClaim<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserClaim<string>", b =>
                {
                    b.HasOne("JobWebsite.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserLogin<string>", b =>
                {
                    b.HasOne("JobWebsite.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserRole<string>", b =>
                {
                    b.HasOne("Microsoft.AspNetCore.Identity.IdentityRole")
                        .WithMany()
                        .HasForeignKey("RoleId")
                        .OnDelete(DeleteBehavior.Cascade);

                    b.HasOne("JobWebsite.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });

            modelBuilder.Entity("Microsoft.AspNetCore.Identity.IdentityUserToken<string>", b =>
                {
                    b.HasOne("JobWebsite.Models.ApplicationUser")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade);
                });
#pragma warning restore 612, 618
        }
    }
}
