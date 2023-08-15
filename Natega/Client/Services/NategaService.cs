using Natega.Shared.Models;
using System.Net.Http.Json;

namespace Natega.Client.Services
{
    public class NategaService : Inategaservice
    {
        private readonly HttpClient _httpclient;

        public NategaService(HttpClient httpclient)
        {
            _httpclient = httpclient;
        }

        public async Task<List<Stage_New_Search>> GetAllStudents(string Apiname)
        {
            return await _httpclient.GetFromJsonAsync<List<Stage_New_Search>>(Apiname);
        }

        public async Task<Stage_New_Search> GetStudentbyseating(string Apiname)
        {
            return await _httpclient.GetFromJsonAsync<Stage_New_Search>(Apiname);
        }
    }
}
