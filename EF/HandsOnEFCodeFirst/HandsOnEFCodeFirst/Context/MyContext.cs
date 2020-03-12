using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using HandsOnEFCodeFirst.Models;
namespace HandsOnEFCodeFirst.Context
{
    class MyContext:DbContext
    {
        //Define entities
        public DbSet<Student> Students { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Define connection string
            optionsBuilder.UseSqlServer(@"Data Source=DESKTOP-G33N13I\SQLEXPRESS;
Initial Catalog=StudentDB;User ID=sa;Password=pass@word1");
        }
    }
}
