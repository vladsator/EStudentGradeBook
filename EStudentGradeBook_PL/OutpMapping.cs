using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using EStudentGradeBook_BLL;


namespace EStudentGradeBook_PL
{
    class OutpMapping
    {
        public StudentBLL StudentMapper(StudentPL student)
        {
            Mapper.Initialize(cfg => cfg.CreateMap<StudentPL, StudentBLL>());
            return Mapper.Map<StudentPL, StudentBLL>(student);
        }

        public List<StudentBLL> StudentListMapper(List<StudentPL> students)
        {
            List<StudentBLL> studentsBll = new List<StudentBLL>();

            foreach (var g in students)
            {
                studentsBll.Add(StudentMapper(g));
            }
            return studentsBll;
        }

        public GroupBll GroupMapper(GroupPL groupPl)
        {
            Mapper.Initialize(
                cfg =>
                    cfg.CreateMap<GroupPL, GroupBll>()
                        .ForMember(dest => dest.students, opt => opt.MapFrom(src => StudentListMapper(src.students))));
            return Mapper.Map<GroupPL, GroupBll>(groupPl);
        }
    }
}
