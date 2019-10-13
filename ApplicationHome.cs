using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;


namespace VisualProgrammingProject
{
    public partial class ApplicationHomeForm : Form
    {
        List<Student> studentsList;
        public ApplicationHomeForm()
        {
            InitializeComponent();
            // initialize the students list and fetch students from database
            studentsList = new List<Student>();
            FetchAndUpdateStudentsList();

        }

        public void FetchAndUpdateStudentsList()
        {
            // use DBRepo to get the list of students from the db
            studentsList = DBRepo.FetchAllStudents();

            //clear existing students and add them to the list
            studentsListView.Items.Clear();
            foreach (Student s in studentsList)
            {
                Console.WriteLine(s.ToString());
                string[] items = new string[7];
                items[0] = s.StudentId;
                items[1] = s.FirstName;
                items[2] = s.LastName;
                items[3] = s.Year.ToString();
                items[4] = s.Branch;
                items[5] = s.Cgpa.ToString();
                items[6] = s.Campus;
                // append the students to the listView
                studentsListView.Items.Add(new ListViewItem(items));
            }

            // Event handler to get more details of students
        }

        // TODO: Add methods update and delete student information
        private void StudentDetailsList_DoubleClick(object sender, EventArgs e)
        {
            ListViewItem s =  ((ListView)sender).SelectedItems[0];
           
            UpdateDeleteForm form = new UpdateDeleteForm(Int32.Parse(s.Text));
            DialogResult result =  form.ShowDialog();
           if (result == DialogResult.OK)
			{
				FetchAndUpdateStudentsList();
			} else
			{

			}
        }

        ///Event handler for the Add students button
        private void AddStudentDetailsButton_Click(object sender, EventArgs e)
        {
            AddStudentDetails form = new AddStudentDetails();
            DialogResult result = form.ShowDialog();
            // if the result was ok
            if (result == DialogResult.OK)
            {
                FetchAndUpdateStudentsList();
            } else
            {

            }
            form.Dispose();
        }

        private void ViewAllStudents_Load(object sender, EventArgs e)
        {

        }
    }
}
