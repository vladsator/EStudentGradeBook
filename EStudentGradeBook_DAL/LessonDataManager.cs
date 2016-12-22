using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EStudentGradeBook_DAL
{
    public class LessonDataManager : DataManager<Lesson>
    {
        EStudentGradeBookDBContext context = new EStudentGradeBookDBContext();

        public override void Add(Lesson addObj)
        {
            context.Lessons.Add(addObj);
            context.SaveChanges();
        }

        public override void Remove(Lesson removeObj)
        {
            context.Lessons.Remove(removeObj);
            context.SaveChanges();
        }

        public override void Update(Lesson updateObj)
        {
            throw new NotImplementedException();
        }

        public override List<Lesson> GetList()
        {
            return context.Lessons.ToList();
        }
    }
}
