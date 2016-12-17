using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EStudentGradeBook_DAL
{
    public class StudentDataManager : DataManager<Student>
    {
        private readonly EStudentGradeBookDBContext _context = new EStudentGradeBookDBContext();

        public override void Add(Student addObj)
        {
            _context.Students.Add(addObj);
            _context.SaveChanges();
        }

        public override void Remove(Student removeObj)
        {
            _context.Students.Remove(removeObj);
            _context.SaveChanges();
        }
        
        //TODO: test this shit!
        public override void Update(Student updateObj)
        {
            var student = _context.Students.FirstOrDefault(s => s.student_id == updateObj.student_id);
            student = updateObj;
            _context.SaveChanges();

        }

        public override object GetList()
        {
            EStudentGradeBookDBContext context = new EStudentGradeBookDBContext();
            var query = from s in context.Students
                join g in context.Groups on s.student_group_id equals g.group_id into joined
                from j in joined.DefaultIfEmpty()
                select new
                {
                    GroupId = j.group_id,
                    Cource = j.group_cource,
                    StudentSurname = s.student_surname,
                    StudentName = s.student_name,
                    Patronymic = s.student_secondname,
                    Email = s.student_email
                };

            
            return query.ToList();
        }
    }
}
