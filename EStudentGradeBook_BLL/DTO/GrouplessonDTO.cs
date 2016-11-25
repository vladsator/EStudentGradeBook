using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EStudentGradeBook_BLL.DTO
{
    public class GrouplessonDTO
    {
        public int grouplesson_id { get; set; }
        public int grouplesson_group_id { get; set; }
        public int grouplesson_lesson_id { get; set; }

        public GrouplessonDTO()
        {
            
        }
    }
}
