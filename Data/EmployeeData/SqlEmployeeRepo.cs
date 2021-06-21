using CrudCoreApp01.Models;
using System.Data;

namespace CrudCoreApp01.Data.EmployeeData
{
    public class SqlEmployeeRepo
    {
        private readonly EmployeeAccessLayer _employeeAccess;
        public Employee employee;
        public SqlEmployeeRepo(EmployeeAccessLayer _employeeAccessLayer)
        {
            this._employeeAccess = _employeeAccessLayer;
        }
        public string InsertUpdateEmployee()
        {
            DataSet ds = _employeeAccess.InsertUpdateEmployee();
            string EmployeeId = ds.Tables[0].Rows[0]["EmployeeId"].ToString();
            return EmployeeId;
        }
    }
}
