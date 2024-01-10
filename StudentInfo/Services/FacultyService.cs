using StudentInfo.Interfaces.IRepositories;
using StudentInfo.Interfaces.IServices;
using StudentInfo.Model;

namespace StudentInfo.Services
{
    public class FacultyService : IFacultyService
    {
        protected readonly IFacultyRepository _facultetRepository;

        public FacultyService(IFacultyRepository facultyRepository)
        {
            _facultetRepository = facultyRepository;
        }
        public async Task<IEnumerable<Faculty>> GetAllFaculties()
        {

            return  _facultetRepository.GetAllFaculteties();
        }
    }
}
