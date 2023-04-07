namespace ClassManagementSystem
{
    partial class Form1
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.addDept = new System.Windows.Forms.Button();
            this.addDeptCode = new System.Windows.Forms.TextBox();
            this.addDeptName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.addStudentSection = new System.Windows.Forms.TextBox();
            this.addStudentDeptCode = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.addStudentButton = new System.Windows.Forms.Button();
            this.addStudentName = new System.Windows.Forms.TextBox();
            this.addStudentId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.studentsListbox = new System.Windows.Forms.ListBox();
            this.showStudentsButton = new System.Windows.Forms.Button();
            this.showStudentsDeptCode = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.addTeacherDeptCode = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.addTeacherButton = new System.Windows.Forms.Button();
            this.addTeacherId = new System.Windows.Forms.TextBox();
            this.addTeacherName = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.showTeachersListbox = new System.Windows.Forms.ListBox();
            this.showTeachersButton = new System.Windows.Forms.Button();
            this.showTeachersDeptCode = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.addTeacherDesignation = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.addDept);
            this.groupBox1.Controls.Add(this.addDeptCode);
            this.groupBox1.Controls.Add(this.addDeptName);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(26, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(282, 151);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Add Department";
            // 
            // addDept
            // 
            this.addDept.Location = new System.Drawing.Point(89, 110);
            this.addDept.Name = "addDept";
            this.addDept.Size = new System.Drawing.Size(75, 29);
            this.addDept.TabIndex = 4;
            this.addDept.Text = "Add";
            this.addDept.UseVisualStyleBackColor = true;
            this.addDept.Click += new System.EventHandler(this.addDept_Click);
            // 
            // addDeptCode
            // 
            this.addDeptCode.Location = new System.Drawing.Point(160, 69);
            this.addDeptCode.Name = "addDeptCode";
            this.addDeptCode.Size = new System.Drawing.Size(100, 26);
            this.addDeptCode.TabIndex = 3;
            // 
            // addDeptName
            // 
            this.addDeptName.Location = new System.Drawing.Point(160, 33);
            this.addDeptName.Name = "addDeptName";
            this.addDeptName.Size = new System.Drawing.Size(100, 26);
            this.addDeptName.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Department code:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Department name:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.addStudentSection);
            this.groupBox2.Controls.Add(this.addStudentDeptCode);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.addStudentButton);
            this.groupBox2.Controls.Add(this.addStudentName);
            this.groupBox2.Controls.Add(this.addStudentId);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(26, 197);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(282, 225);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Add Student";
            // 
            // addStudentSection
            // 
            this.addStudentSection.Location = new System.Drawing.Point(160, 128);
            this.addStudentSection.Name = "addStudentSection";
            this.addStudentSection.Size = new System.Drawing.Size(100, 26);
            this.addStudentSection.TabIndex = 8;
            // 
            // addStudentDeptCode
            // 
            this.addStudentDeptCode.Location = new System.Drawing.Point(160, 96);
            this.addStudentDeptCode.Name = "addStudentDeptCode";
            this.addStudentDeptCode.Size = new System.Drawing.Size(100, 26);
            this.addStudentDeptCode.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 20);
            this.label6.TabIndex = 6;
            this.label6.Text = "Section:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(137, 20);
            this.label5.TabIndex = 5;
            this.label5.Text = "Department code:";
            // 
            // addStudentButton
            // 
            this.addStudentButton.Location = new System.Drawing.Point(89, 181);
            this.addStudentButton.Name = "addStudentButton";
            this.addStudentButton.Size = new System.Drawing.Size(75, 29);
            this.addStudentButton.TabIndex = 4;
            this.addStudentButton.Text = "Add";
            this.addStudentButton.UseVisualStyleBackColor = true;
            this.addStudentButton.Click += new System.EventHandler(this.addStudentButton_Click);
            // 
            // addStudentName
            // 
            this.addStudentName.Location = new System.Drawing.Point(160, 65);
            this.addStudentName.Name = "addStudentName";
            this.addStudentName.Size = new System.Drawing.Size(100, 26);
            this.addStudentName.TabIndex = 3;
            // 
            // addStudentId
            // 
            this.addStudentId.Location = new System.Drawing.Point(160, 33);
            this.addStudentId.Name = "addStudentId";
            this.addStudentId.Size = new System.Drawing.Size(100, 26);
            this.addStudentId.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(91, 20);
            this.label4.TabIndex = 1;
            this.label4.Text = "Student ID:";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.studentsListbox);
            this.groupBox3.Controls.Add(this.showStudentsButton);
            this.groupBox3.Controls.Add(this.showStudentsDeptCode);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(331, 25);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(442, 305);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Show Students List";
            // 
            // studentsListbox
            // 
            this.studentsListbox.FormattingEnabled = true;
            this.studentsListbox.ItemHeight = 20;
            this.studentsListbox.Location = new System.Drawing.Point(22, 110);
            this.studentsListbox.Name = "studentsListbox";
            this.studentsListbox.Size = new System.Drawing.Size(398, 164);
            this.studentsListbox.TabIndex = 5;
            // 
            // showStudentsButton
            // 
            this.showStudentsButton.Location = new System.Drawing.Point(140, 62);
            this.showStudentsButton.Name = "showStudentsButton";
            this.showStudentsButton.Size = new System.Drawing.Size(133, 29);
            this.showStudentsButton.TabIndex = 4;
            this.showStudentsButton.Text = "Show Students";
            this.showStudentsButton.UseVisualStyleBackColor = true;
            this.showStudentsButton.Click += new System.EventHandler(this.showStudentsButton_Click);
            // 
            // showStudentsDeptCode
            // 
            this.showStudentsDeptCode.Location = new System.Drawing.Point(233, 30);
            this.showStudentsDeptCode.Name = "showStudentsDeptCode";
            this.showStudentsDeptCode.Size = new System.Drawing.Size(100, 26);
            this.showStudentsDeptCode.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(90, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(137, 20);
            this.label7.TabIndex = 2;
            this.label7.Text = "Department code:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.addTeacherDesignation);
            this.groupBox4.Controls.Add(this.addTeacherDeptCode);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.addTeacherButton);
            this.groupBox4.Controls.Add(this.addTeacherId);
            this.groupBox4.Controls.Add(this.addTeacherName);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Location = new System.Drawing.Point(26, 450);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(282, 233);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Add Teacher";
            // 
            // addTeacherDeptCode
            // 
            this.addTeacherDeptCode.Location = new System.Drawing.Point(160, 145);
            this.addTeacherDeptCode.Name = "addTeacherDeptCode";
            this.addTeacherDeptCode.Size = new System.Drawing.Size(100, 26);
            this.addTeacherDeptCode.TabIndex = 8;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(21, 145);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(137, 20);
            this.label11.TabIndex = 6;
            this.label11.Text = "Department code:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(6, 108);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(157, 20);
            this.label10.TabIndex = 5;
            this.label10.Text = "Teacher designation:";
            // 
            // addTeacherButton
            // 
            this.addTeacherButton.Location = new System.Drawing.Point(89, 182);
            this.addTeacherButton.Name = "addTeacherButton";
            this.addTeacherButton.Size = new System.Drawing.Size(75, 29);
            this.addTeacherButton.TabIndex = 4;
            this.addTeacherButton.Text = "Add";
            this.addTeacherButton.UseVisualStyleBackColor = true;
            this.addTeacherButton.Click += new System.EventHandler(this.addTeacherButton_Click);
            // 
            // addTeacherId
            // 
            this.addTeacherId.Location = new System.Drawing.Point(160, 69);
            this.addTeacherId.Name = "addTeacherId";
            this.addTeacherId.Size = new System.Drawing.Size(100, 26);
            this.addTeacherId.TabIndex = 3;
            // 
            // addTeacherName
            // 
            this.addTeacherName.Location = new System.Drawing.Point(160, 33);
            this.addTeacherName.Name = "addTeacherName";
            this.addTeacherName.Size = new System.Drawing.Size(100, 26);
            this.addTeacherName.TabIndex = 1;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 72);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(131, 30);
            this.label8.TabIndex = 2;
            this.label8.Text = "Teacher id:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 36);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(115, 20);
            this.label9.TabIndex = 1;
            this.label9.Text = "Teacher name:";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.showTeachersListbox);
            this.groupBox5.Controls.Add(this.showTeachersButton);
            this.groupBox5.Controls.Add(this.showTeachersDeptCode);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Location = new System.Drawing.Point(331, 357);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(442, 326);
            this.groupBox5.TabIndex = 6;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Show Teachers List";
            // 
            // showTeachersListbox
            // 
            this.showTeachersListbox.FormattingEnabled = true;
            this.showTeachersListbox.ItemHeight = 20;
            this.showTeachersListbox.Location = new System.Drawing.Point(22, 110);
            this.showTeachersListbox.Name = "showTeachersListbox";
            this.showTeachersListbox.Size = new System.Drawing.Size(398, 184);
            this.showTeachersListbox.TabIndex = 5;
            // 
            // showTeachersButton
            // 
            this.showTeachersButton.Location = new System.Drawing.Point(140, 62);
            this.showTeachersButton.Name = "showTeachersButton";
            this.showTeachersButton.Size = new System.Drawing.Size(133, 29);
            this.showTeachersButton.TabIndex = 4;
            this.showTeachersButton.Text = "Show Students";
            this.showTeachersButton.UseVisualStyleBackColor = true;
            // 
            // showTeachersDeptCode
            // 
            this.showTeachersDeptCode.Location = new System.Drawing.Point(233, 30);
            this.showTeachersDeptCode.Name = "showTeachersDeptCode";
            this.showTeachersDeptCode.Size = new System.Drawing.Size(100, 26);
            this.showTeachersDeptCode.TabIndex = 3;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(90, 33);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(137, 20);
            this.label12.TabIndex = 2;
            this.label12.Text = "Department code:";
            // 
            // addTeacherDesignation
            // 
            this.addTeacherDesignation.FormattingEnabled = true;
            this.addTeacherDesignation.Items.AddRange(new object[] {
            "Lecturer",
            "Professor"});
            this.addTeacherDesignation.Location = new System.Drawing.Point(161, 108);
            this.addTeacherDesignation.Name = "addTeacherDesignation";
            this.addTeacherDesignation.Size = new System.Drawing.Size(99, 28);
            this.addTeacherDesignation.TabIndex = 9;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 713);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button addDept;
        private System.Windows.Forms.TextBox addDeptCode;
        private System.Windows.Forms.TextBox addDeptName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox addStudentSection;
        private System.Windows.Forms.TextBox addStudentDeptCode;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button addStudentButton;
        private System.Windows.Forms.TextBox addStudentName;
        private System.Windows.Forms.TextBox addStudentId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button showStudentsButton;
        private System.Windows.Forms.TextBox showStudentsDeptCode;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ListBox studentsListbox;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button addTeacherButton;
        private System.Windows.Forms.TextBox addTeacherId;
        private System.Windows.Forms.TextBox addTeacherName;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox addTeacherDeptCode;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.ListBox showTeachersListbox;
        private System.Windows.Forms.Button showTeachersButton;
        private System.Windows.Forms.TextBox showTeachersDeptCode;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox addTeacherDesignation;
    }
}

