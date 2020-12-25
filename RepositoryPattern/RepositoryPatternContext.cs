using Microsoft.EntityFrameworkCore;
using RepositoryPattern.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RepositoryPattern
{
    public class RepositoryPatternContext : DbContext
    {
        public RepositoryPatternContext(DbContextOptions<RepositoryPatternContext> options) : base(options)
        {
        }

        public DbSet<User> Users { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

        }
    }
}
