using DepartmentStructure.Data.Domain.Modals;
using DepartmentStructure.Data.Shared;
using Microsoft.EntityFrameworkCore;

namespace DepartmentStructure.Service
{
    public interface IDepartmentService
    {
        public List<Department> GetAllDepartmentsWithEmployee(int? roodDepartmentId);
        public bool AddQuentity(int id);
    }
    public class DepartmentService:IDepartmentService
    {
        private readonly DepartmentStructureDbContext _context;

        public DepartmentService(DepartmentStructureDbContext context)
        {
            _context=context;
        }

        public List<Department> GetAllDepartmentsWithEmployee(int? roodDepartmentId)
        {
            var structure = GoDownRecursive(null);
            return structure;
        }

        List<Department> GoDownRecursive(int? categoryId)
        {
            var query = _context.Departments.Include(x => x.Employees)
                .Where(d => d.ParentDepartmentId == categoryId)
                .ToList<Department>();

            var res = new List<Department>();

            foreach (var subDepartment in query)
            {

                res.Add(subDepartment);
                subDepartment.Departments.AddRange(GoDownRecursive(subDepartment.Id));
                if (subDepartment.Employees.Count == 0)
                {

                    subDepartment.EmpQuentity += subDepartment.Departments.Select(x => x.EmpQuentity).Sum();
                }
                else
                {
                    subDepartment.EmpQuentity = subDepartment.Employees.Count;
                }
            }


            return res;
        }

        public bool AddQuentity(int id)
        {
            if (_context.Departments.Any(x => x.Id == id))
            {
                var newEmployee = new Employee()
                {
                    Name = "Новый",
                    DepartmentId = id
                };

                _context.Employees.Add(newEmployee);
                _context.SaveChanges();
                return true;
            }
            
            return false;
        }
    }
}
