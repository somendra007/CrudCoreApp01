using CrudCoreApp01.Models;
using CrudCoreApp01.Data;
using System.Data;
using System.Data.SqlClient;
using System;

namespace CrudCoreApp01.Data.EmployeeData
{
    public class EmployeeAccessLayer
    {        
        private DataAccessLayer _accessLayer;
        private Employee _employee;
        public EmployeeAccessLayer(DataAccessLayer _dataAccessLayer, Employee _emp)
        {
            this._accessLayer = _dataAccessLayer;
            this._employee = _emp;
        }

        public DataSet InsertUpdateEmployee()
        {
            using (SqlCommand _sqlCommand = new SqlCommand())
            {
                _sqlCommand.CommandText = "Proc_InsertUpdateEmployeeById";
                _sqlCommand.CommandType = CommandType.StoredProcedure;
                _sqlCommand.Parameters.AddWithValue("@FirstName", _employee.FirstName);
                _sqlCommand.Parameters.AddWithValue("@LastName", _employee.LastName);
                _sqlCommand.Parameters.AddWithValue("@MailId", _employee.EmailId);
                _sqlCommand.Parameters.AddWithValue("@Address", _employee.Address);
                _sqlCommand.Parameters.AddWithValue("@DOB", _employee.DOB);
                _sqlCommand.Parameters.AddWithValue("@Country", _employee.Country);
                _sqlCommand.Parameters.AddWithValue("@State", _employee.State);
                return _accessLayer.GetDataSet(_sqlCommand);
            }
        }
    }
}
