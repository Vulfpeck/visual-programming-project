namespace VisualProgrammingProject
{
    partial class AddStudentDetails
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label9 = new System.Windows.Forms.Label();
            this.lastNameBox = new System.Windows.Forms.TextBox();
            this.firstNameBox = new System.Windows.Forms.TextBox();
            this.studentIDBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cgpaBox = new System.Windows.Forms.TextBox();
            this.yearBox = new System.Windows.Forms.ComboBox();
            this.campusBox = new System.Windows.Forms.ComboBox();
            this.branchBox = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 59);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student ID";
            this.label1.Click += new System.EventHandler(this.Label1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "First Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 158);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Last Name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(11, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(29, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Year";
            this.label4.Click += new System.EventHandler(this.Label4_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(176, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "CGPA";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(11, 57);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Branch";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(11, 109);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Campus";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(68, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 13);
            this.label8.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.lastNameBox);
            this.groupBox1.Controls.Add(this.firstNameBox);
            this.groupBox1.Controls.Add(this.studentIDBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(12, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(298, 219);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Basic Details";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(6, 29);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(216, 13);
            this.label9.TabIndex = 10;
            this.label9.Text = "Enter general details, all fields are mandatory";
            this.label9.Click += new System.EventHandler(this.Label9_Click);
            // 
            // lastNameBox
            // 
            this.lastNameBox.Location = new System.Drawing.Point(9, 174);
            this.lastNameBox.Name = "lastNameBox";
            this.lastNameBox.Size = new System.Drawing.Size(283, 20);
            this.lastNameBox.TabIndex = 12;
            this.lastNameBox.TextChanged += new System.EventHandler(this.LastNameBox_TextChanged);
            // 
            // firstNameBox
            // 
            this.firstNameBox.Location = new System.Drawing.Point(9, 126);
            this.firstNameBox.Name = "firstNameBox";
            this.firstNameBox.Size = new System.Drawing.Size(283, 20);
            this.firstNameBox.TabIndex = 11;
            this.firstNameBox.TextChanged += new System.EventHandler(this.FirstNameBox_TextChanged);
            // 
            // studentIDBox
            // 
            this.studentIDBox.Location = new System.Drawing.Point(9, 75);
            this.studentIDBox.Name = "studentIDBox";
            this.studentIDBox.Size = new System.Drawing.Size(283, 20);
            this.studentIDBox.TabIndex = 10;
            this.studentIDBox.TextChanged += new System.EventHandler(this.StudendIDBoxTextChangedEvent);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cgpaBox);
            this.groupBox2.Controls.Add(this.yearBox);
            this.groupBox2.Controls.Add(this.campusBox);
            this.groupBox2.Controls.Add(this.branchBox);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(316, 22);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(299, 218);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            // 
            // cgpaBox
            // 
            this.cgpaBox.Location = new System.Drawing.Point(179, 173);
            this.cgpaBox.Name = "cgpaBox";
            this.cgpaBox.Size = new System.Drawing.Size(100, 20);
            this.cgpaBox.TabIndex = 17;
            this.cgpaBox.TextChanged += new System.EventHandler(this.CgpaBox_TextChanged);
            // 
            // yearBox
            // 
            this.yearBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Append;
            this.yearBox.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.yearBox.DisplayMember = "4";
            this.yearBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.yearBox.FormattingEnabled = true;
            this.yearBox.ItemHeight = 13;
            this.yearBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
            this.yearBox.Location = new System.Drawing.Point(9, 172);
            this.yearBox.Name = "yearBox";
            this.yearBox.Size = new System.Drawing.Size(113, 21);
            this.yearBox.Sorted = true;
            this.yearBox.TabIndex = 16;
            this.yearBox.SelectedIndexChanged += new System.EventHandler(this.YearBox_SelectedIndexChanged);
            // 
            // campusBox
            // 
            this.campusBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.campusBox.FormattingEnabled = true;
            this.campusBox.Items.AddRange(new object[] {
            "Kattankulathur",
            "Ramapuram",
            "NCR"});
            this.campusBox.Location = new System.Drawing.Point(9, 125);
            this.campusBox.Name = "campusBox";
            this.campusBox.Size = new System.Drawing.Size(284, 21);
            this.campusBox.TabIndex = 15;
            this.campusBox.SelectedIndexChanged += new System.EventHandler(this.Campus_SelectedIndexChanged);
            // 
            // branchBox
            // 
            this.branchBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.branchBox.FormattingEnabled = true;
            this.branchBox.Items.AddRange(new object[] {
            "CSE",
            "Software",
            "IT"});
            this.branchBox.Location = new System.Drawing.Point(9, 73);
            this.branchBox.Name = "branchBox";
            this.branchBox.Size = new System.Drawing.Size(284, 21);
            this.branchBox.TabIndex = 14;
            this.branchBox.SelectedIndexChanged += new System.EventHandler(this.Branch_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 28);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(228, 13);
            this.label10.TabIndex = 13;
            this.label10.Text = "Enter education details, all fields are mandatory";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(495, 266);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(120, 23);
            this.button1.TabIndex = 10;
            this.button1.Text = "Save Student";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.AddStudentButtonClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(414, 266);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 11;
            this.button2.Text = "Cancel";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // AddStudentDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(627, 301);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.groupBox2);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddStudentDetails";
            this.ShowIcon = false;
            this.Text = "Add new student to system";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox studentIDBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox lastNameBox;
        private System.Windows.Forms.TextBox firstNameBox;
        private System.Windows.Forms.TextBox cgpaBox;
        private System.Windows.Forms.ComboBox yearBox;
        private System.Windows.Forms.ComboBox campusBox;
        private System.Windows.Forms.ComboBox branchBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}