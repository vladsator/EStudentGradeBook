using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EStudentGradeBook_DAL;

namespace EStudentGradeBook_BLL
{
    public class StudentManager
    {
        static List<StudentBLL> _studentList = new List<StudentBLL>();
        readonly StudentDataManager _studentDataManager = new StudentDataManager();
        readonly OutpMapping _outMapper = new OutpMapping();
        readonly InpMapping _inMaper = new InpMapping();

        public void AddStudent(StudentBLL student)
        {                      
            _studentDataManager.Add(_outMapper.StudentMapper(student));    
        }

        public List<StudentBLL> GetStudentList()
        {
            _studentList = _inMaper.StudentListMapper(_studentDataManager.GetList());
            return _studentList;
        }
    }
}
