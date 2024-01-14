using Dapper;
using StudentInfo.Constants;
using StudentInfo.Interfaces.IRepositories;
using StudentInfo.Model;
using System.Data;

namespace StudentInfo.Repositories
{
    public class StudentRepository : IBaseRepository<Student>
    {
        public int CreateElement(Student newItem)
        {
            using var connection = DataBaseConstants.GetConnection();
            connection.Open();

            var rows = connection.Execute(DataBaseConstants.CreateStudent, new
            {
                newItem.PhoneNumber,
                newItem.Name,
                newItem.Surname,
                newItem.BornDate,
                newItem.DateStartStudy,
                newItem.GPA,
                newItem.GroupId,
                newItem.Course,
                newItem.DateEndStudy
            }, commandType: CommandType.StoredProcedure);
            if(rows>0) 
            {
                return 1;
            }
            return 0;
        }

        public bool DeleteElement(int id)
        {
            using var connection = DataBaseConstants.GetConnection();
            connection.Open();

            var rows = connection.Execute(DataBaseConstants.DeleteStudent, new { StudentId = id }, commandType: CommandType.StoredProcedure);
            return rows > 0;
        }

        public IEnumerable<Student> GetAllElements()
        {
            using var connection = DataBaseConstants.GetConnection();
            connection.Open();

            return connection.Query<Student>(DataBaseConstants.GetAllStudents, commandType: CommandType.StoredProcedure);
        }

        public Student GetElementById(int id)
        {
            using var connection = DataBaseConstants.GetConnection();
            connection.Open();

            return connection.QueryFirstOrDefault<Student>(DataBaseConstants.GetStudentById, new { StudentId = id }, commandType: CommandType.StoredProcedure);
        }

        public bool UpdateElement(int id, Student updatedItem)
        {
            using var connection = DataBaseConstants.GetConnection();
            connection.Open();

            var rows = connection.Execute(DataBaseConstants.UpdateStudent, new
            {
                StudentId = id,
                updatedItem.PhoneNumber,
                updatedItem.Name,
                updatedItem.Surname,
                updatedItem.BornDate,
                updatedItem.DateStartStudy,
                updatedItem.GPA,
                updatedItem.GroupId,
                updatedItem.Course,
                updatedItem.DateEndStudy
            }, commandType: CommandType.StoredProcedure);
            return rows > 0;
        }
    }
}
