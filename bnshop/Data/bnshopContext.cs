using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using bnshop.Models;

namespace bnshop.Data
{
    public class bnshopContext : DbContext
    {
        public bnshopContext (DbContextOptions<bnshopContext> options)
            : base(options)
        {
        }

        public DbSet<bnshop.Models.Product> Product { get; set; } = default!;
    }
}
