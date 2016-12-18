using System;
using System.Windows.Forms;
using EStudentGradeBook_BLL;

namespace EStudentGradeBook_PL.Group
{
    public partial class FormGroup : Form
    {
        readonly GroupManager _groupManager = new GroupManager();

        public FormGroup()
        {
            InitializeComponent();
        }

        private void button_addGroup_Click(object sender, EventArgs e)
        {
            new Form_addGroup().Show();
        }

        private void FormGroup_Load(object sender, EventArgs e)
        {
            dataGridView_groups.DataSource = _groupManager.GetGroupList();
        }
    }
}
