using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace VisualProgrammingProject
{
    partial class ViewAllStudents
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;


        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.listView1 = new System.Windows.Forms.ListView();
            this.StudentID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.FirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.LastName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Year = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Branch = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CGPA = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Campus = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();

            // 
            // listView1
            // 
            this.listView1.Alignment = System.Windows.Forms.ListViewAlignment.Default;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.StudentID,
            this.FirstName,
            this.LastName,
            this.Year,
            this.Branch,
            this.CGPA,
            this.Campus});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(0, 0);
            this.listView1.Margin = new System.Windows.Forms.Padding(16);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(777, 435);
            this.listView1.Sorting = System.Windows.Forms.SortOrder.Ascending;
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // StudentID
            // 
            this.StudentID.Text = "Student ID";
            this.StudentID.Width = 78;
            // 
            // FirstName
            // 
            this.FirstName.Text = "First Name";
            this.FirstName.Width = 128;
            // 
            // LastName
            // 
            this.LastName.Text = "Last Name";
            this.LastName.Width = 131;
            // 
            // Year
            // 
            this.Year.Text = "Year";
            this.Year.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.Year.Width = 40;
            // 
            // Branch
            // 
            this.Branch.Text = "Branch";
            this.Branch.Width = 182;
            // 
            // CGPA
            // 
            this.CGPA.Text = "CGPA";
            this.CGPA.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.CGPA.Width = 48;
            // 
            // Campus
            // 
            this.Campus.Text = "Campus";
            this.Campus.Width = 134;
            // 
            // ViewAllStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(777, 435);
            this.Controls.Add(this.listView1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ViewAllStudents";
            this.ShowIcon = false;
            this.Text = "ViewAllStudents";

            Console.WriteLine("Init form");

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
                listView1.Items.Add(new ListViewItem(items));
            }

            this.ResumeLayout(true);
        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader StudentID;
        private System.Windows.Forms.ColumnHeader FirstName;
        private System.Windows.Forms.ColumnHeader LastName;
        private System.Windows.Forms.ColumnHeader Year;
        private System.Windows.Forms.ColumnHeader Branch;
        private System.Windows.Forms.ColumnHeader CGPA;
        private System.Windows.Forms.ColumnHeader Campus;
    }
}