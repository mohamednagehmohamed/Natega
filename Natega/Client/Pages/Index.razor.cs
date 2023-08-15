using Microsoft.AspNetCore.Components;
using Natega.Client.Services;
using Natega.Shared.Models;
using System.Timers;
namespace Natega.Client.Pages
{
    public partial class Index
    {
        [Inject]
        public Inategaservice inategaservice { get; set; }
        List<Stage_New_Search> AllStudents { get; set; } = new();
        Stage_New_Search oneStudent { get; set; } = new();
        private string Studentshoaba = string.Empty;
        private int standing = 0;
        System.Timers.Timer timer;
        string datetime = string.Empty;
        protected override async Task OnInitializedAsync()
        {

            timer = new System.Timers.Timer();
            timer.Interval = 1000;
            timer.Elapsed += OnTimeStambes;
            timer.Enabled = true;
            // AllStudents = await inategaservice.GetAllStudents("api/Natega/GetAllStudents");
            //  oneStudent = await inategaservice.GetStudentbyseating("api/Natega/GetStudentBySeating/1323869");
            await base.OnInitializedAsync();
        }
        private void OnTimeStambes(object?sender,ElapsedEventArgs e)
        {
            datetime = DateTime.Now.ToString("dd-MM-yyyy hh:mm:ss tt");
            InvokeAsync(()=>
            {
                StateHasChanged();
            });    
        }
        private async void OnValidSubmit(int seatingno) 
        {
            oneStudent = await inategaservice.GetStudentbyseating($"api/Natega/GetStudentBySeating/{seatingno}");

            AllStudents = await inategaservice.GetAllStudents("api/Natega/GetAllStudents"); 
            int index = AllStudents.IndexOf(oneStudent);
            standing = index + 1;
            if (oneStudent.c_flage == 1)
                Studentshoaba = "علمي علوم";
            if (oneStudent.c_flage == 2)
                Studentshoaba = "علمي رياضة";
            if (oneStudent.c_flage == 3)
                Studentshoaba = "أدبي";
        }


    }
}
