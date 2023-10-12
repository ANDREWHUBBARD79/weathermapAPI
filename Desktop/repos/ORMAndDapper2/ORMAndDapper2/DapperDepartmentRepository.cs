using System;
using System.Collections.Generic;
using System.Data;
using Dapper;
using ORMAndDapper2;

namespace BestBuyCRUD
{
    public class DepartmentRepository : DepartmentRepositoryBase, IDepartmentRepository
    {
        private readonly IDbConnection _conn;

        public DepartmentRepository(IDbConnection conn)
        {
            _conn = conn;
        }

        public void CreateDepartment(string name)
        {
            _conn.Execute("INSERT INTO departments Name Values(@name);", new { name = name });
        }

        public void UpdateDepartment(int id, string newName)
        {
            _conn.Execute("UPDATE departments SET Name = @newName WHERE DepartmentID = @id;", new { newName = newName, id = id });
        }

        IEnumerable<Department> IDepartmentRepository.GetAllDepartments()
        {
            throw new NotImplementedException();
        }
    }
}