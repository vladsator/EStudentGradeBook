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
using EStudentGradeBook_BLL.DTO;

namespace EStudentGradeBook_PL
{
    public partial class AddStudent : Form
    {
        public AddStudent()
        {
            InitializeComponent();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            var student = new StudentDTO()
            {
                student_email = textBox_email.Text,
                student_group_id = int.Parse(textBox_groupid.Text),
                student_surname = textBox_surname.Text,
                student_name = textBox_name.Text,
                student_secondname = textBox_secondname.Text
            };
            var StudentDM = new StudentDataManager();
            StudentDM.Add(student);
            Close();
        }
    }
}
