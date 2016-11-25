using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EStudentGradeBook_BLL.DTO;
using EStudentGradeBook_DAL;
using AutoMapper;

namespace EStudentGradeBook_BLL
{
    public class StudentDataManager : DataManager
    {
        public override void Add(object obj)
        {
            Student student = DataMapper(obj as StudentDTO) as Student;
            EStudentGradeBookDBContext context = new EStudentGradeBookDBContext();
            context.Students.Add(student);
            context.SaveChanges();
        }

        public override void Remove(object obj)
        {
            throw new NotImplementedException();
        }

        public override void Update(object destobj, object sourceobj)
        {
            throw new NotImplementedException();
        }

        protected override object DataMapper(object obj)
        {
            var config = new MapperConfiguration(cfg => {
                cfg.CreateMap<StudentDTO, Student>();
            });
            var mapper = config.CreateMapper();
            return mapper.Map<StudentDTO, Student>(obj as StudentDTO);
        }

        public override object GetDataList()
        {
            var context = new EStudentGradeBookDBContext();
            var query =  from s in context.Students.ToList()
                select new StudentDTO()
                {
                    student_id = s.student_id ,
                    student_email = s.student_email,
                    student_group_id = s.student_group_id,
                    student_name = s.student_name,
                    student_surname = s.student_surname,
                    student_secondname = s.student_secondname
                };
            return query.ToList();
        }
    }
}
