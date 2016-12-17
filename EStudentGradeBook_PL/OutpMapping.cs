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
    }
}
