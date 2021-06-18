namespace CrudCoreApp01.Data.EmployeeData
{
    public class EmployeeAccessLayer
    {
        private DataAccessLayer _accessLayer;
        public EmployeeAccessLayer(DataAccessLayer _dataAccessLayer)
        {
            this._accessLayer = _dataAccessLayer;
        }


    }
}
