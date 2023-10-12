using Dapper;
using ORMAndDapper2;

namespace BestBuyCRUD
{
    public class DepartmentRepositoryBase
    {

        public IEnumerable<Department> GetDepartments() => _conn.Query<Department>("Select * FROM departments;");
    }
}