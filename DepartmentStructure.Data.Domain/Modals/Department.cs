

using System.ComponentModel.DataAnnotations.Schema;

namespace DepartmentStructure.Data.Domain.Modals
{
    public class Department
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public int? ParentDepartmentId { get; set; }
        public virtual ICollection<Employee> Employees { get;}
        [NotMapped]
        public int EmpQuentity { get; set; }
        [NotMapped]
        public List<Department> Departments=new List<Department>();

    }
}
