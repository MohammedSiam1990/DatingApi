using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DatingApi.Models;

namespace DatingApi.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)

        {

        }

        public DbSet<Value> Values { set; get; }

        public DbSet<User> Users { set; get; }

        public DbSet<Photo> Photos { get; set; }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    //optionsBuilder.UseSqlServer(@"Server=.\DESKTOP-C84B5Q4;Database=DatingApp;Trusted_Connection=True;");
        //    //optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb; Database=DatingApp; Trusted_Connection=True;");
        //    optionsBuilder.UseSqlServer("Server=(localdb)\\mssqllocaldb; Database=DatingAppDb; Trusted_Connection=True;");
        //}
    }
}
