using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EStudentGradeBook_BLL
{
    public class LessonPL
    {
        public LessonPL()
        {
        }

        public int lesson_id { get; set; }
        public string lesson_name { get; set; }


        public override string ToString()
        {
            return lesson_name;
        }
    }
}
