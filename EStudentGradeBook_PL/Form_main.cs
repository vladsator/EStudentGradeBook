using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Metadata.Edm;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using EStudentGradeBook_BLL;
using EStudentGradeBook_PL.Group;
using EStudentGradeBook_PL.Student;

namespace EStudentGradeBook_PL
{
    public partial class Form_main : Form
    {
        StudentManager studentManager = new StudentManager();

        public Form_main()
        {
            InitializeComponent();
        }

        private void button_groupManager_Click(object sender, EventArgs e)
        {
            new FormGroup().Show();
        }

        private void button_addStudent_Click(object sender, EventArgs e)
        {
            new FormStudents().Show();
        }

        private void Form_main_Load(object sender, EventArgs e)
        {
            dataGridView_allinfo.DataSource = studentManager.GetStudentList();
        }

        private void button1_Click(object sender, EventArgs e)
        {         
            dataGridView_allinfo.DataSource = studentManager.GetStudentList();
        }
    }
}
