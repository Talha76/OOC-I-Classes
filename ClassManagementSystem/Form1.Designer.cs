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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.addDeptName = new System.Windows.Forms.TextBox();
            this.addDeptCode = new System.Windows.Forms.TextBox();
            this.addDept = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.addStudentButton = new System.Windows.Forms.Button();
            this.addStudentName = new System.Windows.Forms.TextBox();
            this.addStudentId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.addStudentDeptCode = new System.Windows.Forms.TextBox();
            this.addStudentSection = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.showStudentsButton = new System.Windows.Forms.Button();
            this.showStudentsDeptCode = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.studentsListbox = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
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
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(213, 30);
            this.label1.TabIndex = 1;
            this.label1.Text = "Department name:";
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
            // addDeptName
            // 
            this.addDeptName.Location = new System.Drawing.Point(160, 33);
            this.addDeptName.Name = "addDeptName";
            this.addDeptName.Size = new System.Drawing.Size(100, 26);
            this.addDeptName.TabIndex = 1;
            // 
            // addDeptCode
            // 
            this.addDeptCode.Location = new System.Drawing.Point(160, 69);
            this.addDeptCode.Name = "addDeptCode";
            this.addDeptCode.Size = new System.Drawing.Size(100, 26);
            this.addDeptCode.TabIndex = 3;
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
            this.label3.Size = new System.Drawing.Size(83, 30);
            this.label3.TabIndex = 2;
            this.label3.Text = "Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 36);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 30);
            this.label4.TabIndex = 1;
            this.label4.Text = "Student ID:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(16, 96);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(206, 30);
            this.label5.TabIndex = 5;
            this.label5.Text = "Department code:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(16, 125);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(101, 30);
            this.label6.TabIndex = 6;
            this.label6.Text = "Section:";
            // 
            // addStudentDeptCode
            // 
            this.addStudentDeptCode.Location = new System.Drawing.Point(160, 96);
            this.addStudentDeptCode.Name = "addStudentDeptCode";
            this.addStudentDeptCode.Size = new System.Drawing.Size(100, 26);
            this.addStudentDeptCode.TabIndex = 7;
            // 
            // addStudentSection
            // 
            this.addStudentSection.Location = new System.Drawing.Point(160, 128);
            this.addStudentSection.Name = "addStudentSection";
            this.addStudentSection.Size = new System.Drawing.Size(100, 26);
            this.addStudentSection.TabIndex = 8;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.studentsListbox);
            this.groupBox3.Controls.Add(this.showStudentsButton);
            this.groupBox3.Controls.Add(this.showStudentsDeptCode);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(331, 25);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(442, 397);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Show Students List";
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
            // studentsListbox
            // 
            this.studentsListbox.FormattingEnabled = true;
            this.studentsListbox.ItemHeight = 20;
            this.studentsListbox.Location = new System.Drawing.Point(22, 110);
            this.studentsListbox.Name = "studentsListbox";
            this.studentsListbox.Size = new System.Drawing.Size(398, 264);
            this.studentsListbox.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
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
    }
}

