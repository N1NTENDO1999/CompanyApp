using CompanyServer.Models;
using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CompanyServer.Infrastructure
{
    public class CompanyContext : DbContext
    {
        public DbSet<Issue> Issues { get; set; }
        public DbSet<Project> Projects { get; set; }
        public DbSet<TaskState> TaskStates { get; set; }
        public DbSet<Team> Teams{ get; set; }
        public DbSet<User> Users { get; set; }

        public CompanyContext(DbContextOptions<CompanyContext> options) 
            : base(options)
        {
        }
        public CompanyContext()
        {
            Database.EnsureCreated();
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

    }
}
