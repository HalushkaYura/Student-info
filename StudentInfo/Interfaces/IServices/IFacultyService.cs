using StudentInfo.Model;

namespace StudentInfo.Interfaces.IServices
{
    public interface IFacultyService
    {
         Task<IEnumerable<Faculty>> GetAllFaculties();
    }
}
