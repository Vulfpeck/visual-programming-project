using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisualProgrammingProject
{
    public partial class InitialForm : Form
    {
        public InitialForm()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            ViewAllStudents viewStudentsForm = new ViewAllStudents();
            viewStudentsForm.Show();
        }

        private void AddStudentButton_Click(object sender, EventArgs e)
        {
            AddStudentDetails form = new AddStudentDetails();
            form.ShowDialog();
        }
    }
}
