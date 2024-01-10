using StudentInfo.Model;

namespace StudentInfo.Interfaces.IRepositories
{
    public interface IFacultyRepository
    {
        IEnumerable<Faculty> GetAllFaculteties();
        Faculty GetFacultyById(int id);
        bool CreateFaculty(Faculty newItem);
        bool UpdateFaculty(int id, Faculty updateItem);
        //T GetLastItem();
        bool DeleteFaculty(int id);
    }
}
