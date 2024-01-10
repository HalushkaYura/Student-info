using Dapper;
using StudentInfo.Constants;
using StudentInfo.Interfaces.IRepositories;
using StudentInfo.Model;
using System.Data;

namespace StudentInfo.Repositories
{
    public class FacultyRepository : IBaseRepository<Faculty>
    {

        public int CreateElement(Faculty newItem)
        {

            using var connection = DataBaseConstants.GetConnection();
            connection.Open();

            var parameters = new DynamicParameters();
            parameters.Add("@Name", newItem.Name);
            parameters.Add("@Note", newItem.Note);
            parameters.Add("@FacultyId", dbType: DbType.Int32, direction: ParameterDirection.Output);  // Встановлення параметру для виводу Id
            var rows = connection.Execute(
            DataBaseConstants.CreateFaculty,
            parameters,
            commandType: CommandType.StoredProcedure);
            if (rows > 0)
            {
                return parameters.Get<int>("@FacultyId");
            }
            return 0;
        }

        public bool DeleteElement(int id)
        {
            using var connection = DataBaseConstants.GetConnection();
            connection.Open();

            var rows = connection.Execute(DataBaseConstants.DeleteFaculty, new { FacultyId = id }, commandType: CommandType.StoredProcedure);
            return rows > 0;
        }

        public IEnumerable<Faculty> GetAllElements()
        {
            using var connection = DataBaseConstants.GetConnection();
            connection.Open();

            return connection.Query<Faculty>(DataBaseConstants.GetAllFaculties, commandType: CommandType.StoredProcedure);
        }

        public Faculty GetElementById(int facultyId)
        {
            using var connection = DataBaseConstants.GetConnection();
            connection.Open();

            return connection.QueryFirstOrDefault<Faculty>(DataBaseConstants.GetFacultyById, new { FacultyId = facultyId }, commandType: CommandType.StoredProcedure);
        }

        public Faculty GetLastItem()
        {
            using var connection = DataBaseConstants.GetConnection();
            connection.Open();

            return connection.QueryFirstOrDefault<Faculty>(DataBaseConstants.GetLastFaculty, commandType: CommandType.StoredProcedure);
        }

        public bool UpdateElement(int id, Faculty updateItem)
        {
            using var connection = DataBaseConstants.GetConnection();
            connection.Open();

            var rows = connection.Execute(DataBaseConstants.UpdateFaculty, new { FacultyId = id, updateItem.Name, updateItem.Note }, commandType: CommandType.StoredProcedure);
            return rows > 0;
        }


    }
}
