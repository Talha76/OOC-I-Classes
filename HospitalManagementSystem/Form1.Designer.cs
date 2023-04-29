namespace HospitalManagementSystem
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
            this.label1 = new System.Windows.Forms.Label();
            this.PatientName = new System.Windows.Forms.TextBox();
            this.PatientID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.admitPatient = new System.Windows.Forms.Button();
            this.PatientAdmissionDate = new System.Windows.Forms.DateTimePicker();
            this.PatientDisease = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Patient Name:";
            // 
            // PatientName
            // 
            this.PatientName.Location = new System.Drawing.Point(144, 32);
            this.PatientName.Name = "PatientName";
            this.PatientName.Size = new System.Drawing.Size(100, 26);
            this.PatientName.TabIndex = 1;
            // 
            // PatientID
            // 
            this.PatientID.Location = new System.Drawing.Point(144, 74);
            this.PatientID.Name = "PatientID";
            this.PatientID.Size = new System.Drawing.Size(100, 26);
            this.PatientID.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Patient ID:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Admission Date:";
            // 
            // admitPatient
            // 
            this.admitPatient.Location = new System.Drawing.Point(88, 226);
            this.admitPatient.Name = "admitPatient";
            this.admitPatient.Size = new System.Drawing.Size(75, 33);
            this.admitPatient.TabIndex = 6;
            this.admitPatient.Text = "Admit";
            this.admitPatient.UseVisualStyleBackColor = true;
            this.admitPatient.Click += new System.EventHandler(this.admitPatient_Click);
            // 
            // PatientAdmissionDate
            // 
            this.PatientAdmissionDate.Location = new System.Drawing.Point(143, 160);
            this.PatientAdmissionDate.Name = "PatientAdmissionDate";
            this.PatientAdmissionDate.Size = new System.Drawing.Size(100, 26);
            this.PatientAdmissionDate.TabIndex = 7;
            // 
            // PatientDisease
            // 
            this.PatientDisease.Location = new System.Drawing.Point(144, 122);
            this.PatientDisease.Name = "PatientDisease";
            this.PatientDisease.Size = new System.Drawing.Size(100, 26);
            this.PatientDisease.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 122);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Disease:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 548);
            this.Controls.Add(this.PatientDisease);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.PatientAdmissionDate);
            this.Controls.Add(this.admitPatient);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PatientID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PatientName);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox PatientName;
        private System.Windows.Forms.TextBox PatientID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button admitPatient;
        private System.Windows.Forms.DateTimePicker PatientAdmissionDate;
        private System.Windows.Forms.TextBox PatientDisease;
        private System.Windows.Forms.Label label4;
    }
}

