using AngularWithDotNet.Models;

namespace AngularWithDotNet.Interfaces
{
    public interface IEmployee
    {
        IEnumerable<Employee> GetAllEmployees();

        Employee GetEmployeeById(int employeeId);

        int AddEmployee(Employee employee);

        int UpdateEmployee(Employee employee);

        int DeleteEmployee(int employeeId);

        List<City> GetAllCities();
    }
}
