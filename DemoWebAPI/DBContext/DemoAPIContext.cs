using DemoWebAPI.Model;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace DemoWebAPI.DBContext
{
    public class DemoAPIContext : DbContext
    {
        public DemoAPIContext(DbContextOptions options) : base(options) { }
        DbSet<Student> Student{
            get;
            set;
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer(ConfigurationManager.ConnectionStrings["ConStr"].ConnectionString);
        //}

    }
}
