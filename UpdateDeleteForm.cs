using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VisualProgrammingProject
{
    public partial class UpdateDeleteForm : Form
    {
        Student student;
        public UpdateDeleteForm(String studentId)
        {
            Student fetchedStudent = DBRepo.FetchStudentById(studentId);
            Debug.WriteLine(fetchedStudent.ToString());
            this.student = fetchedStudent;
			InitializeComponent();
			studentIDBox.Text = fetchedStudent.StudentId;
			firstNameBox.Text = fetchedStudent.FirstName;
			lastNameBox.Text = fetchedStudent.LastName;
			branchBox.SelectedItem = fetchedStudent.Branch;
			campusBox.SelectedItem = fetchedStudent.Campus;
			yearBox.SelectedItem = fetchedStudent.Year;
			cgpaBox.Text = fetchedStudent.Cgpa.ToString();
			yearBox.Text = fetchedStudent.Year.ToString();
        }

        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void UpdateDeleteForm_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

			this.UpdateDetailsButton.DialogResult = DialogResult.None;
			this.CancelButton.DialogResult = DialogResult.None;
			this.DialogResult = DialogResult.None;
			if (this.student.ValidateEntries())
			{
				bool result = DBRepo.UpdateStudentData(stud: this.student);
				if (!result)
				{
					MessageBox.Show("Failed to update student");
				}
				else
				{
					this.UpdateDetailsButton.DialogResult = DialogResult.OK;
					this.CancelButton.DialogResult = DialogResult.OK;
					this.DialogResult = DialogResult.OK;
					MessageBox.Show("User updated successfully");
				}
			}
			else {
				MessageBox.Show("Please fill all the values");
   }
		}

		private void studentIDBox_TextChanged(object sender, EventArgs e)
		{
			student.StudentId = ((TextBox)sender).Text;
			Debug.WriteLine(student.StudentId);
		}

		private void firstNameBox_TextChanged(object sender, EventArgs e)
		{
			student.FirstName = ((TextBox)sender).Text;
			Debug.WriteLine(student.FirstName);
		}

		private void lastNameBox_TextChanged(object sender, EventArgs e)
		{
			student.LastName = ((TextBox)sender).Text;
			Debug.WriteLine(student.LastName);
		}

		private void branchBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			student.Branch = ((ComboBox)sender).SelectedItem.ToString();
			Debug.WriteLine(student.Branch);
		}

		private void campusBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			student.Campus = ((ComboBox)sender).SelectedItem.ToString();
			Debug.WriteLine(student.Campus);
		}

		private void yearBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			student.Year = Int32.Parse(((ComboBox)sender).SelectedItem.ToString());
			Debug.WriteLine(student.Year);
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
				this.student.Cgpa = result;
			}
		}

		private void DeleteButton_Click(object sender, EventArgs e)
		{
			DialogResult result = MessageBox.Show(text: "Are you sure you want to delete student?", caption: "This will not be reversible", buttons: MessageBoxButtons.OKCancel);
			this.UpdateDetailsButton.DialogResult = DialogResult.None;
			this.CancelButton.DialogResult = DialogResult.None;
			this.DialogResult = DialogResult.None;
			if (result == DialogResult.OK)
			{
				bool delresult = DBRepo.DeleteStudent(stud: this.student); 
				if (!delresult)
				{
					MessageBox.Show("Failed to delete student");
				} else
				{
					MessageBox.Show("Deleted successfully!");
					this.UpdateDetailsButton.DialogResult = DialogResult.OK;
					this.CancelButton.DialogResult = DialogResult.OK;
					this.DialogResult = DialogResult.OK;
				}
			} else
			{

			}
		}

		private void CancelButton_Click(object sender, EventArgs e)
		{
			this.DialogResult = DialogResult.OK;
		}
	}
}
