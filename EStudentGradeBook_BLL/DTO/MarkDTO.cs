using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EStudentGradeBook_BLL.DTO
{
    public class MarkDTO
    {
        public int mark_id { get; set; }
        public int mark_student_id { get; set; }
        public int mark_lesson_id { get; set; }
        public int mark_value { get; set; }
        public DateTime? mark_date { get; set; }

        public MarkDTO()
        {
            
        }
    }
}
