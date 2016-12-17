using System.Collections.Generic;
using AutoMapper;
using EStudentGradeBook_DAL;

namespace EStudentGradeBook_BLL
{
    class InpMapping
    {
        public StudentBLL StudentMapper(Student student)
        {
            Mapper.Initialize(cfg => cfg.CreateMap<Student, StudentBLL>());
            return Mapper.Map<Student, StudentBLL>(student);
        }

        public List<GroupBll> GroupListMapper(List<Group> groups)
        {
            Mapper.Initialize(cfg => cfg.CreateMap<Group, GroupBll>());
            List<GroupBll> groupsId = new List<GroupBll>();

            foreach (var g in groups)
            {
                groupsId.Add(Mapper.Map<Group, GroupBll>(g));
            }
            return groupsId;
        }
    }
}
