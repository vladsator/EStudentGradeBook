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
    public partial class StudentManager : Form
    {
        public StudentManager()
        {
            InitializeComponent();
        }

        private void StudentManager_Load(object sender, EventArgs e)
        {
            dataGridView_students.RowHeadersVisible = false;
            dataGridView_students.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "student_id",
                HeaderText = "№",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
     
            });
            dataGridView_students.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "student_group_id",
                HeaderText = "Group №",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            });
            dataGridView_students.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "student_surname",
                HeaderText = "Surname",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });
            dataGridView_students.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "student_name",
                HeaderText = "Name",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill
            });
            dataGridView_students.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "student_secondname",
                HeaderText = "Secondname",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill                
            });
            dataGridView_students.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "student_email",
                HeaderText = "Email",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            });
            var StudentDM = new StudentDataManager();
            dataGridView_students.DataSource = StudentDM.GetDataList();
        }

        private void button_addstudent_Click(object sender, EventArgs e)
        {
            var newForm = new AddStudent();
            newForm.Show();
        }

        private void StudentManager_Activated(object sender, EventArgs e)
        {
            var StudentDM = new StudentDataManager();
            dataGridView_students.DataSource = StudentDM.GetDataList();
        }
    }
}
