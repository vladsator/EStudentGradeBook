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
        List<LessonBLL> _lessons = new List<LessonBLL>();
        readonly OutpMapping _outMapper = new OutpMapping();
        readonly InpMapping _inMaper = new InpMapping();
        LessonDataManager _lessonDataManager = new LessonDataManager();

        public LessonManager()
        {
            _lessons = _inMaper.LessonListMapper(_lessonDataManager.GetList());
        }

        public void AddLesson(LessonBLL lesson)
        {
            _lessonDataManager.Add(OutpMapping.LessonMapper(lesson));    
        }

        public List<LessonBLL> GetLessonList()
        {
            return _lessons;
        }
    }
}
