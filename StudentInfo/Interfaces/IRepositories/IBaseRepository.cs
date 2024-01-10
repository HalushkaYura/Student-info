using StudentInfo.Model;

namespace StudentInfo.Interfaces.IRepositories
{
    public interface IBaseRepository<T>
    {
        IEnumerable<T> GetAllElements();
        T GetElementById(int id);
        int CreateElement(T newItem);
        bool UpdateElement(int id, T updateItem);
        //T GetLastItem();
        bool DeleteElement(int id);
    }
}
