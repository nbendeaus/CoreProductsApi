using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace CoreProductsApi.Models
{
    public class PrjContext : DbContext
    {
        public PrjContext (DbContextOptions<PrjContext> options)
            : base(options)
        {
        }

        public DbSet<CoreProductsApi.Models.Product> Product { get; set; }
    }
}
