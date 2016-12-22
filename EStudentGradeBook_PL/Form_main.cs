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
        readonly GroupManager _groupManager = new GroupManager();

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

            List<int> groupsId = _groupManager.GetAllGroupIds();
            foreach (var g in groupsId)
            {
                comboBox_groups.Items.Add(g);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {        
             
            dataGridView_allinfo.DataSource = studentManager.GetStudentList();
        }

        private void button_search_Click(object sender, EventArgs e)
        {
            if (textBox_name.Text != "")
            {
                dataGridView_allinfo.DataSource = studentManager.FilterStudentByName(textBox_name.Text);
            }
            else
            {
                dataGridView_allinfo.DataSource = studentManager.GetStudentList();
            }
        }

        private void comboBox_groups_SelectedIndexChanged(object sender, EventArgs e)
        {
            if ((int) comboBox_groups.SelectedItem != 0)
            {
                dataGridView_allinfo.DataSource = studentManager.FilterStudent(comboBox_groups.Text);
            }           
        }

        private void button_markManager_Click(object sender, EventArgs e)
        {
            new MarkAdder().Show();
        }
    }
}
