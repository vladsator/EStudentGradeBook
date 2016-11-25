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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            var StudentDM = new StudentDataManager();
            dataGridView_students.AutoSize = AutoSize;
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
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            });
            dataGridView_students.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "student_name",
                HeaderText = "Name",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            });
            dataGridView_students.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "student_secondname",
                HeaderText = "Secondname",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            });
            dataGridView_students.Columns.Add(new DataGridViewTextBoxColumn
            {
                DataPropertyName = "student_email",
                HeaderText = "Email",
                AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells
            });
            dataGridView_students.DataSource = StudentDM.GetDataList();

        }
    }
}
