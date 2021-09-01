using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public interface IEmployeeRepository
    {
        Task<IEnumerable<Employee>> Search(string name, eGender? gender);
        Task<IEnumerable<Employee>> GetAllEmployees();
        Task<Employee> GetEmployeeById(int employeeId);
        Task<Employee> AddEmployee(Employee addEmployee);
        Task<Employee> UpdateEmployee(Employee updateEmployee);
        Task<Employee> DeleteEmployee(Employee deleteEmployee); 
    }
}
