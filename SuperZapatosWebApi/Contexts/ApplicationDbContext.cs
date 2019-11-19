using JetBrains.Annotations;
using Microsoft.EntityFrameworkCore;
using SuperZapatosWebApi.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SuperZapatosWebApi.Contexts
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
        }

        public DbSet<Article> Articles { get; set; }
        public DbSet<Store> Stores { get; set; }
    }
}
