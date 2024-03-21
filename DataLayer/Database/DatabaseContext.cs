using DataLayer.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Database
{
    public class DatabaseContext : DbContext
    {
        public DbSet<DatabaseUser> Users { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string solutionFolder = Path.GetFullPath(@"..\..\..\..\");
            string databaseFolder = Path.Combine(solutionFolder, "databases");

            if (!Directory.Exists(databaseFolder))
            {
                Directory.CreateDirectory(databaseFolder);
            }

            string databasePath = Path.Combine(databaseFolder, "Welcome.db");
            optionsBuilder.UseSqlite($"Data Source={databasePath}");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DatabaseUser>().Property(e => e.Id).ValueGeneratedOnAdd();

            var user = new DatabaseUser()
            {
                Id = 1,
                Name = "John Doe",
                Password = "1234",
                Role = Welcome.Others.UserRolesEnum.ADMIN,
                Expired = DateTime.Now.AddYears(10),
                Email = "",
                FacultyNumber = ""
            };



            modelBuilder.Entity<DatabaseUser>()
                .HasData(user);

            modelBuilder.Entity<DatabaseUser>()
                .HasData(
                new DatabaseUser()
                {
                    Id = 2,
                    Name = "Alice",
                    Password = "123",
                    Role = Welcome.Others.UserRolesEnum.STUDENT,
                    Expired = DateTime.Now.AddYears(5),
                    Email = "",
                    FacultyNumber = ""
                });

            modelBuilder.Entity<DatabaseUser>()
                .HasData(
                new DatabaseUser()
                {
                    Id = 3,
                    Name = "Bob",
                    Password = "123",
                    Role = Welcome.Others.UserRolesEnum.INSPECTOR,
                    Expired = DateTime.Now.AddYears(5),
                    Email = "",
                    FacultyNumber = ""
                });
        }
    }
}
