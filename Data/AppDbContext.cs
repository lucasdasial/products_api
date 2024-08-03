using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using products_api.Models;

namespace products_api.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext (DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }


        public DbSet<Product> Product { get; set; }
        public DbSet<Category> Category { get; set; }
    }
}
