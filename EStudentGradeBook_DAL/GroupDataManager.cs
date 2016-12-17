using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EStudentGradeBook_DAL
{
    public class GroupDataManager : DataManager<Group>
    {
        public override void Add(Group addObj)
        {
            throw new NotImplementedException();
        }

        public override void Remove(Group removeObj)
        {
            throw new NotImplementedException();
        }

        public override void Update(Group updateObj)
        {
            throw new NotImplementedException();
        }

        public override object GetList()
        {
            EStudentGradeBookDBContext context = new EStudentGradeBookDBContext();
            return context.Groups.ToList();
        }
    }
}
