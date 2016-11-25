using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EStudentGradeBook_BLL.DTO
{
    public class StudentDTO
    {
        public int student_id { get; set; }
        public int? student_group_id { get; set; }
        public string student_name { get; set; }
        public string student_surname { get; set; }
        public string student_secondname { get; set; }
        public string student_email { get; set; }

        public StudentDTO()
        {
            
        }
    }
}
