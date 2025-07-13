using DN4._0_Week4_WebAPI.Filters;
using DN4._0_Week4_WebAPI.Models;
using DN4._0_Week4_WebAPI.Repositories;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace DN4._0_Week4_WebAPI.Controllers
{
    [Route("Emp")]
    [ApiController]
    //[ServiceFilter(typeof(CustomAuthFilter))]
    [TypeFilter(typeof(CustomExceptionFilter))]
    //[Authorize]
    //[Authorize(Roles = "POC")]
    [Authorize(Roles = "Admin, POC")]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeRepository _repository;
        public EmployeeController(IEmployeeRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Employee>> GetAllEmployees()
        {
            var employees = _repository.GetAll();
            return Ok(employees);
        }

        [HttpGet("{id}")]
        public ActionResult<Employee> GetEmployeeById(int id)
        {
            var employee = _repository.GetById(id);
            if (employee == null)
            {
                return NotFound();
            }
            return Ok(employee);
        }

        [HttpPost]
        public ActionResult<Employee> CreateEmployee([FromBody] Employee employee)
        {
            if (!ModelState.IsValid)
            {
                return BadRequest(ModelState);
            }
            _repository.Add(employee);
            return CreatedAtAction(nameof(GetEmployeeById), new { id = employee.Id }, employee);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateEmployee(int id, [FromBody] Employee employee)
        {
            if (id <= 0)
            {
                return BadRequest("Invalid employee id");
            }

            if (!_repository.Exists(id))
            {
                return BadRequest("Invalid employee id");
            }
            _repository.Update(employee);
            return Ok(employee);
        }

        [HttpPatch("{id}")]
        public IActionResult PatchEmployee(int id, [FromBody] Employee employee)
        {
            var existingEmployee = _repository.GetById(id);
            if (existingEmployee == null)
            {
                return NotFound();
            }
            // For simplicity, updating all fields. In real scenarios, use JSON Patch.
            existingEmployee.Name = employee.Name ?? existingEmployee.Name;
            existingEmployee.Salary = employee.Salary != 0 ? employee.Salary : existingEmployee.Salary;
            existingEmployee.Permanent = employee.Permanent;
            existingEmployee.Department = employee.Department ?? existingEmployee.Department;
            existingEmployee.Skills = employee.Skills ?? existingEmployee.Skills;
            existingEmployee.DateOfBirth = employee.DateOfBirth != default ? employee.DateOfBirth : existingEmployee.DateOfBirth;
            
            _repository.Update(existingEmployee);
            return Ok(employee);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteEmployee(int id)
        {
            if (!_repository.Exists(id))
            {
                return NotFound();
            }
            _repository.Delete(id);
            return NoContent();
        }

        //private List<Employee> _employees;

        //public EmployeeController()
        //{
        //    _employees = GetStandardEmployeeList();
        //}
        //private List<Employee> GetStandardEmployeeList()
        //{
        //    return new List<Employee>
        //    {
        //        new Employee
        //        {
        //            Id = 1,
        //            Name = "John Doe",
        //            Salary = 50000,
        //            Permanent = true,
        //            Department = new Department { Id = 1, Name = "IT" },
        //            Skills = new List<Skill>
        //            {
        //                new Skill { Id = 1, Name = "C#" },
        //                new Skill { Id = 2, Name = "ASP.NET Core" }
        //            },
        //            DateOfBirth = new DateTime(1990, 1, 1)
        //        },
        //        new Employee
        //        {
        //            Id = 2,
        //            Name = "Jane Smith",
        //            Salary = 60000,
        //            Permanent = false,
        //            Department = new Department { Id = 2, Name = "HR" },
        //            Skills = new List<Skill>
        //            {
        //                new Skill { Id = 3, Name = "Recruitment" },
        //                new Skill { Id = 4, Name = "Employee Relations" }
        //            },
        //            DateOfBirth = new DateTime(1985, 5, 15)
        //        }
        //    };
        //}

        //[HttpGet("Standard")]
        //public ActionResult<Employee> GetStandard()
        //{
        //    return Ok(_employees.First());
        //}

        //[HttpGet]
        //[ProducesResponseType(200)]
        //[ProducesResponseType(500)]
        //public ActionResult<List<Employee>> GetAll()
        //{
        //    //throw new Exception("Simulated error from GetAll");
        //    return Ok(_employees);
        //}

        //[HttpGet("{id}")]
        //[ProducesResponseType(200)]
        //public ActionResult<Employee> GetEmployeeById(int id)
        //{
        //    var employee = _employees.FirstOrDefault(e => e.Id == id);
        //    if (employee == null)
        //        return NotFound();
        //    return Ok(employee);
        //}

        //[HttpPost]
        //public ActionResult CreateEmployee([FromBody] Employee emp)
        //{
        //    if (!ModelState.IsValid)
        //    {
        //        return BadRequest(ModelState);
        //    }
        //    _employees.Add(emp);
        //    return Ok(emp);
        //}

        //[HttpPut]
        //public IActionResult UpdateEmployee([FromBody] Employee emp)
        //{
        //    var existing = _employees.FirstOrDefault(e => e.Id == emp.Id);
        //    if (existing == null)
        //        return NotFound();

        //    existing.Name = emp.Name;
        //    existing.Salary = emp.Salary;
        //    existing.Permanent = emp.Permanent;
        //    existing.DateOfBirth = emp.DateOfBirth;
        //    existing.Department = emp.Department;
        //    existing.Skills = emp.Skills;

        //    return Ok(existing);
        //}

    }
}
