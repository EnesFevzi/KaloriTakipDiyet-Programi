using KaloriTakipProgramı.Data.Extensions;
using KaloriTakipProgramı.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KaloriTakipProgramı.Data.Context
{
	public class AppDbContext:DbContext
	{
		public DbSet<AppUser> AppUsers { get; set; }
		public DbSet<Food> Foods { get; set; }
		public DbSet<Meal> Meals { get; set; }
		public DbSet<MealOfDay> MealOfDays { get; set; }
		public DbSet<Water> Waters { get; set; }
		public DbSet<AppRole> AppRoles { get; set; }



		protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		{
			optionsBuilder.UseSqlServer("server=(localdb)\\MSSQLLocalDB;database=DietDB;integrated security=true");
		}

		protected override void OnModelCreating(ModelBuilder modelBuilder)
		{
			modelBuilder.Entity<AppRole>().HasData(
				new AppRole()
				{
					RoleID = 1,
					RoleName = "Admin",

				});
			modelBuilder.SeedData();
			base.OnModelCreating(modelBuilder);
		}
	}
}
