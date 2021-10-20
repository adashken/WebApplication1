using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

    public class FlavorContext : DbContext
    {
        public FlavorContext (DbContextOptions<FlavorContext> options)
            : base(options)
        {
        }

        public DbSet<WebApplication1.Models.Flavor> Flavor { get; set; }
    }
