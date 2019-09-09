using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using JobWebsite.Models;
using JobWebsite.Models.Job;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

namespace JobWebsite.Data
{
    public class DataSeeder
    {
        private ApplicationDbContext _context;
        private readonly UserManager<ApplicationUser> _userManager;
        private IServiceProvider _services;

        public DataSeeder(ApplicationDbContext context, UserManager<ApplicationUser> userManager, IServiceProvider services)
        {
            _context = context;
            _userManager = userManager;
            _services = services;
        }

        public async void EnsureSeedData()
        {
            // Create me some users:
            if (!_userManager.Users.Any())
            {
                // Create roles
                using (var roleManager = _services.GetRequiredService<RoleManager<IdentityRole>>())
                {
                    string[] roleNames = { "Job Seeker", "Recruiter" };
                    IdentityResult roleResult;
                    foreach (var roleName in roleNames)
                    {
                        if (await roleManager.RoleExistsAsync(roleName) == false)
                        {
                            roleResult = await roleManager.CreateAsync(new IdentityRole(roleName));
                        }
                    }
                }

                
                await _context.UserTypes.AddRangeAsync( new List<UserType>
                {
                    new UserType{ Description = "Job Seeker", Active = true },
                    new UserType{ Description = "Recruiter", Active = true }
                });
                await _context.SaveChangesAsync();

                var user = new ApplicationUser { 
                    UserName = "marcus_stockton@hotmail.co.uk", 
                    Email = "marcus_stockton@hotmail.co.uk", 
                    LockoutEnabled = false, 
                    FirstName = "Marcus", 
                    LastName = "Stockton", 
                    DateOfBirth = new DateTime(1982, 6, 26),
                    UserType = _context.UserTypes.FirstOrDefault()
                };
                _userManager.CreateAsync(user, "P@ssword1").Wait();
                _userManager.AddToRoleAsync(user, "Recruiter").Wait();

                var user2 = new ApplicationUser { 
                    UserName = "test@hotmail.co.uk", 
                    Email = "test@hotmail.co.uk", 
                    LockoutEnabled = false, 
                    FirstName = "Test", 
                    LastName = "Stockton", 
                    DateOfBirth = new DateTime(1985, 2, 12), 
                    UserType = _context.UserTypes.LastOrDefault() 
                };
                _userManager.CreateAsync(user2, "P@ssword1").Wait();
                _userManager.AddToRoleAsync(user2, "Job Seeker").Wait();
            }

            // Create me some Job Categories:
            if (!_context.JobCategories.Any())
            {
                await _context.JobCategories.AddRangeAsync(new List<JobCategory>{
                    new JobCategory{Description = "IT", Active = true},
                    new JobCategory{Description = "Sales", Active = true},
                    new JobCategory{Description = "Web Developer", Active = true},
                    new JobCategory{Description = "Software Developer", Active = true},
                    new JobCategory{Description = "Hairdresser", Active = true}
                });
            }

            // Create me some job types:
            if (!_context.JobTypes.Any())
            {
                await _context.JobTypes.AddRangeAsync(new List<JobType>{
                    new JobType{Description = "Perm", Active = true},
                    new JobType{Description = "Temp", Active = true},
                    new JobType{Description = "Contract", Active = true}
                });
            }

            // Create me some job posistions:
            if (!_context.JobPosistions.Any())
            {
                await _context.JobPosistions.AddRangeAsync(new List<JobPosistion>{
                    new JobPosistion{Description = "FullTime", Active = true},
                    new JobPosistion{Description = "PartTime", Active = true},
                });
            }

            // Create me some job key skills:
            if (!_context.JobKeySkills.Any())
            {
                await _context.JobKeySkills.AddRangeAsync(new List<JobKeySkill>{
                    new JobKeySkill{Description = "Communications skills", Active = true},
                    new JobKeySkill{Description = "Teamwork", Active = true},
                    new JobKeySkill{Description = "Problem-solving skills", Active = true},
                });
            }

            // Create me some job benefits:
            if (!_context.JobBenefits.Any())
            {
                await _context.JobBenefits.AddRangeAsync(new List<JobBenefit>{
                    new JobBenefit{Description = "Cycle to work scheme", Active = true},
                    new JobBenefit{Description = "Gym Membership", Active = true},
                    new JobBenefit{Description = "Pension", Active = true},
                });
            }
            await _context.SaveChangesAsync();
            // Create me some jobs:
            if (!_context.Jobs.Any())
            {
                await _context.Jobs.AddRangeAsync(new List<Job>{
                    new Job{Active = true, IsDraft = false, MinSalary = 16200, MaxSalary = 17000, Title="Warehouse Operative", Description="As a warehouse operative you will be working both alone and as part of a team with efficiency and commitment to complete your work and strive to maintain the business performance targets." +
                        "This role best suits upbeat and self-motivated individuals who enjoy working systematically and productively. The fast paced and energised environment relies on organisation and efficiency and with so much ground to cover in the line of duty it is important to ensure that you have a moderate level of fitness to enable you to comfortably carry out your tasks. " +
                        "Picking and packing products can involve a substantial amount of manual handling including bending, stretching, stooping, stepping, reaching and lifting. Having a good range of mobility is important to ensure you can work safely within health and safety regulations without placing undue strain on your body." +
                        "Warehouses are usually located on the outskirts of cities, towns and villages and are positioned on large industrial landscapes with good access to main roads for the ease of goods transportation. Due to their location, warehouses are not always located on or near a bus route so travel to work may need some prior planning if you do not have a car.", JobCategory=_context.JobCategories.FirstOrDefault(), JobPosistion = _context.JobPosistions.FirstOrDefault(), PublishDate = DateTime.Now, JobType = _context.JobTypes.FirstOrDefault(),ClosingDate = DateTime.Now.AddMonths(1)},
                    new Job{Active = true, IsDraft = false, MinSalary = 25000, MaxSalary = 32000, Title="Software Developer", Description="As a software engineer, you'll work in a constantly evolving environment, due to technological advances and the strategic direction of their organisation. You'll create, maintain, audit and improve systems to meet particular needs, often as advised by a systems analyst or architect, testing both hard and software systems to diagnose and resolve system faults. " + 
                        "The role also covers writing diagnostic programs and designing and writing code for operating systems and software to ensure efficiency. When required, you'll make recommendations for future developments." + 
                        "Job titles and descriptions in IT are not standardised. Instead of a software engineer, you may be called a systems/software/database/web programmer, engineer or developer, depending on the system you're developing. Alternatively, the programming language you use may become part of your title, such as Java or C# developer. The work of a software engineer can also form part of a multimedia programmer role." +
                        "Depending on the organisation you work for, you may have a more defined role and work within a group of IT specialists which can include systems analysts, systems designers and systems testers. Nevertheless, as software engineers often manage the support systems required to effectively run an organisation, the role can also require you to communicate effectively and translate the needs of different teams into systems developments.", JobCategory=_context.JobCategories.LastOrDefault(), JobPosistion = _context.JobPosistions.LastOrDefault(), PublishDate = DateTime.Now.AddHours(-1), JobType = _context.JobTypes.LastOrDefault(),ClosingDate = DateTime.Now.AddMonths(1)},
                });
            }


        }

    }
}
