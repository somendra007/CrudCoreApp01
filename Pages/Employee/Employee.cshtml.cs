using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using CrudCoreApp01.Data.EmployeeData;

namespace CrudCoreApp01.Pages.Employee
{
    public class EmployeeModel : PageModel
    {
        private readonly SqlEmployeeRepo _sqlEmployeeRepo;
        public EmployeeModel(SqlEmployeeRepo _employeeRepo)
        {
            this._sqlEmployeeRepo = _employeeRepo;
        }
        public void OnGet()
        {

        }
    }
}
