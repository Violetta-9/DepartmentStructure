using DepartmentStructure.Data.Domain.Modals;
using Microsoft.EntityFrameworkCore;

namespace DepartmentStructure.Data.Shared
{
    public class DepartmentStructureDbContext:DbContext
    {
        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DepartmentStructureDbContext(DbContextOptions options) : base(options) { }
    }
}