using System;
using AnilDuzTest2.Entities;
using AnilTest.Entities;
using Microsoft.EntityFrameworkCore;

namespace AnilDuzTest2
{
    public class AppDbContext : DbContext
    {
        public DbSet<User> User { get; set; }
        public DbSet<Book> Book { get; set; }



        public AppDbContext() : base()
        {
            ChangeTracker.LazyLoadingEnabled = false;
            ChangeTracker.QueryTrackingBehavior = QueryTrackingBehavior.NoTracking;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=213.238.168.71;Initial Catalog=sudobell_;User ID=admin;Password=1qaz2wsxCV!!");
            optionsBuilder.UseQueryTrackingBehavior(QueryTrackingBehavior.NoTracking);
        }
    }
}
