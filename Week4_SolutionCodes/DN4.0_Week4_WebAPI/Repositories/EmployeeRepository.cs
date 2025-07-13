using DN4._0_Week4_WebAPI.Models;
using System.Xml.Linq;

namespace DN4._0_Week4_WebAPI.Repositories
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly List<Employee> _employees;
        public EmployeeRepository()
        {
            // Initialize with some sample data
            _employees = new List<Employee>
            {
                new Employee
                {
                    Id = 1,
                    Name = "John Doe",
                    Salary = 50000,
                    Permanent = true,
                    Department = new Department { Id = 1, Name = "IT" },
                    Skills = new List<Skill>
                    {
                        new Skill { Id = 1, Name = "C#" },
                        new Skill { Id = 2, Name = "ASP.NET Core" }
                    },
                    DateOfBirth = new DateTime(1990, 1, 1)
                },
                new Employee
                {
                    Id = 2,
                    Name = "Jane Smith",
                    Salary = 60000,
                    Permanent = false,
                    Department = new Department { Id = 2, Name = "HR" },
                    Skills = new List<Skill>
                    {
                        new Skill { Id = 3, Name = "Recruitment" },
                        new Skill { Id = 4, Name = "Employee Relations" }
                    },
                    DateOfBirth = new DateTime(1985, 5, 15)
                }
            };
        }
        public IEnumerable<Employee> GetAll()
        {
            return _employees;
        }
        public Employee? GetById(int id)
        {
            return _employees.FirstOrDefault(e => e.Id == id);
        }
        public void Add(Employee employee)
        {
            employee.Id = _employees.Max(e => e.Id) + 1;
            _employees.Add(employee);
        }
        public void Update(Employee employee)
        {
            var existingEmployee = GetById(employee.Id);
            if (existingEmployee != null)
            {
                existingEmployee.Name = employee.Name;
                existingEmployee.Salary = employee.Salary;
                existingEmployee.Permanent = employee.Permanent;
                existingEmployee.Department = employee.Department;
                existingEmployee.Skills = employee.Skills;
                existingEmployee.DateOfBirth = employee.DateOfBirth;
            }
        }
        public void Delete(int id)
        {
            var employee = GetById(id);
            if (employee != null)
            {
                _employees.Remove(employee);
            }
        }
        public bool Exists(int id)
        {
            return _employees.Any(e => e.Id == id);
        }
    }
}
