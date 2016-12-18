using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Windows.Forms;
using EStudentGradeBook_BLL;

namespace EStudentGradeBook_PL.Student
{
    public partial class FormStudents : Form
    {
        readonly StudentManager _studentManager = new StudentManager();
        readonly GroupManager _groupManager = new GroupManager();
        readonly OutpMapping _outMapper = new OutpMapping();

        public FormStudents()
        {
            InitializeComponent();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            StudentPL student = new StudentPL(int.Parse(comboBox_groups.Text),textBox_name.Text,textBox_surname.Text,textBox_patronymic.Text, textBox_email.Text);
            try
            {
                _studentManager.AddStudent(_outMapper.StudentMapper(student));
                Close();
            }
            catch (DbUpdateException)
            {
                label_error.Visible = true;
            }            
        }

        private void Form_Students_Load(object sender, EventArgs e)
        {            
            List<int> groupsId = _groupManager.GetAllGroupIds();
            foreach (var g in groupsId)
            {
                comboBox_groups.Items.Add(g);
            }
        }
    }
}
