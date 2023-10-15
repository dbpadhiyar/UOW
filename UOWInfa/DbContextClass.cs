using Microsoft.EntityFrameworkCore;
using ModelUOW;
using System.Collections.Generic;

namespace UOWInfa
{
    public class DbContextClass : DbContext
    {
        public DbContextClass(DbContextOptions<DbContextClass> contextOptions) : base(contextOptions)
        {
        }

        public DbSet<ProductDetails> Products { get; set; }
    }
}
