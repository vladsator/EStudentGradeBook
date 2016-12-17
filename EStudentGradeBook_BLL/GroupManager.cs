using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EStudentGradeBook_DAL;

namespace EStudentGradeBook_BLL
{
    public class GroupManager
    {
        public List<int> GetAllGroupIds()
        {
            GroupDataManager dataManager = new GroupDataManager();
            InpMapping mapper = new InpMapping();
            var query = from g in mapper.GroupListMapper((List<Group>) dataManager.GetList())
                select g.group_id;
            return query.ToList();
        }
    }
}
