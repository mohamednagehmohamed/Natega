using Natega.Shared.Models;

namespace Natega.Server.Interfaces
{
    public interface INategaInterface
    {
        IEnumerable<Stage_New_Search> GetAllStudents();
        Stage_New_Search GetStudentbyseating(int seatingno);
    }
}
