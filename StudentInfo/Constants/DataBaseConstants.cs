using System.Data.SqlClient;

namespace StudentInfo.Constants
{
    public class DataBaseConstants
    {
        private const string ConnectionString = "Data Source=DESKTOP-CPV6M2H\\SQLEXPRESS;Initial Catalog=UniversitiesDb;Persist Security Info=True;User ID=sa;Password=123456789";
        public static SqlConnection GetConnection()
            => new(ConnectionString);

        #region Faculties

        public const string CreateFaculty = "sp_Faculties_CreateFaculty";
        public const string UpdateFaculty = "sp_Faculties_UpdateFaculty";
        public const string DeleteFaculty = "sp_Faculties_DeleteFaculty";
        public const string GetAllFaculties = "sp_Faculties_GetAllFaculties";
        public const string GetFacultyById = "sp_Faculties_GetFacultyById";
        public const string GetLastFaculty = "sp_Faculties_GetLastFaculty";

        #endregion

        #region Departments

        public const string CreateDepartment = "sp_Departments_CreateDepartment";
        public const string UpdateDepartment = "sp_Departments_UpdateDepartment";
        public const string DeleteDepartment = "sp_Departments_DeleteDepartment";
        public const string GetAllDepartments = "sp_Departments_GetAllDepartments";
        public const string GetDepartmentById = "sp_Departments_GetDepartmentById";
        public const string GetLastDepartment = "sp_Categories_GetLastDepartment";

        #endregion

        #region Students
        public const string CreateStudent = "sp_Students_CreateStudent";
        public const string UpdateStudent = "sp_Students_UpdateStudent";
        public const string DeleteStudent = "sp_Students_DeleteStudent";
        public const string GetAllStudents = "sp_Students_GetAllStudents";
        public const string GetStudentById = "sp_Students_GetStudentById";
        public const string GetLastStudents = "sp_Categories_GetLastStudent";

        #endregion

        #region Groups
        public const string CreateGroup = "sp_Groups_CreateGroup";
        public const string UpdateGroup = "sp_Groups_UpdateGroup";
        public const string DeleteGroup = "sp_Groups_DeleteGroup";
        public const string GetAllGroups = "sp_Groups_GetAllGroups";
        public const string GetGroupById = "sp_Groups_GetGroupById";
        public const string GetLastGroup = "sp_Categories_GetLastGroup";

        #endregion
    }
}
