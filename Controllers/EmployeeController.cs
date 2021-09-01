using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebAPI.Models;

namespace WebAPI.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class EmployeeController : ControllerBase
    {
        private readonly IEmployeeRepository _employeeRepository;

        public EmployeeController(IEmployeeRepository employeeRepository)
        {
            _employeeRepository = employeeRepository;
        }

        [HttpGet]
        public async Task<ActionResult> GetEmpoyees()
        {
            return Ok(await this._employeeRepository.GetAllEmployees());
        }

        [HttpPost]
        public async Task<ActionResult> AddEmployee(Employee addEmployee)
        {
            return Ok(await _employeeRepository.AddEmployee(addEmployee));
        }
    }
}
