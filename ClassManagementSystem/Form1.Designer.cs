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
            this.addTeacherDesignation = new System.Windows.Forms.ComboBox();
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
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.addCourseButton = new System.Windows.Forms.Button();
            this.addCourseCode = new System.Windows.Forms.TextBox();
            this.addCourseName = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.assignCourseTeacherButton = new System.Windows.Forms.Button();
            this.assignCourseCode = new System.Windows.Forms.TextBox();
            this.assignCourseTeacherId = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.enrollCourseStudentButton = new System.Windows.Forms.Button();
            this.enrollCourseCode = new System.Windows.Forms.TextBox();
            this.enrollCourseStudentId = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.groupBox9 = new System.Windows.Forms.GroupBox();
            this.assignedCourseListbox = new System.Windows.Forms.ListBox();
            this.showAssignedCoursesButton = new System.Windows.Forms.Button();
            this.showAssignedCoursesTeacherId = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.groupBox10 = new System.Windows.Forms.GroupBox();
            this.enrolledCourseListbox = new System.Windows.Forms.ListBox();
            this.showEnrolledCourses = new System.Windows.Forms.Button();
            this.showEnrolledCoursesStudentId = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.groupBox9.SuspendLayout();
            this.groupBox10.SuspendLayout();
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
            this.label8.Size = new System.Drawing.Size(87, 20);
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
            this.showTeachersButton.Text = "Show Teachers";
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
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.addCourseButton);
            this.groupBox6.Controls.Add(this.addCourseCode);
            this.groupBox6.Controls.Add(this.addCourseName);
            this.groupBox6.Controls.Add(this.label13);
            this.groupBox6.Controls.Add(this.label14);
            this.groupBox6.Location = new System.Drawing.Point(789, 25);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(284, 151);
            this.groupBox6.TabIndex = 7;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Add Course";
            // 
            // addCourseButton
            // 
            this.addCourseButton.Location = new System.Drawing.Point(93, 107);
            this.addCourseButton.Name = "addCourseButton";
            this.addCourseButton.Size = new System.Drawing.Size(75, 29);
            this.addCourseButton.TabIndex = 9;
            this.addCourseButton.Text = "Add";
            this.addCourseButton.UseVisualStyleBackColor = true;
            // 
            // addCourseCode
            // 
            this.addCourseCode.Location = new System.Drawing.Point(164, 66);
            this.addCourseCode.Name = "addCourseCode";
            this.addCourseCode.Size = new System.Drawing.Size(100, 26);
            this.addCourseCode.TabIndex = 8;
            // 
            // addCourseName
            // 
            this.addCourseName.Location = new System.Drawing.Point(164, 30);
            this.addCourseName.Name = "addCourseName";
            this.addCourseName.Size = new System.Drawing.Size(100, 26);
            this.addCourseName.TabIndex = 5;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(20, 63);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(103, 20);
            this.label13.TabIndex = 7;
            this.label13.Text = "Course code:";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(20, 33);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(108, 20);
            this.label14.TabIndex = 6;
            this.label14.Text = "Course name:";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.assignCourseTeacherButton);
            this.groupBox7.Controls.Add(this.assignCourseCode);
            this.groupBox7.Controls.Add(this.assignCourseTeacherId);
            this.groupBox7.Controls.Add(this.label15);
            this.groupBox7.Controls.Add(this.label16);
            this.groupBox7.Location = new System.Drawing.Point(789, 197);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(284, 151);
            this.groupBox7.TabIndex = 10;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Assign Course to Teachers";
            // 
            // assignCourseTeacherButton
            // 
            this.assignCourseTeacherButton.Location = new System.Drawing.Point(93, 107);
            this.assignCourseTeacherButton.Name = "assignCourseTeacherButton";
            this.assignCourseTeacherButton.Size = new System.Drawing.Size(75, 29);
            this.assignCourseTeacherButton.TabIndex = 9;
            this.assignCourseTeacherButton.Text = "Assign";
            this.assignCourseTeacherButton.UseVisualStyleBackColor = true;
            // 
            // assignCourseCode
            // 
            this.assignCourseCode.Location = new System.Drawing.Point(164, 66);
            this.assignCourseCode.Name = "assignCourseCode";
            this.assignCourseCode.Size = new System.Drawing.Size(100, 26);
            this.assignCourseCode.TabIndex = 8;
            // 
            // assignCourseTeacherId
            // 
            this.assignCourseTeacherId.Location = new System.Drawing.Point(164, 30);
            this.assignCourseTeacherId.Name = "assignCourseTeacherId";
            this.assignCourseTeacherId.Size = new System.Drawing.Size(100, 26);
            this.assignCourseTeacherId.TabIndex = 5;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(20, 63);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(103, 20);
            this.label15.TabIndex = 7;
            this.label15.Text = "Course code:";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(20, 33);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(92, 20);
            this.label16.TabIndex = 6;
            this.label16.Text = "Teacher ID:";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.enrollCourseStudentButton);
            this.groupBox8.Controls.Add(this.enrollCourseCode);
            this.groupBox8.Controls.Add(this.enrollCourseStudentId);
            this.groupBox8.Controls.Add(this.label17);
            this.groupBox8.Controls.Add(this.label18);
            this.groupBox8.Location = new System.Drawing.Point(789, 378);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(284, 151);
            this.groupBox8.TabIndex = 10;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Enroll Course to Students";
            // 
            // enrollCourseStudentButton
            // 
            this.enrollCourseStudentButton.Location = new System.Drawing.Point(93, 107);
            this.enrollCourseStudentButton.Name = "enrollCourseStudentButton";
            this.enrollCourseStudentButton.Size = new System.Drawing.Size(75, 29);
            this.enrollCourseStudentButton.TabIndex = 9;
            this.enrollCourseStudentButton.Text = "Enroll";
            this.enrollCourseStudentButton.UseVisualStyleBackColor = true;
            // 
            // enrollCourseCode
            // 
            this.enrollCourseCode.Location = new System.Drawing.Point(164, 66);
            this.enrollCourseCode.Name = "enrollCourseCode";
            this.enrollCourseCode.Size = new System.Drawing.Size(100, 26);
            this.enrollCourseCode.TabIndex = 8;
            // 
            // enrollCourseStudentId
            // 
            this.enrollCourseStudentId.Location = new System.Drawing.Point(164, 30);
            this.enrollCourseStudentId.Name = "enrollCourseStudentId";
            this.enrollCourseStudentId.Size = new System.Drawing.Size(100, 26);
            this.enrollCourseStudentId.TabIndex = 5;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(20, 63);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(103, 20);
            this.label17.TabIndex = 7;
            this.label17.Text = "Course code:";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(20, 33);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(91, 20);
            this.label18.TabIndex = 6;
            this.label18.Text = "Student ID:";
            // 
            // groupBox9
            // 
            this.groupBox9.Controls.Add(this.assignedCourseListbox);
            this.groupBox9.Controls.Add(this.showAssignedCoursesButton);
            this.groupBox9.Controls.Add(this.showAssignedCoursesTeacherId);
            this.groupBox9.Controls.Add(this.label19);
            this.groupBox9.Location = new System.Drawing.Point(1094, 25);
            this.groupBox9.Name = "groupBox9";
            this.groupBox9.Size = new System.Drawing.Size(442, 305);
            this.groupBox9.TabIndex = 11;
            this.groupBox9.TabStop = false;
            this.groupBox9.Text = "Show Assigned Courses";
            // 
            // assignedCourseListbox
            // 
            this.assignedCourseListbox.FormattingEnabled = true;
            this.assignedCourseListbox.ItemHeight = 20;
            this.assignedCourseListbox.Location = new System.Drawing.Point(22, 110);
            this.assignedCourseListbox.Name = "assignedCourseListbox";
            this.assignedCourseListbox.Size = new System.Drawing.Size(398, 164);
            this.assignedCourseListbox.TabIndex = 5;
            // 
            // showAssignedCoursesButton
            // 
            this.showAssignedCoursesButton.Location = new System.Drawing.Point(140, 62);
            this.showAssignedCoursesButton.Name = "showAssignedCoursesButton";
            this.showAssignedCoursesButton.Size = new System.Drawing.Size(133, 29);
            this.showAssignedCoursesButton.TabIndex = 4;
            this.showAssignedCoursesButton.Text = "Show Courses";
            this.showAssignedCoursesButton.UseVisualStyleBackColor = true;
            // 
            // showAssignedCoursesTeacherId
            // 
            this.showAssignedCoursesTeacherId.Location = new System.Drawing.Point(233, 30);
            this.showAssignedCoursesTeacherId.Name = "showAssignedCoursesTeacherId";
            this.showAssignedCoursesTeacherId.Size = new System.Drawing.Size(100, 26);
            this.showAssignedCoursesTeacherId.TabIndex = 3;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(90, 33);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(92, 20);
            this.label19.TabIndex = 2;
            this.label19.Text = "Teacher ID:";
            // 
            // groupBox10
            // 
            this.groupBox10.Controls.Add(this.enrolledCourseListbox);
            this.groupBox10.Controls.Add(this.showEnrolledCourses);
            this.groupBox10.Controls.Add(this.showEnrolledCoursesStudentId);
            this.groupBox10.Controls.Add(this.label20);
            this.groupBox10.Location = new System.Drawing.Point(1094, 357);
            this.groupBox10.Name = "groupBox10";
            this.groupBox10.Size = new System.Drawing.Size(442, 326);
            this.groupBox10.TabIndex = 7;
            this.groupBox10.TabStop = false;
            this.groupBox10.Text = "Show Enrolled Courses";
            // 
            // enrolledCourseListbox
            // 
            this.enrolledCourseListbox.FormattingEnabled = true;
            this.enrolledCourseListbox.ItemHeight = 20;
            this.enrolledCourseListbox.Location = new System.Drawing.Point(22, 110);
            this.enrolledCourseListbox.Name = "enrolledCourseListbox";
            this.enrolledCourseListbox.Size = new System.Drawing.Size(398, 184);
            this.enrolledCourseListbox.TabIndex = 5;
            // 
            // showEnrolledCourses
            // 
            this.showEnrolledCourses.Location = new System.Drawing.Point(140, 62);
            this.showEnrolledCourses.Name = "showEnrolledCourses";
            this.showEnrolledCourses.Size = new System.Drawing.Size(133, 29);
            this.showEnrolledCourses.TabIndex = 4;
            this.showEnrolledCourses.Text = "Show Courses:";
            this.showEnrolledCourses.UseVisualStyleBackColor = true;
            // 
            // showEnrolledCoursesStudentId
            // 
            this.showEnrolledCoursesStudentId.Location = new System.Drawing.Point(233, 30);
            this.showEnrolledCoursesStudentId.Name = "showEnrolledCoursesStudentId";
            this.showEnrolledCoursesStudentId.Size = new System.Drawing.Size(100, 26);
            this.showEnrolledCoursesStudentId.TabIndex = 3;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(90, 33);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(91, 20);
            this.label20.TabIndex = 2;
            this.label20.Text = "Student ID:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1560, 713);
            this.Controls.Add(this.groupBox10);
            this.Controls.Add(this.groupBox9);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
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
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.groupBox9.ResumeLayout(false);
            this.groupBox9.PerformLayout();
            this.groupBox10.ResumeLayout(false);
            this.groupBox10.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button addCourseButton;
        private System.Windows.Forms.TextBox addCourseCode;
        private System.Windows.Forms.TextBox addCourseName;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.Button assignCourseTeacherButton;
        private System.Windows.Forms.TextBox assignCourseCode;
        private System.Windows.Forms.TextBox assignCourseTeacherId;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.Button enrollCourseStudentButton;
        private System.Windows.Forms.TextBox enrollCourseCode;
        private System.Windows.Forms.TextBox enrollCourseStudentId;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.GroupBox groupBox9;
        private System.Windows.Forms.ListBox assignedCourseListbox;
        private System.Windows.Forms.Button showAssignedCoursesButton;
        private System.Windows.Forms.TextBox showAssignedCoursesTeacherId;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.GroupBox groupBox10;
        private System.Windows.Forms.ListBox enrolledCourseListbox;
        private System.Windows.Forms.Button showEnrolledCourses;
        private System.Windows.Forms.TextBox showEnrolledCoursesStudentId;
        private System.Windows.Forms.Label label20;
    }
}

