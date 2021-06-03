using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCTest.Models
{
    public class Employee
    {
        [Key]
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public DateTime DateOfJoining { get; set; }
        public double Salary { get; set; }
        public string DepartmentName { get; set; }

    }
}