using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Natega.Shared.Models
{
    public class Stage_New_Search
    {
        public int ID { get; set; }
        public int seating_no { get; set; }
        public string arabic_name { get; set; }
        public float total_degree { get; set; }
        public int student_case { get; set; }
        public string student_case_desc { get; set; }
        public float c_flage { get; set; }
    }
}
