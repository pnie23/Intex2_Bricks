﻿using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;

namespace Intex2_Bricks.Models
{
    public class BricksContext : DbContext
    {
        public BricksContext(DbContextOptions<BricksContext> options) : base(options)
        {
            public DbSet<Product> Products { get; set; }
            public DbSet<Order> Orders { get; set; }
            public DbSet<LineItem> LineItems { get; set; }
            public DbSet<Customer> Customers { get; set; }
            public DbSet<Recommendation> Recommendations { get; set; }
        }
    }
}
