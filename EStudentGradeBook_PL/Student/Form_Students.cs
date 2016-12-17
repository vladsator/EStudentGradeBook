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
    public partial class Form_Students : Form
    {
        public Form_Students()
        {
            InitializeComponent();
        }

        private void button_add_Click(object sender, EventArgs e)
        {
            StudentPL student = new StudentPL(int.Parse(comboBox_groups.Text),textBox_name.Text,textBox_surname.Text,textBox_patronymic.Text, textBox_email.Text);
            StudentManager manager = new StudentManager();
            OutpMapping mapper = new OutpMapping();
            manager.AddStudent(mapper.StudentMapper(student));
            this.Close();
        }

        private void Form_Students_Load(object sender, EventArgs e)
        {
            GroupManager manager = new GroupManager();
            List<int> groupsId = manager.GetAllGroupIds();
            foreach (var g in groupsId)
            {
                comboBox_groups.Items.Add(g);
            }
        }
    }
}
