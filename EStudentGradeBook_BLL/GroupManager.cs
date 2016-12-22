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
        static List<GroupBll> _groupList = new List<GroupBll>();
        readonly GroupDataManager _groupManager = new GroupDataManager();
        readonly InpMapping _inpMapper = new InpMapping();
        readonly OutpMapping _outpMapper = new OutpMapping();

        public GroupManager()
        {
            _groupList = _inpMapper.GroupListMapper(_groupManager.GetList());
        }

        public void AddGroup(GroupBll group)
        {
            _groupManager.Add(_outpMapper.GroupMapper(group));        
        }

        public List<GroupBll> GetGroupList()
        {            
            return _groupList;
        }

        public List<int> GetAllGroupIds()
        {          
            var query = from g in _groupList
                select g.group_id;
            return query.ToList();
        }
    }
}
