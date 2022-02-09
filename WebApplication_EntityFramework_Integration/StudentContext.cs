using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WebApplication_EntityFramework_Integration.Models;

namespace WebApplication_EntityFramework_Integration
{
    public class StudentContext : DbContext
    {
        

        public StudentContext():base("name= schoolDbConnectionString")
        {

        }

        public DbSet<Student> students { get; set; }
    }
}