using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace EStudentGradeBook_PL
{
    public partial class Form_main : Form
    {
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
            new Form_Students().Show();
        }
    }
}
