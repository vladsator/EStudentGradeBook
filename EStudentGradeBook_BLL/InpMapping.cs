using AutoMapper;
using EStudentGradeBook_DAL;

namespace EStudentGradeBook_BLL
{
    class InpMapping
    {
        public StudentBLL StudentMapper(Student student)
        {
            return Mapper.Map<Student, StudentBLL>(student);
        }
    }
}
