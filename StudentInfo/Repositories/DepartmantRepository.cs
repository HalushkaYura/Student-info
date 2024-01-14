using Dapper;
using StudentInfo.Constants;
using StudentInfo.Interfaces.IRepositories;
using StudentInfo.Model;
using System.Data;

namespace StudentInfo.Repositories
{
    public class DepartmantRepository : IBaseRepository<Department>
    {
        public int  CreateElement(Department newItem)
        {
            using var connection = DataBaseConstants.GetConnection();
            connection.Open();

            var rows = connection.Execute(DataBaseConstants.CreateDepartment,
                new
                {
                    newItem.Name,
                    newItem.FacultyId
                }, commandType: CommandType.StoredProcedure);
            return 1;
        }

        public bool DeleteElement(int id)
        {
            using var connection = DataBaseConstants.GetConnection();
            connection.Open();

            var rows = connection.Execute(DataBaseConstants.DeleteDepartment, new { DepartmentId = id }, commandType: CommandType.StoredProcedure);
            return rows > 0;
        }

        public IEnumerable<Department> GetAllElements()
        {
            using var connection = DataBaseConstants.GetConnection();
            connection.Open();

            return connection.Query<Department>(DataBaseConstants.GetAllDepartments, commandType: CommandType.StoredProcedure);
        }

        public Department GetElementById(int id)
        {
            using var connection = DataBaseConstants.GetConnection();
            connection.Open();

            return connection.QueryFirstOrDefault<Department>(DataBaseConstants.GetDepartmentById, new { DepartmentId = id }, commandType: CommandType.StoredProcedure);
        }

            public bool UpdateElement(int id, Department updateItem)
            {
                using var connection = DataBaseConstants.GetConnection();
                connection.Open();

                var rows = connection.Execute(DataBaseConstants.UpdateDepartment, 
                    new {
                        DepartmentId = id,
                        Name = updateItem.Name,
                        FacultyId = updateItem.FacultyId
                    }, commandType: CommandType.StoredProcedure);
                return rows > 0;
            }
    }
}
