using DAL.Model;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Bll
{
   public class CoreContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=.;database=TestDB;uid=sa;pwd=123456789;");
        }

        public DbSet<Test1> test1s { get; set; }
    }
}
