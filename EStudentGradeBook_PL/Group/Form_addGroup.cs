﻿using System;
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
        private List<StudentPL> _allStudentList;
        public Form_addGroup()
        {
            InitializeComponent();
            _studentManager = new StudentManager();
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
                _allStudentList.Find(s =>listBox_allStudents.SelectedItem.ToString().Contains(s.student_surname + " " + s.student_name + " " + s.student_secondname));
            _groupPl.students.Add(tempStudent);
            _allStudentList.Remove(tempStudent);
            listBox_thisGroupStudents.Items.Add(listBox_allStudents.SelectedItem);
            listBox_allStudents.Items.Remove(listBox_allStudents.SelectedItem);
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
            listBox_thisGroupStudents.Items.Remove(listBox_thisGroupStudents.SelectedItem);
            
        }
    }
}
