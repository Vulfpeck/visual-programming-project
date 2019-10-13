namespace VisualProgrammingProject
{
    partial class UpdateDeleteForm
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
			this.splitContainer1 = new System.Windows.Forms.SplitContainer();
			this.UpdatStudentDetailsLabel = new System.Windows.Forms.Label();
			this.DeleteButton = new System.Windows.Forms.Button();
			this.UpdateDetailsButton = new System.Windows.Forms.Button();
			this.CancelButton = new System.Windows.Forms.Button();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label9 = new System.Windows.Forms.Label();
			this.lastNameBox = new System.Windows.Forms.TextBox();
			this.firstNameBox = new System.Windows.Forms.TextBox();
			this.studentIDBox = new System.Windows.Forms.TextBox();
			this.label1 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label3 = new System.Windows.Forms.Label();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.cgpaBox = new System.Windows.Forms.TextBox();
			this.yearBox = new System.Windows.Forms.ComboBox();
			this.campusBox = new System.Windows.Forms.ComboBox();
			this.branchBox = new System.Windows.Forms.ComboBox();
			this.label10 = new System.Windows.Forms.Label();
			this.label5 = new System.Windows.Forms.Label();
			this.label7 = new System.Windows.Forms.Label();
			this.label4 = new System.Windows.Forms.Label();
			this.label6 = new System.Windows.Forms.Label();
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
			this.splitContainer1.Panel1.SuspendLayout();
			this.splitContainer1.Panel2.SuspendLayout();
			this.splitContainer1.SuspendLayout();
			this.groupBox1.SuspendLayout();
			this.groupBox2.SuspendLayout();
			this.SuspendLayout();
			// 
			// splitContainer1
			// 
			this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.splitContainer1.Font = new System.Drawing.Font("Segoe MDL2 Assets", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.splitContainer1.IsSplitterFixed = true;
			this.splitContainer1.Location = new System.Drawing.Point(0, 0);
			this.splitContainer1.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
			this.splitContainer1.Name = "splitContainer1";
			this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
			// 
			// splitContainer1.Panel1
			// 
			this.splitContainer1.Panel1.BackColor = System.Drawing.Color.Black;
			this.splitContainer1.Panel1.Controls.Add(this.UpdatStudentDetailsLabel);
			this.splitContainer1.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel1_Paint);
			this.splitContainer1.Panel1MinSize = 10;
			// 
			// splitContainer1.Panel2
			// 
			this.splitContainer1.Panel2.Controls.Add(this.DeleteButton);
			this.splitContainer1.Panel2.Controls.Add(this.UpdateDetailsButton);
			this.splitContainer1.Panel2.Controls.Add(this.CancelButton);
			this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
			this.splitContainer1.Panel2.Controls.Add(this.groupBox2);
			this.splitContainer1.Size = new System.Drawing.Size(731, 451);
			this.splitContainer1.SplitterDistance = 110;
			this.splitContainer1.SplitterWidth = 8;
			this.splitContainer1.TabIndex = 0;
			// 
			// UpdatStudentDetailsLabel
			// 
			this.UpdatStudentDetailsLabel.AutoSize = true;
			this.UpdatStudentDetailsLabel.BackColor = System.Drawing.Color.Black;
			this.UpdatStudentDetailsLabel.Font = new System.Drawing.Font("Segoe UI Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.UpdatStudentDetailsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
			this.UpdatStudentDetailsLabel.Location = new System.Drawing.Point(19, 48);
			this.UpdatStudentDetailsLabel.Margin = new System.Windows.Forms.Padding(0);
			this.UpdatStudentDetailsLabel.Name = "UpdatStudentDetailsLabel";
			this.UpdatStudentDetailsLabel.Size = new System.Drawing.Size(321, 37);
			this.UpdatStudentDetailsLabel.TabIndex = 0;
			this.UpdatStudentDetailsLabel.Text = "Update Student Details";
			this.UpdatStudentDetailsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// DeleteButton
			// 
			this.DeleteButton.BackColor = System.Drawing.Color.White;
			this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.DeleteButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.DeleteButton.ForeColor = System.Drawing.Color.Red;
			this.DeleteButton.Location = new System.Drawing.Point(16, 281);
			this.DeleteButton.Name = "DeleteButton";
			this.DeleteButton.Size = new System.Drawing.Size(126, 23);
			this.DeleteButton.TabIndex = 16;
			this.DeleteButton.Text = "Delete Student";
			this.DeleteButton.UseVisualStyleBackColor = false;
			this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
			// 
			// UpdateDetailsButton
			// 
			this.UpdateDetailsButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.UpdateDetailsButton.Location = new System.Drawing.Point(580, 281);
			this.UpdateDetailsButton.Name = "UpdateDetailsButton";
			this.UpdateDetailsButton.Size = new System.Drawing.Size(139, 23);
			this.UpdateDetailsButton.TabIndex = 15;
			this.UpdateDetailsButton.Text = "Update Details";
			this.UpdateDetailsButton.UseVisualStyleBackColor = true;
			this.UpdateDetailsButton.Click += new System.EventHandler(this.button2_Click);
			// 
			// CancelButton
			// 
			this.CancelButton.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.CancelButton.Location = new System.Drawing.Point(499, 281);
			this.CancelButton.Name = "CancelButton";
			this.CancelButton.Size = new System.Drawing.Size(75, 23);
			this.CancelButton.TabIndex = 14;
			this.CancelButton.Text = "Cancel";
			this.CancelButton.UseVisualStyleBackColor = true;
			this.CancelButton.Click += new System.EventHandler(this.CancelButton_Click);
			// 
			// groupBox1
			// 
			this.groupBox1.BackColor = System.Drawing.Color.White;
			this.groupBox1.Controls.Add(this.label9);
			this.groupBox1.Controls.Add(this.lastNameBox);
			this.groupBox1.Controls.Add(this.firstNameBox);
			this.groupBox1.Controls.Add(this.studentIDBox);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.groupBox1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.groupBox1.Location = new System.Drawing.Point(16, 8);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(348, 252);
			this.groupBox1.TabIndex = 12;
			this.groupBox1.TabStop = false;
			this.groupBox1.Text = "Basic Details";
			// 
			// label9
			// 
			this.label9.AutoSize = true;
			this.label9.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label9.Location = new System.Drawing.Point(7, 33);
			this.label9.Name = "label9";
			this.label9.Size = new System.Drawing.Size(242, 15);
			this.label9.TabIndex = 10;
			this.label9.Text = "Enter general details, all fields are mandatory";
			// 
			// lastNameBox
			// 
			this.lastNameBox.Location = new System.Drawing.Point(10, 201);
			this.lastNameBox.Name = "lastNameBox";
			this.lastNameBox.Size = new System.Drawing.Size(329, 23);
			this.lastNameBox.TabIndex = 12;
			this.lastNameBox.TextChanged += new System.EventHandler(this.lastNameBox_TextChanged);
			// 
			// firstNameBox
			// 
			this.firstNameBox.Location = new System.Drawing.Point(10, 145);
			this.firstNameBox.Name = "firstNameBox";
			this.firstNameBox.Size = new System.Drawing.Size(329, 23);
			this.firstNameBox.TabIndex = 11;
			this.firstNameBox.TextChanged += new System.EventHandler(this.firstNameBox_TextChanged);
			// 
			// studentIDBox
			// 
			this.studentIDBox.Enabled = false;
			this.studentIDBox.Location = new System.Drawing.Point(10, 87);
			this.studentIDBox.Name = "studentIDBox";
			this.studentIDBox.Size = new System.Drawing.Size(329, 23);
			this.studentIDBox.TabIndex = 10;
			this.studentIDBox.TextChanged += new System.EventHandler(this.studentIDBox_TextChanged);
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(14, 68);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(65, 15);
			this.label1.TabIndex = 0;
			this.label1.Text = "Student ID";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(14, 127);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(64, 15);
			this.label2.TabIndex = 1;
			this.label2.Text = "First Name";
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(14, 182);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(63, 15);
			this.label3.TabIndex = 2;
			this.label3.Text = "Last Name";
			// 
			// groupBox2
			// 
			this.groupBox2.BackColor = System.Drawing.Color.White;
			this.groupBox2.Controls.Add(this.cgpaBox);
			this.groupBox2.Controls.Add(this.yearBox);
			this.groupBox2.Controls.Add(this.campusBox);
			this.groupBox2.Controls.Add(this.branchBox);
			this.groupBox2.Controls.Add(this.label10);
			this.groupBox2.Controls.Add(this.label5);
			this.groupBox2.Controls.Add(this.label7);
			this.groupBox2.Controls.Add(this.label4);
			this.groupBox2.Controls.Add(this.label6);
			this.groupBox2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
			this.groupBox2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
			this.groupBox2.Location = new System.Drawing.Point(370, 10);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(349, 250);
			this.groupBox2.TabIndex = 13;
			this.groupBox2.TabStop = false;
			this.groupBox2.Text = "Education Details";
			this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
			// 
			// cgpaBox
			// 
			this.cgpaBox.Location = new System.Drawing.Point(183, 198);
			this.cgpaBox.Name = "cgpaBox";
			this.cgpaBox.Size = new System.Drawing.Size(158, 23);
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
			this.yearBox.IntegralHeight = false;
			this.yearBox.ItemHeight = 15;
			this.yearBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4"});
			this.yearBox.Location = new System.Drawing.Point(10, 198);
			this.yearBox.Name = "yearBox";
			this.yearBox.Size = new System.Drawing.Size(167, 23);
			this.yearBox.Sorted = true;
			this.yearBox.TabIndex = 16;
			this.yearBox.SelectedIndexChanged += new System.EventHandler(this.yearBox_SelectedIndexChanged);
			// 
			// campusBox
			// 
			this.campusBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.campusBox.FormattingEnabled = true;
			this.campusBox.IntegralHeight = false;
			this.campusBox.Items.AddRange(new object[] {
            "Kattankulathur",
            "Ramapuram",
            "NCR"});
			this.campusBox.Location = new System.Drawing.Point(10, 144);
			this.campusBox.Name = "campusBox";
			this.campusBox.Size = new System.Drawing.Size(331, 23);
			this.campusBox.TabIndex = 15;
			this.campusBox.SelectedIndexChanged += new System.EventHandler(this.campusBox_SelectedIndexChanged);
			// 
			// branchBox
			// 
			this.branchBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
			this.branchBox.FormattingEnabled = true;
			this.branchBox.IntegralHeight = false;
			this.branchBox.Items.AddRange(new object[] {
            "CSE",
            "Software",
            "IT"});
			this.branchBox.Location = new System.Drawing.Point(10, 84);
			this.branchBox.Name = "branchBox";
			this.branchBox.Size = new System.Drawing.Size(331, 23);
			this.branchBox.TabIndex = 14;
			this.branchBox.SelectedIndexChanged += new System.EventHandler(this.branchBox_SelectedIndexChanged);
			// 
			// label10
			// 
			this.label10.AutoSize = true;
			this.label10.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
			this.label10.Location = new System.Drawing.Point(7, 32);
			this.label10.Name = "label10";
			this.label10.Size = new System.Drawing.Size(256, 15);
			this.label10.TabIndex = 13;
			this.label10.Text = "Enter education details, all fields are mandatory";
			// 
			// label5
			// 
			this.label5.AutoSize = true;
			this.label5.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
			this.label5.Location = new System.Drawing.Point(185, 181);
			this.label5.Name = "label5";
			this.label5.Size = new System.Drawing.Size(36, 15);
			this.label5.TabIndex = 4;
			this.label5.Text = "CGPA";
			// 
			// label7
			// 
			this.label7.AutoSize = true;
			this.label7.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
			this.label7.Location = new System.Drawing.Point(13, 126);
			this.label7.Name = "label7";
			this.label7.Size = new System.Drawing.Size(50, 15);
			this.label7.TabIndex = 6;
			this.label7.Text = "Campus";
			// 
			// label4
			// 
			this.label4.AutoSize = true;
			this.label4.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
			this.label4.Location = new System.Drawing.Point(13, 181);
			this.label4.Name = "label4";
			this.label4.Size = new System.Drawing.Size(29, 15);
			this.label4.TabIndex = 3;
			this.label4.Text = "Year";
			// 
			// label6
			// 
			this.label6.AutoSize = true;
			this.label6.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold);
			this.label6.Location = new System.Drawing.Point(13, 66);
			this.label6.Name = "label6";
			this.label6.Size = new System.Drawing.Size(44, 15);
			this.label6.TabIndex = 5;
			this.label6.Text = "Branch";
			// 
			// UpdateDeleteForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 27F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.BackColor = System.Drawing.Color.White;
			this.ClientSize = new System.Drawing.Size(731, 451);
			this.Controls.Add(this.splitContainer1);
			this.Font = new System.Drawing.Font("Segoe MDL2 Assets", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
			this.Name = "UpdateDeleteForm";
			this.Text = "Form1";
			this.Load += new System.EventHandler(this.UpdateDeleteForm_Load);
			this.splitContainer1.Panel1.ResumeLayout(false);
			this.splitContainer1.Panel1.PerformLayout();
			this.splitContainer1.Panel2.ResumeLayout(false);
			((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
			this.splitContainer1.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			this.groupBox2.ResumeLayout(false);
			this.groupBox2.PerformLayout();
			this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Label UpdatStudentDetailsLabel;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox lastNameBox;
        private System.Windows.Forms.TextBox firstNameBox;
        private System.Windows.Forms.TextBox studentIDBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox cgpaBox;
        private System.Windows.Forms.ComboBox yearBox;
        private System.Windows.Forms.ComboBox campusBox;
        private System.Windows.Forms.ComboBox branchBox;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button UpdateDetailsButton;
        private System.Windows.Forms.Button CancelButton;
    }
}