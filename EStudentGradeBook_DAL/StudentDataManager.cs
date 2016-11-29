using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EStudentGradeBook_DAL
{
    class StudentDataManager : DataManager<Student>
    {
        public override void Add(Student addObj)
        {
            var context = new EStudentGradeBookDBContext();
            context.Students.Add(addObj);
            context.SaveChanges();
        }

        public override void Remove(Student removeObj)
        {
            var context = new EStudentGradeBookDBContext();
            context.Students.Remove(removeObj);
            context.SaveChanges();
        }

        public override void Update(Student updateObj)
        {
            var context = new EStudentGradeBookDBContext();
            var student = context.Students.FirstOrDefault(s => s.student_id == updateObj.student_id);
            student = updateObj;
            context.SaveChanges();

        }

        public override List<Student> GetList()
        {
            var context = new EStudentGradeBookDBContext();
            return context.Students.ToList();
        }
    }
}
