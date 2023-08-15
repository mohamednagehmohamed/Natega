using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;
using Natega.Shared.Models;

namespace Natega.Server.Interfaces
{
    public class NtageaInterface : INategaInterface
    {
        private readonly NategaContext _context;

        public NtageaInterface(NategaContext context)
        {
            _context = context;
        }

        public IEnumerable<Stage_New_Search> GetAllStudents()
        {
            return _context.Stage_New_Search.OrderByDescending(x=>x.total_degree).Where(s=>s.total_degree<=40).ToList();
        }

        public Stage_New_Search GetStudentbyseating(int seatingno)
        {
            return _context.Stage_New_Search.FirstOrDefault(x=>x.seating_no==seatingno);
        }
    }
}
