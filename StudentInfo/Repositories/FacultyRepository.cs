using Dapper;
using StudentInfo.Constants;
using StudentInfo.Interfaces.IRepositories;
using StudentInfo.Model;
using System.Data;

namespace StudentInfo.Repositories
{
    public class FacultyRepository : IFacultyRepository
    {

        public bool CreateFaculty(Faculty newItem)
        {
            
            using var connection = DataBaseConstants.GetConnection();
            connection.Open();

            var rows = connection.Execute(DataBaseConstants.CreateFaculty, 
                new 
                { 
                    newItem.Name, 
                    newItem.Note 
                }, commandType: CommandType.StoredProcedure);
            return rows > 0;
        }

        public bool DeleteFaculty(int id)
        {
            using var connection = DataBaseConstants.GetConnection();
            connection.Open();

            var rows = connection.Execute(DataBaseConstants.DeleteFaculty, new { Id = id }, commandType: CommandType.StoredProcedure);
            return rows > 0;
        }

        public IEnumerable<Faculty> GetAllFaculteties()
        {
            using var connection = DataBaseConstants.GetConnection();
            connection.Open();

            return connection.Query<Faculty>(DataBaseConstants.GetAllFaculties, commandType: CommandType.StoredProcedure);
        }

        public Faculty GetFacultyById(int facultyId)
        {
            using var connection = DataBaseConstants.GetConnection();
            connection.Open();

            return connection.QueryFirstOrDefault<Faculty>(DataBaseConstants.GetFacultyById, new { FacultyId = facultyId }, commandType: CommandType.StoredProcedure);
        }

        public bool UpdateFaculty(int id, Faculty updateItem)
        {
            using var connection = DataBaseConstants.GetConnection();
            connection.Open();

            var rows = connection.Execute(DataBaseConstants.UpdateFaculty, new { Id = id, updateItem.Name, updateItem.Note }, commandType: CommandType.StoredProcedure);
            return rows > 0;
        }
    }
}
