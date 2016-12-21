using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using EStudentGradeBook_DAL;

namespace EStudentGradeBook_BLL
{
    class OutpMapping
    {
        public Student StudentMapper(StudentBLL student)
        {
            Mapper.Initialize(cfg => cfg.CreateMap<StudentBLL, Student>());
            return Mapper.Map<StudentBLL, Student>(student);
        }

        public List<Student> StudentListMapper(List<StudentBLL> students)
        {
            List<Student> studentsBll = new List<Student>();

            foreach (var g in students)
            {
                studentsBll.Add(StudentMapper(g));
            }
            return studentsBll;
        }

        public Group GroupMapper(GroupBll group)
        {
            Mapper.Initialize(
                cfg =>
                    cfg.CreateMap<GroupBll, Group>()
                        .ForMember(dest => dest.students, opt => opt.MapFrom(src => StudentListMapper(src.students))));                            
            return Mapper.Map<GroupBll, Group>(group);
        }
    }
}
