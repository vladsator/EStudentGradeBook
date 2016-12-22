using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EStudentGradeBook_DAL;

namespace EStudentGradeBook_BLL
{
    public class LessonManager
    {
        readonly OutpMapping _outMapper = new OutpMapping();
        readonly InpMapping _inMaper = new InpMapping();
        LessonDataManager _lessonDataManager = new LessonDataManager();

        public void AddLesson(LessonBLL lesson)
        {
            _lessonDataManager.Add(OutpMapping.LessonMapper(lesson));    
        }
    }
}
