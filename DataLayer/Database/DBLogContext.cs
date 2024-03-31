using DataLayer.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Database
{
    public class DBLogContext : DbContext
    {
        public DbSet<DBLog> DBLogs { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string solutionFolder = Path.GetFullPath(@"..\..\..\..\");
            string databaseFolder = Path.Combine(solutionFolder, "databases");

            if (!Directory.Exists(databaseFolder))
            {
                Directory.CreateDirectory(databaseFolder);
            }

            string databasePath = Path.Combine(databaseFolder, "WelcomeLog.db");
            optionsBuilder.UseSqlite($"Data Source={databasePath}");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<DBLog>().Property(e => e.Id).ValueGeneratedOnAdd();
        }
    }
}
