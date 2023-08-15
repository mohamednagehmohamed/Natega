using Natega.Shared.Models;

namespace Natega.Client.Services
{
    public interface Inategaservice
    {
        Task<List<Stage_New_Search>> GetAllStudents(string Apiname);
        Task<Stage_New_Search> GetStudentbyseating(string Apiname);
    }
}
