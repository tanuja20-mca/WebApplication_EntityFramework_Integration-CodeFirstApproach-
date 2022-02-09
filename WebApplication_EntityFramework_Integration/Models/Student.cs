using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WebApplication_EntityFramework_Integration.Models
{
    public class Student
    {
        [Key]
        public int ID { get; set; }
         public string Name { get; set; }
        public string Course { get; set; }
        public double Fee { get; set; }
    }
}