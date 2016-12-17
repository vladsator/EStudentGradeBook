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
    }
}
