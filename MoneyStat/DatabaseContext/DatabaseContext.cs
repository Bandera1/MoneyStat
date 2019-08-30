namespace MoneyStat
{
    using MoneyStat.EnititiesClasses;
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class DatabaseContext : DbContext
    {        
        public DatabaseContext() : base("name=DatabaseContext")
        {
        }

        public DbSet<ProfitsAndSpendings> ProfitsAndSpendings { get; set; }
        public DbSet<Categories> Categories { get; set; }
        public DbSet<Types> Types { get; set; }
    }

}