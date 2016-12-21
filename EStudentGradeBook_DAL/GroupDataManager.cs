using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EStudentGradeBook_DAL
{
    public class GroupDataManager : DataManager<Group>
    {
        EStudentGradeBookDBContext context = new EStudentGradeBookDBContext();

        public override void Add(Group addObj)
        {
            context.Groups.Add(addObj);
            context.SaveChanges();
        }

        public override void Remove(Group removeObj)
        {
            context.Groups.Remove(removeObj);
            context.SaveChanges();
        }

        public override void Update(Group updateObj)
        {
            throw new NotImplementedException();
        }

        public override List<Group> GetList()
        {
            EStudentGradeBookDBContext context = new EStudentGradeBookDBContext();
            return context.Groups.ToList();
        }
    }
}
