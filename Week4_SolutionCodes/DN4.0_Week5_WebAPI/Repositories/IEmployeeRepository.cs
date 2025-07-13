using DN4._0_Week5_WebAPI.Models;

namespace DN4._0_Week5_WebAPI.Repositories
{
    public interface IEmployeeRepository
    {
        IEnumerable<Employee> GetAll();
        Employee? GetById(int id);
        void Add(Employee employee);
        void Update(Employee employee);
        void Delete(int id);
        bool Exists(int id);
    }
}
