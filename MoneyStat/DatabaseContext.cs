namespace MoneyStat
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class DatabaseContext : DbContext
    {        
        public DatabaseContext()
            : base("name=DatabaseContext")
        {
        }

    }

}