using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AutoMapper;
using EStudentGradeBook_BLL;

namespace EStudentGradeBook_PL
{
    class InpMapping
    {
        public StudentPL StudentMapper(StudentBLL student)
        {
            Mapper.Initialize(cfg => cfg.CreateMap<StudentBLL, StudentPL>());
            return Mapper.Map<StudentBLL, StudentPL>(student);
        }

        public List<StudentPL> StudentListMapper(List<StudentBLL> students)
        {
            List<StudentPL> studentsPL = new List<StudentPL>();

            foreach (var g in students)
            {
                studentsPL.Add(StudentMapper(g));
            }
            return studentsPL;
        }
    }
}
