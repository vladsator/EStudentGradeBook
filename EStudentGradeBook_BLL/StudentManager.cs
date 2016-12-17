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
        public void AddStudent(StudentBLL student)
        {
            StudentDataManager dataManager = new StudentDataManager();
            OutpMapping mapper = new OutpMapping();
            dataManager.Add(mapper.StudentMapper(student));    
        }

        public object GetStudentList()
        {
            StudentDataManager dataManager = new StudentDataManager();
            return dataManager.GetList();
        }
    }
}
