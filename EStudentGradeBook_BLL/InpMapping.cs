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

        public List<StudentBLL> StudentListMapper(List<Student> students)
        {
            List<StudentBLL> studentsBll = new List<StudentBLL>();

            foreach (var g in students)
            {
                studentsBll.Add(StudentMapper(g));
            }
            return studentsBll;
        }

        public List<GroupBll> GroupListMapper(List<Group> groups)
        {
            Mapper.Initialize(cfg => cfg.CreateMap<Group, GroupBll>());
            List<GroupBll> groupsBll = new List<GroupBll>();

            foreach (var g in groups)
            {
                groupsBll.Add(Mapper.Map<Group, GroupBll>(g));
            }
            return groupsBll;
        }
    }
}
