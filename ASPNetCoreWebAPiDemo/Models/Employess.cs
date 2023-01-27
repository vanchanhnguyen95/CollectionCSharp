using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNetCoreWebAPiDemo.Models
{
    public class Employees
    {
        [Key]
        public int EmployeeId { get; set; }
        public string EmployeeFirstName { get; set; }
        public string EmployeeLastName { get; set; }
        public decimal Salary { get; set; }
        public string Designation { get; set; } 
    }
}
