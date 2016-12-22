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
    public partial class MarkAdder : Form
    {
        StudentManager studentManager = new StudentManager();
        readonly GroupManager _groupManager = new GroupManager();
        readonly LessonManager _lessonManager = new LessonManager();
        InpMapping _inpMapper = new InpMapping();

        public MarkAdder()
        {
            InitializeComponent();
        }

        private void MarkAdder_Load(object sender, EventArgs e)
        {
            comboBox_group.DataSource = _groupManager.GetAllGroupIds();
            comboBox_lesson.DataSource = _inpMapper.LessonListMapper(_lessonManager.GetLessonList());
        }

        private void comboBox_group_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox_student.DataSource = _inpMapper.StudentListMapper(studentManager.FilterStudent(comboBox_group.Text));

        }

        private void comboBox_lesson_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
