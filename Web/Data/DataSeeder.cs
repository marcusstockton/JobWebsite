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

            }


        }

    }
}
