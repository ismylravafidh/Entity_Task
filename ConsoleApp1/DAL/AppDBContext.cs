using ConsoleApp1.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1.DAL
{
    internal class AppDBContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            optionsBuilder.UseSqlServer("server=ISMAYIL;database=TaskEntitiysFW;Trusted_Connection=true;Integrated Security=true;Encrypt=false");
        }
        public DbSet<Group> Groups { get; set; }
        public DbSet<Student> Students { get; set; }


    }
}
