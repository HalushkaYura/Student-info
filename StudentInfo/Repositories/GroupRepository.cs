using Dapper;
using StudentInfo.Constants;
using StudentInfo.Interfaces.IRepositories;
using StudentInfo.Model;
using System.Data;

namespace StudentInfo.Repositories
{
    public class GroupRepository : IBaseRepository<Group>
    {
        public int CreateElement(Group newItem)
        {
            using var connection = DataBaseConstants.GetConnection();
            connection.Open();

            var rows = connection.Execute(DataBaseConstants.CreateGroup, new { newItem.Name, newItem.FacultyId}, commandType: CommandType.StoredProcedure);
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

            var rows = connection.Execute(DataBaseConstants.DeleteGroup, new { GroupId = id }, commandType: CommandType.StoredProcedure);
            return rows > 0;
        }

        public IEnumerable<Group> GetAllElements()
        {
            using var connection = DataBaseConstants.GetConnection();
            connection.Open();

            return connection.Query<Group>(DataBaseConstants.GetAllGroups, commandType: CommandType.StoredProcedure);
        }

        public Group GetElementById(int id)
        {
            using var connection = DataBaseConstants.GetConnection();
            connection.Open();

            return connection.QueryFirstOrDefault<Group>(DataBaseConstants.GetGroupById, new { GroupId = id }, commandType: CommandType.StoredProcedure);
        }

        public bool UpdateElement(int id, Group updatedItem)
        {
            using var connection = DataBaseConstants.GetConnection();
            connection.Open();

            var rows = connection.Execute(DataBaseConstants.UpdateGroup, new { GroupId = id, updatedItem.Name, updatedItem.FacultyId }, commandType: CommandType.StoredProcedure);
            return rows > 0;
        }
    }
}
