using CrudCoreApp01.Models;

namespace CrudCoreApp01.Data.EmployeeData
{
    interface IEmployee
    {
        //Insert and Update Employee records by EmployeeId.
        public Employee InsertUpdateEmployee();
    }
}
