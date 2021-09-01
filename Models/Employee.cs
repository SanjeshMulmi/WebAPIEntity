using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPI.Models
{
    public enum eGender { Male, Female}
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public int DepartmentId { get; set; }
        public eGender Gender { get; set; }
        public Department Department { get; set; }

    }
}
