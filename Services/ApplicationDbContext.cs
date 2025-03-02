using EmployeeManagmentSystem.Models;
using Microsoft.EntityFrameworkCore;

namespace EmployeeManagmentSystem.Services
{
    public class ApplicationDbContext
    {


        public class AppDbContext : DbContext
        {
            public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) 
            { 
            }
            public DbSet<Employee> Employees { get; set; }

        }
    }
}
