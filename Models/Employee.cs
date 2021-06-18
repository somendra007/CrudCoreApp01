using System;
using System.Collections.Generic;

namespace CrudCoreApp01.Models
{
    public class Employee
    {
        public int EmployeeId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EmailId { get; set; }
        public string Address { get; set; }
        public DateTime DOB { get; set; }
        public string Country { get; set; }
        public string State { get; set; }

        public List<Employee> GetEmployees { get; set; }
    }
}
