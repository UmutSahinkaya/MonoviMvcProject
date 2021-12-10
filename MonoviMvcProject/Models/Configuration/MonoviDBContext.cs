using MonoviMvcProject.Models.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MonoviMvcProject.Models.Configuration
{
    public class MonoviDBContext:DbContext
    {

        public MonoviDBContext() : base("EmpDBContext") { }

        public DbSet<Employee> Employees { get; set; }

    }

}