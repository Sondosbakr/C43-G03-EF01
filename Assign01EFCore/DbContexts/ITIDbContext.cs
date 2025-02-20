using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assign01EFCore.Models;
using Microsoft.EntityFrameworkCore;

namespace Assign01EFCore.DbContexts
{
    internal class ITIDbContext : DbContext
    {
        public ITIDbContext():base()
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server = .; Database = ITIDb; Trusted_Connection = true; Trusted_Connection = true; TrustServerCertificate=True");
        }

        DbSet<Student> Students { get; set; }
        public DbSet<Course> Courses { get; set; }

    }
}
