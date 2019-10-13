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
    public partial class AddStudentDetails : Form
    {
        // all the methods mostly act as event listeners and updated the values stored in the 
        // student object created. When the add button is pressed this object is passed onto the
        // DBRepo function to add it to the database
        readonly private Student newStudent;
        public AddStudentDetails()
        {
            newStudent = new Student();
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label4_Click(object sender, EventArgs e)
        {

        }

        private void StudendIDBoxTextChangedEvent(object sender, EventArgs e)
        {
            this.newStudent.StudentId = ((TextBox)sender).Text;
        }

        private void Label9_Click(object sender, EventArgs e)
        {

        }

        private void Branch_SelectedIndexChanged(object sender, EventArgs e)
        {
            Console.WriteLine("Branch Index changed");
            this.newStudent.Branch = ((ComboBox)sender).SelectedItem.ToString();
            Console.WriteLine(newStudent);
        }

        private void Campus_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.newStudent.Campus = ((ComboBox)sender).SelectedItem.ToString();
            Console.WriteLine(this.newStudent);
        }

        private void FirstNameBox_TextChanged(object sender, EventArgs e)
        {
            this.newStudent.FirstName = ((TextBox)sender).Text;
        }

        private void LastNameBox_TextChanged(object sender, EventArgs e)
        {
            this.newStudent.LastName = ((TextBox)sender).Text;
        }

        private void CgpaBox_TextChanged(object sender, EventArgs e)
        {
            string cgpaText = ((TextBox)sender).Text;
            double result = 0.0;
            if ((cgpaText != "") && ((cgpaText.Contains(",")) || !Double.TryParse(cgpaText, out result) || result > 10 || result < 0.0))
            {
                MessageBox.Show("This is not a valid CGPA, Enter valid CGPA value");
                ((TextBox)sender).Text = "";
            }
            else
            {
                this.newStudent.Cgpa = result;
            }
        }

        private void AddStudentButtonClick(object sender, EventArgs e)
        {
            this.SaveStudentButton.DialogResult = DialogResult.None;
            this.CancelButton.DialogResult = DialogResult.None;
            this.DialogResult = DialogResult.None;
            if (this.newStudent.ValidateEntries())
            {
                bool result = DBRepo.AddStudent(this.newStudent);
                if (!result)
                {
                    MessageBox.Show("Student already exists");
                }
                else
                {
                    this.SaveStudentButton.DialogResult = DialogResult.OK;
                    this.CancelButton.DialogResult = DialogResult.OK;
                    this.DialogResult = DialogResult.OK;
                    MessageBox.Show("User added successfully");
                }
            }
            else
            {
                MessageBox.Show("Please fill all the values");
            }
        }

        private void YearBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            this.newStudent.Year = Int32.Parse(((ComboBox)sender).SelectedItem.ToString());
            Console.WriteLine(this.newStudent);
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Label11_Click(object sender, EventArgs e)
        {

        }
    }
}
