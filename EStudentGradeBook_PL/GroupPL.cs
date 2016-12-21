using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EStudentGradeBook_PL
{
    class GroupPL
    {
        public GroupPL()
        {
            this.students = new List<StudentPL>();
        }

        public int group_id { get; set; }
        public int group_cource { get; set; }

        public List<StudentPL> students { get; set; }
    }
}
