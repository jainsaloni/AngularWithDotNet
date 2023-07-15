using AngularWithDotNet.Interfaces;
using AngularWithDotNet.Models;
using Microsoft.AspNetCore.Mvc;

namespace AngularWithDotNet.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class EmployeeController : ControllerBase
    {
        public readonly IEmployee _employee;

        public EmployeeController(IEmployee employee)
        {
            _employee = employee;
        }

        [HttpGet]
        public IEnumerable<Employee> Get() 
        {
            return _employee.GetAllEmployees();
        }

        [HttpGet("GetById/{id}")]
        public Employee Get(int id)
        {
            return _employee.GetEmployeeById(id);
        }

        [HttpPost]
        public int Post([FromBody] Employee employee)
        {
            return _employee.AddEmployee(employee);
        }

        [HttpPut]
        public int Put([FromBody] Employee employee)
        {
            return _employee.UpdateEmployee(employee);
        }

        [HttpDelete("DeleteById/{id}")]
        public int Delete(int id)
        {
            return _employee.DeleteEmployee(id);
        }

        [HttpGet]
        [Route("GetCityList")]
        public IEnumerable<City> GetCityList() 
        {
            return _employee.GetAllCities();
        }
    }
}
