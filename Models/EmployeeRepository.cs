using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public class EmployeeRepository : IEmployeeRepository
    {
        private readonly EmployeeDBContext _context;
        public EmployeeRepository(EmployeeDBContext context)
        {
            _context = context;
        }

        public async Task<Employee> AddEmployee(Employee addEmployee)
        {
            var result = await _context.Employees.AddAsync(addEmployee);
            await _context.SaveChangesAsync();
            return result.Entity;
        }

        public async Task DeleteEmployee(Employee deleteEmployee)
        {
            var result = await _context.Employees.FindAsync(deleteEmployee.EmployeeId);
            if (result != null)
            {
                _context.Employees.Remove(deleteEmployee);
                await _context.SaveChangesAsync();
            }
        }

        public Employee GetAllEmployee()
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Employee>> GetAllEmployees()
        {
            return await _context.Employees.ToListAsync();
        }

        public Task<Employee> GetEmployeeById(int employeeId)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Employee>> Search(string name, eGender? gender)
        {
            IQueryable<Employee> query = _context.Employees;
            if (!String.IsNullOrEmpty(name))
            {
                query = query.Where(e => e.Name.Contains(name));
            }
            if (gender != null)
            {
                query = query.Where(e => e.Gender == (eGender)gender);
            }
            return await query.ToListAsync();
        }

        public Task<Employee> UpdateEmployee(Employee updateEmployee)
        {
            throw new NotImplementedException();
        }

        Task<Employee> IEmployeeRepository.DeleteEmployee(Employee deleteEmployee)
        {
            throw new NotImplementedException();
        }
    }
}
