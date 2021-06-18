using CrudCoreApp01.Models;
using System.Data;
using System.Data.SqlClient;

namespace CrudCoreApp01.Data
{
    /// <summary>
    /// Author : Somendra Pratap Singh
    /// Date   : 18-June-2021
    /// </summary>
    public class DataAccessLayer
    {
        public ConnectionString _connectionstring;
        private readonly string con;

        public DataAccessLayer(ConnectionString _con)
        {
            this._connectionstring = _con;
            con = _con.DefaultCoreDbConnectionString;
        }

        #region "Return DataSet"
        public DataSet GetDataSet(SqlCommand _cmd)
        {
            try
            {
                using (SqlConnection _con = new SqlConnection(con))
                {
                    _con.Open();
                    using (DataSet _dataset = new DataSet())
                    {
                        _cmd.Connection = _con;
                        _cmd.CommandTimeout = 300;
                        using (SqlDataAdapter _dataAdapter = new SqlDataAdapter())
                        {
                            _dataAdapter.Fill(_dataset);
                        }
                        return _dataset;
                    }
                }
            }
            finally
            {
                _cmd.Dispose();
            }
        }
        #endregion
    }
}
