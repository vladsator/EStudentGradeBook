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

namespace EStudentGradeBook_PL.Group
{
    public partial class Form_addGroup : Form
    {
        
        GroupPL _groupPl = new GroupPL();
        private StudentManager _studentManager;
        InpMapping inpMapper = new InpMapping();
        OutpMapping _outpMapping = new OutpMapping();
        private List<StudentPL> _allStudentList;
        private GroupManager _groupManager;
        public Form_addGroup()
        {
            InitializeComponent();
            _studentManager = new StudentManager();
            _groupManager = new GroupManager();
            _allStudentList = inpMapper.StudentListMapper(_studentManager.GetStudentList());
        }

        private void Form_addGroup_Load(object sender, EventArgs e)
        {
            foreach (var s in _allStudentList)
            {
                listBox_allStudents.Items.Add(s.ToString());
            }
        }

        private void button_addSelectedStudent_Click(object sender, EventArgs e)
        {
            if (listBox_allStudents.SelectedItem == null)
            {
                return;
            }

            StudentPL tempStudent =
                _allStudentList.Find(s => listBox_allStudents.SelectedItem.ToString().Contains(s.student_surname + " " + s.student_name + " " + s.student_secondname));
            _groupPl.students.Add(tempStudent);
            _allStudentList.Remove(tempStudent);
            listBox_thisGroupStudents.Items.Add(listBox_allStudents.SelectedItem);
            listBox_allStudents.Items.Remove(listBox_allStudents.SelectedItem);
            if (listBox_allStudents != null)
            {
                listBox_allStudents.SelectedItem = listBox_allStudents.Items[listBox_allStudents.SelectedIndex + 1];
            }
        }

        private void button_addAllStudents_Click(object sender, EventArgs e)
        {
            if (listBox_thisGroupStudents.SelectedItem == null)
            {
                return;
            }
            StudentPL tempStudent =
                _groupPl.students.Find(s => listBox_thisGroupStudents.SelectedItem.ToString().Contains(s.student_surname + " " + s.student_name + " " + s.student_secondname));
            _allStudentList.Add(tempStudent);
            _groupPl.students.Remove(tempStudent);
            listBox_allStudents.Items.Add(listBox_thisGroupStudents.SelectedItem);
            int prevIndex = listBox_thisGroupStudents.SelectedIndex;
            listBox_thisGroupStudents.Items.Remove(listBox_thisGroupStudents.SelectedItem);
            if (listBox_thisGroupStudents.Items.Count != 0)
            {
                if (listBox_thisGroupStudents.Items[listBox_thisGroupStudents.SelectedIndex + 1] != null)
                {
                    listBox_thisGroupStudents.SelectedItem = listBox_thisGroupStudents.Items[listBox_thisGroupStudents.SelectedIndex + 1];
                }
                else
                {
                    listBox_thisGroupStudents.SelectedItem = listBox_thisGroupStudents.Items[listBox_thisGroupStudents.SelectedIndex];
                }
            }
        }

        private void button_ok_Click(object sender, EventArgs e)
        {
            _groupPl.group_cource = int.Parse(comboBox_cource.Text);
            _groupManager.AddGroup(_outpMapping.GroupMapper(_groupPl));
        }
    }
}
