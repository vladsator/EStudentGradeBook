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
            //Mapper.Initialize(cfg => cfg.CreateMap<Group, GroupBll>().ForMember(dest => dest.students, opt => opt.MapFrom(src => StudentListMapper(src.students))));
            //List<GroupBll> groupsBll = new List<GroupBll>();

            //foreach (var g in groups)
            //{
            //    groupsBll.Add(Mapper.Map<Group, GroupBll>(g));
            //}
            List<GroupBll> groupsBll = new List<GroupBll>();
            foreach (var g in groups)
            {
                GroupBll group = new GroupBll()
                {
                    group_cource = g.group_cource,
                    group_id = g.group_id,
                    students = StudentListMapper(g.students)
                };
                groupsBll.Add(group);
            }
            return groupsBll;
        }

        public List<LessonBLL> LessonListMapper(List<Lesson> getList)
        {
            List<LessonBLL> studentsBll = new List<LessonBLL>();

            foreach (var g in getList)
            {
                studentsBll.Add(LessonMapper(g));
            }
            return studentsBll;
        }

        public LessonBLL LessonMapper(Lesson lesson)
        {
            Mapper.Initialize(cfg => cfg.CreateMap<Lesson, LessonBLL>());
            return Mapper.Map<Lesson, LessonBLL>(lesson);
        }

    }
}
