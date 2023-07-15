using AngularWithDotNet.Interfaces;
using AngularWithDotNet.Models;
using Microsoft.EntityFrameworkCore;

namespace AngularWithDotNet.DataAccess
{
    public class EmployeeDataAccessLayer : IEmployee
    {
        private EmployeeDbContext _employeeDbContext;

        public EmployeeDataAccessLayer(EmployeeDbContext employeeDbContext)
        {
            _employeeDbContext = employeeDbContext;
        }

        public IEnumerable<Employee> GetAllEmployees() {
            try
            {
                return _employeeDbContext.Employees.ToList().OrderBy(x => x.EmployeeId);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }

        public Employee GetEmployeeById(int employeeId)
        {
            try
            {
                Employee employee = _employeeDbContext.Employees.Find(employeeId);
                return employee;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }

        public int AddEmployee(Employee employee)
        {
            try
            {
                _employeeDbContext.Employees.Add(employee);
                _employeeDbContext.SaveChanges();
                return 1;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }

        public int UpdateEmployee(Employee employee) {
            try
            {
                _employeeDbContext.Entry(employee).State = EntityState.Modified;
                _employeeDbContext.SaveChanges();
                return 1;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }

        public int DeleteEmployee(int employeeId) {
            try
            {
                Employee employee = _employeeDbContext.Employees.Find(employeeId);
                _employeeDbContext.Remove(employee);
                _employeeDbContext.SaveChanges();   
                return 1;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                throw;
            }
        }

        public List<City> GetAllCities()
        {
            List<City> list = new List<City>();
            list = (from CityList in  _employeeDbContext.Cities select CityList).ToList();
            return list;
        }
    }
}
