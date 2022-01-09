using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EmployeeManagement.Models
{
    public static class ModelBuilderExtensions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>().HasData(
                new Employee
                {
                    Id = 3,
                    Name = "mary",
                    Department = dept.IT,
                    Email = "mary@gmail.com"
                },
                new Employee
                {
                    Id = 5,
                    Name = "John",
                    Department = dept.Payroll,
                    Email = "John@gmail.com"
                }
                );
        }
    }
}
