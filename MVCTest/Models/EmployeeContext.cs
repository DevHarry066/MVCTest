using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCTest.Models
{
    public class EmployeeContext:DbContext
    {
        public EmployeeContext() : base("name=EmployeeDBConnectionString")
        {

        }
        public DbSet<Employee> Employees { get; set; }



    }
}