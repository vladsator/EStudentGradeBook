using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EStudentGradeBook_BLL;

namespace EStudentGradeBook_PL
{
    public partial class FormLessons : Form
    {
        LessonManager _lessonManager = new LessonManager();

        public FormLessons()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            LessonPL lesson = new LessonPL();
            lesson.lesson_name = textBox1.Text;
            _lessonManager.AddLesson(OutpMapping.LessonMapper(lesson));
        }
    }
}
