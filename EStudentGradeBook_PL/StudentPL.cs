using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EStudentGradeBook_PL
{
    class StudentPL
    {
        public int? student_id { get; set; }
        public int? student_group_id { get; set; }
        public string student_name { get; set; }
        public string student_surname { get; set; }
        public string student_secondname { get; set; }
        public string student_email { get; set; }

        public StudentPL(int? groupId, string name, string surname, string secondname, string email)
        {
            student_group_id = groupId;
            student_name = name;
            student_surname = surname;
            student_secondname = secondname;
            student_email = email;
        }

        public StudentPL()
        {
            
        }

        public override string ToString()
        {
            return $"{student_surname} {student_name} {student_secondname}";
        }
    }
}
