using Microsoft.EntityFrameworkCore;
using Abp.Zero.EntityFrameworkCore;
using FituationAPI.Authorization.Roles;
using FituationAPI.Authorization.Users;
using FituationAPI.MultiTenancy;
using FituationAPI.Domain;

namespace FituationAPI.EntityFrameworkCore
{
    public class FituationAPIDbContext : AbpZeroDbContext<Tenant, Role, User, FituationAPIDbContext>
    {
        /* Define a DbSet for each entity of the application */
        public DbSet<Person> People { get; set; }
        
        public DbSet<AppUser> AppUsers { get; set; }

        public DbSet<Admin> Admins { get; set; }
        public DbSet<Exercise> Exercises { get; set; }

        public DbSet<UserActivity> UserActivities { get; set; }

        public DbSet<UserFavourite> UserFavourites { get; set; }


        public FituationAPIDbContext(DbContextOptions<FituationAPIDbContext> options)
            : base(options)
        {
        }
    }
}
