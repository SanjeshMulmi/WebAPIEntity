using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class EmployeeDBContext : DbContext
    {
        public EmployeeDBContext(DbContextOptions<EmployeeDBContext> options) : base(options)
        {

        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Employee> Department { get; set; }
    }
}
